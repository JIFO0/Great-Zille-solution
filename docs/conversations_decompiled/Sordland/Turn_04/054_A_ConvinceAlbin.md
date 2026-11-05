# Sordland/Turn04/A_ConvinceAlbin

- **ID konwersacji:** `54`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/054_A_ConvinceAlbin.md`
- **Liczba węzłów dialogowych:** 727
- **Liczba wyborów gracza:** 146

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Albin_Law_Decrees_Weaker`
- `BaseGame.Reform_Albin_Law_Impeachment_Default`
- `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Albin_Law_Ministers_Assembly`
- `BaseGame.Reform_Albin_Law_TermLimits_2`
- `BaseGame.Reform_Albin_Law_Threshold_Default`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Default`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Assembly`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_Default`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Veto_Loophole`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGameIsolated.Albin_AskedForThreshold`
- `BaseGameIsolated.Turn04_A_Albin_OfferedDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Albin_Law_Decrees_Weaker`
- `BaseGame.Reform_Albin_Law_Impeachment_Default`
- `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Albin_Law_Ministers_Assembly`
- `BaseGame.Reform_Albin_Law_TermLimits_2`
- `BaseGame.Reform_Albin_Law_Threshold_Default`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Impeachment_Assembly`
- `BaseGame.Reform_Law_Impeachment_Default`
- `BaseGame.Reform_Law_Impeachment_Harder`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Assembly`
- `BaseGame.Reform_Law_Ministers_ConfidenceVote`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_TermLimits_Default`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Relations_Albin_Bribed`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGameIsolated.Albin_AskedForThreshold`
- `BaseGameIsolated.Turn04_A_Albin_OfferedDeal`
- `BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin`
- `BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAlbin`
- `BaseGameSupport.News_Turn04_HP_USPMeeting`
- `GameCondition.Turn04_A_Convince_Albin`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""How is everything going, Mr. Clavin?""** | `[11]` **Narrator**: "On his gesture, I took a seat." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Albin Clavin**: ""It's been busy. The party has b..." |
| `[12]` | **""Did a bomb drop in this office?""** | `[11]` **Narrator**: "On his gesture, I took a seat." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "He laughed." |
| `[19]` | **""It's pretty tough.""** | `[15]` **Albin Clavin**: ""How is it going for you in the ..."<br>`[18]` **Albin Clavin**: ""How is everything going for you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Albin Clavin**: ""I can't imagine the work you're..." |
| `[20]` | **""I'm feeling pretty good.""** | `[15]` **Albin Clavin**: ""How is it going for you in the ..."<br>`[18]` **Albin Clavin**: ""How is everything going for you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Albin Clavin**: ""That's great to hear."" |
| `[21]` | **""It depends on our meeting today.""** | `[15]` **Albin Clavin**: ""How is it going for you in the ..."<br>`[18]` **Albin Clavin**: ""How is everything going for you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Albin Clavin**: ""Oh, I see. Then I'll try my bes..." |
| `[36]` | **""Dear members of Assembly...""** | `[35]` **Narrator**: "I walked up to the stand as ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "I started my speech with the rea..." |
| `[37]` | **""Ladies and gentlemen of the Party!""** | `[35]` **Narrator**: "I walked up to the stand as ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "I started my speech with the rea..." |
| `[38]` | **""Brothers and sisters of United Sordland!""** | `[35]` **Narrator**: "I walked up to the stand as ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "I started my speech with the rea..." |
| `[40]` | **""The people of Sordland have spoken...""** | `[39]` **Narrator**: "I started my speech with the rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "I paused as they started clappin..." |
| `[41]` | **""Our system and institutions have increasingly became undemocratic...""** | `[39]` **Narrator**: "I started my speech with the rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "I paused when some people starte..." |
| `[42]` | **""The Supreme Court is blocking the future of Sordland...""** | `[39]` **Narrator**: "I started my speech with the rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "I paused when some people starte..." |
| `[45]` | **"Talk about democracy."** | `[43]` **Narrator**: "I paused as they started clappin..."<br>`[44]` **Narrator**: "I paused when some people starte..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause"); ;` | `[52]` **Narrator**: "The left side of the hall where ..." |
| `[46]` | **"Talk about why USP needs this to survive the next elections."** | `[43]` **Narrator**: "I paused as they started clappin..."<br>`[44]` **Narrator**: "I paused when some people starte..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause"); ;` | `[53]` **Narrator**: "The moderates that sat in the ce..." |
| `[47]` | **"Target the Old Guards and the Supreme Court."** | `[43]` **Narrator**: "I paused as they started clappin..."<br>`[44]` **Narrator**: "I paused when some people starte..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause"); ;` | `[51]` **Narrator**: "A round of applause from the lef..." |
| `[55]` | **"Threaten them to vote yes."** | `[54]` **Narrator**: "Later I explained the contents o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "The reformist wing on the left s..."<br>`[66]` **Narrator**: "The conservatives on the right s..."<br>*(oraz 1 innych odgałęzień)* |
| `[56]` | **"Ask for their votes."** | `[54]` **Narrator**: "Later I explained the contents o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "The reformist wing on the left s..."<br>`[66]` **Narrator**: "The conservatives on the right s..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **"Order them to vote yes."** | `[54]` **Narrator**: "Later I explained the contents o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "The reformist wing on the left s..."<br>`[66]` **Narrator**: "The conservatives on the right s..."<br>*(oraz 1 innych odgałęzień)* |
| `[106]` | **""The party should respect my decisions.""** | `[103]` **Albin Clavin**: ""This is in no way what we inten..."<br>`[104]` **Albin Clavin**: ""I cannot support this in its cu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Albin Clavin**: ""That would have been very nice ..." |
| `[107]` | **""I need your support, Mr. Clavin.""** | `[103]` **Albin Clavin**: ""This is in no way what we inten..."<br>`[104]` **Albin Clavin**: ""I cannot support this in its cu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Albin Clavin**: ""A fact that I'm aware of."" |
| `[108]` | **""I thought you were a democrat.""** | `[103]` **Albin Clavin**: ""This is in no way what we inten..."<br>`[104]` **Albin Clavin**: ""I cannot support this in its cu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Albin Clavin**: ""I am."" |
| `[109]` | **""What's the problem?""** | `[103]` **Albin Clavin**: ""This is in no way what we inten..."<br>`[104]` **Albin Clavin**: ""I cannot support this in its cu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Albin Clavin**: ""Where to even begin?""<br>`[129]` **Albin Clavin**: ""First, I'll say that I'm concer..."<br>*(oraz 1 innych odgałęzień)* |
| `[121]` | **""Let's hear your problems.""** | `[114]` **Albin Clavin**: ""With all due respect, maybe you..."<br>`[118]` **Albin Clavin**: ""You cannot claim that you're th..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Albin Clavin**: ""First, I'll say that I'm concer..."<br>`[579]` **Albin Clavin**: ""First, I'll say that I'm concer..."<br>*(oraz 1 innych odgałęzień)* |
| `[122]` | **""How about some other deal?""** | `[114]` **Albin Clavin**: ""With all due respect, maybe you..."<br>`[118]` **Albin Clavin**: ""You cannot claim that you're th..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[123]` | **""I can't let you sabotage this.""** | `[114]` **Albin Clavin**: ""With all due respect, maybe you..."<br>`[118]` **Albin Clavin**: ""You cannot claim that you're th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Albin Clavin**: ""You are sabotaging yourself if ..." |
| `[124]` | **""Don't forget who you are speaking to.""** | `[114]` **Albin Clavin**: ""With all due respect, maybe you..."<br>`[118]` **Albin Clavin**: ""You cannot claim that you're th..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "He raised an eyebrow and then fr..." |
| `[125]` | **""What do you mean?""** | `[119]` **Albin Clavin**: ""But at this point, even my supp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Albin Clavin**: ""This proposal will have hard ti..." |
| `[126]` | **""Tell me the issues. How can I get your support?""** | `[119]` **Albin Clavin**: ""But at this point, even my supp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Albin Clavin**: ""Where to even begin?""<br>`[129]` **Albin Clavin**: ""First, I'll say that I'm concer..."<br>*(oraz 1 innych odgałęzień)* |
| `[135]` | **""That's not a priority for us.""** | `[133]` **Albin Clavin**: ""Yet I see that our suggestions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Albin Clavin**: ""Who's us? Isn't the party inclu..." |
| `[136]` | **""They were not ignored, Mr. Clavin.""** | `[133]` **Albin Clavin**: ""Yet I see that our suggestions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Albin Clavin**: ""Excuse me, Mr. President, but h..." |
| `[137]` | **""We can address that now.""** | `[133]` **Albin Clavin**: ""Yet I see that our suggestions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Albin Clavin**: ""Oh?"" |
| `[141]` | **""Gloria and the conservatives didn't seem to have any problems with it.""** | `[133]` **Albin Clavin**: ""Yet I see that our suggestions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Albin Clavin**: ""What is that supposed to mean? ..." |
| `[149]` | **""Leave the rest of the party to me. I am now asking for *your* support.""** | `[138]` **Albin Clavin**: ""I don't know what I can do for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Albin Clavin**: ""Your proposal will be crushed l..."<br>`[152]` **Albin Clavin**: ""Oh yeah?"" |
| `[150]` | **""We can add the requested change to the proposal.""** | `[138]` **Albin Clavin**: ""I don't know what I can do for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Albin Clavin**: ""Let's see then..."" |
| `[151]` | **""Screw the party.""** | `[138]` **Albin Clavin**: ""I don't know what I can do for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Albin Clavin**: ""Oh yeah?"" |
| `[161]` | **""I am against Sollism. This law is necessary to protect me from the Court.""** | `[160]` **Albin Clavin**: ""I thought you were one of us. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Albin Clavin**: ""It will not only protect you bu..." |
| `[162]` | **""I'm sure we can work something out.""** | `[160]` **Albin Clavin**: ""I thought you were one of us. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Albin Clavin**: ""Oh yeah? What do you have in mi..." |
| `[163]` | **""Well, you were wrong, Mr. Clavin.""** | `[160]` **Albin Clavin**: ""I thought you were one of us. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Albin Clavin**: ""I see that clearly now."" |
| `[164]` | **""I'm open to discuss changes but not to this law.""** | `[160]` **Albin Clavin**: ""I thought you were one of us. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Albin Clavin**: ""Then I cannot help you.""<br>`[183]` **Albin Clavin**: ""Then I cannot help you.""<br>*(oraz 1 innych odgałęzień)* |
| `[171]` | **""I'm sure we can work out *something else*.""** | `[170]` **Albin Clavin**: ""So you want to hear our concern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[198]` | **""It isn't about more powers, it is only protection.""** | `[173]` **Albin Clavin**: ""This isn't how you *curb* the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Albin Clavin**: ""I understand where you're comin..." |
| `[199]` | **""Okay, let's change this law." [CHANGE THE REFORM]"** | `[173]` **Albin Clavin**: ""This isn't how you *curb* the p..."<br>`[202]` **Albin Clavin**: ""Let's say we trust you and you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Albin Clavin**: ""You mean it?"" |
| `[200]` | **""I'm open to discuss changes but not to this law.""** | `[173]` **Albin Clavin**: ""This isn't how you *curb* the p..."<br>`[202]` **Albin Clavin**: ""Let's say we trust you and you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Albin Clavin**: ""Then I cannot help you.""<br>`[183]` **Albin Clavin**: ""Then I cannot help you.""<br>*(oraz 1 innych odgałęzień)* |
| `[207]` | **""Let's remove the change from the proposal." [CHANGE THE REFORM]"** | `[206]` **Albin Clavin**: ""Oh yeah? What do you have in mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Albin Clavin**: ""You mean it?"" |
| `[208]` | **""Maybe I can help you some other way...""** | `[206]` **Albin Clavin**: ""Oh yeah? What do you have in mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[224]` | **""That wasn't a priority.""** | `[205]` **Albin Clavin**: ""Reformists were expecting a ref..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Albin Clavin**: ""What is a priority for you, Mr...." |
| `[225]` | **""This is only my first term. It's too soon to bring term limits.""** | `[205]` **Albin Clavin**: ""Reformists were expecting a ref..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Albin Clavin**: ""So, you also want to use the fl..." |
| `[226]` | **""We can address that today.""** | `[205]` **Albin Clavin**: ""Reformists were expecting a ref..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Albin Clavin**: ""That's good to know."" |
| `[232]` | **""Fine. Let's discuss this.""** | `[231]` **Narrator**: "He stared directly into my eyes." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Albin Clavin**: ""We prefer some kind of reform. ..." |
| `[233]` | **""There isn't going to be reforms about the decrees.""** | `[231]` **Narrator**: "He stared directly into my eyes." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Albin_AskedForThreshold"] = true;` | `[282]` **Albin Clavin**: ""I told you. This is a power gra..."<br>`[283]` **Albin Clavin**: ""You should at least do somethin..." |
| `[234]` | **""Look. We need the decrees to pass further reforms. I can't give away everything.""** | `[231]` **Narrator**: "He stared directly into my eyes." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Albin_AskedForThreshold"] = true;` | `[282]` **Albin Clavin**: ""I told you. This is a power gra..."<br>`[283]` **Albin Clavin**: ""You should at least do somethin..." |
| `[244]` | **"Change the proposal accordingly. [CHANGE THE REFORM]"** | `[148]` **Narrator**: "I skimmed through the law he poi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] ...` | `[325]` **Albin Clavin**: ""Looking good!"" |
| `[245]` | **""On a second thought, I won't change this.""** | `[148]` **Narrator**: "I skimmed through the law he poi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Albin Clavin**: ""Oh yeah?"" |
| `[246]` | **""Limiting the legislative powers of the Supreme Court.""** | `[229]` **Albin Clavin**: ""What is a priority for you, Mr...."<br>`[268]` **Albin Clavin**: ""Could you tell me... What is yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Albin Clavin**: ""You are giving yourself absolut..."<br>`[261]` **Albin Clavin**: ""And you're doing more than that..."<br>*(oraz 2 innych odgałęzień)* |
| `[247]` | **""Balance and division of powers.""** | `[229]` **Albin Clavin**: ""What is a priority for you, Mr...."<br>`[268]` **Albin Clavin**: ""Could you tell me... What is yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Albin Clavin**: ""You are giving yourself absolut..."<br>`[261]` **Albin Clavin**: ""And you're doing more than that..."<br>*(oraz 2 innych odgałęzień)* |
| `[248]` | **""Bringing down the Constitution of Soll.""** | `[229]` **Albin Clavin**: ""What is a priority for you, Mr...."<br>`[268]` **Albin Clavin**: ""Could you tell me... What is yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Albin Clavin**: ""By giving yourself the same rig..."<br>`[262]` **Albin Clavin**: ""Fair enough."" |
| `[249]` | **""You should have read our manifesto.""** | `[229]` **Albin Clavin**: ""What is a priority for you, Mr...."<br>`[268]` **Albin Clavin**: ""Could you tell me... What is yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Narrator**: "He let out a fake laughter." |
| `[279]` | **""We'll bring term limits of 2.""** | `[278]` **Albin Clavin**: ""Let's see then... What are you ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`<br>`Variable["BaseGame.Reform_Law_TermLimits_2"] = true;` | `[307]` **Albin Clavin**: ""A pleasant surprise. Let's move..." |
| `[281]` | **""On a second thought, I'd rather not include any changes to term limits.""** | `[278]` **Albin Clavin**: ""Let's see then... What are you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Albin Clavin**: ""How about the other problem?""<br>`[308]` **Albin Clavin**: ""Fine..."" |
| `[288]` | **""It makes sense. I will include your suggestion and limit the decrees." [CHANGE TH..."** | `[287]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Albin Clavin**: ""Lovely."" |
| `[289]` | **""I don't trust the Assembly to give me the power to enact major reforms though.""** | `[287]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." |
| `[290]` | **""I can't let the Assembly control me.""** | `[287]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." |
| `[293]` | **""I'm sure there's some *other way* to convince you.""** | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[294]` | **""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"** | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[295]` | **""I don't think I want that.""** | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Albin Clavin**: ""I see."" |
| `[310]` | **""Fine. I will add your suggestion." [CHANGE THE REFORM]"** | `[311]` **Albin Clavin**: ""The ministers should be nominat..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] ...` | `[338]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[312]` | **""That's a no.""** | `[283]` **Albin Clavin**: ""You should at least do somethin..."<br>`[284]` **Albin Clavin**: ""You should at least do somethin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Albin Clavin**: ""That's a shame."" |
| `[313]` | **""Fine. I will remove the decrease in the threshold." [CHANGE THE REFORM]"** | `[284]` **Albin Clavin**: ""You should at least do somethin..." | `Variable["BaseGame.Reform_Law_Threshold_3"] == true` | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[338]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[314]` | **""Fine. I will bring a limit of 2 terms." [CHANGE THE REFORM]"** | `[283]` **Albin Clavin**: ""You should at least do somethin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;` | `[338]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[315]` | **""Fine. I will remove the changes to the immunity of the President." [CHANGE THE RE..."** | `[282]` **Albin Clavin**: ""I told you. This is a power gra..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]...` | `[338]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[316]` | **""Okay. I'll reform the decrees then.""** | `[282]` **Albin Clavin**: ""I told you. This is a power gra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Albin Clavin**: ""I suggest limiting the power of..." |
| `[327]` | **""Maybe I can offer you something else...""** | `[184]` **Albin Clavin**: ""You are giving yourself absolut..."<br>`[196]` **Albin Clavin**: ""As long as this law and the thr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[328]` | **""Fine. I will remove the changes to the immunity of the Justices." [CHANGE THE REF..."** | `[600]` **Albin Clavin**: ""Who do you think we are to supp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_De...` | `[333]` **Albin Clavin**: ""Finally, we're getting somewhere."" |
| `[329]` | **""Okay. I'll reform the decrees then.""** | `[184]` **Albin Clavin**: ""You are giving yourself absolut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Albin Clavin**: ""I suggest limiting the power of..." |
| `[330]` | **""Fine. I will remove the changes to the immunity of the President." [CHANGE THE RE..."** | `[184]` **Albin Clavin**: ""You are giving yourself absolut..."<br>`[600]` **Albin Clavin**: ""Who do you think we are to supp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]...` | `[333]` **Albin Clavin**: ""Finally, we're getting somewhere."" |
| `[331]` | **""Fine. I will remove the threshold change." [CHANGE THE REFORM]"** | `[196]` **Albin Clavin**: ""As long as this law and the thr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[333]` **Albin Clavin**: ""Finally, we're getting somewhere."" |
| `[332]` | **""That's a no.""** | `[184]` **Albin Clavin**: ""You are giving yourself absolut..."<br>`[196]` **Albin Clavin**: ""As long as this law and the thr..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Albin Clavin**: ""As much as I want to give you m..." |
| `[350]` | **""Let's look at the draft again. I will give concessions.""** | `[349]` **Albin Clavin**: ""... perhaps there is something ..."<br>`[360]` **Albin Clavin**: ""This is not enough, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Albin Clavin**: ""You already know our concerns."" |
| `[351]` | **""Sure. I'll offer you *something else*.""** | `[349]` **Albin Clavin**: ""... perhaps there is something ..."<br>`[360]` **Albin Clavin**: ""This is not enough, Mr. Preside..." | `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false` | `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] =...` | `[428]` **Albin Clavin**: ""I'm all ears."" |
| `[352]` | **""Pff. This meeting is over.""** | `[349]` **Albin Clavin**: ""... perhaps there is something ..."<br>`[360]` **Albin Clavin**: ""This is not enough, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Albin Clavin**: ""However you see fit, Mr. Presid..." |
| `[363]` | **""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"** | `[362]` **Narrator**: "We both buried our heads inside ..." | `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false` | `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] ...` | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[364]` | **""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"** | `[362]` **Narrator**: "We both buried our heads inside ..." | `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]...` | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[377]` | **""I will limit presidential decrees with the requirement for an enabling act." [CHA..."** | `[362]` **Narrator**: "We both buried our heads inside ..." | `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false` | `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;` | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[384]` | **""Let's just move on.""** | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?""<br>`[362]` **Narrator**: "We both buried our heads inside ..." | `Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true` | *Brak zmian stanu* | `[382]` **Albin Clavin**: ""I guess it's acceptable now.""<br>`[383]` **Albin Clavin**: ""But unfortunately, Mr. Presiden..." |
| `[385]` | **""I will also add term limits. 2 should be enough." [CHANGE THE REFORM]"** | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?""<br>`[362]` **Narrator**: "We both buried our heads inside ..." | `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false`<br>`((Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false` | `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;` | `[393]` **Albin Clavin**: ""Great!"" |
| `[392]` | **""I will also remove the changes to the Justices' immunity." [CHANGE THE REFORM]"** | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?""<br>`[362]` **Narrator**: "We both buried our heads inside ..." | `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`<br>`((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false) == false` | `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_De...` | `[393]` **Albin Clavin**: ""Great!"" |
| `[394]` | **""Fine. I will remove the changes to the threshold." [CHANGE THE REFORM]"** | `[356]` **Albin Clavin**: ""Remove the change to the thresh..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[395]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[396]` | **""No. I can't do it.""** | `[356]` **Albin Clavin**: ""Remove the change to the thresh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Albin Clavin**: ""This is not enough, Mr. Preside..." |
| `[402]` | **""I'll consider you, if you prove yourself useful in the vote.""** | `[401]` **Albin Clavin**: ""Who knows? Maybe you'll conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Albin Clavin**: ""Oh, you know I will, Mr. Presid..." |
| `[403]` | **""I'll be expecting your votes, Mr. Clavin.""** | `[401]` **Albin Clavin**: ""Who knows? Maybe you'll conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Albin Clavin**: ""Of course."" |
| `[409]` | **""Don't botch it.""** | `[407]` **Albin Clavin**: ""I'll have their signatures soon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Albin Clavin**: ""I won't."" |
| `[411]` | **""You bet I will, Mr. Clavin.""** | `[401]` **Albin Clavin**: ""Who knows? Maybe you'll conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Albin Clavin**: ""Good to know, Mr. President."" |
| `[412]` | **""Thank you, Mr. Clavin.""** | `[407]` **Albin Clavin**: ""I'll have their signatures soon."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Albin Clavin**: ""See you in the conference, Mr. ..." |
| `[418]` | **""I understand. I won't bother you any longer.""** | `[417]` **Albin Clavin**: ""Anyway, I need to get back to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Albin Clavin**: ""That's not what I meant, sir."" |
| `[419]` | **""I'll be expecting the reformists' support, Mr. Clavin.""** | `[417]` **Albin Clavin**: ""Anyway, I need to get back to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Albin Clavin**: ""We'll see, Mr. President."" |
| `[420]` | **""Goodbye, Mr. Clavin.""** | `[417]` **Albin Clavin**: ""Anyway, I need to get back to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Albin Clavin**: ""Goodbye, Mr. President."" |
| `[422]` | **""It's okay, Mr. Clavin. I took no offense.""** | `[421]` **Albin Clavin**: ""That's not what I meant, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Narrator**: "I left his room and went back in..." |
| `[424]` | **"Leave the room."** | `[421]` **Albin Clavin**: ""That's not what I meant, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedTo...` | `[30]` **Narrator**: "The meeting had exhausted me." |
| `[429]` | **""If you give us your support, you'll be my VP in my next cabinet. [Collusion]""** | `[428]` **Albin Clavin**: ""I'm all ears."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Albin Clavin**: ""An interesting proposal."" |
| `[430]` | **""How about this? [Show him a cheque]""** | `[428]` **Albin Clavin**: ""I'm all ears.""<br>`[474]` **Albin Clavin**: ""Well... If you promise me the p..." | `Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[434]` **Narrator**: "I took out a cheque and showed i..." |
| `[435]` | **""A lot. [-1 Personal Wealth]""** | `[437]` **Albin Clavin**: ""...How much are we talking abou..." | `Variable["BaseGame.PersonalWealth"] > 0` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Relations_Albin_Bribed"] = true;` | `[498]` **Narrator**: "He took the cheque and slid it i..." |
| `[438]` | **""Life-changing amount." [-2 Personal Wealth]""** | `[437]` **Albin Clavin**: ""...How much are we talking abou..." | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Relations_Albin_Bribed"] = true;` | `[498]` **Narrator**: "He took the cheque and slid it i..." |
| `[439]` | **""Name your price.""** | `[437]` **Albin Clavin**: ""...How much are we talking abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Albin Clavin**: ""I didn't know you were such a *..." |
| `[461]` | **""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"** | `[470]` **Player**: ""Fine. Whatever it takes to get ..." | `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false` | `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] ...` | `[471]` **Albin Clavin**: ""Great. I knew that we could agr..." |
| `[462]` | **""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"** | `[470]` **Player**: ""Fine. Whatever it takes to get ..." | `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]...` | `[471]` **Albin Clavin**: ""Great. I knew that we could agr..." |
| `[469]` | **""I will limit presidential decrees with the requirement for an enabling act." [CHA..."** | `[470]` **Player**: ""Fine. Whatever it takes to get ..." | `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false` | `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;` | `[471]` **Albin Clavin**: ""Great. I knew that we could agr..." |
| `[470]` | **""Fine. Whatever it takes to get this proposal through the Assembly.""** | `[457]` **Narrator**: "He showed the listed problems wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[601]` **Player**: ""I will remove the changes to th..."<br>`[462]` **Player**: ""I will remove the changes to th..."<br>*(oraz 2 innych odgałęzień)* |
| `[472]` | **""How about a position in my cabinet?""** | `[428]` **Albin Clavin**: ""I'm all ears."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[473]` **Albin Clavin**: ""I think we can achieve a lot, i..." |
| `[475]` | **""I'm afraid I can't do that.""** | `[457]` **Narrator**: "He showed the listed problems wh..."<br>`[474]` **Albin Clavin**: ""Well... If you promise me the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[476]` **Albin Clavin**: ""That's a shame."" |
| `[483]` | **""Here you go. [Give him two cheques for -2 Personal Wealth]""** | `[482]` **Albin Clavin**: ""How about two of those cheques ..." | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Relations_Albin_Bribed"] = true;` | `[498]` **Narrator**: "He took the cheque and slid it i..." |
| `[487]` | **""How about only one for now?""** | `[482]` **Albin Clavin**: ""How about two of those cheques ..." | `(Variable["BaseGame.PersonalWealth"] > 1) == false` | *Brak zmian stanu* | `[489]` **Albin Clavin**: ""I thought you were a wealthy ma..." |
| `[488]` | **""That's too much.""** | `[482]` **Albin Clavin**: ""How about two of those cheques ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Albin Clavin**: ""I thought you were a wealthy ma..." |
| `[490]` | **""Here's one. This will be enough. [-1 Personal Wealth]""** | `[489]` **Albin Clavin**: ""I thought you were a wealthy ma..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Relations_Albin_Bribed"] = true;` | `[498]` **Narrator**: "He took the cheque and slid it i..." |
| `[491]` | **""I think there won't be any deal today.""** | `[489]` **Albin Clavin**: ""I thought you were a wealthy ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Albin Clavin**: ""That's a shame."" |
| `[501]` | **""Of course. I am a man of my word.""** | `[454]` **Albin Clavin**: ""Can I hold you to that promise?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Albin_PromisedVP"] = true;` | `[504]` **Albin Clavin**: ""Good. Then it seems like we hav..." |
| `[502]` | **""I don't intend to run with Petr again. It'll be you, I promise.""** | `[454]` **Albin Clavin**: ""Can I hold you to that promise?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Albin_PromisedVP"] = true;` | `[504]` **Albin Clavin**: ""Good. Then it seems like we hav..." |
| `[503]` | **""As long as I get your support.""** | `[454]` **Albin Clavin**: ""Can I hold you to that promise?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Albin_PromisedVP"] = true;` | `[504]` **Albin Clavin**: ""Good. Then it seems like we hav..." |
| `[506]` | **""That's what I wanted to hear.""** | `[505]` **Albin Clavin**: ""I won't create any problems."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "He looked down at the proposal." |
| `[507]` | **""That's good to know.""** | `[505]` **Albin Clavin**: ""I won't create any problems."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "He looked down at the proposal." |
| `[508]` | **""Thank you, Mr. Clavin. Any help from you is much appreciated.""** | `[505]` **Albin Clavin**: ""I won't create any problems."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "He looked down at the proposal." |
| `[517]` | **""It wasn't a good time for a drastic changes which would also costs the government.""** | `[516]` **Albin Clavin**: ""Our team was disappointed by th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[526]` **Albin Clavin**: ""It never is. Not sure how this ..." |
| `[518]` | **""You and I see eye to eye on many subjects including this one.""** | `[515]` **Albin Clavin**: ""I wanted to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[525]` **Albin Clavin**: ""Music to my ears."" |
| `[519]` | **""The businesses would be burdened even further. In this climate it would damage th..."** | `[516]` **Albin Clavin**: ""Our team was disappointed by th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Albin Clavin**: ""I understand your perspective b..." |
| `[520]` | **""Either way, your efforts were appreciated by the Palace.""** | `[516]` **Albin Clavin**: ""Our team was disappointed by th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Albin Clavin**: ""Actions would have gone farther..." |
| `[521]` | **""It was the right thing to do because our workers were suffering for decades.""** | `[515]` **Albin Clavin**: ""I wanted to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Albin Clavin**: ""Indeed the people will credit y..." |
| `[522]` | **""The party effort had to be supported.""** | `[515]` **Albin Clavin**: ""I wanted to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Albin Clavin**: ""It wouldn't be possible without..." |
| `[537]` | **""The worker's revolution will begin with small steps.""** | `[515]` **Albin Clavin**: ""I wanted to express my gratitud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[538]` **Albin Clavin**: ""One would think that I'm talkin..." |
| `[540]` | **""It is a market economy with a free supply and demand system. The government shoul..."** | `[516]` **Albin Clavin**: ""Our team was disappointed by th..." | `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[541]` **Albin Clavin**: ""The situation is borderline exp..." |
| `[595]` | **""Fine. I will remove the increase in the threshold.""** | `[284]` **Albin Clavin**: ""You should at least do somethin..." | `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false` | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[338]` **Albin Clavin**: ""Now, we're getting somewhere."" |
| `[601]` | **"" I will remove the changes to the immunity of the Justices." [CHANGE THE REFORM]"** | `[470]` **Player**: ""Fine. Whatever it takes to get ..." | `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_De...` | `[471]` **Albin Clavin**: ""Great. I knew that we could agr..." |
| `[607]` | **""I will remove the decrease in the threshold." [CHANGE THE REFORM]"** | `[362]` **Narrator**: "We both buried our heads inside ..." | `Variable["BaseGame.Reform_Law_Threshold_3"] == true`<br>`(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[608]` | **""I will remove the increase in the threshold." [CHANGE THE REFORM]"** | `[362]` **Narrator**: "We both buried our heads inside ..." | `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`<br>`(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] =...` | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" |
| `[616]` | **""To truly reform the country the President needs decrees not subject to review.""** | `[615]` **Albin Clavin**: ""This particular change is speci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[640]` **Albin Clavin**: ""Why can't the President work cl..." |
| `[617]` | **""What is wrong with a USP President having strong decree powers?""** | `[615]` **Albin Clavin**: ""This particular change is speci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[638]` **Albin Clavin**: ""Well there were some subjects t..." |
| `[618]` | **""I respect the perspective of the reformist wing.""** | `[615]` **Albin Clavin**: ""This particular change is speci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[639]` **Albin Clavin**: ""Enough to make a slight change ..." |
| `[622]` | **""There must be another way.""** | `[621]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Albin Clavin**: ""I have to say that most of the ..." |
| `[623]` | **""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"** | `[621]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[627]` **Albin Clavin**: ""Lovely."" |
| `[625]` | **""I don't think I want that.""** | `[621]` **Albin Clavin**: ""I thought you wanted to discuss..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Albin Clavin**: ""I see."" |
| `[626]` | **""I can't let the Assembly control me.""** | `[636]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[621]` **Albin Clavin**: ""I thought you wanted to discuss..." |
| `[628]` | **""I don't trust the Assembly to give me the power to enact major reforms though.""** | `[636]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[621]` **Albin Clavin**: ""I thought you wanted to discuss..." |
| `[630]` | **""It makes sense. I will include your suggestion and limit the decrees." [CHANGE TH..."** | `[636]` **Albin Clavin**: ""And if you really care about fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[629]` **Albin Clavin**: ""Lovely."" |
| `[634]` | **""The fact that we are giving the Assembly the power to override a veto is change e..."** | `[291]` **Albin Clavin**: ""I thought you wanted to discuss..." | `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true` | *Brak zmian stanu* | `[635]` **Albin Clavin**: ""You didn't include any time lim..." |
| `[692]` | **""Very well. I accept. [Collusion]""** | `[474]` **Albin Clavin**: ""Well... If you promise me the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Albin Clavin**: ""Can I hold you to that promise?"" |
| `[696]` | **""I wouldn't mind if my next Vice President had a bit more... funds. [Show him a ch..."** | `[457]` **Narrator**: "He showed the listed problems wh..." | `Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[697]` **Narrator**: "I took out a cheque and showed i..." |
| `[708]` | **""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"** | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" | `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false` | `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] ...` | `[393]` **Albin Clavin**: ""Great!"" |
| `[709]` | **""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"** | `[378]` **Albin Clavin**: ""It wasn't so hard, was it?"" | `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]...` | `[393]` **Albin Clavin**: ""Great!"" |
| `[716]` | **""On a second thought, I'm fine with the current draft.""** | `[362]` **Narrator**: "We both buried our heads inside ..." | `(Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false` | *Brak zmian stanu* | `[382]` **Albin Clavin**: ""I guess it's acceptable now.""<br>`[383]` **Albin Clavin**: ""But unfortunately, Mr. Presiden..." |

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
  - -> `[4]` (*Narrator: "After our meeting with Gloria Tory, and further discussio..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""How is everything going, Mr. Clavin?""]** — Mówca: **Player**
> ""How is everything going, Mr. Clavin?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Albin Clavin: ""It's been busy. The party has been working very hard, Mr..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "After our meeting with Gloria Tory, and further discussions with the party and my cabinet, it was time to talk to Albin Clavin to get the reformist wing to support the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I also planned to finally present a more fleshed out prop..."*)

### Węzeł `[5]`
Mówca: **Albin Clavin**
> ""Mr. President! Welcome!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The whole room was surrounded by bookshelves packed with ..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I also planned to finally present a more fleshed out proposal and declare our agenda to the party after our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I walked into the left wing of the Assembly and entered t..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked into the left wing of the Assembly and entered the quarters of the USP. When I reached the meeting hall, I saw many of our members conversing inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "After taking a glimpse inside, I went back into the corri..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "After taking a glimpse inside, I went back into the corridor to look for the office of Albin Clavin, which was around the back of the place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "When I reached his room, I knocked on his door and entered."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "When I reached his room, I knocked on his door and entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Albin Clavin: ""Mr. President! Welcome!""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The whole room was surrounded by bookshelves packed with files and papers. It was a small office, with books and dossiers lying on every corner. It felt claustrophobic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "On his gesture, I took a seat."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "On his gesture, I took a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""How is everything going, Mr. Clavin?""*)
  - -> `[12]` (*Player: ""Did a bomb drop in this office?""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Did a bomb drop in this office?""]** — Mówca: **Player**
> ""Did a bomb drop in this office?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He laughed."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Albin Clavin: ""You could say that.""*)

### Węzeł `[14]`
Mówca: **Albin Clavin**
> ""It's been busy. The party has been working very hard, Mr. President. Thank you for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Albin Clavin: ""How is it going for you in the Palace?""*)

### Węzeł `[15]`
Mówca: **Albin Clavin**
> ""How is it going for you in the Palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""It's pretty tough.""*)
  - -> `[20]` (*Player: ""I'm feeling pretty good.""*)
  - -> `[21]` (*Player: ""It depends on our meeting today.""*)

### Węzeł `[16]`
Mówca: **Albin Clavin**
> ""You could say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Albin Clavin: ""So much research and preparation needs to be done on the..."*)

### Węzeł `[17]`
Mówca: **Albin Clavin**
> ""So much research and preparation needs to be done on the plans we're working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Albin Clavin: ""How is everything going for you, Mr. President?""*)

### Węzeł `[18]`
Mówca: **Albin Clavin**
> ""How is everything going for you, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""It's pretty tough.""*)
  - -> `[20]` (*Player: ""I'm feeling pretty good.""*)
  - -> `[21]` (*Player: ""It depends on our meeting today.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""It's pretty tough.""]** — Mówca: **Player**
> ""It's pretty tough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Albin Clavin), `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Albin Clavin: ""I can't imagine the work you're dealing with up there.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm feeling pretty good.""]** — Mówca: **Player**
> ""I'm feeling pretty good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Albin Clavin), `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Albin Clavin: ""That's great to hear.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""It depends on our meeting today.""]** — Mówca: **Player**
> ""It depends on our meeting today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Albin Clavin), `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Albin Clavin: ""Oh, I see. Then I'll try my best not to make it any wors..."*)

### Węzeł `[22]`
Mówca: **Albin Clavin**
> ""Oh, I see. Then I'll try my best not to make it any worse for you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[23]`
Mówca: **Albin Clavin**
> ""I can't imagine the work you're dealing with up there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[24]`
Mówca: **Albin Clavin**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[25]`
Mówca: **Albin Clavin**
> ""Anyway, sir, let's talk about the proposal. Thanks for coming here for my input because there are some subjects where Gloria and I don't see eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)

