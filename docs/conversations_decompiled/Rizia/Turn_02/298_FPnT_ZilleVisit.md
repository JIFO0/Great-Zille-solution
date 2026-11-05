# Rizia/Turn 2/FPnT_ZilleVisit

- **ID konwersacji:** `298`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/298_FPnT_ZilleVisit.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 106
- **Modyfikacja moda Great Zille Solution:** *Wstrzyknięto opcję bezpośredniej groźby czołgami wobec Smolaka (`Zille_Smolak_FaceToFace_Choice`)*

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
- `RiziaDLC.CountryRelation_Wehlen_AtWar`
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
- `Zille_Smolak_Threatened`
- `Zille_War_Alfa`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Are you all right, Mother?""** | `[5]` **Narrator**: "My mother had insisted on accomp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Estela Toras**: ""I'm absolutely fine, darling."" |
| `[7]` | **""What are you thinking about?""** | `[5]` **Narrator**: "My mother had insisted on accomp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Estela Toras**: ""I'm thinking you ought to have ..." |
| `[8]` | **"Say nothing."** | `[5]` **Narrator**: "My mother had insisted on accomp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "After a short while, she broke t..." |
| `[13]` | **""Of course.""** | `[11]` **Estela Toras**: ""Say, might we have time for a q..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "She leaned forward and gave the ..." |
| `[14]` | **""No. I want to get this over with as fast as possible.""** | `[11]` **Estela Toras**: ""Say, might we have time for a q..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Estela Toras**: ""That's perfectly fine. Mind if ..." |
| `[20]` | **""*If* Zille is returned.""** | `[19]` **Estela Toras**: ""Promise me you'll get these hig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Factory smokestacks rose up on e..." |
| `[21]` | **""It's at the top of my list.""** | `[19]` **Estela Toras**: ""Promise me you'll get these hig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Factory smokestacks rose up on e..." |
| `[22]` | **"Say nothing."** | `[19]` **Estela Toras**: ""Promise me you'll get these hig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Factory smokestacks rose up on e..." |
| `[33]` | **""I can't believe this is the same place we used to go every summer.""** | `[32]` **Narrator**: "She blinked back tears." | `Variable["RiziaDLC.Prologue_Summer_Zille"]` | *Brak zmian stanu* | `[43]` **Narrator**: "She put a hand on my shoulder." |
| `[37]` | **""Don't be so dramatic, Mother. It's just a house.""** | `[32]` **Narrator**: "She blinked back tears." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "She glared at me." |
| `[38]` | **""Wehlen will pay for what happened to your homeland.""** | `[32]` **Narrator**: "She blinked back tears." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "She swallowed hard." |
| `[39]` | **""This is where you grew up?""** | `[32]` **Narrator**: "She blinked back tears." | `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false` | *Brak zmian stanu* | `[40]` **Narrator**: "She nodded." |
| `[55]` | **""They could have stayed. Plenty of Rizians did.""** | `[46]` **Narrator**: "I thought back to my carefree su..."<br>`[50]` **Narrator**: "I tried to summon memories of my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Estela Toras**: ""No. Not after that horrible civ..." |
| `[56]` | **""You did everything you could for them. They should have been more grateful.""** | `[46]` **Narrator**: "I thought back to my carefree su..."<br>`[50]` **Narrator**: "I tried to summon memories of my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Estela Toras**: ""Grateful for what? If I hadn't ..." |
| `[57]` | **""I'll have it fixed up one day. It'll be our summer home again.""** | `[46]` **Narrator**: "I thought back to my carefree su..."<br>`[50]` **Narrator**: "I tried to summon memories of my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Estela Toras**: ""That ship has sailed, child. Ju..." |
| `[63]` | **""Actually, Mr. President, this *is* my home. I spent my childhood summers here.""** | `[62]` **Wiktor Smolak (R)**: ""Welcome to Wehlen. Please, make..." | `Variable["RiziaDLC.Prologue_Summer_Zille"] == true` | *Brak zmian stanu* | `[68]` **Wiktor Smolak (R)**: ""Of course, of course. My home i..." |
| `[64]` | **""Thank you, Mr. President.""** | `[62]` **Wiktor Smolak (R)**: ""Welcome to Wehlen. Please, make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Wiktor Smolak (R)**: ""Who is this Mr. President? Call..." |
| `[66]` | **""Mr. President. I wish I could say I was happy to be here.""** | `[62]` **Wiktor Smolak (R)**: ""Welcome to Wehlen. Please, make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Wiktor Smolak (R)**: ""Why so glum, Your Majesty? How ..." |
| `[72]` | **""Ah, yes. Nothing symbolizes friendship like heavy artillery.""** | `[67]` **Narrator**: "He gestured out to the square, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Wiktor Smolak (R)**: ""Exactly! Who doesn't love tanks..." |
| `[73]` | **""Looks impressive. Where did you get those tanks?""** | `[67]` **Narrator**: "He gestured out to the square, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Wiktor Smolak (R)**: ""Rizia isn't Wehlen's only frien..." |
| `[74]` | **""It's my first time at one of these ceremonies. What's going to happen?""** | `[67]` **Narrator**: "He gestured out to the square, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Wiktor Smolak (R)**: ""The usual. I make a speech, you..." |
| `[77]` | **""I've been wanting to speak with you about the terms of this *friendship.*""** | `[67]` **Narrator**: "He gestured out to the square, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Wiktor Smolak (R)**: ""In due time, Your Majesty. Firs..." |
| `[96]` | **""Disgusting. This whole ceremony is a sham.""** | `[95]` **Estela Toras**: ""A captive audience. That would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "My mother and I took our seats. ..." |
| `[97]` | **""Nice idea. The crowd at my coronation sounded lackluster by comparison.""** | `[95]` **Estela Toras**: ""A captive audience. That would ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[87]` **Narrator**: "My mother and I took our seats. ..." |
| `[98]` | **""Maybe they're happy. They don't get many excuses for celebration around here.""** | `[95]` **Estela Toras**: ""A captive audience. That would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "My mother and I took our seats. ..." |
| `[99]` | **""Look at the sloppy way they're holding their guns. They have nothing on our recru..."** | `[95]` **Estela Toras**: ""A captive audience. That would ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[87]` **Narrator**: "My mother and I took our seats. ..." |
| `[105]` | **"Interject."** | `[94]` **Narrator**: "He stepped to the side and pulle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Wiktor Smolak (R)**: ""It'll be your turn to speak in ..." |
| `[106]` | **"Let Wiktor finish his speech."** | `[94]` **Narrator**: "He stepped to the side and pulle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Wiktor Smolak (R)**: ""Today, I am especially delighte..." |
| `[107]` | **""I stand before you at the dawning of a new era. The reign of Valero Toras is over.""** | `[120]` **Player_Romus**: ""Thank you, President Smolak.""<br>`[122]` **Player_Romus**: ""My fellow Rizians!""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 2 innych odgałęzień)* |
| `[108]` | **""You may not know it, but I am a grandson of Zille. The Queen Mother and I have de..."** | `[120]` **Player_Romus**: ""Thank you, President Smolak.""<br>`[122]` **Player_Romus**: ""My fellow Rizians!""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 2 innych odgałęzień)* |
| `[109]` | **""It is an honor to be here in Zille on the anniversary of our historic treaty.""** | `[120]` **Player_Romus**: ""Thank you, President Smolak.""<br>`[122]` **Player_Romus**: ""My fellow Rizians!""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 2 innych odgałęzień)* |
| `[111]` | **""Quiet. We're supposed to play nice, remember?""** | `[91]` **Narrator**: "He gestured meaningfully towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Wiktor Smolak (R)**: ""Together, we have overcome war,..." |
| `[112]` | **""I know. I can't believe this guy.""** | `[91]` **Narrator**: "He gestured meaningfully towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Wiktor Smolak (R)**: ""Together, we have overcome war,..." |
| `[113]` | **""What did you just say?""** | `[91]` **Narrator**: "He gestured meaningfully towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Estela Toras**: ""'May your testicles be stung by..." |
| `[119]` | **"Rise."** | `[118]` **Wiktor Smolak (R)**: ""Please give a warm welcome to K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Player_Romus**: ""Thank you, President Smolak.""<br>`[122]` **Player_Romus**: ""My fellow Rizians!""<br>*(oraz 2 innych odgałęzień)* |
| `[120]` | **""Thank you, President Smolak.""** | `[207]` **Narrator**: "I turned to face the crowd. The ..."<br>`[119]` **Player_Romus_Italic**: "I stood up. The Rizian side of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **""My fellow Rizians!""** | `[207]` **Narrator**: "I turned to face the crowd. The ..."<br>`[119]` **Player_Romus_Italic**: "I stood up. The Rizian side of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych odgałęzień)* |
| `[123]` | **""Brothers and sisters!""** | `[207]` **Narrator**: "I turned to face the crowd. The ..."<br>`[119]` **Player_Romus_Italic**: "I stood up. The Rizian side of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych odgałęzień)* |
| `[124]` | **""Long live our friendship!""** | `[216]` **Player_Romus**: ""As ATO encroaches on our contin..."<br>`[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("StandApplause"); ;` | `[128]` **Narrator**: "Both sides of the stands applaud..." |
| `[125]` | **""Glovurius axa Rizia!""** | `[216]` **Player_Romus**: ""As ATO encroaches on our contin..."<br>`[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...`<br>`PlaySoundEffect("StandApplause"); ;` | `[126]` **Narrator**: ""Glory to Rizia!" echoed the Riz..." |
| `[127]` | **""All hail Wehlen!""** | `[216]` **Player_Romus**: ""As ATO encroaches on our contin..."<br>`[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("StandApplause"); ;` | `[129]` **Narrator**: "Loud applause broke out from the..." |
| `[135]` | **""That's the first time I've heard of this tradition.""** | `[132]` **Narrator**: "There was a rumbling from behind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Estela Toras**: ""A Wiktor Smolak special."" |
| `[136]` | **""Those really are some impressive tanks.""** | `[132]` **Narrator**: "There was a rumbling from behind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Estela Toras**: ""We can thank his Eastern benefa..." |
| `[137]` | **""Sure... After you, Mr. Smolak.""** | `[132]` **Narrator**: "There was a rumbling from behind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Estela Toras**: ""A Wiktor Smolak special."" |
| `[145]` | **""Is that part of the program?""** | `[147]` **Narrator**: "Wiktor whipped his head around i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Estela Toras**: ""I don't--"" |
| `[146]` | **""Who was that?""** | `[147]` **Narrator**: "Wiktor whipped his head around i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Estela Toras**: ""I don't--"" |
| `[148]` | **""If he was so upstanding, he wouldn't have agreed to stomp out a democratic revolu..."** | `[85]` **Estela Toras**: ""The Wehzek president back then ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[150]` **Estela Toras**: ""What revolution? If those terro..." |
| `[151]` | **""It's not your fault. Father should have reneged on the agreement immediately afte..."** | `[85]` **Estela Toras**: ""The Wehzek president back then ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Estela Toras**: ""And made outright enemies of We..." |
| `[152]` | **""It was a period of instability across all of Merkopa. You were playing with fire.""** | `[85]` **Estela Toras**: ""The Wehzek president back then ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Estela Toras**: ""Would you have done any differe..." |
| `[157]` | **"Get down."** | `[260]` **Narrator**: "I turned towards the source of t..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Titus Gordion");` | `[244]` **Titus Gordion**: ""YOUR MAJESTY!"" |
| `[158]` | **"Run towards the stands."** | `[260]` **Narrator**: "I turned towards the source of t..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Titus Gordion");` | `[246]` **Titus Gordion**: ""YOUR MAJESTY! GET DOWN!"" |
| `[159]` | **"Run away from the stands."** | `[260]` **Narrator**: "I turned towards the source of t..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Titus Gordion");` | `[246]` **Titus Gordion**: ""YOUR MAJESTY! GET DOWN!"" |
| `[163]` | **""I had an interesting talk with Pabel recently.""** | `[5]` **Narrator**: "My mother had insisted on accomp..." | `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true` | *Brak zmian stanu* | `[164]` **Estela Toras**: ""Oh? I'm glad the two of you are..."<br>`[168]` **Estela Toras**: ""He talks? I always saw him as a..." |
| `[169]` | **""Was Father acting out of the ordinary the night of his death?""** | `[164]` **Estela Toras**: ""Oh? I'm glad the two of you are..."<br>`[168]` **Estela Toras**: ""He talks? I always saw him as a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Estela Toras**: ""Any more out of the ordinary th..." |
| `[170]` | **""When was the last time you saw Father? Before he died, I mean.""** | `[164]` **Estela Toras**: ""Oh? I'm glad the two of you are..."<br>`[168]` **Estela Toras**: ""He talks? I always saw him as a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Narrator**: "She arched an eyebrow." |
| `[171]` | **""Do you know about mandragora?""** | `[164]` **Estela Toras**: ""Oh? I'm glad the two of you are..."<br>`[168]` **Estela Toras**: ""He talks? I always saw him as a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Estela Toras**: ""I've never heard of her. Is she..." |
| `[177]` | **""Tell me again. How did you discover Father had died?""** | `[164]` **Estela Toras**: ""Oh? I'm glad the two of you are..."<br>`[168]` **Estela Toras**: ""He talks? I always saw him as a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "She arched an eyebrow." |
| `[181]` | **""Pabel thinks Father was poisoned.""** | `[176]` **Estela Toras**: ""I've never heard of her. Is she..."<br>`[180]` **Estela Toras**: ""Why do you ask?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"]...` | `[184]` **Estela Toras**: ""And they say butlers have no im..." |
| `[182]` | **""Never mind.""** | `[176]` **Estela Toras**: ""I've never heard of her. Is she..."<br>`[180]` **Estela Toras**: ""Why do you ask?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Estela Toras**: ""How cruel of you to pique my in..." |
| `[183]` | **""I'll tell you later.""** | `[176]` **Estela Toras**: ""I've never heard of her. Is she..."<br>`[180]` **Estela Toras**: ""Why do you ask?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Estela Toras**: ""How cruel of you to pique my in..." |
| `[188]` | **""Mother. What happened?""** | `[147]` **Narrator**: "Wiktor whipped his head around i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Estela Toras**: ""I don't--"" |
| `[189]` | **""None of this was Wehlen's fault. It was the superpowers trying to use the country..."** | `[85]` **Estela Toras**: ""The Wehzek president back then ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Estela Toras**: ""Nobody forced Wiktor Smolak to ..." |
| `[194]` | **""Actually, Mr. President, this *is* my mother's home.""** | `[62]` **Wiktor Smolak (R)**: ""Welcome to Wehlen. Please, make..." | `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false` | *Brak zmian stanu* | `[68]` **Wiktor Smolak (R)**: ""Of course, of course. My home i..." |
| `[195]` | **""It's heartening to see that Zille remains in good hands.""** | `[62]` **Wiktor Smolak (R)**: ""Welcome to Wehlen. Please, make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Wiktor Smolak (R)**: ""Yes, yes! This square used to b..." |
| `[198]` | **""My mistake. Please go on, Mr. President.""** | `[197]` **Wiktor Smolak (R)**: ""It'll be your turn to speak in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "Wiktor stared me down for a seco..." |
| `[199]` | **""Forgive me, but your words were so inspiring I couldn't stay quiet for a moment l..."** | `[197]` **Wiktor Smolak (R)**: ""It'll be your turn to speak in ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Varia...` | `[201]` **Narrator**: "Wiktor stared me down for a seco..." |
| `[200]` | **""You've said more than enough already.""** | `[197]` **Wiktor Smolak (R)**: ""It'll be your turn to speak in ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Varia...` | `[201]` **Narrator**: "Wiktor stared me down for a seco..." |
| `[209]` | **""My loyal subjects!""** | `[207]` **Narrator**: "I turned to face the crowd. The ..."<br>`[119]` **Player_Romus_Italic**: "I stood up. The Rizian side of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych odgałęzień)* |
| `[210]` | **""It pained me when my father signed away this beautiful part of Rizia. Yet I knew ..."** | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>`[218]` **Player_Romus**: ""I commend Wiktor Smolak for his..."<br>*(oraz 2 innych odgałęzień)* |
| `[211]` | **""Today marks a chance to make a clean break with the past and begin looking toward..."** | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>`[218]` **Player_Romus**: ""I commend Wiktor Smolak for his..."<br>*(oraz 2 innych odgałęzień)* |
| `[212]` | **""I know none of the Rizians here today asked for their homeland to be governed by ..."** | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>`[215]` **Player_Romus**: ""The past years have not been ea..."<br>*(oraz 2 innych odgałęzień)* |
| `[213]` | **""I will never forget what Wehlen did for my family and my country.""** | `[107]` **Player_Romus**: ""I stand before you at the dawni..."<br>`[108]` **Player_Romus**: ""You may not know it, but I am a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>`[218]` **Player_Romus**: ""I commend Wiktor Smolak for his..."<br>*(oraz 2 innych odgałęzień)* |
| `[214]` | **""I have come here to send Wiktor Smolak a warning. If Zille is not returned, he wi..."** | `[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>`[212]` **Player_Romus**: ""I know none of the Rizians here..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] = tr...`<br>`Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[228]` **Narrator**: "The crowd went completely silent..." |
| `[215]` | **""The past years have not been easy for any of you. But the time will soon come whe..."** | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>`[221]` **Player_Romus**: ""I know that I can count on the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[216]` | **""As ATO encroaches on our continent, it is vital that the nations of Southeastern ..."** | `[215]` **Player_Romus**: ""The past years have not been ea..."<br>`[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Player_Romus**: ""Long live our friendship!""<br>`[242]` **Player_Romus**: ""The King has spoken!""<br>*(oraz 2 innych odgałęzień)* |
| `[217]` | **""In one year, Rizia will resume governorship of Zille. But I hope that will not me..."** | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>`[221]` **Player_Romus**: ""I know that I can count on the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[218]` | **""I commend Wiktor Smolak for his exemplary leadership in the face of war and terro..."** | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[211]` **Player_Romus**: ""Today marks a chance to make a ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>`[221]` **Player_Romus**: ""I know that I can count on the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[219]` | **""To the Rizians here today, I say: Do not forget your motherland. Be ready to defe..."** | `[228]` **Narrator**: "The crowd went completely silent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych odgałęzień)* |
| `[220]` | **""I pledge to support Rizians and Wehzeks alike through the upcoming peaceful trans..."** | `[215]` **Player_Romus**: ""The past years have not been ea..."<br>`[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Player_Romus**: ""Long live our friendship!""<br>`[242]` **Player_Romus**: ""The King has spoken!""<br>*(oraz 2 innych odgałęzień)* |
| `[221]` | **""I know that I can count on the President of Wehlen to do what's best for Zille un..."** | `[215]` **Player_Romus**: ""The past years have not been ea..."<br>`[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Player_Romus**: ""Long live our friendship!""<br>`[242]` **Player_Romus**: ""The King has spoken!""<br>*(oraz 2 innych odgałęzień)* |
| `[222]` | **""Yet I commend Wiktor Smolak for his exemplary leadership in the face of war and t..."** | `[212]` **Player_Romus**: ""I know none of the Rizians here..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>`[221]` **Player_Romus**: ""I know that I can count on the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[225]` | **""I pledge to support Rizians and Wehzeks alike through the upcoming transfer of po..."** | `[228]` **Narrator**: "The crowd went completely silent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych odgałęzień)* |
| `[226]` | **""I call on the people of Rizia to resist your Wehzek oppressors. Remind them in wh..."** | `[228]` **Narrator**: "The crowd went completely silent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych odgałęzień)* |
| `[227]` | **""But I have come here to send Wiktor Smolak a warning. If Zille is not returned, h..."** | `[210]` **Player_Romus**: ""It pained me when my father sig..."<br>`[213]` **Player_Romus**: ""I will never forget what Wehlen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] = tr...`<br>`Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["R...` | `[228]` **Narrator**: "The crowd went completely silent..." |
| `[229]` | **""To my countrymen, I say: Be patient. A mere year from now, we will be reunited.""** | `[228]` **Narrator**: "The crowd went completely silent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych odgałęzień)* |
| `[230]` | **""Despite our political differences, Rizia and Wehlen have much in common. There's ..."** | `[215]` **Player_Romus**: ""The past years have not been ea..."<br>`[217]` **Player_Romus**: ""In one year, Rizia will resume ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Player_Romus**: ""Long live our friendship!""<br>`[242]` **Player_Romus**: ""The King has spoken!""<br>*(oraz 2 innych odgałęzień)* |
| `[231]` | **""Wiktor, I know you are a man of honor. When the time comes, you will do what is r..."** | `[219]` **Player_Romus**: ""To the Rizians here today, I sa..."<br>`[225]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Player_Romus**: ""Thank you and happy Friendship ..."<br>`[236]` **Player_Romus**: ""Glovurius axa Rizia!""<br>*(oraz 1 innych odgałęzień)* |
| `[232]` | **""The president of Wehlen believes these tanks will intimidate us. We will show him..."** | `[219]` **Player_Romus**: ""To the Rizians here today, I sa..."<br>`[225]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Player_Romus**: ""Thank you and happy Friendship ..."<br>`[236]` **Player_Romus**: ""Glovurius axa Rizia!""<br>*(oraz 1 innych odgałęzień)* |
| `[233]` | **""People of Wehlen, I invite you to stay in Zille once it is part of my kingdom aga..."** | `[219]` **Player_Romus**: ""To the Rizians here today, I sa..."<br>`[225]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Player_Romus**: ""Thank you and happy Friendship ..."<br>`[236]` **Player_Romus**: ""Glovurius axa Rizia!""<br>*(oraz 1 innych odgałęzień)* |
| `[234]` | **""On behalf of House Toras, there will be justice for what has been done to Zille.""** | `[219]` **Player_Romus**: ""To the Rizians here today, I sa..."<br>`[225]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Player_Romus**: ""Thank you and happy Friendship ..."<br>`[236]` **Player_Romus**: ""Glovurius axa Rizia!""<br>*(oraz 1 innych odgałęzień)* |
| `[235]` | **""Thank you and happy Friendship Day!""** | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "A few tentative claps came from ..." |
| `[236]` | **""Glovurius axa Rizia!""** | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[238]` **Narrator**: "A few tentative claps came from ..." |
| `[237]` | **""The King has spoken!""** | `[231]` **Player_Romus**: ""Wiktor, I know you are a man of..."<br>`[232]` **Player_Romus**: ""The president of Wehlen believe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "A few tentative claps came from ..." |
| `[242]` | **""The King has spoken!""** | `[216]` **Player_Romus**: ""As ATO encroaches on our contin..."<br>`[220]` **Player_Romus**: ""I pledge to support Rizians and..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("StandApplause"); ;` | `[128]` **Narrator**: "Both sides of the stands applaud..." |
| `[245]` | **"Protect Estela."** | `[260]` **Narrator**: "I turned towards the source of t..." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Titus Gordion"); ;` | `[251]` **Titus Gordion**: ""YOUR MAJESTY!"" |
| `[249]` | **""What's happening?""** | `[247]` **Narrator**: "Titus dove at me and tackled me ..."<br>`[248]` **Narrator**: "Titus rushed to cover me, gun at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Titus Gordion**: ""Security breach, sir."" |
| `[250]` | **""Where's Mother?""** | `[247]` **Narrator**: "Titus dove at me and tackled me ..."<br>`[248]` **Narrator**: "Titus rushed to cover me, gun at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Estela Toras**: ""Romus!"" |
| `[253]` | **""Where's Smolak?""** | `[247]` **Narrator**: "Titus dove at me and tackled me ..."<br>`[248]` **Narrator**: "Titus rushed to cover me, gun at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Estela Toras**: ""Romus!"" |
| `[255]` | **""Get me over there, Titus!""** | `[257]` **Narrator**: "My mother and Wiktor were still ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""They'll be fine. We have to get..." |
| `[258]` | **""Don't worry, Mother!""** | `[257]` **Narrator**: "My mother and Wiktor were still ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""They'll be fine. We have to get..." |
| `[259]` | **""Don't you lay a hand on her, Smolak!""** | `[257]` **Narrator**: "My mother and Wiktor were still ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Titus Gordion**: ""They'll be fine. We have to get..." |
| `[261]` | **""What's happening?""** | `[252]` **Narrator**: "Titus rushed to our side, gun at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Titus Gordion**: ""Security breach, sir."" |
| `[262]` | **""Where's Smolak?""** | `[252]` **Narrator**: "Titus rushed to our side, gun at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Wiktor Smolak (R)**: ""Right here, Your Majesty."" |
| `[275]` | **""We're going to get to the bottom of this.""** | `[274]` **Narrator**: "My mother's voice shook. She and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Wiktor Smolak (R)**: ""It's no great mystery, Your Maj..." |
| `[276]` | **""What have you done, Smolak?""** | `[274]` **Narrator**: "My mother's voice shook. She and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Wiktor Smolak (R)**: ""What have *I* done, Your Majesty?"" |
| `[277]` | **""Are you hurt?""** | `[274]` **Narrator**: "My mother's voice shook. She and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Wiktor Smolak (R)**: ""Of course she isn't. It seemed ..." |
| `[99203]` *(MOD)* | **"This is Rizian soil, Wiktor. If you do not leave Zille voluntarily, my tanks will remove you."** | Spotkanie twarzą w twarz ze Smolakiem w Zille | *Wstrzyknięcie Moda Great Zille Solution* | `Variable["RiziaDLC.CountryRelation_Wehlen_AtWar"] = true;`<br>`Variable["Zille_War_Alfa"] = true;`<br>`Variable["Zille_Smolak_Threatened"] = true;` | `[99204]` **Wiktor Smolak (R)**: *"Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms..."* |

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
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Surviving a bombing during the Rizia-Zil..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I couldn't tell if the sky was growing darker, or if it was just the tinted windows of the armored car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Our motorcade slowed as it approached the Zille border. A..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Our motorcade slowed as it approached the Zille border. A concrete barrier rose up in front of us, its top strung with barbed wire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "My mother had insisted on accompanying me to the Wehzek-R..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "My mother had insisted on accompanying me to the Wehzek-Rizian Friendship Day festivities. She leaned against the window, uncharacteristically quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Are you all right, Mother?""*)
  - -> `[7]` (*Player_Romus: ""What are you thinking about?""*)
  - -> `[8]` (*Player_Romus_Italic: "Say nothing."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you all right, Mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Estela Toras: ""I'm absolutely fine, darling.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you thinking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Estela Toras: ""I'm thinking you ought to have chosen a different jacket..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing and kept my eyes fixed in front of me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "After a short while, she broke the silence."*)

### Węzeł `[9]`
Mówca: **Estela Toras**
> ""I'm absolutely fine, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Estela Toras: ""Say, might we have time for a quick detour once we reach..."*)

### Węzeł `[10]`
Mówca: **Estela Toras**
> ""I'm thinking you ought to have chosen a different jacket to go with those trousers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Estela Toras: ""Say, might we have time for a quick detour once we reach..."*)

### Węzeł `[11]`
Mówca: **Estela Toras**
> ""Say, might we have time for a quick detour once we reach town?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""Of course.""*)
  - -> `[14]` (*Player_Romus: ""No. I want to get this over with as fast as possible.""*)

