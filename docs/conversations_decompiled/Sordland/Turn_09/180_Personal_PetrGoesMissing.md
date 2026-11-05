# Sordland/Turn09/Personal_PetrGoesMissing

- **ID konwersacji:** `180`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/180_Personal_PetrGoesMissing.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 93

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[28]** Evelyn Vectern
- **[38]** Lucian Galade
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Media_Censored`
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- `BaseGameIsolated.Turn09_PetrMissing_CalledKarl`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn09_PetrMissing_CalledKarl`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP`
- `BaseGameSupport.Journal_Turn09_Petr_Learned`
- `BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed`
- `BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed`
- `BaseGameSupport.Report_Turn09_Holsord_Petr_Missing`
- `GameCondition.Turn09_Personal_PetrGoesMissing`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“Hello. Who is this?”"** | `[6]` **Narrator**: "I picked it up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "I heard a soft voice from the ot..." |
| `[8]` | **"“Don't you know what time it is?”"** | `[6]` **Narrator**: "I picked it up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "I heard a soft voice from the ot..." |
| `[11]` | **"“If you wanted to talk to Monica, she's sleeping right now.”"** | `[10]` **Evelyn Vectern**: "“Sorry for calling so late.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Evelyn Vectern**: "“Actually, I was calling for you."" |
| `[12]` | **"“Is something wrong?”"** | `[10]` **Evelyn Vectern**: "“Sorry for calling so late.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Evelyn Vectern**: "“Yes. No. I don't know, actually."" |
| `[15]` | **"“Can't this wait until the morning?”"** | `[13]` **Evelyn Vectern**: "“Actually, I was calling for you.""<br>`[14]` **Evelyn Vectern**: "“Yes. No. I don't know, actually."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Evelyn Vectern**: "“I don't think it can. I didn't ..." |
| `[16]` | **"“Spit it out, woman. What's going on?”"** | `[13]` **Evelyn Vectern**: "“Actually, I was calling for you.""<br>`[14]` **Evelyn Vectern**: "“Yes. No. I don't know, actually."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Evelyn Vectern**: "“The thing is, I was supposed to..."<br>`[90]` **Evelyn Vectern**: ""It's about Petr."" |
| `[17]` | **""All right. Let's talk.”"** | `[13]` **Evelyn Vectern**: "“Actually, I was calling for you.""<br>`[14]` **Evelyn Vectern**: "“Yes. No. I don't know, actually."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Evelyn Vectern**: "“The thing is, I was supposed to..."<br>`[90]` **Evelyn Vectern**: ""It's about Petr."" |
| `[24]` | **"“I'm sure he'll turn up.""** | `[23]` **Evelyn Vectern**: "“Trust me, Anton, I couldn't be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Evelyn Vectern**: ""I don't know, Anton. He was in ..." |
| `[25]` | **"“Get some sleep, Evelyn.”"** | `[80]` **Narrator**: "Her voice sounded tired." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Evelyn Vectern**: "“Goodbye.”" |
| `[26]` | **"“Good night.”"** | `[80]` **Narrator**: "Her voice sounded tired." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Evelyn Vectern**: "“Goodbye.”" |
| `[31]` | **"“Yes, just a work call. Sorry for waking you up.”"** | `[30]` **Monica**: "“Who was that? Is everything all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Monica**: ""I don't sleep much these days a..."<br>`[45]` **Monica**: "“Don't worry about it."" |
| `[32]` | **"“It's fine. Go back to bed.""** | `[30]` **Monica**: "“Who was that? Is everything all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "She looked at me in confusion an..." |
| `[33]` | **"“It was Evelyn. She said Petr went missing.”"** | `[30]` **Monica**: "“Who was that? Is everything all..." | `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[34]` **Monica**: "“Missing? Drowning his sorrows, ..." |
| `[36]` | **"“She's a middle-aged woman. What kind of a life will she have without a husband?”"** | `[35]` **Monica**: "“I'm surprised she still cares a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Monica looked at me strangely." |
| `[37]` | **"“She was a good influence on him.”"** | `[35]` **Monica**: "“I'm surprised she still cares a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Monica**: "“For a while.”" |
| `[38]` | **"“Whatever. Not my problem.”"** | `[35]` **Monica**: "“I'm surprised she still cares a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Monica shrugged." |
| `[46]` | **"Call Karl to ask him about Petr."** | `[42]` **Narrator**: "She made her way upstairs." | `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`<br>`Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true` | `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"...` | `[51]` **Narrator**: "The phone rang for only a few se..." |
| `[47]` | **"Go to sleep."** | `[42]` **Narrator**: "She made her way upstairs." | `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true` | *Brak zmian stanu* | `[50]` **Narrator**: "I quickly fell asleep." |
| `[48]` | **"Continue watching TV."** | `[42]` **Narrator**: "She made her way upstairs." | `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true` | *Brak zmian stanu* | `[49]` **Narrator**: "I went to bed after a few hours." |
| `[53]` | **"“Sorry for calling this late.”"** | `[52]` **Karl Greiser**: "“Yes, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Karl Greiser**: "“Not a problem, sir. I only slee..." |
| `[54]` | **"“I need you to find someone.”"** | `[52]` **Karl Greiser**: "“Yes, Mr. President.”"<br>`[56]` **Karl Greiser**: "“What can I do?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Karl Greiser**: "“As you wish.”" |
| `[60]` | **"“Petr. Petr Vectern. The ex-Vice President.”"** | `[59]` **Karl Greiser**: "“Who do you want found, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Karl Greiser**: "“As you command. I will report m..." |
| `[63]` | **""Thank you for your help. As always.""** | `[61]` **Karl Greiser**: "“As you command. I will report m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Karl Greiser**: "“Have a good night.”" |
| `[64]` | **"“Very well. I will be waiting.”"** | `[61]` **Karl Greiser**: "“As you command. I will report m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Karl Greiser**: "“Have a good night.”" |
| `[68]` | **"“He's probably just with some other girl.""** | `[23]` **Evelyn Vectern**: "“Trust me, Anton, I couldn't be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Evelyn Vectern**: ""I don't know, Anton. He was in ..." |
| `[69]` | **"“This isn't my problem.""** | `[23]` **Evelyn Vectern**: "“Trust me, Anton, I couldn't be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Evelyn Vectern**: ""You forced him to resign rather..." |
| `[73]` | **""All right. If it'll give you peace of mind, I will.""** | `[72]` **Evelyn Vectern**: ""Can't you get your police conta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Evelyn Vectern**: ""Thanks, Anton. That'd be great."" |
| `[74]` | **""You're being paranoid, Evelyn. Let's just wait a few more days and see if he turn..."** | `[72]` **Evelyn Vectern**: ""Can't you get your police conta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Evelyn Vectern**: ""You're right. I'll try to relax."" |
| `[77]` | **""I knew, by the way. About all his affairs. I'm so sorry I never came to you about..."** | `[75]` **Evelyn Vectern**: ""Thanks, Anton. That'd be great.""<br>`[76]` **Evelyn Vectern**: ""You're right. I'll try to relax.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Evelyn Vectern**: ""Boys will be boys. Isn't that w..." |
| `[78]` | **""I never had any idea he was cheating on you before this, by the way. You know I w..."** | `[75]` **Evelyn Vectern**: ""Thanks, Anton. That'd be great.""<br>`[76]` **Evelyn Vectern**: ""You're right. I'll try to relax.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Evelyn Vectern**: ""I'm sure you would have."" |
| `[86]` | **""Honestly, probably a pretty fabulous one.""** | `[39]` **Narrator**: "Monica looked at me strangely." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Narrator**: "She made her way upstairs." |
| `[99]` | **""I-- I don't know. I'll have this looked into at once.""** | `[98]` **Evelyn Vectern**: ""Be honest, Anton. What really h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Evelyn Vectern**: ""I'd appreciate that."" |
| `[100]` | **""Evelyn. You're being paranoid.""** | `[98]` **Evelyn Vectern**: ""Be honest, Anton. What really h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Evelyn Vectern**: ""No, I don't think I am."" |
| `[101]` | **""Everything I know, I already said at my press conference.""** | `[98]` **Evelyn Vectern**: ""Be honest, Anton. What really h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Evelyn Vectern**: ""Then maybe something else is go..." |
| `[106]` | **""Forget closure! Hit the town! Live a little!""** | `[105]` **Evelyn Vectern**: ""Honestly, I couldn't be more ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Evelyn Vectern**: ""That's not how this works, and ..." |
| `[107]` | **""I understand.""** | `[105]` **Evelyn Vectern**: ""Honestly, I couldn't be more ex..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Evelyn Vectern**: ""I have a few journalist contact..." |
| `[110]` | **""No need to get them involved. I'll do it myself.""** | `[109]` **Evelyn Vectern**: ""I have a few journalist contact..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Evelyn Vectern**: ""All right. Let me know what you..." |
| `[111]` | **""That's a great idea. Let me know if they come up with any leads.""** | `[109]` **Evelyn Vectern**: ""I have a few journalist contact..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Evelyn Vectern**: ""Of course."" |
| `[117]` | **""It was Evelyn. She's got some crackpot theories about what happened to Petr.""** | `[30]` **Monica**: "“Who was that? Is everything all..." | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[35]` **Monica**: "“I'm surprised she still cares a..." |
| `[124]` | **"“Sorry for calling this late.”"** | `[123]` **Karl Greiser**: "“Yes, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Karl Greiser**: "“Not a problem, sir. I only slee..." |
| `[125]` | **"“Evelyn's getting suspicious.”"** | `[123]` **Karl Greiser**: "“Yes, Mr. President.”"<br>`[126]` **Karl Greiser**: "“What can I do?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Karl Greiser**: ""As we discussed, Mr. Vectern ha..." |
| `[129]` | **""Evelyn's going to investigate this, Karl.""** | `[128]` **Karl Greiser**: ""As we discussed, Mr. Vectern ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Karl Greiser**: ""Would you like her to be dispos..." |
| `[130]` | **""I told Evelyn not to investigate this, but I don't know how much longer I can hol..."** | `[128]` **Karl Greiser**: ""As we discussed, Mr. Vectern ha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Karl Greiser**: ""Would you like her to be dispos..." |
| `[132]` | **""Good lord, no.""** | `[131]` **Karl Greiser**: ""Would you like her to be dispos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Karl Greiser**: ""Here's what I would suggest."" |
| `[133]` | **""Well, maybe...""** | `[131]` **Karl Greiser**: ""Would you like her to be dispos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Karl Greiser**: ""Frankly, sir, I would advise ag..." |
| `[137]` | **""That would be much appreciated.""** | `[136]` **Karl Greiser**: ""We still have Mr. Vectern's wed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Karl Greiser**: ""I'll begin right away, sir."" |
| `[138]` | **""What are you waiting for? Get on it!""** | `[136]` **Karl Greiser**: ""We still have Mr. Vectern's wed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Karl Greiser**: ""I'll begin right away, sir."" |
| `[146]` | **""Well? Is it done?""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[153]` **Karl Greiser**: ""Indeed it is, sir."" |
| `[147]` | **""That was fast.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[154]` **Karl Greiser**: ""Indeed, sir."" |
| `[148]` | **""Morning, Karl.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true` | *Brak zmian stanu* | `[152]` **Karl Greiser**: ""I've done what we agreed on, sir."" |
| `[149]` | **""Well? Did you find him?""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[157]` **Karl Greiser**: ""Not exactly, sir."" |
| `[150]` | **""That was fast.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[155]` **Karl Greiser**: ""Indeed, sir."" |
| `[151]` | **""Morning, Karl.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[286]` **Karl Greiser**: ""This isn't easy for me to say."" |
| `[161]` | **""What did the note say?""** | `[160]` **Karl Greiser**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Karl Greiser**: ""We kept it vague. Asking forgiv..." |
| `[162]` | **""Do you think Evelyn will be convinced?""** | `[160]` **Karl Greiser**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Karl Greiser**: ""The man was obviously in an uns..." |
| `[163]` | **""Good job.""** | `[160]` **Karl Greiser**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Karl Greiser**: ""Just carrying out my duty, sir."" |
| `[167]` | **""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""** | `[164]` **Karl Greiser**: ""The man was obviously in an uns..."<br>`[165]` **Karl Greiser**: ""We kept it vague. Asking forgiv..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Karl Greiser**: ""Right away, sir."" |
| `[168]` | **""I'll tell Evelyn the news. Thanks again for your help and discretion.""** | `[164]` **Karl Greiser**: ""The man was obviously in an uns..."<br>`[165]` **Karl Greiser**: ""We kept it vague. Asking forgiv..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Karl Greiser**: ""Of course, sir."" |
| `[173]` | **""No! Not Petr!""** | `[159]` **Karl Greiser**: ""We surmise that he took his own..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Karl Greiser**: ""I'm sorry for your loss, sir."" |
| `[174]` | **""Oh, no. I was afraid of that.""** | `[159]` **Karl Greiser**: ""We surmise that he took his own..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Karl Greiser**: ""I'm sorry for your loss, sir."" |
| `[175]` | **""What did the note say?""** | `[159]` **Karl Greiser**: ""We surmise that he took his own..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Karl Greiser**: ""He wished it to be read by Evel..." |
| `[179]` | **""I'll tell Evelyn. Thanks again for your help.""** | `[178]` **Karl Greiser**: ""Would you like to break the new..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Karl Greiser**: ""Of course, sir."" |
| `[180]` | **""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""** | `[178]` **Karl Greiser**: ""Would you like to break the new..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Karl Greiser**: ""Right away, sir."" |
| `[196]` | **"“Sorry for calling this late.”"** | `[195]` **Lucian Galade**: "“Yes, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Lucian Galade**: "“Not a problem, sir. I sleep nex..." |
| `[198]` | **"“Evelyn's getting suspicious.”"** | `[195]` **Lucian Galade**: "“Yes, Mr. President.”"<br>`[203]` **Lucian Galade**: "“What's going on?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Lucian Galade**: ""The last I knew of it, Mr. Vect..." |
| `[201]` | **""Well, maybe...""** | `[211]` **Lucian Galade**: ""I hope you're not suggesting th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Lucian Galade**: ""Frankly, sir, that would only l..." |
| `[202]` | **""What are you waiting for? Get on it!""** | `[200]` **Lucian Galade**: ""We still have Petr's wedding ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Lucian Galade**: ""Right away, sir."" |
| `[204]` | **""Can you ask the new chief?""** | `[200]` **Lucian Galade**: ""We still have Petr's wedding ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Lucian Galade**: ""Right away, sir."" |
| `[205]` | **""I told Evelyn not to investigate, but I don't know how much longer I can hold her..."** | `[208]` **Lucian Galade**: ""The last I knew of it, Mr. Vect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Lucian Galade**: ""I hope you're not suggesting th..." |
| `[207]` | **""Good lord, no.""** | `[211]` **Lucian Galade**: ""I hope you're not suggesting th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Lucian Galade**: ""Here's what I would suggest."" |
| `[209]` | **""Not well enough. Evelyn's going to investigate this.""** | `[208]` **Lucian Galade**: ""The last I knew of it, Mr. Vect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Lucian Galade**: ""I hope you're not suggesting th..." |
| `[212]` | **"“Remember that thing with Petr? Turns out Karl didn't cover his tracks.”"** | `[195]` **Lucian Galade**: "“Yes, Mr. President.”"<br>`[203]` **Lucian Galade**: "“What's going on?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Lucian Galade**: ""The last I knew of it, Mr. Vect..." |
| `[213]` | **"“Remember that thing with Petr? Turns out you didn't cover your tracks.”"** | `[123]` **Karl Greiser**: "“Yes, Mr. President.”"<br>`[126]` **Karl Greiser**: "“What can I do?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Karl Greiser**: ""As we discussed, Mr. Vectern ha..." |
| `[218]` | **""I'll tell Evelyn the news. Thanks again for your help and discretion.""** | `[234]` **Lucian Galade**: ""They kept it vague. Asking forg..."<br>`[242]` **Lucian Galade**: ""The man was obviously in an uns..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Lucian Galade**: ""Of course, sir."" |
| `[219]` | **""He was a prick who didn't deserve you.""** | `[238]` **Evelyn Vectern**: ""I just can't believe it."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Evelyn Vectern**: ""Maybe not. But he didn't deserv..." |
| `[221]` | **""Well? Is it done?""** | `[220]` **Lucian Galade**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Lucian Galade**: ""Indeed it is, sir."" |
| `[222]` | **""That was fast.""** | `[220]` **Lucian Galade**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Lucian Galade**: ""Indeed, sir."" |
| `[223]` | **""Morning, Lucian.""** | `[220]` **Lucian Galade**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Lucian Galade**: ""The SSP has complied with our r..." |
| `[225]` | **""Did you find him?""** | `[258]` **Narrator**: "I picked up. It was Evelyn." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Evelyn Vectern**: ""Not exactly."" |
| `[226]` | **""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""** | `[234]` **Lucian Galade**: ""They kept it vague. Asking forg..."<br>`[242]` **Lucian Galade**: ""The man was obviously in an uns..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Lucian Galade**: ""Right away, sir."" |
| `[227]` | **""No! Not Petr!""** | `[262]` **Narrator**: "She trailed off." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Evelyn Vectern**: ""I just can't believe it."" |
| `[232]` | **""What did the note say?""** | `[262]` **Narrator**: "She trailed off." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Evelyn Vectern**: ""He wanted it to be for my eyes ..." |
| `[235]` | **""Oh, no. I was afraid of that.""** | `[262]` **Narrator**: "She trailed off." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Evelyn Vectern**: ""I just can't believe it."" |
| `[237]` | **""I'm so sorry for your loss.""** | `[244]` **Evelyn Vectern**: ""He wanted it to be for my eyes ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Evelyn Vectern**: ""I'm sorry for yours, Anton."" |
| `[240]` | **""Morning, Evelyn.""** | `[258]` **Narrator**: "I picked up. It was Evelyn." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Evelyn Vectern**: ""Hi again, Anton."" |
| `[245]` | **""What did the note say?""** | `[241]` **Lucian Galade**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Lucian Galade**: ""They kept it vague. Asking forg..." |
| `[246]` | **""Any news?""** | `[258]` **Narrator**: "I picked up. It was Evelyn." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Evelyn Vectern**: ""Unfortunately, yes."" |
| `[249]` | **""Do you think Evelyn will be convinced?""** | `[241]` **Lucian Galade**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucian Galade**: ""The man was obviously in an uns..." |
| `[250]` | **""Good job.""** | `[241]` **Lucian Galade**: ""His wedding ring, a half-empty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Lucian Galade**: ""I hope we never have to speak o..." |
| `[279]` | **""I'm sorry about what happened between you two.""** | `[75]` **Evelyn Vectern**: ""Thanks, Anton. That'd be great.""<br>`[76]` **Evelyn Vectern**: ""You're right. I'll try to relax.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Evelyn Vectern**: ""Thanks, I guess."" |
| `[287]` | **""Hello, Karl.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[292]` **Karl Greiser**: ""You may want to sit down, sir."" |
| `[288]` | **""What's going on?""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[292]` **Karl Greiser**: ""You may want to sit down, sir."" |
| `[289]` | **""Please tell me you have good news.""** | `[142]` **Karl Greiser**: ""Good morning, Mr. President."" | `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false` | *Brak zmian stanu* | `[290]` **Karl Greiser**: ""Unfortunately not, sir."" |

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
  - -> `[3]` (*Narrator: "Midnight. I was in the living room watching the tail end ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Midnight. I was in the living room watching the tail end of a news report when I heard the phone ring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I sighed and walked over to the phone, wondering who coul..."*)

