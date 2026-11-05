# Sordland/Turn07/BludishRightsMeeting

- **ID konwersacji:** `128`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/128_BludishRightsMeeting.md`
- **Liczba węzłów dialogowych:** 436
- **Liczba wyborów gracza:** 113

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[30]** Fetih Ejall
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSpecialZone_Proposal_Amendment`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option1`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option2`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option3`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Sollist`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option1`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option2`
- `BaseGameIsolated.BludishRightsMeeting_Hub_Option3`
- `BaseGameSupport.Journal_Turn07_BludishMeeting_ChangedProposal`
- `BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal`
- `BaseGameSupport.News_Turn07_HP_RayneChangesProposal`
- `BaseGameSupport.News_Turn07_R_BludishMovementGivesSupportToRayne`
- `BaseGameSupport.News_Turn07_R_RayneChangesProposal`
- `BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator`
- `BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone`
- `BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""How many times do you need to read that, Lucian?""** | `[5]` **Narrator**: "Lucian was poring over the propo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Lucian Galade**: ""Forgive me, sir. As I wasn't in..." |
| `[7]` | **""Lucian, are you okay? I thought you would have memorized the proposal within minu..."** | `[5]` **Narrator**: "Lucian was poring over the propo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucian Galade**: ""Of course I've read it, sir. Bu..." |
| `[8]` | **""If there's something you want to say to me before the guests arrive, this would b..."** | `[5]` **Narrator**: "Lucian was poring over the propo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Lucian Galade**: ""Since you've already accepted t..." |
| `[9]` | **"Stay silent."** | `[5]` **Narrator**: "Lucian was poring over the propo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Lucian Galade**: ""Ms. Morgna did a fine job, but ..." |
| `[18]` | **""I thought you would support me through this, Lucian.""** | `[17]` **Lucian Galade**: ""It replaces the term 'Sord' wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""Of course I will, sir. I'm just..." |
| `[19]` | **""Are you advising against changing our proposal?""** | `[17]` **Lucian Galade**: ""It replaces the term 'Sord' wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..." |
| `[20]` | **""What do you mean? Are you showing me your nationalist side, Lucian?""** | `[17]` **Lucian Galade**: ""It replaces the term 'Sord' wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucian Galade**: ""No, sir. I'm merely stating tha..." |
| `[21]` | **""Well, don't stop there. Read the changes to Article 7 as well.""** | `[17]` **Lucian Galade**: ""It replaces the term 'Sord' wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "He flipped to the second page of..." |
| `[30]` | **""Well... Nothing's been decided yet.""** | `[22]` **Lucian Galade**: ""Of course I will, sir. I'm just..."<br>`[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "He flipped to the second page of..." |
| `[32]` | **""I want you to give this a chance, Lucian. I believe this is very important for th..."** | `[22]` **Lucian Galade**: ""Of course I will, sir. I'm just..."<br>`[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Lucian Galade**: ""Of course, sir."" |
| `[33]` | **""The party doesn't support the current proposal anyway. At least we can shine a sp..."** | `[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..."<br>`[31]` **Lucian Galade**: ""No, sir. I'm merely stating tha..." | `Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false` | *Brak zmian stanu* | `[36]` **Lucian Galade**: ""Of course, sir."" |
| `[34]` | **""I didn't get the full party's support for our current proposal, either... Honestl..."** | `[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..."<br>`[31]` **Lucian Galade**: ""No, sir. I'm merely stating tha..." | `Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false`<br>`(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false` | *Brak zmian stanu* | `[37]` **Lucian Galade**: ""If you say so, sir."" |
| `[35]` | **""You might be right. It was already difficult trying to get the party to back our ..."** | `[23]` **Lucian Galade**: ""I'll be honest, sir. I don't se..."<br>`[31]` **Lucian Galade**: ""No, sir. I'm merely stating tha..." | `(Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`<br>`(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false` | *Brak zmian stanu* | `[38]` **Lucian Galade**: ""With these additions, it will b..." |
| `[47]` | **""Of course I am.""** | `[46]` **Lucian Galade**: ""What about you, sir? Are you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Lucian Galade**: ""I'll be honest."" |
| `[48]` | **""Not seriously, no. I just want to test the waters.""** | `[46]` **Lucian Galade**: ""What about you, sir? Are you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Lucian Galade**: ""Good to know."" |
| `[49]` | **""That really depends on how today's meeting goes.""** | `[46]` **Lucian Galade**: ""What about you, sir? Are you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Lucian Galade**: ""I'll be honest."" |
| `[50]` | **""Tell me straight, Lucian. What are our chances of passing this proposal?""** | `[46]` **Lucian Galade**: ""What about you, sir? Are you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Lucian Galade**: ""I'll be honest."" |
| `[62]` | **""You don't seem too happy about this meeting.""** | `[66]` **Narrator**: "But since our statement with the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: ""Forgive me, sir. I just think w..." |
| `[63]` | **""Do you think they are here to ask us to change Articles 6 and 7?""** | `[66]` **Narrator**: "But since our statement with the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lucian Galade**: ""There's no question about it, s..." |
| `[64]` | **""If there's something you want to tell me before the guests arrive, now would be t..."** | `[66]` **Narrator**: "But since our statement with the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: ""Forgive me, sir. I just think w..." |
| `[65]` | **"Stay silent."** | `[66]` **Narrator**: "But since our statement with the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: ""Sir. I believe your statement w..." |
| `[74]` | **""What's your advice, then?""** | `[72]` **Lucian Galade**: ""With that said... If you don't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lucian Galade**: ""As much as I'm troubled by the ..." |
| `[75]` | **""If we have the opportunity to change those articles as well, we have to seize it.""** | `[72]` **Lucian Galade**: ""With that said... If you don't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Lucian Galade**: ""If you say so, sir."" |
| `[76]` | **""Do you think there's no way to pass changes to Articles 6 and 7?""** | `[72]` **Lucian Galade**: ""With that said... If you don't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: ""It's true that Mr. Ersen's case..." |
| `[77]` | **""Don't worry. I don't intend to change our current proposal.""** | `[72]` **Lucian Galade**: ""With that said... If you don't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: ""Good to know."" |
| `[89]` | **""It's good to see you, gentlemen. Please, have a seat.""** | `[61]` **Mansoun Leke**: ""Thanks for having us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "We shook hands and took our seat..." |
| `[90]` | **""Good morning, Mr. Leke and Mr. Ejall. Why don't we take a seat?""** | `[61]` **Mansoun Leke**: ""Thanks for having us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "We shook hands and took our seat..." |
| `[91]` | **""Barilbar zinjar, my Bludish brothers. Please have a seat.""** | `[61]` **Mansoun Leke**: ""Thanks for having us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "Mansoun and Fetih exchanged puzz..." |
| `[104]` | **""I promise you, I am willing to fight for your rights until we achieve true equali..."** | `[102]` **Fetih Ejall**: ""But know this. If you're *reall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Fetih Ejall**: ""Ett'a. Of course."" |
| `[105]` | **""I think I've already shown you that my intentions are pure by involving you in ou..."** | `[102]` **Fetih Ejall**: ""But know this. If you're *reall..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true` | *Brak zmian stanu* | `[111]` **Mansoun Leke**: ""The addition of these changes t..." |
| `[106]` | **""Why don't we jump straight to the point?""** | `[102]` **Fetih Ejall**: ""But know this. If you're *reall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Fetih Ejall**: ""Ett'a. Of course."" |
| `[110]` | **""That's great to know. Thank you, Mr. Ejall.""** | `[102]` **Fetih Ejall**: ""But know this. If you're *reall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Fetih Ejall**: ""Ett'a. Of course."" |
| `[122]` | **""I'm listening.""** | `[121]` **Fetih Ejall**: ""If you're willing to listen, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Fetih Ejall**: ""Mr. Leke, could you read the pr..." |
| `[123]` | **""As much as I support your cause, the timing of this may not be the best.""** | `[118]` **Fetih Ejall**: ""If we're already aligned and th..."<br>`[121]` **Fetih Ejall**: ""If you're willing to listen, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Fetih Ejall**: ""No. On the contrary, this is th..." |
| `[124]` | **""You have the floor.""** | `[121]` **Fetih Ejall**: ""If you're willing to listen, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Fetih Ejall**: ""Mr. Leke, could you read the pr..." |
| `[125]` | **""I went over the changes already and I approve of them. Let's talk about how we ca..."** | `[118]` **Fetih Ejall**: ""If we're already aligned and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Fetih Ejall**: ""All right."" |
| `[126]` | **""Before we discuss our strategy, I'd like to go over the changes together with you.""** | `[118]` **Fetih Ejall**: ""If we're already aligned and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Fetih Ejall**: ""Great. Mr. Leke, could you read..." |
| `[127]` | **""I'll be honest. It is still not guaranteed that we'll be adding these changes to ..."** | `[118]` **Fetih Ejall**: ""If we're already aligned and th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Fetih Ejall**: ""You didn't hear our offer yet, ..." |
| `[141]` | **""Gentlemen. I'm all with you on this.""** | `[140]` **Mansoun Leke**: ""'Everyone, regardless of langua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Fetih Ejall**: ""Good to know, Mr. President."" |
| `[142]` | **""These are very significant and necessary changes. But they should be the target o..."** | `[140]` **Mansoun Leke**: ""'Everyone, regardless of langua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Lucian Galade**: ""Mr. President is right. Given t..." |
| `[143]` | **""As much as I agree with these changes in principle, I don't have a sound plan to ..."** | `[140]` **Mansoun Leke**: ""'Everyone, regardless of langua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Lucian Galade**: ""Mr. President is right. Given t..." |
| `[144]` | **""Are you crazy? This proposal will be crushed in an instant.""** | `[140]` **Mansoun Leke**: ""'Everyone, regardless of langua..." | `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false` | *Brak zmian stanu* | `[152]` **Lucian Galade**: ""Mr. President is right. Given t..." |
| `[159]` | **""You sound like you're trying to justify the actions of the secessionists. I hope ..."** | `[157]` **Fetih Ejall**: ""Ett'a. And that deadlock is wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Fetih Ejall**: ""You know what I'm referring to,..." |
| `[160]` | **""The liberation movement?""** | `[157]` **Fetih Ejall**: ""Ett'a. And that deadlock is wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Fetih Ejall**: ""Exactly. As long as the governm..." |
| `[163]` | **""Okay, let's talk strategy. Let's hear your offer.""** | `[162]` **Fetih Ejall**: ""You didn't hear our offer yet, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Fetih Ejall**: ""All right."" |
| `[164]` | **""Let's go over those contents one more time.""** | `[162]` **Fetih Ejall**: ""You didn't hear our offer yet, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Fetih Ejall**: ""Sure. Mr. Leke, could you read ..." |
| `[171]` | **""Are you really trying to justify the actions of the BFF right now?""** | `[170]` **Fetih Ejall**: ""And as long as you label those ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Fetih Ejall**: ""I'm not trying to justify anyth..." |
| `[172]` | **""So the only side at fault here is the government?""** | `[170]` **Fetih Ejall**: ""And as long as you label those ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Fetih Ejall**: ""No. I didn't say that."" |
| `[173]` | **""I knew you were in cahoots with the terrorists.""** | `[170]` **Fetih Ejall**: ""And as long as you label those ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Fetih Ejall**: ""I'm not going to reply to that."" |
| `[174]` | **""You are right. Many mistakes were made to the detriment of the Bludish people. We..."** | `[170]` **Fetih Ejall**: ""And as long as you label those ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Fetih Ejall**: ""I'm glad you agree."" |
| `[182]` | **""No, Mr. Leke. Please calm down.""** | `[181]` **Mansoun Leke**: ""You're not even listening, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Fetih Ejall**: ""Gentlemen. Let's get one thing ..." |
| `[183]` | **""They're right, Lucian. The Sordish state isn't entirely innocent.""** | `[181]` **Mansoun Leke**: ""You're not even listening, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Lucian Galade**: ""Of course, sir."" |
| `[184]` | **""But we are listening.""** | `[181]` **Mansoun Leke**: ""You're not even listening, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Fetih Ejall**: ""Gentlemen. Let's get one thing ..." |
| `[185]` | **""I'm not looking for reasons, Mr. Leke. But if you give me one, you'll face justic..."** | `[181]` **Mansoun Leke**: ""You're not even listening, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Fetih Ejall**: ""Fara!? Don't finish that senten..." |
| `[191]` | **""Since we're already on the same page, we should talk about how realistic it is to..."** | `[177]` **Fetih Ejall**: ""I'm glad you agree."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Fetih Ejall**: ""All right."" |
| `[192]` | **""But the Bludish movement must properly distance itself from the secessionists. Ot..."** | `[177]` **Fetih Ejall**: ""I'm glad you agree."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Fetih Ejall**: ""We will, Mr. President. If you ..." |
| `[198]` | **""Yes, Mr. Ejall. I'm willing to support you.""** | `[190]` **Fetih Ejall**: ""Are you willing to support our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Fetih Ejall**: ""All right."" |
| `[199]` | **""I want to support this proposal, but you have to convince me that you have a soun..."** | `[190]` **Fetih Ejall**: ""Are you willing to support our ..."<br>`[208]` **Fetih Ejall**: ""You cannot dictate that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Fetih Ejall**: ""All right."" |
| `[200]` | **""I thought we could find other common ground.""** | `[190]` **Fetih Ejall**: ""Are you willing to support our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Fetih Ejall**: ""You cannot dictate that."" |
| `[201]` | **""No. I'm not willing to support your proposal.""** | `[190]` **Fetih Ejall**: ""Are you willing to support our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Fetih Ejall**: ""As expected."" |
| `[203]` | **""Mr. Ejall... Sit down, please.""** | `[202]` **Narrator**: "He stood up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Fetih Ejall**: ""I don't see why I should stay i..." |
| `[204]` | **""You're forgetting your place.""** | `[202]` **Narrator**: "He stood up."<br>`[388]` **Fetih Ejall**: ""If you're not willing to suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Fetih Ejall**: ""I'm not going to indulge your p..." |
| `[205]` | **""Stop throwing Bludish words around, Mr. Ejall. I hope for your sake that you didn..."** | `[202]` **Narrator**: "He stood up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Fetih Ejall**: ""I'm not going to indulge your p..." |
| `[207]` | **""Please repeat that in proper Sordish.""** | `[202]` **Narrator**: "He stood up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Fetih Ejall**: ""I'm not going to indulge your p..." |
| `[212]` | **""Look. I'm willing to support you, but I don't believe we can succeed.""** | `[211]` **Fetih Ejall**: ""I don't see why I should stay i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Mansoun Leke**: ""Please sit down, Mr. Ejall. Let..." |
| `[213]` | **""Why don't we all just calm down and hear your plan?""** | `[211]` **Fetih Ejall**: ""I don't see why I should stay i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Mansoun Leke**: ""Please sit down, Mr. Ejall. Let..." |
| `[214]` | **""Did you not learn common courtesy?""** | `[211]` **Fetih Ejall**: ""I don't see why I should stay i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Fetih Ejall**: ""No, I didn't. I'm a *Blud*, aft..." |
| `[243]` | **""I wouldn't count on the PFJP too much.""** | `[233]` **Fetih Ejall**: ""It's true. If you include our c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucian Galade**: ""Gathering the support of the US..." |
| `[244]` | **""That's good to know.""** | `[233]` **Fetih Ejall**: ""It's true. If you include our c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucian Galade**: ""Gathering the support of the US..." |
| `[245]` | **""Well, but that doesn't help me with convincing the USP.""** | `[233]` **Fetih Ejall**: ""It's true. If you include our c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Lucian Galade**: ""Gathering the support of the US..." |
| `[252]` | **""Intriguing. So you really are a traitor to your cause.""** | `[251]` **Fetih Ejall**: ""If you include these changes in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Fetih Ejall**: ""Watch what you're saying, Mr. P..." |
| `[253]` | **""Are you absolutely serious, Mr. Ejall?""** | `[251]` **Fetih Ejall**: ""If you include these changes in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Fetih Ejall**: ""Yes."" |
| `[254]` | **""How do we know the Old Guard will be convinced by that?""** | `[251]` **Fetih Ejall**: ""If you include these changes in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Mansoun Leke**: ""You can't *know* everything, Mr..." |
| `[255]` | **""Are you really admitting your direct ties to the BFF in front of the president?""** | `[251]` **Fetih Ejall**: ""If you include these changes in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Mansoun Leke**: ""You're starting to show your tr..." |
| `[268]` | **""If you can promise us the BFF, maybe we can make this work.""** | `[266]` **Fetih Ejall**: ""We came here with a real offer ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Fetih Ejall**: ""That I promise."" |
| `[269]` | **""You're forgetting something. We never promised you anything.""** | `[266]` **Fetih Ejall**: ""We came here with a real offer ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Fetih Ejall**: ""So you don't intend to pursue t..." |
| `[270]` | **""That's Lucian's personal opinion, Mr. Ejall. There is no sudden change. I am will..."** | `[266]` **Fetih Ejall**: ""We came here with a real offer ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Fetih Ejall**: ""Then we can talk about the deta..." |
| `[271]` | **""I think this is too risky. I'm not willing to lose our progress by cooperating wi..."** | `[266]` **Fetih Ejall**: ""We came here with a real offer ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Fetih Ejall**: ""So you don't intend to pursue t..." |
| `[272]` | **""Calm down. I was just joking.""** | `[256]` **Mansoun Leke**: ""You're starting to show your tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Mansoun Leke**: ""This isn't a joking matter, Mr...." |
| `[273]` | **""Be careful what you say in front of me, Mr. Ejall. You don't want to force me to ..."** | `[256]` **Mansoun Leke**: ""You're starting to show your tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Fetih Ejall**: ""You know that nobody received m..." |
| `[279]` | **""I want to. But I'm not convinced that your offer would make a difference. You hav..."** | `[278]` **Fetih Ejall**: ""So you don't intend to pursue t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Fetih Ejall**: ""Then we can talk about the deta..." |
| `[280]` | **""I apologize but no, I don't.""** | `[278]` **Fetih Ejall**: ""So you don't intend to pursue t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Mansoun Leke**: ""That's very disappointing."" |
| `[290]` | **""Tell me everything about the connection between the Workers' Party and the BFF, a..."** | `[289]` **Mansoun Leke**: ""If you have any questions, feel..."<br>`[334]` **Mansoun Leke**: ""This way, we can start anew.""<br>*(oraz 4 innych węzłów)* | `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false` | *Brak zmian stanu* | `[295]` **Fetih Ejall**: ""As soon as you give the greenli..." |
| `[291]` | **""Tell me about the BFF. Are you certain your intelligence would help us catch all ..."** | `[289]` **Mansoun Leke**: ""If you have any questions, feel..."<br>`[334]` **Mansoun Leke**: ""This way, we can start anew.""<br>*(oraz 4 innych węzłów)* | `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false` | *Brak zmian stanu* | `[305]` **Fetih Ejall**: ""That's on your security forces,..." |
| `[292]` | **""If this becomes public, how do you expect to keep your leadership of the Workers ..."** | `[289]` **Mansoun Leke**: ""If you have any questions, feel..."<br>`[334]` **Mansoun Leke**: ""This way, we can start anew.""<br>*(oraz 4 innych węzłów)* | `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false` | *Brak zmian stanu* | `[330]` **Fetih Ejall**: ""I don't."" |
| `[294]` | **""I'm all clear on your offer. Let's talk about how we deal with the votes.""** | `[289]` **Mansoun Leke**: ""If you have any questions, feel..."<br>`[334]` **Mansoun Leke**: ""This way, we can start anew.""<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Lucian Galade**: ""I believe that according to the..." |
| `[299]` | **""So the party was always connected to the BFF, as the Sollists and the nationalist..."** | `[296]` **Fetih Ejall**: ""I am ready to give you the name..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Fetih Ejall**: ""Well, their claims go to ridicu..." |
| `[300]` | **""But why now?""** | `[296]` **Fetih Ejall**: ""I am ready to give you the name..."<br>`[298]` **Fetih Ejall**: ""Well, their claims go to ridicu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Fetih Ejall**: ""The support for the Workers' Pa..." |
| `[301]` | **""Do you really believe the changes to Article 6 and 7 will go over that well with ..."** | `[296]` **Fetih Ejall**: ""I am ready to give you the name..."<br>`[298]` **Fetih Ejall**: ""Well, their claims go to ridicu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Fetih Ejall**: ""Progress is progress. I think t..." |
| `[308]` | **""Dewlen is already in Antel Rock. If we can get both brothers locked up, the BFF w..."** | `[307]` **Fetih Ejall**: ""What you do with that informati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Fetih Ejall**: ""Exactly."" |
| `[309]` | **""Do you know who their current leader is?""** | `[307]` **Fetih Ejall**: ""What you do with that informati..."<br>`[311]` **Fetih Ejall**: ""Exactly."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Fetih Ejall**: ""Since the arrest of Dewlen Arge..." |
| `[310]` | **""What else do you know about the BFF?""** | `[307]` **Fetih Ejall**: ""What you do with that informati..."<br>`[311]` **Fetih Ejall**: ""Exactly.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Fetih Ejall**: ""According to my sources, a grou..." |
| `[314]` | **""What can you tell me about him?""** | `[313]` **Fetih Ejall**: ""But his brother is the most res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Fetih Ejall**: ""According to my sources, a grou..." |
| `[327]` | **""These are massive, Mr. Ejall. I want you to give all of this intelligence to my t..."** | `[326]` **Fetih Ejall**: ""What's even more striking is a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Fetih Ejall**: ""Of course. As soon as you add t..." |
| `[328]` | **""This entire offer sounds too good to be true. I'm not sure if I'm willing to trus..."** | `[326]` **Fetih Ejall**: ""What's even more striking is a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Fetih Ejall**: ""I'm not a Sordish politician, M..." |
| `[329]` | **""I hope that's not true.""** | `[326]` **Fetih Ejall**: ""What's even more striking is a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Fetih Ejall**: ""It likely is."" |
| `[337]` | **""Just imagining talking to Gloria and Albin about the proposal again is giving me ..."** | `[336]` **Fetih Ejall**: ""We'll give you the BFF and you'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Mansoun Leke**: ""I'm sure you can handle it, Mr...." |
| `[338]` | **""What about the Supreme Court?""** | `[336]` **Fetih Ejall**: ""We'll give you the BFF and you'..."<br>`[341]` **Mansoun Leke**: ""He has a way with words. I thin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Mansoun Leke**: ""What about it? You're already g..." |
| `[339]` | **""I may convince the leaders of the party, but we may want to reach out directly to..."** | `[336]` **Fetih Ejall**: ""We'll give you the BFF and you'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Mansoun Leke**: ""Focus on the leadership and get..." |
| `[347]` | **""Really? Does Petr really have such an influence in the Assembly?""** | `[341]` **Mansoun Leke**: ""He has a way with words. I thin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Mansoun Leke**: ""Of course, Mr. President. He ha..." |
| `[351]` | **""Then I'm sorry. I'm not willing to support your proposal.""** | `[208]` **Fetih Ejall**: ""You cannot dictate that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Fetih Ejall**: ""As expected."" |
| `[360]` | **""Don't worry. We are already working on a proposal to restructure the Special Zone..."** | `[356]` **Fetih Ejall**: ""Governor Bron's racist policies..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true` | *Brak zmian stanu* | `[367]` **Fetih Ejall**: ""I've heard about that. We ask t..." |
| `[361]` | **""Mr. Hawker is using Governor Bron to increase tensions in the country. If there r..."** | `[356]` **Fetih Ejall**: ""Governor Bron's racist policies..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true` | *Brak zmian stanu* | `[366]` **Fetih Ejall**: ""It's great that we think alike ..." |
| `[362]` | **""As much as I'm against the Supreme Court's decision to delay the case, the BFF th..."** | `[356]` **Fetih Ejall**: ""Governor Bron's racist policies..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true` | *Brak zmian stanu* | `[363]` **Fetih Ejall**: ""Hm..."" |
| `[374]` | **""I'm willing to fight for you. I will include these amendments in our reform propo..."** | `[373]` **Fetih Ejall**: ""We're not going to *negotiate* ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_BludishRights_Amendment_Proposa...` | `[393]` **Mansoun Leke**: ""That's great to hear."" |
| `[375]` | **""No need to be so dramatic, Mr. Ejall. Let's work together and finally change the ..."** | `[373]` **Fetih Ejall**: ""We're not going to *negotiate* ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_BludishRights_Amendment_Proposa...` | `[393]` **Mansoun Leke**: ""That's great to hear."" |
| `[376]` | **""I'm sorry, Mr. Ejall, but I don't think I'm willing to take the risk. We can't lo..."** | `[373]` **Fetih Ejall**: ""We're not going to *negotiate* ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Mansoun Leke**: ""That's... a shame."" |
| `[389]` | **""I am not.""** | `[388]` **Fetih Ejall**: ""If you're not willing to suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Fetih Ejall**: ""So you don't intend to pursue t..." |
| `[390]` | **""Let's just calm down and talk about the offer.""** | `[388]` **Fetih Ejall**: ""If you're not willing to suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Lucian Galade**: ""This would give us a significan..." |
| `[397]` | **""Thank you. Together we will achieve a better democracy in Sordland -- for everyon..."** | `[396]` **Fetih Ejall**: ""And I will deliver my promises...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Mansoun Leke**: ""Thank you, Mr. President."" |
| `[398]` | **""Thank you, Mr. Ejall. Together we will eliminate the BFF and set the Bludish peop..."** | `[396]` **Fetih Ejall**: ""And I will deliver my promises...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Fetih Ejall**: ""For a better future."" |
| `[399]` | **""I hope so, Mr. Ejall. Your promises will be needed to convince the party.""** | `[396]` **Fetih Ejall**: ""And I will deliver my promises...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Fetih Ejall**: ""For a better future."" |
| `[400]` | **""This was a very productive and historic meeting, gentlemen. Thank you for coming ..."** | `[396]` **Fetih Ejall**: ""And I will deliver my promises...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Mansoun Leke**: ""Thank you, Mr. President."" |

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
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Meeting with the leaders of the minority..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I were waiting in my office ahead of our talk with the representatives of the Bludish movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> ""Forgive me, sir. As I wasn't involved in the preparation of this proposal, I wanted to make sure I didn't miss anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""Ms. Morgna did a fine job, but I'll be honest. This is t..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian was poring over the proposal Nia had prepared for the amendments to Article 6 and 7. She had completed it with extraordinary speed and with input from the Bludish rights movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""How many times do you need to read that, Lucian?""*)
  - -> `[7]` (*Player: ""Lucian, are you okay? I thought you would have memorized..."*)
  - -> `[8]` (*Player: ""If there's something you want to say to me before the gu..."*)
  - -> `[9]` (*Player_Italic: "Stay silent."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How many times do you need to read that, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: ""Forgive me, sir. As I wasn't involved in the preparation..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian, are you okay? I thought you would have memorized the proposal within minutes of receiving it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""Of course I've read it, sir. But as I wasn't involved in..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If there's something you want to say to me before the guests arrive, this would be the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Since you've already accepted their meeting, I don't thi..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent as Lucian kept reading the proposal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""Ms. Morgna did a fine job, but I'll be honest. This is t..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Of course I've read it, sir. But as I wasn't involved in its preparation, I wanted to make sure I didn't miss anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""Ms. Morgna did a fine job, but I'll be honest. This is t..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Since you've already accepted their meeting, I don't think there's much to say until we hear what they bring up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Lucian Galade: ""Ms. Morgna did a fine job, but I'll be honest. This is t..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""Ms. Morgna did a fine job, but I'll be honest. This is too extreme to pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He pointed to the first page of the proposal."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""Article 6 is modified with additional details on how to acquire or lose Sordish citizenship status. But the main change is the removal of the term 'Sord' -- which I must say is extremely significant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Especially the line: 'Everyone who is bound to the Sordi..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He pointed to the first page of the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: ""Article 6 is modified with additional details on how to ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Especially the line: 'Everyone who is bound to the Sordish state by citizenship is a Sord,' is modified to... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""'Sordish citizenship' refers to all citizens of Sordland..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""'Sordish citizenship' refers to all citizens of Sordland on the basis of equality regardless of language, race, color, gender, political thought, philosophical belief, religion or disability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""It replaces the term 'Sord' with 'Sordish citizen', and ..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""It replaces the term 'Sord' with 'Sordish citizen', and clearly defines what that is. As much as it a good change in theory, I'm not sure if this is worth tanking the whole of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Well, don't stop there. Read the changes to Article 7 as..."*)
  - -> `[18]` (*Player: ""I thought you would support me through this, Lucian.""*)
  - -> `[19]` (*Player: ""Are you advising against changing our proposal?""*)
  - -> `[20]` (*Player: ""What do you mean? Are you showing me your nationalist si..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you would support me through this, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""Of course I will, sir. I'm just doing my job as your adv..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you advising against changing our proposal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""I'll be honest, sir. I don't see how anyone from the USP..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you mean? Are you showing me your nationalist side, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""No, sir. I'm merely stating that I don't see how anyone ..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, don't stop there. Read the changes to Article 7 as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Of course I will, sir. I'm just doing my job as your advisor. I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Well... Nothing's been decided yet.""*)
  - -> `[32]` (*Player: ""I want you to give this a chance, Lucian. I believe this..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'll be honest, sir. I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Well... Nothing's been decided yet.""*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false && BaseGame.Refo..."*)
  - -> `[32]` (*Player: ""I want you to give this a chance, Lucian. I believe this..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false && BaseGame.Refo..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == false && BaseGame.Re..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""The party doesn't support the current proposal anyway. A..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false || BaseGame.Refo..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false || BaseGame.Refo..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == false || BaseGame.Re..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""I didn't get the full party's support for our current pr..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""You might be right. It was already difficult trying to g..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... Nothing's been decided yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Lucian Galade), `[23]` (Lucian Galade), `[31]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""No, sir. I'm merely stating that I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Well... Nothing's been decided yet.""*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == false && BaseGame.Refo..."*)
  - -> `[32]` (*Player: ""I want you to give this a chance, Lucian. I believe this..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want you to give this a chance, Lucian. I believe this is very important for the future, and I need your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Lucian Galade), `[23]` (Lucian Galade), `[31]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The party doesn't support the current proposal anyway. At least we can shine a spotlight on Bludish rights with this.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucian Galade), `[31]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't get the full party's support for our current proposal, either... Honestly, I don't see why we should back off.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false` AND `(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucian Galade), `[31]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""If you say so, sir.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right. It was already difficult trying to get the party to back our initial draft.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false` AND `(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucian Galade), `[31]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""With these additions, it will be nearly impossible.""*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""If you say so, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""With these additions, it will be nearly impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "He flipped to the second page of the proposal."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "He flipped to the second page of the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""The line in Article 7: 'Every Sord is equal before the l..."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""The line in Article 7: 'Every Sord is equal before the law' is modified to...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""'Everyone, regardless of language, race, color, gender, ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Lucian was poring over the proposal Nia had prepared for ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "After I accepted the meeting, Nia informed us of their in..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""'Everyone, regardless of language, race, color, gender, political thought, philosophical belief, religion or disability, is equal before the law'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I can at least see how this change could have been worka..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""What about you, sir? Are you really thinking of adding these to your proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""Of course I am.""*)
  - -> `[48]` (*Player: ""Not seriously, no. I just want to test the waters.""*)
  - -> `[49]` (*Player: ""That really depends on how today's meeting goes.""*)
  - -> `[50]` (*Player: ""Tell me straight, Lucian. What are our chances of passin..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""I'll be honest.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not seriously, no. I just want to test the waters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""Good to know.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That really depends on how today's meeting goes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""I'll be honest.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me straight, Lucian. What are our chances of passing this proposal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""I'll be honest.""*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Livia stepped in and informed us that the representatives..."*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""I'll be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""I doubt Mr. Leke and Mr. Ejall can provide us with anyth..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""I doubt Mr. Leke and Mr. Ejall can provide us with anything tangible that will change the minds of the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: ""Unless something extraordinary happens, the addition of ..."*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""Unless something extraordinary happens, the addition of these changes would doom our proposal for failure. There's no question about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Livia stepped in and informed us that the representatives..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "After I accepted the meeting, Nia informed us of their intention to convince us to add further changes to our constitutional amendment proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Lucian didn't seem too happy about my decision to put pre..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I can at least see how this change could have been workable, if it wasn't coupled with the first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""My general advice is not to change the focus of our cons..."*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""My general advice is not to change the focus of our constitutional amendments by messing with these articles. Our priority should be reforming the governmental structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""What about you, sir? Are you really thinking of adding t..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Livia stepped in and informed us that the representatives had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "With my assent, she opened the door to let Mansoun Leke a..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "With my assent, she opened the door to let Mansoun Leke and Fetih Ejall inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Manson was the spokesperson of the independents and the f..."*)

### Węzeł `[60]`
Mówca: **Fetih Ejall**
> ""It is great to finally meet with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Mansoun Leke: ""Thanks for having us.""*)

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> ""Thanks for having us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""It's good to see you, gentlemen. Please, have a seat.""*)
  - -> `[90]` (*Player: ""Good morning, Mr. Leke and Mr. Ejall. Why don't we take ..."*)
  - -> `[91]` (*Player: ""Barilbar zinjar, my Bludish brothers. Please have a seat.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't seem too happy about this meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""Forgive me, sir. I just think we are in a precarious sit..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think they are here to ask us to change Articles 6 and 7?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: ""There's no question about it, sir.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If there's something you want to tell me before the guests arrive, now would be the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: ""Forgive me, sir. I just think we are in a precarious sit..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I waited in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: ""Sir. I believe your statement with Mr. Ricter put us in ..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "But since our statement with the PFJP, there were rumors that we would also include these changes in our proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""You don't seem too happy about this meeting.""*)
  - -> `[63]` (*Player: ""Do you think they are here to ask us to change Articles ..."*)
  - -> `[64]` (*Player: ""If there's something you want to tell me before the gues..."*)
  - -> `[65]` (*Player_Italic: "Stay silent."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Forgive me, sir. I just think we are in a precarious situation at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""You already publicly criticized those articles for being..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""There's no question about it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""You already publicly criticized those articles for being..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Lucian didn't seem too happy about my decision to put pressure on the Court by highlighting the discrimination in Article 6 and 7 of the Sordish Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "But since our statement with the PFJP, there were rumors ..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""You already publicly criticized those articles for being discriminatory against the Bludish people. They'll expect you to act on your words now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""But I advise against altering our proposal at the last m..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""But I advise against altering our proposal at the last minute. Especially with changes that would never be accepted by our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""With that said... If you don't act on this, you risk losing all the Bludish support you've gained so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""What's your advice, then?""*)
  - -> `[75]` (*Player: ""If we have the opportunity to change those articles as w..."*)
  - -> `[76]` (*Player: ""Do you think there's no way to pass changes to Articles ..."*)
  - -> `[77]` (*Player: ""Don't worry. I don't intend to change our current propos..."*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Sir. I believe your statement with Mr. Ricter put us in a precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""You already publicly criticized those articles for being..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's your advice, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""As much as I'm troubled by the possibility of losing Blu..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we have the opportunity to change those articles as well, we have to seize it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: ""If you say so, sir.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think there's no way to pass changes to Articles 6 and 7?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""It's true that Mr. Ersen's case gathered a lot of sympat..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I don't intend to change our current proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""Good to know.""*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""My general advice is not to lose focus of our constituti..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""It's true that Mr. Ersen's case gathered a lot of sympathy, even from the USP...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""...But I must say it's not enough to pass the amendments..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""...But I must say it's not enough to pass the amendments. Not unless something extraordinary happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""My general advice is not to lose focus of our constituti..."*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""If you say so, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Livia stepped in and informed us that the representatives..."*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""As much as I'm troubled by the possibility of losing Bludish support, we cannot agree to change our proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: ""My general advice is not to lose focus of our constituti..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""My general advice is not to lose focus of our constitutional amendments by messing with these articles. Our priority should be reforming the governmental structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Livia stepped in and informed us that the representatives..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Livia stepped in and informed us that the representatives had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "With my assent, she opened the door to let Mansoun Leke a..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "We shook hands and took our seats on the two sofas facing each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Good morning, Mr. Ejall and Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Mansoun Leke: ""Good morning.""*)

### Węzeł `[87]`
Mówca: **Mansoun Leke**
> ""Good morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Fetih Ejall: ""Barilbar zinjar. Healthy mornings to you.""*)

### Węzeł `[88]`
Mówca: **Fetih Ejall**
> ""Barilbar zinjar. Healthy mornings to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Fetih Ejall: ""It is great to finally meet with you, Mr. President.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see you, gentlemen. Please, have a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "We shook hands and took our seats on the two sofas facing..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good morning, Mr. Leke and Mr. Ejall. Why don't we take a seat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "We shook hands and took our seats on the two sofas facing..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Barilbar zinjar, my Bludish brothers. Please have a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Mansoun and Fetih exchanged puzzled looks. Lucian raised ..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Mansoun and Fetih exchanged puzzled looks. Lucian raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "After a few seconds of awkward silence, we shook hands an..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "After a few seconds of awkward silence, we shook hands and took our seats on the two sofas facing each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[94]`
Mówca: **Fetih Ejall**
> ""You must know why we're here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Fetih Ejall: ""First of all, we thank you for standing with Ishval Erse..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Fetih Ejall: ""You know why we're here, Mr. President.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Fetih Ejall: ""You must know why we're here, Mr. President.""*)

### Węzeł `[98]`
Mówca: **Fetih Ejall**
> ""You know why we're here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Fetih Ejall: ""We must first thank you for pushing for changes to Artic..."*)

### Węzeł `[99]`
Mówca: **Fetih Ejall**
> ""We must first thank you for pushing for changes to Article 6 and 7. This has been a lifelong quest of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Mansoun Leke: ""Thank you for your support of Mr. Ersen and the rights o..."*)

### Węzeł `[100]`
Mówca: **Mansoun Leke**
> ""Thank you for your support of Mr. Ersen and the rights of Bludish people in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[101]`
Mówca: **Fetih Ejall**
> ""First of all, we thank you for standing with Ishval Ersen and the rights of the Bludish people of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[102]`
Mówca: **Fetih Ejall**
> ""But know this. If you're *really* willing to fight for the rights of the Bludish people, we will champion you to the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""I promise you, I am willing to fight for your rights unt..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[110]` (*Player: ""That's great to know. Thank you, Mr. Ejall.""*)
  - -> `[106]` (*Player: ""Why don't we jump straight to the point?""*)

### Węzeł `[103]`
Mówca: **Fetih Ejall**
> ""We never would have expected such statements of support coming from a USP president. You have our appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Fetih Ejall: ""But know this. If you're *really* willing to fight for t..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I promise you, I am willing to fight for your rights until we achieve true equality between Sords and Bluds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Fetih Ejall: ""Ett'a. Of course.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I've already shown you that my intentions are pure by involving you in our proposal.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Mansoun Leke: ""The addition of these changes to your proposal hasn't be..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't we jump straight to the point?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Fetih Ejall: ""Ett'a. Of course.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""I think I've already shown you that my intentions are pu..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to know. Thank you, Mr. Ejall.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Fetih Ejall: ""Ett'a. Of course.""*)

### Węzeł `[111]`
Mówca: **Mansoun Leke**
> ""The addition of these changes to your proposal hasn't been announced yet, Mr. President. We hope to see you act on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[112]`
Mówca: **Fetih Ejall**
> ""Ett'a. Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Fetih Ejall: ""I believe we made good headway with Ms. Morgna on the pr..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Fetih Ejall: ""With the support of Mr. Ricter and the PFJP, we have wor..."*)

### Węzeł `[116]`
Mówca: **Fetih Ejall**
> ""I believe we made good headway with Ms. Morgna on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Fetih Ejall: ""Since it was your intention to start this process in the..."*)

### Węzeł `[117]`
Mówca: **Fetih Ejall**
> ""Since it was your intention to start this process in the first place, I'd like to believe that you'll add these amendments to your reform package soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Fetih Ejall: ""If we're already aligned and there's nothing to discuss ..."*)

### Węzeł `[118]`
Mówca: **Fetih Ejall**
> ""If we're already aligned and there's nothing to discuss about the proposal, we can immediately talk about how we can pass the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""I went over the changes already and I approve of them. L..."*)
  - -> `[126]` (*Player: ""Before we discuss our strategy, I'd like to go over the ..."*)
  - -> `[127]` (*Player: ""I'll be honest. It is still not guaranteed that we'll be..."*)
  - -> `[123]` (*Player: ""As much as I support your cause, the timing of this may ..."*)

### Węzeł `[119]`
Mówca: **Fetih Ejall**
> ""With the support of Mr. Ricter and the PFJP, we have worked on a proposal to change the articles you singled out as discriminatory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Fetih Ejall: ""It was a bold move openly attacking the Sollist structur..."*)

### Węzeł `[120]`
Mówca: **Fetih Ejall**
> ""It was a bold move openly attacking the Sollist structure of this country, so I'd like to believe that we share the same sentiment about reforming our constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Fetih Ejall: ""If you're willing to listen, we can explain the details ..."*)

### Węzeł `[121]`
Mówca: **Fetih Ejall**
> ""If you're willing to listen, we can explain the details to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""I'm listening.""*)
  - -> `[124]` (*Player: ""You have the floor.""*)
  - -> `[123]` (*Player: ""As much as I support your cause, the timing of this may ..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Fetih Ejall: ""Mr. Leke, could you read the proposed changes for us?""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I support your cause, the timing of this may not be the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Fetih Ejall), `[121]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Fetih Ejall: ""No. On the contrary, this is the perfect time.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have the floor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Fetih Ejall: ""Mr. Leke, could you read the proposed changes for us?""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I went over the changes already and I approve of them. Let's talk about how we can actually pass them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we discuss our strategy, I'd like to go over the changes together with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Fetih Ejall: ""Great. Mr. Leke, could you read the proposed changes?""*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. It is still not guaranteed that we'll be adding these changes to our reform package.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Fetih Ejall: ""You didn't hear our offer yet, Mr. President... Or do yo..."*)

### Węzeł `[128]`
Mówca: **Fetih Ejall**
> ""Mr. Leke, could you read the proposed changes for us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Mansoun took out a stack of papers and started reading."*)

### Węzeł `[129]`
Mówca: **Fetih Ejall**
> ""Great. Mr. Leke, could you read the proposed changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Mansoun took out a stack of papers and started reading."*)

### Węzeł `[130]`
Mówca: **Mansoun Leke**
> ""The ethnic term 'Sord' will be removed from the constitution. We will remove the lines that define the citizens of Sordland by nationality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Mansoun Leke: ""Firstly, the line 'Everyone who is bound to the Sordish ..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Mansoun took out a stack of papers and started reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Mansoun Leke: ""The ethnic term 'Sord' will be removed from the constitu..."*)

### Węzeł `[132]`
Mówca: **Mansoun Leke**
> ""Firstly, the line 'Everyone who is bound to the Sordish state by citizenship is a Sord' will be removed entirely from Article 6.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Mansoun Leke: ""As for the following lines in the rest of the article, t..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucian Galade: ""And not only them. Do you really want to throw away your..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""With that said... If you don't act on this, you risk los..."*)

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""And not only them. Do you really want to throw away your cooperation with the NFP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""I don't think we should lose the focus of our reforms.""*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""I don't think we should lose the focus of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""With that said... If you don't act on this, you risk los..."*)

### Węzeł `[138]`
Mówca: **Mansoun Leke**
> ""As for the following lines in the rest of the article, the term 'Sord' will be replaced with 'citizen of Sordland'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Mansoun Leke: ""And the line in Article 7: 'Every Sord is equal before t..."*)

### Węzeł `[139]`
Mówca: **Mansoun Leke**
> ""And the line in Article 7: 'Every Sord is equal before the law' will be modified to...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Mansoun Leke: ""'Everyone, regardless of language, race, color, gender, ..."*)

### Węzeł `[140]`
Mówca: **Mansoun Leke**
> ""'Everyone, regardless of language, race, color, gender, political thought, philosophical belief, religion or disability, is equal before the law'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[141]` (*Player: ""Gentlemen. I'm all with you on this.""*)
  - -> `[142]` (*Player: ""These are very significant and necessary changes. But th..."*)
  - -> `[143]` (*Player: ""As much as I agree with these changes in principle, I do..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gentlemen. I'm all with you on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Fetih Ejall: ""Good to know, Mr. President.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are very significant and necessary changes. But they should be the target of our next reforms. They don't have a place in our current reform package.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Mr. President is right. Given the current political real..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I agree with these changes in principle, I don't have a sound plan to pass them in practice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Mr. President is right. Given the current political real..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you crazy? This proposal will be crushed in an instant.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[140]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: ""Mr. President is right. Given the current political real..."*)

### Węzeł `[145]`
Mówca: **Fetih Ejall**
> ""No. On the contrary, this is the perfect time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Fetih Ejall: ""Governor Bron's ultranationalist policies are now known ..."*)

### Węzeł `[146]`
Mówca: **Fetih Ejall**
> ""Governor Bron's ultranationalist policies are now known all across Sordland thanks to Ishval Ersen. And the support from the presidency has given people hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Fetih Ejall: ""Our polls show that the Workers Party will definitely ma..."*)

### Węzeł `[147]`
Mówca: **Fetih Ejall**
> ""Our polls show that the Workers Party will definitely make it to the Assembly in the next elections. Anybody can see the Old Guard is scared of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Mansoun Leke: ""And with the public opinion behind your constitutional c..."*)

### Węzeł `[148]`
Mówca: **Mansoun Leke**
> ""And with the public opinion behind your constitutional changes, now is the best opportunity to include the Bludish community in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lucian Galade: ""The Bludish community was never excluded during the prep..."*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> ""You might be correct about the sharp change in the public perspective, but I agree with President Rayne. The timing of this is not right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Fetih Ejall: ""Let us at least explain our proposal, Mr. Galade. Mr. Pr..."*)

### Węzeł `[150]`
Mówca: **Fetih Ejall**
> ""Let us at least explain our proposal, Mr. Galade. Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Fetih Ejall: ""Mr. Leke, could you read the proposed changes for us?""*)

### Węzeł `[151]`
Mówca: **Fetih Ejall**
> ""Good to know, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""I must point out that given our current political realit..."*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Mr. President is right. Given the current political reality, adding these to our proposal would eliminate the possibility of any reform being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""I'm sure you understand. We need a realistic proposal. T..."*)

### Węzeł `[153]`
Mówca: **Lucian Galade**
> ""If we can't reform the judiciary and the amendment procedures, what good does it do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Mansoun Leke: ""If even the leadership of the governing party doesn't be..."*)

### Węzeł `[154]`
Mówca: **Mansoun Leke**
> ""If even the leadership of the governing party doesn't believe in the possibility of change, of course nobody else will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Mansoun Leke: ""But this is a fallacy. If you don't support us because o..."*)

### Węzeł `[155]`
Mówca: **Mansoun Leke**
> ""But this is a fallacy. If you don't support us because of the existence of people who are against us, how do we even start fixing the problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Mansoun Leke: ""It's time this country stops pushing the Bludish people ..."*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""I'm sure you understand. We need a realistic proposal. This is the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: ""If we can't reform the judiciary and the amendment proce..."*)

### Węzeł `[157]`
Mówca: **Fetih Ejall**
> ""Ett'a. And that deadlock is what's created the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""The liberation movement?""*)
  - -> `[159]` (*Player: ""You sound like you're trying to justify the actions of t..."*)

### Węzeł `[158]`
Mówca: **Mansoun Leke**
> ""It's time this country stops pushing the Bludish people to the corners of society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Fetih Ejall: ""Ett'a. And that deadlock is what's created the liberatio..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You sound like you're trying to justify the actions of the secessionists. I hope you're not referring to the BFF, Mr. Ejall.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Fetih Ejall: ""You know what I'm referring to, Mr. President.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The liberation movement?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Fetih Ejall: ""Exactly. As long as the government creates a deadlock an..."*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""I must point out that given our current political reality, adding these to our proposal may eliminate the possibility of any reform being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""I'm sure you understand. We need a realistic proposal. T..."*)

### Węzeł `[162]`
Mówca: **Fetih Ejall**
> ""You didn't hear our offer yet, Mr. President... Or do you have a problem with the proposal's contents?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""Okay, let's talk strategy. Let's hear your offer.""*)
  - -> `[164]` (*Player: ""Let's go over those contents one more time.""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Okay, let's talk strategy. Let's hear your offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's go over those contents one more time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Fetih Ejall: ""Sure. Mr. Leke, could you read the proposed changes?""*)

### Węzeł `[165]`
Mówca: **Fetih Ejall**
> ""Sure. Mr. Leke, could you read the proposed changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Mansoun took out a stack of papers and started reading."*)

### Węzeł `[166]`
Mówca: **Fetih Ejall**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Fetih Ejall: ""I know you are rightfully wondering how we can gather a ..."*)

### Węzeł `[167]`
Mówca: **Fetih Ejall**
> ""Exactly. As long as the government creates a deadlock and doesn't offer solutions, the Bludish people will have to do what it takes to defend themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Fetih Ejall: ""And as long as you label those people who fight for thei..."*)

### Węzeł `[168]`
Mówca: **Fetih Ejall**
> ""You know what I'm referring to, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Fetih Ejall: ""As long as the government creates a deadlock and doesn't..."*)

### Węzeł `[169]`
Mówca: **Fetih Ejall**
> ""As long as the government creates a deadlock and doesn't offer solutions, the Bludish people will have to do what it takes to defend themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Fetih Ejall: ""And as long as you label those people who fight for thei..."*)

### Węzeł `[170]`
Mówca: **Fetih Ejall**
> ""And as long as you label those people who fight for their rights as the villains, you are deepening the problem and turning it into a cycle of violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""So the only side at fault here is the government?""*)
  - -> `[171]` (*Player: ""Are you really trying to justify the actions of the BFF ..."*)
  - -> `[173]` (*Player: ""I knew you were in cahoots with the terrorists.""*)
  - -> `[174]` (*Player: ""You are right. Many mistakes were made to the detriment ..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really trying to justify the actions of the BFF right now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Fetih Ejall: ""I'm not trying to justify anything.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So the only side at fault here is the government?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Fetih Ejall: ""No. I didn't say that.""*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew you were in cahoots with the terrorists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Fetih Ejall: ""I'm not going to reply to that.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are right. Many mistakes were made to the detriment of the Bludish people. We can't continue like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Fetih Ejall: ""I'm glad you agree.""*)

### Węzeł `[175]`
Mówca: **Fetih Ejall**
> ""I'm not trying to justify anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Fetih Ejall: ""What I'm saying is that you can't ignore the background ..."*)

### Węzeł `[176]`
Mówca: **Fetih Ejall**
> ""I'm not going to reply to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Fetih Ejall: ""What I'm saying is that you can't ignore the background ..."*)

### Węzeł `[177]`
Mówca: **Fetih Ejall**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: ""Since we're already on the same page, we should talk abo..."*)
  - -> `[192]` (*Player: ""But the Bludish movement must properly distance itself f..."*)

### Węzeł `[178]`
Mówca: **Fetih Ejall**
> ""No. I didn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Fetih Ejall: ""What I'm saying is that you can't ignore the background ..."*)

### Węzeł `[179]`
Mówca: **Fetih Ejall**
> ""What I'm saying is that you can't ignore the background of how these movements came to be. Nothing appeared out of thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: ""That does sound suspiciously like a defense of the BFF m..."*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""That does sound suspiciously like a defense of the BFF militants. Why are you refraining from using their name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Mansoun Leke: ""You're not even listening, Mr. Galade. Are you looking f..."*)

### Węzeł `[181]`
Mówca: **Mansoun Leke**
> ""You're not even listening, Mr. Galade. Are you looking for reasons to prosecute us too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""They're right, Lucian. The Sordish state isn't entirely ..."*)
  - -> `[182]` (*Player: ""No, Mr. Leke. Please calm down.""*)
  - -> `[184]` (*Player: ""But we are listening.""*)
  - -> `[185]` (*Player: ""I'm not looking for reasons, Mr. Leke. But if you give m..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Mr. Leke. Please calm down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Fetih Ejall: ""Gentlemen. Let's get one thing straight here.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're right, Lucian. The Sordish state isn't entirely innocent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But we are listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Fetih Ejall: ""Gentlemen. Let's get one thing straight here.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""I'm not looking for reasons, Mr. Leke. But if you give me one, you'll face justice like everyone else.""]** — Mówca: **Player**
> ""I'm not looking for reasons, Mr. Leke. But if you give me o--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Fetih Ejall: ""Fara!? Don't finish that sentence, Mr. President.""*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Mansoun Leke: ""Then why don't we talk about our offer and plan our moves?""*)

### Węzeł `[187]`
Mówca: **Fetih Ejall**
> ""Fara!? Don't finish that sentence, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Fetih Ejall: ""We will not sit here smiling if you're going to start th..."*)

### Węzeł `[188]`
Mówca: **Fetih Ejall**
> ""We will not sit here smiling if you're going to start throwing threats at us. Lok geduhe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "He stood up."*)

### Węzeł `[189]`
Mówca: **Fetih Ejall**
> ""Gentlemen. Let's get one thing straight here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Fetih Ejall: ""Are you willing to support our rights? Or did you approa..."*)

### Węzeł `[190]`
Mówca: **Fetih Ejall**
> ""Are you willing to support our rights? Or did you approach us for propaganda reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""Yes, Mr. Ejall. I'm willing to support you.""*)
  - -> `[199]` (*Player: ""I want to support this proposal, but you have to convinc..."*)
  - -> `[200]` (*Player: ""I thought we could find other common ground.""*)
  - -> `[201]` (*Player: ""No. I'm not willing to support your proposal.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Since we're already on the same page, we should talk about how realistic it is to pass these changes instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But the Bludish movement must properly distance itself from the secessionists. Otherwise we will see no progress on these issues.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Fetih Ejall: ""We will, Mr. President. If you give us your full support..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""All right.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[194]`
Mówca: **Fetih Ejall**
> ""We will, Mr. President. If you give us your full support, we will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Mansoun Leke: ""Then let's talk about our offer and plan our moves.""*)

### Węzeł `[195]`
Mówca: **Mansoun Leke**
> ""Then let's talk about our offer and plan our moves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[196]`
Mówca: **Mansoun Leke**
> ""Then why don't we talk about our offer and plan our moves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""All right.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Mr. Ejall. I'm willing to support you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want to support this proposal, but you have to convince me that you have a sound plan to pass it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Fetih Ejall), `[208]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought we could find other common ground.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Fetih Ejall: ""You cannot dictate that.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. I'm not willing to support your proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Fetih Ejall: ""As expected.""*)

### Węzeł `[202]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""Mr. Ejall... Sit down, please.""*)
  - -> `[204]` (*Player: ""You're forgetting your place.""*)
  - -> `[207]` (*Player: ""Please repeat that in proper Sordish.""*)
  - -> `[205]` (*Player: ""Stop throwing Bludish words around, Mr. Ejall. I hope fo..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Ejall... Sit down, please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Fetih Ejall: ""I don't see why I should stay if you're not willing to s..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're forgetting your place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator), `[388]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Fetih Ejall: ""I'm not going to indulge your power trip, Mr. Rejn!""*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Stop throwing Bludish words around, Mr. Ejall. I hope for your sake that you didn't say anything bad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Fetih Ejall: ""I'm not going to indulge your power trip, Mr. Rejn!""*)

### Węzeł `[206]`
Mówca: **Fetih Ejall**
> ""I'm not going to indulge your power trip, Mr. Rejn!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "On his gesture, Mansoun also stood up."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please repeat that in proper Sordish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Fetih Ejall: ""I'm not going to indulge your power trip, Mr. Rejn!""*)

### Węzeł `[208]`
Mówca: **Fetih Ejall**
> ""You cannot dictate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""I want to support this proposal, but you have to convinc..."*)
  - -> `[351]` (*Player: ""Then I'm sorry. I'm not willing to support your proposal.""*)

### Węzeł `[209]`
Mówca: **Fetih Ejall**
> ""As expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""There is nothing left to discuss..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""All right.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[211]`
Mówca: **Fetih Ejall**
> ""I don't see why I should stay if you're not willing to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""Look. I'm willing to support you, but I don't believe we..."*)
  - -> `[213]` (*Player: ""Why don't we all just calm down and hear your plan?""*)
  - -> `[214]` (*Player: ""Did you not learn common courtesy?""*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look. I'm willing to support you, but I don't believe we can succeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Mansoun Leke: ""Please sit down, Mr. Ejall. Let's talk about our plans. ..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't we all just calm down and hear your plan?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Mansoun Leke: ""Please sit down, Mr. Ejall. Let's talk about our plans. ..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Did you not learn common courtesy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Fetih Ejall: ""No, I didn't. I'm a *Blud*, after all.""*)

### Węzeł `[215]`
Mówca: **Fetih Ejall**
> ""No, I didn't. I'm a *Blud*, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Fetih Ejall: ""I'm not going to indulge your power trip, Mr. Rejn!""*)

### Węzeł `[216]`
Mówca: **Narrator**
> "On his gesture, Mansoun also stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Mansoun Leke: ""Well... Nevertheless. Thank you for inviting us, Mr. Pre..."*)

### Węzeł `[217]`
Mówca: **Mansoun Leke**
> ""Well... Nevertheless. Thank you for inviting us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "He sighed and shook my hand."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "He sighed and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "They both stood up and left the office afterwards."*)

### Węzeł `[219]`
Mówca: **Mansoun Leke**
> ""Please sit down, Mr. Ejall. Let's talk about our plans. I believe Mr. President can still change his mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "He sighed and sat down again."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""All right.""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Fetih Ejall: ""All right.""*)

### Węzeł `[221]`
Mówca: **Fetih Ejall**
> ""I know you are rightfully wondering how we can gather a majority in both the Assembly and the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Fetih Ejall: ""In the past, Mr. Ricter and Ms. Suheil supported us grea..."*)

### Węzeł `[222]`
Mówca: **Fetih Ejall**
> ""If you can gather the support of the USP, the Assembly won't be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)

### Węzeł `[223]`
Mówca: **Lucian Galade**
> ""The Bludish community was never excluded during the preparation process. However, the fact is that there is no major Bludish presence in the Assembly. And we can't simply bring a party that's not elected into the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: ""You might be correct about the sharp change in the publi..."*)

### Węzeł `[224]`
Mówca: **Fetih Ejall**
> ""In the past, Mr. Ricter and Ms. Suheil supported us greatly in this endeavor, and I believe the PFJP would get behind our proposed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Fetih Ejall: ""If you can gather the support of the USP, the Assembly w..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""Gathering the support of the USP is the real problem here.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucian Galade: ""I hope you're aware that Mr. Ricter has already announce..."*)

### Węzeł `[228]`
Mówca: **Lucian Galade**
> ""I hope you're aware that Mr. Ricter has already announced that the PFJP will not vote for our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[229]`
Mówca: **Mansoun Leke**
> ""Since Ms. Morgna's team involved us in the proposal, the PFJP leadership has been reaching out to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Mansoun Leke: ""You've put them under a lot of pressure now. They've bee..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Mansoun Leke: ""Since Ms. Morgna's team involved us in the proposal, the..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[233]`
Mówca: **Fetih Ejall**
> ""It's true. If you include our changes in your reforms, the tide can still be turned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""That's good to know.""*)
  - -> `[243]` (*Player: ""I wouldn't count on the PFJP too much.""*)
  - -> `[245]` (*Player: ""Well, but that doesn't help me with convincing the USP.""*)

### Węzeł `[234]`
Mówca: **Mansoun Leke**
> ""You've put them under a lot of pressure now. They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Fetih Ejall: ""It's true. If you include our changes in your reforms, t..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Mansoun Leke: ""You've already made a statement together, denouncing Art..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Mansoun Leke: ""They've been campaigning for these changes themselves, a..."*)

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""You've already made a statement together, denouncing Article 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Mansoun Leke: ""This would put them under a lot of pressure. They've bee..."*)

### Węzeł `[239]`
Mówca: **Mansoun Leke**
> ""This would put them under a lot of pressure. They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Fetih Ejall: ""It's true. If you include our changes in your reforms, t..."*)

### Węzeł `[240]`
Mówca: **Mansoun Leke**
> ""They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Mansoun Leke: ""I think Mr. Ricter wouldn't risk that.""*)

### Węzeł `[241]`
Mówca: **Mansoun Leke**
> ""I think Mr. Ricter wouldn't risk that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Fetih Ejall: ""It's true. If you include our changes in your reforms, t..."*)

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""Gathering the support of the USP is the real problem here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucian Galade: ""Do you think the conservative MPs will have a sudden cha..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't count on the PFJP too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""Gathering the support of the USP is the real problem here.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good to know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""Gathering the support of the USP is the real problem here.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, but that doesn't help me with convincing the USP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: ""Gathering the support of the USP is the real problem here.""*)

### Węzeł `[246]`
Mówca: **Lucian Galade**
> ""Do you think the conservative MPs will have a sudden change of heart?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Fetih Ejall: ""There is only one thing that can get them to work with us.""*)

### Węzeł `[247]`
Mówca: **Fetih Ejall**
> ""There is only one thing that can get them to work with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Fetih Ejall: ""If Mr. Hawker and his puppets are looking to put an end ..."*)

### Węzeł `[248]`
Mówca: **Fetih Ejall**
> ""If Mr. Hawker and his puppets are looking to put an end to the liberation movement, I'm willing to cooperate with them and give them what they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Lucian's eyes widened for a second."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Lucian's eyes widened for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Lucian Galade: ""What are you saying, Mr. Ejall?""*)

### Węzeł `[250]`
Mówca: **Lucian Galade**
> ""What are you saying, Mr. Ejall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Fetih Ejall: ""If you include these changes in your proposal, I will gi..."*)

### Węzeł `[251]`
Mówca: **Fetih Ejall**
> ""If you include these changes in your proposal, I will give you the best bargaining chip you can get. Intelligence about the BFF and the locations of its leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""Are you absolutely serious, Mr. Ejall?""*)
  - -> `[252]` (*Player: ""Intriguing. So you really are a traitor to your cause.""*)
  - -> `[254]` (*Player: ""How do we know the Old Guard will be convinced by that?""*)
  - -> `[255]` (*Player: ""Are you really admitting your direct ties to the BFF in ..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Intriguing. So you really are a traitor to your cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Fetih Ejall: ""Watch what you're saying, Mr. President. I came to you w..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you absolutely serious, Mr. Ejall?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Fetih Ejall: ""Yes.""*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How do we know the Old Guard will be convinced by that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Mansoun Leke: ""You can't *know* everything, Mr. President.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really admitting your direct ties to the BFF in front of the president?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Mansoun Leke: ""You're starting to show your true colors, Mr. Rayne.""*)

### Węzeł `[256]`
Mówca: **Mansoun Leke**
> ""You're starting to show your true colors, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: ""Calm down. I was just joking.""*)
  - -> `[273]` (*Player: ""Be careful what you say in front of me, Mr. Ejall. You d..."*)

### Węzeł `[257]`
Mówca: **Fetih Ejall**
> ""Watch what you're saying, Mr. President. I came to you with respect, I demand the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""This would give us a significant edge, of course. But I ..."*)

### Węzeł `[258]`
Mówca: **Fetih Ejall**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""This would give us a significant edge, of course. But I ..."*)

### Węzeł `[259]`
Mówca: **Mansoun Leke**
> ""You can't *know* everything, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Mansoun Leke: ""This is what we offer because we believe in it. An end t..."*)

### Węzeł `[260]`
Mówca: **Mansoun Leke**
> ""This is what we offer because we believe in it. An end to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""This would give us a significant edge, of course. But I ..."*)

### Węzeł `[261]`
Mówca: **Lucian Galade**
> ""This would give us a significant edge, of course. But I still don't think it would be enough on its own. Besides, can you really deliver on your claims?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Fetih Ejall: ""I thought it was you who wanted to add this reform and i..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Fetih Ejall: ""I thought the administration was behind this reform.""*)

### Węzeł `[265]`
Mówca: **Fetih Ejall**
> ""I thought it was you who wanted to add this reform and invited us to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Fetih Ejall: ""We came here with a real offer and you keep questioning ..."*)

### Węzeł `[266]`
Mówca: **Fetih Ejall**
> ""We came here with a real offer and you keep questioning us. What's with this sudden change of attitude?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""If you can promise us the BFF, maybe we can make this wo..."*)
  - -> `[269]` (*Player: ""You're forgetting something. We never promised you anyth..."*)
  - -> `[270]` (*Player: ""That's Lucian's personal opinion, Mr. Ejall. There is no..."*)
  - -> `[271]` (*Player: ""I think this is too risky. I'm not willing to lose our p..."*)

### Węzeł `[267]`
Mówca: **Fetih Ejall**
> ""I thought the administration was behind this reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Fetih Ejall: ""We came here with a real offer and you keep questioning ..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you can promise us the BFF, maybe we can make this work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Fetih Ejall: ""That I promise.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're forgetting something. We never promised you anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Fetih Ejall: ""So you don't intend to pursue these reforms at all?""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's Lucian's personal opinion, Mr. Ejall. There is no sudden change. I am willing to support you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Fetih Ejall: ""Then we can talk about the details.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think this is too risky. I'm not willing to lose our progress by cooperating with you. No offense intended.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Fetih Ejall: ""So you don't intend to pursue these reforms at all?""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Calm down. I was just joking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Mansoun Leke: ""This isn't a joking matter, Mr. President.""*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Be careful what you say in front of me, Mr. Ejall. You don't want to force me to start an investigation on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Fetih Ejall: ""You know that nobody received more death threats than me..."*)

### Węzeł `[274]`
Mówca: **Mansoun Leke**
> ""This isn't a joking matter, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Fetih Ejall: ""So, what about our plan and offer?""*)

### Węzeł `[275]`
Mówca: **Fetih Ejall**
> ""So, what about our plan and offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""This would give us a significant edge, of course. But I ..."*)

### Węzeł `[276]`
Mówca: **Fetih Ejall**
> ""That I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "He straightened his posture."*)

### Węzeł `[277]`
Mówca: **Fetih Ejall**
> ""Then we can talk about the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Fetih Ejall: ""As I said, I'm offering the Sollists an end to the BFF.""*)

### Węzeł `[278]`
Mówca: **Fetih Ejall**
> ""So you don't intend to pursue these reforms at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: ""I want to. But I'm not convinced that your offer would m..."*)
  - -> `[280]` (*Player: ""I apologize but no, I don't.""*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want to. But I'm not convinced that your offer would make a difference. You have to give me more details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Fetih Ejall: ""Then we can talk about the details.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I apologize but no, I don't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Mansoun Leke: ""That's very disappointing.""*)

### Węzeł `[281]`
Mówca: **Fetih Ejall**
> ""There is nothing left to discuss here. We should take our leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "He stood up."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""There is nothing left to discuss h..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Fetih Ejall: ""There is nothing left to discuss here. We should take ou..."*)

### Węzeł `[283]`
Mówca: **Mansoun Leke**
> ""That's very disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Fetih Ejall: ""There is nothing left to discuss here. We should take ou..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "He straightened his posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Fetih Ejall: ""Then we can talk about the details.""*)

### Węzeł `[285]`
Mówca: **Fetih Ejall**
> ""As I said, I'm offering the Sollists an end to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Fetih Ejall: ""I will give you everything I know and can gather. Even t..."*)

### Węzeł `[286]`
Mówca: **Fetih Ejall**
> ""But to you, I'm offering the possibility to become the president who finished off the secessionists. The president who started a new age in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Fetih Ejall: ""Think of the popularity you'll enjoy. This would be a hu..."*)

### Węzeł `[287]`
Mówca: **Fetih Ejall**
> ""Think of the popularity you'll enjoy. This would be a huge boost for the administration, and it will also help your standing with traditional Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Fetih Ejall: ""And if we change the constitution in the process, the Bl..."*)

### Węzeł `[288]`
Mówca: **Fetih Ejall**
> ""And if we change the constitution in the process, the Bludish community will be applauding you with all their might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Mansoun Leke: ""If you have any questions, feel free to ask.""*)

### Węzeł `[289]`
Mówca: **Mansoun Leke**
> ""If you have any questions, feel free to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "Hub_BludishRights_BFF"*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me everything about the connection between the Workers' Party and the BFF, and why you are suddenly so keen on selling them out.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false`
- **Kontekst wejściowy (poprzednik):** `[289]` (Mansoun Leke), `[334]` (Mansoun Leke), `[304]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Fetih Ejall: ""As soon as you give the greenlight, I will suspend the p..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me about the BFF. Are you certain your intelligence would help us catch all of their leadership in one go?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false`
- **Kontekst wejściowy (poprzednik):** `[289]` (Mansoun Leke), `[334]` (Mansoun Leke), `[304]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Fetih Ejall: ""That's on your security forces, Mr. President.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If this becomes public, how do you expect to keep your leadership of the Workers Party?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false`
- **Kontekst wejściowy (poprzednik):** `[289]` (Mansoun Leke), `[334]` (Mansoun Leke), `[304]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Fetih Ejall: ""I don't.""*)

### Węzeł `[293]`
Mówca: **Fetih Ejall**
> ""I will give you everything I know and can gather. Even the connections in my own party. I am prepared to do this for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Fetih Ejall: ""But to you, I'm offering the possibility to become the p..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm all clear on your offer. Let's talk about how we deal with the votes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Mansoun Leke), `[334]` (Mansoun Leke), `[304]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Lucian Galade: ""I believe that according to their plan, that part is all..."*)

### Węzeł `[295]`
Mówca: **Fetih Ejall**
> ""As soon as you give the greenlight, I will suspend the people from our party who have ties to the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Fetih Ejall: ""I am ready to give you the names of all of them when the..."*)

### Węzeł `[296]`
Mówca: **Fetih Ejall**
> ""I am ready to give you the names of all of them when the time comes. If this achieves progress for Bludish rights, I am willing to go to the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player: ""So the party was always connected to the BFF, as the Sol..."*)
  - -> `[300]` (*Player: ""But why now?""*)
  - -> `[301]` (*Player: ""Do you really believe the changes to Article 6 and 7 wil..."*)

### Węzeł `[297]`
Mówca: **Fetih Ejall**
> ""Progress is progress. I think this would open so many doors for our people. And I don't hold the belief that the way forward is armed resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Fetih Ejall: ""The support for the Workers' Party is increasing more th..."*)

### Węzeł `[298]`
Mówca: **Fetih Ejall**
> ""Well, their claims go to ridiculous lengths. It's true that some of the founders had previous connections to the liberation movement, but most have abandoned it entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player: ""But why now?""*)
  - -> `[301]` (*Player: ""Do you really believe the changes to Article 6 and 7 wil..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So the party was always connected to the BFF, as the Sollists and the nationalists claim?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Fetih Ejall: ""Well, their claims go to ridiculous lengths. It's true t..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But why now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Fetih Ejall), `[298]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Fetih Ejall: ""The support for the Workers' Party is increasing more th..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you really believe the changes to Article 6 and 7 will go over that well with the Bludish community?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Fetih Ejall), `[298]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Fetih Ejall: ""Progress is progress. I think this would open so many do..."*)

### Węzeł `[302]`
Mówca: **Fetih Ejall**
> ""The support for the Workers' Party is increasing more than ever. I firmly believe that we will make it to the Assembly in the next elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Fetih Ejall: ""If we're to finally take place in the democratic process..."*)

### Węzeł `[303]`
Mówca: **Fetih Ejall**
> ""If we're to finally take place in the democratic process, I believe we must completely sever our ties with the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Fetih Ejall: ""Our movement is now far larger than theirs, and we have ..."*)

### Węzeł `[304]`
Mówca: **Fetih Ejall**
> ""Our movement is now far larger than theirs, and we have to take this opportunity for the Workers' Party and for Bludish rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option1 = true"*)

### Węzeł `[305]`
Mówca: **Fetih Ejall**
> ""That's on your security forces, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Fetih Ejall: ""But I'm very certain that the recent intel I received ab..."*)

### Węzeł `[306]`
Mówca: **Fetih Ejall**
> ""But I'm very certain that the recent intel I received about their location is reliable. Among the leadership, the highest profile name is Awlan -- Dewlen Arge's brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Fetih Ejall: ""What you do with that information is up to you.""*)

### Węzeł `[307]`
Mówca: **Fetih Ejall**
> ""What you do with that information is up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""Dewlen is already in Antel Rock. If we can get both brot..."*)
  - -> `[309]` (*Player: ""Do you know who their current leader is?""*)
  - -> `[310]` (*Player: ""What else do you know about the BFF?""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Dewlen is already in Antel Rock. If we can get both brothers locked up, the BFF would be crippled.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Fetih Ejall: ""Exactly.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you know who their current leader is?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Fetih Ejall), `[311]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Fetih Ejall: ""Since the arrest of Dewlen Arge, I don't believe they ha..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else do you know about the BFF?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Fetih Ejall), `[311]` (Fetih Ejall), `[313]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Fetih Ejall: ""According to my sources, a group of four commanders are ..."*)

### Węzeł `[311]`
Mówca: **Fetih Ejall**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""Do you know who their current leader is?""*)
  - -> `[310]` (*Player: ""What else do you know about the BFF?""*)

### Węzeł `[312]`
Mówca: **Fetih Ejall**
> ""Since the arrest of Dewlen Arge, I don't believe they have a single leadership position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Fetih Ejall: ""But his brother is the most respected high-ranking membe..."*)

### Węzeł `[313]`
Mówca: **Fetih Ejall**
> ""But his brother is the most respected high-ranking member inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: ""What can you tell me about him?""*)
  - -> `[310]` (*Player: ""What else do you know about the BFF?""*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What can you tell me about him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Fetih Ejall: ""According to my sources, a group of four commanders are ..."*)

### Węzeł `[315]`
Mówca: **Fetih Ejall**
> ""According to my sources, a group of four commanders are leading the movement in Sordland. Awlan Arge is among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Fetih Ejall: ""I've learned that Awlan has been to Rumburg several time..."*)

### Węzeł `[316]`
Mówca: **Fetih Ejall**
> ""I've learned that Awlan has been to Rumburg several times to meet with the Rumburgian Intelligence Directorate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Fetih Ejall: ""Apart from Rumburg, he also seems to have ties with the ..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: ""Are you crazy? This proposal will be crushed in an insta..."*)

### Węzeł `[320]`
Mówca: **Fetih Ejall**
> ""Apart from Rumburg, he also seems to have ties with the Golcondist administration in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)

### Węzeł `[321]`
Mówca: **Fetih Ejall**
> ""Since Operation Bear Trap commenced in Wehlen, rumors have been circulating that Awlan and his brigade are planning to increase their activity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Fetih Ejall: ""What's even more striking is a yet-to-be-confirmed repor..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Fetih Ejall: ""Since Operation Bear Trap commenced in Wehlen, rumors ha..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Fetih Ejall: ""Since Operation Bear Trap commenced in Wehlen, Awlan and..."*)

### Węzeł `[325]`
Mówca: **Fetih Ejall**
> ""Since Operation Bear Trap commenced in Wehlen, Awlan and his brigade have apparently been cooperating very closely with the movement's Wehlen branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Fetih Ejall: ""What's even more striking is a yet-to-be-confirmed repor..."*)

### Węzeł `[326]`
Mówca: **Fetih Ejall**
> ""What's even more striking is a yet-to-be-confirmed report which points to the involvement of several wealthy Sordish businessman in smuggling Arcasian and Rumburgian weapons to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player: ""I hope that's not true.""*)
  - -> `[327]` (*Player: ""These are massive, Mr. Ejall. I want you to give all of ..."*)
  - -> `[328]` (*Player: ""This entire offer sounds too good to be true. I'm not su..."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are massive, Mr. Ejall. I want you to give all of this intelligence to my team as soon as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Fetih Ejall: ""Of course. As soon as you add the changes to Article 6 a..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This entire offer sounds too good to be true. I'm not sure if I'm willing to trust you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Fetih Ejall: ""I'm not a Sordish politician, Mr. Rayne. You will see ho..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope that's not true.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Fetih Ejall: ""It likely is.""*)

### Węzeł `[330]`
Mówca: **Fetih Ejall**
> ""I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Fetih Ejall: ""I intend to give leadership back to Mansoun. The party s..."*)

### Węzeł `[331]`
Mówca: **Fetih Ejall**
> ""I intend to give leadership back to Mansoun. The party still respects him immensely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Fetih Ejall: ""And his name hasn't been stained like most of ours. The ..."*)

### Węzeł `[332]`
Mówca: **Fetih Ejall**
> ""And his name hasn't been stained like most of ours. The government did not label him as a 'former terrorist', and neither was he declared a target by far-right nationalists. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Mansoun Leke: ""As much as I feel like I'm not ready for that responsibi..."*)

### Węzeł `[333]`
Mówca: **Mansoun Leke**
> ""As much as I feel like I'm not ready for that responsibility, I'm ready to do whatever it takes to grow the Bludish democratic movement. I'm ready to be the new target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Mansoun Leke: ""This way, we can start anew.""*)

### Węzeł `[334]`
Mówca: **Mansoun Leke**
> ""This way, we can start anew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option3 = true"*)

### Węzeł `[335]`
Mówca: **Lucian Galade**
> ""I believe that according to their plan, that part is all on us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Fetih Ejall: ""We'll give you the BFF and you'll get us the votes from ..."*)

### Węzeł `[336]`
Mówca: **Fetih Ejall**
> ""We'll give you the BFF and you'll get us the votes from the USP, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: ""Just imagining talking to Gloria and Albin about the pro..."*)
  - -> `[338]` (*Player: ""What about the Supreme Court?""*)
  - -> `[339]` (*Player: ""I may convince the leaders of the party, but we may want..."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just imagining talking to Gloria and Albin about the proposal again is giving me a headache.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Mansoun Leke: ""I'm sure you can handle it, Mr. President.""*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What about the Supreme Court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Fetih Ejall), `[341]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Mansoun Leke: ""What about it? You're already going directly against the..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may convince the leaders of the party, but we may want to reach out directly to all 130 of our members.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[336]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Mansoun Leke: ""Focus on the leadership and get your vice president to c..."*)

### Węzeł `[340]`
Mówca: **Mansoun Leke**
> ""Focus on the leadership and get your vice president to convince the MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Mansoun Leke: ""He has a way with words. I think he can sell this idea e..."*)

### Węzeł `[341]`
Mówca: **Mansoun Leke**
> ""He has a way with words. I think he can sell this idea even to the staunchest conservatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player: ""What about the Supreme Court?""*)
  - -> `[347]` (*Player: ""Really? Does Petr really have such an influence in the A..."*)

### Węzeł `[342]`
Mówca: **Mansoun Leke**
> ""I'm sure you can handle it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Mansoun Leke: ""Focus on the leadership and get your vice president to c..."*)

### Węzeł `[343]`
Mówca: **Mansoun Leke**
> ""What about it? You're already going directly against the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Mansoun Leke: ""Don't you already have a plan to get your current reform..."*)

### Węzeł `[344]`
Mówca: **Mansoun Leke**
> ""Don't you already have a plan to get your current reforms through the Court? What does it really change for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Lucian Galade: ""With all due respect, Mr. Leke, we are not children here..."*)

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""With all due respect, Mr. Leke, we are not children here. You know how risky this is. If we lose this, our entire reform package goes down the drain. Not just Article 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Lucian Galade: ""The addition of these reforms would flip our plan upside..."*)

### Węzeł `[346]`
Mówca: **Lucian Galade**
> ""The addition of these reforms would flip our plan upside down. The implications are not the same at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Fetih Ejall: ""Then do your absolute best and make sure it doesn't fail.""*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really? Does Petr really have such an influence in the Assembly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Mansoun Leke: ""Of course, Mr. President. He has a dialogue with everyon..."*)

### Węzeł `[348]`
Mówca: **Mansoun Leke**
> ""Of course, Mr. President. He has a dialogue with everyone. He's able to reach all corners of the political spectrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Lucian Galade: ""I'm sure Mr. Vectern would be helpful in getting votes, ..."*)

### Węzeł `[349]`
Mówca: **Lucian Galade**
> ""I'm sure Mr. Vectern would be helpful in getting votes, but I don't see how that would be enough. Besides, the Supreme Court is the main problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Mansoun Leke: ""What about it? You're already going directly against the..."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "He sighed and sat down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""All right.""]"*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Then I'm sorry. I'm not willing to support your proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Fetih Ejall: ""As expected.""*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Fetih Ejall: ""This is a very dark time for the Bludish people in Bergi..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Fetih Ejall: ""We never would have expected such statements of support ..."*)

### Węzeł `[355]`
Mówca: **Fetih Ejall**
> ""This is a very dark time for the Bludish people in Bergia and we need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Fetih Ejall: ""Governor Bron's racist policies are being illegally prot..."*)

### Węzeł `[356]`
Mówca: **Fetih Ejall**
> ""Governor Bron's racist policies are being illegally protected by the Supreme Court under the guise of a large-scale threat by the so-called terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == tru..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == tru..."*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: ""Don't worry. We are already working on a proposal to res..."*)
  - -> `[361]` (*Player: ""Mr. Hawker is using Governor Bron to increase tensions i..."*)
  - -> `[362]` (*Player: ""As much as I'm against the Supreme Court's decision to d..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Fetih Ejall: ""We never would have expected such statements of support ..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We are already working on a proposal to restructure the Special Zone. Governor Bron will soon be gone.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Kontekst wejściowy (poprzednik):** `[356]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Fetih Ejall: ""I've heard about that. We ask that you prioritize it aft..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Hawker is using Governor Bron to increase tensions in the country. If there really are terrorists out there, these two are where it starts.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Kontekst wejściowy (poprzednik):** `[356]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Fetih Ejall: ""It's great that we think alike on the matter.""*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I'm against the Supreme Court's decision to delay the case, the BFF threat in the region is not some fantasy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Kontekst wejściowy (poprzednik):** `[356]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Fetih Ejall: ""Hm...""*)

### Węzeł `[363]`
Mówca: **Fetih Ejall**
> ""Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Fetih Ejall: ""Well... Where were we?""*)

### Węzeł `[364]`
Mówca: **Fetih Ejall**
> ""Well... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Fetih Ejall: ""Ah, yes. We never would have expected such statements of..."*)

### Węzeł `[365]`
Mówca: **Fetih Ejall**
> ""Ah, yes. We never would have expected such statements of support coming from a USP president. You have our appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Fetih Ejall: ""But know this. If you're *really* willing to fight for t..."*)

### Węzeł `[366]`
Mówca: **Fetih Ejall**
> ""It's great that we think alike on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Fetih Ejall: ""We never would have expected such statements of support ..."*)

### Węzeł `[367]`
Mówca: **Fetih Ejall**
> ""I've heard about that. We ask that you prioritize it after your reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Mansoun Leke: ""Thank you for following up on this, Mr. President. I hop..."*)

### Węzeł `[368]`
Mówca: **Mansoun Leke**
> ""Thank you for following up on this, Mr. President. I hope it becomes a reality soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Fetih Ejall: ""We never would have expected such statements of support ..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Fetih Ejall: ""I thought you were different, Mr. President. But you've ..."*)

### Węzeł `[370]`
Mówca: **Fetih Ejall**
> ""I thought you were different, Mr. President. But you've proved my comrades right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Fetih Ejall: ""We'll never achieve anything tangible as long as the USP..."*)

### Węzeł `[371]`
Mówca: **Fetih Ejall**
> ""We'll never achieve anything tangible as long as the USP is in power. I'm certain of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "On his gesture, Mansoun also stood up."*)

### Węzeł `[372]`
Mówca: **Fetih Ejall**
> ""Then do your absolute best and make sure it doesn't fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Fetih Ejall: ""We're not going to *negotiate* our rights here. Either y..."*)

### Węzeł `[373]`
Mówca: **Fetih Ejall**
> ""We're not going to *negotiate* our rights here. Either you will fight for us and we will give you what I said in return, or you abandon the Bludish democratic movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player: ""I'm willing to fight for you. I will include these amend..."*)
  - -> `[375]` (*Player: ""No need to be so dramatic, Mr. Ejall. Let's work togethe..."*)
  - -> `[376]` (*Player: ""I'm sorry, Mr. Ejall, but I don't think I'm willing to t..."*)

### Węzeł `[374]`
**[WYBÓR GRACZA: ""I'm willing to fight for you. I will include these amendments in our reform proposal." [ADD NEW CHANGES TO PROPOSAL]"]** — Mówca: **Player**
> ""I'm willing to fight for you. I will include these amendments in our reform proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[373]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal = true; ..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA: ""No need to be so dramatic, Mr. Ejall. Let's work together and finally change the Articles 6 and 7." [ADD NEW CHANGES TO PROPOSAL]"]** — Mówca: **Player**
> ""No need to be so dramatic, Mr. Ejall. Let's work together and finally change the Articles 6 and 7.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[373]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal = true; ..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, Mr. Ejall, but I don't think I'm willing to take the risk. We can't lose a possibility to reform our constitution due to these two changes. We won't include them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[373]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Mansoun Leke: ""That's... a shame.""*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hub_BludishRights_BFF`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false"*)
  - -> `[294]` (*Player: ""I'm all clear on your offer. Let's talk about how we dea..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_BludishRights_BFF]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "Hub_BludishRights_BFF"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_BludishRights_BFF]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "Hub_BludishRights_BFF"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_BludishRights_BFF]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "Hub_BludishRights_BFF"*)

### Węzeł `[381]`
Mówca: **Fetih Ejall**
> ""I'm not a Sordish politician, Mr. Rayne. You will see how serious I am about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option2 = true"*)

### Węzeł `[382]`
Mówca: **Fetih Ejall**
> ""It likely is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option2 = true"*)

### Węzeł `[383]`
Mówca: **Fetih Ejall**
> ""Of course. As soon as you add the changes to Article 6 and 7 to your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option2 = true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal = true;
BaseGameSupport.Journal_Turn07_BludishMeeting_ChangedProposal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] = true;
Variable["BaseGameSupport.Journal_Turn07_BludishMeeting_ChangedProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Mansoun Leke: ""That's great to hear.""*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Manson was the spokesperson of the independents and the former leader of the WPB, while Fetih Ejall was the WPB's current leader."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: ""Good morning, Mr. Ejall and Mr. Leke.""*)

### Węzeł `[386]`
Mówca: **Fetih Ejall**
> ""You can threaten me all you like, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Fetih Ejall: ""If you're not willing to support us, say it like a man.""*)

### Węzeł `[387]`
Mówca: **Fetih Ejall**
> ""You know that nobody received more death threats than me in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Fetih Ejall: ""You can threaten me all you like, Mr. President.""*)

### Węzeł `[388]`
Mówca: **Fetih Ejall**
> ""If you're not willing to support us, say it like a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player: ""Let's just calm down and talk about the offer.""*)
  - -> `[389]` (*Player: ""I am not.""*)
  - -> `[204]` (*Player: ""You're forgetting your place.""*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Fetih Ejall: ""So you don't intend to pursue these reforms at all?""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's just calm down and talk about the offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: ""This would give us a significant edge, of course. But I ..."*)

### Węzeł `[391]`
Mówca: **Mansoun Leke**
> ""That's... a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "Jump to: [Fetih Ejall: ""There is nothing left to discuss..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Fetih Ejall: ""There is nothing left to discuss h..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Fetih Ejall: ""There is nothing left to discuss here. We should take ou..."*)

### Węzeł `[393]`
Mówca: **Mansoun Leke**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Fetih Ejall: ""Thank you, Mr. President.""*)

### Węzeł `[394]`
Mówca: **Fetih Ejall**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Fetih Ejall: ""You will find an ally in me.""*)

### Węzeł `[395]`
Mówca: **Fetih Ejall**
> ""You will find an ally in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Fetih Ejall: ""And I will deliver my promises. You can count on what I ..."*)

### Węzeł `[396]`
Mówca: **Fetih Ejall**
> ""And I will deliver my promises. You can count on what I said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player: ""This was a very productive and historic meeting, gentlem..."*)
  - -> `[397]` (*Player: ""Thank you. Together we will achieve a better democracy i..."*)
  - -> `[398]` (*Player: ""Thank you, Mr. Ejall. Together we will eliminate the BFF..."*)
  - -> `[399]` (*Player: ""I hope so, Mr. Ejall. Your promises will be needed to co..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you. Together we will achieve a better democracy in Sordland -- for everyone regardless of culture, language or ethnicity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Ejall. Together we will eliminate the BFF and set the Bludish people free from terror and division.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Fetih Ejall: ""For a better future.""*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope so, Mr. Ejall. Your promises will be needed to convince the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Fetih Ejall: ""For a better future.""*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This was a very productive and historic meeting, gentlemen. Thank you for coming here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Fetih Ejall)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[401]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "They both stood up and shook my hand."*)

### Węzeł `[402]`
Mówca: **Fetih Ejall**
> ""For a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "They both stood up and shook my hand."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "They both stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "This drastic addition to the proposal at the last minute ..."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "This drastic addition to the proposal at the last minute would surely be a cause of contention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "I had no idea whether Fetih Ejall's plan would work."*)

### Węzeł `[405]`
Mówca: **Narrator**
> "I had no idea whether Fetih Ejall's plan would work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_Amendment_NewPropos..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "They both stood up and left the office afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "I wondered if I could still maintain the support of the B..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "I wondered if I could still maintain the support of the Bludish community after this meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal ..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal = true;
BaseGame.Bludish_Opinion += 2;
BaseGame.Sollist -= 5;
BaseGame.Democratic += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 5;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced = false"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_RayneChangesProposal = tru..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_RayneChangesProposal = true;
BaseGameSupport.News_Turn07_R_BludishMovementGivesSupportToRayne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_RayneChangesProposal"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludishMovementGivesSupportToRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictat..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_RayneChangesProposal = true"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_RayneChangesProposal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToE..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal = true;
BaseGame.Bludish_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Security");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Security");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian and I were waiting in my office ahead of our talk ..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_BludishRights_BFF]"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_BludishRights_BFF]"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_BludishRights_BFF]"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == fa..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""Tell me everything about the connection between the Work..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == fa..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""Tell me about the BFF. Are you certain your intelligence..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == fa..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player: ""If this becomes public, how do you expect to keep your l..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Meeting with the leaders of the minority rights movement", "Maroon Palace", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Meeting with the leaders of the minority rights movement","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Security");"*)