### Węzeł `[12]`
Mówca: **Narrator**
> "After a short while, she broke the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Estela Toras: ""Say, might we have time for a quick detour once we reach..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "She leaned forward and gave the driver an address. He nod..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want to get this over with as fast as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Estela Toras: ""That's perfectly fine. Mind if I smoke?""*)

### Węzeł `[15]`
Mówca: **Estela Toras**
> ""That's perfectly fine. Mind if I smoke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Without waiting for an answer, she cracked open the windo..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "She leaned forward and gave the driver an address. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse = true"*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Without waiting for an answer, she cracked open the window and lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "At the border, we presented our identification documents ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "At the border, we presented our identification documents and the official invitation from President Smolak. As we crossed, the road turned uneven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Estela Toras: ""Promise me you'll get these highways back up and running..."*)

### Węzeł `[19]`
Mówca: **Estela Toras**
> ""Promise me you'll get these highways back up and running once Zille is returned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""*If* Zille is returned.""*)
  - -> `[21]` (*Player_Romus: ""It's at the top of my list.""*)
  - -> `[22]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* Zille is returned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Factory smokestacks rose up on either side of us. Through..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's at the top of my list.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Factory smokestacks rose up on either side of us. Through..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I didn't respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Factory smokestacks rose up on either side of us. Through..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Factory smokestacks rose up on either side of us. Through the haze, I spotted numerous shanty towns, built over the past few years to house miners and refinery workers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "We entered the city and drove on through a maze of teneme..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "We entered the city and drove on through a maze of tenement buildings, their facades hastily repainted to hide the damage from the war 20 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "At the border, we presented our identification documents ..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "As my mother had instructed him to, the driver veered down a side street that led toward the coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "We stopped in front of a small wooden building with a col..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "As my mother had instructed him to, the driver veered dow..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Zille_GrandparentsHouse"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "We kept going in the direction of Smolak Square, a circul..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "We stopped in front of a small wooden building with a collapsed roof. The front porch was partly buried in sand; jagged teeth of broken glass lined the window frames."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Estela Toras: ""They say you can't go home again. Rarely do they mean it..."*)

### Węzeł `[31]`
Mówca: **Estela Toras**
> ""They say you can't go home again. Rarely do they mean it this literally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "She blinked back tears."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "She blinked back tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Don't be so dramatic, Mother. It's just a house.""*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille"*)
  - -> `[38]` (*Player_Romus: ""Wehlen will pay for what happened to your homeland.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't believe this is the same place we used to go every summer.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Zille"]`
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "She put a hand on my shoulder."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""I can't believe this is the same place we used to go eve..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""This is where you grew up?""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic, Mother. It's just a house.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "She glared at me."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen will pay for what happened to your homeland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "She swallowed hard."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is where you grew up?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false`
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She nodded."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""I never brought my parents here after they fled to Rizia..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "She glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""I never brought my parents here after they fled to Rizia..."*)

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""I never brought my parents here after they fled to Rizia. I knew it would break their hearts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Estela Toras: ""I wish they could have seen it one last time. The way it..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "She put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""I never brought my parents here after they fled to Rizia..."*)

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""I wish they could have seen it one last time. The way it used to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "She swallowed hard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""I never brought my parents here after they fled to Rizia..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I thought back to my carefree summers in Zille. My grandparents had spent the last 10 years of their lives in Palas Rezna, surrounded by luxury, but they never seemed as happy as they did in this house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""They could have stayed. Plenty of Rizians did.""*)
  - -> `[56]` (*Player_Romus: ""You did everything you could for them. They should have ..."*)
  - -> `[57]` (*Player_Romus: ""I'll have it fixed up one day. It'll be our summer home ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I thought back to my carefree summers in Zille. My grandp..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I tried to summon memories of my grandparents. They'd spe..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "I tried to summon memories of my grandparents. They'd spent the last 10 years of their lives in Palas Rezna, surrounded by luxury, yet they always seemed ill at ease."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""They could have stayed. Plenty of Rizians did.""*)
  - -> `[56]` (*Player_Romus: ""You did everything you could for them. They should have ..."*)
  - -> `[57]` (*Player_Romus: ""I'll have it fixed up one day. It'll be our summer home ..."*)

### Węzeł `[51]`
Mówca: **Estela Toras**
> ""Enough dallying. Driver, step on it. We've got a date with a psychopath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "We returned to the main road and drove towards Smolak Squ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "We returned to the main road and drove towards Smolak Square, a circular plaza in the center of town that had once been named after Duke Fedo Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "A silver stretch limousine was parked just in front of th..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "We both fell silent. After a few moments, she plastered a smile on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Estela Toras: ""Enough dallying. Driver, step on it. We've got a date wi..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "We kept going in the direction of Smolak Square, a circular plaza in the center of town that had once been named after Duke Fedo Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "A silver stretch limousine was parked just in front of th..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They could have stayed. Plenty of Rizians did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Estela Toras: ""No. Not after that horrible civil war. The only way they..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You did everything you could for them. They should have been more grateful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Estela Toras: ""Grateful for what? If I hadn't convinced Valero to get W..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll have it fixed up one day. It'll be our summer home again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Estela Toras: ""That ship has sailed, child. Just think, If I hadn't con..."*)

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""No. Not after that horrible civil war. The only way they could have stayed is if I hadn't convinced Valero to get Wehlen involved in our affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "She looked down at her hands."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "A silver stretch limousine was parked just in front of the square. Our driver stopped and we exited the car, flanked by our guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Estela Toras: ""Say what you will about Smolak, he never makes a dull en..."*)

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Your Majesty King Romus! Queen Mother Estela!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "He made a sweeping, exaggerated bow and straightened up w..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "He made a sweeping, exaggerated bow and straightened up with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Wiktor Smolak (R): ""Welcome to Wehlen. Please, make yourselves at home.""*)

### Węzeł `[62]`
Mówca: **Wiktor Smolak (R)**
> ""Welcome to Wehlen. Please, make yourselves at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""Thank you, Mr. President.""*)
  - -> `[195]` (*Player_Romus: ""It's heartening to see that Zille remains in good hands.""*)
  - -> `[66]` (*Player_Romus: ""Mr. President. I wish I could say I was happy to be here.""*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Mr. President, this *is* my home. I spent my childhood summers here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Wiktor Smolak (R): ""Of course, of course. My home is your home, your home is..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Wiktor Smolak (R): ""Who is this Mr. President? Call me Wiktor. We're friends..."*)

### Węzeł `[65]`
Mówca: **Wiktor Smolak (R)**
> ""Who is this Mr. President? Call me Wiktor. We're friends, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He gestured out to the square, where a colorful banner re..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. President. I wish I could say I was happy to be here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Wiktor Smolak (R): ""Why so glum, Your Majesty? How could anyone not be happy..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He gestured out to the square, where a colorful banner reading '24 Years Of Wehzek-Rizian Friendship' hung above a trio of gleaming tanks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Ah, yes. Nothing symbolizes friendship like heavy artill..."*)
  - -> `[73]` (*Player_Romus: ""Looks impressive. Where did you get those tanks?""*)
  - -> `[77]` (*Player_Romus: ""I've been wanting to speak with you about the terms of t..."*)
  - -> `[74]` (*Player_Romus: ""It's my first time at one of these ceremonies. What's go..."*)

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""Of course, of course. My home is your home, your home is my home. We're friends!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He gestured out to the square, where a colorful banner re..."*)

### Węzeł `[69]`
Mówca: **Wiktor Smolak (R)**
> ""Why so glum, Your Majesty? How could anyone not be happy on a day like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He gestured out to the square, where a colorful banner re..."*)

### Węzeł `[70]`
Mówca: **Estela Toras**
> ""Say what you will about Smolak, he never makes a dull entrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "A dozen uniformed soldiers hurriedly got into formation a..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "A dozen uniformed soldiers hurriedly got into formation around us and the limo. The door opened, and Wiktor Smolak stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Wiktor Smolak (R): ""Your Majesty King Romus! Queen Mother Estela!""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. Nothing symbolizes friendship like heavy artillery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Wiktor Smolak (R): ""Exactly! Who doesn't love tanks? Today's audience certai..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks impressive. Where did you get those tanks?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Wiktor Smolak (R): ""Rizia isn't Wehlen's only friend, Your Majesty.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's my first time at one of these ceremonies. What's going to happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Wiktor Smolak (R): ""The usual. I make a speech, you make a speech, the press..."*)

### Węzeł `[75]`
Mówca: **Wiktor Smolak (R)**
> ""Exactly! Who doesn't love tanks? Today's audience certainly does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The square was surrounded by grandstands -- one side deco..."*)

### Węzeł `[76]`
Mówca: **Wiktor Smolak (R)**
> ""The usual. I make a speech, you make a speech, the press takes pictures, everyone goes home happy. Listen to the crowd! They're already happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The square was surrounded by grandstands -- one side deco..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to speak with you about the terms of this *friendship.*""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Wiktor Smolak (R): ""In due time, Your Majesty. First we have some speeches t..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The square was surrounded by grandstands -- one side decorated in the colors of Wehlen's flag, the other in Rizia's blue, orange and gold. I heard loud cheers emanating from them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Wiktor Smolak (R): ""I've invited the finest representatives from both of our..."*)

### Węzeł `[79]`
Mówca: **Wiktor Smolak (R)**
> ""In due time, Your Majesty. First we have some speeches to get through. We can't let down our adoring public!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The square was surrounded by grandstands -- one side deco..."*)

### Węzeł `[80]`
Mówca: **Wiktor Smolak (R)**
> ""Rizia isn't Wehlen's only friend, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The square was surrounded by grandstands -- one side deco..."*)

### Węzeł `[81]`
Mówca: **Wiktor Smolak (R)**
> ""I've invited the finest representatives from both of our countries to join us for this special occasion. Follow me, if you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""Grateful for what? If I hadn't convinced Valero to get Wehlen involved in our affairs, they never would have had to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "She looked down at her hands."*)

### Węzeł `[83]`
Mówca: **Estela Toras**
> ""That ship has sailed, child. Just think, If I hadn't convinced Valero to get Wehlen involved in our affairs, none of this would've happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "She looked down at her hands."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "She looked down at her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Estela Toras: ""The Wehzek president back then was such an upstanding ma..."*)

### Węzeł `[85]`
Mówca: **Estela Toras**
> ""The Wehzek president back then was such an upstanding man. How could I have known he'd go and get himself killed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""If he was so upstanding, he wouldn't have agreed to stom..."*)
  - -> `[151]` (*Player_Romus: ""It's not your fault. Father should have reneged on the a..."*)
  - -> `[152]` (*Player_Romus: ""It was a period of instability across all of Merkopa. Yo..."*)
  - -> `[189]` (*Player_Romus: ""None of this was Wehlen's fault. It was the superpowers ..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "A semicircular stage was set up in front of the tanks. The crowd roared as we crossed the square and made our way over to it. Looking up into the grandstands, I noticed armed guards standing on every level."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Estela Toras: ""A captive audience. That would explain the enthusiasm.""*)

### Węzeł `[87]`
Mówca: **Narrator**
> "My mother and I took our seats. Wiktor stepped up to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Wiktor Smolak (R): ""Wehzeks! Rizians! People of Zille!""*)

### Węzeł `[88]`
Mówca: **Wiktor Smolak (R)**
> ""Wehzeks! Rizians! People of Zille!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Wiktor Smolak (R): ""Two dozen years ago, the glorious country of Wehlen was ..."*)

### Węzeł `[89]`
Mówca: **Wiktor Smolak (R)**
> ""Two dozen years ago, the glorious country of Wehlen was given custody over this land. A great honor, and a tremendous responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Wiktor Smolak (R): ""Wehlen didn't only gain new territory that day. We gaine..."*)

### Węzeł `[90]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen didn't only gain new territory that day. We gained new friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He gestured meaningfully towards the Rizian side of the s..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "He gestured meaningfully towards the Rizian side of the stands. After a few seconds, they broke out in scattered applause. My mother muttered a harsh-sounding curse in Zille dialect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Quiet. We're supposed to play nice, remember?""*)
  - -> `[112]` (*Player_Romus: ""I know. I can't believe this guy.""*)
  - -> `[113]` (*Player_Romus: ""What did you just say?""*)

### Węzeł `[92]`
Mówca: **Wiktor Smolak (R)**
> ""Together, we have overcome war, repaired our economy and made great strides in science and industry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Wiktor Smolak (R): ""Even the decision of the Toras family to ally with Rumbu..."*)

### Węzeł `[93]`
Mówca: **Wiktor Smolak (R)**
> ""I look forward to strengthening that bond for many, many years to come!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He stepped to the side and pulled a rope attached to a fl..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "He stepped to the side and pulled a rope attached to a flagpole. A massive Wehzek flag unfurled, then a much smaller Rizian one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player_Romus_Italic: "Interject."*)
  - -> `[106]` (*Player_Romus_Italic: "Let Wiktor finish his speech."*)

### Węzeł `[95]`
Mówca: **Estela Toras**
> ""A captive audience. That would explain the enthusiasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""Disgusting. This whole ceremony is a sham.""*)
  - -> `[97]` (*Player_Romus: ""Nice idea. The crowd at my coronation sounded lackluster..."*)
  - -> `[98]` (*Player_Romus: ""Maybe they're happy. They don't get many excuses for cel..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Disgusting. This whole ceremony is a sham.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "My mother and I took our seats. Wiktor stepped up to the ..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice idea. The crowd at my coronation sounded lackluster by comparison.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe they're happy. They don't get many excuses for celebration around here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "My mother and I took our seats. Wiktor stepped up to the ..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at the sloppy way they're holding their guns. They have nothing on our recruits.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[95]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "My mother and I took our seats. Wiktor stepped up to the ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""Look at the sloppy way they're holding their guns. They ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "My mother and I took our seats. Wiktor stepped up to the ..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "Interject."]** — Mówca: **Player_Romus_Italic**
> "I stood up and grabbed a microphone. I heard gasps and hushed whispers coming from the grandstands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Wiktor Smolak (R): ""It'll be your turn to speak in a minute, Your Majesty.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "Let Wiktor finish his speech."]** — Mówca: **Player_Romus_Italic**
> "I sat back in my chair and kept silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Wiktor Smolak (R): ""Today, I am especially delighted to be blessed with the ..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand before you at the dawning of a new era. The reign of Valero Toras is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Player_Romus), `[122]` (Player_Romus), `[123]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus: ""It pained me when my father signed away this beautiful p..."*)
  - -> `[211]` (*Player_Romus: ""Today marks a chance to make a clean break with the past..."*)
  - -> `[213]` (*Player_Romus: ""I will never forget what Wehlen did for my family and my..."*)
  - -> `[212]` (*Player_Romus: ""I know none of the Rizians here today asked for their ho..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not know it, but I am a grandson of Zille. The Queen Mother and I have deep ties to this land.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Player_Romus), `[122]` (Player_Romus), `[123]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus: ""It pained me when my father signed away this beautiful p..."*)
  - -> `[211]` (*Player_Romus: ""Today marks a chance to make a clean break with the past..."*)
  - -> `[213]` (*Player_Romus: ""I will never forget what Wehlen did for my family and my..."*)
  - -> `[212]` (*Player_Romus: ""I know none of the Rizians here today asked for their ho..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is an honor to be here in Zille on the anniversary of our historic treaty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Player_Romus), `[122]` (Player_Romus), `[123]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus: ""It pained me when my father signed away this beautiful p..."*)
  - -> `[211]` (*Player_Romus: ""Today marks a chance to make a clean break with the past..."*)
  - -> `[213]` (*Player_Romus: ""I will never forget what Wehlen did for my family and my..."*)
  - -> `[212]` (*Player_Romus: ""I know none of the Rizians here today asked for their ho..."*)

### Węzeł `[110]`
Mówca: **Wiktor Smolak (R)**
> ""Today, I am especially delighted to be blessed with the presence of Rizia's new king. As well as the Queen Mother, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Wiktor Smolak (R): ""They are heirs to a long, proud legacy. One that would h..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quiet. We're supposed to play nice, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Wiktor Smolak (R): ""Together, we have overcome war, repaired our economy and..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. I can't believe this guy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Wiktor Smolak (R): ""Together, we have overcome war, repaired our economy and..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you just say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Estela Toras: ""'May your testicles be stung by a thousand jellyfish.'""*)

### Węzeł `[114]`
Mówca: **Estela Toras**
> ""'May your testicles be stung by a thousand jellyfish.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Wiktor Smolak (R): ""Together, we have overcome war, repaired our economy and..."*)

### Węzeł `[115]`
Mówca: **Wiktor Smolak (R)**
> ""Even the decision of the Toras family to ally with Rumburg, a nation that obviously wishes Wehlen harm, could not diminish the beautiful bond we have formed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Wiktor Smolak (R): ""I look forward to strengthening that bond for many, many..."*)

### Węzeł `[116]`
Mówca: **Wiktor Smolak (R)**
> ""They are heirs to a long, proud legacy. One that would have been shattered had Wehlen and Rizia not made the fateful decision to work hand in hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Wiktor Smolak (R): ""On that note...""*)

### Węzeł `[117]`
Mówca: **Wiktor Smolak (R)**
> ""On that note...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Wiktor Smolak (R): ""Please give a warm welcome to King Romus Toras!""*)

### Węzeł `[118]`
Mówca: **Wiktor Smolak (R)**
> ""Please give a warm welcome to King Romus Toras!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus_Italic: "Rise."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "Rise."]** — Mówca: **Player_Romus_Italic**
> "I stood up. The Rizian side of the stands immediately erupted in loud, authentic-sounding applause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "Jump to: [Zille Speech]"*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, President Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator), `[119]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""I stand before you at the dawning of a new era. The reig..."*)
  - -> `[108]` (*Player_Romus: ""You may not know it, but I am a grandson of Zille. The Q..."*)
  - -> `[109]` (*Player_Romus: ""It is an honor to be here in Zille on the anniversary of..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Zille Speech`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Thank you, President Smolak.""*)
  - -> `[122]` (*Player_Romus: ""My fellow Rizians!""*)
  - -> `[209]` (*Player_Romus: ""My loyal subjects!""*)
  - -> `[123]` (*Player_Romus: ""Brothers and sisters!""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow Rizians!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator), `[119]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""I stand before you at the dawning of a new era. The reig..."*)
  - -> `[108]` (*Player_Romus: ""You may not know it, but I am a grandson of Zille. The Q..."*)
  - -> `[109]` (*Player_Romus: ""It is an honor to be here in Zille on the anniversary of..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brothers and sisters!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator), `[119]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""I stand before you at the dawning of a new era. The reig..."*)
  - -> `[108]` (*Player_Romus: ""You may not know it, but I am a grandson of Zille. The Q..."*)
  - -> `[109]` (*Player_Romus: ""It is an honor to be here in Zille on the anniversary of..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Long live our friendship!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Player_Romus), `[220]` (Player_Romus), `[221]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StandApplause");"*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Player_Romus), `[220]` (Player_Romus), `[221]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[126]`
Mówca: **Narrator**
> ""Glory to Rizia!" echoed the Rizian side of the stands. Wiktor gave me an appraising glance, then readjusted the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech =..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All hail Wehlen!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Player_Romus), `[220]` (Player_Romus), `[221]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StandApplause");"*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Both sides of the stands applauded. Wiktor gave me an appraising glance, then readjusted the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech =..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Loud applause broke out from the Wehzeks in the audience. Wiktor shot me an appraising glance, then turned back to his microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech =..."*)

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> ""What a speech! The king's got charisma!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Wiktor Smolak (R): ""We have a terrific evening of entertainment lined up. Bu..."*)

### Węzeł `[131]`
Mówca: **Wiktor Smolak (R)**
> ""We have a terrific evening of entertainment lined up. But first, we must commemorate this landmark meeting of world leaders with a traditional triple-tank salute!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "There was a rumbling from behind us as the three tanks ai..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "There was a rumbling from behind us as the three tanks aimed their barrels into the air. My mother and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""That's the first time I've heard of this tradition.""*)
  - -> `[136]` (*Player_Romus: ""Those really are some impressive tanks.""*)
  - -> `[137]` (*Player_Romus: ""Sure... After you, Mr. Smolak.""*)

### Węzeł `[133]`
Mówca: **Wiktor Smolak (R)**
> ""One!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CannonLeft");"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "The tank on the left fired, sending a plume of gold-colored smoke high over the stands. The crowd gasped in excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Wiktor Smolak (R): ""Two!""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the first time I've heard of this tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Estela Toras: ""A Wiktor Smolak special.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those really are some impressive tanks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Estela Toras: ""We can thank his Eastern benefactors, I presume.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure... After you, Mr. Smolak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Estela Toras: ""A Wiktor Smolak special.""*)

### Węzeł `[138]`
Mówca: **Estela Toras**
> ""A Wiktor Smolak special.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Wiktor raised a finger up in the air."*)

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""We can thank his Eastern benefactors, I presume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Wiktor raised a finger up in the air."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Wiktor raised a finger up in the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Wiktor Smolak (R): ""One!""*)

### Węzeł `[141]`
Mówca: **Wiktor Smolak (R)**
> ""Two!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CannonRight");"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "The gun mounted to the tank on the right went off. This time, the smoke was magenta."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Wiktor Smolak (R): ""Thr--""*)

