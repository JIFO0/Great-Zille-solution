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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"Escape through secret tunnel."** | `[294]` **Narrator**: "My only other option was to get ..."<br>`[295]` **Narrator**: "My only other option was to get ..." | `Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeR...` | `[41]` **Narrator**: "The nearest access was a dumbwai..." |
| `[4]` | **"Take spiral staircase to roof."** | `[294]` **Narrator**: "My only other option was to get ..."<br>`[295]` **Narrator**: "My only other option was to get ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeR...` | `[25]` **Narrator**: "Everything blurred past as I dar..." |
| `[5]` | **"Leave through front entrance."** | `[294]` **Narrator**: "My only other option was to get ..."<br>`[295]` **Narrator**: "My only other option was to get ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeR...` | `[7]` **Narrator**: "Everything blurred past as I ran..." |
| `[12]` | **"Dash across the open space toward the exit."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false` | *Brak zmian stanu* | `[134]` **Narrator**: "But just as I reached the halfwa..." |
| `[13]` | **"Create a distraction by knocking over a nearby vase."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false` | *Brak zmian stanu* | `[15]` **Narrator**: "With their backs momentarily tur..." |
| `[14]` | **"Hide behind a bookshelf and wait for reinforcements."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Eventually, the sounds of the ba..." |
| `[19]` | **"Hold position and wait for the nearby gunfight to subside."** | `[18]` **Narrator**: "With their focus on the firefigh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Eventually, the sounds of the ba..." |
| `[20]` | **"Make a direct run to your goal."** | `[18]` **Narrator**: "With their focus on the firefigh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "Adrenaline surged as I pushed fo..." |
| `[21]` | **"Double back and find an alternate escape route."** | `[18]` **Narrator**: "With their focus on the firefigh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "Adrenaline surged as I retraced ..." |
| `[22]` | **"Duck and crawl beneath the banquet tables."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..." | `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_Banque...` | `[18]` **Narrator**: "With their focus on the firefigh..." |
| `[23]` | **"Use the assault rifle."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"]...` | `[45]` **Narrator**: "As I did, memories from my time ..." |
| `[27]` | **"Move underneath central reading table."** | `[24]` **Narrator**: "I spotted several Golden Guardsm..."<br>`[555]` **Narrator**: "I spotted several Wruhec's Guard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Adarfo Sotelato"); ;`<br>`Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hidi...` | `[30]` **Narrator**: "Several shots immediately struck..."<br>`[378]` **Narrator**: "I unexpectedly crashed into Adar..." |
| `[28]` | **"Sprint directly toward the spiral staircase."** | `[24]` **Narrator**: "I spotted several Golden Guardsm..."<br>`[555]` **Narrator**: "I spotted several Wruhec's Guard..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false` | *Brak zmian stanu* | `[219]` **Narrator**: "However, just before I reached i..." |
| `[29]` | **"Use a fallen bookshelf as cover and wait for reinforcements."** | `[24]` **Narrator**: "I spotted several Golden Guardsm..."<br>`[555]` **Narrator**: "I spotted several Wruhec's Guard..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)) == false` | *Brak zmian stanu* | `[150]` **Narrator**: "Eventually, the sounds of the ba..." |
| `[32]` | **"Wait for a lull in the gunfire."** | `[31]` **Narrator**: "I was safely protected, but craw..."<br>`[393]` **Narrator**: "However, the moment we crawled o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "Adrenaline surged through my vei..." |
| `[33]` | **"Quickly dash to the nearest book stack."** | `[31]` **Narrator**: "I was safely protected, but craw..."<br>`[393]` **Narrator**: "However, the moment we crawled o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Narrator**: "As I continued moving, the books..."<br>`[403]` **Narrator**: "Adarfo, however, wasn't so fortu..." |
| `[34]` | **"Kick over a nearby chair to create a distraction."** | `[31]` **Narrator**: "I was safely protected, but craw..."<br>`[393]` **Narrator**: "However, the moment we crawled o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "As it clattered across the floor..." |
| `[36]` | **"Duck and weave through the book stacks."** | `[413]` **Narrator**: "I hesitated, realizing that any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Just my luck, it kept me conceal..." |
| `[38]` | **"Dash to the staircase."** | `[413]` **Narrator**: "I hesitated, realizing that any ..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false` | *Brak zmian stanu* | `[200]` **Narrator**: "However, I was soon spotted, and..." |
| `[48]` | **"Move along the wall's edge."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..."<br>`[47]` **Narrator**: "The second guard barely had time..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false` | *Brak zmian stanu* | `[52]` **Narrator**: "My eyes constantly darted betwee..." |
| `[49]` | **"Mad dash across the open space toward the exit."** | `[47]` **Narrator**: "The second guard barely had time..."<br>`[542]` **Narrator**: "The second Guardian barely had t..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false` | *Brak zmian stanu* | `[51]` **Narrator**: "My heart pounded in my chest as ..." |
| `[50]` | **"Hold position and wait for reinforcements."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..."<br>`[47]` **Narrator**: "The second guard barely had time..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Eventually, the sounds of the ba..." |
| `[54]` | **"Shoot at guard."** | `[53]` **Narrator**: "I spotted a guard standing on th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "I missed, the bullets slamming i..." |
| `[55]` | **"Run for the exit."** | `[53]` **Narrator**: "I spotted a guard standing on th..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false` | *Brak zmian stanu* | `[104]` **Narrator**: "But just before I reached the do..." |
| `[58]` | **"Resume crawling toward your goal."** | `[57]` **Narrator**: "I was now just a few agonizing f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Narrator**: "After what felt like an eternity..."<br>`[176]` **Narrator**: "After what felt like an eternity..." |
| `[60]` | **"Wait for guard to turn."** | `[53]` **Narrator**: "I spotted a guard standing on th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "I pushed forward, adrenaline rus..." |
| `[61]` | **"Wait for the nearby gunfight to subside."** | `[57]` **Narrator**: "I was now just a few agonizing f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Then, to my horror, several Hous..."<br>`[513]` **Narrator**: "Then, to my horror, several Wruh..."<br>*(oraz 1 innych odgałęzień)* |
| `[63]` | **"Drop weapon and surrender."** | `[62]` **Narrator**: "They demanded that I drop my wea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "I soon found myself with my hand..." |
| `[64]` | **"Fire weapon."** | `[62]` **Narrator**: "They demanded that I drop my wea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "My body jerked with each impact,..." |
| `[90]` | **""GET OUT OF THE WAY!""** | `[96]` **Narrator**: "They were blocking my way, and t..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true` | *Brak zmian stanu* | `[98]` **Narrator**: "When the crowd realized I was wi..." |
| `[97]` | **"Fire gun into the air."** | `[96]` **Narrator**: "They were blocking my way, and t..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true` | *Brak zmian stanu* | `[100]` **Narrator**: "Fear rippled through the crowd, ..." |
| `[112]` | **"Stay put."** | `[111]` **Narrator**: "No one was coming." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Then, to my horror, several Hous..."<br>`[513]` **Narrator**: "Then, to my horror, several Wruh..."<br>*(oraz 1 innych odgałęzień)* |
| `[120]` | **""MOVE ASIDE! NOW!""** | `[96]` **Narrator**: "They were blocking my way, and t..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false` | *Brak zmian stanu* | `[149]` **Narrator**: "In an instant, a mass of people ..." |
| `[121]` | **"Barrel through the crowd."** | `[96]` **Narrator**: "They were blocking my way, and t..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false` | *Brak zmian stanu* | `[125]` **Narrator**: "Fists and feet rained down in a ..." |
| `[122]` | **"Go back inside."** | `[96]` **Narrator**: "They were blocking my way, and t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "I made my way down the hall unti..." |
| `[129]` | **"Use the assault rifle."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false` | *Brak zmian stanu* | `[130]` **Narrator**: "So I took aim, steadying the sig..." |
| `[141]` | **"Crawl out and move along the wall's edge."** | `[111]` **Narrator**: "No one was coming." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false) == false` | *Brak zmian stanu* | `[52]` **Narrator**: "My eyes constantly darted betwee..." |
| `[142]` | **"Run for the exit."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false` | *Brak zmian stanu* | `[143]` **Narrator**: "However, just before I reached t..." |
| `[144]` | **"Run for the exit."** | `[57]` **Narrator**: "I was now just a few agonizing f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "However, the guard returned and ..." |
| `[151]` | **"Stay where you are."** | `[154]` **Narrator**: "No one was coming." | `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false` | *Brak zmian stanu* | `[202]` **Narrator**: "Adrenaline surged through my vei..." |
| `[152]` | **"Double back and find an alternate escape route."** | `[154]` **Narrator**: "No one was coming."<br>`[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Before long the gunfire eventual..." |
| `[153]` | **"Double back and find an alternate escape route."** | `[111]` **Narrator**: "No one was coming." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "Adrenaline surged as I retraced ..." |
| `[158]` | **"Surrender."** | `[157]` **Narrator**: "They demanded that I put my hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "I soon found myself with my hand..." |
| `[159]` | **"Run."** | `[157]` **Narrator**: "They demanded that I put my hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "My body jerked with each impact,..." |
| `[169]` | **"Go down the alley."** | `[229]` **Narrator**: "I could either take my chances i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "I kept my head down, pushing for..." |
| `[183]` | **"Step inside tunnel."** | `[184]` **Narrator**: "Sliding it aside revealed the hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "My sense of direction slipped aw..." |
| `[185]` | **"Hide."** | `[184]` **Narrator**: "Sliding it aside revealed the hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Then, to my horror, several Hous..."<br>`[513]` **Narrator**: "Then, to my horror, several Wruh..."<br>*(oraz 1 innych odgałęzień)* |
| `[186]` | **"Double back to the library."** | `[184]` **Narrator**: "Sliding it aside revealed the hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Then, to my horror, several Hous..."<br>`[513]` **Narrator**: "Then, to my horror, several Wruh..."<br>*(oraz 1 innych odgałęzień)* |
| `[189]` | **"Run for the stairs."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false` | *Brak zmian stanu* | `[203]` **Narrator**: "With the men providing cover, I ..." |
| `[190]` | **"Push nearby book cart toward House security."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false` | *Brak zmian stanu* | `[193]` **Narrator**: "It crashed into a nearby bookshe..." |
| `[191]` | **"Hold position and wait for reinforcements."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[600]` **Narrator**: "And just when escape felt within..."<br>`[596]` **Narrator**: "And just when escape felt within..."<br>*(oraz 1 innych odgałęzień)* |
| `[197]` | **"Double back and find an alternate escape route."** | `[413]` **Narrator**: "I hesitated, realizing that any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "As I retracted my steps, the gun..." |
| `[209]` | **"Leap to nearest rooftop."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false` | *Brak zmian stanu* | `[223]` **Narrator**: "Pushing past the ache in my leg,..."<br>`[227]` **Narrator**: "Taking a deep breath, I stepped ..." |
| `[210]` | **"Take fire escape."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false` | *Brak zmian stanu* | `[229]` **Narrator**: "I could either take my chances i..." |
| `[211]` | **"Go back inside."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`<br>`Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false` | *Brak zmian stanu* | `[201]` **Narrator**: "I made my way down the stairs un..." |
| `[220]` | **"Run for the stairs."** | `[154]` **Narrator**: "No one was coming." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "However, just before I reached i..." |
| `[228]` | **"Run for the dumbwaiter."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false` | *Brak zmian stanu* | `[239]` **Narrator**: "However, just before I reached i..." |
| `[235]` | **"Dash across the open space toward the front desk."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false` | *Brak zmian stanu* | `[240]` **Narrator**: "However, just before I reached i..." |
| `[242]` | **"Dash across the open space toward the dumbwaiter."** | `[47]` **Narrator**: "The second guard barely had time..."<br>`[542]` **Narrator**: "The second Guardian barely had t..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false` | *Brak zmian stanu* | `[251]` **Narrator**: "My heart pounded in my chest as ..." |
| `[262]` | **"Head into the street."** | `[229]` **Narrator**: "I could either take my chances i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "I kept my head down and stepped ..."<br>`[170]` **Narrator**: "As I made my way forward, I spot..." |
| `[265]` | **"Run for the dumbwaiter."** | `[53]` **Narrator**: "I spotted a guard standing on th..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false` | *Brak zmian stanu* | `[241]` **Narrator**: "But just before I reached it, a ..." |
| `[297]` | **"Flee to nearest safe room."** | `[294]` **Narrator**: "My only other option was to get ..."<br>`[295]` **Narrator**: "My only other option was to get ..." | `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true` | `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeR...` | `[298]` **Narrator**: "Built as a space for rare books ..." |
| `[305]` | **"Sprint directly toward the book vault."** | `[24]` **Narrator**: "I spotted several Golden Guardsm..."<br>`[555]` **Narrator**: "I spotted several Wruhec's Guard..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false` | *Brak zmian stanu* | `[219]` **Narrator**: "However, just before I reached i..." |
| `[309]` | **"Run for the book vault."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false` | *Brak zmian stanu* | `[203]` **Narrator**: "With the men providing cover, I ..." |
| `[313]` | **"Dash to the book vault."** | `[413]` **Narrator**: "I hesitated, realizing that any ..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false` | *Brak zmian stanu* | `[200]` **Narrator**: "However, I was soon spotted, and..." |
| `[333]` | **""Titus! What happened?""** | `[332]` **Narrator**: "I looked up, expecting the worst..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." |
| `[334]` | **""Oh my God, Titus! Are you alright?""** | `[332]` **Narrator**: "I looked up, expecting the worst..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Titus Gordion**: ""A little banged up, but I'll ma..." |
| `[335]` | **""Is it safe to come out?""** | `[332]` **Narrator**: "I looked up, expecting the worst..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Titus Gordion**: ""Yes, Your Majesty. Sorry we cou..." |
| `[336]` | **""What took you so long?""** | `[332]` **Narrator**: "I looked up, expecting the worst..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Titus Gordion**: ""As you can see, I had some... c..." |
| `[341]` | **""What about my family?""** | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Titus Gordion**: ""Don't worry. They've been taken..." |
| `[343]` | **""How could you let this happen?""** | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Titus Gordion**: ""Sometimes, no matter how much p..." |
| `[344]` | **""This is all my fault.""** | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Titus Gordion**: ""No one could have predicted thi..." |
| `[351]` | **""I need a drink.""** | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." | `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false` | *Brak zmian stanu* | `[352]` **Titus Gordion**: ""I'm sure we could arrange that,..." |
| `[353]` | **""Next time, I’ll consider a more exclusive guest list. No need for the Houses to c..."** | `[337]` **Titus Gordion**: ""The House forces overwhelmed us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Titus Gordion**: ""Good idea. But come, let's get ..." |
| `[379]` | **""I trusted you, Adarfo. And this is where it’s led us.""** | `[378]` **Narrator**: "I unexpectedly crashed into Adar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Adarfo Sotelato**: ""Don't you dare try to pin this ..." |
| `[380]` | **""Hiding now, are we? Not quite the leader of the revolution I envisioned.""** | `[378]` **Narrator**: "I unexpectedly crashed into Adar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Adarfo Sotelato**: ""And yet here you are, reduced t..." |
| `[381]` | **""Funny, isn't it? You wanted to topple a king, and here we are, both groveling in ..."** | `[378]` **Narrator**: "I unexpectedly crashed into Adar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Adarfo Sotelato**: ""Don’t mistake my position for d..." |
| `[382]` | **""I can't believe this is happening.""** | `[378]` **Narrator**: "I unexpectedly crashed into Adar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Adarfo Sotelato**: ""Believe it! Your arrogance brou..." |
| `[386]` | **""So how's your day going?""** | `[378]` **Narrator**: "I unexpectedly crashed into Adar..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[387]` **Narrator**: "Adarfo glared at me coldly, not ..." |
| `[394]` | **"Push Adarfo out from underneath to create a distraction."** | `[393]` **Narrator**: "However, the moment we crawled o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Narrator**: "His hands clawing at mine in a d..." |
| `[411]` | **""We should double back. Without any cover, we'd be sitting ducks.""** | `[412]` **Narrator**: "I hesitated, realizing that any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Adarfo Sotelato**: ""Do what you like, but I'm not s..." |
| `[416]` | **""We need to proceed with caution. Who knows what's waiting for us if we make a run..."** | `[412]` **Narrator**: "I hesitated, realizing that any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Adarfo Sotelato**: ""Agreed. No point being too hasty."" |
| `[417]` | **""Alright, let's go!""** | `[412]` **Narrator**: "I hesitated, realizing that any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Adarfo Sotelato**: ""After you, *Your Majesty*."" |
| `[430]` | **"Dash to the book vault."** | `[420]` **Adarfo Sotelato**: ""After you, *Your Majesty*."" | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false` | *Brak zmian stanu* | `[422]` **Narrator**: "However, we were soon spotted, a..." |
| `[437]` | **""We’re still alive. That's more than you can say for your stupid movement.""** | `[435]` **Adarfo Sotelato**: ""This was a mistake. I should've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Narrator**: "Before I realized what was happe..." |
| `[438]` | **""Don’t mistake our situation for a failure. We’ll find a way to come out on top.""** | `[435]` **Adarfo Sotelato**: ""This was a mistake. I should've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Adarfo Sotelato**: ""The only thing we’re coming out..." |
| `[439]` | **""We may die, but the revolution never will.""** | `[435]` **Adarfo Sotelato**: ""This was a mistake. I should've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[651]` **Narrator**: "He cracked a half-smile." |
| `[440]` | **""Why don’t you keep complaining? Surely, that’ll solve everything.""** | `[435]` **Adarfo Sotelato**: ""This was a mistake. I should've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Narrator**: "Before I realized what was happe..." |
| `[459]` | **""We should take the fire escape.""** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false` | *Brak zmian stanu* | `[478]` **Adarfo Sotelato**: ""If you want to take the fire es..." |
| `[460]` | **""Jumping would be our safest option.""** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false` | *Brak zmian stanu* | `[462]` **Adarfo Sotelato**: ""Yes, it does seem like the best..." |
| `[461]` | **""No. I'm not about to put myself at the mercy of an angry mob or risk plummeting t..."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`<br>`(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false` | *Brak zmian stanu* | `[658]` **Adarfo Sotelato**: ""The mob is your problem. Not mi..." |
| `[466]` | **"Go back inside to face the consequences of your choices."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`<br>`Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false` | *Brak zmian stanu* | `[467]` **Narrator**: "I turned around and went back in..." |
| `[468]` | **""There's no honor in running away. I'll be perceived as a coward. I have to go bac..."** | `[263]` **Narrator**: "I wasn't as athletic as I once w..."<br>`[264]` **Narrator**: "I wasn't as athletic as I used t..." | `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false` | *Brak zmian stanu* | `[472]` **Adarfo Sotelato**: ""Then you're a fool. There's onl..." |
| `[494]` | **"Knock over a nearby vase as a distraction."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | *Brak zmian stanu* | `[15]` **Narrator**: "With their backs momentarily tur..." |
| `[501]` | **"Knock over a nearby vase as a distraction."** | `[44]` **Narrator**: "My eyes were then drawn to a nea..."<br>`[518]` **Narrator**: "My eyes were then drawn to a nea..." | `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | *Brak zmian stanu* | `[15]` **Narrator**: "With their backs momentarily tur..." |
| `[505]` | **"Duck and crawl beneath the banquet tables."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..." | `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_Banque...` | `[18]` **Narrator**: "With their focus on the firefigh..." |
| `[506]` | **"Duck and crawl beneath the banquet tables."** | `[17]` **Narrator**: "Scattered books, toppled chairs,..." | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_Banque...` | `[18]` **Narrator**: "With their focus on the firefigh..." |
| `[562]` | **"Use a fallen bookshelf as cover and wait for reinforcements."** | `[24]` **Narrator**: "I spotted several Golden Guardsm..."<br>`[555]` **Narrator**: "I spotted several Wruhec's Guard..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)` | *Brak zmian stanu* | `[150]` **Narrator**: "Eventually, the sounds of the ba..." |
| `[569]` | **"Stay where you are."** | `[154]` **Narrator**: "No one was coming." | `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true` | *Brak zmian stanu* | `[202]` **Narrator**: "Adrenaline surged through my vei..." |
| `[576]` | **"Push nearby book cart toward the Guardians."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | *Brak zmian stanu* | `[193]` **Narrator**: "It crashed into a nearby bookshe..." |
| `[577]` | **"Push nearby book cart toward the Golden Guard."** | `[188]` **Narrator**: ""Go! We'll cover you!" they yell..." | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false` | *Brak zmian stanu* | `[193]` **Narrator**: "It crashed into a nearby bookshe..." |
| `[626]` | **"Make your escape."** | `[633]` **Narrator**: "One of Titus' men was pointing a..."<br>`[634]` **Narrator**: "One of the House forces was poin..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Pabel_Gone"] == false) == false` | *Brak zmian stanu* | `[272]` **Narrator**: "The main entrance was the most d..." |
| `[635]` | **""Don't hurt anyone! I surrender!""** | `[633]` **Narrator**: "One of Titus' men was pointing a..."<br>`[634]` **Narrator**: "One of the House forces was poin..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Pabel_Gone"] == false) == false` | *Brak zmian stanu* | `[646]` **Narrator**: "The guardsmen and the revolution..."<br>`[642]` **Narrator**: "The action froze. Everyone in th..." |
| `[648]` | **""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS YOU!""** | `[646]` **Narrator**: "The guardsmen and the revolution..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Narrator**: "Before I could finish the words,..." |

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
  - -> `[625]` (*Narrator: "Emerging out into the main atrium, I saw a scene of pande..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "Escape through secret tunnel."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the archive level within the bowels of the library."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true`
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator), `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunne..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Take spiral staircase to roof."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the spiral staircase in the back of the main hall. From there, I could reach the rooftop."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator), `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof ..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "Leave through front entrance."]** — Mówca: **Player_Romus_Italic**
> "I decided to make a break for the front entrance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator), `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Front..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "It would be a tight fit, but from there I could access the secret tunnel that ran between the library and the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "Jump to: [Archive _Jump_Hub]"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Everything blurred past as I ran into the main hall darting between bookshelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "The library's pristine interior was now a war zone, with ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I stopped when I spotted two House security guards crouched behind an overturned table, exchanging gunfire with the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "My eyes were then drawn to a nearby dead guard, still clu..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Dash across the open space toward the exit."]** — Mówca: **Player_Romus_Italic**
> "I made a mad dash across the open space toward the exit. Adrenaline surged as my heart pounded in my chest while I pushed forward."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "But just as I reached the halfway point, a sharp crack ec..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Create a distraction by knocking over a nearby vase."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the guards' attention."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "With their backs momentarily turned, I had a clear path b..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Hide behind a bookshelf and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I hid behind a bookshelf, deciding it was best to hold my position and wait for reinforcements."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Eventually, the sounds of the battle gradually began to f..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "With their backs momentarily turned, I had a clear path between the massive shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Scattered books, toppled chairs, and torn decorations cre..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Deafening gunfire erupted all around me, but I kept moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Scattered books, toppled chairs, and torn decorations created a maze of potential cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus_Italic: "Move along the wall's edge."*)
  - -> `[50]` (*Player_Romus_Italic: "Hold position and wait for reinforcements."*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "With their focus on the firefight, I was now just a few feet away from my escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus_Italic: "Double back and find an alternate escape route."*)
  - -> `[19]` (*Player_Romus_Italic: "Hold position and wait for the nearby gunfight to subside."*)
  - -> `[20]` (*Player_Romus_Italic: "Make a direct run to your goal."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Hold position and wait for the nearby gunfight to subside."]** — Mówca: **Player_Romus_Italic**
> "I decided it was best to hold my position and wait for the gunfight to subside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Eventually, the sounds of the battle gradually began to f..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "Make a direct run to your goal."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted towards my goal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Adrenaline surged as I pushed forward. Fortunately, my fo..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "Despite my close proximity to the door, I doubled back to find an alternate escape route."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Adrenaline surged as I retraced my steps."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several House guards ran past."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable = t..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Use the assault rifle."]** — Mówca: **Player_Romus_Italic**
> "I reached out and grabbed the assault rifle."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun = true;"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "I spotted several Golden Guardsmen positioned near a bookshelf, exchanging gunfire with House security forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Everything blurred past as I darted between bookshelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The library's pristine interior was now a war zone, with ..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Deafening gunfire erupted all around me, but I kept moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "Move underneath central reading table."]** — Mówca: **Player_Romus_Italic**
> "I dove underneath a massive central reading table."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[555]` (Narrator), `[556]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Sprint directly toward the spiral staircase."]** — Mówca: **Player_Romus_Italic**
> "Without a second thought, I sprinted directly toward the spiral staircase. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[555]` (Narrator), `[556]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "However, just before I reached it, a sharp crack rang out."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Use a fallen bookshelf as cover and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I used a fallen bookshelf as cover, judging it was best to hold my position and wait for reinforcements."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)) == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[555]` (Narrator), `[556]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Eventually, the sounds of the battle began to fade. My pu..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Several shots immediately struck the top of the table, splintering wood and sending fragments flying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "I was safely protected, but crawling out would mean stepp..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "I was safely protected, but crawling out would mean stepping into the line of fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus_Italic: "Wait for a lull in the gunfire."*)
  - -> `[34]` (*Player_Romus_Italic: "Kick over a nearby chair to create a distraction."*)
  - -> `[33]` (*Player_Romus_Italic: "Quickly dash to the nearest book stack."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Wait for a lull in the gunfire."]** — Mówca: **Player_Romus_Italic**
> "I decided to hunker down and wait for a lull in the gunfire. However, as I did, the situation for my guardsmen seemed to get worse."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[393]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Adrenaline surged through my veins. Before long, one of t..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Quickly dash to the nearest book stack."]** — Mówca: **Player_Romus_Italic**
> "I quickly dashed to the nearest book stack."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[393]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "Kick over a nearby chair to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I kicked over a nearby chair to create a distraction."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[393]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "As it clattered across the floor, guards momentarily redi..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "As it clattered across the floor, guards momentarily redirected their attention, allowing me a clear path to get away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "Duck and weave through the book stacks."]** — Mówca: **Player_Romus_Italic**
> "I ducked and weaved my way through the bookstack."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Just my luck, it kept me concealed, and before long, the ..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Before long, I was just a few feet away from the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Narrator: "I hesitated, realizing that any movement upward would sur..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Dash to the staircase."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I dashed for the staircase."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Kontekst wejściowy (poprzednik):** `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "However, I was soon spotted, and a guard unleashed a voll..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Just my luck, it kept me concealed, and before long, the spiral staircase came into view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorti..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "I rushed upward, the dizzying speed of my ascent distorting the frenzy below as I escaped the library’s violent interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "The cool night air greeted me as I spilled out from the r..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The nearest access was a dumbwaiter, once used to transport books and documents, tucked near the entrance behind the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "It would be a tight fit, but from there I could access th..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The library's pristine interior was now a war zone, with research materials and broken furniture creating a treacherous landscape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "The library's pristine interior was now a war zone, with research materials and broken furniture creating a treacherous landscape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "My eyes were then drawn to a nearby dead guard, still clutching his assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "As I did, memories from my time at the military academy came rushing back. Instinctively, I took aim, steadying the sights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the House security guards dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "The second guard barely had time to react, scrambling to reposition, but the Wruhec's Guardians finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Move along the wall's edge."]** — Mówca: **Player_Romus_Italic**
> "I began carefully moving along the wall’s edge, each step measured and deliberate."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[47]` (Narrator), `[542]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "My eyes constantly darted between the shelves and the bal..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Mad dash across the open space toward the exit."]** — Mówca: **Player_Romus_Italic**
> "With the immediate threat eliminated, I made a mad dash across the open space toward the exit."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[542]` (Narrator), `[546]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "My heart pounded in my chest as I did. But just as I reac..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Hold position and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I stayed put, deciding it was best to hold my position and wait for reinforcements."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[47]` (Narrator), `[542]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Eventually, the sounds of the battle gradually began to f..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "My heart pounded in my chest as I did. But just as I reached the halfway point, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Ah_Shoot_Hub"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "My eyes constantly darted between the shelves and the balcony above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I spotted a guard standing on the second level, his atten..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I spotted a guard standing on the second level, his attention focused elsewhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus_Italic: "Shoot at guard."*)
  - -> `[60]` (*Player_Romus_Italic: "Wait for guard to turn."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Shoot at guard."]** — Mówca: **Player_Romus_Italic**
> "My finger tightened around the trigger, and a series of shots rang out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I missed, the bullets slamming into the bookshelf beside ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pushed forward, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "But just before I reached the doors, a sharp crack echoed..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "I missed, the bullets slamming into the bookshelf beside him. Startled, the guard retreated, clearing my path to the front of the library."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I was now just a few agonizing feet away from my escape."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I was now just a few agonizing feet away from my escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus_Italic: "Wait for the nearby gunfight to subside."*)
  - -> `[58]` (*Player_Romus_Italic: "Resume crawling toward your goal."*)
  - -> `[144]` (*Player_Romus_Italic: "Run for the exit."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Resume crawling toward your goal."]** — Mówca: **Player_Romus_Italic**
> "Heart pounding in my chest, I resumed my crawl toward my goal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Then, to my horror, several House security guards, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "Wait for guard to turn."]** — Mówca: **Player_Romus_Italic**
> "So I waited for what felt like an eternity until the guard turned away. Seizing the moment, I bolted for my exit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I pushed forward, adrenaline rushing through me, but my q..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "Wait for the nearby gunfight to subside."]** — Mówca: **Player_Romus_Italic**
> "After an agonizing wait, the gunfire eventually subsided, but it was unclear what had happened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "They demanded that I drop my weapon and surrender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus_Italic: "Fire weapon."*)
  - -> `[63]` (*Player_Romus_Italic: "Drop weapon and surrender."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Drop weapon and surrender."]** — Mówca: **Player_Romus_Italic**
> "Realizing there was no way out, I dropped my weapon and threw my hands in the air."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "Peaceful Arrest"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "Fire weapon."]** — Mówca: **Player_Romus_Italic**
> "I raised my weapon and fired, but before I could fire again, searing pain tore through my side, then my shoulder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "My body jerked with each impact, the air knocked from my ..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "I soon found myself with my hands tied behind my back as I was taken into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Vina and Mother were both frozen in shock."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I looked at Mother. She was frozen in shock."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Vina and Mother were both frozen in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I wondered if this would be the last time I’d ever see th..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I looked at Mother. She was frozen in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "I wondered if this would be the last time I’d ever see he..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Taddeus approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Taddeus Azaro: ""You're half the man your father was.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Hugo approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_LargerYourQuarry == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Angelica approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Angelica Sazon: ""You're worse than Lucas. Prison is too good for you.""*)

