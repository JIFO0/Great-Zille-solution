# Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation

- **ID konwersacji:** `567`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/567_Run_Romus_Run!_Conversation.md`
- **Liczba węzłów dialogowych:** 680
- **Liczba wyborów gracza:** 104

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[85]** Sevrio Castellanus
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Rusty`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Hugo_LargerYourQuarry`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Rusty_Allied`
- `RiziaDLC.Rusty_PalantorPMCAvailable`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn09_TalkWithTitus_SecretTunnel`
- `RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare`
- `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal`
- `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives`
- `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom`
- `RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable`
- `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch`
- `RiziaDLCIsolated.Birthday_Gathering_PickUpGun`
- `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency`
- `RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.Epilogue_Death_KilledByMob`
- `RiziaDLC.Epilogue_Death_ShotFromAbove`
- `RiziaDLC.Epilogue_Prison_HouseFallouts`
- `RiziaDLC.Epilogue_Survived_BirthdayStrike`
- `RiziaDLC.Epilogue_Survived_RevolutionaryFail`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal`
- `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives`
- `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom`
- `RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable`
- `RiziaDLCIsolated.Birthday_Gathering_PickUpGun`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_FrontDoor`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom_TitusRescue`
- `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunnel`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[566] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation** (../Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md), Węzeł `[11]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 32

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[116]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] = true;`
- Węzeł `[137]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] = true;`
- Węzeł `[296]` (Paskal Beniwoll): `--;`
- Węzeł `[398]` (Paskal Beniwoll): `AddConversant("Adarfo Sotelato"); ;`
- Węzeł `[399]` (Paskal Beniwoll): `AddConversant("Adarfo Sotelato"); ;`
- Węzeł `[405]` (Paskal Beniwoll): `RemoveConversant("Adarfo Sotelato"); ;`
- Węzeł `[452]` (Paskal Beniwoll): `RemoveConversant("Adarfo Sotelato"); ;`
- Węzeł `[479]` (Paskal Beniwoll): `RemoveConversant("Adarfo Sotelato"); ;`
- *...oraz 24 innych węzłów ze skryptami.*

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
  - -> `[625]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `566` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation*), Węzeł `[11]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "Escape through secret tunnel."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the archive level within the bowels of the library."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Take spiral staircase to roof."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the spiral staircase in the back of the main hall. From there, I could reach the rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "Leave through front entrance."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the front entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[6]`
Mówca: **Narrator**
> "It would be a tight fit, but from there I could access the secret tunnel that ran between the library and the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Everything blurred past as I ran into the main hall darting between bookshelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I stopped when I spotted two House security guards crouched behind an overturned table, exchanging gunfire with the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Dash across the open space toward the exit."]** — Mówca: **Player_Romus_Italic**
> "I made a mad dash across the open space toward the exit. Adrenaline surged as my heart pounded in my chest while I pushed forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Create a distraction by knocking over a nearby vase."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the guards' attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Hide behind a bookshelf and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I hid behind a bookshelf, deciding it was best to hold my position and wait for reinforcements."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[15]`
Mówca: **Narrator**
> "With their backs momentarily turned, I had a clear path between the massive shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Deafening gunfire erupted all around me, but I kept moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Scattered books, toppled chairs, and torn decorations created a maze of potential cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[50]`
  - -> `[495]`
  - -> `[236]`