### Węzeł `[4]`
Mówca: **Evelyn Vectern**
> "“Hello. Anton?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Evelyn Vectern: "“This is Evelyn.”"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I sighed and walked over to the phone, wondering who could be calling me this late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I picked it up."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“Hello. Who is this?”"*)
  - -> `[8]` (*Player: "“Don't you know what time it is?”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Hello. Who is this?”"]** — Mówca: **Player**
> "“Hello. Who is this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I heard a soft voice from the other end."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Don't you know what time it is?”"]** — Mówca: **Player**
> "“Don't you know what time it is?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I heard a soft voice from the other end."*)

### Węzeł `[9]`
Mówca: **Evelyn Vectern**
> "“This is Evelyn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Evelyn Vectern: "“Sorry for calling so late.”"*)

### Węzeł `[10]`
Mówca: **Evelyn Vectern**
> "“Sorry for calling so late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“If you wanted to talk to Monica, she's sleeping right now.”"*)
  - -> `[12]` (*Player: "“Is something wrong?”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“If you wanted to talk to Monica, she's sleeping right now.”"]** — Mówca: **Player**
> "“If you wanted to talk to Monica, she's sleeping right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Evelyn Vectern: "“Actually, I was calling for you.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Is something wrong?”"]** — Mówca: **Player**
> "“Is something wrong?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Evelyn Vectern: "“Yes. No. I don't know, actually.""*)