### Węzeł `[83]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Leona approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Leona Sazon: ""You had to go after us. You couldn't leave well enough a..."*)

### Węzeł `[84]`
Mówca: **Leona Sazon**
> ""You had to go after us. You couldn't leave well enough alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see her again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arres..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monarchy_Meets_Muzzle_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_ShotFromAbove = true; RiziaDLC.Sk..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSqua..."*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSq..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "I stumbled out of the library doors to an angry mob that ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSquare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "The library doors slammed shut behind me as I stumbled in..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""GET OUT OF THE WAY!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "When the crowd realized I was wielding a rifle, they slow..."*)

### Węzeł `[91]`
Mówca: **Taddeus Azaro**
> ""You're half the man your father was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""The larger your quarry, the more important it is for you not to miss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[93]`
Mówca: **Angelica Sazon**
> ""You're worse than Lucas. Prison is too good for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I wondered if this would be the last time I’d ever see them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arres..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "My body jerked with each impact, the air knocked from my lungs. My legs gave out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Monarchy_Meets_Muzzle_Hub"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "They were blocking my way, and the local police standing between us were barely enough to hold them back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus_Italic: "Go back inside."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Fire gun into the air."]** — Mówca: **Player_Romus_Italic**
> "I raised my weapon and fired a single shot into the air."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Fear rippled through the crowd, and scattered in all dire..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "When the crowd realized I was wielding a rifle, they slowly, but surely made a path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spotting my motorcade nearby, I ran for it and dove into ..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "I stumbled out of the library doors to an angry mob that had filled the square, shouting and jeering at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "They were blocking my way, and the local police standing ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Fear rippled through the crowd, and scattered in all directions, giving me the opening I needed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spotting my motorcade nearby, I ran for it and dove into ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Spotting my motorcade nearby, I ran for it and dove into the nearest car. The moment I was in, we sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "My plans had unraveled, but at least I'd escaped."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "My plans had unraveled, but at least I'd escaped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "The library doors slammed shut behind me as I stumbled into the street. To my relief, there was no immediate threat waiting to pounce."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Spotting my motorcade nearby, I ran for it and dove into ..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "But just before I reached the doors, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Ah_Shoot_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I had been spotted."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ah_Shoot_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Ah_Shoot_Hub"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "I had been spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Monarchy_Meets_Muzzle_Hub"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I pushed forward, adrenaline rushing through me, but my quick motion drew his gaze. He whipped around and fired several shots that barely missed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "I didn't stop until I was through the doorway and into the safety of the hallway, breathless but still alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSqua..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Eventually, the sounds of the battle gradually began to fad. My pulse slowed as an unsettling thought crept in..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "No one was coming."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "No one was coming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == ..."*)
  - -> `[112]` (*Player_Romus_Italic: "Stay put."*)
  - -> `[153]` (*Player_Romus_Italic: "Double back and find an alternate escape route."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "Stay put."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay put, trusting my guards to get the situation under control."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BarrelOfTrouble_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Adrenaline surged as I pushed forward. Fortunately, my foes were too preoccupied with the battle at hand to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the safety of the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSqua..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_PickUpGun = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "As I did, memories from my time at the military academy c..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus_Italic: "Fire gun into the air."*)
  - -> `[90]` (*Player_Romus: ""GET OUT OF THE WAY!""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus_Italic: "Barrel through the crowd."*)
  - -> `[120]` (*Player_Romus: ""MOVE ASIDE! NOW!""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""MOVE ASIDE! NOW!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "In an instant, a mass of people pushed past the row of of..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Barrel through the crowd."]** — Mówca: **Player_Romus_Italic**
