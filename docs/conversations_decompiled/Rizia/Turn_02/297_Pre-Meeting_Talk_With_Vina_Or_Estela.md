# Rizia/Turn 2/Pre-Meeting Talk With Vina Or Estela

- **ID konwersacji:** `297`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/297_Pre-Meeting_Talk_With_Vina_Or_Estela.md`
- **Liczba węzłów dialogowych:** 200
- **Liczba wyborów gracza:** 79

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_TookBookAway`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[296] Rizia/Turn 2/FPnT_DiplomacyBriefing** (../Turn_02/296_FPnT_DiplomacyBriefing.md), Węzeł `[4]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"Talk to Vina."** | `[32]` **Narrator**: "To my left, I saw Vina reading a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Vina Toras**: ""Oh! Hello, Father.""<br>`[56]` **Vina Toras**: ""Oh! Greetings, Father."" |
| `[5]` | **""Got a cigarette?""** | `[4]` **Estela Toras**: ""I'm surprised you haven't died ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Estela Toras**: ""Is the Grand Wiseman Nurist?"" |
| `[6]` | **""I'm discussing the fate of the country. How could I be bored?""** | `[4]` **Estela Toras**: ""I'm surprised you haven't died ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Estela Toras**: ""The fate of the country depends..." |
| `[7]` | **""It's only a matter of time.""** | `[4]` **Estela Toras**: ""I'm surprised you haven't died ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Estela Toras**: ""If your uncle was any more plea..." |
| `[13]` | **""Do you trust Hugo?""** | `[12]` **Estela Toras**: ""Seriously, I hope you're faring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Estela Toras**: ""You're asking the wrong person...." |
| `[14]` | **""Did you know about the Golden Guard?""** | `[12]` **Estela Toras**: ""Seriously, I hope you're faring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Estela Toras**: ""Of course, darling. They're a l..." |
| `[15]` | **""It's a lot to take in.""** | `[12]` **Estela Toras**: ""Seriously, I hope you're faring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Estela Toras**: ""Even more so for Vina, I imagine.""<br>`[22]` **Estela Toras**: ""Now picture your daughter havin..." |
| `[19]` | **""Good to see you outside of the council chambers. Do you have any questions about ..."** | `[128]` **Vina Toras**: ""Oh! Hello, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Vina Toras**: ""I have plenty. But I'll figure ..." |
| `[26]` | **""I'm relieved to hear that.""** | `[20]` **Estela Toras**: ""With that said, he was nothing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[27]` | **""I wouldn't be so sure, myself.""** | `[20]` **Estela Toras**: ""With that said, he was nothing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[28]` | **""I can tell she's struggling, but she'll learn.""** | `[21]` **Estela Toras**: ""Even more so for Vina, I imagine."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[29]` | **""I don't know. Maybe it would have been a valuable experience.""** | `[22]` **Estela Toras**: ""Now picture your daughter havin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[30]` | **""I bet you're wishing you'd never asked to come to my meetings, right?""** | `[128]` **Vina Toras**: ""Oh! Hello, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Vina Toras**: ""What are you talking about? It'..." |
| `[33]` | **""Yes, she's lucky not to have to deal with it all.""** | `[22]` **Estela Toras**: ""Now picture your daughter havin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[34]` | **""Sorry if Uncle Hugo made you feel uncomfortable the other day.""** | `[128]` **Vina Toras**: ""Oh! Hello, Father."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Vina Toras**: ""That's okay. I know he means we..." |
| `[35]` | **""Yes, I'm starting to regret giving in to her.""** | `[21]` **Estela Toras**: ""Even more so for Vina, I imagine."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[36]` | **""What's that you've been reading?""** | `[55]` **Narrator**: "She hurriedly shoved the book sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Vina sheepishly fished the book ..." |
| `[38]` | **""We're sitting on so much money. Why didn't Father do anything with it?""** | `[12]` **Estela Toras**: ""Seriously, I hope you're faring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Estela Toras**: ""He was paralyzed at the end. By..." |
| `[39]` | **""Better his than mine.""** | `[37]` **Estela Toras**: ""Let's hope it never comes to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[40]` | **""Spectacular? I hadn't noticed.""** | `[37]` **Estela Toras**: ""Let's hope it never comes to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[44]` | **""I *did* lose my wife. I managed to keep myself together.""** | `[42]` **Estela Toras**: ""Nearly losing you had a momento..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[45]` | **""I can respect that. I haven't been the same since losing Lena.""** | `[42]` **Estela Toras**: ""Nearly losing you had a momento..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[46]` | **""And now I've got to pick up all of his slack.""** | `[42]` **Estela Toras**: ""Nearly losing you had a momento..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[47]` | **""She's keeping up just fine.""** | `[21]` **Estela Toras**: ""Even more so for Vina, I imagine."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "A bell chimed in the distance. I..." |
| `[48]` | **""Listen, I'll give the book back to you. But don't let anyone else catch you readi..."** | `[80]` **Vina Toras**: ""You wouldn't allow me onto the ..."<br>`[87]` **Vina Toras**: ""They thought that was what they..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Vina gave me a conspiratorial nod." |
| `[49]` | **"Take the book and look at it."** | `[55]` **Narrator**: "She hurriedly shoved the book sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Vina Toras**: ""No! You can't do that!"" |
| `[50]` | **"Talk to your mother."** | `[32]` **Narrator**: "To my left, I saw Vina reading a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "She lowered the black lace paras..." |
| `[57]` | **""Show me that book. Now.""** | `[55]` **Narrator**: "She hurriedly shoved the book sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "Vina sheepishly fished the book ..." |
| `[60]` | **""The uprising didn't succeed because the Rizian people knew what was good for them..."** | `[79]` **Vina Toras**: ""Do you think that's why the upr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[87]` **Vina Toras**: ""They thought that was what they..." |
| `[62]` | **""Chava-what?""** | `[59]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Vina Toras**: ""This was one of his first tract..." |
| `[63]` | **""This had better not be what I think it is.""** | `[59]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Vina Toras**: ""It's not as extreme as his late..." |
| `[65]` | **""It failed because it lacked cohesion. Every faction was fighting for something di..."** | `[79]` **Vina Toras**: ""Do you think that's why the upr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Vina Toras**: ""The student and workers' moveme..." |
| `[67]` | **""Workers did join the protests. But yes, the initial spark came from naval officers.""** | `[79]` **Vina Toras**: ""Do you think that's why the upr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Vina Toras**: ""And aristocrats working for the..." |
| `[68]` | **""You don't need to bother with this. You're a princess, not an intellectual.""** | `[79]` **Vina Toras**: ""Do you think that's why the upr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Vina Toras**: ""You wouldn't allow me onto the ..." |
| `[69]` | **""Enroll in etiquette classes. Learn how to bake. The possibilities are endless.""** | `[80]` **Vina Toras**: ""You wouldn't allow me onto the ..."<br>`[170]` **Vina Toras**: ""The student and workers' moveme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Vina Toras**: ""Endlessly dull, you mean. Will ..." |
| `[71]` | **""All right. But don't let anyone else catch you reading it.""** | `[81]` **Vina Toras**: ""Endlessly dull, you mean. Will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Vina gave me a conspiratorial nod." |
| `[72]` | **""It would be easier if I knew whom I could trust.""** | `[129]` **Vina Toras**: ""This must be overwhelming for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Vina Toras**: ""You can always trust me, Father."" |
| `[76]` | **""This is dangerous propaganda, Vina. Don't you realize Malenyev and his followers ..."** | `[64]` **Narrator**: "She bit her lip nervously." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[77]` **Vina Toras**: ""Isn't that why it's important t..." |
| `[78]` | **""You know, I've always been curious about Malenyevism. Do you think it's compatibl..."** | `[64]` **Narrator**: "She bit her lip nervously." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[167]` **Vina Toras**: ""Um... not really. A society rul..." |
| `[84]` | **""That name sounds familiar.""** | `[59]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Vina Toras**: ""He changed it to Malenyev right..." |
| `[86]` | **""And? Are you learning anything interesting?""** | `[64]` **Narrator**: "She bit her lip nervously." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Vina Toras**: ""I mean... of course it's all ru..." |
| `[89]` | **""This is no way for a Toras to be carrying on. I'm taking this book away from you.""** | `[80]` **Vina Toras**: ""You wouldn't allow me onto the ..."<br>`[87]` **Vina Toras**: ""They thought that was what they..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[94]` **Narrator**: "Vina stared at me in disbelief f..." |
| `[90]` | **""I knew you'd learn more off the council than on it. Keep it up.""** | `[87]` **Vina Toras**: ""They thought that was what they..."<br>`[88]` **Vina Toras**: ""And aristocrats working for the..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[105]` **Narrator**: "Vina stared at me in disbelief f..." |
| `[99]` | **""Where did you find this?""** | `[59]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Vina Toras**: ""It was just lying around in the..." |
| `[102]` | **""Malenyev? What happened to Queen Lyza?""** | `[64]` **Narrator**: "She bit her lip nervously." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Vina Toras**: ""I've read all her writings alre..." |
| `[106]` | **""No. Find another use of your time.""** | `[81]` **Vina Toras**: ""Endlessly dull, you mean. Will ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[94]` **Narrator**: "Vina stared at me in disbelief f..." |
| `[107]` | **""It's overwhelming at times. But I trust the council to help me decide.""** | `[129]` **Vina Toras**: ""This must be overwhelming for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Vina Toras**: ""I can't imagine how it feels to..." |
| `[121]` | **""Is this what I think it is?.""** | `[116]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Estela Toras**: ""I can see why he changed it to ..." |
| `[123]` | **""I'm the king. Every decision I make is the right decision.""** | `[129]` **Vina Toras**: ""This must be overwhelming for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Vina Toras**: ""I can't imagine how it feels to..." |
| `[124]` | **""Chava-what?""** | `[116]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Estela Toras**: ""I remember hearing that name a ..." |
| `[125]` | **""What were you doing snooping around my daughter's room?""** | `[116]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Estela Toras**: ""She was too quiet. I worried sh..." |
| `[126]` | **""She's been reading this? Interesting.""** | `[116]` **Narrator**: "I took a closer look at the cove..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Estela Toras**: ""That's an underreaction, wouldn..." |
| `[130]` | **""A long time ago. Frankly, they should have retired by now.""** | `[114]` **Vina Toras**: ""All of this council stuff is ol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Vina Toras**: ""Ms. Werner and Mr. Esquibel may..." |
| `[132]` | **""Queen Lyza wasn't a saint. She had her flaws.""** | `[131]` **Vina Toras**: ""Any good monarch listens to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Vina Toras**: ""I know. But it's still an inspi..." |
| `[135]` | **""Yes, it's easy enough. I'm the king. What I say goes.""** | `[114]` **Vina Toras**: ""All of this council stuff is ol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Vina Toras**: ""I can't imagine how it feels to..." |
| `[136]` | **""Don't you worry about me. Focus on keeping your own head above water.""** | `[129]` **Vina Toras**: ""This must be overwhelming for y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Vina Toras**: ""I will. I've been taking notes."" |
| `[138]` | **""It's different now that I'm the one in charge.""** | `[114]` **Vina Toras**: ""All of this council stuff is ol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Vina Toras**: ""I can't imagine how it feels to..." |
| `[139]` | **""Of course I will. They're the best hope we have for giving Rizians an actual voice.""** | `[159]` **Vina Toras**: ""What do you think of the House ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[131]` **Vina Toras**: ""Any good monarch listens to the..." |
| `[140]` | **""Wise words from a wise woman.""** | `[131]` **Vina Toras**: ""Any good monarch listens to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Vina Toras**: ""By the time she was my age, she..." |
| `[141]` | **""I was naive back then. Now I don't know whom I can trust.""** | `[114]` **Vina Toras**: ""All of this council stuff is ol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Vina Toras**: ""You can always trust me, Father."" |
| `[145]` | **""A good monarch listens. A great monarch acts.""** | `[131]` **Vina Toras**: ""Any good monarch listens to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Vina Toras**: ""Lyza acted, too."" |
| `[146]` | **""And if the will of the public is for there to be no monarch at all? What then?""** | `[131]` **Vina Toras**: ""Any good monarch listens to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Vina Toras**: ""If you rule as well as she did,..." |
| `[148]` | **""Lead the way, Your Highness.""** | `[163]` **Narrator**: "A clock chimed in the distance. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[150]` | **""I'm not against the opposition because of House Sazon. I'm against it because it'..."** | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Vina Toras**: ""Oh. Right."" |
| `[151]` | **""I'll take their opinions into consideration. But I'm the one with the final say.""** | `[159]` **Vina Toras**: ""What do you think of the House ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Vina Toras**: ""Any good monarch listens to the..." |
| `[152]` | **""I might, but I don't want anything to do with your friend Mr. Sazon.""** | `[159]` **Vina Toras**: ""What do you think of the House ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." |
| `[154]` | **""Lucas put a taint on his entire house. I won't discuss this further.""** | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Vina Toras**: ""Okay, Father."" |
| `[155]` | **""It's not all of the Sazons. Manus in particular strikes me as suspicious.""** | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Vina Toras**: ""Suspicious? He wants to work wi..." |
| `[160]` | **""The only reason I would do that is to find out the opposition's weaknesses.""** | `[159]` **Vina Toras**: ""What do you think of the House ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." |
| `[162]` | **""The Sazons have never truly been a royal house. Their ancestor had no claim to th..."** | `[153]` **Vina Toras**: ""Why do you have it out for Hous..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Vina Toras**: ""The royal heir doesn't always h..." |
| `[165]` | **""Enough chit-chat. Let's go.""** | `[163]` **Narrator**: "A clock chimed in the distance. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[176]` | **""There were Malenyevists involved in the '26 uprising, weren't there? It could be ..."** | `[127]` **Estela Toras**: ""I remember hearing that name a ..."<br>`[174]` **Estela Toras**: ""That's an underreaction, wouldn..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Estela Toras**: ""The workers and students were i..." |
| `[177]` | **""You're right, Mother. I'm sure it's pure garbage.""** | `[174]` **Estela Toras**: ""That's an underreaction, wouldn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Estela Toras**: ""It's more than that, dear. Garb..." |
| `[178]` | **""Vina's a smart girl. She wouldn't be reading this if there weren't value in it.""** | `[127]` **Estela Toras**: ""I remember hearing that name a ..."<br>`[173]` **Estela Toras**: ""And reading Malenyevist tracts ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Estela Toras**: ""That's what I'm worried about, ..." |
| `[180]` | **""I see. Well, better this than Arcasian garbage.""** | `[127]` **Estela Toras**: ""I remember hearing that name a ..."<br>`[173]` **Estela Toras**: ""And reading Malenyevist tracts ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[188]` **Estela Toras**: ""My dear, I'm no scholar, but I ..." |
| `[182]` | **""The man had some good ideas. Maybe his vision of a more egalitarian society isn't..."** | `[173]` **Estela Toras**: ""And reading Malenyevist tracts ..."<br>`[174]` **Estela Toras**: ""That's an underreaction, wouldn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Estela Toras**: ""My dear, I'm no scholar, but I ..." |
| `[193]` | **""Put it back where you found it. Vina's allowed to read what she wants in her free..."** | `[187]` **Estela Toras**: ""So what should I do with the bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Estela Toras**: ""Very well. But I do suggest hav..." |
| `[194]` | **""This is dangerous propaganda. You were right to bring it to my attention.""** | `[127]` **Estela Toras**: ""I remember hearing that name a ..."<br>`[173]` **Estela Toras**: ""And reading Malenyevist tracts ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Estela Toras**: ""I try to stay out of ideologica..." |
| `[196]` | **""Give it to me. Vina shouldn't be exposed to such ideas.""** | `[187]` **Estela Toras**: ""So what should I do with the bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Estela Toras**: ""Good thinking, Romus."" |

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
  - -> `[32]` (*Narrator: "To my left, I saw Vina reading a book on a bench beneath ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Estela Toras: ""I'm surprised you haven't died of boredom yet.""*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "Talk to Vina."]** — Mówca: **Player_Romus_Italic**
> "I made my way to the stone arch and sat down next to my daughter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[4]`
Mówca: **Estela Toras**
> ""I'm surprised you haven't died of boredom yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""I'm discussing the fate of the country. How could I be b..."*)
  - -> `[7]` (*Player_Romus: ""It's only a matter of time.""*)
  - -> `[5]` (*Player_Romus: ""Got a cigarette?""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Got a cigarette?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Estela Toras: ""Is the Grand Wiseman Nurist?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm discussing the fate of the country. How could I be bored?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Estela Toras: ""The fate of the country depends on tax rates and trade a..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only a matter of time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Estela Toras: ""If your uncle was any more pleased with the sound of his..."*)

### Węzeł `[8]`
Mówca: **Estela Toras**
> ""Is the Grand Wiseman Nurist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "She lit two cigarettes and handed one to me."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "She lit two cigarettes and handed one to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Estela Toras: ""Seriously, I hope you're faring well thus far.""*)

### Węzeł `[10]`
Mówca: **Estela Toras**
> ""The fate of the country depends on tax rates and trade agreements, I see. Wake me when there's a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Estela Toras: ""Seriously, I hope you're faring well thus far.""*)

### Węzeł `[11]`
Mówca: **Estela Toras**
> ""If your uncle was any more pleased with the sound of his own voice, he'd be a parakeet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Estela Toras: ""Seriously, I hope you're faring well thus far.""*)

### Węzeł `[12]`
Mówca: **Estela Toras**
> ""Seriously, I hope you're faring well thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""It's a lot to take in.""*)
  - -> `[14]` (*Player_Romus: ""Did you know about the Golden Guard?""*)
  - -> `[13]` (*Player_Romus: ""Do you trust Hugo?""*)
  - -> `[38]` (*Player_Romus: ""We're sitting on so much money. Why didn't Father do any..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you trust Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Estela Toras: ""You're asking the wrong person. Don't forget, he positiv..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know about the Golden Guard?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Estela Toras: ""Of course, darling. They're a little unnerving at first,..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a lot to take in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[16]`
Mówca: **Estela Toras**
> ""You're asking the wrong person. Don't forget, he positively loathes me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Estela Toras: ""With that said, he was nothing but loyal to your father...."*)

### Węzeł `[17]`
Mówca: **Estela Toras**
> ""Of course, darling. They're a little unnerving at first, but that Titus fellow would take a bullet for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Estela Toras: ""Let's hope it never comes to that. It'd be a waste of a ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "She stormed off, leaving me to my own thoughts. Before I knew it, it was time for the council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to see you outside of the council chambers. Do you have any questions about the past few meetings?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Vina Toras: ""I have plenty. But I'll figure them out on my own time.""*)