### Węzeł `[26]`
Mówca: **Albin Clavin**
> ""I have to say that most of the progressives were already starting to warm up to you. Your attempt at changing the constitution created quite a bit of excitement. One could dare to say an excitement that hasn't been felt since the 30's...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == false && BaseGam..."*)

### Węzeł `[27]`
Mówca: **Albin Clavin**
> ""Yet, there are some issues with the current status of the draft proposal. So we may need to contain our excitement a little longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[28]`
Mówca: **Albin Clavin**
> ""I've read the proposal that was finalised together with Mrs. Tory. And surprisingly, it came out pretty good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Albin Clavin: ""Look, Mr. President. I'm on the same side as you.""*)

### Węzeł `[29]`
Mówca: **Albin Clavin**
> ""I have to say that the proposal is unacceptable in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Albin Clavin: ""This is in no way what we intended nor asked for.""*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The meeting had exhausted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "I went to the restaurant of the Assembly to get something..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "I went to the restaurant of the Assembly to get something to eat while conversing with other members of our party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I saw Albin talking to his people in the distance."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I saw Albin talking to his people in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After a while, the preparations for the conference began ..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "After a while, the preparations for the conference began and I went back into the conference hall and prepared my notes for the speech I was going to make."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "It took time to get all of the present members of the par..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "It took time to get all of the present members of the party inside the hall. Gloria Tory announced me from the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I walked up to the stand as everybody in the room started..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I walked up to the stand as everybody in the room started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Ladies and gentlemen of the Party!""*)
  - -> `[36]` (*Player: ""Dear members of Assembly...""*)
  - -> `[38]` (*Player: ""Brothers and sisters of United Sordland!""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Dear members of Assembly...""]** — Mówca: **Player**
> ""Dear members of Assembly, I came here today to announce the agenda for the future of our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I started my speech with the reasons of the changes to th..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Party!""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Party! I came here today to announce the agenda for the future of our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I started my speech with the reasons of the changes to th..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Brothers and sisters of United Sordland!""]** — Mówca: **Player**
> ""Brothers and sisters of United Sordland! I came here today to announce the agenda for the future of our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I started my speech with the reasons of the changes to th..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "I started my speech with the reasons of the changes to the Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""The people of Sordland have spoken...""*)
  - -> `[41]` (*Player: ""Our system and institutions have increasingly became und..."*)
  - -> `[42]` (*Player: ""The Supreme Court is blocking the future of Sordland...""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""The people of Sordland have spoken...""]** — Mówca: **Player**
> ""The people of Sordland have spoken! They blame our institutions and our systems, and want change! Can you blame the people? Haven't we had enough with the flaws of our Constitution? We must listen their wishes, and get their trust in Sordland back!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I paused as they started clapping and continued."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Our system and institutions have increasingly became undemocratic...""]** — Mówca: **Player**
> ""Our system and institutions have increasingly became undemocratic over the decades after Soll tightened his grip on the country. Since then, we have a Supreme Court that obstructs the duties of the President and the Assembly. We must finally be brave enough to go against the status quo that they created and write a new Constitution!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "I paused when some people started clapping but it was sho..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""The Supreme Court is blocking the future of Sordland...""]** — Mówca: **Player**
> ""The Supreme Court is blocking the future of Sordland yet again, since President Soll has placed these Judges there. They believe that they are the sole protectors of the Constitution and real leaders of Sordland even though they weren't even elected. We must be brave enough to break their power over us and bring the change Sordland has been so eagerly waiting for!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "I paused when some people started clapping but it was sho..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "I paused as they started clapping and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Italic: "Talk about democracy."*)
  - -> `[46]` (*Player_Italic: "Talk about why USP needs this to survive the next elections."*)
  - -> `[47]` (*Player_Italic: "Target the Old Guards and the Supreme Court."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "I paused when some people started clapping but it was short lived. After taking a breath, I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Italic: "Talk about democracy."*)
  - -> `[46]` (*Player_Italic: "Talk about why USP needs this to survive the next elections."*)
  - -> `[47]` (*Player_Italic: "Target the Old Guards and the Supreme Court."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Talk about democracy."]** — Mówca: **Player_Italic**
> "I brought attention to democracy and why we must write a more democratic Constitution. I explained how our proposal will fix the issues."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Talk about why USP needs this to survive the next elections."]** — Mówca: **Player_Italic**
> "I brought attention to the people's protests and the slight decrease in the popularity of USP. I explained how our proposal will only be beneficial for everybody."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Target the Old Guards and the Supreme Court."]** — Mówca: **Player_Italic**
> "I blamed the Old Guards for not allowing the legislative to do their work. I explained how more reforms can be done if their power over constitutional changes were to be limited."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Narrator), `[44]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "The reformist wing on the left stood up and started clapp..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "A round of applause from the left was heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Later I explained the contents of the new Constitution an..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The left side of the hall where Albin sat started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Later I explained the contents of the new Constitution an..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The moderates that sat in the centre started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Later I explained the contents of the new Constitution an..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Later I explained the contents of the new Constitution and asked for their full support for the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Italic: "Ask for their votes."*)
  - -> `[57]` (*Player_Italic: "Order them to vote yes."*)
  - -> `[55]` (*Player_Italic: "Threaten them to vote yes."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "Threaten them to vote yes."]** — Mówca: **Player_Italic**