> "I pushed forward, barreling through the wall of people, but they swarmed me."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Fists and feet rained down in a relentless barrage until ..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "Go back inside."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk putting myself at the mercy of an angry mob, I turned around and went back inside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "I made my way down the hall until I emerged back into the..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "I made my way down the hall until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Fists and feet rained down in a relentless barrage until my legs buckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Death_KilledByMob = true; RiziaDLC.Skip..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus_Italic: "Use the assault rifle."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus_Italic: "Use the assault rifle."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "Use the assault rifle."]** — Mówca: **Player_Romus_Italic**
> "Despite my limited experience with such a weapon, I reached out and grabbed the assault rifle."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "So I took aim, steadying the sights as best I could. A cr..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "So I took aim, steadying the sights as best I could. A crack of gunfire rang out as I squeezed the trigger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The guards immediately turned, their eyes locking onto me as they raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A sharp pain shot through my body, but I forced myself to..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "A sharp pain shot through my body, but I forced myself to remain standing. And then another shot rang out, and my legs immediately gave out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monarchy_Meets_Muzzle_Hub]"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monarchy_Meets_Muzzle_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Monarchy_Meets_Muzzle_Hub"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "But just as I reached the halfway point, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ah_Shoot_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Ah_Shoot_Hub"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "With their focus on the firefight, I was now just a few f..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == ..."*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable =..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus_Italic: "Move along the wall's edge."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus_Italic: "Crawl out and move along the wall's edge."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "Crawl out and move along the wall's edge."]** — Mówca: **Player_Romus_Italic**
> "I slowly crawled out from under the table, reached the wall, and began moving along its edge, each step measured and deliberate."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "My eyes constantly darted between the shelves and the bal..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "However, just before I reached the doors, a sharp crack e..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "However, just before I reached the doors, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "Run for the exit."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the exit. Adrenaline surged as I pressed onward, every second feeling like an eternity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "However, the guard returned and fired several shots in my..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "However, the guard returned and fired several shots in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "He missed. I didn't stop until I'd reached the safety of ..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ah_Shoot_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Ah_Shoot_Hub"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Adrenaline surged as I retraced my steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[148]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the safety of the hallway, breathless but alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSqua..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "In an instant, a mass of people pushed past the row of officers and swarmed me in a wild frenzy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Fists and feet rained down in a relentless barrage until ..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Eventually, the sounds of the battle began to fade. My pulse slowed as an unsettling thought crept in..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "No one was coming."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay where I was, trusting my guards to get the situation under control."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Adrenaline surged through my veins. Before long, one of t..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "I decided to double back and find an alternate escape route."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator), `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Before long the gunfire eventually subsided, but it was u..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "Despite my close proximity to the door, I decided to double back and find an alternate escape route."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Adrenaline surged as I retraced my steps."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "No one was coming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus_Italic: "Run for the stairs."*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[152]` (*Player_Romus_Italic: "Double back and find an alternate escape route."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Before long the gunfire eventually subsided, but it was unclear what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[157]`
Mówca: **Narrator**
> "They demanded that I put my hands in the air and surrender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus_Italic: "Surrender."*)
  - -> `[159]` (*Player_Romus_Italic: "Run."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "Surrender."]** — Mówca: **Player_Romus_Italic**
