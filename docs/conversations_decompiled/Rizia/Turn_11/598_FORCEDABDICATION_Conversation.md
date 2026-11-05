# Rizia/Turn 11/FORCEDABDICATION/FORCEDABDICATION Conversation

- **ID konwersacji:** `598`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Rizia/Turn_11/598_FORCEDABDICATION_Conversation.md`
- **Liczba węzłów dialogowych:** 250
- **Liczba wyborów gracza:** 93

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Morella_Funds_Revolutionaries`
- `RiziaDLC.Morella_Sabotage_Plans_Discovered`
- `RiziaDLC.NatDes_Appease`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.Reform_Diplomatic_RejectedandCancelled`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.Abdication_Speech_Warned`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Abdication_Speech_Warned`

### Skoki między-konwersacyjne:
- Węzeł `[201]` -> **[456] Rizia/Turn 11/Ending_Speech** (../Turn_11/456_Ending_Speech.md), Węzeł `[897]`
- Węzeł `[225]` -> **[456] Rizia/Turn 11/Ending_Speech** (../Turn_11/456_Ending_Speech.md), Węzeł `[933]`
- Węzeł `[236]` -> **[456] Rizia/Turn 11/Ending_Speech** (../Turn_11/456_Ending_Speech.md), Węzeł `[933]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""I leave behind a legacy that is imperfect, yet mine.""** | `[24]` **Player_Romus**: ""I have chosen to step down -- n..."<br>`[25]` **Player_Romus**: ""I am relinquishing the throne w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;`<br>*(+1 skryptów)* | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 5 innych odgałęzień)* |
| `[4]` | **""History will judge my years on the throne. But I pray it judges them fairly.""** | `[24]` **Player_Romus**: ""I have chosen to step down -- n..."<br>`[25]` **Player_Romus**: ""I am relinquishing the throne w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;`<br>*(+1 skryptów)* | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 5 innych odgałęzień)* |
| `[5]` | **""No throne can stand untouched in a storm. And in recent years, the storm has not ..."** | `[24]` **Player_Romus**: ""I have chosen to step down -- n..."<br>`[25]` **Player_Romus**: ""I am relinquishing the throne w..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | `--;`<br>`--;`<br>*(+1 skryptów)* | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 5 innych odgałęzień)* |
| `[6]` | **""Somewhere along the way, something broke between the Crown and the people. And th..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` | `--;` | `[104]` **Player_Romus**: ""I do not stand here to deflect ..."<br>`[75]` **Player_Romus**: ""I became the villain in someone..."<br>*(oraz 3 innych odgałęzień)* |
| `[7]` | **""But you must know that I fought for you. I fought for the reforms. I stood before..."** | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[9]` **Player_Romus**: ""I chose not to answer rebellion..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true` | `--;` | `[119]` **Player_Romus**: ""Although it wasn't my wish for ..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 2 innych odgałęzień)* |
| `[8]` | **""Revolutions do not wait politely. They arrive loudly, and often, without mercy. A..."** | `[75]` **Player_Romus**: ""I became the villain in someone..."<br>`[87]` **Player_Romus**: ""In times of unrest, people do n..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 4 innych odgałęzień)* |
| `[9]` | **""I chose not to answer rebellion with violence, because I still believed there was..."** | `[76]` **Player_Romus**: ""If I could turn back time, ther..."<br>`[77]` **Player_Romus**: ""Perhaps I tried too hard to pre..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.NatDes_Oppress"] == false` | `--;`<br>`--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 4 innych odgałęzień)* |
| `[10]` | **""The people demanded change -- and they did not ask for it gently. I heard them. B..."** | `[76]` **Player_Romus**: ""If I could turn back time, ther..."<br>`[77]` **Player_Romus**: ""Perhaps I tried too hard to pre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 4 innych odgałęzień)* |
| `[11]` | **""Yes, I chose this. I opened the gates. I invited them in.""** | `[41]` **Narrator**: "Adarfo and the revolutionary gua..."<br>`[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[55]` **Player_Romus**: ""And, I made a choice -- a choic..."<br>*(oraz 3 innych odgałęzień)* |
| `[15]` | **""I believed that if anyone should end the old order, it ought to be someone within..."** | `[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>`[35]` **Player_Romus**: ""The heads of noble houses gathe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[55]` **Player_Romus**: ""And, I made a choice -- a choic..."<br>*(oraz 3 innych odgałęzień)* |
| `[16]` | **""Not to save myself. But to save Rizia from the devastation of a civil war.""** | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[54]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[190]` **Narrator**: "The revolutionaries pointed to t..." |
| `[17]` | **""I will not pretend it was a celebration. What occurred behind those doors changed..."** | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>`[15]` **Player_Romus**: ""I believed that if anyone shoul..."<br>*(oraz 3 innych odgałęzień)* |
| `[18]` | **""My actions cannot be called surrender. It was a safeguard. An act to avoid the bl..."** | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[54]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[190]` **Narrator**: "The revolutionaries pointed to t..." |
| `[19]` | **""I knew the risks. But I saw something in their cause --something that resonated l..."** | `[65]` **Player_Romus**: ""On that day, I listened to a mo..."<br>`[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Player_Romus**: ""My actions cannot be called sur..."<br>`[16]` **Player_Romus**: ""Not to save myself. But to save..."<br>*(oraz 2 innych odgałęzień)* |
| `[20]` | **""I must tell you -- just as I was betrayed, so too was the reform movement.""** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[21]` | **""This was not the reform I imagined. I sought a constitutional kingdom. They sough..."** | `[42]` **Narrator**: "The revolutionaries' eyes sharpe..."<br>`[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | `--;` | `[135]` **Narrator**: "Adarfo leaned in and whispered."<br>`[130]` **Narrator**: "Adarfo immediately stepped close..." |
| `[22]` | **""They came in fast, rifles pointed. In seconds, we were all under their control.""** | `[42]` **Narrator**: "The revolutionaries' eyes sharpe..."<br>`[215]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[135]` **Narrator**: "Adarfo leaned in and whispered."<br>`[130]` **Narrator**: "Adarfo immediately stepped close..." |
| `[23]` | **""Instead of staying true to their vision, the reformers opened their doors to radi..."** | `[7]` **Player_Romus**: ""But you must know that I fought..."<br>`[112]` **Player_Romus**: ""I supported the reforms. I pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "Adarfo quickly stepped closer to..."<br>`[142]` **Narrator**: "A revolutionary quickly stepped ..."<br>*(oraz 2 innych odgałęzień)* |
| `[24]` | **""I have chosen to step down -- not out of weakness, but out of strength. The stren..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych odgałęzień)* |
| `[25]` | **""I am relinquishing the throne with a heavy heart, but with a clear conscience.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych odgałęzień)* |
| `[26]` | **""I hereby announce my abdication. Because the future demands it. Because holding p..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych odgałęzień)* |
| `[27]` | **""I speak to you now in full honesty, as a king who has been forced to abdicate.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "Adarfo flinched at the word “for..."<br>`[126]` **Narrator**: "A revolutionary flinched at the ..." |
| `[29]` | **""Many of you may be wondering what transpired during my mother's birthday at the G..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` | `--;` | `[58]` **Player_Romus**: ""The upper echelons of Rizian no..."<br>`[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>*(oraz 3 innych odgałęzień)* |
| `[30]` | **""You've heard whispers of the birthday that became a battlefield. Let me assure yo..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` | `--;` | `[58]` **Player_Romus**: ""The upper echelons of Rizian no..."<br>`[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>*(oraz 3 innych odgałęzień)* |
| `[31]` | **""You will hear many versions of what happened inside the Grand Library that evenin..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` | `--;` | `[58]` **Player_Romus**: ""The upper echelons of Rizian no..."<br>`[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>*(oraz 3 innych odgałęzień)* |
| `[35]` | **""The heads of noble houses gathered, and I brought them there. What followed was w..."** | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true` | `--;` | `[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>`[15]` **Player_Romus**: ""I believed that if anyone shoul..."<br>*(oraz 3 innych odgałęzień)* |
| `[36]` | **""When the doors closed and the revolutionaries entered, I knew that our long era o..."** | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Adarfo and the revolutionary gua..." |
| `[37]` | **""It is true. I myself invited the revolutionaries inside. I worked with them to st..."** | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>`[15]` **Player_Romus**: ""I believed that if anyone shoul..."<br>*(oraz 3 innych odgałęzień)* |
| `[40]` | **""My innocent, elderly mother and I sat together that day -- completely unaware, li..."** | `[41]` **Narrator**: "Adarfo and the revolutionary gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Narrator**: "The revolutionaries' eyes sharpe..." |
| `[43]` | **""I believed I was guiding a transition. Instead, I inadvertently lit a fuse.""** | `[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>`[35]` **Player_Romus**: ""The heads of noble houses gathe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "The revolutionaries said nothing..." |
| `[44]` | **""What began as cooperation ended as a coup. The pen I offered them was snatched an..."** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[45]` | **""All I ever wanted was to help bring the reform movement's vision to life -- to se..."** | `[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>`[35]` **Player_Romus**: ""The heads of noble houses gathe..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false` | *Brak zmian stanu* | `[49]` **Narrator**: "The revolutionaries said nothing..." |
| `[54]` | **""The people demanded change -- and they did not ask for it gently. But I finally I..."** | `[42]` **Narrator**: "The revolutionaries' eyes sharpe..."<br>`[49]` **Narrator**: "The revolutionaries said nothing..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Player_Romus**: ""My actions cannot be called sur..."<br>`[16]` **Player_Romus**: ""Not to save myself. But to save..."<br>*(oraz 2 innych odgałęzień)* |
| `[55]` | **""And, I made a choice -- a choice to relinquish my power to the people of Rizia, b..."** | `[65]` **Player_Romus**: ""On that day, I listened to a mo..."<br>`[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Player_Romus**: ""My actions cannot be called sur..."<br>`[16]` **Player_Romus**: ""Not to save myself. But to save..."<br>*(oraz 2 innych odgałęzień)* |
| `[56]` | **""Because what began as murmurs in the streets became something no gun, no decree, ..."** | `[65]` **Player_Romus**: ""On that day, I listened to a mo..."<br>`[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[18]` **Player_Romus**: ""My actions cannot be called sur..."<br>`[16]` **Player_Romus**: ""Not to save myself. But to save..."<br>*(oraz 2 innych odgałęzień)* |
| `[57]` | **""This was not the transition I imagined. I sought a peaceful political changeover...."** | `[42]` **Narrator**: "The revolutionaries' eyes sharpe..."<br>`[11]` **Player_Romus**: ""Yes, I chose this. I opened the..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false` | `--;` | `[135]` **Narrator**: "Adarfo leaned in and whispered."<br>`[130]` **Narrator**: "Adarfo immediately stepped close..." |
| `[58]` | **""The upper echelons of Rizian nobility were devising a sick plan to undermine the ..."** | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Adarfo looked at me with surpris..."<br>`[59]` **Narrator**: "Adarfo nodded approvingly and sm..." |
| `[64]` | **""But this was not the transition I imagined. I sought smooth political changes. He..."** | `[59]` **Narrator**: "Adarfo nodded approvingly and sm..."<br>`[63]` **Narrator**: "Adarfo looked at me with surpris..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "His smile quickly turned into a ..." |
| `[65]` | **""On that day, I listened to a movement that spoke with the voice of the people.""** | `[59]` **Narrator**: "Adarfo nodded approvingly and sm..."<br>`[63]` **Narrator**: "Adarfo looked at me with surpris..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[55]` **Player_Romus**: ""And, I made a choice -- a choic..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **""And today, there are no longer any obstacles left before the Rizian people. The r..."** | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[54]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "The revolutionaries started appl..." |
| `[70]` | **""But this was not the transition I imagined. I sought a peaceful political changeo..."** | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[54]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[135]` **Narrator**: "Adarfo leaned in and whispered."<br>`[130]` **Narrator**: "Adarfo immediately stepped close..." |
| `[73]` | **""What went wrong? That answer depends on who you ask. But I know this: the surest ..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` | `--;` | `[104]` **Player_Romus**: ""I do not stand here to deflect ..."<br>`[75]` **Player_Romus**: ""I became the villain in someone..."<br>*(oraz 3 innych odgałęzień)* |
| `[74]` | **""There were those who believed I gave too much. Others said I gave too little. Per..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` | `--;` | `[104]` **Player_Romus**: ""I do not stand here to deflect ..."<br>`[75]` **Player_Romus**: ""I became the villain in someone..."<br>*(oraz 3 innych odgałęzień)* |
| `[75]` | **""I became the villain in someone else's story -- the scapegoat for the chaos no on..."** | `[6]` **Player_Romus**: ""Somewhere along the way, someth..."<br>`[73]` **Player_Romus**: ""What went wrong? That answer de..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[88]` **Player_Romus**: ""I stand by every single decisio..."<br>*(oraz 2 innych odgałęzień)* |
| `[76]` | **""If I could turn back time, there are things I would do differently. Of that, I ha..."** | `[6]` **Player_Romus**: ""Somewhere along the way, someth..."<br>`[73]` **Player_Romus**: ""What went wrong? That answer de..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[10]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **""Perhaps I tried too hard to preserve something that no longer wished to be preser..."** | `[6]` **Player_Romus**: ""Somewhere along the way, someth..."<br>`[73]` **Player_Romus**: ""What went wrong? That answer de..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[10]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych odgałęzień)* |
| `[78]` | **""A man named Adarfo Sotelato now speaks for you. And whether you agree with his me..."** | `[115]` **Narrator**: "The revolutionaries were getting..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 9 innych węzłów)* | `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false` | `--;` | `[172]` **Player_Romus**: ""I believe his movement will ris..."<br>`[176]` **Player_Romus**: ""I believe this movement will ri..."<br>*(oraz 4 innych odgałęzień)* |
| `[82]` | **""The revolutionary leaders now speak for you. And whether you agree with their met..."** | `[115]` **Narrator**: "The revolutionaries were getting..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 9 innych węzłów)* | `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false` | `--;` | `[172]` **Player_Romus**: ""I believe his movement will ris..."<br>`[176]` **Player_Romus**: ""I believe this movement will ri..."<br>*(oraz 4 innych odgałęzień)* |
| `[86]` | **""There were incidents I could not control, yet I bore the full weight of their con..."** | `[3]` **Player_Romus**: ""I leave behind a legacy that is..."<br>`[4]` **Player_Romus**: ""History will judge my years on ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false` | `--;` | `[104]` **Player_Romus**: ""I do not stand here to deflect ..."<br>`[75]` **Player_Romus**: ""I became the villain in someone..."<br>*(oraz 3 innych odgałęzień)* |
| `[87]` | **""In times of unrest, people do not look for truth -- they look for someone to blam..."** | `[6]` **Player_Romus**: ""Somewhere along the way, someth..."<br>`[73]` **Player_Romus**: ""What went wrong? That answer de..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[88]` **Player_Romus**: ""I stand by every single decisio..."<br>*(oraz 2 innych odgałęzień)* |
| `[88]` | **""I stand by every single decision I made during my reign as King. I wouldn't chang..."** | `[75]` **Player_Romus**: ""I became the villain in someone..."<br>`[87]` **Player_Romus**: ""In times of unrest, people do n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "The revolutionary guards exchang..." |
| `[90]` | **""But the truth is, I did not deserve any of this.""** | `[76]` **Player_Romus**: ""If I could turn back time, ther..."<br>`[77]` **Player_Romus**: ""Perhaps I tried too hard to pre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[99]` **Player_Romus**: ""The streets spoke louder than t..."<br>`[100]` **Player_Romus**: ""My only regret is that I allowe..."<br>*(oraz 4 innych odgałęzień)* |
| `[93]` | **""This revolution did not rise from within alone. It was fed -- funded -- by those ..."** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | `Variable["RiziaDLC.Morella_Funds_Revolutionaries"] == true  or  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true` | *Brak zmian stanu* | `[137]` **Narrator**: "Adarfo quickly stepped closer to..."<br>`[142]` **Narrator**: "A revolutionary quickly stepped ..."<br>*(oraz 2 innych odgałęzień)* |
| `[97]` | **""You may say I was weak for not fighting back. I say I was strong for refusing to ..."** | `[75]` **Player_Romus**: ""I became the villain in someone..."<br>`[87]` **Player_Romus**: ""In times of unrest, people do n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "The revolutionary guards exchang..." |
| `[99]` | **""The streets spoke louder than the throne. And in time, I was forced to listen.""** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 4 innych odgałęzień)* |
| `[100]` | **""My only regret is that I allowed a group of agitators to sway the masses into vio..."** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "Adarfo quickly stepped closer to..."<br>`[142]` **Narrator**: "A revolutionary quickly stepped ..."<br>*(oraz 2 innych odgałęzień)* |
| `[104]` | **""I do not stand here to deflect blame. I stand here to carry it, as a king must.""** | `[6]` **Player_Romus**: ""Somewhere along the way, someth..."<br>`[73]` **Player_Romus**: ""What went wrong? That answer de..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[8]` **Player_Romus**: ""Revolutions do not wait politel..."<br>`[10]` **Player_Romus**: ""The people demanded change -- a..."<br>*(oraz 2 innych odgałęzień)* |
| `[105]` | **""I did not seek this end. I was made the face of our nation's problems -- whether ..."** | `[75]` **Player_Romus**: ""I became the villain in someone..."<br>`[87]` **Player_Romus**: ""In times of unrest, people do n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "The revolutionary guards exchang..." |
| `[112]` | **""I supported the reforms. I presented them to the very people who now claim I stoo..."** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true` | `--;` | `[119]` **Player_Romus**: ""Although it wasn't my wish for ..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 2 innych odgałęzień)* |
| `[113]` | **""We gave them everything they could have asked for. But nothing was enough.""** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | `Variable["RiziaDLC.NatDes_Appease"] == true`<br>`(Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true) == false` | *Brak zmian stanu* | `[115]` **Narrator**: "The revolutionaries were getting..." |
| `[114]` | **""My only regret is failing to give the Rizian people what they hoped for -- what t..."** | `[90]` **Player_Romus**: ""But the truth is, I did not des..."<br>`[220]` **Narrator**: "The revolutionary guards exchang..." | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 4 innych odgałęzień)* |
| `[116]` | **""When the royal houses turned their backs, what power did I have to force their co..."** | `[7]` **Player_Romus**: ""But you must know that I fought..."<br>`[112]` **Player_Romus**: ""I supported the reforms. I pres..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 3 innych odgałęzień)* |
| `[118]` | **""Don't say I did nothing. I carried your proposals into the lion's den -- and I wa..."** | `[7]` **Player_Romus**: ""But you must know that I fought..."<br>`[112]` **Player_Romus**: ""I supported the reforms. I pres..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 3 innych odgałęzień)* |
| `[119]` | **""Although it wasn't my wish for things to come to this, I must salute the Rizian P..."** | `[7]` **Player_Romus**: ""But you must know that I fought..."<br>`[112]` **Player_Romus**: ""I supported the reforms. I pres..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[221]` **Player_Romus**: ""But none of this changes the fa..."<br>*(oraz 3 innych odgałęzień)* |
| `[153]` | **""You heard me right! The reform movement was hijacked by extremist factions -- by ..."** | `[138]` **Adarfo Sotelato**: ""Stick to the agreement, Mr. Tor..."<br>`[143]` **Narrator**: ""Stick to the agreement, Mr. Tor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Adarfo Sotelato**: ""Cut it. That's enough!""<br>`[152]` **Narrator**: "A revolutionary shouted: "Cut it..." |
| `[154]` | **""And as a result, I'm making a choice today to relinquish all my powers to the peo..."** | `[115]` **Narrator**: "The revolutionaries were getting..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[155]` | **""What I'm doing is not surrender. It is deliberate. An act to avoid the bloodshed ..."** | `[115]` **Narrator**: "The revolutionaries were getting..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[157]` | **""There are those who marched at his side, and those who cursed his name. I stood b..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false` | `--;`<br>`--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[158]` | **""He has seized the moment, and is poised to fulfill the hopes -- or greatest fears..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false` | *Brak zmian stanu* | `[177]` **Narrator**: "Adarfo quickly stepped closer to..."<br>`[182]` **Narrator**: "A revolutionary quickly stepped ..."<br>*(oraz 2 innych odgałęzień)* |
| `[162]` | **""There are those who marched at their side, and those who cursed their names. And ..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false` | `--;`<br>`--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[166]` | **""They have seized the moment, and are poised to fulfill the hopes -- or greatest f..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false` | *Brak zmian stanu* | `[177]` **Narrator**: "Adarfo quickly stepped closer to..."<br>`[182]` **Narrator**: "A revolutionary quickly stepped ..."<br>*(oraz 2 innych odgałęzień)* |
| `[168]` | **""To the noblemen and -women who once ruled with me: you saw change as a threat, an..."** | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[155]` **Player_Romus**: ""What I'm doing is not surrender..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "The revolutionaries pointed to t..." |
| `[169]` | **""To my fellow Rizians, I say: even in dissent -- even in rage -- you remained the ..."** | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[155]` **Player_Romus**: ""What I'm doing is not surrender..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "The revolutionaries pointed to t..." |
| `[170]` | **""I say to the revolutionaries: You are in control already, you've won. Lay down yo..."** | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[155]` **Player_Romus**: ""What I'm doing is not surrender..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "The revolutionaries pointed to t..."<br>`[148]` **Adarfo Sotelato**: ""Cut it. That's enough!""<br>*(oraz 1 innych odgałęzień)* |
| `[172]` | **""I believe his movement will rise to this responsibility and build a government th..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false` | `--;`<br>`--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[176]` | **""I believe this movement will rise to this responsibility and build a government t..."** | `[78]` **Player_Romus**: ""A man named Adarfo Sotelato now..."<br>`[82]` **Player_Romus**: ""The revolutionary leaders now s..." | `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false` | `--;`<br>`--;` | `[168]` **Player_Romus**: ""To the noblemen and -women who ..."<br>`[169]` **Player_Romus**: ""To my fellow Rizians, I say: ev..."<br>*(oraz 2 innych odgałęzień)* |
| `[188]` | **""We cannot rewrite the past. So we should not dwell on it any longer.""** | `[154]` **Player_Romus**: ""And as a result, I'm making a c..."<br>`[155]` **Player_Romus**: ""What I'm doing is not surrender..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Narrator**: "The revolutionaries pointed to t..." |
| `[191]` | **""Regardless, I believe Mr. Sotelato and his movement will rise to the responsibili..."** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "The revolutionaries pointed to t..." |
| `[192]` | **""However, I'd like to ask everyone to give their full support to the new government.""** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "The revolutionaries pointed to t..." |
| `[196]` | **"It is with a heart heavy with emotion, yet buoyed by hope for our future, I now de..."** | `[190]` **Narrator**: "The revolutionaries pointed to t..."<br>`[202]` **Narrator**: "The revolutionaries pointed to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[197]` | **""To put it plainly, I am finished. Done. Outta here.""** | `[190]` **Narrator**: "The revolutionaries pointed to t..."<br>`[202]` **Narrator**: "The revolutionaries pointed to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[198]` | **""From henceforth, I am stepping down in order to give way to the new order.""** | `[190]` **Narrator**: "The revolutionaries pointed to t..."<br>`[202]` **Narrator**: "The revolutionaries pointed to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[199]` | **""It gives me no great pleasure to relinquish my crown. Yet I know in my heart it i..."** | `[190]` **Narrator**: "The revolutionaries pointed to t..."<br>`[202]` **Narrator**: "The revolutionaries pointed to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[204]` | **""I feel that I have done my part for this country. And I am proud of what I achiev..."** | `[24]` **Player_Romus**: ""I have chosen to step down -- n..."<br>`[25]` **Player_Romus**: ""I am relinquishing the throne w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;`<br>`--;`<br>*(+1 skryptów)* | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 5 innych odgałęzień)* |
| `[205]` | **""Throughout my reign, I have been uplifted and sustained by the knowledge that you..."** | `[24]` **Player_Romus**: ""I have chosen to step down -- n..."<br>`[25]` **Player_Romus**: ""I am relinquishing the throne w..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false` | `--;`<br>`--;`<br>*(+1 skryptów)* | `[29]` **Player_Romus**: ""Many of you may be wondering wh..."<br>`[30]` **Player_Romus**: ""You've heard whispers of the bi..."<br>*(oraz 5 innych odgałęzień)* |
| `[212]` | **""They didn't come to negotiate -- they came to seize.""** | `[41]` **Narrator**: "Adarfo and the revolutionary gua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Narrator**: "Adarfo leaned in and whispered."<br>`[214]` **Narrator**: "Adarfo immediately stepped close..." |
| `[213]` | **""I knew there was no point in fighting back.""** | `[41]` **Narrator**: "Adarfo and the revolutionary gua..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[55]` **Player_Romus**: ""And, I made a choice -- a choic..."<br>*(oraz 3 innych odgałęzień)* |
| `[221]` | **""But none of this changes the fact that, today, I am making this announcement at g..."** | `[115]` **Narrator**: "The revolutionaries were getting..."<br>`[116]` **Player_Romus**: ""When the royal houses turned th..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Adarfo Sotelato**: ""Cut it. That's enough!""<br>`[152]` **Narrator**: "A revolutionary shouted: "Cut it..." |
| `[229]` | **""They took my wife away from me -- in cold blood!""** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[233]` | **""They executed General Taddeus and his daughter without a shred of mercy. Not a tr..."** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[234]` | **""They executed General Taddeus without a shred of mercy. Not a trial. Not a questi..."** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[243]` | **"“What began as cooperation ended as a coup. I offered the olive branch. They turne..."** | `[131]` **Adarfo Sotelato**: ""That wasn't part of the speech,..."<br>`[219]` **Adarfo Sotelato**: ""This is your last warning, Tora..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[235]` **Adarfo Sotelato**: ""Cut it. That's enough!"" |
| `[250]` | **"“Yes, I chose this path. But perhaps it was laid before me by divine design.”"** | `[17]` **Player_Romus**: ""I will not pretend it was a cel..."<br>`[35]` **Player_Romus**: ""The heads of noble houses gathe..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `--;` | `[19]` **Player_Romus**: ""I knew the risks. But I saw som..."<br>`[55]` **Player_Romus**: ""And, I made a choice -- a choic..."<br>*(oraz 3 innych odgałęzień)* |

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
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I leave behind a legacy that is imperfect, yet mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Player_Romus), `[25]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""History will judge my years on the throne. But I pray it judges them fairly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Player_Romus), `[25]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No throne can stand untouched in a storm. And in recent years, the storm has not passed over us. It has passed through us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[24]` (Player_Romus), `[25]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Somewhere along the way, something broke between the Crown and the people. And though I tried to hold it together, I fear my hands weren't enough.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But you must know that I fought for you. I fought for the reforms. I stood before the nobility and made the case myself.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Player_Romus), `[9]` (Player_Romus), `[10]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Revolutions do not wait politely. They arrive loudly, and often, without mercy. And the first person they come for is the king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Player_Romus), `[87]` (Player_Romus), `[76]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I chose not to answer rebellion with violence, because I still believed there was another way. Perhaps that was weakness. Perhaps it was wisdom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.NatDes_Oppress"] == false`
- **Kontekst wejściowy (poprzednik):** `[76]` (Player_Romus), `[77]` (Player_Romus), `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people demanded change -- and they did not ask for it gently. I heard them. But I did not always know how to answer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Player_Romus), `[77]` (Player_Romus), `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I chose this. I opened the gates. I invited them in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[17]` (Player_Romus), `[35]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""The heads of noble houses gathered, and I brought them t..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believed that if anyone should end the old order, it ought to be someone within it -- someone who could do it without bloodshed. So I made a pact. We struck before they could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus), `[35]` (Player_Romus), `[37]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not to save myself. But to save Rizia from the devastation of a civil war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player_Romus), `[54]` (Player_Romus), `[55]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not pretend it was a celebration. What occurred behind those doors changed the course of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus), `[30]` (Player_Romus), `[31]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My actions cannot be called surrender. It was a safeguard. An act to avoid the bloodshed history has witnessed too many times before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player_Romus), `[54]` (Player_Romus), `[55]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew the risks. But I saw something in their cause --something that resonated louder than our titles ever did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player_Romus), `[11]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must tell you -- just as I was betrayed, so too was the reform movement.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was not the reform I imagined. I sought a constitutional kingdom. They sought a reckoning.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[11]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They came in fast, rifles pointed. In seconds, we were all under their control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[215]` (Adarfo Sotelato), `[217]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Instead of staying true to their vision, the reformers opened their doors to radicals -- and in doing so, betrayed your faith in them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[112]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have chosen to step down -- not out of weakness, but out of strength. The strength to know when to let go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am relinquishing the throne with a heavy heart, but with a clear conscience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby announce my abdication. Because the future demands it. Because holding power too tightly can choke the very life of a nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I speak to you now in full honesty, as a king who has been forced to abdicate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Many of you may be wondering what transpired during my m..."*)
  - -> `[30]` (*Player_Romus: ""You've heard whispers of the birthday that became a batt..."*)
  - -> `[31]` (*Player_Romus: ""You will hear many versions of what happened inside the ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Many of you may be wondering what transpired during my mother's birthday at the Grand Library...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've heard whispers of the birthday that became a battlefield. Let me assure you: nothing about it was accidental.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will hear many versions of what happened inside the Grand Library that evening. I only ask that you remember -- not everything is always what it seems.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Adar..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Ad..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The heads of noble houses gathered, and I brought them there. What followed was what had to be done.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus), `[30]` (Player_Romus), `[31]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When the doors closed and the revolutionaries entered, I knew that our long era of peace under the monarchy was over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus), `[30]` (Player_Romus), `[31]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Adarfo and the revolutionary guards exchanged uneasy glan..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true. I myself invited the revolutionaries inside. I worked with them to stop the nobility from usurping the will of the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus), `[30]` (Player_Romus), `[31]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""The upper echelons of Rizian nobility were devising a si..."*)
  - -> `[17]` (*Player_Romus: ""I will not pretend it was a celebration. What occurred b..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[36]` (*Player_Romus: ""When the doors closed and the revolutionaries entered, I..."*)
  - -> `[37]` (*Player_Romus: ""It is true. I myself invited the revolutionaries inside...."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[11]` (*Player_Romus: ""Yes, I chose this. I opened the gates. I invited them in.""*)
  - -> `[15]` (*Player_Romus: ""I believed that if anyone should end the old order, it o..."*)
  - -> `[43]` (*Player_Romus: ""I believed I was guiding a transition. Instead, I inadve..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My innocent, elderly mother and I sat together that day -- completely unaware, like many of you, of what was coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The revolutionaries' eyes sharpened. No one said anything..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Adarfo and the revolutionary guards exchanged uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Yes, I chose this. I opened the gates. I invited them in.""*)
  - -> `[213]` (*Player_Romus: ""I knew there was no point in fighting back.""*)
  - -> `[212]` (*Player_Romus: ""They didn't come to negotiate -- they came to seize.""*)
  - -> `[40]` (*Player_Romus: ""My innocent, elderly mother and I sat together that day ..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The revolutionaries' eyes sharpened. No one said anything, but the warning was clear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[22]` (*Player_Romus: ""They came in fast, rifles pointed. In seconds, we were a..."*)
  - -> `[54]` (*Player_Romus: ""The people demanded change -- and they did not ask for i..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believed I was guiding a transition. Instead, I inadvertently lit a fuse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus), `[35]` (Player_Romus), `[37]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The revolutionaries said nothing, but their gaze made the..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What began as cooperation ended as a coup. The pen I offered them was snatched and turned into a blade.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I ever wanted was to help bring the reform movement's vision to life -- to see the Rizian Charter of Rights become law.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus), `[35]` (Player_Romus), `[37]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The revolutionaries said nothing, but their gaze made the..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == false)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""All I ever wanted was to help bring the reform movement'..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Narrator**
> "The revolutionaries said nothing, but their gaze made their disproval plain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""The people demanded change -- and they did not ask for i..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""I knew the risks. But I saw something in their cause --s..."*)
  - -> `[55]` (*Player_Romus: ""And, I made a choice -- a choice to relinquish my power ..."*)
  - -> `[56]` (*Player_Romus: ""Because what began as murmurs in the streets became some..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == false)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""This was not the reform I imagined. I sought a constitut..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""This was not the transition I imagined. I sought a peace..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people demanded change -- and they did not ask for it gently. But I finally I heard them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[49]` (Narrator), `[215]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And, I made a choice -- a choice to relinquish my power to the people of Rizia, by whatever means necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player_Romus), `[11]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because what began as murmurs in the streets became something no gun, no decree, no palace could silence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player_Romus), `[11]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was not the transition I imagined. I sought a peaceful political changeover. They sought a reckoning.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator), `[11]` (Player_Romus), `[15]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The upper echelons of Rizian nobility were devising a sick plan to undermine the will of the Rizian people. With the help of Adarfo Sotelato, we foiled their scheme.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus), `[30]` (Player_Romus), `[31]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Adarfo nodded approvingly and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""On that day, I listened to a movement that spoke with th..."*)
  - -> `[64]` (*Player_Romus: ""But this was not the transition I imagined. I sought smo..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Adarfo looked at me with surprise and then smiled, noddin..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Adarfo nodded approvingly and smiled."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Adarfo looked at me with surprise and then smiled, nodding approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""On that day, I listened to a movement that spoke with th..."*)
  - -> `[64]` (*Player_Romus: ""But this was not the transition I imagined. I sought smo..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But this was not the transition I imagined. I sought smooth political changes. He sought a reckoning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator), `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "His smile quickly turned into a frown."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On that day, I listened to a movement that spoke with the voice of the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator), `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""I knew the risks. But I saw something in their cause --s..."*)
  - -> `[55]` (*Player_Romus: ""And, I made a choice -- a choice to relinquish my power ..."*)
  - -> `[56]` (*Player_Romus: ""Because what began as murmurs in the streets became some..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "His smile quickly turned into a frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Romus: ""My actions cannot be called surrender. It was a safeguar..."*)
  - -> `[16]` (*Player_Romus: ""Not to save myself. But to save Rizia from the devastati..."*)
  - -> `[69]` (*Player_Romus: ""And today, there are no longer any obstacles left before..."*)
  - -> `[70]` (*Player_Romus: ""But this was not the transition I imagined. I sought a p..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned > 0"*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And today, there are no longer any obstacles left before the Rizian people. The road has been cleared.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player_Romus), `[54]` (Player_Romus), `[55]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The revolutionaries started applauding."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But this was not the transition I imagined. I sought a peaceful political changeover. They sought a reckoning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player_Romus), `[54]` (Player_Romus), `[55]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The revolutionaries started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What went wrong? That answer depends on who you ask. But I know this: the surest way to foster discontent is to ignore it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There were those who believed I gave too much. Others said I gave too little. Perhaps the truth lies somewhere in between -- but the result is here, before us all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I became the villain in someone else's story -- the scapegoat for the chaos no one dared to own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[73]` (Player_Romus), `[74]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I could turn back time, there are things I would do differently. Of that, I have no doubt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[73]` (Player_Romus), `[74]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps I tried too hard to preserve something that no longer wished to be preserved. And for that... I am sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[73]` (Player_Romus), `[74]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A man named Adarfo Sotelato now speaks for you. And whether you agree with his methods or not, you cannot deny that he has been heard.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[116]` (Player_Romus), `[118]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""A man named Adarfo Sotelato now speaks for you. And whet..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""The revolutionary leaders now speak for you. And whether..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The revolutionary leaders now speak for you. And whether you agree with their methods or not, you cannot deny that they have been heard.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[116]` (Player_Romus), `[118]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""Somewhere along the way, something broke between the Cro..."*)
  - -> `[73]` (*Player_Romus: ""What went wrong? That answer depends on who you ask. But..."*)
  - -> `[74]` (*Player_Romus: ""There were those who believed I gave too much. Others sa..."*)
  - -> `[86]` (*Player_Romus: ""There were incidents I could not control, yet I bore the..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""I do not stand here to deflect blame. I stand here to ca..."*)
  - -> `[75]` (*Player_Romus: ""I became the villain in someone else's story -- the scap..."*)
  - -> `[76]` (*Player_Romus: ""If I could turn back time, there are things I would do d..."*)
  - -> `[77]` (*Player_Romus: ""Perhaps I tried too hard to preserve something that no l..."*)
  - -> `[87]` (*Player_Romus: ""In times of unrest, people do not look for truth -- they..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Revolutions do not wait politely. They arrive loudly, an..."*)
  - -> `[88]` (*Player_Romus: ""I stand by every single decision I made during my reign ..."*)
  - -> `[105]` (*Player_Romus: ""I did not seek this end. I was made the face of our nati..."*)
  - -> `[97]` (*Player_Romus: ""You may say I was weak for not fighting back. I say I wa..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There were incidents I could not control, yet I bore the full weight of their consequences.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_Adarfo_Usurped"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Player_Romus), `[4]` (Player_Romus), `[5]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In times of unrest, people do not look for truth -- they look for someone to blame. And I stood at the center.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[73]` (Player_Romus), `[74]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand by every single decision I made during my reign as King. I wouldn't change a thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Player_Romus), `[87]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "The revolutionary guards exchanged uneasy glances."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Revolutions do not wait politely. They arrive loudly, an..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == false"*)
  - -> `[10]` (*Player_Romus: ""The people demanded change -- and they did not ask for i..."*)
  - -> `[90]` (*Player_Romus: ""But the truth is, I did not deserve any of this.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But the truth is, I did not deserve any of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Player_Romus), `[77]` (Player_Romus), `[104]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This revolution did not rise from within alone. It was fed -- funded -- by those across the border, by Morella and its shadowy backers in the CSP.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Morella_Funds_Revolutionaries"] == true  or  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Funds_Revolutionaries == true || RiziaDLC.Morella_Sabotage_Plans_Discovered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Funds_Revolutionaries == true || RiziaDL..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Morella_Funds_Revolutionaries == true || Rizia..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Funds_Revolutionaries == true || RiziaDLC.Morella_Sabotage_Plans_Discovered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Morella_Funds_Revolutionaries"] == true  or  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""This revolution did not rise from within alone. It was f..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Morella_Funds_Revolutionaries == true || RiziaDLC.Morella_Sabotage_Plans_Discovered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Morella_Funds_Revolutionaries"] == true  or  Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may say I was weak for not fighting back. I say I was strong for refusing to answer their calls for civil war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Player_Romus), `[87]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "The revolutionary guards exchanged uneasy glances."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true"*)
  - -> `[99]` (*Player_Romus: ""The streets spoke louder than the throne. And in time, I..."*)
  - -> `[100]` (*Player_Romus: ""My only regret is that I allowed a group of agitators to..."*)
  - -> `[114]` (*Player_Romus: ""My only regret is failing to give the Rizian people what..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Funds_Revolutionaries == true || RiziaDL..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The streets spoke louder than the throne. And in time, I was forced to listen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My only regret is that I allowed a group of agitators to sway the masses into violence -- violence against Rizia, its people, and its very traditions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == false"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == false)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I chose not to answer rebellion with violence, because I..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not stand here to deflect blame. I stand here to carry it, as a king must.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Player_Romus), `[73]` (Player_Romus), `[74]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not seek this end. I was made the face of our nation's problems -- whether I caused them or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Player_Romus), `[87]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "The revolutionary guards exchanged uneasy glances."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""But you must know that I fought for you. I fought for th..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I supported the reforms. I presented them to the very pe..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic_RejectedandCancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I supported the reforms. I presented them to the very people who now claim I stood in their way. They refused. And I was made to look like the obstructor.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We gave them everything they could have asked for. But nothing was enough.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.NatDes_Appease"] == true` AND `(Variable["RiziaDLC.Reform_Diplomatic_RejectedandCancelled"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "The revolutionaries were getting restless. Their gaze sha..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My only regret is failing to give the Rizian people what they hoped for -- what they deserved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Player_Romus), `[220]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "The revolutionaries were getting restless. Their gaze sharpened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When the royal houses turned their backs, what power did I have to force their cooperation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[112]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Although it wasn't my wish for things to come to this, I..."*)
  - -> `[116]` (*Player_Romus: ""When the royal houses turned their backs, what power did..."*)
  - -> `[118]` (*Player_Romus: ""Don't say I did nothing. I carried your proposals into t..."*)
  - -> `[23]` (*Player_Romus: ""Instead of staying true to their vision, the reformers o..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't say I did nothing. I carried your proposals into the lion's den -- and I was torn apart for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[112]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Although it wasn't my wish for things to come to this, I must salute the Rizian People's Party and the reform movement. You finally won!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[112]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[154]` (*Player_Romus: ""And as a result, I'm making a choice today to relinquish..."*)
  - -> `[221]` (*Player_Romus: ""But none of this changes the fact that, today, I am maki..."*)
  - -> `[155]` (*Player_Romus: ""What I'm doing is not surrender. It is deliberate. An ac..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Adarfo flinched at the word “forced.” He stepped closer to me, hand resting just near his holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Adarfo Sotelato: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[122]`
Mówca: **Adarfo Sotelato**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Adarfo flinched at the word “forced.” He stepped closer t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "A revolutionary flinched at the word “forced.” She steppe..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "A revolutionary flinched at the word “forced.” She stepped closer to me, hand resting just near her holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] = Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus: ""I leave behind a legacy that is imperfect, yet mine.""*)
  - -> `[4]` (*Player_Romus: ""History will judge my years on the throne. But I pray it..."*)
  - -> `[204]` (*Player_Romus: ""I feel that I have done my part for this country. And I ..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Adarfo immediately stepped closer to me, hand resting just near his holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Adarfo Sotelato: ""That wasn't part of the speech, Mr. Toras. Stick to the ..."*)

### Węzeł `[131]`
Mówca: **Adarfo Sotelato**
> ""That wasn't part of the speech, Mr. Toras. Stick to the statement. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned > 0"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Abdication_Speech_Warned > 0)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Adarfo leaned in and whispered."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Abdication_Speech_Warned > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Adarfo immediately stepped closer to me, hand resting jus..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Adarfo leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Adarfo Sotelato: ""This is your last warning, Toras. Think very carefully a..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_Adarfo_Usurped == true || RiziaDLC.Adar..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Adarfo quickly stepped closer to me, hand resting just near his holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Adarfo Sotelato: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[138]`
Mówca: **Adarfo Sotelato**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Adarfo quickly stepped closer to me, hand resting just ne..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "A revolutionary quickly stepped closer tome, hand resting..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "A revolutionary quickly stepped closer tome, hand resting just near her holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] = Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[148]`
Mówca: **Adarfo Sotelato**
> ""Cut it. That's enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Abdication_Overstepped]"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "A revolutionary shouted: "Cut it. That's enough!""*)

### Węzeł `[152]`
Mówca: **Narrator**
> "A revolutionary shouted: "Cut it. That's enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Abdication_Overstepped]"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""You heard me right! The reform movement was hijacked by extremist factions -- by people who do not plan to follow the will of the Rizian people but to force their own values upon you.""]** — Mówca: **Player_Romus**
> ""You heard me right! The reform movement was hijacked by extre--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Adarfo Sotelato), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And as a result, I'm making a choice today to relinquish all my powers to the people. I truly believe this is the best way forward for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[116]` (Player_Romus), `[118]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What I'm doing is not surrender. It is deliberate. An act to avoid the bloodshed history has written too many times before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[116]` (Player_Romus), `[118]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[153]` (*Player_Romus: ""You heard me right! The reform movement was hijacked by ..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are those who marched at his side, and those who cursed his name. I stood between them, trying to make sense of it all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He has seized the moment, and is poised to fulfill the hopes -- or greatest fears -- of a nation in flux. I leave it to history to decide which.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""There are those who marched at his side, and those who c..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""There are those who marched at their side, and those who..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are those who marched at their side, and those who cursed their names. And I stood between them, trying to make sense of it all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""He has seized the moment, and is poised to fulfill the h..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""They have seized the moment, and are poised to fulfill t..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They have seized the moment, and are poised to fulfill the hopes -- or greatest fears -- of a nation in flux. I leave it to history to decide which.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""To the noblemen and -women who once ruled with me: you s..."*)
  - -> `[169]` (*Player_Romus: ""To my fellow Rizians, I say: even in dissent -- even in ..."*)
  - -> `[188]` (*Player_Romus: ""We cannot rewrite the past. So we should not dwell on it..."*)
  - -> `[170]` (*Player_Romus: ""I say to the revolutionaries: You are in control already..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the noblemen and -women who once ruled with me: you saw change as a threat, and refused to see the future knocking at your door. Perhaps if we had changed together, this wouldn't have ended as it did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Player_Romus), `[155]` (Player_Romus), `[157]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To my fellow Rizians, I say: even in dissent -- even in rage -- you remained the beating heart of this kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Player_Romus), `[155]` (Player_Romus), `[157]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I say to the revolutionaries: You are in control already, you've won. Lay down your arms and let the people organize their own government without the influence of a single faction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Player_Romus), `[155]` (Player_Romus), `[157]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe his movement will rise to this responsibility and build a government that serves all of Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""I believe his movement will rise to this responsibility ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""I believe this movement will rise to this responsibility..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe this movement will rise to this responsibility and build a government that serves all of Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[78]` (Player_Romus), `[82]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Adarfo quickly stepped closer to me, hand resting just near his holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Adarfo Sotelato: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[178]`
Mówca: **Adarfo Sotelato**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Ex..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Adarfo quickly stepped closer to me, hand resting just ne..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "A revolutionary quickly stepped closer tome, hand resting..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "A revolutionary quickly stepped closer tome, hand resting just near her holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: ""Stick to the agreement, Mr. Toras. Don't provoke the peo..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> ""Stick to the agreement, Mr. Toras. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] = Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot rewrite the past. So we should not dwell on it any longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Player_Romus), `[155]` (Player_Romus), `[157]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[191]` (*Player_Romus: ""Regardless, I believe Mr. Sotelato and his movement will..."*)
  - -> `[192]` (*Player_Romus: ""However, I'd like to ask everyone to give their full sup..."*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[190]`
Mówca: **Narrator**
> "The revolutionaries pointed to the clock. It was time to finish my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless, I believe Mr. Sotelato and his movement will rise to the responsibility they have taken on -- and build a government that serves all of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, I'd like to ask everyone to give their full support to the new government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == false)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""I must tell you -- just as I was betrayed, so too was th..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It is with a heart heavy with emotion, yet buoyed by hope for our future, I now declare my official abdication from the throne of Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator), `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [ForcedAbdication_Jump]"*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To put it plainly, I am finished. Done. Outta here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator), `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [ForcedAbdication_Jump]"*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From henceforth, I am stepping down in order to give way to the new order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator), `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [ForcedAbdication_Jump]"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It gives me no great pleasure to relinquish my crown. Yet I know in my heart it is what I must do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Narrator), `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "Jump to: [ForcedAbdication_Jump]"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""To put it plainly, I am finished. Done. Outta here.""*)
  - -> `[196]` (*Player_Romus: "It is with a heart heavy with emotion, yet buoyed by hope..."*)
  - -> `[198]` (*Player_Romus: ""From henceforth, I am stepping down in order to give way..."*)
  - -> `[199]` (*Player_Romus: ""It gives me no great pleasure to relinquish my crown. Ye..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ForcedAbdication_Jump]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]`

### Węzeł `[202]`
Mówca: **Narrator**
> "The revolutionaries pointed to the clock. It was time to finish my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[24]` (*Player_Romus: ""I have chosen to step down -- not out of weakness, but o..."*)
  - -> `[25]` (*Player_Romus: ""I am relinquishing the throne with a heavy heart, but wi..."*)
  - -> `[26]` (*Player_Romus: ""I hereby announce my abdication. Because the future dema..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I feel that I have done my part for this country. And I am proud of what I achieved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Player_Romus), `[25]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Throughout my reign, I have been uplifted and sustained by the knowledge that your thoughts and prayers were with me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[24]` (Player_Romus), `[25]` (Player_Romus), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""No throne can stand untouched in a storm. And in recent ..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Throughout my reign, I have been uplifted and sustained ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == false)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""I speak to you now in full honesty, as a king who has be..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They didn't come to negotiate -- they came to seize.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned > 0"*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew there was no point in fighting back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Adarfo immediately stepped closer to me, his hand resting just near his holster."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Adarfo Sotelato: ""That wasn't part of the speech, Mr. Toras. Stick to the ..."*)

### Węzeł `[215]`
Mówca: **Adarfo Sotelato**
> ""That wasn't part of the speech, Mr. Toras. Stick to the statement. Don't provoke the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Adarfo leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Adarfo Sotelato: ""That wasn't part of the speech, Mr. Toras...""*)

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""That wasn't part of the speech, Mr. Toras...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned += 1"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] = Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""And, I made a choice -- a choice to relinquish my power ..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == false"*)
  - -> `[22]` (*Player_Romus: ""They came in fast, rifles pointed. In seconds, we were a..."*)
  - -> `[54]` (*Player_Romus: ""The people demanded change -- and they did not ask for i..."*)

### Węzeł `[219]`
Mówca: **Adarfo Sotelato**
> ""This is your last warning, Toras. Think very carefully about your next words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "The revolutionary guards exchanged uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""But none of this changes the fact that, today, I am making this announcement at gunpoint.""]** — Mówca: **Player_Romus**
> ""But none of this changes the fact that, today, I am making this announcement at gunp--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[116]` (Player_Romus), `[118]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned == 0"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "The revolutionaries pointed to the clock. It was time to ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Abdication_Speech_Warned == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Exec..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Abdication_Overstepped]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]`

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""They took my wife away from me -- in cold blood!""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true && RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA: ""They took my wife away from me -- in cold blood!""]** — Mówca: **Player_Romus**
> ""They took my wife away from me -- in co-""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Lucita == true && Rizi..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && Ri..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""They executed General Taddeus and his daughter without a..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Lucita == true && RiziaDLC.Lucita_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus: ""They executed General Taddeus without a shred of mercy. ..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: ""They executed General Taddeus and his daughter without a shred of mercy. Not a trial. Not a question. Just bullets.""]** — Mówca: **Player_Romus**
> ""They executed General Taddeus and his daughter witho-""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""They executed General Taddeus without a shred of mercy. Not a trial. Not a question. Just bullets.""]** — Mówca: **Player_Romus**
> ""They executed General Taddeus witho-""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[235]`
Mówca: **Adarfo Sotelato**
> ""Cut it. That's enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "Jump to: [Abdication_Overstepped]"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Abdication_Overstepped]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]`

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Appease == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""We gave them everything they could have asked for. But n..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Appease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Abdication_Speech_Warned > 0"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Abdication_Speech_Warned > 0)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Abdication_Speech_Warned > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Adarfo leaned in and whispered."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Abdication_Speech_Warned > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Abdication_Speech_Warned"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Adarfo immediately stepped closer to me, his hand resting..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“What began as cooperation ended as a coup. I offered the olive branch. They turned it into a sword. Perhaps they were never guided by the light.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Adarfo Sotelato), `[219]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Cut it. That's enough!""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player_Romus: "“What began as cooperation ended as a coup. I offered the..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""What began as cooperation ended as a coup. The pen I off..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: "“Yes, I chose this path. But perhaps it was laid before m..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Romus: ""Yes, I chose this. I opened the gates. I invited them in.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Yes, I chose this path. But perhaps it was laid before me by divine design.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Romus), `[35]` (Player_Romus), `[37]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "//"*)