> "I announced that any opposition to the proposal will not be tolerated and will be declared as traitors to the party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Ask for their votes."]** — Mówca: **Player_Italic**
> "I asked for each and every member's vote to make a change together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Order them to vote yes."]** — Mówca: **Player_Italic**
> "I told them what they must do and what was expected of them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "The reformist wing on the left stood up and started clapping loudly after Albin Clavin made a sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The conservatives on the right side of the hall where Glo..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "There wasn't much reaction from the party."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Soon after, most of the party members stood up and joined..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I saluted everybody in the room one last time and bid the..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Soon after, most of the party members stood up and joined in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I saluted everybody in the room one last time and bid the..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The conservatives on the right side of the hall where Gloria sat stood up and started clapping loudly after I saw Gloria making a gesture with her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I saluted everybody in the room one last time and bid the..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "There wasn't much reaction from the party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I saluted everybody in the room one last time and bid the..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "I saluted everybody in the room one last time and bid them farewell before leaving the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "I walked outside the Assembly and back into the Palace..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "I walked outside the Assembly and back into the Palace..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_USPMeeting = true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == false && BaseGam..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == false && BaseG..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Albin Clavin: ""I've read the proposal that was finalised together with ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Albin Clavin: ""I've already read the proposal you've made. It looks pre..."*)