### Węzeł `[18]`
Mówca: **Narrator**
> "With their focus on the firefight, I was now just a few feet away from my escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Hold position and wait for the nearby gunfight to subside."]** — Mówca: **Player_Romus_Italic**
> "I decided it was best to hold my position and wait for the gunfight to subside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "Make a direct run to your goal."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted towards my goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "Despite my close proximity to the door, I doubled back to find an alternate escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several House guards ran past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Use the assault rifle."]** — Mówca: **Player_Romus_Italic**
> "I reached out and grabbed the assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[24]`
Mówca: **Narrator**
> "I spotted several Golden Guardsmen positioned near a bookshelf, exchanging gunfire with House security forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Everything blurred past as I darted between bookshelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Deafening gunfire erupted all around me, but I kept moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "Move underneath central reading table."]** — Mówca: **Player_Romus_Italic**
> "I dove underneath a massive central reading table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "Sprint directly toward the spiral staircase."]** — Mówca: **Player_Romus_Italic**
> "Without a second thought, I sprinted directly toward the spiral staircase. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Use a fallen bookshelf as cover and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I used a fallen bookshelf as cover, judging it was best to hold my position and wait for reinforcements."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Several shots immediately struck the top of the table, splintering wood and sending fragments flying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "I was safely protected, but crawling out would mean stepping into the line of fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[34]`
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "Wait for a lull in the gunfire."]** — Mówca: **Player_Romus_Italic**
> "I decided to hunker down and wait for a lull in the gunfire. However, as I did, the situation for my guardsmen seemed to get worse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Quickly dash to the nearest book stack."]** — Mówca: **Player_Romus_Italic**
> "I quickly dashed to the nearest book stack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "Kick over a nearby chair to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I kicked over a nearby chair to create a distraction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "As it clattered across the floor, guards momentarily redirected their attention, allowing me a clear path to get away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "Duck and weave through the book stacks."]** — Mówca: **Player_Romus_Italic**
> "I ducked and weaved my way through the bookstack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Before long, I was just a few feet away from the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Dash to the staircase."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I dashed for the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Just my luck, it kept me concealed, and before long, the spiral staircase came into view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "I rushed upward, the dizzying speed of my ascent distorting the frenzy below as I escaped the library’s violent interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[41]`
Mówca: **Narrator**
> "The nearest access was a dumbwaiter, once used to transport books and documents, tucked near the entrance behind the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[42]`
Mówca: **Narrator**
> "The library's pristine interior was now a war zone, with research materials and broken furniture creating a treacherous landscape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[43]`
Mówca: **Narrator**
> "The library's pristine interior was now a war zone, with research materials and broken furniture creating a treacherous landscape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[44]`
Mówca: **Narrator**
> "My eyes were then drawn to a nearby dead guard, still clutching his assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[45]`
Mówca: **Narrator**
> "As I did, memories from my time at the military academy came rushing back. Instinctively, I took aim, steadying the sights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the House security guards dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[47]`
Mówca: **Narrator**
> "The second guard barely had time to react, scrambling to reposition, but the Wruhec's Guardians finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Move along the wall's edge."]** — Mówca: **Player_Romus_Italic**
> "I began carefully moving along the wall’s edge, each step measured and deliberate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Mad dash across the open space toward the exit."]** — Mówca: **Player_Romus_Italic**
> "With the immediate threat eliminated, I made a mad dash across the open space toward the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Hold position and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I stayed put, deciding it was best to hold my position and wait for reinforcements."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[51]`
Mówca: **Narrator**
> "My heart pounded in my chest as I did. But just as I reached the halfway point, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[52]`
Mówca: **Narrator**
> "My eyes constantly darted between the shelves and the balcony above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I spotted a guard standing on the second level, his attention focused elsewhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[60]`
  - -> `[266]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Shoot at guard."]** — Mówca: **Player_Romus_Italic**
> "My finger tightened around the trigger, and a series of shots rang out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pushed forward, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[56]`
Mówca: **Narrator**
> "I missed, the bullets slamming into the bookshelf beside him. Startled, the guard retreated, clearing my path to the front of the library."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "I was now just a few agonizing feet away from my escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[58]`
  - -> `[144]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Resume crawling toward your goal."]** — Mówca: **Player_Romus_Italic**
> "Heart pounding in my chest, I resumed my crawl toward my goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Then, to my horror, several House security guards, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "Wait for guard to turn."]** — Mówca: **Player_Romus_Italic**
> "So I waited for what felt like an eternity until the guard turned away. Seizing the moment, I bolted for my exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "Wait for the nearby gunfight to subside."]** — Mówca: **Player_Romus_Italic**
> "After an agonizing wait, the gunfire eventually subsided, but it was unclear what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[62]`
Mówca: **Narrator**
> "They demanded that I drop my weapon and surrender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "Drop weapon and surrender."]** — Mówca: **Player_Romus_Italic**
> "Realizing there was no way out, I dropped my weapon and threw my hands in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "Fire weapon."]** — Mówca: **Player_Romus_Italic**
> "I raised my weapon and fired, but before I could fire again, searing pain tore through my side, then my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[65]`
Mówca: **Narrator**
> "I soon found myself with my hands tied behind my back as I was taken into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Vina and Mother were both frozen in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I looked at Mother. She was frozen in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[71]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Taddeus approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Hugo approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Angelica approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[83]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Leona approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Leona Sazon**
> ""You had to go after us. You couldn't leave well enough alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[85]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Monarchy_Meets_Muzzle_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET OUT OF THE WAY!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""You're half the man your father was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is for you not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[93]`
Mówca: **Angelica Sazon**
> ""You're worse than Lucas. Prison is too good for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[94]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[95]`
Mówca: **Narrator**
> "My body jerked with each impact, the air knocked from my lungs. My legs gave out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[96]`
Mówca: **Narrator**
> "They were blocking my way, and the local police standing between us were barely enough to hold them back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[117]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Fire gun into the air."]** — Mówca: **Player_Romus_Italic**
> "I raised my weapon and fired a single shot into the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Narrator**
> "When the crowd realized I was wielding a rifle, they slowly, but surely made a path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Narrator**
> "I stumbled out of the library doors to an angry mob that had filled the square, shouting and jeering at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Fear rippled through the crowd, and scattered in all directions, giving me the opening I needed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Spotting my motorcade nearby, I ran for it and dove into the nearest car. The moment I was in, we sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "My plans had unraveled, but at least I'd escaped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[103]`
Mówca: **Narrator**
> "The library doors slammed shut behind me as I stumbled into the street. To my relief, there was no immediate threat waiting to pounce."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Narrator**
> "But just before I reached the doors, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Ah_Shoot_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ah_Shoot_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[107]`
Mówca: **Narrator**
> "I had been spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I pushed forward, adrenaline rushing through me, but my quick motion drew his gaze. He whipped around and fired several shots that barely missed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[109]`
Mówca: **Narrator**
> "I didn't stop until I was through the doorway and into the safety of the hallway, breathless but still alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Eventually, the sounds of the battle gradually began to fad. My pulse slowed as an unsettling thought crept in..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "No one was coming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[112]`
  - -> `[153]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "Stay put."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay put, trusting my guards to get the situation under control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BarrelOfTrouble_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Adrenaline surged as I pushed forward. Fortunately, my foes were too preoccupied with the battle at hand to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[115]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the safety of the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_PickUpGun = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[90]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[120]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""MOVE ASIDE! NOW!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Barrel through the crowd."]** — Mówca: **Player_Romus_Italic**