### Węzeł `[13]`
Mówca: **Evelyn Vectern**
> "“Actually, I was calling for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""All right. Let's talk.”"*)
  - -> `[15]` (*Player: "“Can't this wait until the morning?”"*)
  - -> `[16]` (*Player: "“Spit it out, woman. What's going on?”"*)

### Węzeł `[14]`
Mówca: **Evelyn Vectern**
> "“Yes. No. I don't know, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""All right. Let's talk.”"*)
  - -> `[15]` (*Player: "“Can't this wait until the morning?”"*)
  - -> `[16]` (*Player: "“Spit it out, woman. What's going on?”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Can't this wait until the morning?”"]** — Mówca: **Player**
> "“Can't this wait until the morning?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Evelyn Vectern), `[14]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Evelyn Vectern: "“I don't think it can. I didn't know who to call.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Spit it out, woman. What's going on?”"]** — Mówca: **Player**
> "“Spit it out, woman. What's going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Evelyn Vectern), `[14]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""All right. Let's talk.”"]** — Mówca: **Player**
> ""All right. Let's talk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Evelyn Vectern), `[14]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[18]`
Mówca: **Evelyn Vectern**
> "“I don't think it can. I didn't know who to call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[19]`
Mówca: **Evelyn Vectern**
> "“The thing is, I was supposed to meet with Petr today to hand him the signed divorce papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Evelyn Vectern: "“But he didn't come to our designated meeting point. I fi..."*)