> "Realizing my situation was hopeless, I raised my hands in surrender."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "Peaceful Arrest"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Run."]** — Mówca: **Player_Romus_Italic**
> "I turned to run, but I barely made it three steps before a searing pain tore through my side, then my shoulder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "My body jerked with each impact, the air knocked from my ..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Spotting the motorcade parked nearby, I hurried to another fire escape out of sight from the protesters and climbed down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Diving into the nearest car, we sped off the moment I was..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Diving into the nearest car, we sped off the moment I was inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "My plans may have unraveled, but at least I'd made it out..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Flat on my back, I stared at the sky, unable to move or breathe as an eerie numbness spread through me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monarchy_Meets_Muzzle_Hub]"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "My plans may have unraveled, but at least I'd made it out alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "My fingers scraped the ledge before I plummeted into the alley below, the motorcade vanishing from view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Flat on my back, I stared at the sky, unable to move or b..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monarchy_Meets_Muzzle_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Monarchy_Meets_Muzzle_Hub"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "I kept my head down and stepped into the street, blending..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "As I made my way forward, I spotted my motorcade. But jus..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "Go down the alley."]** — Mówca: **Player_Romus_Italic**
> "The alley was narrow and rough, lined with shady figures who eyed me warily."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "I kept my head down, pushing forward through the darkness..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "As I made my way forward, I spotted my motorcade. But just as I neared it, a shout pierced the air -- then another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Before I could react, I was swarmed by protesters."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "I kept my head down, pushing forward through the darkness until I emerged on the other side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "There, parked nearby, was my motorcade."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "There, parked nearby, was my motorcade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Diving into the nearest car, we sped off the moment I was..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Before I could react, I was swarmed by protesters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Fists and feet rained down in a relentless barrage until ..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "I kept my head down and stepped into the street, blending seamlessly with the flow of pedestrians. No one seemed to notice me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Ahead, I spotted my motorcade, parked and waiting. I made..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Ahead, I spotted my motorcade, parked and waiting. I made my way over and casually stepped into the nearest car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "The moment I was inside, we sped away."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "Jump to: [Dumbwaiter_Hub]"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Squeezing inside, I hit the button, and it groaned to life, slowly lowering me down a dark shaft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "When it stopped, I struggled with the basement panels, fi..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "When it stopped, I struggled with the basement panels, finally prying them open and stumbling into the dimly lit space."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I made my way down a narrow aisle of archival books.  At ..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "I made my way down a narrow aisle of archival books.  At the end, I found an old rolling shelf Titus told me about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Sliding it aside revealed the hidden passageway, where I ..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "My sense of direction slipped away as I lost all sense of time, until finally, I emerged deep within the palace grounds, disoriented but free."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "After what felt like an eternity, I reached the safety of the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.BirthdayGathering_Protests_AllowedOnSqua..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "The moment I was inside, we sped away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "My plans may have unraveled, but at least I'd made it out..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "Step inside tunnel."]** — Mówca: **Player_Romus_Italic**
> "I stepped inside the tunnel, swallowed by darkness. With no light to guide me, I moved blindly, the walls closing in."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "My sense of direction slipped away as I lost all sense of..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Sliding it aside revealed the hidden passageway, where I was greeted by the musty smell of stale air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus_Italic: "Step inside tunnel."*)
  - -> `[185]` (*Player_Romus_Italic: "Hide."*)
  - -> `[186]` (*Player_Romus_Italic: "Double back to the library."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "Hide."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk the dangers of the tunnel,  I changed my mind and searched for a secluded spot among the rows of dusty shelves. I lost all sense of time as I stayed out of sight."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "Double back to the library."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk the dangers of the tunnel,  I changed my mind and retreated up a back stairwell until I reemerged into the main hall."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[188]`
Mówca: **Narrator**
> ""Go! We'll cover you!" they yelled, as bullets rained all around them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[191]` (*Player_Romus_Italic: "Hold position and wait for reinforcements."*)
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[152]` (*Player_Romus_Italic: "Double back and find an alternate escape route."*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "Run for the stairs."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the stairs. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "With the men providing cover, I eventually made it."*)

### Węzeł `[190]`
**[WYBÓR GRACZA: "Push nearby book cart toward House security."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the House security guards."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "It crashed into a nearby bookshelf, sending dozens of boo..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "Hold position and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I held my position, deciding it was best to wait for backup."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "And just when escape felt within reach, both Guardsmen were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[193]`
Mówca: **Narrator**
> "It crashed into a nearby bookshelf, sending dozens of books down on top of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "The guards were momentarily distracted, giving the Golden Guard the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Seizing the moment, I dashed for the stairs."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Pain shot through my body, but I forced myself to remain standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Then another shot rang out, and my legs immediately gave ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Then another shot rang out, and my legs immediately gave way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monarchy_Meets_Muzzle_Hub]"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "Double back and find an alternate escape route."]** — Mówca: **Player_Romus_Italic**
> "I doubled back, unwilling to take that risk, and searched for an alternate escape route."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "As I retracted my steps, the gunfire eventually subsided,..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[199]`
Mówca: **Narrator**
> "As I retracted my steps, the gunfire eventually subsided, but it was unclear what had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "However, I was soon spotted, and a guard unleashed a volley of shots in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I made my way down the stairs until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Adrenaline surged through my veins. Before long, one of them noticed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: ""Go! We'll cover you!" they yelled, as bullets rained all..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "With the men providing cover, I eventually made it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)