### Węzeł `[76]`
Mówca: **Albin Clavin**
> ""I've already read the proposal you've made. It looks pretty good. No surprise that Mrs. Tory didn't give her support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Albin Clavin: ""Look, Mr. President. I'm on the same side as you.""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Albin Clavin: ""First, I'll say that I'm concerned about the drastic dec..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_Default == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Albin Clavin: ""Reformists were expecting a reform about the term limits..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true || BaseGame.R..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Albin Clavin: ""First of all, we are concerned about where this proposal..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Albin Clavin: ""We have specifically asked for a change in appointment o..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Re..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Albin Clavin: ""...which unfortunately has been crushed with the current..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Albin Clavin: ""Yet, there are some issues with the current status of th..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true || BaseGame.R..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true || BaseGame..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Albin Clavin: ""I thought there would be some reform about the extensive..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[95]`
Mówca: **Albin Clavin**
> ""I suspect that Mrs. Tory had a lot of influence on this proposal. I have to say that the proposal is unacceptable in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Albin Clavin: ""This is in no way what we intended nor asked for.""*)

### Węzeł `[96]`
Mówca: **Albin Clavin**
> ""...which unfortunately has been crushed with the current draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Albin Clavin: ""I suspect that Mrs. Tory had a lot of influence on this ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Albin Clavin: ""I have to say that the proposal is unacceptable in its c..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Albin Clavin: ""I suspect that Mrs. Tory had a lot of influence on this ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Albin Clavin: ""I cannot support this in its current state.""*)

### Węzeł `[103]`
Mówca: **Albin Clavin**
> ""This is in no way what we intended nor asked for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""I need your support, Mr. Clavin.""*)
  - -> `[109]` (*Player: ""What's the problem?""*)
  - -> `[108]` (*Player: ""I thought you were a democrat.""*)
  - -> `[106]` (*Player: ""The party should respect my decisions.""*)

### Węzeł `[104]`
Mówca: **Albin Clavin**
> ""I cannot support this in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""I need your support, Mr. Clavin.""*)
  - -> `[109]` (*Player: ""What's the problem?""*)
  - -> `[108]` (*Player: ""I thought you were a democrat.""*)
  - -> `[106]` (*Player: ""The party should respect my decisions.""*)

### Węzeł `[105]`
Mówca: **Albin Clavin**
> ""I suspect that Mrs. Tory had a lot of influence on this proposal. But I cannot support this in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""I need your support, Mr. Clavin.""*)
  - -> `[109]` (*Player: ""What's the problem?""*)
  - -> `[108]` (*Player: ""I thought you were a democrat.""*)
  - -> `[106]` (*Player: ""The party should respect my decisions.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""The party should respect my decisions.""]** — Mówca: **Player**
> ""The party should respect my decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin), `[104]` (Albin Clavin), `[105]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Albin Clavin: ""That would have been very nice for you, wouldn't it, Mr...."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I need your support, Mr. Clavin.""]** — Mówca: **Player**
> ""I need your support, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin), `[104]` (Albin Clavin), `[105]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Albin Clavin: ""A fact that I'm aware of.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I thought you were a democrat.""]** — Mówca: **Player**
> ""I thought you were a democrat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin), `[104]` (Albin Clavin), `[105]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Albin Clavin: ""I am.""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""What's the problem?""]** — Mówca: **Player**
> ""What's the problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin), `[104]` (Albin Clavin), `[105]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Re..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Albin Clavin: ""Where to even begin?""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[113]`
Mówca: **Albin Clavin**
> ""That would have been very nice for you, wouldn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[114]`
Mówca: **Albin Clavin**
> ""With all due respect, maybe you shouldn't forget that it is the party that made you president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Let's hear your problems.""*)
  - -> `[122]` (*Player: ""How about some other deal?""*)
  - -> `[123]` (*Player: ""I can't let you sabotage this.""*)
  - -> `[124]` (*Player: ""Don't forget who you are speaking to.""*)

### Węzeł `[115]`
Mówca: **Albin Clavin**
> ""A fact that I'm aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Albin Clavin: ""But at this point, even my support would not be enough.""*)

### Węzeł `[116]`
Mówca: **Albin Clavin**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[117]`
Mówca: **Albin Clavin**
> ""But us democrats have already established our demands, which were apparently ignored by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Albin Clavin: ""You cannot claim that you're the democrat here.""*)

### Węzeł `[118]`
Mówca: **Albin Clavin**
> ""You cannot claim that you're the democrat here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Let's hear your problems.""*)
  - -> `[122]` (*Player: ""How about some other deal?""*)
  - -> `[123]` (*Player: ""I can't let you sabotage this.""*)
  - -> `[124]` (*Player: ""Don't forget who you are speaking to.""*)

### Węzeł `[119]`
Mówca: **Albin Clavin**
> ""But at this point, even my support would not be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""What do you mean?""*)
  - -> `[126]` (*Player: ""Tell me the issues. How can I get your support?""*)
  - -> `[122]` (*Player: ""How about some other deal?""*)

### Węzeł `[120]`
Mówca: **Albin Clavin**
> ""Where to even begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Let's hear your problems.""]** — Mówca: **Player**
> ""Let's hear your problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Albin Clavin), `[118]` (Albin Clavin), `[128]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""How about some other deal?""]** — Mówca: **Player**
> ""How about some other deal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Albin Clavin), `[118]` (Albin Clavin), `[119]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I can't let you sabotage this.""]** — Mówca: **Player**
> ""I can't let you sabotage this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Albin Clavin), `[118]` (Albin Clavin), `[649]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Albin Clavin: ""You are sabotaging yourself if you're not willing to lis..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Don't forget who you are speaking to.""]** — Mówca: **Player**
> ""Don't forget who you are speaking to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Albin Clavin), `[118]` (Albin Clavin), `[128]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He raised an eyebrow and then frowned at me."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""What do you mean?""]** — Mówca: **Player**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Albin Clavin: ""This proposal will have hard time getting support in its..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Tell me the issues. How can I get your support?""]** — Mówca: **Player**
> ""Tell me the issues. How can I get your support?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)

### Węzeł `[127]`
Mówca: **Albin Clavin**
> ""This proposal will have hard time getting support in its current status. You surely know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[128]`
Mówca: **Albin Clavin**
> ""You are sabotaging yourself if you're not willing to listen the reformists in your own party...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Let's hear your problems.""*)
  - -> `[122]` (*Player: ""How about some other deal?""*)
  - -> `[124]` (*Player: ""Don't forget who you are speaking to.""*)

### Węzeł `[129]`
Mówca: **Albin Clavin**
> ""First, I'll say that I'm concerned about the drastic decrease in the threshold. The reformist wing of the party will do its best to boycott it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[130]`
Mówca: **Albin Clavin**
> ""That will have negative consequences for our party since dozens of parties could potentially enter the parliament. The electoral finance reform reduces their ability to campaign but nonetheless the situation won't be in our favour at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He paused and twiddled his thumbs."*)

### Węzeł `[131]`
Mówca: **Albin Clavin**
> ""We have specifically asked for a change in appointment of ministers. This is what the party was expecting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Albin Clavin: ""Yet I see that our suggestions were completely ignored.""*)

### Węzeł `[132]`
Mówca: **Narrator**
> "He paused and twiddled his thumbs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[133]`
Mówca: **Albin Clavin**
> ""Yet I see that our suggestions were completely ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""That's not a priority for us.""*)
  - -> `[136]` (*Player: ""They were not ignored, Mr. Clavin.""*)
  - -> `[137]` (*Player: ""We can address that now.""*)
  - -> `[141]` (*Player: ""Gloria and the conservatives didn't seem to have any pro..."*)

### Węzeł `[134]`
Mówca: **Albin Clavin**
> ""Excuse me, Mr. President, but how are they not ignored?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Albin Clavin: ""I don't know what I can do for you even if I gave you my..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""That's not a priority for us.""]** — Mówca: **Player**
> ""That's not a priority for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Albin Clavin: ""Who's us? Isn't the party included in that now?""*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""They were not ignored, Mr. Clavin.""]** — Mówca: **Player**
> ""They were not ignored, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Albin Clavin: ""Excuse me, Mr. President, but how are they not ignored?""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""We can address that now.""]** — Mówca: **Player**
> ""We can address that now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Albin Clavin: ""Oh?""*)

### Węzeł `[138]`
Mówca: **Albin Clavin**
> ""I don't know what I can do for you even if I gave you my support. The party will not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""Leave the rest of the party to me. I am now asking for *..."*)
  - -> `[150]` (*Player: ""We can add the requested change to the proposal.""*)
  - -> `[151]` (*Player: ""Screw the party.""*)

### Węzeł `[139]`
Mówca: **Albin Clavin**
> ""Who's us? Isn't the party included in that now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Albin Clavin: ""I don't know what I can do for you even if I gave you my..."*)

### Węzeł `[140]`
Mówca: **Albin Clavin**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Albin Clavin: ""Let's see then...""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Gloria and the conservatives didn't seem to have any problems with it.""]** — Mówca: **Player**
> ""Gloria and the conservatives didn't seem to have any problems with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Albin Clavin: ""What is that supposed to mean? *We* have a problem with ..."*)

### Węzeł `[142]`
Mówca: **Albin Clavin**
> ""What is that supposed to mean? *We* have a problem with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Albin Clavin: ""I don't know what I can do for you even if I gave you my..."*)

### Węzeł `[143]`
Mówca: **Albin Clavin**
> ""Let's see then...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "He pulled out a stack of papers and placed them on his desk."*)

### Węzeł `[144]`
Mówca: **Albin Clavin**
> ""Here. I already have my suggestion here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "The papers contained suggested amendments to the Constitu..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "He pulled out a stack of papers and placed them on his desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Albin Clavin: ""Here. I already have my suggestion here.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "The papers contained suggested amendments to the Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I skimmed through the law he pointed out. "Council of Min..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "I skimmed through the law he pointed out. "Council of Ministers are formed upon the President's appointment of them from a list of nominees that the Grand National Assembly selects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player_Italic: "Change the proposal accordingly. [CHANGE THE REFORM]"*)
  - -> `[245]` (*Player: ""On a second thought, I won't change this.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Leave the rest of the party to me. I am now asking for *your* support.""]** — Mówca: **Player**
> ""Leave the rest of the party to me. I am now asking for *your* support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_TermLimits_Default == true ||BaseGam..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""We can add the requested change to the proposal.""]** — Mówca: **Player**
> ""We can add the requested change to the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Albin Clavin: ""Let's see then...""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Screw the party.""]** — Mówca: **Player**
> ""Screw the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Albin Clavin: ""Oh yeah?""*)

### Węzeł `[152]`
Mówca: **Albin Clavin**
> ""Oh yeah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[153]`
Mówca: **Albin Clavin**
> ""Your proposal will be crushed like this anyway. I'd rather have something tangible to support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[154]`
Mówca: **Albin Clavin**
> ""First of all, we are concerned about where this proposal is heading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: ""It aims to give you absolute immunity with no way of imp..."*)