### Węzeł `[20]`
Mówca: **Evelyn Vectern**
> "“But he didn't come to our designated meeting point. I figured he might have been too drunk to remember, so I went to the apartment he's been renting -- but he wasn't there either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Evelyn Vectern: "“I asked around. The landlord, the neighbors, his friends..."*)

### Węzeł `[21]`
Mówca: **Evelyn Vectern**
> "“I asked around. The landlord, the neighbors, his friends...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Evelyn Vectern: "“No one knows where he is.”"*)

### Węzeł `[22]`
Mówca: **Evelyn Vectern**
> "“No one knows where he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Evelyn Vectern: "“Trust me, Anton, I couldn't be more excited to be rid of..."*)

### Węzeł `[23]`
Mówca: **Evelyn Vectern**
> "“Trust me, Anton, I couldn't be more excited to be rid of this man. But I can't close off this chapter of my life without his cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“I'm sure he'll turn up.""*)
  - -> `[68]` (*Player: "“He's probably just with some other girl.""*)
  - -> `[69]` (*Player: "“This isn't my problem.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I'm sure he'll turn up.""]** — Mówca: **Player**
> "“I'm sure he'll turn up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Evelyn Vectern: ""I don't know, Anton. He was in bad shape after your pres..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Get some sleep, Evelyn.”"]** — Mówca: **Player**
> "“Get some sleep, Evelyn.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Evelyn Vectern: "“Goodbye.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Evelyn Vectern: "“Goodbye.”"*)

### Węzeł `[27]`
Mówca: **Evelyn Vectern**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "The line dropped."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "As I put down the phone, Monica sleepily approached with ..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "As I put down the phone, Monica sleepily approached with a glass of water in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Monica: "“Who was that? Is everything all right?”"*)

### Węzeł `[30]`
Mówca: **Monica**
> "“Who was that? Is everything all right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Yes, just a work call. Sorry for waking you up.”"*)
  - -> `[32]` (*Player: "“It's fine. Go back to bed.""*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Yes, just a work call. Sorry for waking you up.”"]** — Mówca: **Player**
> "“Yes, just a work call. Sorry for waking you up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < 1"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“It's fine. Go back to bed.""]** — Mówca: **Player**
> "“It's fine. Go back to bed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "She looked at me in confusion and anger."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“It was Evelyn. She said Petr went missing.”"]** — Mówca: **Player**
> "“It was Evelyn. She said Petr went missing.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“Missing? Drowning his sorrows, I wager.""*)

### Węzeł `[34]`
Mówca: **Monica**
> "“Missing? Drowning his sorrows, I wager.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Monica: "“I'm surprised she still cares about him.”"*)

### Węzeł `[35]`
Mówca: **Monica**
> "“I'm surprised she still cares about him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“She's a middle-aged woman. What kind of a life will she ..."*)
  - -> `[37]` (*Player: "“She was a good influence on him.”"*)
  - -> `[38]` (*Player: "“Whatever. Not my problem.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“She's a middle-aged woman. What kind of a life will she have without a husband?”"]** — Mówca: **Player**
> "“She's a middle-aged woman. What kind of a life will she have without a husband?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Monica looked at me strangely."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“She was a good influence on him.”"]** — Mówca: **Player**
> "“She was a good influence on him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Monica: "“For a while.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Whatever. Not my problem.”"]** — Mówca: **Player**
> "“Whatever. Not my problem.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Monica shrugged."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Monica looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Monica: ""Honestly, probably a pretty fabulous one.""*)

### Węzeł `[40]`
Mówca: **Monica**
> "“For a while.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Monica shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "She made her way upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "She looked at me in confusion and anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“I will.”"*)

### Węzeł `[44]`
Mówca: **Monica**
> "“I will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[45]`
Mówca: **Monica**
> "“Don't worry about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Call Karl to ask him about Petr."]** — Mówca: **Player_Italic**
> "I picked up the phone and dialled Karl's number."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false` AND `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_PetrMissing_CalledKarl = true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Go to sleep."]** — Mówca: **Player_Italic**
> "I followed Monica to the bedroom and pulled the covers over my head."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I quickly fell asleep."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Continue watching TV."]** — Mówca: **Player_Italic**
> "I continued to watch TV."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "I went to bed after a few hours."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "I went to bed after a few hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "As I was eating breakfast the next morning, the phone rang."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "I quickly fell asleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "As I was eating breakfast the next morning, the phone rang."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Karl Greiser: "“Yes, Mr. President.”"*)

### Węzeł `[52]`
Mówca: **Karl Greiser**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Sorry for calling this late.”"*)
  - -> `[54]` (*Player: "“I need you to find someone.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Karl Greiser: "“Not a problem, sir. I only sleep for three fifteen-minut..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“I need you to find someone.”"]** — Mówca: **Player**
> "“I need you to find someone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Karl Greiser), `[56]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Karl Greiser: "“As you wish.”"*)

### Węzeł `[55]`
Mówca: **Karl Greiser**
> "“Not a problem, sir. I only sleep for three fifteen-minute intervals per night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Karl Greiser: "“What can I do?”"*)

### Węzeł `[56]`
Mówca: **Karl Greiser**
> "“What can I do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“I need you to find someone.”"*)

### Węzeł `[57]`
Mówca: **Karl Greiser**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard the faint rustling of a notepad being opened."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard the faint rustling of a notepad being opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Karl Greiser: "“Who do you want found, sir?”"*)

### Węzeł `[59]`
Mówca: **Karl Greiser**
> "“Who do you want found, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“Petr. Petr Vectern. The ex-Vice President.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Petr. Petr Vectern. The ex-Vice President.”"]** — Mówca: **Player**
> "“Petr. Petr Vectern. The ex-Vice President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Karl Greiser: "“As you command. I will report my findings shortly.”"*)

### Węzeł `[61]`
Mówca: **Karl Greiser**
> "“As you command. I will report my findings shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Very well. I will be waiting.”"*)
  - -> `[63]` (*Player: ""Thank you for your help. As always.""*)

### Węzeł `[62]`
Mówca: **Karl Greiser**
> "“Have a good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He hung up. I put away the phone and went down to the bed..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Thank you for your help. As always.""]** — Mówca: **Player**
> ""Thank you for your help. As always.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Karl Greiser: "“Have a good night.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. I will be waiting.”"]** — Mówca: **Player**
> "“Very well. I will be waiting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Karl Greiser: "“Have a good night.”"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "He hung up. I put away the phone and went down to the bedroom to get some sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "As I was eating breakfast the next morning, the phone rang."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrGoesMissing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_Personal_PetrGoesMissing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true ||..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I heard a soft voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Evelyn Vectern: "“Hello. Anton?”"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“He's probably just with some other girl.""]** — Mówca: **Player**
> "“He's probably just with some other girl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Evelyn Vectern: ""I don't know, Anton. He was in bad shape after your pres..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“This isn't my problem.""]** — Mówca: **Player**
> "“This isn't my problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Evelyn Vectern: ""You forced him to resign rather than admit you couldn't ..."*)

### Węzeł `[70]`
Mówca: **Evelyn Vectern**
> ""I don't know, Anton. He was in bad shape after your press conference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Evelyn Vectern: ""Can't you get your police contacts to look into this? Ju..."*)