> "I pushed forward, barreling through the wall of people, but they swarmed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "Go back inside."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk putting myself at the mercy of an angry mob, I turned around and went back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "I made my way down the hall until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[125]`
Mówca: **Narrator**
> "Fists and feet rained down in a relentless barrage until my legs buckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "Use the assault rifle."]** — Mówca: **Player_Romus_Italic**
> "Despite my limited experience with such a weapon, I reached out and grabbed the assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "So I took aim, steadying the sights as best I could. A crack of gunfire rang out as I squeezed the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[131]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The guards immediately turned, their eyes locking onto me as they raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "A sharp pain shot through my body, but I forced myself to remain standing. And then another shot rang out, and my legs immediately gave out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Monarchy_Meets_Muzzle_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[134]`
Mówca: **Narrator**
> "But just as I reached the halfway point, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ah_Shoot_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "Crawl out and move along the wall's edge."]** — Mówca: **Player_Romus_Italic**
> "I slowly crawled out from under the table, reached the wall, and began moving along its edge, each step measured and deliberate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "However, just before I reached the doors, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pressed onward, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "However, the guard returned and fired several shots in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ah_Shoot_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Adrenaline surged as I retraced my steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[148]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the safety of the hallway, breathless but alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[149]`
Mówca: **Narrator**
> "In an instant, a mass of people pushed past the row of officers and swarmed me in a wild frenzy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Eventually, the sounds of the battle began to fade. My pulse slowed as an unsettling thought crept in..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay where I was, trusting my guards to get the situation under control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "I decided to double back and find an alternate escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "Despite my close proximity to the door, I decided to double back and find an alternate escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[154]`
Mówca: **Narrator**
> "No one was coming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[566]`
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Before long the gunfire eventually subsided, but it was unclear what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[157]`
Mówca: **Narrator**
> "They demanded that I put my hands in the air and surrender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "Surrender."]** — Mówca: **Player_Romus_Italic**
> "Realizing my situation was hopeless, I raised my hands in surrender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Run."]** — Mówca: **Player_Romus_Italic**
> "I turned to run, but I barely made it three steps before a searing pain tore through my side, then my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Spotting the motorcade parked nearby, I hurried to another fire escape out of sight from the protesters and climbed down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Diving into the nearest car, we sped off the moment I was inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Narrator**
> "Flat on my back, I stared at the sky, unable to move or breathe as an eerie numbness spread through me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
Mówca: **Narrator**
> "My plans may have unraveled, but at least I'd made it out alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[164]`
Mówca: **Narrator**
> "My fingers scraped the ledge before I plummeted into the alley below, the motorcade vanishing from view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Monarchy_Meets_Muzzle_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "Go down the alley."]** — Mówca: **Player_Romus_Italic**
> "The alley was narrow and rough, lined with shady figures who eyed me warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Narrator**
> "As I made my way forward, I spotted my motorcade. But just as I neared it, a shout pierced the air -- then another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Narrator**
> "I kept my head down, pushing forward through the darkness until I emerged on the other side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "There, parked nearby, was my motorcade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Before I could react, I was swarmed by protesters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[174]`
Mówca: **Narrator**
> "I kept my head down and stepped into the street, blending seamlessly with the flow of pedestrians. No one seemed to notice me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Ahead, I spotted my motorcade, parked and waiting. I made my way over and casually stepped into the nearest car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[176]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Squeezing inside, I hit the button, and it groaned to life, slowly lowering me down a dark shaft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "When it stopped, I struggled with the basement panels, finally prying them open and stumbling into the dimly lit space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "I made my way down a narrow aisle of archival books.  At the end, I found an old rolling shelf Titus told me about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Narrator**
> "My sense of direction slipped away as I lost all sense of time, until finally, I emerged deep within the palace grounds, disoriented but free."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[181]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the safety of the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[182]`
Mówca: **Narrator**
> "The moment I was inside, we sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "Step inside tunnel."]** — Mówca: **Player_Romus_Italic**
> "I stepped inside the tunnel, swallowed by darkness. With no light to guide me, I moved blindly, the walls closing in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Sliding it aside revealed the hidden passageway, where I was greeted by the musty smell of stale air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "Hide."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk the dangers of the tunnel,  I changed my mind and searched for a secluded spot among the rows of dusty shelves. I lost all sense of time as I stayed out of sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "Double back to the library."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk the dangers of the tunnel,  I changed my mind and retreated up a back stairwell until I reemerged into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[188]`
Mówca: **Narrator**
> ""Go! We'll cover you!" they yelled, as bullets rained all around them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[191]`
  - -> `[570]`
  - -> `[152]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "Run for the stairs."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the stairs. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[190]`