### Węzeł `[155]`
Mówca: **Albin Clavin**
> ""It aims to give you absolute immunity with no way of impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Albin Clavin: ""But never mind that now. There are far worse problems. W..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[159]`
Mówca: **Albin Clavin**
> ""But never mind that now. There are far worse problems. We are not sure where this proposal is heading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: ""It aims to give you absolute immunity with no way of imp..."*)

### Węzeł `[160]`
Mówca: **Albin Clavin**
> ""I thought you were one of us. Against Sollism and the concentration of power. This is wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: ""I am against Sollism. This law is necessary to protect m..."*)
  - -> `[162]` (*Player: ""I'm sure we can work something out.""*)
  - -> `[163]` (*Player: ""Well, you were wrong, Mr. Clavin.""*)
  - -> `[164]` (*Player: ""I'm open to discuss changes but not to this law.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I am against Sollism. This law is necessary to protect me from the Court.""]** — Mówca: **Player**
> ""I am against Sollism. This law is necessary to protect me from the Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Albin Clavin: ""It will not only protect you but also your successors, M..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I'm sure we can work something out.""]** — Mówca: **Player**
> ""I'm sure we can work something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Albin Clavin: ""Oh yeah? What do you have in mind?""*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Well, you were wrong, Mr. Clavin.""]** — Mówca: **Player**
> ""Well, you were wrong, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Albin Clavin: ""I see that clearly now.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""I'm open to discuss changes but not to this law.""]** — Mówca: **Player**
> ""I'm open to discuss changes but not to this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[165]`
Mówca: **Albin Clavin**
> ""It will not only protect you but also your successors, Mr. President. This law has the potential to create another Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Albin Clavin: ""This isn't how you *curb* the power of the Old Guards......"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AlbinDeal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Albin Clavin: ""I'm all ears.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[168]`
Mówca: **Albin Clavin**
> ""Well, yeah. You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Albin Clavin: ""So you want to hear our concerns or you are only here to..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He raised an eyebrow and then frowned at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Albin Clavin: ""Well, yeah. You are right.""*)

### Węzeł `[170]`
Mówca: **Albin Clavin**
> ""So you want to hear our concerns or you are only here to push your agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Let's hear your problems.""*)
  - -> `[171]` (*Player: ""I'm sure we can work out *something else*.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I'm sure we can work out *something else*.""]** — Mówca: **Player**
> ""I'm sure we can work out *something else*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[173]`
Mówca: **Albin Clavin**
> ""This isn't how you *curb* the power of the Old Guards... This proposal instead gives more power to the executive. How is this any better than before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""It isn't about more powers, it is only protection.""*)
  - -> `[199]` (*Player: ""Okay, let's change this law." [CHANGE THE REFORM]"*)
  - -> `[200]` (*Player: ""I'm open to discuss changes but not to this law.""*)

### Węzeł `[174]`
Mówca: **Albin Clavin**
> ""I see that clearly now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Albin Clavin: ""Then I cannot help you.""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[178]`
Mówca: **Albin Clavin**
> ""Then I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[179]`
Mówca: **Albin Clavin**
> ""You are removing the Justices' immunity and giving it to yourself. This is borderline dictatorial since you can also replace them at your whim. Did you forget that we are democrats at heart, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Albin Clavin: ""Who do you think we are to support such changes, Mr. Pre..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Albin Clavin: ""Then I cannot help you.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)

### Węzeł `[183]`
Mówca: **Albin Clavin**
> ""Then I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Albin Clavin: ""You are giving yourself absolute immunity and still keep..."*)

### Węzeł `[184]`
Mówca: **Albin Clavin**
> ""You are giving yourself absolute immunity and still keeping your extensive decree powers. Who do you think we are to support such changes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""Fine. I will remove the changes to the immunity of the P..."*)
  - -> `[329]` (*Player: ""Okay. I'll reform the decrees then.""*)
  - -> `[327]` (*Player: ""Maybe I can offer you something else...""*)
  - -> `[332]` (*Player: ""That's a no.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && BaseGa..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Albin Clavin: ""That is not a good start. But let's look at the other is..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true ||BaseGame...."*)

### Węzeł `[188]`
Mówca: **Albin Clavin**
> ""That is not a good start. But let's look at the other issues first then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[189]`
Mówca: **Albin Clavin**
> ""That is not a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true ||BaseGame...."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true ||BaseGam..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Albin Clavin: ""That is not a good start. But let's look at the other is..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Albin Clavin: ""That is not a good start.""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Albin Clavin: ""As long as this law and the threshold remains, I don't t..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Albin Clavin: ""As much as I want to give you my support, you are forcin..."*)

### Węzeł `[196]`
Mówca: **Albin Clavin**
> ""As long as this law and the threshold remains, I don't think I can give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player: ""Maybe I can offer you something else...""*)
  - -> `[331]` (*Player: ""Fine. I will remove the threshold change." [CHANGE THE R..."*)
  - -> `[332]` (*Player: ""That's a no.""*)

### Węzeł `[197]`
Mówca: **Albin Clavin**
> ""As much as I want to give you my support, you are forcing our hand with this proposal...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""It isn't about more powers, it is only protection.""]** — Mówca: **Player**
> ""It isn't about more powers, it is only protection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Albin Clavin: ""I understand where you're coming from but us reformists ..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Okay, let's change this law." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Okay, let's change this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Albin Clavin), `[202]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Albin Clavin: ""You mean it?""*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I'm open to discuss changes but not to this law.""]** — Mówca: **Player**
> ""I'm open to discuss changes but not to this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Albin Clavin), `[202]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[201]`
Mówca: **Albin Clavin**
> ""I understand where you're coming from but us reformists cannot agree to this change. This is the very political culture that we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Albin Clavin: ""Let's say we trust you and you become the greatest leade..."*)

### Węzeł `[202]`
Mówca: **Albin Clavin**
> ""Let's say we trust you and you become the greatest leader ever lived. And then, what happens when you leave office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""Okay, let's change this law." [CHANGE THE REFORM]"*)
  - -> `[200]` (*Player: ""I'm open to discuss changes but not to this law.""*)

### Węzeł `[203]`
Mówca: **Albin Clavin**
> ""You mean it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Albin Clavin: ""That's a positive development.""*)

### Węzeł `[204]`
Mówca: **Albin Clavin**
> ""That's a positive development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[205]`
Mówca: **Albin Clavin**
> ""Reformists were expecting a reform about the term limits. Why is that not included in the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: ""That wasn't a priority.""*)
  - -> `[225]` (*Player: ""This is only my first term. It's too soon to bring term ..."*)
  - -> `[226]` (*Player: ""We can address that today.""*)

### Węzeł `[206]`
Mówca: **Albin Clavin**
> ""Oh yeah? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""Let's remove the change from the proposal." [CHANGE THE ..."*)
  - -> `[208]` (*Player: ""Maybe I can help you some other way...""*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Let's remove the change from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Let's remove the change from the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Albin Clavin: ""You mean it?""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Maybe I can help you some other way...""]** — Mówca: **Player**
> ""Maybe I can help you some other way...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true || Base..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Albin Clavin: ""It seems you have interesting dreams. But dreams, noneth..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[213]`
Mówca: **Albin Clavin**
> ""It seems you have interesting dreams. But dreams, nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Albin Clavin: ""I would have understood your stance if this was the only..."*)

### Węzeł `[214]`
Mówca: **Albin Clavin**
> ""I would have understood your stance if this was the only issue... There are more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_Default == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Albin Clavin: ""I think you're pushing your luck too much, Mr. President.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Albin Clavin: ""At least you decided to make some democratic changes to ..."*)

### Węzeł `[218]`
Mówca: **Albin Clavin**
> ""I think you're pushing your luck too much, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Albin Clavin: ""You know... This isn't the only issue. There's another o..."*)

### Węzeł `[219]`
Mówca: **Albin Clavin**
> ""You know... This isn't the only issue. There's another one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[220]`
Mówca: **Albin Clavin**
> ""At least you decided to make some democratic changes to the term limits, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true || BaseGame.R..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_TermLimits_Default == true ||BaseGam..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_TermLimits_Default == true ||BaseG..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or Variable["BaseGame.Reform_Law_Decrees_Default"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Albin Clavin: ""Your proposal will be crushed like this anyway. I'd rath..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or Variable["BaseGame.Reform_Law_Decrees_Default"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Albin Clavin: ""Oh yeah?""*)

### Węzeł `[224]`
**[WYBÓR GRACZA: ""That wasn't a priority.""]** — Mówca: **Player**
> ""That wasn't a priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Albin Clavin: ""What is a priority for you, Mr. President?""*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""This is only my first term. It's too soon to bring term limits.""]** — Mówca: **Player**
> ""This is only my first term. It's too soon to bring term limits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Albin Clavin: ""So, you also want to use the flaws of the system for you..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""We can address that today.""]** — Mówca: **Player**
> ""We can address that today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Albin Clavin: ""That's good to know.""*)

### Węzeł `[227]`
Mówca: **Albin Clavin**
> ""So, you also want to use the flaws of the system for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Albin Clavin: ""Could you tell me... What is your priority with this pro..."*)

### Węzeł `[228]`
Mówca: **Albin Clavin**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[229]`
Mówca: **Albin Clavin**
> ""What is a priority for you, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""Limiting the legislative powers of the Supreme Court.""*)
  - -> `[247]` (*Player: ""Balance and division of powers.""*)
  - -> `[248]` (*Player: ""Bringing down the Constitution of Soll.""*)
  - -> `[249]` (*Player: ""You should have read our manifesto.""*)

### Węzeł `[230]`
Mówca: **Albin Clavin**
> ""I thought there would be some reform about the extensive decree powers...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He stared directly into my eyes."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He stared directly into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: ""There isn't going to be reforms about the decrees.""*)
  - -> `[234]` (*Player: ""Look. We need the decrees to pass further reforms. I can..."*)
  - -> `[232]` (*Player: ""Fine. Let's discuss this.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Fine. Let's discuss this.""]** — Mówca: **Player**
> ""Fine. Let's discuss this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Albin Clavin: ""We prefer some kind of reform. The president currently h..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: ""There isn't going to be reforms about the decrees.""]** — Mówca: **Player**
> ""There isn't going to be reforms about the decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Look. We need the decrees to pass further reforms. I can't give away everything.""]** — Mówca: **Player**
> ""Look. We need the decrees to pass further reforms. I can't give away everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Albin Clavin: ""I told you. This is a power grab. I can't support this.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_Default == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Albin Clavin: ""You should at least do something about term limits.""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Albin_AskedForThreshold = true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[244]`
**[WYBÓR GRACZA: "Change the proposal accordingly. [CHANGE THE REFORM]"]** — Mówca: **Player_Italic**
> "Change the proposal accordingly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly = true"*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""On a second thought, I won't change this.""]** — Mówca: **Player**
> ""On a second thought, I won't change this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Albin Clavin: ""Oh yeah?""*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Limiting the legislative powers of the Supreme Court.""]** — Mówca: **Player**
> ""Limiting the legislative powers of the Supreme Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Albin Clavin), `[268]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Balance and division of powers.""]** — Mówca: **Player**
> ""Balance and division of powers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Albin Clavin), `[268]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Bringing down the Constitution of Soll.""]** — Mówca: **Player**
> ""Bringing down the Constitution of Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Albin Clavin), `[268]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""You should have read our manifesto.""]** — Mówca: **Player**
> ""You should have read our manifesto.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Albin Clavin), `[268]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He let out a fake laughter."*)

### Węzeł `[250]`
Mówca: **Albin Clavin**
> ""You are giving yourself absolute immunity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Albin Clavin: ""You are giving yourself absolute immunity...""*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true )"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Albin Clavin: ""...and keeping your extensive powers.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[257]`
Mówca: **Albin Clavin**
> ""...and keeping your extensive powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Albin Clavin: ""Do you want me to believe that?""*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Albin Clavin: ""And you're doing more than that, aren't you? Taking away..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[261]`
Mówca: **Albin Clavin**
> ""And you're doing more than that, aren't you? Taking away the immunity of the Justices and giving the power to impeach to the parliament which our, or should I say, your party controls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Albin Clavin: ""Do you want me to believe that?""*)

### Węzeł `[262]`
Mówca: **Albin Clavin**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Albin Clavin: ""By giving yourself the same rights as Soll?""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Albin Clavin: ""Fair enough.""*)

### Węzeł `[266]`
Mówca: **Albin Clavin**
> ""By giving yourself the same rights as Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Albin Clavin: ""Do you want me to believe that?""*)

### Węzeł `[267]`
Mówca: **Albin Clavin**
> ""Do you want me to believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[268]`
Mówca: **Albin Clavin**
> ""Could you tell me... What is your priority with this proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""Limiting the legislative powers of the Supreme Court.""*)
  - -> `[247]` (*Player: ""Balance and division of powers.""*)
  - -> `[248]` (*Player: ""Bringing down the Constitution of Soll.""*)
  - -> `[249]` (*Player: ""You should have read our manifesto.""*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He let out a fake laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[270]`
Mówca: **Albin Clavin**
> ""Let's see then... There is one more problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Albin Clavin: ""I thought there would be some reform about the extensive..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Albin Clavin: ""And there is more...""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[274]`
Mówca: **Albin Clavin**
> ""And there is more...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Albin Clavin: ""I thought there would be some reform about the extensive..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Albin Clavin: ""Let's see then... There is one more problem.""*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Albin Clavin: ""Let's see then... What are you thinking about?""*)

### Węzeł `[278]`
Mówca: **Albin Clavin**
> ""Let's see then... What are you thinking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: ""We'll bring term limits of 2.""*)
  - -> `[281]` (*Player: ""On a second thought, I'd rather not include any changes ..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""We'll bring term limits of 2.""]** — Mówca: **Player**
> ""We'll bring term limits of 2.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default = false;"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 = true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA: ""On a second thought, I'd rather not include any changes to term limits.""]** — Mówca: **Player**
> ""On a second thought, I'd rather not include any changes to term limits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[282]`
Mówca: **Albin Clavin**
> ""I told you. This is a power grab. I can't support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player: ""Okay. I'll reform the decrees then.""*)
  - -> `[315]` (*Player: ""Fine. I will remove the changes to the immunity of the P..."*)

### Węzeł `[283]`
Mówca: **Albin Clavin**
> ""You should at least do something about term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: ""Fine. I will bring a limit of 2 terms." [CHANGE THE REFORM]"*)
  - -> `[312]` (*Player: ""That's a no.""*)

### Węzeł `[284]`
Mówca: **Albin Clavin**
> ""You should at least do something about the threshold. The party will not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[312]` (*Player: ""That's a no.""*)

### Węzeł `[285]`
Mówca: **Albin Clavin**
> ""We prefer some kind of reform. The president currently holds too much power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Albin Clavin: ""I suggest limiting the power of the decrees with an enab..."*)

### Węzeł `[286]`
Mówca: **Albin Clavin**
> ""I suggest limiting the power of the decrees with an enabling act. The Assembly should have some control over a potential rogue president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Albin Clavin: ""And if you really care about further democratic reforms,..."*)

### Węzeł `[287]`
Mówca: **Albin Clavin**
> ""And if you really care about further democratic reforms, we'll issue the enabling act. But we have to make sure the presidents can't work alone anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""It makes sense. I will include your suggestion and limit..."*)
  - -> `[289]` (*Player: ""I don't trust the Assembly to give me the power to enact..."*)
  - -> `[290]` (*Player: ""I can't let the Assembly control me.""*)

### Węzeł `[288]`
**[WYBÓR GRACZA: ""It makes sense. I will include your suggestion and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""It makes sense. I will include your suggestion and limit the decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Albin Clavin: ""Lovely.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA: ""I don't trust the Assembly to give me the power to enact major reforms though.""]** — Mówca: **Player**
> ""I don't trust the Assembly to give me the power to enact major reforms though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Albin Clavin: ""I thought you wanted to discuss a change...""*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""I can't let the Assembly control me.""]** — Mówca: **Player**
> ""I can't let the Assembly control me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Albin Clavin: ""I thought you wanted to discuss a change...""*)

### Węzeł `[291]`
Mówca: **Albin Clavin**
> ""I thought you wanted to discuss a change...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: ""I'm sure there's some *other way* to convince you.""*)
  - -> `[294]` (*Player: ""Fine. Let's change the law and limit the decrees." [CHAN..."*)
  - -> `[295]` (*Player: ""I don't think I want that.""*)
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)

### Węzeł `[292]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: ""I'm sure there's some *other way* to convince you.""]** — Mówca: **Player**
> ""I'm sure there's some *other way* to convince you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[294]`
**[WYBÓR GRACZA: ""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. Let's change the law and limit the decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Albin Clavin: ""Now, we're getting somewhere.""*)

### Węzeł `[295]`
**[WYBÓR GRACZA: ""I don't think I want that.""]** — Mówca: **Player**
> ""I don't think I want that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Albin Clavin: ""I see.""*)

### Węzeł `[296]`
Mówca: **Albin Clavin**
> ""Now, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[297]`
Mówca: **Albin Clavin**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Albin Clavin: ""You should at least do something about the party's deman..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Albin Clavin: ""Fine...""*)

### Węzeł `[301]`
Mówca: **Albin Clavin**
> ""You should at least do something about the party's demand for minister reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Albin Clavin: ""The ministers should be nominated by the Assembly.""*)

### Węzeł `[302]`
Mówca: **Albin Clavin**
> ""Fine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[303]`
Mówca: **Albin Clavin**
> ""How about the other problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Albin Clavin: ""I thought there would be some reform about the extensive..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Albin Clavin: ""How about the other problem?""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Albin Clavin: ""Fine...""*)

### Węzeł `[307]`
Mówca: **Albin Clavin**
> ""A pleasant surprise. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[308]`
Mówca: **Albin Clavin**
> ""Fine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[309]`
Mówca: **Narrator**
> "He looked down at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""Fine. I will add your suggestion." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will add your suggestion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly = true"*)

### Węzeł `[311]`
Mówca: **Albin Clavin**
> ""The ministers should be nominated by the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""Fine. I will add your suggestion." [CHANGE THE REFORM]"*)
  - -> `[312]` (*Player: ""That's a no.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA: ""That's a no.""]** — Mówca: **Player**
> ""That's a no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Albin Clavin), `[284]` (Albin Clavin), `[311]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Albin Clavin: ""That's a shame.""*)

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Fine. I will remove the decrease in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the decrease in the threshold.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Kontekst wejściowy (poprzednik):** `[284]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[314]`
**[WYBÓR GRACZA: ""Fine. I will bring a limit of 2 terms." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will bring a limit of 2 terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_TermLimits_2 = true"*)

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[316]`
**[WYBÓR GRACZA: ""Okay. I'll reform the decrees then.""]** — Mówca: **Player**
> ""Okay. I'll reform the decrees then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDecree]"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Albin_Law_Ministers_Assembly == true |..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Albin Clavin: ""It's looking good.""*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Reform_Albin_Law_Ministers_Assembly == true ||..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AlbinEnd`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "He looked down at the proposal."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[325]`
Mówca: **Albin Clavin**
> ""Looking good!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Maybe I can offer you something else...""]** — Mówca: **Player**
> ""Maybe I can offer you something else...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Albin Clavin), `[196]` (Albin Clavin), `[600]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the Justices." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the Justices.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[600]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[329]`
**[WYBÓR GRACZA: ""Okay. I'll reform the decrees then.""]** — Mówca: **Player**
> ""Okay. I'll reform the decrees then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDecree]"*)

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Albin Clavin), `[600]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Fine. I will remove the threshold change." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the threshold change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[332]`
**[WYBÓR GRACZA: ""That's a no.""]** — Mówca: **Player**
> ""That's a no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Albin Clavin), `[196]` (Albin Clavin), `[600]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Albin Clavin: ""As much as I want to give you my support, you are forcin..."*)

### Węzeł `[333]`
Mówca: **Albin Clavin**
> ""Finally, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AlbinDecree`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Albin Clavin: ""I suggest limiting the power of the decrees with an enab..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDecree]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "AlbinDecree"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[338]`
Mówca: **Albin Clavin**
> ""Now, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDecree]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "AlbinDecree"*)