### Węzeł `[71]`
Mówca: **Evelyn Vectern**
> ""You forced him to resign rather than admit you couldn't tell your own secretary was a spy. It kind of is your problem, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Evelyn Vectern: ""Can't you get your police contacts to look into this? Ju..."*)

### Węzeł `[72]`
Mówca: **Evelyn Vectern**
> ""Can't you get your police contacts to look into this? Just to be on the safe side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""All right. If it'll give you peace of mind, I will.""*)
  - -> `[74]` (*Player: ""You're being paranoid, Evelyn. Let's just wait a few mor..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""All right. If it'll give you peace of mind, I will.""]** — Mówca: **Player**
> ""All right. If it'll give you peace of mind, I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Evelyn Vectern: ""Thanks, Anton. That'd be great.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""You're being paranoid, Evelyn. Let's just wait a few more days and see if he turns up.""]** — Mówca: **Player**
> ""You're being paranoid, Evelyn. Let's just wait a few more days and see if he turns up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Evelyn Vectern: ""You're right. I'll try to relax.""*)

### Węzeł `[75]`
Mówca: **Evelyn Vectern**
> ""Thanks, Anton. That'd be great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I knew, by the way. About all his affairs. I'm so sorry ..."*)
  - -> `[78]` (*Player: ""I never had any idea he was cheating on you before this,..."*)
  - -> `[279]` (*Player: ""I'm sorry about what happened between you two.""*)

### Węzeł `[76]`
Mówca: **Evelyn Vectern**
> ""You're right. I'll try to relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I knew, by the way. About all his affairs. I'm so sorry ..."*)
  - -> `[78]` (*Player: ""I never had any idea he was cheating on you before this,..."*)
  - -> `[279]` (*Player: ""I'm sorry about what happened between you two.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I knew, by the way. About all his affairs. I'm so sorry I never came to you about it.""]** — Mówca: **Player**
> ""I knew, by the way. About all his affairs. I'm so sorry I never came to you about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Evelyn Vectern), `[76]` (Evelyn Vectern), `[112]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Evelyn Vectern: ""Boys will be boys. Isn't that what they say?""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I never had any idea he was cheating on you before this, by the way. You know I would've come to you about it.""]** — Mówca: **Player**
> ""I never had any idea he was cheating on you before this, by the way. You know I would've come to you about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Evelyn Vectern), `[76]` (Evelyn Vectern), `[112]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Evelyn Vectern: ""I'm sure you would have.""*)

### Węzeł `[79]`
Mówca: **Evelyn Vectern**
> ""Boys will be boys. Isn't that what they say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her voice sounded tired."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Her voice sounded tired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“Good night.”"*)
  - -> `[25]` (*Player: "“Get some sleep, Evelyn.”"*)

### Węzeł `[81]`
Mówca: **Evelyn Vectern**
> ""I'm sure you would have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her voice sounded tired."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < 1"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion < 1)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Monica: ""I don't sleep much these days anyway.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: "“Don't worry about it.""*)

### Węzeł `[85]`
Mówca: **Monica**
> ""I don't sleep much these days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Honestly, probably a pretty fabulous one.""]** — Mówca: **Monica**
> ""Honestly, probably a pretty fabulous one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "She made her way upstairs."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Evelyn Vectern: "“The thing is, I was supposed to meet with Petr today to ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Evelyn Vectern: ""It's about Petr.""*)

### Węzeł `[90]`
Mówca: **Evelyn Vectern**
> ""It's about Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway ==..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Evelyn Vectern: ""It's been weeks since he and that woman ran away, hasn't..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Evelyn Vectern: ""I was told I couldn't finalize the divorce until he sign..."*)

### Węzeł `[94]`
Mówca: **Evelyn Vectern**
> ""It's been weeks since he and that woman ran away, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Evelyn Vectern: ""He's not some sort of escape artist. He's instantly reco..."*)

### Węzeł `[95]`
Mówca: **Evelyn Vectern**
> ""I was told I couldn't finalize the divorce until he signs the papers. So I went to the apartment he's been renting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Evelyn Vectern: ""He wasn't there. Actually, it looked like nobody had bee..."*)

### Węzeł `[96]`
Mówca: **Evelyn Vectern**
> ""He wasn't there. Actually, it looked like nobody had been living there for weeks. I called the housekeeper at his villa in Erlory, and she told me the same thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Evelyn Vectern: ""Be honest, Anton. What really happened to him?""*)

### Węzeł `[97]`
Mówca: **Evelyn Vectern**
> ""He's not some sort of escape artist. He's instantly recognizable. And you said you had your best men on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Evelyn Vectern: ""Be honest, Anton. What really happened to him?""*)

### Węzeł `[98]`
Mówca: **Evelyn Vectern**
> ""Be honest, Anton. What really happened to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: ""I-- I don't know. I'll have this looked into at once.""*)
  - -> `[100]` (*Player: ""Evelyn. You're being paranoid.""*)
  - -> `[101]` (*Player: ""Everything I know, I already said at my press conference.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I-- I don't know. I'll have this looked into at once.""]** — Mówca: **Player**
> ""I-- I don't know. I'll have this looked into at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Evelyn Vectern: ""I'd appreciate that.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Evelyn. You're being paranoid.""]** — Mówca: **Player**
> ""Evelyn. You're being paranoid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Evelyn Vectern: ""No, I don't think I am.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""Everything I know, I already said at my press conference.""]** — Mówca: **Player**
> ""Everything I know, I already said at my press conference.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Evelyn Vectern: ""Then maybe something else is going on that neither of us..."*)

### Węzeł `[102]`
Mówca: **Evelyn Vectern**
> ""No, I don't think I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Evelyn Vectern: ""Honestly, I couldn't be more excited to be rid of the ma..."*)

### Węzeł `[103]`
Mówca: **Evelyn Vectern**
> ""Then maybe something else is going on that neither of us know about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Evelyn Vectern: ""Honestly, I couldn't be more excited to be rid of the ma..."*)

### Węzeł `[104]`
Mówca: **Evelyn Vectern**
> ""I'd appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Evelyn Vectern: ""Honestly, I couldn't be more excited to be rid of the ma..."*)

### Węzeł `[105]`
Mówca: **Evelyn Vectern**
> ""Honestly, I couldn't be more excited to be rid of the man. But I'll never get closure if I can't track him down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Forget closure! Hit the town! Live a little!""*)
  - -> `[107]` (*Player: ""I understand.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Forget closure! Hit the town! Live a little!""]** — Mówca: **Player**
> ""Forget closure! Hit the town! Live a little!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Evelyn Vectern: ""That's not how this works, and you know it.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I understand.""]** — Mówca: **Player**
> ""I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Evelyn Vectern: ""I have a few journalist contacts left over from my Holso..."*)

### Węzeł `[108]`
Mówca: **Evelyn Vectern**
> ""That's not how this works, and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Evelyn Vectern: ""I have a few journalist contacts left over from my Holso..."*)

### Węzeł `[109]`
Mówca: **Evelyn Vectern**
> ""I have a few journalist contacts left over from my Holsord Post days. I'm thinking of asking them to investigate this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""No need to get them involved. I'll do it myself.""*)
  - -> `[111]` (*Player: ""That's a great idea. Let me know if they come up with an..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""No need to get them involved. I'll do it myself.""]** — Mówca: **Player**
> ""No need to get them involved. I'll do it myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Evelyn Vectern: ""All right. Let me know what you can find.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""That's a great idea. Let me know if they come up with any leads.""]** — Mówca: **Player**
> ""That's a great idea. Let me know if they come up with any leads.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Evelyn Vectern: ""Of course.""*)