### Węzeł `[143]`
Mówca: **Wiktor Smolak (R)**
> ""Thr--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "His count was interrupted by an unidentified voice in the..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "His count was interrupted by an unidentified voice in the distance, shouting "For the King!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Wiktor whipped his head around in shock, a frenzied look ..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that part of the program?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Estela Toras: ""I don't--""*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Estela Toras: ""I don't--""*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Wiktor whipped his head around in shock, a frenzied look in his eyes. I turned to my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""Is that part of the program?""*)
  - -> `[146]` (*Player_Romus: ""Who was that?""*)
  - -> `[188]` (*Player_Romus: ""Mother. What happened?""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he was so upstanding, he wouldn't have agreed to stomp out a democratic revolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Estela Toras: ""What revolution? If those terrorists were acting on beha..."*)

### Węzeł `[150]`
Mówca: **Estela Toras**
> ""What revolution? If those terrorists were acting on behalf of the Rizian people, they wouldn't have harmed innocents. Yourself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "We both fell silent. After a few moments, she plastered a..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault. Father should have reneged on the agreement immediately after the assassination.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Estela Toras: ""And made outright enemies of Wehlen while our own countr..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a period of instability across all of Merkopa. You were playing with fire.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Estela Toras: ""Would you have done any differently if Vina was in danger?""*)

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""And made outright enemies of Wehlen while our own country was still weak? Don't be foolish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "We both fell silent. After a few moments, she plastered a..."*)

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""Would you have done any differently if Vina was in danger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "We both fell silent. After a few moments, she plastered a..."*)