### Węzeł `[340]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Reform_Albin_Law_Ministers_Assembly == true ||..."*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(((BaseGame.Reform_Albin_Law_Ministers_Assembly == true ..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false))  and  ((Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Albin Clavin: ""There might... still be a way for me to get behind this.""*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true)))`
- **Warunek bezpośredni (`conditionsString`):** `(((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false))  and  ((Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseG..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseG..."*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(((BaseGame.Reform_Albin_Law_TermLimits_2 == true || Bas..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == false))  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  (Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Albin Clavin: ""There might... still be a way for me to get behind this.""*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)))`
- **Warunek bezpośredni (`conditionsString`):** `(((Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == false))  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  (Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "He took a deep breath then let out a long sigh."*)

### Węzeł `[347]`
Mówca: **Albin Clavin**
> ""It's looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Albin Clavin: ""I will support the proposal and get the needed signature..."*)

### Węzeł `[348]`
Mówca: **Albin Clavin**
> ""There might... still be a way for me to get behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Ref..."*)

### Węzeł `[349]`
Mówca: **Albin Clavin**
> ""... perhaps there is something else you could offer me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: ""Let's look at the draft again. I will give concessions.""*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false"*)
  - -> `[352]` (*Player: ""Pff. This meeting is over.""*)

### Węzeł `[350]`
**[WYBÓR GRACZA: ""Let's look at the draft again. I will give concessions.""]** — Mówca: **Player**
> ""Let's look at the draft again. I will give concessions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Albin Clavin), `[360]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Albin Clavin: ""You already know our concerns.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""Sure. I'll offer you *something else*.""]** — Mówca: **Player**
> ""Sure. I'll offer you *something else*.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false`
- **Kontekst wejściowy (poprzednik):** `[349]` (Albin Clavin), `[360]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Albin_OfferedDeal = true"*)

### Węzeł `[352]`
**[WYBÓR GRACZA: ""Pff. This meeting is over.""]** — Mówca: **Player**
> ""Pff. This meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Albin Clavin), `[360]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Albin Clavin: ""However you see fit, Mr. President. I hope I didn't offe..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Ref..."*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Threshold_15 == true || BaseGame.R..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true)  and  Variable["BaseGameIsolated.Albin_AskedForThreshold"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Albin Clavin: ""Remove the change to the threshold and we will be as gol..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true)  and  Variable["BaseGameIsolated.Albin_AskedForThreshold"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Albin Clavin: ""This is not enough, Mr. President. We can take another l..."*)

### Węzeł `[356]`
Mówca: **Albin Clavin**
> ""Remove the change to the threshold and we will be as golden as Rizia. No need to agitate our party, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""Fine. I will remove the changes to the threshold." [CHAN..."*)
  - -> `[396]` (*Player: ""No. I can't do it.""*)

### Węzeł `[357]`
Mówca: **Albin Clavin**
> ""I will support the proposal and get the needed signatures from our wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Albin Clavin: ""I believe the reformist votes that I have will be very i..."*)

### Węzeł `[358]`
Mówca: **Albin Clavin**
> ""However you see fit, Mr. President. I hope I didn't offend you in some way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinFail]"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinDeal]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "AlbinDeal"*)

### Węzeł `[360]`
Mówca: **Albin Clavin**
> ""This is not enough, Mr. President. We can take another look over the draft or... perhaps there is something else you could offer me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: ""Let's look at the draft again. I will give concessions.""*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false"*)
  - -> `[352]` (*Player: ""Pff. This meeting is over.""*)

### Węzeł `[361]`
Mówca: **Albin Clavin**
> ""You already know our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "We both buried our heads inside the proposal."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "We both buried our heads inside the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Default == true && BaseGa..."*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Default == true || BaseGame...."*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly = true"*)

### Węzeł `[364]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Player: ""I will remove the changes to the immunity of the Preside..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && BaseGa..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""I will give the Assembly the power to nominate the minis..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refo..."*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Re..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Default == true || BaseGame...."*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Default == true || BaseGam..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""I will limit presidential decrees with the requirement f..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true && BaseGam..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I will limit presidential decrees with the requirement for an enabling act." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will limit presidential decrees with the requirement for an enabling act.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[378]`
Mówca: **Albin Clavin**
> ""It wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""Let's just move on.""*)
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true && BaseGam..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Albin_Law_Ministers_Assembly == true |..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  ((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false)  or  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Albin Clavin: ""I guess it's acceptable now.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  ((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false)  or  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Albin Clavin: ""But unfortunately, Mr. President. This is not enough. Ei..."*)

### Węzeł `[382]`
Mówca: **Albin Clavin**
> ""I guess it's acceptable now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Albin Clavin: ""It's looking good.""*)

### Węzeł `[383]`
Mówca: **Albin Clavin**
> ""But unfortunately, Mr. President. This is not enough. Either we change more or....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Albin Clavin: ""... perhaps there is something else you could offer me.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Let's just move on.""]** — Mówca: **Player**
> ""Let's just move on.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Kontekst wejściowy (poprzednik):** `[378]` (Albin Clavin), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA: ""I will also add term limits. 2 should be enough." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will also add term limits. 2 should be enough.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false` AND `((Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[378]` (Albin Clavin), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_TermLimits_2 = true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true && BaseGam..."*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_Default == true && BaseG..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""I will also add term limits. 2 should be enough." [CHANG..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ..."*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Judges_Impeachment_Assembly == tru..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Player: ""I will also remove the changes to the Justices' immunity..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[392]`
**[WYBÓR GRACZA: ""I will also remove the changes to the Justices' immunity." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will also remove the changes to the Justices' immunity.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false` AND `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[378]` (Albin Clavin), `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[393]`
Mówca: **Albin Clavin**
> ""Great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[395]`
Mówca: **Albin Clavin**
> ""It wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Albin Clavin: ""It's looking good.""*)

### Węzeł `[396]`
**[WYBÓR GRACZA: ""No. I can't do it.""]** — Mówca: **Player**
> ""No. I can't do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Albin Clavin: ""This is not enough, Mr. President. We can take another l..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AlbinFail`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Albin Clavin: ""I'm sorry to say that there's nothing I can do for you, ..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "AlbinFail"*)

### Węzeł `[399]`
Mówca: **Albin Clavin**
> ""Good to know, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Albin Clavin: ""I will talk to my guys shortly.""*)

### Węzeł `[400]`
Mówca: **Albin Clavin**
> ""I believe the reformist votes that I have will be very important to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == false"*)

### Węzeł `[401]`
Mówca: **Albin Clavin**
> ""Who knows? Maybe you'll consider me for a job in the government in the future for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player: ""You bet I will, Mr. Clavin.""*)
  - -> `[402]` (*Player: ""I'll consider you, if you prove yourself useful in the v..."*)
  - -> `[403]` (*Player: ""I'll be expecting your votes, Mr. Clavin.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA: ""I'll consider you, if you prove yourself useful in the vote.""]** — Mówca: **Player**
> ""I'll consider you, if you prove yourself useful in the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Albin Clavin: ""Oh, you know I will, Mr. President.""*)

### Węzeł `[403]`
**[WYBÓR GRACZA: ""I'll be expecting your votes, Mr. Clavin.""]** — Mówca: **Player**
> ""I'll be expecting your votes, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Albin Clavin: ""Of course.""*)

### Węzeł `[404]`
Mówca: **Albin Clavin**
> ""See you in the conference, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "I left his room and went back into the corridor."*)

### Węzeł `[405]`
Mówca: **Albin Clavin**
> ""Oh, you know I will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Albin Clavin: ""I will talk to my guys shortly.""*)

### Węzeł `[406]`
Mówca: **Albin Clavin**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Albin Clavin: ""I will talk to my guys shortly.""*)

### Węzeł `[407]`
Mówca: **Albin Clavin**
> ""I'll have their signatures soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player: ""Thank you, Mr. Clavin.""*)
  - -> `[409]` (*Player: ""Don't botch it.""*)

### Węzeł `[408]`
Mówca: **Albin Clavin**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "I left his room and went back into the corridor."*)

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Don't botch it.""]** — Mówca: **Player**
> ""Don't botch it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Albin Clavin: ""I won't.""*)

### Węzeł `[410]`
Mówca: **Albin Clavin**
> ""I will talk to my guys shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Albin Clavin: ""I'll have their signatures soon.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA: ""You bet I will, Mr. Clavin.""]** — Mówca: **Player**
> ""You bet I will, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Albin Clavin: ""Good to know, Mr. President.""*)

### Węzeł `[412]`
**[WYBÓR GRACZA: ""Thank you, Mr. Clavin.""]** — Mówca: **Player**
> ""Thank you, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Albin Clavin: ""See you in the conference, Mr. President.""*)

### Węzeł `[413]`
Mówca: **Albin Clavin**
> ""I'm sorry to say that there's nothing I can do for you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Albin Clavin: ""Good luck with uniting the party under your reforms. But..."*)

### Węzeł `[414]`
Mówca: **Albin Clavin**
> ""Good luck with uniting the party under your reforms. But I guess you will be uniting the party against you like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Albin Clavin: ""Which is an achievement too, I guess.""*)

### Węzeł `[415]`
Mówca: **Albin Clavin**
> ""Which is an achievement too, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Albin Clavin: ""Anyway, I need to get back to work, Mr. President.""*)

### Węzeł `[416]`
Mówca: **Albin Clavin**
> ""We'll see, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "I left his room and went back into the corridor."*)

### Węzeł `[417]`
Mówca: **Albin Clavin**
> ""Anyway, I need to get back to work, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""I understand. I won't bother you any longer.""*)
  - -> `[420]` (*Player: ""Goodbye, Mr. Clavin.""*)
  - -> `[419]` (*Player: ""I'll be expecting the reformists' support, Mr. Clavin.""*)

### Węzeł `[418]`
**[WYBÓR GRACZA: ""I understand. I won't bother you any longer.""]** — Mówca: **Player**
> ""I understand. I won't bother you any longer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Albin Clavin: ""That's not what I meant, sir.""*)

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I'll be expecting the reformists' support, Mr. Clavin.""]** — Mówca: **Player**
> ""I'll be expecting the reformists' support, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Albin Clavin: ""We'll see, Mr. President.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA: ""Goodbye, Mr. Clavin.""]** — Mówca: **Player**
> ""Goodbye, Mr. Clavin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Albin Clavin: ""Goodbye, Mr. President.""*)

### Węzeł `[421]`
Mówca: **Albin Clavin**
> ""That's not what I meant, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Player: ""It's okay, Mr. Clavin. I took no offense.""*)
  - -> `[424]` (*Player_Italic: "Leave the room."*)

### Węzeł `[422]`
**[WYBÓR GRACZA: ""It's okay, Mr. Clavin. I took no offense.""]** — Mówca: **Player**
> ""It's okay, Mr. Clavin. I took no offense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "I left his room and went back into the corridor."*)

### Węzeł `[423]`
Mówca: **Albin Clavin**
> ""Goodbye, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "I left his room and went back into the corridor."*)

### Węzeł `[424]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Italic**
> "I left his room and went back into the corridor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[421]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAl..."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "I left his room and went back into the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAl..."*)

### Węzeł `[426]`
Mówca: **Narrator**
> "I left his room and went back into the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced = true"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin = true"*)

### Węzeł `[428]`
Mówca: **Albin Clavin**
> ""I'm all ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player: ""How about a position in my cabinet?""*)
  - -> `[429]` (*Player: ""If you give us your support, you'll be my VP in my next ..."*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[429]`
**[WYBÓR GRACZA: ""If you give us your support, you'll be my VP in my next cabinet. [Collusion]""]** — Mówca: **Player**
> ""If you give us your support, you'll be my VP in my next cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Albin Clavin: ""An interesting proposal.""*)

### Węzeł `[430]`
**[WYBÓR GRACZA: ""How about this? [Show him a cheque]""]** — Mówca: **Player**
> ""How about this?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[428]` (Albin Clavin), `[474]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "I took out a cheque and showed it to him. It immediately ..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player: ""How about this? [Show him a cheque]""*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Narrator**
> "I took out a cheque and showed it to him. It immediately got his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Albin Clavin: ""That was very direct...""*)

### Węzeł `[435]`
**[WYBÓR GRACZA: ""A lot. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""A lot.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[437]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[436]`
Mówca: **Albin Clavin**
> ""That was very direct...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Albin Clavin: ""...How much are we talking about here?""*)

### Węzeł `[437]`
Mówca: **Albin Clavin**
> ""...How much are we talking about here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[439]` (*Player: ""Name your price.""*)

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Life-changing amount." [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Life-changing amount.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[437]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[439]`
**[WYBÓR GRACZA: ""Name your price.""]** — Mówca: **Player**
> ""Name your price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Albin Clavin: ""I didn't know you were such a *businessman*.""*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player: ""A lot. [-1 Personal Wealth]""*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Player: ""Life-changing amount." [-2 Personal Wealth]""*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[446]`
Mówca: **Albin Clavin**
> ""I didn't know you were such a *businessman*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Albin Clavin: ""How about two of those cheques you're holding?""*)

### Węzeł `[447]`
Mówca: **Albin Clavin**
> ""Look, Mr. President. I'm on the same side as you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Albin Clavin: ""I won't create any problems.""*)

### Węzeł `[448]`
Mówca: **Albin Clavin**
> ""An interesting proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false ||  BaseGame..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false ||  BaseGame..."*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == false ||  BaseGa..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  or  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Albin Clavin: ""One that's very hard to turn down.""*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  or  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Albin Clavin: ""But not quite enough.""*)

### Węzeł `[452]`
Mówca: **Albin Clavin**
> ""One that's very hard to turn down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Albin Clavin: ""Especially now that I think we align, Mr. President.""*)

### Węzeł `[453]`
Mówca: **Albin Clavin**
> ""Especially now that I think we align, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Albin Clavin: ""Can I hold you to that promise?""*)