### Węzeł `[112]`
Mówca: **Evelyn Vectern**
> ""All right. Let me know what you can find.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I knew, by the way. About all his affairs. I'm so sorry ..."*)
  - -> `[78]` (*Player: ""I never had any idea he was cheating on you before this,..."*)
  - -> `[279]` (*Player: ""I'm sorry about what happened between you two.""*)

### Węzeł `[113]`
Mówca: **Evelyn Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I knew, by the way. About all his affairs. I'm so sorry ..."*)
  - -> `[78]` (*Player: ""I never had any idea he was cheating on you before this,..."*)
  - -> `[279]` (*Player: ""I'm sorry about what happened between you two.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""It was Evelyn. She's got some crackpot theories about wh..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“It was Evelyn. She said Petr went missing.”"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""It was Evelyn. She's got some crackpot theories about what happened to Petr.""]** — Mówca: **Player**
> ""It was Evelyn. She's got some crackpot theories about what happened to Petr.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Monica: "“I'm surprised she still cares about him.”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[47]` (*Player_Italic: "Go to sleep."*)
  - -> `[48]` (*Player_Italic: "Continue watching TV."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I went to my private study, picked up the phone and called Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "The phone rang for only a few seconds."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Karl Greiser: "“Yes, Mr. President.”"*)

### Węzeł `[123]`
Mówca: **Karl Greiser**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: "“Sorry for calling this late.”"*)
  - -> `[125]` (*Player: "“Evelyn's getting suspicious.”"*)
  - -> `[213]` (*Player: "“Remember that thing with Petr? Turns out you didn't cove..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Karl Greiser: "“Not a problem, sir. I only sleep for three fifteen-minut..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Evelyn's getting suspicious.”"]** — Mówca: **Player**
> "“Evelyn's getting suspicious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Karl Greiser), `[126]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Karl Greiser: ""As we discussed, Mr. Vectern has been well and properly ..."*)

### Węzeł `[126]`
Mówca: **Karl Greiser**
> "“What can I do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Evelyn's getting suspicious.”"*)
  - -> `[213]` (*Player: "“Remember that thing with Petr? Turns out you didn't cove..."*)

### Węzeł `[127]`
Mówca: **Karl Greiser**
> "“Not a problem, sir. I only sleep for three fifteen-minute intervals per night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Karl Greiser: "“What can I do?”"*)

### Węzeł `[128]`
Mówca: **Karl Greiser**
> ""As we discussed, Mr. Vectern has been well and properly disposed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""Evelyn's going to investigate this, Karl.""*)
  - -> `[130]` (*Player: ""I told Evelyn not to investigate this, but I don't know ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Evelyn's going to investigate this, Karl.""]** — Mówca: **Player**
> ""Evelyn's going to investigate this, Karl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Karl Greiser: ""Would you like her to be disposed of as well, sir?""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""I told Evelyn not to investigate this, but I don't know how much longer I can hold her off.""]** — Mówca: **Player**
> ""I told Evelyn not to investigate this, but I don't know how much longer I can hold her off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Karl Greiser: ""Would you like her to be disposed of as well, sir?""*)

### Węzeł `[131]`
Mówca: **Karl Greiser**
> ""Would you like her to be disposed of as well, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""Good lord, no.""*)
  - -> `[133]` (*Player: ""Well, maybe...""*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Good lord, no.""]** — Mówca: **Player**
> ""Good lord, no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Karl Greiser: ""Here's what I would suggest.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Well, maybe...""]** — Mówca: **Player**
> ""Well, maybe...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Karl Greiser: ""Frankly, sir, I would advise against it. It would only l..."*)

### Węzeł `[134]`
Mówca: **Karl Greiser**
> ""Frankly, sir, I would advise against it. It would only lead to more unnecessary suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Karl Greiser: ""Here's what I would suggest.""*)

### Węzeł `[135]`
Mówca: **Karl Greiser**
> ""Here's what I would suggest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Karl Greiser: ""We still have Mr. Vectern's wedding ring and a sample of..."*)

### Węzeł `[136]`
Mówca: **Karl Greiser**
> ""We still have Mr. Vectern's wedding ring and a sample of his handwriting. It would be fairly easy to plant evidence of his death by suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""That would be much appreciated.""*)
  - -> `[138]` (*Player: ""What are you waiting for? Get on it!""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""That would be much appreciated.""]** — Mówca: **Player**
> ""That would be much appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Karl Greiser: ""I'll begin right away, sir.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""What are you waiting for? Get on it!""]** — Mówca: **Player**
> ""What are you waiting for? Get on it!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Karl Greiser: ""I'll begin right away, sir.""*)

### Węzeł `[139]`
Mówca: **Karl Greiser**
> ""I'll begin right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He hung up. I put away the phone and went down to the bed..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "As I was eating breakfast the next morning, the phone rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[141]`
Mówca: **Narrator**
> "I picked up. It was Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Karl Greiser: ""Good morning, Mr. President.""*)

### Węzeł `[142]`
Mówca: **Karl Greiser**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""Well? Is it done?""*)
  - -> `[148]` (*Player: ""Morning, Karl.""*)
  - -> `[147]` (*Player: ""That was fast.""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""Well? Is it done?""]** — Mówca: **Player**
> ""Well? Is it done?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Karl Greiser: ""Indeed it is, sir.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Karl Greiser: ""Indeed, sir.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Morning, Karl.""]** — Mówca: **Player**
> ""Morning, Karl.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Karl Greiser: ""I've done what we agreed on, sir.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Well? Did you find him?""]** — Mówca: **Player**
> ""Well? Did you find him?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Karl Greiser: ""Not exactly, sir.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Karl Greiser: ""Indeed, sir.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Morning, Karl.""]** — Mówca: **Player**
> ""Morning, Karl.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Karl Greiser: ""This isn't easy for me to say.""*)

### Węzeł `[152]`
Mówca: **Karl Greiser**
> ""I've done what we agreed on, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[153]`
Mówca: **Karl Greiser**
> ""Indeed it is, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[154]`
Mówca: **Karl Greiser**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[155]`
Mówca: **Karl Greiser**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: ""I have some unfortunate news regarding Mr. Vectern.""*)

### Węzeł `[156]`
Mówca: **Karl Greiser**
> ""I have some unfortunate news regarding Mr. Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[157]`
Mówca: **Karl Greiser**
> ""Not exactly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[158]`
Mówca: **Karl Greiser**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were found on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Karl Greiser: ""We surmise that he took his own life.""*)

### Węzeł `[159]`
Mówca: **Karl Greiser**
> ""We surmise that he took his own life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""No! Not Petr!""*)
  - -> `[174]` (*Player: ""Oh, no. I was afraid of that.""*)
  - -> `[175]` (*Player: ""What did the note say?""*)

### Węzeł `[160]`
Mówca: **Karl Greiser**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were planted on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: ""What did the note say?""*)
  - -> `[162]` (*Player: ""Do you think Evelyn will be convinced?""*)
  - -> `[163]` (*Player: ""Good job.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Karl Greiser: ""We kept it vague. Asking forgiveness from you and Evelyn..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Do you think Evelyn will be convinced?""]** — Mówca: **Player**
> ""Do you think Evelyn will be convinced?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Karl Greiser: ""The man was obviously in an unstable state before. I don..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Good job.""]** — Mówca: **Player**
> ""Good job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Karl Greiser: ""Just carrying out my duty, sir.""*)