### Węzeł `[155]`
Mówca: **Estela Toras**
> ""I don't--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("R_ZilleExplosion");"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "A deafening blast, much louder than the two that had preceded it, echoed from the opposite end of the square."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "I turned towards the source of the sound and saw the Wehz..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "Get down."]** — Mówca: **Player_Romus_Italic**
> "I dove from the dais and flung myself onto the ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "Run towards the stands."]** — Mówca: **Player_Romus_Italic**
> "I rushed towards the stands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Run away from the stands."]** — Mówca: **Player_Romus_Italic**
> "I rushed away from the stands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == ..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""I had an interesting talk with Pabel recently.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had an interesting talk with Pabel recently.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[164]`
Mówca: **Estela Toras**
> ""Oh? I'm glad the two of you are still close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Was Father acting out of the ordinary the night of his d..."*)
  - -> `[170]` (*Player_Romus: ""When was the last time you saw Father? Before he died, I..."*)
  - -> `[177]` (*Player_Romus: ""Tell me again. How did you discover Father had died?""*)
  - -> `[171]` (*Player_Romus: ""Do you know about mandragora?""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Estela Toras: ""Oh? I'm glad the two of you are still close.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Estela Toras: ""He talks? I always saw him as a sort of walking hors d'o..."*)

### Węzeł `[168]`
Mówca: **Estela Toras**
> ""He talks? I always saw him as a sort of walking hors d'oeuvre platter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Was Father acting out of the ordinary the night of his d..."*)
  - -> `[170]` (*Player_Romus: ""When was the last time you saw Father? Before he died, I..."*)
  - -> `[177]` (*Player_Romus: ""Tell me again. How did you discover Father had died?""*)
  - -> `[171]` (*Player_Romus: ""Do you know about mandragora?""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was Father acting out of the ordinary the night of his death?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Estela Toras), `[168]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Estela Toras: ""Any more out of the ordinary than ordinary, you mean?""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When was the last time you saw Father? Before he died, I mean.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Estela Toras), `[168]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "She arched an eyebrow."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you know about mandragora?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Estela Toras), `[168]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Estela Toras: ""I've never heard of her. Is she a noble?""*)

### Węzeł `[172]`
Mówca: **Narrator**
> "She arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Estela Toras: ""I told you, we had dinner together. After he made Pabel ..."*)

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""I told you, we had dinner together. After he made Pabel taste the food.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Estela Toras: ""Why do you ask?""*)

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""Any more out of the ordinary than ordinary, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Estela Toras: ""No. He went to bed early, as he'd been doing for months...."*)

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""No. He went to bed early, as he'd been doing for months. A symptom of old age, for some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Estela Toras: ""Why do you ask?""*)

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I've never heard of her. Is she a noble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Pabel thinks Father was poisoned.""*)
  - -> `[183]` (*Player_Romus: ""I'll tell you later.""*)
  - -> `[182]` (*Player_Romus: ""Never mind.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me again. How did you discover Father had died?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Estela Toras), `[168]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "She arched an eyebrow."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "She arched an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Estela Toras: ""I told you. I went to check on him a few hours after sup..."*)

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""I told you. I went to check on him a few hours after supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Estela Toras: ""Why do you ask?""*)