### Węzeł `[454]`
Mówca: **Albin Clavin**
> ""Can I hold you to that promise?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player: ""Of course. I am a man of my word.""*)
  - -> `[502]` (*Player: ""I don't intend to run with Petr again. It'll be you, I p..."*)
  - -> `[503]` (*Player: ""As long as I get your support.""*)

### Węzeł `[455]`
Mówca: **Albin Clavin**
> ""But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Albin Clavin: ""I can't really support the proposal without at least som..."*)

### Węzeł `[456]`
Mówca: **Albin Clavin**
> ""I can't really support the proposal without at least some change to these points of concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "He showed the listed problems which were outlined on a pi..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "He showed the listed problems which were outlined on a piece of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Player: ""I'm afraid I can't do that.""*)
  - -> `[470]` (*Player: ""Fine. Whatever it takes to get this proposal through the..."*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player: ""I will remove the changes to the immunity of the Preside..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[461]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Kontekst wejściowy (poprzednik):** `[470]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly = true"*)

### Węzeł `[462]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[470]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && BaseGa..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""I will give the Assembly the power to nominate the minis..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true && BaseGame.R..."*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true && BaseGame..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Player: ""I will limit presidential decrees with the requirement f..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[469]`
**[WYBÓR GRACZA: ""I will limit presidential decrees with the requirement for an enabling act." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will limit presidential decrees with the requirement for an enabling act.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Kontekst wejściowy (poprzednik):** `[470]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[470]`
**[WYBÓR GRACZA: ""Fine. Whatever it takes to get this proposal through the Assembly.""]** — Mówca: **Player**
> ""Fine. Whatever it takes to get this proposal through the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true && BaseGame.R..."*)

### Węzeł `[471]`
Mówca: **Albin Clavin**
> ""Great. I knew that we could agree on something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Albin Clavin: ""Now your offer has indeed become something very persuasi..."*)

### Węzeł `[472]`
**[WYBÓR GRACZA: ""How about a position in my cabinet?""]** — Mówca: **Player**
> ""How about a position in my cabinet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Albin Clavin: ""I think we can achieve a lot, if we lead together.""*)

### Węzeł `[473]`
Mówca: **Albin Clavin**
> ""I think we can achieve a lot, if we lead together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Albin Clavin: ""Well... If you promise me the position of the Vice Presi..."*)

### Węzeł `[474]`
Mówca: **Albin Clavin**
> ""Well... If you promise me the position of the Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Player: ""I'm afraid I can't do that.""*)
  - -> `[692]` (*Player: ""Very well. I accept. [Collusion]""*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[475]`
**[WYBÓR GRACZA: ""I'm afraid I can't do that.""]** — Mówca: **Player**
> ""I'm afraid I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Narrator), `[474]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Albin Clavin: ""That's a shame.""*)

### Węzeł `[476]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinFail]"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false )"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""Sure. I'll offer you *something else*.""*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_A_Albin_OfferedDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinDeal]"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "AlbinFail"*)

### Węzeł `[482]`
Mówca: **Albin Clavin**
> ""How about two of those cheques you're holding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[488]` (*Player: ""That's too much.""*)

### Węzeł `[483]`
**[WYBÓR GRACZA: ""Here you go. [Give him two cheques for -2 Personal Wealth]""]** — Mówca: **Player**
> ""Here you go.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[482]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Player: ""Here you go. [Give him two cheques for -2 Personal Wealth]""*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Player: ""How about only one for now?""*)

### Węzeł `[487]`
**[WYBÓR GRACZA: ""How about only one for now?""]** — Mówca: **Player**
> ""How about only one for now?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[482]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Albin Clavin: ""I thought you were a wealthy man...""*)

### Węzeł `[488]`
**[WYBÓR GRACZA: ""That's too much.""]** — Mówca: **Player**
> ""That's too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Albin Clavin: ""I thought you were a wealthy man...""*)

### Węzeł `[489]`
Mówca: **Albin Clavin**
> ""I thought you were a wealthy man...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player: ""Here's one. This will be enough. [-1 Personal Wealth]""*)
  - -> `[491]` (*Player: ""I think there won't be any deal today.""*)

### Węzeł `[490]`
**[WYBÓR GRACZA: ""Here's one. This will be enough. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""Here's one. This will be enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[491]`
**[WYBÓR GRACZA: ""I think there won't be any deal today.""]** — Mówca: **Player**
> ""I think there won't be any deal today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Albin Clavin: ""That's a shame.""*)

### Węzeł `[492]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinFail]"*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "AlbinFail"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_Bribed = true"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_Bribed = true"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_Bribed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Albin_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Narrator: "He took the cheque and slid it into the pocket of his jac..."*)

### Węzeł `[497]`
Mówca: **Albin Clavin**
> ""Glad to be making business with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Narrator: "He glanced at the proposal on the table."*)

### Węzeł `[498]`
Mówca: **Narrator**
> "He took the cheque and slid it into the pocket of his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Albin Clavin: ""Glad to be making business with you.""*)

### Węzeł `[499]`
Mówca: **Narrator**
> "He glanced at the proposal on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Albin Clavin: ""It's looking good.""*)

### Węzeł `[500]`
Mówca: **Albin Clavin**
> ""Now your offer has indeed become something very persuasive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Albin Clavin: ""One that's very hard to turn down.""*)

### Węzeł `[501]`
**[WYBÓR GRACZA: ""Of course. I am a man of my word.""]** — Mówca: **Player**
> ""Of course. I am a man of my word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP = true"*)

### Węzeł `[502]`
**[WYBÓR GRACZA: ""I don't intend to run with Petr again. It'll be you, I promise.""]** — Mówca: **Player**
> ""I don't intend to run with Petr again. It'll be you, I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP = true"*)

### Węzeł `[503]`
**[WYBÓR GRACZA: ""As long as I get your support.""]** — Mówca: **Player**
> ""As long as I get your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP = true"*)

### Węzeł `[504]`
Mówca: **Albin Clavin**
> ""Good. Then it seems like we have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Albin Clavin: ""I will talk to my guys shortly.""*)