### Węzeł `[164]`
Mówca: **Karl Greiser**
> ""The man was obviously in an unstable state before. I don't think it's a stretch of the imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[168]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[165]`
Mówca: **Karl Greiser**
> ""We kept it vague. Asking forgiveness from you and Evelyn, that sort of thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[168]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[166]`
Mówca: **Karl Greiser**
> ""Just carrying out my duty, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[168]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Karl Greiser), `[165]` (Karl Greiser), `[166]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Karl Greiser: ""Right away, sir.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""I'll tell Evelyn the news. Thanks again for your help and discretion.""]** — Mówca: **Player**
> ""I'll tell Evelyn the news. Thanks again for your help and discretion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Karl Greiser), `[165]` (Karl Greiser), `[166]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""Of course, sir.""*)

### Węzeł `[169]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Karl hung up. With a heavy heart, I started mentally rehe..."*)

### Węzeł `[170]`
Mówca: **Karl Greiser**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Karl hung up. With a heavy heart, I started mentally rehe..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started mentally rehearsing what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started mentally rehearsing what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""No! Not Petr!""]** — Mówca: **Player**
> ""No! Not Petr!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Karl Greiser: ""I'm sorry for your loss, sir.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Oh, no. I was afraid of that.""]** — Mówca: **Player**
> ""Oh, no. I was afraid of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Karl Greiser: ""I'm sorry for your loss, sir.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Karl Greiser: ""He wished it to be read by Evelyn alone, sir.""*)

### Węzeł `[176]`
Mówca: **Karl Greiser**
> ""He wished it to be read by Evelyn alone, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Karl Greiser: ""Would you like to break the news to Mrs. Vectern or shou..."*)

### Węzeł `[177]`
Mówca: **Karl Greiser**
> ""I'm sorry for your loss, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Karl Greiser: ""Would you like to break the news to Mrs. Vectern or shou..."*)

### Węzeł `[178]`
Mówca: **Karl Greiser**
> ""Would you like to break the news to Mrs. Vectern or should I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[179]` (*Player: ""I'll tell Evelyn. Thanks again for your help.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""I'll tell Evelyn. Thanks again for your help.""]** — Mówca: **Player**
> ""I'll tell Evelyn. Thanks again for your help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Karl Greiser: ""Of course, sir.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Karl Greiser: ""Right away, sir.""*)

### Węzeł `[181]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Karl hung up. With a heavy heart, I started thinking abou..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started thinking about what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started thinking about what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[184]`
Mówca: **Karl Greiser**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Karl hung up. With a heavy heart, I started thinking abou..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Petr_Learned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Petr_Learned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Holsord_Petr_Missing = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_Petr_Missing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Italic: "Call Karl to ask him about Petr."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "I went to my private study, picked up the phone and calle..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I went to my private study, picked up the phone and calle..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "I went to my private study, picked up the phone and called Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "The phone rang for only a few seconds."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucian Galade: "“Yes, Mr. President.”"*)

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“Sorry for calling this late.”"*)
  - -> `[198]` (*Player: "“Evelyn's getting suspicious.”"*)
  - -> `[212]` (*Player: "“Remember that thing with Petr? Turns out Karl didn't cov..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: "“Not a problem, sir. I sleep next to the phone in case I'..."*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Not a problem, sir. I sleep next to the phone in case I'm ever needed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: "“What's going on?”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Evelyn's getting suspicious.”"]** — Mówca: **Player**
> "“Evelyn's getting suspicious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Lucian Galade), `[203]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: ""The last I knew of it, Mr. Vectern had been well and pro..."*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He hung up. I put away the phone and went down to the bed..."*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""We still have Petr's wedding ring and a sample of his handwriting. It would be fairly easy for the SSP to plant evidence of his death by suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""Can you ask the new chief?""*)
  - -> `[202]` (*Player: ""What are you waiting for? Get on it!""*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""Well, maybe...""]** — Mówca: **Player**
> ""Well, maybe...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: ""Frankly, sir, that would only lead to more unnecessary s..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""What are you waiting for? Get on it!""]** — Mówca: **Player**
> ""What are you waiting for? Get on it!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: ""Right away, sir.""*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“What's going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: "“Evelyn's getting suspicious.”"*)
  - -> `[212]` (*Player: "“Remember that thing with Petr? Turns out Karl didn't cov..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Can you ask the new chief?""]** — Mówca: **Player**
> ""Can you ask the new chief?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: ""Right away, sir.""*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""I told Evelyn not to investigate, but I don't know how much longer I can hold her off.""]** — Mówca: **Player**
> ""I told Evelyn not to investigate, but I don't know how much longer I can hold her off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucian Galade: ""I hope you're not suggesting the SSP dispose of her as w..."*)

### Węzeł `[206]`
Mówca: **Lucian Galade**
> ""Here's what I would suggest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: ""We still have Petr's wedding ring and a sample of his ha..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Good lord, no.""]** — Mówca: **Player**
> ""Good lord, no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucian Galade: ""Here's what I would suggest.""*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> ""The last I knew of it, Mr. Vectern had been well and properly disposed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: ""Not well enough. Evelyn's going to investigate this.""*)
  - -> `[205]` (*Player: ""I told Evelyn not to investigate, but I don't know how m..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""Not well enough. Evelyn's going to investigate this.""]** — Mówca: **Player**
> ""Not well enough. Evelyn's going to investigate this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucian Galade: ""I hope you're not suggesting the SSP dispose of her as w..."*)

### Węzeł `[210]`
Mówca: **Lucian Galade**
> ""Frankly, sir, that would only lead to more unnecessary suspicions. And as someone who had to spend a good stretch of his career putting up with Mr. Vectern, I do feel a certain kinship with Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucian Galade: ""Here's what I would suggest.""*)

### Węzeł `[211]`
Mówca: **Lucian Galade**
> ""I hope you're not suggesting the SSP dispose of her as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""Good lord, no.""*)
  - -> `[201]` (*Player: ""Well, maybe...""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: "“Remember that thing with Petr? Turns out Karl didn't cover his tracks.”"]** — Mówca: **Player**
> "“Remember that thing with Petr? Turns out Karl didn't cover his tracks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Lucian Galade), `[203]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: ""The last I knew of it, Mr. Vectern had been well and pro..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Remember that thing with Petr? Turns out you didn't cover your tracks.”"]** — Mówca: **Player**
> "“Remember that thing with Petr? Turns out you didn't cover your tracks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Karl Greiser), `[126]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Karl Greiser: ""As we discussed, Mr. Vectern has been well and properly ..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "He hung up. I put away the phone and went down to the bedroom to get some sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "As I was eating breakfast the next morning, the phone rang."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "I picked up. It was Karl."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""I'll tell Evelyn the news. Thanks again for your help and discretion.""]** — Mówca: **Player**
> ""I'll tell Evelyn the news. Thanks again for your help and discretion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Lucian Galade), `[242]` (Lucian Galade), `[247]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""He was a prick who didn't deserve you.""]** — Mówca: **Player**
> ""He was a prick who didn't deserve you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Evelyn Vectern: ""Maybe not. But he didn't deserve to go out like this.""*)

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""Well? Is it done?""*)
  - -> `[223]` (*Player: ""Morning, Lucian.""*)
  - -> `[222]` (*Player: ""That was fast.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Well? Is it done?""]** — Mówca: **Player**