### Węzeł `[204]`
Mówca: **Narrator**
> "The cool night air greeted me as I spilled out from the rooftop exit and hurried to the fire escape leading down to the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "From this vantage, I could see the angry mob of protester..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "From this vantage point, I could see the usual street sce..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Looking up, my eyes fixed on a nearby building across from the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "Leap to nearest rooftop."]** — Mówca: **Player_Romus_Italic**
> "I decided to take the leap to the nearest rooftop."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "Take fire escape."]** — Mówca: **Player_Romus_Italic**
> "I quickly descended the fire escape."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "I could either take my chances in the alley or head into ..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "Go back inside."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to risk putting myself at the mercy of an angry mob or falling to my death, I turned around and went back inside."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` AND `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I made my way down the stairs until I emerged back into t..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Seizing the moment, I dashed for the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "With the men providing cover, I eventually made it."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorti..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monarchy_Meets_Muzzle_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "Monarchy_Meets_Muzzle_Hub"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "I had been spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Pain shot through my body, but I forced myself to remain ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "They demanded that I drop my weapon and surrender."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_PickUpGun"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "They demanded that I put my hands in the air and surrender."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack rang out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I had been spotted."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "Run for the stairs."]** — Mówca: **Player_Romus_Italic**
> "I ran for the stairs. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "However, just before I reached it, a sharp crack rang out."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "From this vantage, I could see the angry mob of protesters down below, yelling and jeering anti-Crown sentiments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "I spotted my motorcade parked nearby as well."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Pushing past the ache in my leg, I sprinted and leapt for the opposite rooftop, but the pain wrenched mid-air, and I stumbled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "My fingers scraped the ledge before I plummeted into the ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Pushing past the ache in my leg, I sprinted and leapt for..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Taking a deep breath, I stepped back, then sprinted and l..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Taking a deep breath, I stepped back, then sprinted and leapt across the alley, landing hard but steady on the opposite rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Spotting the motorcade parked nearby, I hurried to anothe..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA: "Run for the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the dumbwaiter. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "However, just before I reached it, a sharp crack echoed f..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "I could either take my chances in the alley or head into the street, blending in with the crowd to avoid being spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus_Italic: "Go down the alley."*)
  - -> `[262]` (*Player_Romus_Italic: "Head into the street."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Archive _Jump_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Everything blurred past as I ran into the main hall darti..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Archive _Jump_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "Archive _Jump_Hub"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus_Italic: "Dash across the open space toward the exit."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus_Italic: "Dash across the open space toward the front desk."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "Dash across the open space toward the front desk."]** — Mówca: **Player_Romus_Italic**
> "I made a mad dash across the open space toward the front desk. Adrenaline surged as my heart pounded in my chest while I pushed forward."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "However, just before I reached it, a sharp crack echoed f..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus_Italic: "Run for the exit."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus_Italic: "Run for the dumbwaiter."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "However, just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "But just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ah_Shoot_Hub]"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "Dash across the open space toward the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "With the immediate threat eliminated I made a mad dash across the open space toward the dumbwaiter."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator), `[542]` (Narrator), `[546]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "My heart pounded in my chest as I did. But just before I ..."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "After what felt like an eternity, I made it behind the librarian's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "Dumbwaiter_Hub"*)

### Węzeł `[244]`
Mówca: **Narrator**
> "After what felt like an eternity, I made it behind the librarian's desk, breathless but still alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "Jump to: [Dumbwaiter_Hub]"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "After what felt like an eternity, I reached the safety of..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "After what felt like an eternity, I reached the librarian..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "I didn't stop until I was through the doorway and into th..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "After what felt like an eternity, I made it behind the li..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "My heart pounded in my chest as I did. But just before I reached it, a sharp crack echoed from above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Ah_Shoot_Hub"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus_Italic: "Mad dash across the open space toward the exit."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus_Italic: "Dash across the open space toward the dumbwaiter."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Dumbwaiter_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "I slid back an unassuming wooden panel on the back wall, ..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "I slid back an unassuming wooden panel on the back wall, revealing a dumbwaiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Squeezing inside, I hit the button, and it groaned to lif..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "I wasn't as athletic as I once was, especially after the ..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "I wasn't as athletic as I used to be, but it appeared to ..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "From this vantage point, I could see the usual street scene below, with people going about their business, unaware of turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "I spotted my motorcade parked nearby as well."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "I spotted my motorcade parked nearby as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Looking up, my eyes fixed on a nearby building across fro..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "Head into the street."]** — Mówca: **Player_Romus_Italic**
> "I kept my head down and stepped into the street, weaving through the crowd, careful not to draw attention."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "I wasn't as athletic as I once was, especially after the injury I sustained from my kidnapping years ago, but it seemed within jumping distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "I wasn't as athletic as I used to be, but it appeared to be within jumping distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "Run for the dumbwaiter."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the dumbwaiter. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "But just before I reached it, a sharp crack echoed from a..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus_Italic: "Run for the exit."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus_Italic: "Run for the dumbwaiter."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == ..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "After what felt like an eternity, I reached the safety of..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "After what felt like an eternity, I made it behind the li..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "The main entrance was the most direct route out of the library, and closest to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == t..."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "But that would mean having to get past the checkpoint Titus spoke of -- if anyone was still manning it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == t..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol ==..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol"] == true  or Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "But that would mean having to get past the checkpoint Tit..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol == true ||RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_EntryProtocol"] == true  or Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "It was the most heavily guarded, but if the unrest caused..."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Not to mention, risking a confrontation with the protesters gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Not to mention, risking a confrontation with the proteste..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "It was the most heavily guarded, but if the unrest caused the guards to leave their posts, the entrance would be temporarily vulnerable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "However, I'd also have to risk a confrontation with the p..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "However, I'd also have to risk a confrontation with the protesters gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "The was also the rooftop evacuation route that Titus briefed me on. From there I could take the fire escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "The was also the rooftop evacuation route that Titus brie..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "I could also try to make it up to the rooftop, though I d..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "I could also try to make it up to the rooftop, though I didn't know where I'd be able to go from there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "My only other option was to get to the basement archive l..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "My only other option was to get to the basement archive l..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "My only other option was to get to the basement archive level and take the secret tunnel that connected the library and the Palace -- that or make it to the closest designated safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[295]`
Mówca: **Narrator**
> "My only other option was to get to the basement archive level and take the secret tunnel that connected the library and the Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus_Italic: "Leave through front entrance."*)
  - -> `[4]` (*Player_Romus_Italic: "Take spiral staircase to roof."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true"*)

### Węzeł `[297]`
**[WYBÓR GRACZA: "Flee to nearest safe room."]** — Mówca: **Player_Romus_Italic**
> "I decided to flee to the nearest safe room, the book vault, tucked just behind the spiral staircase in the back of the main hall."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Kontekst wejściowy (poprzednik):** `[294]` (Narrator), `[295]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeR..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "Built as a space for rare books and private collections, its reinforced doors and secure locks would hold up until the threat was neutralized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Everything blurred past as I darted between bookshelves."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Player_Romus_Italic: "Flee to nearest safe room."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TitusTalk_SecurityHub_Emergency"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus_Italic: "Sprint directly toward the spiral staircase."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player_Romus_Italic: "Sprint directly toward the book vault."*)

### Węzeł `[305]`
**[WYBÓR GRACZA: "Sprint directly toward the book vault."]** — Mówca: **Player_Romus_Italic**
> "Without a second thought, I sprinted directly toward the book vault. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[555]` (Narrator), `[556]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "However, just before I reached it, a sharp crack rang out."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus_Italic: "Run for the stairs."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus_Italic: "Run for the book vault."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: "Run for the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I bolted for the book vault. Adrenaline surged as I pressed on, every second feeling like an eternity."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "With the men providing cover, I eventually made it."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus_Italic: "Dash to the staircase."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus_Italic: "Dash to the book vault."*)

### Węzeł `[313]`
**[WYBÓR GRACZA: "Dash to the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, I dashed for the book vault."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[413]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "However, I was soon spotted, and a guard unleashed a voll..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "He missed. I didn't stop until I'd reached the stairs."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "He missed. I didn't stop until I'd reached the vault door..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "He missed. I didn't stop until I'd reached the vault door. With the combination clicked into place, I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I flicked on the light, revealing rows of old manuscripts..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Dumbwaiter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "Dumbwaiter_Hub"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Dumbwaiter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "Dumbwaiter_Hub"*)

### Węzeł `[320]`
Mówca: **Narrator**
> "I flicked on the light, revealing rows of old manuscripts and books, some hundreds of years old, stacked neatly on the shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "I sank into a chair, waiting for the upheaval outside to end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Minutes felt like hours, and before long, the gunfire subsided, and my solitude was interrupted by the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[323]`
Mówca: **Narrator**
> "My stomach sank when Titus, flanked by several Golden Guardsmen, stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[324]`
Mówca: **Narrator**
> "It hit me then that they obviously knew about the safe room and the combination to get in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[325]`
Mówca: **Titus Gordion**
> ""If you would be so kind as to step out of the vault and follow me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I did as I was told. As I was escorted out, I overheard t..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "I did as I was told. As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "Jump to: [Vault_Caught_Hub]"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Vault_Caught_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Vault_Caught_Hub"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or 
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "Hours passed in uneasy silence. Finally, the sound of the..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true ||
RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or 
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Minutes felt like hours, and before long, the gunfire sub..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "Hours passed in uneasy silence. Finally, the sound of the door unlocking broke through my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "I looked up, expecting the worst, but instead, Titus step..."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "I looked up, expecting the worst, but instead, Titus stepped through the door, his face pale, bandages wrapped around his midsection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Player_Romus: ""Is it safe to come out?""*)
  - -> `[336]` (*Player_Romus: ""What took you so long?""*)
  - -> `[334]` (*Player_Romus: ""Oh my God, Titus! Are you alright?""*)
  - -> `[333]` (*Player_Romus: ""Titus! What happened?""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Titus Gordion: ""The House forces overwhelmed us, but we called in reinfo..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh my God, Titus! Are you alright?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Titus Gordion: ""A little banged up, but I'll manage.""*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it safe to come out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Titus Gordion: ""Yes, Your Majesty. Sorry we couldn't reach you sooner. A..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What took you so long?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Titus Gordion: ""As you can see, I had some... complications.""*)

### Węzeł `[337]`
Mówca: **Titus Gordion**
> ""The House forces overwhelmed us, but we called in reinforcements, and we have them at bay for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player_Romus: ""What about my family?""*)
  - -> `[344]` (*Player_Romus: ""This is all my fault.""*)
  - -> `[343]` (*Player_Romus: ""How could you let this happen?""*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[353]` (*Player_Romus: ""Next time, I’ll consider a more exclusive guest list. No..."*)

### Węzeł `[338]`
Mówca: **Titus Gordion**
> ""A little banged up, but I'll manage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Titus Gordion: ""The House forces overwhelmed us, but we called in reinfo..."*)

### Węzeł `[339]`
Mówca: **Titus Gordion**
> ""As you can see, I had some... complications.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Titus Gordion: ""The House forces overwhelmed us, but we called in reinfo..."*)

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. Sorry we couldn't reach you sooner. As you can see, we had some... complications.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Titus Gordion: ""The House forces overwhelmed us, but we called in reinfo..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about my family?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Titus Gordion: ""Don't worry. They've been taken to a secure location. Wh..."*)

### Węzeł `[342]`
Mówca: **Titus Gordion**
> ""Don't worry. They've been taken to a secure location. What's most important is getting you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeR..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could you let this happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""Sometimes, no matter how much preparation you have, life..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all my fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Titus Gordion: ""No one could have predicted this, Your Majesty.""*)

### Węzeł `[345]`
Mówca: **Titus Gordion**
> ""Sometimes, no matter how much preparation you have, life has a way of throwing unexpected challenges your way. We did everything we could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Titus Gordion: ""But come, let's get you out of here.""*)

### Węzeł `[346]`
Mówca: **Titus Gordion**
> ""But come, let's get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeR..."*)

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""No one could have predicted this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Titus Gordion: ""Sometimes, no matter how much preparation you have, life..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""I need a drink.""*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a drink.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Kontekst wejściowy (poprzednik):** `[337]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Titus Gordion: ""I'm sure we could arrange that, but right now, we need t..."*)

### Węzeł `[352]`
Mówca: **Titus Gordion**
> ""I'm sure we could arrange that, but right now, we need to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeR..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Next time, I’ll consider a more exclusive guest list. No need for the Houses to crash the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Titus Gordion: ""Good idea. But come, let's get you out of here.""*)