### Węzeł `[20]`
Mówca: **Estela Toras**
> ""With that said, he was nothing but loyal to your father. And that loyalty extends to anyone with the last name Toras, personal squabbles aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""I'm relieved to hear that.""*)
  - -> `[27]` (*Player_Romus: ""I wouldn't be so sure, myself.""*)

### Węzeł `[21]`
Mówca: **Estela Toras**
> ""Even more so for Vina, I imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""She's keeping up just fine.""*)
  - -> `[28]` (*Player_Romus: ""I can tell she's struggling, but she'll learn.""*)
  - -> `[35]` (*Player_Romus: ""Yes, I'm starting to regret giving in to her.""*)

### Węzeł `[22]`
Mówca: **Estela Toras**
> ""Now picture your daughter having to fill her head with that drivel. Aren't you glad you kept her off the Council?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""Yes, she's lucky not to have to deal with it all.""*)
  - -> `[29]` (*Player_Romus: ""I don't know. Maybe it would have been a valuable experi..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Estela Toras: ""Even more so for Vina, I imagine.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Estela Toras: ""Now picture your daughter having to fill her head with t..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm relieved to hear that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't be so sure, myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can tell she's struggling, but she'll learn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. Maybe it would have been a valuable experience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bet you're wishing you'd never asked to come to my meetings, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Vina Toras: ""What are you talking about? It's been fascinating!""*)

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""What are you talking about? It's been fascinating!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "To my left, I saw Vina reading a book on a bench beneath a decorative stone arch. In the date palm grove to my right, I caught a glimpse of my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Romus_Italic: "Talk to Vina."*)
  - -> `[50]` (*Player_Romus_Italic: "Talk to your mother."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, she's lucky not to have to deal with it all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry if Uncle Hugo made you feel uncomfortable the other day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Vina Toras: ""That's okay. I know he means well.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm starting to regret giving in to her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's that you've been reading?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Vina sheepishly fished the book out of her bag and handed..."*)

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""Let's hope it never comes to that. It'd be a waste of a spectacular torso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""Spectacular? I hadn't noticed.""*)
  - -> `[39]` (*Player_Romus: ""Better his than mine.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're sitting on so much money. Why didn't Father do anything with it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Estela Toras: ""He was paralyzed at the end. By the weight of all the de..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better his than mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spectacular? I hadn't noticed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""He was paralyzed at the end. By the weight of all the decisions he had made, and the fear of making a faulty one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""Nearly losing you had a momentous effect on him. On us b..."*)

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""Nearly losing you had a momentous effect on him. On us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""I *did* lose my wife. I managed to keep myself together.""*)
  - -> `[45]` (*Player_Romus: ""I can respect that. I haven't been the same since losing..."*)
  - -> `[46]` (*Player_Romus: ""And now I've got to pick up all of his slack.""*)

### Węzeł `[43]`
Mówca: **Narrator**
> "A bell chimed in the distance. It was time for the meeting to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I *did* lose my wife. I managed to keep myself together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can respect that. I haven't been the same since losing Lena.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And now I've got to pick up all of his slack.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's keeping up just fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "A bell chimed in the distance. It was time for the meetin..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen, I'll give the book back to you. But don't let anyone else catch you reading it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Vina Toras), `[87]` (Vina Toras), `[88]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Vina gave me a conspiratorial nod."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Take the book and look at it."]** — Mówca: **Player_Romus_Italic**
> "I snatched the book out of Vina's bag."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Vina Toras: ""No! You can't do that!""*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Talk to your mother."]** — Mówca: **Player_Romus_Italic**
> "I made my way to the palm grove and tapped my mother on the shoulder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "She lowered the black lace parasol she was holding and li..."*)

### Węzeł `[51]`
Mówca: **Vina Toras**
> ""That's okay. I know he means well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Vina Toras: ""Oh! Hello, Father.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Vina Toras: ""Oh! Greetings, Father.""*)

### Węzeł `[55]`
Mówca: **Narrator**
> "She hurriedly shoved the book she was reading into her handbag. On the cover were the words "Ce Faximi" -- "What Are We To Do?" in Rizian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus_Italic: "Take the book and look at it."*)
  - -> `[36]` (*Player_Romus: ""What's that you've been reading?""*)
  - -> `[57]` (*Player_Romus: ""Show me that book. Now.""*)

### Węzeł `[56]`
Mówca: **Vina Toras**
> ""Oh! Greetings, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She hurriedly shoved the book she was reading into her ha..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Show me that book. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Vina sheepishly fished the book out of her bag and handed..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Vina sheepishly fished the book out of her bag and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I took a closer look at the cover. Beneath the title were..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "I took a closer look at the cover. Beneath the title were the words, "A Collection of Proposals by L. Chavatangakwunua.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""That name sounds familiar.""*)
  - -> `[62]` (*Player_Romus: ""Chava-what?""*)
  - -> `[63]` (*Player_Romus: ""This had better not be what I think it is.""*)
  - -> `[99]` (*Player_Romus: ""Where did you find this?""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The uprising didn't succeed because the Rizian people knew what was good for them. A strong leader and strong laws.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""No! You can't do that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I took a closer look at the cover. Beneath the title were..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chava-what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Vina Toras: ""This was one of his first tracts. He wrote it right befo..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better not be what I think it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Vina Toras: ""It's not as extreme as his later work. He wrote it right..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "She bit her lip nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""This is dangerous propaganda, Vina. Don't you realize Ma..."*)
  - -> `[86]` (*Player_Romus: ""And? Are you learning anything interesting?""*)
  - -> `[78]` (*Player_Romus: ""You know, I've always been curious about Malenyevism. Do..."*)
  - -> `[102]` (*Player_Romus: ""Malenyev? What happened to Queen Lyza?""*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It failed because it lacked cohesion. Every faction was fighting for something different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Vina Toras: ""The student and workers' movement was more aligned with ..."*)

### Węzeł `[66]`
Mówca: **Vina Toras**
> ""Look at what he writes here. True systemic change can only be accomplished with the wholehearted support of the working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""Do you think that's why the uprising in Rizia failed? Be..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Workers did join the protests. But yes, the initial spark came from naval officers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""And aristocrats working for their own gain, right? Like ..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to bother with this. You're a princess, not an intellectual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""You wouldn't allow me onto the council. There are only s..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enroll in etiquette classes. Learn how to bake. The possibilities are endless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Vina Toras), `[170]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Vina Toras: ""Endlessly dull, you mean. Will you please give me my boo..."*)

### Węzeł `[70]`
Mówca: **Vina Toras**
> ""You can't control what I read, you know. I'm a grown woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway = true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. But don't let anyone else catch you reading it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Vina gave me a conspiratorial nod."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be easier if I knew whom I could trust.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Vina Toras: ""You can always trust me, Father.""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""It's not as extreme as his later work. He wrote it right before changing his last name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She bit her lip nervously."*)

### Węzeł `[75]`
Mówca: **Vina Toras**
> ""He changed it to Malenyev right after this was published.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She bit her lip nervously."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is dangerous propaganda, Vina. Don't you realize Malenyev and his followers hate people like you and me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 1"*)

### Węzeł `[77]`
Mówca: **Vina Toras**
> ""Isn't that why it's important to know how they think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Vina Toras: ""Look at what he writes here. True systemic change can on..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, I've always been curious about Malenyevism. Do you think it's compatible with monarchy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 1"*)

### Węzeł `[79]`
Mówca: **Vina Toras**
> ""Do you think that's why the uprising in Rizia failed? Because workers weren't the ones leading the charge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""It failed because it lacked cohesion. Every faction was ..."*)
  - -> `[60]` (*Player_Romus: ""The uprising didn't succeed because the Rizian people kn..."*)
  - -> `[67]` (*Player_Romus: ""Workers did join the protests. But yes, the initial spar..."*)
  - -> `[68]` (*Player_Romus: ""You don't need to bother with this. You're a princess, n..."*)

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""You wouldn't allow me onto the council. There are only so many balls I can attend. What else am I supposed to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Listen, I'll give the book back to you. But don't let an..."*)
  - -> `[89]` (*Player_Romus: ""This is no way for a Toras to be carrying on. I'm taking..."*)
  - -> `[69]` (*Player_Romus: ""Enroll in etiquette classes. Learn how to bake. The poss..."*)

### Węzeł `[81]`
Mówca: **Vina Toras**
> ""Endlessly dull, you mean. Will you please give me my book back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""All right. But don't let anyone else catch you reading it.""*)
  - -> `[106]` (*Player_Romus: ""No. Find another use of your time.""*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Vina gave me a conspiratorial nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Vina Toras: ""I won't.""*)

### Węzeł `[83]`
Mówca: **Vina Toras**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "She took the book and walked away, leaving me to my own t..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That name sounds familiar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Vina Toras: ""He changed it to Malenyev right after this was published.""*)

### Węzeł `[85]`
Mówca: **Vina Toras**
> ""This was one of his first tracts. He wrote it right before changing his name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She bit her lip nervously."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And? Are you learning anything interesting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Vina Toras: ""I mean... of course it's all rubbish. But it does make o..."*)

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""They thought that was what they wanted. Because nobody bothered to teach them otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Listen, I'll give the book back to you. But don't let an..."*)
  - -> `[89]` (*Player_Romus: ""This is no way for a Toras to be carrying on. I'm taking..."*)
  - -> `[90]` (*Player_Romus: ""I knew you'd learn more off the council than on it. Keep..."*)

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""And aristocrats working for their own gain, right? Like your kidnappers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Listen, I'll give the book back to you. But don't let an..."*)
  - -> `[89]` (*Player_Romus: ""This is no way for a Toras to be carrying on. I'm taking..."*)
  - -> `[90]` (*Player_Romus: ""I knew you'd learn more off the council than on it. Keep..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is no way for a Toras to be carrying on. I'm taking this book away from you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Vina Toras), `[87]` (Vina Toras), `[88]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew you'd learn more off the council than on it. Keep it up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Vina Toras), `[88]` (Vina Toras), `[170]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""Chin up, now. I'll see you at supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "My mother raised her parasol and strode away."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "My mother raised her parasol and strode away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Vina stared at me in disbelief for a second, then smiled."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Vina stared at me in disbelief for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Vina Toras: ""You can't control what I read, you know. I'm a grown wom..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Vina stared at me in disbelief for a moment."*)

### Węzeł `[96]`
Mówca: **Vina Toras**
> ""I will. Enjoy the boring meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "She took the book and walked away, leaving me to my own t..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "She took the book and walked away, leaving me to my own thoughts. Before I knew it, it was time for the council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where did you find this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Vina Toras: ""It was just lying around in the library. One of his supp..."*)

### Węzeł `[100]`
Mówca: **Vina Toras**
> ""It was just lying around in the library. One of his supporters must have had it translated into Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Vina Toras: ""Of course, he wrote this right before he changed his nam..."*)

### Węzeł `[101]`
Mówca: **Vina Toras**
> ""Of course, he wrote this right before he changed his name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She bit her lip nervously."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyev? What happened to Queen Lyza?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""I've read all her writings already. And this one applies..."*)

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""I've read all her writings already. And this one applies to our modern era far more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Vina Toras: ""Look at what he writes here. True systemic change can on..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Vina Toras: ""Isn't that why it's important to know how they think?""*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Vina stared at me in disbelief for a second, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Vina Toras: ""I will. Enjoy the boring meetings.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Find another use of your time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's overwhelming at times. But I trust the council to help me decide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Vina Toras: ""I can't imagine how it feels to hold all that power.""*)

### Węzeł `[108]`
Mówca: **Narrator**
> "She lowered the black lace parasol she was holding and linked her arm through mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Estela Toras: ""I'm surprised you haven't died of boredom yet.""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "She reached into her handbag and pulled out a slim paperback. On its cover were the words "Ce Faximi", or "What Are We To Do?" in Rizian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Estela Toras: ""I found this in Vina's room after she went to lunch. Her..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Vina Toras: ""All of this council stuff is old hat for you, isn't it? ..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Vina Toras: ""This must be overwhelming for you as well. So many decis..."*)

### Węzeł `[113]`
Mówca: **Vina Toras**
> ""I have plenty. But I'll figure them out on my own time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[114]`
Mówca: **Vina Toras**
> ""All of this council stuff is old hat for you, isn't it? You've even served with some of the same people before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""A long time ago. Frankly, they should have retired by now.""*)
  - -> `[138]` (*Player_Romus: ""It's different now that I'm the one in charge.""*)
  - -> `[135]` (*Player_Romus: ""Yes, it's easy enough. I'm the king. What I say goes.""*)
  - -> `[141]` (*Player_Romus: ""I was naive back then. Now I don't know whom I can trust.""*)

### Węzeł `[115]`
Mówca: **Estela Toras**
> ""One more thing, darling...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "She reached into her handbag and pulled out a slim paperb..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "I took a closer look at the cover. Beneath the title were the words, "A Collection of Proposals by L. Chavatangakwunua.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""Is this what I think it is?.""*)
  - -> `[124]` (*Player_Romus: ""Chava-what?""*)
  - -> `[126]` (*Player_Romus: ""She's been reading this? Interesting.""*)
  - -> `[125]` (*Player_Romus: ""What were you doing snooping around my daughter's room?""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Estela Toras: ""Chin up, now. I'll see you at supper.""*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Estela Toras: ""One more thing, darling...""*)

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""I found this in Vina's room after she went to lunch. Her way of rebelling against you for not letting her on the council, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "I took a closer look at the cover. Beneath the title were..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this what I think it is?.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Estela Toras: ""I can see why he changed it to 'Malenyev', That's one un..."*)

### Węzeł `[122]`
Mówca: **Estela Toras**
> ""She was too quiet. I worried she was up to something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Estela Toras: ""And reading Malenyevist tracts is definitely 'something'.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm the king. Every decision I make is the right decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Vina Toras: ""I can't imagine how it feels to hold all that power.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chava-what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Estela Toras: ""I remember hearing that name a long time ago. Before he ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What were you doing snooping around my daughter's room?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Estela Toras: ""She was too quiet. I worried she was up to something.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's been reading this? Interesting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Estela Toras: ""That's an underreaction, wouldn't you say? Malenyevist t..."*)

### Węzeł `[127]`
Mówca: **Estela Toras**
> ""I remember hearing that name a long time ago. Before he changed it to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""This is dangerous propaganda. You were right to bring it..."*)
  - -> `[178]` (*Player_Romus: ""Vina's a smart girl. She wouldn't be reading this if the..."*)
  - -> `[176]` (*Player_Romus: ""There were Malenyevists involved in the '26 uprising, we..."*)
  - -> `[180]` (*Player_Romus: ""I see. Well, better this than Arcasian garbage.""*)

### Węzeł `[128]`
Mówca: **Vina Toras**
> ""Oh! Hello, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Good to see you outside of the council chambers. Do you ..."*)
  - -> `[30]` (*Player_Romus: ""I bet you're wishing you'd never asked to come to my mee..."*)
  - -> `[34]` (*Player_Romus: ""Sorry if Uncle Hugo made you feel uncomfortable the othe..."*)

### Węzeł `[129]`
Mówca: **Vina Toras**
> ""This must be overwhelming for you as well. So many decisions to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""I'm the king. Every decision I make is the right decision.""*)
  - -> `[136]` (*Player_Romus: ""Don't you worry about me. Focus on keeping your own head..."*)
  - -> `[107]` (*Player_Romus: ""It's overwhelming at times. But I trust the council to h..."*)
  - -> `[72]` (*Player_Romus: ""It would be easier if I knew whom I could trust.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A long time ago. Frankly, they should have retired by now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Vina Toras: ""Ms. Werner and Mr. Esquibel may be old, but what they we..."*)

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""Any good monarch listens to the will of the public. Queen Lyza always said that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""A good monarch listens. A great monarch acts.""*)
  - -> `[146]` (*Player_Romus: ""And if the will of the public is for there to be no mona..."*)
  - -> `[132]` (*Player_Romus: ""Queen Lyza wasn't a saint. She had her flaws.""*)
  - -> `[140]` (*Player_Romus: ""Wise words from a wise woman.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Queen Lyza wasn't a saint. She had her flaws.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Vina Toras: ""I know. But it's still an inspiring legacy to live up to.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""Any good monarch listens to the will of the public. Quee..."*)

### Węzeł `[134]`
Mówca: **Vina Toras**
> ""By the time she was my age, she'd already been queen for a year. Imagine!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it's easy enough. I'm the king. What I say goes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Vina Toras: ""I can't imagine how it feels to hold all that power.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you worry about me. Focus on keeping your own head above water.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Vina Toras: ""I will. I've been taking notes.""*)

### Węzeł `[137]`
Mówca: **Vina Toras**
> ""I know. But it's still an inspiring legacy to live up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's different now that I'm the one in charge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Vina Toras: ""I can't imagine how it feels to hold all that power.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I will. They're the best hope we have for giving Rizians an actual voice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words from a wise woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Vina Toras: ""By the time she was my age, she'd already been queen for..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was naive back then. Now I don't know whom I can trust.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Vina Toras: ""You can always trust me, Father.""*)

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""Lyza acted, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[143]`
Mówca: **Vina Toras**
> ""You can always trust me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Vina Toras: ""What do you think of the House of Delegates? Will you go..."*)

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""Ms. Werner and Mr. Esquibel may be old, but what they were saying made a lot of sense to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Vina Toras: ""What do you think of the House of Delegates? Will you go..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A good monarch listens. A great monarch acts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Vina Toras: ""Lyza acted, too.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if the will of the public is for there to be no monarch at all? What then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Vina Toras: ""If you rule as well as she did, that won't ever become a..."*)

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""If you rule as well as she did, that won't ever become a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lead the way, Your Highness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[149]`
Mówca: **Vina Toras**
> ""I will. I've been taking notes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Vina Toras: ""What do you think of the House of Delegates? Will you go..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not against the opposition because of House Sazon. I'm against it because it's the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Vina Toras: ""Oh. Right.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take their opinions into consideration. But I'm the one with the final say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""Any good monarch listens to the will of the public. Quee..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might, but I don't want anything to do with your friend Mr. Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Vina Toras: ""Why do you have it out for House Sazon? Just because one..."*)

### Węzeł `[153]`
Mówca: **Vina Toras**
> ""Why do you have it out for House Sazon? Just because one duke plotted against the king doesn't mean the whole family is evil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""The Sazons have never truly been a royal house. Their an..."*)
  - -> `[154]` (*Player_Romus: ""Lucas put a taint on his entire house. I won't discuss t..."*)
  - -> `[155]` (*Player_Romus: ""It's not all of the Sazons. Manus in particular strikes ..."*)
  - -> `[150]` (*Player_Romus: ""I'm not against the opposition because of House Sazon. I..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucas put a taint on his entire house. I won't discuss this further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Vina Toras: ""Okay, Father.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not all of the Sazons. Manus in particular strikes me as suspicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Vina Toras: ""Suspicious? He wants to work with you. Why not at least ..."*)

### Węzeł `[156]`
Mówca: **Vina Toras**
> ""Suspicious? He wants to work with you. Why not at least hear what he has to say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[157]`
Mówca: **Vina Toras**
> ""Oh. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[158]`
Mówca: **Vina Toras**
> ""Okay, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[159]`
Mówca: **Vina Toras**
> ""What do you think of the House of Delegates? Will you go talk to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Of course I will. They're the best hope we have for givi..."*)
  - -> `[151]` (*Player_Romus: ""I'll take their opinions into consideration. But I'm the..."*)
  - -> `[160]` (*Player_Romus: ""The only reason I would do that is to find out the oppos..."*)
  - -> `[152]` (*Player_Romus: ""I might, but I don't want anything to do with your frien..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only reason I would do that is to find out the opposition's weaknesses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Vina Toras: ""Why do you have it out for House Sazon? Just because one..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Sazons have never truly been a royal house. Their ancestor had no claim to the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Vina Toras: ""The royal heir doesn't always have to be the king's son...."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "A clock chimed in the distance. It was time for the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""Enough chit-chat. Let's go.""*)
  - -> `[148]` (*Player_Romus: ""Lead the way, Your Highness.""*)

### Węzeł `[164]`
Mówca: **Vina Toras**
> ""I can't imagine how it feels to hold all that power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Vina Toras: ""What do you think of the House of Delegates? Will you go..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough chit-chat. Let's go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[166]`
Mówca: **Vina Toras**
> ""The royal heir doesn't always have to be the king's son. Sometimes there are special circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "A clock chimed in the distance. It was time for the meeting."*)

### Węzeł `[167]`
Mówca: **Vina Toras**
> ""Um... not really. A society ruled by a king is the embodiment of everything Malenyevists hate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Vina Toras: ""But it's useful to know how they think, isn't it?""*)

### Węzeł `[168]`
Mówca: **Vina Toras**
> ""But it's useful to know how they think, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Vina Toras: ""Look at what he writes here. True systemic change can on..."*)

### Węzeł `[169]`
Mówca: **Vina Toras**
> ""I mean... of course it's all rubbish. But it does make one think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Vina Toras: ""Look at what he writes here. True systemic change can on..."*)

### Węzeł `[170]`
Mówca: **Vina Toras**
> ""The student and workers' movement was more aligned with Malenyevism, but the nobles who rebelled were in favor of Arcasian democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""Listen, I'll give the book back to you. But don't let an..."*)
  - -> `[89]` (*Player_Romus: ""This is no way for a Toras to be carrying on. I'm taking..."*)
  - -> `[90]` (*Player_Romus: ""I knew you'd learn more off the council than on it. Keep..."*)
  - -> `[69]` (*Player_Romus: ""Enroll in etiquette classes. Learn how to bake. The poss..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Vina Toras: ""They thought that was what they wanted. Because nobody b..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Vina Toras: ""Um... not really. A society ruled by a king is the embod..."*)

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""And reading Malenyevist tracts is definitely 'something'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""This is dangerous propaganda. You were right to bring it..."*)
  - -> `[178]` (*Player_Romus: ""Vina's a smart girl. She wouldn't be reading this if the..."*)
  - -> `[182]` (*Player_Romus: ""The man had some good ideas. Maybe his vision of a more ..."*)
  - -> `[180]` (*Player_Romus: ""I see. Well, better this than Arcasian garbage.""*)

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""That's an underreaction, wouldn't you say? Malenyevist tracts belong in an incinerator, not your daughter's bedroom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""There were Malenyevists involved in the '26 uprising, we..."*)
  - -> `[182]` (*Player_Romus: ""The man had some good ideas. Maybe his vision of a more ..."*)
  - -> `[177]` (*Player_Romus: ""You're right, Mother. I'm sure it's pure garbage.""*)

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""I can see why he changed it to 'Malenyev', That's one unholy mass of letters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""This is dangerous propaganda. You were right to bring it..."*)
  - -> `[178]` (*Player_Romus: ""Vina's a smart girl. She wouldn't be reading this if the..."*)
  - -> `[176]` (*Player_Romus: ""There were Malenyevists involved in the '26 uprising, we..."*)
  - -> `[180]` (*Player_Romus: ""I see. Well, better this than Arcasian garbage.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There were Malenyevists involved in the '26 uprising, weren't there? It could be useful to learn how the enemy thinks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras), `[174]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Estela Toras: ""The workers and students were inspired by Malenyevism. T..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Mother. I'm sure it's pure garbage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Estela Toras: ""It's more than that, dear. Garbage won't cut off your he..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a smart girl. She wouldn't be reading this if there weren't value in it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras), `[173]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Estela Toras: ""That's what I'm worried about, dear.""*)

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""That's what I'm worried about, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Estela Toras: ""They're like cannons at that age. You've got to mind the..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Well, better this than Arcasian garbage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras), `[173]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Estela Toras: ""My dear, I'm no scholar, but I do know there's a direct ..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man had some good ideas. Maybe his vision of a more egalitarian society isn't entirely incompatible with monarchy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Estela Toras), `[174]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Estela Toras: ""My dear, I'm no scholar, but I do know there's a direct ..."*)

### Węzeł `[183]`
Mówca: **Estela Toras**
> ""My dear, I'm no scholar, but I do know there's a direct correlation between this fellow's line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[184]`
Mówca: **Estela Toras**
> ""The workers and students were inspired by Malenyevism. The nobles who got involved were pushing for Arcasian-style democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Estela Toras: ""I'm no scholar myself. But I do know the former leads to..."*)

### Węzeł `[185]`
Mówca: **Estela Toras**
> ""I'm no scholar myself. But I do know the former leads to more royal beheadings than the latter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[186]`
Mówca: **Estela Toras**
> ""It's more than that, dear. Garbage won't cut off your head in the middle of the night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[187]`
Mówca: **Estela Toras**
> ""So what should I do with the book?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""Give it to me. Vina shouldn't be exposed to such ideas.""*)
  - -> `[193]` (*Player_Romus: ""Put it back where you found it. Vina's allowed to read w..."*)

### Węzeł `[188]`
Mówca: **Estela Toras**
> ""My dear, I'm no scholar, but I do know there's a direct correlation between this fellow's line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[189]`
Mówca: **Estela Toras**
> ""They're like cannons at that age. You've got to mind the direction they're pointed in, or there'll be hell to pay when they go off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[190]`
Mówca: **Estela Toras**
> ""Very well. But I do suggest having a chat with her about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "She put the book back in her purse."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "She put the book back in her purse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Estela Toras: ""Chin up, now. I'll see you at supper.""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "She stormed off, leaving me to my own thoughts. Before I ..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put it back where you found it. Vina's allowed to read what she wants in her free time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Estela Toras: ""Very well. But I do suggest having a chat with her about..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is dangerous propaganda. You were right to bring it to my attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Estela Toras), `[173]` (Estela Toras), `[175]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Estela Toras: ""I try to stay out of ideological debates. But I do know ..."*)

### Węzeł `[195]`
Mówca: **Estela Toras**
> ""I try to stay out of ideological debates. But I do know there's a direct correlation between this line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Estela Toras: ""So what should I do with the book?""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me. Vina shouldn't be exposed to such ideas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Estela Toras: ""Good thinking, Romus.""*)

### Węzeł `[197]`
Mówca: **Estela Toras**
> ""Good thinking, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway = true; RiziaDLC.Rel..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway = true;
RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "She handed the book to me."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "She handed the book to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Estela Toras: ""Chin up, now. I'll see you at supper.""*)