**[WYBÓR GRACZA: "Push nearby book cart toward House security."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the House security guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "Hold position and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I held my position, deciding it was best to wait for backup."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[192]`
Mówca: **Narrator**
> "And just when escape felt within reach, both Guardsmen were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[193]`
Mówca: **Narrator**
> "It crashed into a nearby bookshelf, sending dozens of books down on top of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[194]`
Mówca: **Narrator**
> "The guards were momentarily distracted, giving the Golden Guard the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Pain shot through my body, but I forced myself to remain standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Then another shot rang out, and my legs immediately gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "I doubled back, unwilling to take that risk, and searched for an alternate escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[199]`
Mówca: **Narrator**
> "As I retracted my steps, the gunfire eventually subsided, but it was unclear what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[200]`
Mówca: **Narrator**
> "However, I was soon spotted, and a guard unleashed a volley of shots in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[201]`
Mówca: **Narrator**
> "I made my way down the stairs until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[202]`
Mówca: **Narrator**
> "Adrenaline surged through my veins. Before long, one of them noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[203]`
Mówca: **Narrator**
> "With the men providing cover, I eventually made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[204]`
Mówca: **Narrator**
> "The cool night air greeted me as I spilled out from the rooftop exit and hurried to the fire escape leading down to the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Looking up, my eyes fixed on a nearby building across from the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "Leap to nearest rooftop."]** — Mówca: **Player_Romus_Italic**
> "I decided to take the leap to the nearest rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "Take fire escape."]** — Mówca: **Player_Romus_Italic**
> "I quickly descended the fire escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "Go back inside."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk putting myself at the mercy of an angry mob or falling to my death, I turned around and went back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Seizing the moment, I dashed for the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[213]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Monarchy_Meets_Muzzle_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[215]`
Mówca: **Narrator**
> "I had been spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[219]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack rang out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "Run for the stairs."]** — Mówca: **Player_Romus_Italic**
> "I ran for the stairs. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
Mówca: **Narrator**
> "From this vantage, I could see the angry mob of protesters down below, yelling and jeering anti-Crown sentiments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Pushing past the ache in my leg, I sprinted and leapt for the opposite rooftop, but the pain wrenched mid-air, and I stumbled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Taking a deep breath, I stepped back, then sprinted and leapt across the alley, landing hard but steady on the opposite rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[228]`
**[WYBÓR GRACZA: "Run for the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the dumbwaiter. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[229]`
Mówca: **Narrator**
> "I could either take my chances in the alley or head into the street, blending in with the crowd to avoid being spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[262]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Archive _Jump_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Archive _Jump_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "Dash across the open space toward the front desk."]** — Mówca: **Player_Romus_Italic**
> "I made a mad dash across the open space toward the front desk. Adrenaline surged as my heart pounded in my chest while I pushed forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[239]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[240]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[241]`
Mówca: **Narrator**
> "But just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "Dash across the open space toward the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "With the immediate threat eliminated I made a mad dash across the open space toward the dumbwaiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[243]`
Mówca: **Narrator**
> "After what felt like an eternity, I made it behind the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[244]`
Mówca: **Narrator**
> "After what felt like an eternity, I made it behind the librarian's desk, breathless but still alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[251]`
Mówca: **Narrator**
> "My heart pounded in my chest as I did. But just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Dumbwaiter_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Narrator**
> "I slid back an unassuming wooden panel on the back wall, revealing a dumbwaiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[260]`
Mówca: **Narrator**
> "From this vantage point, I could see the usual street scene below, with people going about their business, unaware of turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Narrator**
> "I spotted my motorcade parked nearby as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "Head into the street."]** — Mówca: **Player_Romus_Italic**
> "I kept my head down and stepped into the street, weaving through the crowd, careful not to draw attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[263]`
Mówca: **Narrator**
> "I wasn't as athletic as I once was, especially after the injury I sustained from my kidnapping years ago, but it seemed within jumping distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[264]`
Mówca: **Narrator**
> "I wasn't as athletic as I used to be, but it appeared to be within jumping distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "Run for the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the dumbwaiter. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[272]`
Mówca: **Narrator**
> "The main entrance was the most direct route out of the library, and closest to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Narrator**
> "But that would mean having to get past the checkpoint Titus spoke of -- if anyone was still manning it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol"] == true  or Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol"] == true  or Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Not to mention, risking a confrontation with the protesters gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[281]`
Mówca: **Narrator**
> "It was the most heavily guarded, but if the unrest caused the guards to leave their posts, the entrance would be temporarily vulnerable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Narrator**
> "However, I'd also have to risk a confrontation with the protesters gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Narrator**
> "The was also the rooftop evacuation route that Titus briefed me on. From there I could take the fire escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Narrator**
> "I could also try to make it up to the rooftop, though I didn't know where I'd be able to go from there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Narrator**
> "My only other option was to get to the basement archive level and take the secret tunnel that connected the library and the Palace -- that or make it to the closest designated safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Narrator**
> "My only other option was to get to the basement archive level and take the secret tunnel that connected the library and the Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[4]`
  - -> `[299]`
  - -> `[661]`

### Węzeł `[297]`
**[WYBÓR GRACZA: "Flee to nearest safe room."]** — Mówca: **Player_Romus_Italic**
> "I decided to flee to the nearest safe room, the book vault, tucked just behind the spiral staircase in the back of the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[298]`
Mówca: **Narrator**
> "Built as a space for rare books and private collections, its reinforced doors and secure locks would hold up until the threat was neutralized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
**[WYBÓR GRACZA: "Sprint directly toward the book vault."]** — Mówca: **Player_Romus_Italic**
> "Without a second thought, I sprinted directly toward the book vault. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
**[WYBÓR GRACZA: "Run for the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the book vault. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
**[WYBÓR GRACZA: "Dash to the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I dashed for the book vault."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the vault door. With the combination clicked into place, I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Dumbwaiter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Dumbwaiter_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[320]`
Mówca: **Narrator**
> "I flicked on the light, revealing rows of old manuscripts and books, some hundreds of years old, stacked neatly on the shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[321]`
Mówca: **Narrator**
> "I sank into a chair, waiting for the upheaval outside to end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Minutes felt like hours, and before long, the gunfire subsided, and my solitude was interrupted by the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[323]`
Mówca: **Narrator**
> "My stomach sank when Titus, flanked by several Golden Guardsmen, stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[324]`
Mówca: **Narrator**
> "It hit me then that they obviously knew about the safe room and the combination to get in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[325]`
Mówca: **Titus Gordion**
> ""If you would be so kind as to step out of the vault and follow me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "I did as I was told. As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Vault_Caught_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or 
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or 
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[331]`
Mówca: **Narrator**
> "Hours passed in uneasy silence. Finally, the sound of the door unlocking broke through my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Narrator**
> "I looked up, expecting the worst, but instead, Titus stepped through the door, his face pale, bandages wrapped around his midsection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`
  - -> `[334]`
  - -> `[333]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! What happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh my God, Titus! Are you alright?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it safe to come out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What took you so long?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[337]`
Mówca: **Titus Gordion**
> ""The House forces overwhelmed us, but we called in reinforcements, and we have them at bay for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[344]`
  - -> `[343]`
  - -> `[348]`
  - -> `[353]`

### Węzeł `[338]`
Mówca: **Titus Gordion**
> ""A little banged up, but I'll manage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[339]`
Mówca: **Titus Gordion**
> ""As you can see, I had some... complications.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. Sorry we couldn't reach you sooner. As you can see, we had some... complications.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about my family?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Titus Gordion**
> ""Don't worry. They've been taken to a secure location. What's most important is getting you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you let this happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""Sometimes, no matter how much preparation you have, life has a way of throwing unexpected challenges your way. We did everything we could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Titus Gordion**
> ""But come, let's get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""No one could have predicted this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Titus Gordion**
> ""I'm sure we could arrange that, but right now, we need to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Next time, I’ll consider a more exclusive guest list. No need for the Houses to crash the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Titus Gordion**
> ""Good idea. But come, let's get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[355]`
Mówca: **Narrator**
> "Titus escorted me through the blood-streaked halls of the library, past fallen guards and intruders alike."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Narrator**
> "The motorcade stood ready as I stepped outside. Titus opened the door to the lead car, and once inside, we sped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[360]`
Mówca: **Narrator**
> "He kept a hand pressed firmly against his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Narrator**
> "Titus approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Narrator**
> "Titus approached with a hand pressed firmly against his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Titus Gordion**
> "“Your little insurrection has been crushed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[370]`
Mówca: **Titus Gordion**
> "“Adarfo’s dead, and your pathetic little rebellion has ended in failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""By the authority vested in me, I hereby declare King Romus is to be taken into custody for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Narrator**
> "I wanted more than anything to deny his accusation and protest his actions, but I didn't have the strength to resist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Vault_Caught_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[374]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[378]`
Mówca: **Narrator**
> "I unexpectedly crashed into Adarfo, who was taking cover under there as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[379]`
  - -> `[381]`
  - -> `[382]`
  - -> `[383]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trusted you, Adarfo. And this is where it’s led us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hiding now, are we? Not quite the leader of the revolution I envisioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Funny, isn't it? You wanted to topple a king, and here we are, both groveling in the dirt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe this is happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So how's your day going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Narrator**
> "Adarfo glared at me coldly, not saying a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[388]`
Mówca: **Adarfo Sotelato**
> ""Believe it! Your arrogance brought us to this moment. This is all your fault!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Adarfo Sotelato**
> ""Don’t mistake my position for defeat! You’ll answer for what you’ve done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Adarfo Sotelato**
> ""Don't you dare try to pin this on me! This is where *you* led us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""And yet here you are, reduced to my level. You're to blame for this disaster!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Narrator**
> "Several shots immediately struck the top of the table, splintering wood and sending fragments flying, but we remained protected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Narrator**
> "However, the moment we crawled out from underneath, we'd be exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[34]`
  - -> `[33]`
  - -> `[394]`

### Węzeł `[394]`
**[WYBÓR GRACZA: "Push Adarfo out from underneath to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I grabbed Adarfo by the collar, using all my strength to push him out from under the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Narrator**
> "His hands clawing at mine in a desperate attempt to break free. With a final heave, I pushed him out from underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Narrator**
> "In an instant, as gunfire tore through the air, and he crumpled to the ground, dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[397]`
Mówca: **Narrator**
> "With all eyes on Adarfo, I had a clear path to get away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Narrator**
> "Adarfo, however, wasn't so fortunate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Narrator**
> "As he tried to scramble to his feet, gunfire tore through the air, and he crumpled to the ground, dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "As I continued moving, the bookshelves kept me concealed, and before I knew it, I reached the spiral staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Narrator**
> "Adarfo followed my lead, and we managed to slip away. Before long, we were just a few feet away from the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should double back. Without any cover, we'd be sitting ducks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[412]`
Mówca: **Narrator**
> "I hesitated, realizing that any movement upward would surely leave us dangerously exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[416]`
  - -> `[417]`

### Węzeł `[413]`
Mówca: **Narrator**
> "I hesitated, realizing that any movement upward would surely leave us dangerously exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[36]`
  - -> `[197]`

### Węzeł `[414]`
Mówca: **Adarfo Sotelato**
> ""Do what you like, but I'm not staying here a minute longer than I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Narrator**
> "Adarfo hurried up the stairs. Shots were fired at him, however, I didn't wait to see if managed to evade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to proceed with caution. Who knows what's waiting for us if we make a run for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, let's go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[418]`
Mówca: **Adarfo Sotelato**
> ""Agreed. No point being too hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Narrator**
> "I ducked and weaved my way through the bookstack. Doing so kept us concealed, and before long, we'd reached the spiral staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[420]`
Mówca: **Adarfo Sotelato**
> ""After you, *Your Majesty*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[421]`
Mówca: **Narrator**
> "I ignored his sarcasm as we dashed for the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Narrator**
> "However, we were soon spotted, and a guard unleashed a volley of shots in our direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Narrator**
> "He missed. We didn't stop until we'd reached the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
**[WYBÓR GRACZA: "Dash to the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, we dashed for the book vault."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[431]`
Mówca: **Narrator**
> "He missed. We didn't stop until we'd reached the vault door. With the combination clicked into place, Adarfo and I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Adarfo Sotelato**
> ""This was a mistake. I should've known better than to trust a monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`
  - -> `[439]`
  - -> `[440]`

### Węzeł `[436]`
Mówca: **Narrator**
> "I sank into a chair, waiting for the upheaval outside to end, while Adarfo paced about. Minutes felt like hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’re still alive. That's more than you can say for your stupid movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t mistake our situation for a failure. We’ll find a way to come out on top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may die, but the revolution never will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don’t you keep complaining? Surely, that’ll solve everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Narrator**
> "Adarfo abruptly slammed his hand against a shelf."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[442]`
Mówca: **Narrator**
> "Before I realized what was happening, Adarfo threw me against the floor and had me by the throat. I struggled to fight back, but his grip was unrelenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Narrator**
> "Everything began to turn black. But it was at that moment that I heard the doors to the vault click open, followed by a loud commotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Adarfo Sotelato**
> ""The only thing we’re coming out of is this vault, when they decide it’s time to drag us out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Narrator**
> "When I came to, my stomach sank as I found myself looking up at Titus, flanked by several guards holding rifles. Adarfo lay nearby, not moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[446]`
Mówca: **Narrator**
> "And that's exactly what happened. As if on cue, we heard the gunfire subside and the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[450]`
Mówca: **Narrator**
> "Without warning, Adarfo charged toward our guests, screaming and waving his fists, before he was gunned down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[451]`
Mówca: **Narrator**
> "It took a moment for my hearing to recover and make out what Titus was saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[453]`
Mówca: **Titus Gordion**
> ""Step out of the vault and follow me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[454]`
Mówca: **Narrator**
> "I rushed upward, the dizzying speed of my ascent distorted the frenzy below as Adarfo and I escaped the library’s violent interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Narrator**
> "The cool night air greeted us as we spilled out from the rooftop exit and hurried to the fire escape leading down to the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[209]`
  - -> `[463]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`
  - -> `[469]`
  - -> `[468]`

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take the fire escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Jumping would be our safest option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not about to put myself at the mercy of an angry mob or risk plummeting to my death. I'm going back inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[462]`
Mówca: **Adarfo Sotelato**
> ""Yes, it does seem like the best chance to avoid detection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
**[WYBÓR GRACZA: "Go back inside to face the consequences of your choices."]** — Mówca: **Player_Romus_Italic**
> "I realized that I had to face the consequences of my choices head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Narrator**
> "I turned around and went back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no honor in running away. I'll be perceived as a coward. I have to go back and face the consequences of my actions head-on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[472]`
Mówca: **Adarfo Sotelato**
> ""Then you're a fool. There's only possible way that will turn out. And I'm not about to let that happen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Narrator**
> "Without a second thought, Adarfo gave himself a running start before leaping to the other rooftop. He took one last look at me before vanishing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[474]`
Mówca: **Narrator**
> "I, on the other hand, turned back around and went inside. I then made my way down the stairs until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[476]`
Mówca: **Narrator**
> "Without a second thought, Adarfo gave himself a running start before leaping to the other rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Narrator**
> "He looked back and nodded his farewell before taking off, vanishing without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[478]`
Mówca: **Adarfo Sotelato**
> ""If you want to take the fire escape, be my guest. But I'll stick to where it's actually harder to get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[485]`
Mówca: **Narrator**
> "I stopped when I spotted two House security guards crouched behind an overturned table, exchanging gunfire with the Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Narrator**
> "I stopped when I spotted two of Adarfo's men crouched behind an overturned table, exchanging gunfire with the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[490]`
Mówca: **Narrator**
> "I stopped when I spotted two of Adarfo's men crouched behind an overturned table, exchanging gunfire with the Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[494]`
**[WYBÓR GRACZA: "Knock over a nearby vase as a distraction."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the Guardsmen's attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[501]`
**[WYBÓR GRACZA: "Knock over a nearby vase as a distraction."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the Guardians' attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[505]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several Wruhec's Guardians ran past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[506]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several Golden Guardsmen ran past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Narrator**
> "Then, to my horror, several Wruhec's Guardians, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[514]`
Mówca: **Narrator**
> "Then, to my horror, several Golden Guardsmen, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[518]`
Mówca: **Narrator**
> "My eyes were then drawn to a nearby dead insurgent, still clutching his assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[14]`
  - -> `[232]`
  - -> `[491]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[526]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The Guardians turned and raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[527]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The Golden Guardsmen turned and raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the Guardians dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the Guardsmen dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[542]`
Mówca: **Narrator**
> "The second Guardian barely had time to react, scrambling to reposition, but the rebels finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Narrator**
> "The second guard barely had time to react, scrambling to reposition, but the Golden Guard finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[547]`
Mówca: **Narrator**
> "The second Guardsman barely had time to react, scrambling to reposition, but the rebels finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[48]`
  - -> `[50]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[555]`
Mówca: **Narrator**
> "I spotted several Wruhec's Guardians positioned near a bookshelf, exchanging gunfire with House security forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[556]`
Mówca: **Narrator**
> "I spotted several Golden Guardsmen positioned near a bookshelf, exchanging gunfire with Adarfo's forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[560]`
Mówca: **Narrator**
> "I spotted several Wruhec's Guardians positioned near a bookshelf, exchanging gunfire with Adarfo's forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[27]`
  - -> `[302]`

### Węzeł `[562]`
**[WYBÓR GRACZA: "Use a fallen bookshelf as cover and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I took cover behind a fallen bookshelf, certain that reinforcements would arrive to turn the tide in our favor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true) ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[569]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay where I was, trusting my Adarfo's men to get the situation under control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[576]`
**[WYBÓR GRACZA: "Push nearby book cart toward the Guardians."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[577]`
**[WYBÓR GRACZA: "Push nearby book cart toward the Golden Guard."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the Golden Guardsmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[584]`
Mówca: **Narrator**
> "The guards were momentarily distracted, giving the Guardians the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[585]`
Mówca: **Narrator**
> "The Guardians were momentarily distracted, giving the rebels the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[589]`
Mówca: **Narrator**
> "The Guards were momentarily distracted, giving the rebels the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed = true;
RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = false; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed = true;
RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = false; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[596]`
Mówca: **Narrator**
> "And just when escape felt within reach, both Guardians were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`
  - -> `[599]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
Mówca: **Narrator**
> "And just when escape felt within reach, Adarfo's freedom fighters were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [BarrelOfTrouble_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[605]`
Mówca: **Narrator**
> "My stomach sank when Titus, flanked by Captain Castellanus and his Wruhec's Guardians, stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`
  - -> `[608]`

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[609]`
Mówca: **Sevrio Castellanus**
> ""Divus gidatu gaitu eta libratu gaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[610]`
Mówca: **Narrator**
> "His words were at the ancient Wruhecist for, "The Lord has guided us and delivered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[612]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped = true;
RiziaDLC.SkipToEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arrested = true;
RiziaDLC.Epilogue_Prison_HouseFallouts = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arrested"] = true;
Variable["RiziaDLC.Epilogue_Prison_HouseFallouts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_FrontDoor = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_FrontDoor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom = true; RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunnel = true; RiziaDLCIsolated.Birthday_Gathering_Escape_Archives = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunnel"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom_TitusRescue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom_TitusRescue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_ShotFromAbove = true;
RiziaDLC.SkipToEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[620]`
Mówca: **Narrator**
> "I looked around for Vina and my mother. Neither were to be seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`
  - -> `[623]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[623]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Narrator**
> "I looked around for my mother. I couldn't see her anywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[625]`
Mówca: **Narrator**
> "Emerging out into the main atrium, I saw a scene of pandemonium. Some of the invitees had taken up arms and were firing blindly at the attackers; others cowered behind library shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[626]`
**[WYBÓR GRACZA: "Make your escape."]** — Mówca: **Player_Romus_Italic**
> "The others could take care of themselves. I had to get out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Gone == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Gone == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[626]`

### Węzeł `[633]`
Mówca: **Narrator**
> "One of Titus' men was pointing a gun at Pabel, demanding he tell him what he knew of my plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[626]`

### Węzeł `[634]`
Mówca: **Narrator**
> "One of the House forces was pointing a gun at Pabel, demanding he tell him what he knew of my plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`
  - -> `[626]`

### Węzeł `[635]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't hurt anyone! I surrender!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`
  - -> `[638]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[639]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Lucita approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[640]`
Mówca: **Lucita Azaro**
> ""Romus, sweetheart, I want a divorce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Peaceful Arrest)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[642]`
Mówca: **Narrator**
> "The action froze. Everyone in the library stopped and stared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[646]`
Mówca: **Narrator**
> "The guardsmen and the revolutionaries ignored me. The firefight continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`
  - -> `[626]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Peaceful Arrest])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[648]`
**[WYBÓR GRACZA: ""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS YOU!""]** — Mówca: **Player_Romus**
> ""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[649]`
Mówca: **Narrator**
> "Before I could finish the words, something heavy hit the back of my head. I lost consciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[650]`
Mówca: **Narrator**
> "I don't know how much time passed before Titus nudged me awake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[651]`
Mówca: **Narrator**
> "He cracked a half-smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Adarfo Sotelato**
> ""You're right about that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[653]`
Mówca: **Narrator**
> "As if on cue, we heard the gunfire subside and the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_LargerYourQuarry == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_LargerYourQuarry == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_LargerYourQuarry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_LargerYourQuarry == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_LargerYourQuarry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[657]`
Mówca: **Hugo Toras**
> ""You know what hunters say, my boy...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[658]`
Mówca: **Adarfo Sotelato**
> ""The mob is your problem. Not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`
  - -> `[663]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`
  - -> `[666]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[667]`
Mówca: **Narrator**
> "After entering the vault door combination, I stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.Rusty_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.Rusty_Allied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[671]`
Mówca: **Narrator**
> "I saw Rusty watching from the other side of the room, a satisfied smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Death_KilledByMob = true;
RiziaDLC.SkipToEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_KilledByMob"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[677]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_RevolutionaryFail = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_BirthdayStrike = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