### Węzeł `[354]`
Mówca: **Titus Gordion**
> ""Good idea. But come, let's get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeR..."*)

### Węzeł `[355]`
Mówca: **Narrator**
> "Titus escorted me through the blood-streaked halls of the library, past fallen guards and intruders alike."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "The motorcade stood ready as I stepped outside. Titus ope..."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "The motorcade stood ready as I stepped outside. Titus opened the door to the lead car, and once inside, we sped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "My plans may have unraveled, but at least I'd made it out..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "He kept a hand pressed firmly against his side."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "It hit me then that they obviously knew about the safe ro..."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "He kept a hand pressed firmly against his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "It hit me then that they obviously knew about the safe ro..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true )"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "Titus approached with a hand pressed firmly against his s..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "Titus approached."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "Titus approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[365]`
Mówca: **Narrator**
> "Titus approached with a hand pressed firmly against his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[366]`
Mówca: **Titus Gordion**
> "“Your little insurrection has been crushed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Titus Gordion: ""By the authority vested in me, I hereby declare King Rom..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true )"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Titus Gordion: "“Adarfo’s dead, and your pathetic little rebellion has en..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Titus Gordion: "“Your little insurrection has been crushed.""*)

### Węzeł `[370]`
Mówca: **Titus Gordion**
> "“Adarfo’s dead, and your pathetic little rebellion has ended in failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Titus Gordion: ""By the authority vested in me, I hereby declare King Rom..."*)

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""By the authority vested in me, I hereby declare King Romus is to be taken into custody for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "I wanted more than anything to deny his accusation and pr..."*)

### Węzeł `[372]`
Mówca: **Narrator**
> "I wanted more than anything to deny his accusation and protest his actions, but I didn't have the strength to resist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Vault_Caught_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[374]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "I unexpectedly crashed into Adarfo, who was taking cover under there as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player_Romus: ""Hiding now, are we? Not quite the leader of the revoluti..."*)
  - -> `[379]` (*Player_Romus: ""I trusted you, Adarfo. And this is where it’s led us.""*)
  - -> `[381]` (*Player_Romus: ""Funny, isn't it? You wanted to topple a king, and here w..."*)
  - -> `[382]` (*Player_Romus: ""I can't believe this is happening.""*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trusted you, Adarfo. And this is where it’s led us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Adarfo Sotelato: ""Don't you dare try to pin this on me! This is where *you..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hiding now, are we? Not quite the leader of the revolution I envisioned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Adarfo Sotelato: ""And yet here you are, reduced to my level. You're to bla..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Funny, isn't it? You wanted to topple a king, and here we are, both groveling in the dirt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Adarfo Sotelato: ""Don’t mistake my position for defeat! You’ll answer for ..."*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe this is happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Adarfo Sotelato: ""Believe it! Your arrogance brought us to this moment. Th..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player_Romus: ""So how's your day going?""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So how's your day going?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[378]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "Adarfo glared at me coldly, not saying a word."*)

### Węzeł `[387]`
Mówca: **Narrator**
> "Adarfo glared at me coldly, not saying a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[388]`
Mówca: **Adarfo Sotelato**
> ""Believe it! Your arrogance brought us to this moment. This is all your fault!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[389]`
Mówca: **Adarfo Sotelato**
> ""Don’t mistake my position for defeat! You’ll answer for what you’ve done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[390]`
Mówca: **Adarfo Sotelato**
> ""Don't you dare try to pin this on me! This is where *you* led us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""And yet here you are, reduced to my level. You're to blame for this disaster!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Several shots immediately struck the top of the table, sp..."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "Several shots immediately struck the top of the table, splintering wood and sending fragments flying, but we remained protected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "However, the moment we crawled out from underneath, we'd ..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "However, the moment we crawled out from underneath, we'd be exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus_Italic: "Wait for a lull in the gunfire."*)
  - -> `[34]` (*Player_Romus_Italic: "Kick over a nearby chair to create a distraction."*)
  - -> `[33]` (*Player_Romus_Italic: "Quickly dash to the nearest book stack."*)
  - -> `[394]` (*Player_Romus_Italic: "Push Adarfo out from underneath to create a distraction."*)

### Węzeł `[394]`
**[WYBÓR GRACZA: "Push Adarfo out from underneath to create a distraction."]** — Mówca: **Player_Romus_Italic**
> "I grabbed Adarfo by the collar, using all my strength to push him out from under the desk."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "His hands clawing at mine in a desperate attempt to break..."*)

### Węzeł `[395]`
Mówca: **Narrator**
> "His hands clawing at mine in a desperate attempt to break free. With a final heave, I pushed him out from underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "In an instant, as gunfire tore through the air, and he cr..."*)

### Węzeł `[396]`
Mówca: **Narrator**
> "In an instant, as gunfire tore through the air, and he crumpled to the ground, dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed = true; RiziaDLCIsolated.Birthda..."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "With all eyes on Adarfo, I had a clear path to get away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Before long, I was just a few feet away from the staircase."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "With all eyes on Adarfo, I had a clear path to get away."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Revea..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "As I continued moving, the bookshelves kept me concealed,..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "Adarfo, however, wasn't so fortunate."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "Adarfo, however, wasn't so fortunate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "As he tried to scramble to his feet, gunfire tore through..."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "As he tried to scramble to his feet, gunfire tore through the air, and he crumpled to the ground, dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed = true; RiziaDLCIsolated.Birthda..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "As I continued moving, the bookshelves kept me concealed,..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "As I continued moving, the bookshelves kept me concealed, and before I knew it, I reached the spiral staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorti..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Revea..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Before long, I was just a few feet away from the staircase."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Narrator: "Adarfo followed my lead, and we managed to slip away. Bef..."*)

### Węzeł `[410]`
Mówca: **Narrator**
> "Adarfo followed my lead, and we managed to slip away. Before long, we were just a few feet away from the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Narrator: "I hesitated, realizing that any movement upward would sur..."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should double back. Without any cover, we'd be sitting ducks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Adarfo Sotelato: ""Do what you like, but I'm not staying here a minute long..."*)

### Węzeł `[412]`
Mówca: **Narrator**
> "I hesitated, realizing that any movement upward would surely leave us dangerously exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: ""We should double back. Without any cover, we'd be sittin..."*)
  - -> `[416]` (*Player_Romus: ""We need to proceed with caution. Who knows what's waitin..."*)
  - -> `[417]` (*Player_Romus: ""Alright, let's go!""*)

### Węzeł `[413]`
Mówca: **Narrator**
> "I hesitated, realizing that any movement upward would surely leave us dangerously exposed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[36]` (*Player_Romus_Italic: "Duck and weave through the book stacks."*)
  - -> `[197]` (*Player_Romus_Italic: "Double back and find an alternate escape route."*)

### Węzeł `[414]`
Mówca: **Adarfo Sotelato**
> ""Do what you like, but I'm not staying here a minute longer than I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "Adarfo hurried up the stairs. Shots were fired at him, ho..."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "Adarfo hurried up the stairs. Shots were fired at him, however, I didn't wait to see if managed to evade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "As I retracted my steps, the gunfire eventually subsided,..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to proceed with caution. Who knows what's waiting for us if we make a run for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Adarfo Sotelato: ""Agreed. No point being too hasty.""*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, let's go!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Adarfo Sotelato: ""After you, *Your Majesty*.""*)

### Węzeł `[418]`
Mówca: **Adarfo Sotelato**
> ""Agreed. No point being too hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I ducked and weaved my way through the bookstack. Doing s..."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "I ducked and weaved my way through the bookstack. Doing so kept us concealed, and before long, we'd reached the spiral staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorte..."*)

### Węzeł `[420]`
Mówca: **Adarfo Sotelato**
> ""After you, *Your Majesty*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)

### Węzeł `[421]`
Mówca: **Narrator**
> "I ignored his sarcasm as we dashed for the staircase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "However, we were soon spotted, and a guard unleashed a vo..."*)

### Węzeł `[422]`
Mówca: **Narrator**
> "However, we were soon spotted, and a guard unleashed a volley of shots in our direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)

### Węzeł `[423]`
Mówca: **Narrator**
> "He missed. We didn't stop until we'd reached the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorte..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "He missed. We didn't stop until we'd reached the stairs."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "He missed. We didn't stop until we'd reached the vault do..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "I ignored his sarcasm as we dashed for the staircase."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player_Romus_Italic: "Dash to the book vault."*)

### Węzeł `[430]`
**[WYBÓR GRACZA: "Dash to the book vault."]** — Mówca: **Player_Romus_Italic**
> "Seizing the moment, we dashed for the book vault."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[420]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "However, we were soon spotted, and a guard unleashed a vo..."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "He missed. We didn't stop until we'd reached the vault door. With the combination clicked into place, Adarfo and I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I flicked on the light, revealing rows of old manuscripts..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Revea..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "I sank into a chair, waiting for the upheaval outside to ..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Narrator: "I sank into a chair, waiting for the upheaval outside to ..."*)