### Węzeł `[505]`
Mówca: **Albin Clavin**
> ""I won't create any problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Player: ""That's good to know.""*)
  - -> `[508]` (*Player: ""Thank you, Mr. Clavin. Any help from you is much appreci..."*)
  - -> `[506]` (*Player: ""That's what I wanted to hear.""*)

### Węzeł `[506]`
**[WYBÓR GRACZA: ""That's what I wanted to hear.""]** — Mówca: **Player**
> ""That's what I wanted to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[507]`
**[WYBÓR GRACZA: ""That's good to know.""]** — Mówca: **Player**
> ""That's good to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[508]`
**[WYBÓR GRACZA: ""Thank you, Mr. Clavin. Any help from you is much appreciated.""]** — Mówca: **Player**
> ""Thank you, Mr. Clavin. Any help from you is much appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "Jump to: [AlbinEnd]"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AlbinEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The meeting had exhausted me."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAlbin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The meeting had exhausted me."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Albin Clavin: ""I wanted to express my gratitude for passing the Workers..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Albin Clavin: ""Our team was disappointed by the veto of the Workers' Ri..."*)

### Węzeł `[515]`
Mówca: **Albin Clavin**
> ""I wanted to express my gratitude for passing the Workers' Rights Act. It is one of my most comprehensive and successful political efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Player: ""The worker's revolution will begin with small steps.""*)
  - -> `[521]` (*Player: ""It was the right thing to do because our workers were su..."*)
  - -> `[522]` (*Player: ""The party effort had to be supported.""*)
  - -> `[518]` (*Player: ""You and I see eye to eye on many subjects including this..."*)

### Węzeł `[516]`
Mówca: **Albin Clavin**
> ""Our team was disappointed by the veto of the Workers' Rights Act. We worked day and night for weeks. It would have boosted your public opinion too, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player: ""It wasn't a good time for a drastic changes which would ..."*)
  - -> `[519]` (*Player: ""The businesses would be burdened even further. In this c..."*)
  - -> `[520]` (*Player: ""Either way, your efforts were appreciated by the Palace.""*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[517]`
**[WYBÓR GRACZA: ""It wasn't a good time for a drastic changes which would also costs the government.""]** — Mówca: **Player**
> ""It wasn't a good time for a drastic changes which would also costs the government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Albin Clavin: ""It never is. Not sure how this will reflect on the publi..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA: ""You and I see eye to eye on many subjects including this one.""]** — Mówca: **Player**
> ""You and I see eye to eye on many subjects including this one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Albin Clavin: ""Music to my ears.""*)

### Węzeł `[519]`
**[WYBÓR GRACZA: ""The businesses would be burdened even further. In this climate it would damage the economy.""]** — Mówca: **Player**
> ""The businesses would be burdened even further. In this climate it would damage the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Albin Clavin: ""I understand your perspective but haven't the companies ..."*)

### Węzeł `[520]`
**[WYBÓR GRACZA: ""Either way, your efforts were appreciated by the Palace.""]** — Mówca: **Player**
> ""Your efforts were appreciated by the Palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Albin Clavin: ""Actions would have gone farther than words.""*)

### Węzeł `[521]`
**[WYBÓR GRACZA: ""It was the right thing to do because our workers were suffering for decades.""]** — Mówca: **Player**
> ""It was the right thing to do because our workers were suffering for decades.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Albin Clavin: ""Indeed the people will credit your administration and th..."*)

### Węzeł `[522]`
**[WYBÓR GRACZA: ""The party effort had to be supported.""]** — Mówca: **Player**
> ""The party effort had to be supported.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Albin Clavin: ""It wouldn't be possible without Paskal Beniwoll's suppor..."*)

### Węzeł `[523]`
Mówca: **Albin Clavin**
> ""Indeed the people will credit your administration and the party for a positive change in their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Albin Clavin: ""The businesses will share the burden with the state but ..."*)

### Węzeł `[524]`
Mówca: **Albin Clavin**
> ""I have to say, the close collaboration between the palace and the party is going well. Looking forward to what we can accomplish with the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "Albin smiled and knocked on wood."*)

### Węzeł `[525]`
Mówca: **Albin Clavin**
> ""Music to my ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Albin Clavin: ""It wouldn't be possible without Paskal Beniwoll's suppor..."*)

### Węzeł `[526]`
Mówca: **Albin Clavin**
> ""It never is. Not sure how this will reflect on the public opinion, I wouldn't imagine positively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[527]`
Mówca: **Albin Clavin**
> ""I understand your perspective but haven't the companies benefitted from this situation and made profit for a long time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[528]`
Mówca: **Albin Clavin**
> ""Actions would have gone farther than words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[529]`
Mówca: **Albin Clavin**
> ""It seems that the administration is taking a very pro-business approach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Narrator: "He poured himself some water and had a sip before continu..."*)

### Węzeł `[530]`
Mówca: **Narrator**
> "Albin smiled and knocked on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Albin Clavin: ""Anyway, sir, let's talk about the proposal. Thanks for c..."*)

### Węzeł `[531]`
Mówca: **Narrator**
> "He poured himself some water and had a sip before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Albin Clavin: ""Anyway, sir, let's talk about the proposal. Thanks for c..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Albin Clavin: ""It seems that the administration is taking a very pro-bu..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Albin Clavin: ""It's just that we thought the Palace wouldn't let us down.""*)

### Węzeł `[535]`
Mówca: **Albin Clavin**
> ""It's just that we thought the Palace wouldn't let us down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Albin sighed."*)

### Węzeł `[536]`
Mówca: **Albin Clavin**
> ""The businesses will share the burden with the state but it is a change they have to abide by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[537]`
**[WYBÓR GRACZA: ""The worker's revolution will begin with small steps.""]** — Mówca: **Player**
> ""The worker's revolution will begin with small steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Albin Clavin: ""One would think that I'm talking to Ms. Walda. The party..."*)

### Węzeł `[538]`
Mówca: **Albin Clavin**
> ""One would think that I'm talking to Ms. Walda. The party doesn't support such ideologies as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Albin Clavin: ""Personally there are some principles that I respect in M..."*)

### Węzeł `[539]`
Mówca: **Albin Clavin**
> ""Personally there are some principles that I respect in Malenyevism but I wouldn't accept it in it's entirety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[540]`
**[WYBÓR GRACZA: ""It is a market economy with a free supply and demand system. The government shouldn't overregulate.""]** — Mówca: **Player**
> ""It is a market economy with a free supply and demand system. The government shouldn't overregulate.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[516]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Albin Clavin: ""The situation is borderline exploitative, that is why th..."*)

### Węzeł `[541]`
Mówca: **Albin Clavin**
> ""The situation is borderline exploitative, that is why the majority of the assembly gathered behind it. The act was supposed to bring some regulation which didn't exist before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player: ""It is a market economy with a free supply and demand sys..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[545]`
Mówca: **Albin Clavin**
> ""It wouldn't be possible without Paskal Beniwoll's support. The Labour Union and several NGO's like Magnus Cartus also contributed to the campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[546]`
Mówca: **Narrator**
> "Albin sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Albin Clavin: ""Anyway, sir, let's talk about the proposal. Thanks for c..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Albin Clavin: ""I have to say, the close collaboration between the palac..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "Albin smiled and knocked on wood."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Albin Clavin: ""A pleasant surprise. Let's move on.""*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Albin Clavin: ""Looking good!""*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Albin Clavin: ""Finally, we're getting somewhere.""*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Albin Clavin: ""Finally, we're getting somewhere.""*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Albin Clavin: ""Now, we're getting somewhere.""*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_TermLimits_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Albin Clavin: ""Now, we're getting somewhere.""*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Albin Clavin: ""Now, we're getting somewhere.""*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Albin Clavin: ""Now, we're getting somewhere.""*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Albin Clavin: ""Great. I knew that we could agree on something.""*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Albin Clavin: ""Great. I knew that we could agree on something.""*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Albin Clavin: ""Great. I knew that we could agree on something.""*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Albin Clavin: ""It wasn't so hard, was it?""*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Albin Clavin: ""It wasn't so hard, was it?""*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Albin Clavin: ""It wasn't so hard, was it?""*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Albin Clavin: ""It wasn't so hard, was it?""*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_TermLimits_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Albin Clavin: ""Great!""*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Albin Clavin: ""Great!""*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Albin Clavin: ""Finally, we're getting somewhere.""*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Albin Clavin: ""It wasn't so hard, was it?""*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_USPMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_USPMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_A_Convince_Albin = true"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_A_Convince_Albin = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_A_Convince_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_15 == true)"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Albin Clavin: ""First, I'll say that I'm concerned about the increase in..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == tru..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player: "" I will remove the changes to the immunity of the Justic..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
Mówca: **Albin Clavin**
> ""First, I'll say that I'm concerned about the increase in the threshold. The reformist wing of the party will do its best to boycott that since the expectation from us is to democratise, not do the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[580]`
Mówca: **Albin Clavin**
> ""Our constituents wouldn't accept the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He paused and twiddled his thumbs."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Albin Clavin: ""That will have negative consequences for our party since..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Albin Clavin: ""The change will have negative consequences for our party..."*)

### Węzeł `[584]`
Mówca: **Albin Clavin**
> ""The change will have negative consequences for our party since dozens of new parties could potentially enter the parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He paused and twiddled his thumbs."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Albin Clavin: ""Combined with the electoral finance reform no other part..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Albin Clavin: ""Our constituents wouldn't accept the situation.""*)

### Węzeł `[588]`
Mówca: **Albin Clavin**
> ""Combined with the electoral finance reform no other party can ever make it to the parliament. Our constituents wouldn't accept the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He paused and twiddled his thumbs."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Veto_Loophole == true)"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Albin Clavin: ""And the attempt to offset this by adding an override of ..."*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Veto_Loophole == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Albin Clavin: ""I thought you were one of us. Against Sollism and the co..."*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player: ""Fine. I will remove the decrease in the threshold." [CHA..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Player: ""Fine. I will remove the increase in the threshold.""*)

### Węzeł `[595]`
**[WYBÓR GRACZA: ""Fine. I will remove the increase in the threshold.""]** — Mówca: **Player**
> ""Fine. I will remove the increase in the threshold.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[284]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == true)"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Albin Clavin: ""You are removing the Justices' immunity and giving it to..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Albin Clavin: ""You are removing the Justices' immunity and giving the a..."*)

### Węzeł `[599]`
Mówca: **Albin Clavin**
> ""You are removing the Justices' immunity and giving the ability to impeach it to the parliament. I'm a parliamentarian at heart and while I think this strengthens the people's representative power, it still is wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Albin Clavin: ""Who do you think we are to support such changes, Mr. Pre..."*)

### Węzeł `[600]`
Mówca: **Albin Clavin**
> ""Who do you think we are to support such changes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""Fine. I will remove the changes to the immunity of the J..."*)
  - -> `[330]` (*Player: ""Fine. I will remove the changes to the immunity of the P..."*)
  - -> `[327]` (*Player: ""Maybe I can offer you something else...""*)
  - -> `[332]` (*Player: ""That's a no.""*)

### Węzeł `[601]`
**[WYBÓR GRACZA: "" I will remove the changes to the immunity of the Justices." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the Justices.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[470]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Albin Clavin: ""Great. I knew that we could agree on something.""*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == true)"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Albin Clavin: ""And you're doing more than that, aren't you? Taking away..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Albin Clavin: ""Fair enough.""*)

### Węzeł `[606]`
Mówca: **Albin Clavin**
> ""And you're doing more than that, aren't you? Taking away the immunity of the Justices and giving the power to replace them to yourself. A worrying notion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Albin Clavin: ""Do you want me to believe that?""*)

### Węzeł `[607]`
**[WYBÓR GRACZA: ""I will remove the decrease in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the decrease in the threshold.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true` AND `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[608]`
**[WYBÓR GRACZA: ""I will remove the increase in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the increase in the threshold.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false` AND `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default = true"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Player: ""I will remove the decrease in the threshold." [CHANGE TH..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Player: ""I will remove the increase in the threshold." [CHANGE TH..."*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Albin Clavin: ""What I didn't expect was a worsening of the current situ..."*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: ""I have to say that most of the progressives were already..."*)

### Węzeł `[615]`
Mówca: **Albin Clavin**
> ""This particular change is specifically worrying as it represents an opposite trend. The decrees need to be weaker not stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Player: ""To truly reform the country the President needs decrees ..."*)
  - -> `[617]` (*Player: ""What is wrong with a USP President having strong decree ..."*)
  - -> `[618]` (*Player: ""I respect the perspective of the reformist wing.""*)

### Węzeł `[616]`
**[WYBÓR GRACZA: ""To truly reform the country the President needs decrees not subject to review.""]** — Mówca: **Player**
> ""To truly reform the country the President needs decrees not subject to review.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[615]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Albin Clavin: ""Why can't the President work closely with the Assembly?""*)

### Węzeł `[617]`
**[WYBÓR GRACZA: ""What is wrong with a USP President having strong decree powers?""]** — Mówca: **Player**
> ""What is wrong with a USP President having strong decree powers?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[615]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Albin Clavin: ""Well there were some subjects that were wrong about Tarq..."*)

### Węzeł `[618]`
**[WYBÓR GRACZA: ""I respect the perspective of the reformist wing.""]** — Mówca: **Player**
> ""I respect the perspective of the reformist wing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[615]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Albin Clavin: ""Enough to make a slight change that would heavily influe..."*)

### Węzeł `[619]`
Mówca: **Albin Clavin**
> ""What I didn't expect was a worsening of the current situation. Presidential decrees above statute law and not subject to judicial review... It would destroy the separation of powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Albin Clavin: ""This particular change is specifically worrying as it re..."*)

### Węzeł `[620]`
Mówca: **Albin Clavin**
> ""And the attempt to offset this by adding an override of the veto power to the parliament only to have no time limit to act is a very low move. Tricks like this won't go unnoticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Albin Clavin: ""I thought you were one of us. Against Sollism and the co..."*)

### Węzeł `[621]`
Mówca: **Albin Clavin**
> ""I thought you wanted to discuss a change...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Player: ""Fine. Let's change the law and limit the decrees." [CHAN..."*)
  - -> `[625]` (*Player: ""I don't think I want that.""*)
  - -> `[622]` (*Player: ""There must be another way.""*)

### Węzeł `[622]`
**[WYBÓR GRACZA: ""There must be another way.""]** — Mówca: **Player**
> ""There must be another way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: ""I have to say that most of the progressives were already..."*)

### Węzeł `[623]`
**[WYBÓR GRACZA: ""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. Let's change the law and limit the decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Albin Clavin: ""Lovely.""*)

### Węzeł `[624]`
Mówca: **Albin Clavin**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: ""I have to say that most of the progressives were already..."*)

### Węzeł `[625]`
**[WYBÓR GRACZA: ""I don't think I want that.""]** — Mówca: **Player**
> ""I don't think I want that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[621]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Albin Clavin: ""I see.""*)

### Węzeł `[626]`
**[WYBÓR GRACZA: ""I can't let the Assembly control me.""]** — Mówca: **Player**
> ""I can't let the Assembly control me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[636]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Albin Clavin: ""I thought you wanted to discuss a change...""*)

### Węzeł `[627]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[628]`
**[WYBÓR GRACZA: ""I don't trust the Assembly to give me the power to enact major reforms though.""]** — Mówca: **Player**
> ""I don't trust the Assembly to give me the power to enact major reforms though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[636]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Albin Clavin: ""I thought you wanted to discuss a change...""*)

### Węzeł `[629]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker = true"*)

### Węzeł `[630]`
**[WYBÓR GRACZA: ""It makes sense. I will include your suggestion and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""It makes sense. I will include your suggestion and limit the decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[636]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Albin Clavin: ""Lovely.""*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Veto_Loophole == true)"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Player: ""The fact that we are giving the Assembly the power to ov..."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Veto_Loophole == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[634]`
**[WYBÓR GRACZA: ""The fact that we are giving the Assembly the power to override a veto is change enough.""]** — Mówca: **Player**
> ""The fact that we are giving the Assembly the power to override a veto is change enough.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Kontekst wejściowy (poprzednik):** `[291]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Albin Clavin: ""You didn't include any time limit for that response thus..."*)

### Węzeł `[635]`
Mówca: **Albin Clavin**
> ""You didn't include any time limit for that response thus creating a loophole which puts us back to square one. Nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "AlbinEnd"*)

### Węzeł `[636]`
Mówca: **Albin Clavin**
> ""And if you really care about further democratic reforms, we'll issue the enabling act. But we have to make sure the presidents can't work alone anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Player: ""It makes sense. I will include your suggestion and limit..."*)
  - -> `[628]` (*Player: ""I don't trust the Assembly to give me the power to enact..."*)
  - -> `[626]` (*Player: ""I can't let the Assembly control me.""*)

### Węzeł `[637]`
Mówca: **Albin Clavin**
> ""I suggest limiting the power of the decrees with an enabling act. The Assembly should have some control over a potential rogue president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[638]`
Mówca: **Albin Clavin**
> ""Well there were some subjects that were wrong about Tarquin Soll and we don't want to see a repeat of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Albin Clavin: ""I suggest limiting the power of the decrees with an enab..."*)

### Węzeł `[639]`
Mówca: **Albin Clavin**
> ""Enough to make a slight change that would heavily influence our tendencies to support the draft?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Albin Clavin: ""I suggest limiting the power of the decrees with an enab..."*)

### Węzeł `[640]`
Mówca: **Albin Clavin**
> ""Why can't the President work closely with the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Albin Clavin: ""I suggest limiting the power of the decrees with an enab..."*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Albin Clavin: ""Which under this draft proposal also would have immunity..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Albin Clavin: ""And if you really care about further democratic reforms,..."*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Albin Clavin: ""And your abolishment of the honorary membership indicate..."*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Albin Clavin: ""But us democrats have already established our demands, w..."*)

### Węzeł `[647]`
Mówca: **Albin Clavin**
> ""Which under this draft proposal also would have immunity for life once retired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Albin Clavin: ""And if you really care about further democratic reforms,..."*)

### Węzeł `[648]`
Mówca: **Albin Clavin**
> ""And your abolishment of the honorary membership indicates that you are a democrat too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Albin Clavin: ""But the extent of your democratic beliefs matter.""*)

### Węzeł `[649]`
Mówca: **Albin Clavin**
> ""But the extent of your democratic beliefs matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Let's hear your problems.""*)
  - -> `[122]` (*Player: ""How about some other deal?""*)
  - -> `[123]` (*Player: ""I can't let you sabotage this.""*)
  - -> `[124]` (*Player: ""Don't forget who you are speaking to.""*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Albin Clavin: ""The removal of the honorary membership won't be respecte..."*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Albin Clavin: ""With all due respect, maybe you shouldn't forget that it..."*)

### Węzeł `[653]`
Mówca: **Albin Clavin**
> ""The removal of the honorary membership won't be respected by the party either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Albin Clavin: ""With all due respect, maybe you shouldn't forget that it..."*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Albin Clavin: ""Good. Then it seems like we have a deal.""*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Default == true && BaseGa..."*)
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Default == true && Base..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""Let's just move on.""*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Player: ""On a second thought, I'm fine with the current draft.""*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: ""I have to say that most of the progressives were already..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true"*)
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true)"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker == true"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Decrees_Weaker == true"*)
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_Decrees_Weaker == true)"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Decrees_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default = false; BaseGame.Ref..."*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_Decrees_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default  == true"*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default  == true"*)
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_Impeachment_Default  == true)"*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default  == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Assembly = false; BaseGam..."*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_Impeachment_Default  == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]  == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true"*)
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_Judges_Impeachment_Default ==..."*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President = false;..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly == true"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly == true"*)
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_Ministers_Assembly == true)"*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_ConfidenceVote = false; Bas..."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_Ministers_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_TermLimits_2 == true"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_TermLimits_2 == true"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_TermLimits_2 == true)"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default = false"*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default == true"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default == true"*)
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Law_Threshold_Default == true)"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform..."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default = false; BaseGame.Reform_Law_Decrees_Removed = false;  BaseGame.Reform_Law_Decrees_Stronger = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] = false;
Variable["BaseGame.Reform_Law_Decrees_Removed"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker = true"*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default  == true"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Assembly = false; BaseGame.Reform_Law_Impeachment_Harder = false; BaseGame.Reform_Law_Impeachment_Removed = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Harder"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Removed"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Default = true"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President = false; BaseGame.Reform_Law_Judges_Impeachment_Assembly = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] = false;
Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly == true"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_ConfidenceVote = false; BaseGame.Reform_Law_Ministers_Default = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] = false;
Variable["BaseGame.Reform_Law_Ministers_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Assembly = true"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_TermLimits_2 == true"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 = true"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Threshold_Default == true"*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default = true"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[692]`
**[WYBÓR GRACZA: ""Very well. I accept. [Collusion]""]** — Mówca: **Player**
> ""Very well. I accept.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Albin Clavin: ""Can I hold you to that promise?""*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Player: ""I wouldn't mind if my next Vice President had a bit more..."*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[696]`
**[WYBÓR GRACZA: ""I wouldn't mind if my next Vice President had a bit more... funds. [Show him a cheque]""]** — Mówca: **Player**
> ""I wouldn't mind if my next Vice President had a bit more... funds.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[457]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Narrator: "I took out a cheque and showed it to him. It immediately ..."*)

### Węzeł `[697]`
Mówca: **Narrator**
> "I took out a cheque and showed it to him. It immediately got his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Albin Clavin: ""You certainly know how to make compelling arguments, don..."*)

### Węzeł `[698]`
Mówca: **Albin Clavin**
> ""You certainly know how to make compelling arguments, don't you Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Narrator: "He took the cheque and slid it into the pocket of his jac..."*)

### Węzeł `[699]`
Mówca: **Narrator**
> "He took the cheque and slid it into the pocket of his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Albin Clavin: ""Glad to be making business with you.""*)

### Węzeł `[700]`
Mówca: **Albin Clavin**
> ""Glad to be making business with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_Bribed = true"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_Bribed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Albin_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Albin Clavin: ""Now your offer has indeed become something very persuasi..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_PromisedVP == false"*)
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Albin_PromisedVP == false)"*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_PromisedVP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Albin Clavin: ""Who knows? Maybe you'll consider me for a job in the gov..."*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Albin_PromisedVP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Albin Clavin: ""I will talk to my guys shortly.""*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Player: ""I will remove the changes to the immunity of the Preside..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[708]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Kontekst wejściowy (poprzednik):** `[378]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Ministers_Assembly = true"*)

### Węzeł `[709]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[378]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Law_Impeachment_Default = true"*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true && BaseGame..."*)
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true && BaseGa..."*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Player: ""I will give the Assembly the power to nominate the minis..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Albin Clavin: ""Great!""*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Law_Ministers_Assembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Albin Clavin: ""Great!""*)

### Węzeł `[715]`
Mówca: **Narrator**
> "He took a deep breath then let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Albin Clavin: ""But unfortunately, Mr. President. This is not enough. Ei..."*)

### Węzeł `[716]`
**[WYBÓR GRACZA: ""On a second thought, I'm fine with the current draft.""]** — Mówca: **Player**
> ""On a second thought, I'm fine with the current draft.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[362]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Albin_Law_Ministers_Assembly == true || ..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Passed a comprehensive bill to improve w..."*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Vetoed a comprehensive workers rights bi..."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Passed a comprehensive bill to improve workers rights", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Passed a comprehensive bill to improve workers rights","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Vetoed a comprehensive workers rights bill", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Vetoed a comprehensive workers rights bill","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The left side of the hall where Albin sat started applaud..."*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The moderates that sat in the centre started applauding."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "A round of applause from the left was heard."*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Albin_AskedForThreshold = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Albin_AskedForThreshold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Albin Clavin: ""You should at least do something about the threshold. Th..."*)