> ""Well? Is it done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lucian Galade: ""Indeed it is, sir.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Lucian Galade: ""Indeed, sir.""*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Morning, Lucian.""]** — Mówca: **Player**
> ""Morning, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucian Galade: ""The SSP has complied with our request, sir.""*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Evelyn hung up. With a heavy heart, I started thinking about what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""Did you find him?""]** — Mówca: **Player**
> ""Did you find him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Evelyn Vectern: ""Not exactly.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Lucian Galade), `[242]` (Lucian Galade), `[247]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucian Galade: ""Right away, sir.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""No! Not Petr!""]** — Mówca: **Player**
> ""No! Not Petr!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Evelyn Vectern: ""I just can't believe it.""*)

### Węzeł `[228]`
Mówca: **Evelyn Vectern**
> ""I'm sorry for yours, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Evelyn Vectern: ""I need a moment. I'll talk to you soon.""*)

### Węzeł `[229]`
Mówca: **Lucian Galade**
> ""The SSP has complied with our request, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[230]`
Mówca: **Evelyn Vectern**
> ""Maybe not. But he didn't deserve to go out like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Evelyn Vectern: ""I need a moment. I'll talk to you soon.""*)

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""Indeed it is, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Evelyn Vectern: ""He wanted it to be for my eyes only.""*)

### Węzeł `[233]`
Mówca: **Lucian Galade**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)

### Węzeł `[234]`
Mówca: **Lucian Galade**
> ""They kept it vague. Asking forgiveness from you and Evelyn, that sort of thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[218]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Oh, no. I was afraid of that.""]** — Mówca: **Player**
> ""Oh, no. I was afraid of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Evelyn Vectern: ""I just can't believe it.""*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Lucian hung up. With a heavy heart, I started mentally rehearsing what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I'm so sorry for your loss.""]** — Mówca: **Player**
> ""I'm so sorry for your loss.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Evelyn Vectern: ""I'm sorry for yours, Anton.""*)

### Węzeł `[238]`
Mówca: **Evelyn Vectern**
> ""I just can't believe it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""He was a prick who didn't deserve you.""*)

### Węzeł `[239]`
Mówca: **Evelyn Vectern**
> ""Not exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Evelyn's voice wavered."*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Morning, Evelyn.""]** — Mówca: **Player**
> ""Morning, Evelyn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Evelyn Vectern: ""Hi again, Anton.""*)

### Węzeł `[241]`
Mówca: **Lucian Galade**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were planted on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: ""What did the note say?""*)
  - -> `[249]` (*Player: ""Do you think Evelyn will be convinced?""*)
  - -> `[250]` (*Player: ""Good job.""*)

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""The man was obviously in an unstable state before. I don't think it's a stretch of the imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[218]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[243]`
Mówca: **Evelyn Vectern**
> ""A friend of mine in Erlory convinced local police to scour the area. They found Petr's wedding ring along with a half-empty bottle of pills and a handwritten note on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Evelyn Vectern: ""They think-- they're telling me he...""*)

### Węzeł `[244]`
Mówca: **Evelyn Vectern**
> ""He wanted it to be for my eyes only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""I'm so sorry for your loss.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Lucian Galade: ""They kept it vague. Asking forgiveness from you and Evel..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Any news?""]** — Mówca: **Player**
> ""Any news?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Evelyn Vectern: ""Unfortunately, yes.""*)

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""I hope we never have to speak of this again, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Can you call Evelyn and tell her? I'm not sure I'm up to..."*)
  - -> `[218]` (*Player: ""I'll tell Evelyn the news. Thanks again for your help an..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Lucian hung up. With a heavy heart, I started mentally rehearsing what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Petr_Learned = true"*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Do you think Evelyn will be convinced?""]** — Mówca: **Player**
> ""Do you think Evelyn will be convinced?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""The man was obviously in an unstable state before. I don..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Good job.""]** — Mówca: **Player**
> ""Good job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: ""I hope we never have to speak of this again, sir.""*)

### Węzeł `[251]`
Mówca: **Evelyn Vectern**
> ""They think-- they're telling me he...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "She trailed off."*)

### Węzeł `[252]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Lucian hung up. With a heavy heart, I started mentally re..."*)

### Węzeł `[253]`
Mówca: **Lucian Galade**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Lucian hung up. With a heavy heart, I started mentally re..."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "I picked up. It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lucian Galade: ""Good morning, Mr. President.""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "I picked up. It was Lucian."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "I picked up. It was Evelyn."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "I picked up. It was Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""Did you find him?""*)
  - -> `[240]` (*Player: ""Morning, Evelyn.""*)
  - -> `[246]` (*Player: ""Any news?""*)

### Węzeł `[259]`
Mówca: **Evelyn Vectern**
> ""Hi again, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Evelyn's voice wavered."*)

### Węzeł `[260]`
Mówca: **Evelyn Vectern**
> ""Unfortunately, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Evelyn's voice wavered."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "Evelyn's voice wavered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Evelyn Vectern: ""A friend of mine in Erlory convinced local police to sco..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "She trailed off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""No! Not Petr!""*)
  - -> `[235]` (*Player: ""Oh, no. I was afraid of that.""*)
  - -> `[232]` (*Player: ""What did the note say?""*)

### Węzeł `[263]`
Mówca: **Evelyn Vectern**
> ""I need a moment. I'll talk to you soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Evelyn hung up. With a heavy heart, I started thinking ab..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed = tr..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_Petr_Missing = true;"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed = true; BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed"] = true;
Variable["BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_Petr_Missing = true;"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Kill..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrGoesMissing = true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suic..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrGoesMissing = true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrGoesMissing = true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true ||..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""I'm sorry about what happened between you two.""]** — Mówca: **Player**
> ""I'm sorry about what happened between you two.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Evelyn Vectern), `[76]` (Evelyn Vectern), `[112]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Evelyn Vectern: ""Thanks, I guess.""*)

### Węzeł `[280]`
Mówca: **Evelyn Vectern**
> ""Thanks, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her voice sounded tired."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_PetrMissing_CalledKarl = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "The phone rang for only a few seconds."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""Well? Did you find him?""*)
  - -> `[151]` (*Player: ""Morning, Karl.""*)
  - -> `[150]` (*Player: ""That was fast.""*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: ""Hello, Karl.""*)
  - -> `[288]` (*Player: ""What's going on?""*)
  - -> `[289]` (*Player: ""Please tell me you have good news.""*)

### Węzeł `[286]`
Mówca: **Karl Greiser**
> ""This isn't easy for me to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: ""I have some unfortunate news regarding Mr. Vectern.""*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hello, Karl.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Karl Greiser: ""You may want to sit down, sir.""*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's going on?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Karl Greiser: ""You may want to sit down, sir.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please tell me you have good news.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Karl Greiser: ""Unfortunately not, sir.""*)

### Węzeł `[290]`
Mówca: **Karl Greiser**
> ""Unfortunately not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: ""I was contacted last night by Holsord Post journalists a..."*)

### Węzeł `[291]`
Mówca: **Karl Greiser**
> ""I was contacted last night by Holsord Post journalists asking about the whereabouts of Mr. Vectern. Apparently his ex-wife had been worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Karl Greiser: ""I sent some of my men to investigate, and, well...""*)

### Węzeł `[292]`
Mówca: **Karl Greiser**
> ""You may want to sit down, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: ""I was contacted last night by Holsord Post journalists a..."*)

### Węzeł `[293]`
Mówca: **Karl Greiser**
> ""I sent some of my men to investigate, and, well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Karl Greiser: ""His wedding ring, a half-empty bottle of pills, and a ha..."*)