### Węzeł `[435]`
Mówca: **Adarfo Sotelato**
> ""This was a mistake. I should've known better than to trust a monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player_Romus: ""We’re still alive. That's more than you can say for your..."*)
  - -> `[438]` (*Player_Romus: ""Don’t mistake our situation for a failure. We’ll find a ..."*)
  - -> `[439]` (*Player_Romus: ""We may die, but the revolution never will.""*)
  - -> `[440]` (*Player_Romus: ""Why don’t you keep complaining? Surely, that’ll solve ev..."*)

### Węzeł `[436]`
Mówca: **Narrator**
> "I sank into a chair, waiting for the upheaval outside to end, while Adarfo paced about. Minutes felt like hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "Adarfo abruptly slammed his hand against a shelf."*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’re still alive. That's more than you can say for your stupid movement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Before I realized what was happening, Adarfo threw me aga..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t mistake our situation for a failure. We’ll find a way to come out on top.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Adarfo Sotelato: ""The only thing we’re coming out of is this vault, when t..."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may die, but the revolution never will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Narrator: "He cracked a half-smile."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don’t you keep complaining? Surely, that’ll solve everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[435]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Before I realized what was happening, Adarfo threw me aga..."*)

### Węzeł `[441]`
Mówca: **Narrator**
> "Adarfo abruptly slammed his hand against a shelf."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Adarfo Sotelato: ""This was a mistake. I should've known better than to tru..."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "Before I realized what was happening, Adarfo threw me against the floor and had me by the throat. I struggled to fight back, but his grip was unrelenting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "Everything began to turn black. But it was at that moment..."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "Everything began to turn black. But it was at that moment that I heard the doors to the vault click open, followed by a loud commotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Narrator: "When I came to, my stomach sank as I found myself looking..."*)

### Węzeł `[444]`
Mówca: **Adarfo Sotelato**
> ""The only thing we’re coming out of is this vault, when they decide it’s time to drag us out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Narrator: "And that's exactly what happened. As if on cue, we heard ..."*)

### Węzeł `[445]`
Mówca: **Narrator**
> "When I came to, my stomach sank as I found myself looking up at Titus, flanked by several guards holding rifles. Adarfo lay nearby, not moving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[446]`
Mówca: **Narrator**
> "And that's exactly what happened. As if on cue, we heard the gunfire subside and the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Narrator: "Without warning, Adarfo charged toward our guests, scream..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Titus Gordion: ""If you would be so kind as to step out of the vault and ..."*)

### Węzeł `[450]`
Mówca: **Narrator**
> "Without warning, Adarfo charged toward our guests, screaming and waving his fists, before he was gunned down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Executed = true; RiziaDLCSupport.Journal_..."*)

### Węzeł `[451]`
Mówca: **Narrator**
> "It took a moment for my hearing to recover and make out what Titus was saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Titus Gordion: ""Step out of the vault and follow me, Your Majesty.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Narrator: "It took a moment for my hearing to recover and make out w..."*)

### Węzeł `[453]`
Mówca: **Titus Gordion**
> ""Step out of the vault and follow me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I did as I was told. As I was escorted out, I overheard t..."*)

### Węzeł `[454]`
Mówca: **Narrator**
> "I rushed upward, the dizzying speed of my ascent distorted the frenzy below as Adarfo and I escaped the library’s violent interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Narrator: "The cool night air greeted us as we spilled out from the ..."*)

### Węzeł `[455]`
Mówca: **Narrator**
> "The cool night air greeted us as we spilled out from the rooftop exit and hurried to the fire escape leading down to the alley."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal ..."*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Revea..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus_Italic: "Take fire escape."*)
  - -> `[209]` (*Player_Romus_Italic: "Leap to nearest rooftop."*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Player_Romus: ""We should take the fire escape.""*)
  - -> `[460]` (*Player_Romus: ""Jumping would be our safest option.""*)
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[468]` (*Player_Romus: ""There's no honor in running away. I'll be perceived as a..."*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take the fire escape.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Adarfo Sotelato: ""If you want to take the fire escape, be my guest. But I'..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Jumping would be our safest option.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Adarfo Sotelato: ""Yes, it does seem like the best chance to avoid detection.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not about to put myself at the mercy of an angry mob or risk plummeting to my death. I'm going back inside.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` AND `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Adarfo Sotelato: ""The mob is your problem. Not mine.""*)

### Węzeł `[462]`
Mówca: **Adarfo Sotelato**
> ""Yes, it does seem like the best chance to avoid detection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Narrator: "Without a second thought, Adarfo gave himself a running s..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus_Italic: "Go back inside."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player_Romus_Italic: "Go back inside to face the consequences of your choices."*)

### Węzeł `[466]`
**[WYBÓR GRACZA: "Go back inside to face the consequences of your choices."]** — Mówca: **Player_Romus_Italic**
> "I realized that I had to face the consequences of my choices head-on."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false` AND `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "I turned around and went back inside."*)

### Węzeł `[467]`
Mówca: **Narrator**
> "I turned around and went back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I made my way down the stairs until I emerged back into t..."*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no honor in running away. I'll be perceived as a coward. I have to go back and face the consequences of my actions head-on.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[263]` (Narrator), `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Adarfo Sotelato: ""Then you're a fool. There's only possible way that will ..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus: ""No. I'm not about to put myself at the mercy of an angry..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[472]`
Mówca: **Adarfo Sotelato**
> ""Then you're a fool. There's only possible way that will turn out. And I'm not about to let that happen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "Without a second thought, Adarfo gave himself a running s..."*)

### Węzeł `[473]`
Mówca: **Narrator**
> "Without a second thought, Adarfo gave himself a running start before leaping to the other rooftop. He took one last look at me before vanishing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = ..."*)

### Węzeł `[474]`
Mówca: **Narrator**
> "I, on the other hand, turned back around and went inside. I then made my way down the stairs until I emerged back into the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[476]`
Mówca: **Narrator**
> "Without a second thought, Adarfo gave himself a running start before leaping to the other rooftop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "He looked back and nodded his farewell before taking off,..."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "He looked back and nodded his farewell before taking off, vanishing without a trace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = ..."*)

### Węzeł `[478]`
Mówca: **Adarfo Sotelato**
> ""If you want to take the fire escape, be my guest. But I'll stick to where it's actually harder to get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Narrator: "Without a second thought, Adarfo gave himself a running s..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Adarfo Sotelato");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Narrator: "I, on the other hand, turned back around and went inside...."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "I unexpectedly crashed into Adarfo, who was taking cover ..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "I stopped when I spotted two House security guards crouch..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I stopped when I spotted two House security guards crouch..."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "I stopped when I spotted two House security guards crouched behind an overturned table, exchanging gunfire with the Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "My eyes were then drawn to a nearby dead guard, still clu..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "I stopped when I spotted two of Adarfo's men crouched beh..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "I stopped when I spotted two of Adarfo's men crouched beh..."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "I stopped when I spotted two of Adarfo's men crouched behind an overturned table, exchanging gunfire with the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "My eyes were then drawn to a nearby dead insurgent, still..."*)

### Węzeł `[490]`
Mówca: **Narrator**
> "I stopped when I spotted two of Adarfo's men crouched behind an overturned table, exchanging gunfire with the Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "My eyes were then drawn to a nearby dead insurgent, still..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus_Italic: "Create a distraction by knocking over a nearby vase."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[494]`
**[WYBÓR GRACZA: "Knock over a nearby vase as a distraction."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the Guardsmen's attention."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "With their backs momentarily turned, I had a clear path b..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus_Italic: "Duck and crawl beneath the banquet tables."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus_Italic: "Knock over a nearby vase as a distraction."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus_Italic: "Knock over a nearby vase as a distraction."*)

### Węzeł `[501]`
**[WYBÓR GRACZA: "Knock over a nearby vase as a distraction."]** — Mówca: **Player_Romus_Italic**
> "I chose to create a distraction by throwing a nearby vase across the room. It crashed against the floor, drawing the Guardians' attention."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Narrator), `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "With their backs momentarily turned, I had a clear path b..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus_Italic: "Duck and crawl beneath the banquet tables."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Player_Romus_Italic: "Duck and crawl beneath the banquet tables."*)

### Węzeł `[505]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several Wruhec's Guardians ran past."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable = t..."*)

### Węzeł `[506]`
**[WYBÓR GRACZA: "Duck and crawl beneath the banquet tables."]** — Mówca: **Player_Romus_Italic**
> "Crawling beneath the tables worked perfectly, allowing me to move through the room undetected, as several Golden Guardsmen ran past."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Hide_BanquetTable = t..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Then, to my horror, several House security guards, rifles..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "Then, to my horror, several Wruhec's Guardians, rifles ai..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "Then, to my horror, several Golden Guardsmen, rifles aime..."*)

### Węzeł `[513]`
Mówca: **Narrator**
> "Then, to my horror, several Wruhec's Guardians, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)

### Węzeł `[514]`
Mówca: **Narrator**
> "Then, to my horror, several Golden Guardsmen, rifles aimed in my direction, surrounded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_PickUpGun == true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[518]`
Mówca: **Narrator**
> "My eyes were then drawn to a nearby dead insurgent, still clutching his assault rifle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[14]` (*Player_Romus_Italic: "Hide behind a bookshelf and wait for reinforcements."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "But my aim was off, and the shot missed. The guards immed..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "But my aim was off, and the shot missed. The Guardians tu..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "But my aim was off, and the shot missed. The Golden Guard..."*)

### Węzeł `[526]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The Guardians turned and raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A sharp pain shot through my body, but I forced myself to..."*)

### Węzeł `[527]`
Mówca: **Narrator**
> "But my aim was off, and the shot missed. The Golden Guardsmen turned and raised their weapons in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "A sharp pain shot through my body, but I forced myself to..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The crack of gunfire rang out as I squeezed the trigger, ..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "The crack of gunfire rang out as I squeezed the trigger, ..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Narrator: "The crack of gunfire rang out as I squeezed the trigger, ..."*)

### Węzeł `[534]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the Guardians dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[535]`
Mówca: **Narrator**
> "The crack of gunfire rang out as I squeezed the trigger, and one of the Guardsmen dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "The second Guardian barely had time to react, scrambling ..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Narrator: "The second Guardsman barely had time to react, scrambling..."*)

### Węzeł `[542]`
Mówca: **Narrator**
> "The second Guardian barely had time to react, scrambling to reposition, but the rebels finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "The second guard barely had time to react, scrambling to ..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "The second guard barely had time to react, scrambling to ..."*)

### Węzeł `[546]`
Mówca: **Narrator**
> "The second guard barely had time to react, scrambling to reposition, but the Golden Guard finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[547]`
Mówca: **Narrator**
> "The second Guardsman barely had time to react, scrambling to reposition, but the rebels finished him off in a flurry of shots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_Archives == false"*)
  - -> `[48]` (*Player_Romus_Italic: "Move along the wall's edge."*)
  - -> `[50]` (*Player_Romus_Italic: "Hold position and wait for reinforcements."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "I spotted several Wruhec's Guardians positioned near a bo..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "I spotted several Golden Guardsmen positioned near a book..."*)

### Węzeł `[555]`
Mówca: **Narrator**
> "I spotted several Wruhec's Guardians positioned near a bookshelf, exchanging gunfire with House security forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[556]`
Mówca: **Narrator**
> "I spotted several Golden Guardsmen positioned near a bookshelf, exchanging gunfire with Adarfo's forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Narrator: "I spotted several Wruhec's Guardians positioned near a bo..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Narrator: "I spotted several Golden Guardsmen positioned near a book..."*)

### Węzeł `[560]`
Mówca: **Narrator**
> "I spotted several Wruhec's Guardians positioned near a bookshelf, exchanging gunfire with Adarfo's forces crouching behind an overturned table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Refor..."*)
  - -> `[27]` (*Player_Romus_Italic: "Move underneath central reading table."*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)