### Węzeł `[180]`
Mówca: **Estela Toras**
> ""Why do you ask?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Pabel thinks Father was poisoned.""*)
  - -> `[183]` (*Player_Romus: ""I'll tell you later.""*)
  - -> `[182]` (*Player_Romus: ""Never mind.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel thinks Father was poisoned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Estela Toras), `[180]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Estela_TellAboutMurderCase = true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Estela Toras), `[180]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Estela Toras: ""How cruel of you to pique my interest like that.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll tell you later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Estela Toras), `[180]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Estela Toras: ""How cruel of you to pique my interest like that.""*)

### Węzeł `[184]`
Mówca: **Estela Toras**
> ""And they say butlers have no imaginations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Estela Toras: ""Your father had a long list of enemies, and an equally l..."*)

### Węzeł `[185]`
Mówca: **Estela Toras**
> ""Your father had a long list of enemies, and an equally long list of safeguards against them. His worries were what stopped his heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "She folded her arms and was silent for a while."*)

### Węzeł `[186]`
Mówca: **Estela Toras**
> ""How cruel of you to pique my interest like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "She folded her arms and was silent for a while."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "She folded her arms and was silent for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Estela Toras: ""Say, might we have time for a quick detour once we reach..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother. What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Estela Toras: ""I don't--""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of this was Wehlen's fault. It was the superpowers trying to use the country as a pawn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Estela Toras: ""Nobody forced Wiktor Smolak to turn my homeland into his..."*)

### Węzeł `[190]`
Mówca: **Estela Toras**
> ""Nobody forced Wiktor Smolak to turn my homeland into his country's armpit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "We both fell silent. After a few moments, she plastered a..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Zille == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Zille == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Zille == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""Actually, Mr. President, this *is* my home. I spent my c..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Zille == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""Actually, Mr. President, this *is* my mother's home.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Mr. President, this *is* my mother's home.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Summer_Zille"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[62]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Wiktor Smolak (R): ""Of course, of course. My home is your home, your home is..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's heartening to see that Zille remains in good hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Wiktor Smolak (R): ""Yes, yes! This square used to be gray and boring. Now lo..."*)

### Węzeł `[196]`
Mówca: **Wiktor Smolak (R)**
> ""Yes, yes! This square used to be gray and boring. Now look at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He gestured out to the square, where a colorful banner re..."*)

### Węzeł `[197]`
Mówca: **Wiktor Smolak (R)**
> ""It'll be your turn to speak in a minute, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""You've said more than enough already.""*)
  - -> `[199]` (*Player_Romus: ""Forgive me, but your words were so inspiring I couldn't ..."*)
  - -> `[198]` (*Player_Romus: ""My mistake. Please go on, Mr. President.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mistake. Please go on, Mr. President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Wiktor stared me down for a second. I suddenly became awa..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, but your words were so inspiring I couldn't stay quiet for a moment longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition += 1"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've said more than enough already.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition += 1"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Wiktor stared me down for a second. I suddenly became aware of how tall he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Wiktor Smolak (R): ""By all means, then, continue.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Wiktor stared me down for a second. I suddenly became awa..."*)

### Węzeł `[203]`
Mówca: **Wiktor Smolak (R)**
> ""By all means, then, continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "I turned to face the crowd. The Rizian side of the stands..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "Wiktor stared me down for a second. I suddenly became aware of how tall he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Wiktor Smolak (R): ""I will. Thank you.""*)

### Węzeł `[205]`
Mówca: **Wiktor Smolak (R)**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "He turned back to the crowd."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "He turned back to the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Wiktor Smolak (R): ""Today, I am especially delighted to be blessed with the ..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "I turned to face the crowd. The Rizian side of the stands erupted in loud, authentic-sounding applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "Zille Speech"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Zille Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "Zille Speech"*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My loyal subjects!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator), `[119]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""I stand before you at the dawning of a new era. The reig..."*)
  - -> `[108]` (*Player_Romus: ""You may not know it, but I am a grandson of Zille. The Q..."*)
  - -> `[109]` (*Player_Romus: ""It is an honor to be here in Zille on the anniversary of..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It pained me when my father signed away this beautiful part of Rizia. Yet I knew it was for the greater good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Player_Romus), `[108]` (Player_Romus), `[109]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""In one year, Rizia will resume governorship of Zille. Bu..."*)
  - -> `[218]` (*Player_Romus: ""I commend Wiktor Smolak for his exemplary leadership in ..."*)
  - -> `[215]` (*Player_Romus: ""The past years have not been easy for any of you. But th..."*)
  - -> `[227]` (*Player_Romus: ""But I have come here to send Wiktor Smolak a warning. If..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today marks a chance to make a clean break with the past and begin looking towards the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Player_Romus), `[108]` (Player_Romus), `[109]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""In one year, Rizia will resume governorship of Zille. Bu..."*)
  - -> `[218]` (*Player_Romus: ""I commend Wiktor Smolak for his exemplary leadership in ..."*)
  - -> `[215]` (*Player_Romus: ""The past years have not been easy for any of you. But th..."*)
  - -> `[214]` (*Player_Romus: ""I have come here to send Wiktor Smolak a warning. If Zil..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know none of the Rizians here today asked for their homeland to be governed by Wehlen. I myself had no choice in the matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Player_Romus), `[108]` (Player_Romus), `[109]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""In one year, Rizia will resume governorship of Zille. Bu..."*)
  - -> `[215]` (*Player_Romus: ""The past years have not been easy for any of you. But th..."*)
  - -> `[222]` (*Player_Romus: ""Yet I commend Wiktor Smolak for his exemplary leadership..."*)
  - -> `[214]` (*Player_Romus: ""I have come here to send Wiktor Smolak a warning. If Zil..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will never forget what Wehlen did for my family and my country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Player_Romus), `[108]` (Player_Romus), `[109]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player_Romus: ""In one year, Rizia will resume governorship of Zille. Bu..."*)
  - -> `[218]` (*Player_Romus: ""I commend Wiktor Smolak for his exemplary leadership in ..."*)
  - -> `[215]` (*Player_Romus: ""The past years have not been easy for any of you. But th..."*)
  - -> `[227]` (*Player_Romus: ""But I have come here to send Wiktor Smolak a warning. If..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have come here to send Wiktor Smolak a warning. If Zille is not returned, he will face Rizia's full retaliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Player_Romus), `[212]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech = true; RiziaDLC..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The past years have not been easy for any of you. But the time will soon come when we are reunited.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Player_Romus), `[211]` (Player_Romus), `[212]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""I pledge to support Rizians and Wehzeks alike through th..."*)
  - -> `[221]` (*Player_Romus: ""I know that I can count on the President of Wehlen to do..."*)
  - -> `[216]` (*Player_Romus: ""As ATO encroaches on our continent, it is vital that the..."*)
  - -> `[230]` (*Player_Romus: ""Despite our political differences, Rizia and Wehlen have..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As ATO encroaches on our continent, it is vital that the nations of Southeastern Merkopa unite as one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Player_Romus), `[217]` (Player_Romus), `[218]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Long live our friendship!""*)
  - -> `[242]` (*Player_Romus: ""The King has spoken!""*)
  - -> `[125]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[127]` (*Player_Romus: ""All hail Wehlen!""*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In one year, Rizia will resume governorship of Zille. But I hope that will not mean an end to our countries' friendly cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Player_Romus), `[211]` (Player_Romus), `[212]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""I pledge to support Rizians and Wehzeks alike through th..."*)
  - -> `[221]` (*Player_Romus: ""I know that I can count on the President of Wehlen to do..."*)
  - -> `[216]` (*Player_Romus: ""As ATO encroaches on our continent, it is vital that the..."*)
  - -> `[230]` (*Player_Romus: ""Despite our political differences, Rizia and Wehlen have..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I commend Wiktor Smolak for his exemplary leadership in the face of war and terrorism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Player_Romus), `[211]` (Player_Romus), `[213]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""I pledge to support Rizians and Wehzeks alike through th..."*)
  - -> `[221]` (*Player_Romus: ""I know that I can count on the President of Wehlen to do..."*)
  - -> `[216]` (*Player_Romus: ""As ATO encroaches on our continent, it is vital that the..."*)
  - -> `[230]` (*Player_Romus: ""Despite our political differences, Rizia and Wehlen have..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the Rizians here today, I say: Do not forget your motherland. Be ready to defend her if necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Wiktor, I know you are a man of honor. When the time com..."*)
  - -> `[232]` (*Player_Romus: ""The president of Wehlen believes these tanks will intimi..."*)
  - -> `[233]` (*Player_Romus: ""People of Wehlen, I invite you to stay in Zille once it ..."*)
  - -> `[234]` (*Player_Romus: ""On behalf of House Toras, there will be justice for what..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge to support Rizians and Wehzeks alike through the upcoming peaceful transfer of power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Player_Romus), `[217]` (Player_Romus), `[218]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Long live our friendship!""*)
  - -> `[242]` (*Player_Romus: ""The King has spoken!""*)
  - -> `[125]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[127]` (*Player_Romus: ""All hail Wehlen!""*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that I can count on the President of Wehlen to do what's best for Zille until it is back in Rizia's custody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Player_Romus), `[217]` (Player_Romus), `[218]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Long live our friendship!""*)
  - -> `[242]` (*Player_Romus: ""The King has spoken!""*)
  - -> `[125]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[127]` (*Player_Romus: ""All hail Wehlen!""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet I commend Wiktor Smolak for his exemplary leadership in the face of war and terrorism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus: ""I pledge to support Rizians and Wehzeks alike through th..."*)
  - -> `[221]` (*Player_Romus: ""I know that I can count on the President of Wehlen to do..."*)
  - -> `[216]` (*Player_Romus: ""As ATO encroaches on our continent, it is vital that the..."*)
  - -> `[230]` (*Player_Romus: ""Despite our political differences, Rizia and Wehlen have..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech = true; RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech = true;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Zille_HostileSpeech"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist -= 1"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "The crowd went completely silent. Wiktor's mouth hung ope..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge to support Rizians and Wehzeks alike through the upcoming transfer of power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Wiktor, I know you are a man of honor. When the time com..."*)
  - -> `[232]` (*Player_Romus: ""The president of Wehlen believes these tanks will intimi..."*)
  - -> `[233]` (*Player_Romus: ""People of Wehlen, I invite you to stay in Zille once it ..."*)
  - -> `[234]` (*Player_Romus: ""On behalf of House Toras, there will be justice for what..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I call on the people of Rizia to resist your Wehzek oppressors. Remind them in whose country they reside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Wiktor, I know you are a man of honor. When the time com..."*)
  - -> `[232]` (*Player_Romus: ""The president of Wehlen believes these tanks will intimi..."*)
  - -> `[233]` (*Player_Romus: ""People of Wehlen, I invite you to stay in Zille once it ..."*)
  - -> `[234]` (*Player_Romus: ""On behalf of House Toras, there will be justice for what..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I have come here to send Wiktor Smolak a warning. If Zille is not returned, he will face Rizia's full retaliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Player_Romus), `[213]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech = true; RiziaDLC..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "The crowd went completely silent. Wiktor's mouth hung open in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""To my countrymen, I say: Be patient. A mere year from no..."*)
  - -> `[219]` (*Player_Romus: ""To the Rizians here today, I say: Do not forget your mot..."*)
  - -> `[225]` (*Player_Romus: ""I pledge to support Rizians and Wehzeks alike through th..."*)
  - -> `[226]` (*Player_Romus: ""I call on the people of Rizia to resist your Wehzek oppr..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To my countrymen, I say: Be patient. A mere year from now, we will be reunited.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Wiktor, I know you are a man of honor. When the time com..."*)
  - -> `[232]` (*Player_Romus: ""The president of Wehlen believes these tanks will intimi..."*)
  - -> `[233]` (*Player_Romus: ""People of Wehlen, I invite you to stay in Zille once it ..."*)
  - -> `[234]` (*Player_Romus: ""On behalf of House Toras, there will be justice for what..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite our political differences, Rizia and Wehlen have much in common. There's no limit to what we can accomplish together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Player_Romus), `[217]` (Player_Romus), `[218]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Long live our friendship!""*)
  - -> `[242]` (*Player_Romus: ""The King has spoken!""*)
  - -> `[125]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[127]` (*Player_Romus: ""All hail Wehlen!""*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor, I know you are a man of honor. When the time comes, you will do what is right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Player_Romus), `[225]` (Player_Romus), `[226]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""Thank you and happy Friendship Day!""*)
  - -> `[236]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[237]` (*Player_Romus: ""The King has spoken!""*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The president of Wehlen believes these tanks will intimidate us. We will show him how wrong he is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Player_Romus), `[225]` (Player_Romus), `[226]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""Thank you and happy Friendship Day!""*)
  - -> `[236]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[237]` (*Player_Romus: ""The King has spoken!""*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People of Wehlen, I invite you to stay in Zille once it is part of my kingdom again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Player_Romus), `[225]` (Player_Romus), `[226]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""Thank you and happy Friendship Day!""*)
  - -> `[236]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[237]` (*Player_Romus: ""The King has spoken!""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On behalf of House Toras, there will be justice for what has been done to Zille.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Player_Romus), `[225]` (Player_Romus), `[226]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""Thank you and happy Friendship Day!""*)
  - -> `[236]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[237]` (*Player_Romus: ""The King has spoken!""*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and happy Friendship Day!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Player_Romus), `[232]` (Player_Romus), `[233]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "A few tentative claps came from the Rizian side of the st..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Player_Romus), `[232]` (Player_Romus), `[233]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King has spoken!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Player_Romus), `[232]` (Player_Romus), `[233]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "A few tentative claps came from the Rizian side of the st..."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "A few tentative claps came from the Rizian side of the stands. I looked back at my mother. She spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Estela Toras: ""Romus, are you insane?""*)

### Węzeł `[239]`
Mówca: **Estela Toras**
> ""Romus, are you insane?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Wiktor's face remained placid. He readjusted his micropho..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Wiktor's face remained placid. He readjusted his microphone, gripping it so tightly that his knuckles turned white."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Wiktor Smolak (R): ""That was some speech, Your Majesty! And right in front o..."*)

### Węzeł `[241]`
Mówca: **Wiktor Smolak (R)**
> ""That was some speech, Your Majesty! And right in front of the international press, as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Wiktor Smolak (R): ""Let's not allow King Romus to spoil the mood on this fin..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King has spoken!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Player_Romus), `[220]` (Player_Romus), `[221]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StandApplause");"*)

### Węzeł `[243]`
Mówca: **Wiktor Smolak (R)**
> ""Let's not allow King Romus to spoil the mood on this fine day. It's time to commemorate the occasion with a traditional three-tank salute!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "There was a rumbling from behind us as the three tanks ai..."*)

### Węzeł `[244]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Titus rushed to cover me, gun at the ready. Screams of fe..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "Protect Estela."]** — Mówca: **Player_Romus_Italic**
> "I flung myself in front of my mother."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY! GET DOWN!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Titus dove at me and tackled me to the ground. Screams of..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Titus dove at me and tackled me to the ground. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Where's Mother?""*)
  - -> `[249]` (*Player_Romus: ""What's happening?""*)
  - -> `[253]` (*Player_Romus: ""Where's Smolak?""*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Titus rushed to cover me, gun at the ready. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Where's Mother?""*)
  - -> `[249]` (*Player_Romus: ""What's happening?""*)
  - -> `[253]` (*Player_Romus: ""Where's Smolak?""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's happening?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Titus Gordion: ""Security breach, sir.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Estela Toras: ""Romus!""*)

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""YOUR MAJESTY!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Titus rushed to our side, gun at the ready. Screams of fe..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Titus rushed to our side, gun at the ready. Screams of fear and confusion were rising up from all around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""What's happening?""*)
  - -> `[262]` (*Player_Romus: ""Where's Smolak?""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Smolak?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator), `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Estela Toras: ""Romus!""*)

### Węzeł `[254]`
Mówca: **Titus Gordion**
> ""Security breach, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Estela Toras: ""Romus!""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get me over there, Titus!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""They'll be fine. We have to get you out of here.""*)

### Węzeł `[256]`
Mówca: **Estela Toras**
> ""Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "My mother and Wiktor were still on the podium, surrounded..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "My mother and Wiktor were still on the podium, surrounded by a thick cordon of Wehzek guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""Get me over there, Titus!""*)
  - -> `[258]` (*Player_Romus: ""Don't worry, Mother!""*)
  - -> `[259]` (*Player_Romus: ""Don't you lay a hand on her, Smolak!""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Mother!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""They'll be fine. We have to get you out of here.""*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you lay a hand on her, Smolak!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Titus Gordion: ""They'll be fine. We have to get you out of here.""*)

### Węzeł `[260]`
Mówca: **Narrator**
> "I turned towards the source of the sound and saw the Wehzek side of the stands engulfed in flames."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus_Italic: "Run towards the stands."*)
  - -> `[159]` (*Player_Romus_Italic: "Run away from the stands."*)
  - -> `[157]` (*Player_Romus_Italic: "Get down."*)
  - -> `[245]` (*Player_Romus_Italic: "Protect Estela."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's happening?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Titus Gordion: ""Security breach, sir.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's Smolak?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Wiktor Smolak (R): ""Right here, Your Majesty.""*)

### Węzeł `[263]`
Mówca: **Titus Gordion**
> ""Security breach, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Wiktor stood beside us on the podium, his own gun drawn. ..."*)

### Węzeł `[264]`
Mówca: **Wiktor Smolak (R)**
> ""Right here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Wiktor stood beside us on the podium, his own gun drawn. ..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Wiktor stood beside us on the podium, his own gun drawn. He was surrounded by a thick cordon of Wehzek guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Titus Gordion: ""We've got to get you out of here.""*)

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""We've got to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "He and Smolak's guards exchanged a series of hand signals..."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "He and Smolak's guards exchanged a series of hand signals. The crowd had begun fleeing in every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Titus grabbed my arm and swiftly started ushering me away..."*)

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""They'll be fine. We have to get you out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He and Smolak's guards exchanged a series of hand signals..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He and Smolak's guards exchanged a series of hand signals. The crowd had begun fleeing in every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Titus grabbed my arm and swiftly started ushering me away..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Titus grabbed my arm and swiftly started ushering me away. I took one last look back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Smoke was now rising from the Wehzek grandstand. Part of ..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Smoke was now rising from the Wehzek grandstand. Part of the structure had collapsed, and soldiers were working to free the people trapped underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "The next few moments were a blur as we made our way throu..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "The next few moments were a blur as we made our way through the panicked hordes of civilians. Wiktor's limo pulled up and Titus roughly shoved me inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Estela Toras: ""Thank God you're safe.""*)

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Thank God you're safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "My mother's voice shook. She and Wiktor were sitting acro..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "My mother's voice shook. She and Wiktor were sitting across from me, looking dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""Are you hurt?""*)
  - -> `[275]` (*Player_Romus: ""We're going to get to the bottom of this.""*)
  - -> `[276]` (*Player_Romus: ""What have you done, Smolak?""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're going to get to the bottom of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Wiktor Smolak (R): ""It's no great mystery, Your Majesty.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have you done, Smolak?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Wiktor Smolak (R): ""What have *I* done, Your Majesty?""*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you hurt?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Wiktor Smolak (R): ""Of course she isn't. It seemed like *no Rizian* was harm..."*)

### Węzeł `[278]`
Mówca: **Wiktor Smolak (R)**
> ""Of course she isn't. It seemed like *no Rizian* was harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Smolak had fire in his eyes."*)

### Węzeł `[279]`
Mówca: **Wiktor Smolak (R)**
> ""It's no great mystery, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Smolak had fire in his eyes."*)

### Węzeł `[280]`
Mówca: **Wiktor Smolak (R)**
> ""What have *I* done, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Smolak had fire in his eyes."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "Smolak had fire in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Wiktor Smolak (R): ""If your people have anything to do with this, there will..."*)

### Węzeł `[282]`
Mówca: **Wiktor Smolak (R)**
> ""If your people have anything to do with this, there will be a price to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He kept his eyes on me as the car began pulling away."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "He kept his eyes on me as the car began pulling away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Rizia_Map_Music_Tense");"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Stress", "R_Stress_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "A deafening blast, much louder than the two that had prec..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Estela_TellAboutMurderCase = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Estela_TellAboutMurderCase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Estela Toras: ""And they say butlers have no imaginations.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Titus Gordion: ""YOUR MAJESTY!""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Titus Gordion: ""YOUR MAJESTY!""*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Titus Gordion: ""YOUR MAJESTY! GET DOWN!""*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2;
RiziaDLCSupport.News_Turn02_RH_Bombing = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 2;
Variable["RiziaDLCSupport.News_Turn02_RH_Bombing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_Zille_BombingReport = true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_Bombing_HostileSpeech = true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_ZilleVisit_HostileSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ZilleVisit_HostileSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_Bombing_Neutral = true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_G_Bombing_Neutral = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_Bombing_Neutral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_Zille_BombingReport = true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I couldn't tell if the sky was growing darker, or if it w..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("R_ZilleExplosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("R_ZilleExplosion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Stress", "R_Stress_Loop");"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn02_Zille_BombingReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Zille_BombingReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn02_Zille_ConciliatorySpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Wiktor Smolak (R): ""What a speech! The king's got charisma!""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StandApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Both sides of the stands applauded. Wiktor gave me an app..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StandApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: ""Glory to Rizia!" echoed the Rizian side of the stands. W..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("StandApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("StandApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Loud applause broke out from the Wehzeks in the audience...."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CannonLeft");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CannonLeft");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "The tank on the left fired, sending a plume of gold-color..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CannonRight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CannonRight");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "The gun mounted to the tank on the right went off. This t..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "A semicircular stage was set up in front of the tanks. Th..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Rizia_Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 2; RiziaDLC..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("StandApplause");"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "A few tentative claps came from the Rizian side of the st..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Surviving a bombing during the Rizia-Zille Friendship Day", "Zille", "Republic of Wehlen");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Surviving a bombing during the Rizia-Zille Friendship Day","Zille","Republic of Wehlen");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");"*)

---

## 5. Wstrzyknięcia Fabularne z Modyfikacji Great Zille Solution

### Węzeł `[99203]` *(MOD: Great Zille Solution)*
**[WYBÓR GRACZA: GROŹBA CZOŁGAMI WOBEC SMOLAKA]** — Mówca: **Player_Romus**
> "This is Rizian soil, Wiktor. If you do not leave Zille voluntarily when the lease expires, my tanks will remove you."
- **Wymagania odblokowania:** Wstrzykiwane w trakcie Dnia Przyjaźni w Zille podczas spotkania ze Smolakiem.
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.CountryRelation_Wehlen_AtWar"] = true; Variable["Zille_War_Alfa"] = true; Variable["Zille_Smolak_Threatened"] = true;`
- **Połączenia wychodzące:** -> `[99204]` (*Wiktor Smolak (R)*)

### Węzeł `[99204]` *(MOD: Great Zille Solution)*
Mówca: **Wiktor Smolak (R)**
> "Threats, Romus? In my own city? Wehlen does not fear your parade-ground uniforms. Just dare to cross that river, and you will see South Merkopa burn!"
- **Połączenia wychodzące:** Powrót do głównego wątku obchodów w Zille.