### Węzeł `[562]`
**[WYBÓR GRACZA: "Use a fallen bookshelf as cover and wait for reinforcements."]** — Mówca: **Player_Romus_Italic**
> "I took cover behind a fallen bookshelf, certain that reinforcements would arrive to turn the tide in our favor."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)`
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator), `[555]` (Narrator), `[556]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Eventually, the sounds of the battle began to fade. My pu..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Refor..."*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Ref..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Player_Romus_Italic: "Use a fallen bookshelf as cover and wait for reinforcements."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true) )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus_Italic: "Use a fallen bookshelf as cover and wait for reinforcements."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus_Italic: "Stay where you are."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus_Italic: "Stay where you are."*)

### Węzeł `[569]`
**[WYBÓR GRACZA: "Stay where you are."]** — Mówca: **Player_Romus_Italic**
> "I pushed that fear aside and decided to stay where I was, trusting my Adarfo's men to get the situation under control."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Adrenaline surged through my veins. Before long, one of t..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus_Italic: "Push nearby book cart toward House security."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Player_Romus_Italic: "Push nearby book cart toward the Guardians."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Player_Romus_Italic: "Push nearby book cart toward the Golden Guard."*)

### Węzeł `[576]`
**[WYBÓR GRACZA: "Push nearby book cart toward the Guardians."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the Guardians."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "It crashed into a nearby bookshelf, sending dozens of boo..."*)

### Węzeł `[577]`
**[WYBÓR GRACZA: "Push nearby book cart toward the Golden Guard."]** — Mówca: **Player_Romus_Italic**
> "Not wanting to leave my men to fend for themselves, I pushed a nearby book cart toward the Golden Guardsmen."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "It crashed into a nearby bookshelf, sending dozens of boo..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Narrator: "The guards were momentarily distracted, giving the Guardi..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "The guards were momentarily distracted, giving the Golden..."*)

### Węzeł `[584]`
Mówca: **Narrator**
> "The guards were momentarily distracted, giving the Guardians the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Seizing the moment, I dashed for the stairs."*)

### Węzeł `[585]`
Mówca: **Narrator**
> "The Guardians were momentarily distracted, giving the rebels the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Seizing the moment, I dashed for the stairs."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Narrator: "The Guardians were momentarily distracted, giving the reb..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Narrator: "The Guards were momentarily distracted, giving the rebels..."*)

### Węzeł `[589]`
Mówca: **Narrator**
> "The Guards were momentarily distracted, giving the rebels the opening they needed to take them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Seizing the moment, I dashed for the stairs."*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed = true;
RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = false; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed = true;
RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal = false; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Adarfo_Hiding_Reveal"] = false;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Executed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "And just when escape felt within reach, both Guardians we..."*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "And just when escape felt within reach, both Guardsmen we..."*)

### Węzeł `[596]`
Mówca: **Narrator**
> "And just when escape felt within reach, both Guardians were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Narrator: "And just when escape felt within reach, Adarfo's freedom ..."*)

### Węzeł `[600]`
Mówca: **Narrator**
> "And just when escape felt within reach, Adarfo's freedom fighters were gunned down right before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "Jump to: [BarrelOfTrouble_Hub]"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BarrelOfTrouble_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BarrelOfTrouble_Hub"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "My stomach sank when Titus, flanked by Captain Castellanu..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "My stomach sank when Titus, flanked by several Golden Gua..."*)

### Węzeł `[605]`
Mówca: **Narrator**
> "My stomach sank when Titus, flanked by Captain Castellanus and his Wruhec's Guardians, stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Sevrio Castellanus: ""Divus gidatu gaitu eta libratu gaitu.""*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[609]`
Mówca: **Sevrio Castellanus**
> ""Divus gidatu gaitu eta libratu gaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Narrator: "His words were at the ancient Wruhecist for, "The Lord ha..."*)

### Węzeł `[610]`
Mówca: **Narrator**
> "His words were at the ancient Wruhecist for, "The Lord has guided us and delivered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped = true;
RiziaDLC.SkipToEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arrested = true;
RiziaDLC.Epilogue_Prison_HouseFallouts = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Escape_King_Arrested"] = true;
Variable["RiziaDLC.Epilogue_Prison_HouseFallouts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_FrontDoor = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_FrontDoor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "Archive _Jump_Hub"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Roof"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Everything blurred past as I darted between bookshelves."*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom = true; RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "Built as a space for rare books and private collections, ..."*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunnel = true; RiziaDLCIsolated.Birthday_Gathering_Escape_Archives = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_Tunnel"] = true;
Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_Archives"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The nearest access was a dumbwaiter, once used to transpo..."*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom_TitusRescue = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_EscapeRoute_SafeRoom_TitusRescue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "Titus escorted me through the blood-streaked halls of the..."*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_ShotFromAbove = true;
RiziaDLC.SkipToEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_ShotFromAbove"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[620]`
Mówca: **Narrator**
> "I looked around for Vina and my mother. Neither were to be seen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Narrator: "I looked around for Vina and my mother. Neither were to b..."*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Narrator: "I looked around for my mother. I couldn't see her anywhere."*)

### Węzeł `[624]`
Mówca: **Narrator**
> "I looked around for my mother. I couldn't see her anywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false"*)

### Węzeł `[625]`
Mówca: **Narrator**
> "Emerging out into the main atrium, I saw a scene of pandemonium. Some of the invitees had taken up arms and were firing blindly at the attackers; others cowered behind library shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[626]`
**[WYBÓR GRACZA: "Make your escape."]** — Mówca: **Player_Romus_Italic**
> "The others could take care of themselves. I had to get out."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[633]` (Narrator), `[634]` (Narrator), `[646]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "The main entrance was the most direct route out of the li..."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Narrator: "One of Titus' men was pointing a gun at Pabel, demanding ..."*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Narrator: "One of the House forces was pointing a gun at Pabel, dema..."*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false"*)
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == false)"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Player_Romus: ""Don't hurt anyone! I surrender!""*)
  - -> `[626]` (*Player_Romus_Italic: "Make your escape."*)

### Węzeł `[633]`
Mówca: **Narrator**
> "One of Titus' men was pointing a gun at Pabel, demanding he tell him what he knew of my plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Player_Romus: ""Don't hurt anyone! I surrender!""*)
  - -> `[626]` (*Player_Romus_Italic: "Make your escape."*)

### Węzeł `[634]`
Mówca: **Narrator**
> "One of the House forces was pointing a gun at Pabel, demanding he tell him what he knew of my plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Player_Romus: ""Don't hurt anyone! I surrender!""*)
  - -> `[626]` (*Player_Romus_Italic: "Make your escape."*)

### Węzeł `[635]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't hurt anyone! I surrender!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pabel_Gone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[633]` (Narrator), `[634]` (Narrator), `[620]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As I was escorted out, I overheard the guards murmuring a..."*)

### Węzeł `[639]`
Mówca: **Narrator**
> "As I was escorted out, I overheard the guards murmuring about my betrayal of the kingdom. Lucita approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Lucita Azaro: ""Romus, sweetheart, I want a divorce.""*)

### Węzeł `[640]`
Mówca: **Lucita Azaro**
> ""Romus, sweetheart, I want a divorce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Peaceful Arrest`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "I soon found myself with my hands tied behind my back as ..."*)

### Węzeł `[642]`
Mówca: **Narrator**
> "The action froze. Everyone in the library stopped and stared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Arrest]"*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Narrator: "The guardsmen and the revolutionaries ignored me. The fir..."*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "The action froze. Everyone in the library stopped and sta..."*)

### Węzeł `[646]`
Mówca: **Narrator**
> "The guardsmen and the revolutionaries ignored me. The firefight continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Player_Romus: ""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS YOU!""*)
  - -> `[626]` (*Player_Romus_Italic: "Make your escape."*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Peaceful Arrest]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "Peaceful Arrest"*)

### Węzeł `[648]`
**[WYBÓR GRACZA: ""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS YOU!""]** — Mówca: **Player_Romus**
> ""I SAID, CEASE FIRE IMMEDIATELY! THE KING COMMANDS--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[646]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Narrator: "Before I could finish the words, something heavy hit the ..."*)

### Węzeł `[649]`
Mówca: **Narrator**
> "Before I could finish the words, something heavy hit the back of my head. I lost consciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Narrator: "I don't know how much time passed before Titus nudged me ..."*)

### Węzeł `[650]`
Mówca: **Narrator**
> "I don't know how much time passed before Titus nudged me awake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "Jump to: [Peaceful Arrest]"*)

### Węzeł `[651]`
Mówca: **Narrator**
> "He cracked a half-smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Adarfo Sotelato: ""You're right about that, Your Majesty.""*)

### Węzeł `[652]`
Mówca: **Adarfo Sotelato**
> ""You're right about that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Narrator: "As if on cue, we heard the gunfire subside and the sound ..."*)

### Węzeł `[653]`
Mówca: **Narrator**
> "As if on cue, we heard the gunfire subside and the sound of the door unlocking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Kidney_Punch == true"*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_LargerYourQuarry == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_LargerYourQuarry == true"*)
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_LargerYourQuarry == true)"*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_LargerYourQuarry == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_LargerYourQuarry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""The larger your quarry, the more important it is for you..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_LargerYourQuarry == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_LargerYourQuarry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Hugo Toras: ""You know what hunters say, my boy...""*)

### Węzeł `[657]`
Mówca: **Hugo Toras**
> ""You know what hunters say, my boy...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""The larger your quarry, the more important it is for you..."*)

### Węzeł `[658]`
Mówca: **Adarfo Sotelato**
> ""The mob is your problem. Not mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Narrator: "Without a second thought, Adarfo gave himself a running s..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Adarfo_Escaped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Adarfo Sotelato");"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true"*)
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true)"*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus_Italic: "Escape through secret tunnel."*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_SecretTunnel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_SecretTunnel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false"*)
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == ..."*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I rushed upward, the dizzying speed of my ascent distorti..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Escape_SafeRoom"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Narrator: "After entering the vault door combination, I stepped inside."*)

### Węzeł `[667]`
Mówca: **Narrator**
> "After entering the vault door combination, I stepped inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I flicked on the light, revealing rows of old manuscripts..."*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Rusty == true && Rizia..."*)
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Rusty == true && Riz..."*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.Rusty_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Narrator: "I saw Rusty watching from the other side of the room, a s..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Rusty == true && RiziaDLC.Rusty_PalantorPMCAvailable == false && RiziaDLC.Rusty_Allied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rusty"] == true  and  Variable["RiziaDLC.Rusty_PalantorPMCAvailable"] == false  and  Variable["RiziaDLC.Rusty_Allied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)

### Węzeł `[671]`
Mówca: **Narrator**
> "I saw Rusty watching from the other side of the room, a satisfied smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina"*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Deafening gunfire erupted all around me, but I kept moving."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Deafening gunfire erupted all around me, but I kept moving."*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Death_KilledByMob = true;
RiziaDLC.SkipToEpilogue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Death_KilledByMob"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_RevolutionaryFail = true"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Epilogue_Survived_BirthdayStrike = true"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_RevolutionaryFail = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped = tr..."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Epilogue_Survived_BirthdayStrike = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_King_Escaped = tr..."*)
