# Sordland/Turn07/A_AddressToTheNation

- **ID konwersacji:** `101`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/101_A_AddressToTheNation.md`
- **Liczba węzłów dialogowych:** 579
- **Liczba wyborów gracza:** 219

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.Capitalist`
- `BaseGame.Decision_Turn05_AutocratEmergency_Revoke`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Promise_TermFocus_Security`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_Law_Amendment_NoCourt`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_TermLimits_Default`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Veto_Limited`
- `BaseGame.Reform_Law_Veto_Loophole`
- `BaseGame.Reform_Law_Veto_Removed`
- `BaseGame.Reform_Reform_AssemblyVote_LostBy1`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Sollist`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Results_Decision_TrySoll`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedParliamentarySystem`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameSupport.News_Turn07_HP_Capitalism`
- `BaseGameSupport.News_Turn07_HP_FutureInOurHands`
- `BaseGameSupport.News_Turn07_HP_Malenyevism`
- `BaseGameSupport.News_Turn07_HP_Sollism`
- `BaseGameSupport.News_Turn07_LT_ParliamentarySystem`
- `BaseGameSupport.News_Turn07_R_AutocratSpeech`
- `BaseGameSupport.News_Turn07_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal`
- `BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal`
- `BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperationBegins`
- `GameCondition.Turn07_A_AddressToTheNation`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Yes. Let's do it.""** | `[5]` **Lucian Galade**: ""Are you ready, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Lucian Galade**: ""Good. I think the crew is ready..." |
| `[7]` | **""I am always ready.""** | `[5]` **Lucian Galade**: ""Are you ready, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Lucian Galade**: ""Good. I think the crew is ready..." |
| `[8]` | **""I guess.""** | `[5]` **Lucian Galade**: ""Are you ready, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Lucian Galade**: ""I'm sure you are, sir. As soon ..." |
| `[13]` | **""Brothers and sisters...""** | `[12]` **Narrator**: "After everybody was ready, the d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: ""I am happy to have this opportu..."<br>`[16]` **Player**: ""I am grateful to earn the honor..."<br>*(oraz 6 innych odgałęzień)* |
| `[14]` | **""My fellow Sords...""** | `[12]` **Narrator**: "After everybody was ready, the d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: ""I am happy to have this opportu..."<br>`[16]` **Player**: ""I am grateful to earn the honor..."<br>*(oraz 6 innych odgałęzień)* |
| `[15]` | **""My fellow citizens...""** | `[12]` **Narrator**: "After everybody was ready, the d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Player**: ""I am happy to have this opportu..."<br>`[16]` **Player**: ""I am grateful to earn the honor..."<br>*(oraz 6 innych odgałęzień)* |
| `[16]` | **""I am grateful to earn the honor of finally modifying the Constitution of Tarquin ..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[21]` **Player**: ""Two years ago, I spoke to you o..."<br>`[20]` **Player**: ""I am proud of what our governme..."<br>*(oraz 1 innych odgałęzień)* |
| `[17]` | **""I'd like to speak about our future, about a great historic effort to give the wor..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true`<br>`Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[21]` **Player**: ""Two years ago, I spoke to you o..."<br>`[20]` **Player**: ""I am proud of what our governme..."<br>*(oraz 1 innych odgałęzień)* |
| `[18]` | **""I am happy to have this opportunity to talk to you about the changes we have unde..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[21]` **Player**: ""Two years ago, I spoke to you o..."<br>`[20]` **Player**: ""I am proud of what our governme..."<br>*(oraz 1 innych odgałęzień)* |
| `[19]` | **""We have reached a turning point in Sordland's history.""** | `[16]` **Player**: ""I am grateful to earn the honor..."<br>`[17]` **Player**: ""I'd like to speak about our fut..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[24]` **Player**: ""Our new Constitution is a secon..."<br>*(oraz 3 innych odgałęzień)* |
| `[20]` | **""I am proud of what our government has accomplished. We have finally brought fairn..."** | `[16]` **Player**: ""I am grateful to earn the honor..."<br>`[17]` **Player**: ""I'd like to speak about our fut..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[24]` **Player**: ""Our new Constitution is a secon..."<br>*(oraz 3 innych odgałęzień)* |
| `[21]` | **""Two years ago, I spoke to you of change, and we have accomplished that.""** | `[16]` **Player**: ""I am grateful to earn the honor..."<br>`[17]` **Player**: ""I'd like to speak about our fut..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Player**: ""But in another sense, our chang..."<br>`[22]` **Player**: ""We need to remember where Sordl..." |
| `[22]` | **""We need to remember where Sordland was two years ago. Those days are behind us no..."** | `[19]` **Player**: ""We have reached a turning point..."<br>`[20]` **Player**: ""I am proud of what our governme..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[28]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych odgałęzień)* |
| `[23]` | **""But in another sense, our change is a continuation of that which started three de..."** | `[21]` **Player**: ""Two years ago, I spoke to you o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[28]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych odgałęzień)* |
| `[24]` | **""Our new Constitution is a second revolution in the history of Sordland that truly..."** | `[19]` **Player**: ""We have reached a turning point..."<br>`[20]` **Player**: ""I am proud of what our governme..." | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[28]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych odgałęzień)* |
| `[25]` | **""The new system brings a more transparent democracy that will help Sordland rise u..."** | `[19]` **Player**: ""We have reached a turning point..."<br>`[20]` **Player**: ""I am proud of what our governme..." | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[28]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych odgałęzień)* |
| `[26]` | **""For the sake of fairness, simplicity, and growth, we had to radically change the ..."** | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[23]` **Player**: ""But in another sense, our chang..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Player**: ""I've spoken with and received l..."<br>`[39]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych odgałęzień)* |
| `[27]` | **""We made a Constitution that no longer protects the rights of a select few elites,..."** | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[23]` **Player**: ""But in another sense, our chang..."<br>*(oraz 4 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `-- continue;` | `[38]` **Player**: ""I've spoken with and received l..."<br>`[39]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych odgałęzień)* |
| `[28]` | **""We transformed a system that had caused endless confusion and resentment into one..."** | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[23]` **Player**: ""But in another sense, our chang..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `-- contiue;` | `[38]` **Player**: ""I've spoken with and received l..."<br>`[39]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych odgałęzień)* |
| `[29]` | **""We will not rest until every Sordish citizen enjoys the freedom, dignity, and opp..."** | `[32]` **Narrator**: "I paused to take a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych odgałęzień)* |
| `[30]` | **""With our reforms complete, our government will now focus on the economic developm..."** | `[32]` **Narrator**: "I paused to take a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych odgałęzień)* |
| `[31]` | **""Now, we have our next challenges. We will be focusing on Sordland's internal and ..."** | `[32]` **Narrator**: "I paused to take a deep breath." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych odgałęzień)* |
| `[36]` | **""Next, we must transition into the parliamentary system.""** | `[32]` **Narrator**: "I paused to take a deep breath." | `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false` | `Variable["BaseGame.Speech_PromisedParliamentarySystem"] =...` | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych odgałęzień)* |
| `[37]` | **""Henceforth, our government shall no longer be able to obstruct the will of the pe..."** | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[129]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `-- continue;` | `[63]` **Player**: ""We eliminated the Supreme Court..."<br>`[64]` **Player**: ""A new age is upon us!""<br>*(oraz 3 innych odgałęzień)* |
| `[38]` | **""I've spoken with and received letters from thousands of you. I know how hungry yo..."** | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[129]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player**: ""We eliminated the Supreme Court..."<br>`[64]` **Player**: ""A new age is upon us!""<br>*(oraz 3 innych odgałęzień)* |
| `[39]` | **""By now I'm sure you have one question on your minds: Will our reforms help you? Y..."** | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[129]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `-- continue;` | `[63]` **Player**: ""We eliminated the Supreme Court..."<br>`[64]` **Player**: ""A new age is upon us!""<br>*(oraz 3 innych odgałęzień)* |
| `[61]` | **""New term limits will ensure that no single person can block change when it's most..."** | `[38]` **Player**: ""I've spoken with and received l..."<br>`[136]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false` | *Brak zmian stanu* | `[67]` **Player**: ""Beyond this, we intend to stren..."<br>`[65]` **Player**: ""I stand proud to have exchanged..."<br>*(oraz 3 innych odgałęzień)* |
| `[62]` | **""We now ensure that neither I nor any other person who holds the position of presi..."** | `[38]` **Player**: ""I've spoken with and received l..."<br>`[136]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true` | *Brak zmian stanu* | `[67]` **Player**: ""Beyond this, we intend to stren..."<br>`[65]` **Player**: ""I stand proud to have exchanged..."<br>*(oraz 3 innych odgałęzień)* |
| `[63]` | **""We eliminated the Supreme Court's iron grip on our legislation.""** | `[38]` **Player**: ""I've spoken with and received l..."<br>`[136]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Player**: ""Beyond this, we intend to stren..."<br>`[65]` **Player**: ""I stand proud to have exchanged..."<br>*(oraz 3 innych odgałęzień)* |
| `[64]` | **""A new age is upon us!""** | `[38]` **Player**: ""I've spoken with and received l..."<br>`[136]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Player**: ""Beyond this, we intend to stren..."<br>`[65]` **Player**: ""I stand proud to have exchanged..."<br>*(oraz 3 innych odgałęzień)* |
| `[65]` | **""I stand proud to have exchanged my own powers for a better future. Presidential d..."** | `[61]` **Player**: ""New term limits will ensure tha..."<br>`[62]` **Player**: ""We now ensure that neither I no..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true` | *Brak zmian stanu* | `[74]` **Player**: ""Voices were raised saying that ..."<br>`[72]` **Player**: ""We have also lowered our unfair..."<br>*(oraz 3 innych odgałęzień)* |
| `[66]` | **""I will personally make sure that every change is respected and executed properly.""** | `[61]` **Player**: ""New term limits will ensure tha..."<br>`[62]` **Player**: ""We now ensure that neither I no..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false` | *Brak zmian stanu* | `[74]` **Player**: ""Voices were raised saying that ..."<br>`[72]` **Player**: ""We have also lowered our unfair..."<br>*(oraz 3 innych odgałęzień)* |
| `[67]` | **""Beyond this, we intend to strengthen the democratic freedoms of every Sordish cit..."** | `[61]` **Player**: ""New term limits will ensure tha..."<br>`[62]` **Player**: ""We now ensure that neither I no..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Player**: ""Voices were raised saying that ..."<br>`[72]` **Player**: ""We have also lowered our unfair..."<br>*(oraz 3 innych odgałęzień)* |
| `[68]` | **""I must thank the Supreme Court Justices for supporting these much-needed changes.""** | `[61]` **Player**: ""New term limits will ensure tha..."<br>`[62]` **Player**: ""We now ensure that neither I no..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true` | *Brak zmian stanu* | `[74]` **Player**: ""Voices were raised saying that ..."<br>`[72]` **Player**: ""We have also lowered our unfair..."<br>*(oraz 3 innych odgałęzień)* |
| `[69]` | **""For too long, our Supreme Court has acted on behalf of sinister deep state intere..."** | `[61]` **Player**: ""New term limits will ensure tha..."<br>`[62]` **Player**: ""We now ensure that neither I no..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false` | *Brak zmian stanu* | `[74]` **Player**: ""Voices were raised saying that ..."<br>`[72]` **Player**: ""We have also lowered our unfair..."<br>*(oraz 3 innych odgałęzień)* |
| `[70]` | **""By abolishing the position of Member of Honor, we have ensured that Sordland will..."** | `[65]` **Player**: ""I stand proud to have exchanged..."<br>`[66]` **Player**: ""I will personally make sure tha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true` | *Brak zmian stanu* | `[79]` **Player**: ""It is time to renew our faith i..."<br>`[75]` **Player**: ""The new changes in our system h..."<br>*(oraz 2 innych odgałęzień)* |
| `[71]` | **""I promise you. We will not stop.""** | `[65]` **Player**: ""I stand proud to have exchanged..."<br>`[66]` **Player**: ""I will personally make sure tha..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false` | *Brak zmian stanu* | `[79]` **Player**: ""It is time to renew our faith i..."<br>`[75]` **Player**: ""The new changes in our system h..."<br>*(oraz 2 innych odgałęzień)* |
| `[72]` | **""We have also lowered our unfair election threshold. No longer will the voices of ..."** | `[65]` **Player**: ""I stand proud to have exchanged..."<br>`[66]` **Player**: ""I will personally make sure tha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true` | *Brak zmian stanu* | `[79]` **Player**: ""It is time to renew our faith i..."<br>`[75]` **Player**: ""The new changes in our system h..."<br>*(oraz 2 innych odgałęzień)* |
| `[73]` | **""We did all of this in a time of economic stress and despite heavy protests.""** | `[65]` **Player**: ""I stand proud to have exchanged..."<br>`[66]` **Player**: ""I will personally make sure tha..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false` | *Brak zmian stanu* | `[79]` **Player**: ""It is time to renew our faith i..."<br>`[75]` **Player**: ""The new changes in our system h..."<br>*(oraz 2 innych odgałęzień)* |
| `[74]` | **""Voices were raised saying that we had to look to our past for greatness and glory..."** | `[65]` **Player**: ""I stand proud to have exchanged..."<br>`[66]` **Player**: ""I will personally make sure tha..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Player**: ""It is time to renew our faith i..."<br>`[75]` **Player**: ""The new changes in our system h..."<br>*(oraz 3 innych odgałęzień)* |
| `[75]` | **""The new changes in our system have planted the seeds for untold future successes.""** | `[70]` **Player**: ""By abolishing the position of M..."<br>`[71]` **Player**: ""I promise you. We will not stop.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "I paused to take a deep breath." |
| `[76]` | **""We will open the way for Tarquin Soll's trial. He must answer for the crimes comm..."** | `[70]` **Player**: ""By abolishing the position of M..."<br>`[71]` **Player**: ""I promise you. We will not stop.""<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true` | `Variable["BaseGame.Speech_PromisedToTrySoll"] = true; Var...`<br>`Variable["BaseGameSupport.News_Turn07_ST_PromisedToTrySol...` | `[32]` **Narrator**: "I paused to take a deep breath." |
| `[77]` | **""We are creating a nation once again vibrant, robust, and alive.""** | `[70]` **Player**: ""By abolishing the position of M..."<br>`[71]` **Player**: ""I promise you. We will not stop.""<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false` | *Brak zmian stanu* | `[32]` **Narrator**: "I paused to take a deep breath." |
| `[78]` | **""But we, the present-day Sords, are not given to looking backward. In this blessed..."** | `[74]` **Player**: ""Voices were raised saying that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "I paused to take a deep breath." |
| `[79]` | **""It is time to renew our faith in our system.""** | `[70]` **Player**: ""By abolishing the position of M..."<br>`[71]` **Player**: ""I promise you. We will not stop.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "I paused to take a deep breath." |
| `[80]` | **""Fellow citizens of Sordland, let me assure you, our nation is poised for greatness.""** | `[29]` **Player**: ""We will not rest until every So..."<br>`[30]` **Player**: ""With our reforms complete, our ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych odgałęzień)* |
| `[81]` | **""Today, we must do what we know is right, and do it with all of our might.""** | `[29]` **Player**: ""We will not rest until every So..."<br>`[30]` **Player**: ""With our reforms complete, our ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""Let history say of us: these were the golden years when Sordish Democracy was reb..."** | `[29]` **Player**: ""We will not rest until every So..."<br>`[30]` **Player**: ""With our reforms complete, our ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **""I'll remind you of the revolutionary phrase: 'Morning will come, Victory is close..."** | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Player**: ""The future is in our hands.""<br>`[88]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[84]` | **""I will not let any of my fellow citizens down.""** | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Player**: ""The future is in our hands.""<br>`[88]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[85]` | **""The United Sordland Party will keep fighting for a stronger and more united Sordl..."** | `[80]` **Player**: ""Fellow citizens of Sordland, le..."<br>`[81]` **Player**: ""Today, we must do what we know ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Player**: ""The future is in our hands.""<br>`[88]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[86]` | **""The future lies in the Socialist Movement of the East.""** | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Malenyevist"] >= 6` | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[93]` **Player**: ""We must take lessons from the M..."<br>`[94]` **Player**: ""Sordland must slowly put more p..."<br>*(oraz 1 innych odgałęzień)* |
| `[87]` | **""The future is in our hands.""** | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn07_HP_FutureInOurHands...` | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[88]` | **""The future lies in the Democratic Movement of the West.""** | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[96]` **Player**: ""We must take lessons from Arcas..."<br>`[97]` **Player**: ""We must keep striving for a fai..."<br>*(oraz 1 innych odgałęzień)* |
| `[93]` | **""We must take lessons from the Malenyevist revolution in United Contana.""** | `[86]` **Player**: ""The future lies in the Socialis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[94]` | **""Sordland must slowly put more power in the hands of the working class, which capi..."** | `[86]` **Player**: ""The future lies in the Socialis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[95]` | **""We must lead Sordland with democratic socialism.""** | `[86]` **Player**: ""The future lies in the Socialis..." | `Variable["BaseGame.Democratic"] >= 6` | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[96]` | **""We must take lessons from Arcasia's democracy.""** | `[88]` **Player**: ""The future lies in the Democrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[97]` | **""We must keep striving for a fair and transparent democracy in Sordland and abroad.""** | `[88]` **Player**: ""The future lies in the Democrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[98]` | **""We must lead Sordland with social democracy.""** | `[88]` **Player**: ""The future lies in the Democrat..." | `Variable["BaseGame.Malenyevist"] >= 6` | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[102]` | **""For a Sordland of wisdom that honors the family, knowing that as the family goes,..."** | `[101]` **Narrator**: "I took another deep breath. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Player**: ""We have begun promisingly. But ..."<br>`[107]` **Player**: ""We're not here to congratulate ..."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **""For a Sordland of vision that sees tomorrow's dreams in the learning and hard wor..."** | `[101]` **Narrator**: "I took another deep breath. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Player**: ""We have begun promisingly. But ..."<br>`[107]` **Player**: ""We're not here to congratulate ..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **""For a Sordland of courage whose servicemen and -women, even as I speak, proudly s..."** | `[101]` **Narrator**: "I took another deep breath. Luci..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Player**: ""We have begun promisingly. But ..."<br>`[107]` **Player**: ""We're not here to congratulate ..."<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **""Let us begin by challenging our conventional wisdom.""** | `[102]` **Player**: ""For a Sordland of wisdom that h..."<br>`[103]` **Player**: ""For a Sordland of vision that s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[110]` **Player**: ""God Bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[106]` | **""We have begun promisingly. But it's only a beginning.""** | `[102]` **Player**: ""For a Sordland of wisdom that h..."<br>`[103]` **Player**: ""For a Sordland of vision that s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[110]` **Player**: ""God Bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[107]` | **""We're not here to congratulate ourselves on what we have done, but to challenge o..."** | `[102]` **Player**: ""For a Sordland of wisdom that h..."<br>`[103]` **Player**: ""For a Sordland of vision that s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[110]` **Player**: ""God Bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[108]` | **""Thank you.""** | `[105]` **Player**: ""Let us begin by challenging our..."<br>`[106]` **Player**: ""We have begun promisingly. But ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[109]` | **""A'Morgna wes core! Vectern sis da!""** | `[105]` **Player**: ""Let us begin by challenging our..."<br>`[106]` **Player**: ""We have begun promisingly. But ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[110]` | **""God Bless Sordland.""** | `[105]` **Player**: ""Let us begin by challenging our..."<br>`[106]` **Player**: ""We have begun promisingly. But ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[111]` | **""I salute you all with respect.""** | `[105]` **Player**: ""Let us begin by challenging our..."<br>`[106]` **Player**: ""We have begun promisingly. But ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[116]` | **""I'd like to speak about our future, about a great historic effort to give the wor..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`<br>`Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[21]` **Player**: ""Two years ago, I spoke to you o..."<br>`[20]` **Player**: ""I am proud of what our governme..."<br>*(oraz 1 innych odgałęzień)* |
| `[123]` | **""The new system brings a stronger government that will help Sordland rise up in th..."** | `[19]` **Player**: ""We have reached a turning point..."<br>`[20]` **Player**: ""I am proud of what our governme..." | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[27]` **Player**: ""We made a Constitution that no ..."<br>*(oraz 1 innych odgałęzień)* |
| `[124]` | **""Our new Constitution is a second revolution in the history of Sordland that truly..."** | `[19]` **Player**: ""We have reached a turning point..."<br>`[20]` **Player**: ""I am proud of what our governme..." | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[28]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych odgałęzień)* |
| `[128]` | **""We made a Constitution that no longer protects the rights of a select few elites.""** | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[23]` **Player**: ""But in another sense, our chang..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | `-- continue;` | `[38]` **Player**: ""I've spoken with and received l..."<br>`[39]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych odgałęzień)* |
| `[129]` | **""We transformed a system that had caused endless confusion and resentment into one..."** | `[22]` **Player**: ""We need to remember where Sordl..."<br>`[23]` **Player**: ""But in another sense, our chang..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[38]` **Player**: ""I've spoken with and received l..."<br>`[39]` **Player**: ""By now I'm sure you have one qu..."<br>*(oraz 3 innych odgałęzień)* |
| `[136]` | **""By now I'm sure you have one question on your minds: Will our reforms help you? Y..."** | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[129]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[63]` **Player**: ""We eliminated the Supreme Court..."<br>`[64]` **Player**: ""A new age is upon us!""<br>*(oraz 3 innych odgałęzień)* |
| `[137]` | **""Henceforth, our government shall no longer be able to obstruct the will of the pe..."** | `[26]` **Player**: ""For the sake of fairness, simpl..."<br>`[129]` **Player**: ""We transformed a system that ha..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | `-- continue;` | `[63]` **Player**: ""We eliminated the Supreme Court..."<br>`[64]` **Player**: ""A new age is upon us!""<br>*(oraz 3 innych odgałęzień)* |
| `[144]` | **""With my new powers as president, I will do whatever it takes to transform this na..."** | `[39]` **Player**: ""By now I'm sure you have one qu..."<br>`[38]` **Player**: ""I've spoken with and received l..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`<br>`(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false` | *Brak zmian stanu* | `[67]` **Player**: ""Beyond this, we intend to stren..."<br>`[65]` **Player**: ""I stand proud to have exchanged..."<br>*(oraz 3 innych odgałęzień)* |
| `[148]` | **""Let history say of us: these were the golden years when Sordland was reborn and r..."** | `[29]` **Player**: ""We will not rest until every So..."<br>`[30]` **Player**: ""With our reforms complete, our ..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych odgałęzień)* |
| `[152]` | **""The future lies in the capitalism of the West.""** | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Capitalist"] >= 8`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...` | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[166]` | **""The future lies in Sollism.""** | `[83]` **Player**: ""I'll remind you of the revoluti..."<br>`[84]` **Player**: ""I will not let any of my fellow..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Sollist"] >= 7`<br>`(Variable["BaseGame.Malenyevist"] >= 6) == false` | `Variable["BaseGameSupport.News_Turn07_HP_Sollism"] = true...` | `[101]` **Narrator**: "I took another deep breath. Luci..." |
| `[212]` | **""I'd like to speak about the events of the past months, about a great historic eff..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[219]` **Player**: ""I took office with a plan. To d..."<br>*(oraz 2 innych odgałęzień)* |
| `[213]` | **""I'd like to speak about the events of the past months, about a great historic eff..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[219]` **Player**: ""I took office with a plan. To d..."<br>*(oraz 2 innych odgałęzień)* |
| `[217]` | **""I soared to election on the winds of change. Change that was desperately sought a..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[219]` **Player**: ""I took office with a plan. To d..."<br>*(oraz 2 innych odgałęzień)* |
| `[218]` | **""From the moment I was sworn in, I have done nothing but fight to achieve the chan..."** | `[212]` **Player**: ""I'd like to speak about the eve..."<br>`[213]` **Player**: ""I'd like to speak about the eve..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Player**: ""However, due to circumstances b..."<br>`[226]` **Player**: ""Alas, my vision was too grand f..."<br>*(oraz 1 innych odgałęzień)* |
| `[219]` | **""I took office with a plan. To dismantle Sordland's ancient government structure a..."** | `[212]` **Player**: ""I'd like to speak about the eve..."<br>`[213]` **Player**: ""I'd like to speak about the eve..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `-- continue;` | `[225]` **Player**: ""However, due to circumstances b..."<br>`[226]` **Player**: ""Alas, my vision was too grand f..."<br>*(oraz 1 innych odgałęzień)* |
| `[223]` | **""I began my term with one goal: To transform Sordland into a modern democracy.""** | `[212]` **Player**: ""I'd like to speak about the eve..."<br>`[213]` **Player**: ""I'd like to speak about the eve..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `-- continue;` | `[225]` **Player**: ""However, due to circumstances b..."<br>`[227]` **Player**: ""My ambition did not waver, even..."<br>*(oraz 2 innych odgałęzień)* |
| `[224]` | **""I began my term with one goal: To transform Sordland into a global force to be re..."** | `[212]` **Player**: ""I'd like to speak about the eve..."<br>`[213]` **Player**: ""I'd like to speak about the eve..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[225]` **Player**: ""However, due to circumstances b..."<br>`[227]` **Player**: ""My ambition did not waver, even..."<br>*(oraz 2 innych odgałęzień)* |
| `[225]` | **""However, due to circumstances beyond my control, my plans were thwarted.""** | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[224]` **Player**: ""I began my term with one goal: ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Player**: ""If the Justices had their way, ..."<br>`[235]` **Player**: ""The Justices could not conceive..."<br>*(oraz 4 innych odgałęzień)* |
| `[226]` | **""Alas, my vision was too grand for the narrow scope of our current Supreme Court.""** | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[224]` **Player**: ""I began my term with one goal: ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true` | *Brak zmian stanu* | `[252]` **Player**: ""If the Justices had their way, ..."<br>`[235]` **Player**: ""The Justices could not conceive..."<br>*(oraz 1 innych odgałęzień)* |
| `[227]` | **""My ambition did not waver, even as forces within my own government conspired agai..."** | `[224]` **Player**: ""I began my term with one goal: ..."<br>`[223]` **Player**: ""I began my term with one goal: ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Player**: ""If the Justices had their way, ..."<br>`[235]` **Player**: ""The Justices could not conceive..."<br>*(oraz 4 innych odgałęzień)* |
| `[231]` | **""Alas, my vision was too grand for the narrow scope of our current Assembly.""** | `[218]` **Player**: ""From the moment I was sworn in,..."<br>`[224]` **Player**: ""I began my term with one goal: ..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false` | *Brak zmian stanu* | `[246]` **Player**: ""The Assembly could not conceive..."<br>`[251]` **Player**: ""If Assembly members had their w..."<br>*(oraz 1 innych odgałęzień)* |
| `[235]` | **""The Justices could not conceive of a Sordland in which they weren't free to engag..."** | `[226]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`<br>`Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true` | *Brak zmian stanu* | `[256]` **Player**: ""When I refused to play their di..."<br>`[253]` **Player**: ""And so they spitefully acted ag..."<br>*(oraz 1 innych odgałęzień)* |
| `[239]` | **""The Assembly could not conceive of a Sordland in which minority voices were repre..."** | `[231]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`<br>`(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false` | `-- continue;` | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 2 innych odgałęzień)* |
| `[246]` | **""The Assembly could not conceive of a Sordland in which they had no power to remov..."** | `[231]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`<br>`(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false` | *Brak zmian stanu* | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 2 innych odgałęzień)* |
| `[250]` | **""The Justices could not conceive of a Sordland in which they were unable to interf..."** | `[226]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true`<br>`Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true` | *Brak zmian stanu* | `[256]` **Player**: ""When I refused to play their di..."<br>`[253]` **Player**: ""And so they spitefully acted ag..."<br>*(oraz 1 innych odgałęzień)* |
| `[251]` | **""If Assembly members had their way, Tarquin Soll's Constitution would last until t..."** | `[231]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`<br>`(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false` | *Brak zmian stanu* | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 2 innych odgałęzień)* |
| `[252]` | **""If the Justices had their way, Tarquin Soll's Constitution would last until the e..."** | `[226]` **Player**: ""Alas, my vision was too grand f..."<br>`[225]` **Player**: ""However, due to circumstances b..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true` | `-- continue;` | `[256]` **Player**: ""When I refused to play their di..."<br>`[253]` **Player**: ""And so they spitefully acted ag..."<br>*(oraz 3 innych odgałęzień)* |
| `[253]` | **""And so they spitefully acted against me, putting their own pettiness before the n..."** | `[235]` **Player**: ""The Justices could not conceive..."<br>`[246]` **Player**: ""The Assembly could not conceive..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[254]` | **""They stubbornly clung to Sordland's past, knowing it would cost us the country's ..."** | `[235]` **Player**: ""The Justices could not conceive..."<br>`[246]` **Player**: ""The Assembly could not conceive..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[255]` | **""And so they struck down my reforms -- with the help of Soll himself.""** | `[246]` **Player**: ""The Assembly could not conceive..."<br>`[251]` **Player**: ""If Assembly members had their w..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false` | *Brak zmian stanu* | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[256]` | **""When I refused to play their dirty games, they banded together against me.""** | `[235]` **Player**: ""The Justices could not conceive..."<br>`[250]` **Player**: ""The Justices could not conceive..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[257]` | **""But I will tell you this: I am not done fighting for you.""** | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych odgałęzień)* |
| `[258]` | **""People of Sordland, Anton Rayne will not let himself be so easily cowed.""** | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych odgałęzień)* |
| `[259]` | **""They may have defeated me, but they will never defeat the Sordish spirit!""** | `[253]` **Player**: ""And so they spitefully acted ag..."<br>`[254]` **Player**: ""They stubbornly clung to Sordla..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych odgałęzień)* |
| `[260]` | **""Historians shall look upon this as but a minor hurdle in Sordland's path to great..."** | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Player**: ""The future is in our hands.""<br>`[296]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[261]` | **""It is time to put this setback behind us and focus on the challenges ahead.""** | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Player**: ""The future is in our hands.""<br>`[296]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[262]` | **""I have not given up on my commitment to equality and justice.""** | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[290]` **Player**: ""The future is in our hands.""<br>`[296]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[266]` | **""I have not given up on my commitment to restore Sordland to glory.""** | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[290]` **Player**: ""The future is in our hands.""<br>`[296]` **Player**: ""The future lies in the Democrat..."<br>*(oraz 3 innych odgałęzień)* |
| `[267]` | **""Sordland must slowly put more power in the hands of the working class, which capi..."** | `[269]` **Player**: ""The future lies in the Socialis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 4 innych odgałęzień)* |
| `[269]` | **""The future lies in the Socialist Movement of the East.""** | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Malenyevist"] >= 6` | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[291]` **Player**: ""We must take lessons from the M..."<br>`[267]` **Player**: ""Sordland must slowly put more p..."<br>*(oraz 1 innych odgałęzień)* |
| `[270]` | **""We must lead Sordland with social democracy.""** | `[296]` **Player**: ""The future lies in the Democrat..." | `Variable["BaseGame.Malenyevist"] >= 6` | `-- continue;` | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 3 innych odgałęzień)* |
| `[272]` | **""The future lies in Sollism.""** | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Sollist"] >= 7`<br>`(Variable["BaseGame.Malenyevist"] >= 6) == false` | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 3 innych odgałęzień)* |
| `[285]` | **""We must take lessons from Arcasia's democracy.""** | `[296]` **Player**: ""The future lies in the Democrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 4 innych odgałęzień)* |
| `[286]` | **""We must keep striving for a fair and transparent democracy in Sordland and abroad.""** | `[296]` **Player**: ""The future lies in the Democrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 4 innych odgałęzień)* |
| `[288]` | **""The future lies in the capitalism of the West.""** | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Capitalist"] >= 8`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capi...` | `[307]` **Player**: ""And with our new allies in the ..."<br>`[308]` **Player**: ""And with our new allies in the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[290]` | **""The future is in our hands.""** | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 4 innych odgałęzień)* |
| `[291]` | **""We must take lessons from the Malenyevist revolution in United Contana.""** | `[269]` **Player**: ""The future lies in the Socialis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 4 innych odgałęzień)* |
| `[295]` | **""We must lead Sordland with democratic socialism.""** | `[269]` **Player**: ""The future lies in the Socialis..." | `Variable["BaseGame.Democratic"] >= 6` | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[307]` **Player**: ""And with our new allies in the ..."<br>`[317]` **Player**: ""And with law and order on our s..."<br>*(oraz 3 innych odgałęzień)* |
| `[296]` | **""The future lies in the Democratic Movement of the West.""** | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Reformist_Path"] == true` | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[285]` **Player**: ""We must take lessons from Arcas..."<br>`[286]` **Player**: ""We must keep striving for a fai..."<br>*(oraz 1 innych odgałęzień)* |
| `[307]` | **""And with our new allies in the PFJP, there is no end to what we can achieve.""** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 7 innych węzłów)* | `Variable["BaseGame.Reform_Alliance_PFJP"] == true` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[308]` | **""And with our new allies in the NFP, there is no end to what we can achieve.""** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 7 innych węzłów)* | `Variable["BaseGame.Reform_Alliance_NFP"] == true`<br>`(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[309]` | **""With or without the Assembly's support, there is no end to what we can achieve.""** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 7 innych węzłów)* | `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`<br>`(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[310]` | **""And with the Supreme Court on our side, there is no end to what we can achieve.""** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Faction_OldGuard_Content"] == true`<br>`(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`<br>`(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[317]` | **""And with the forces of law and order on our side, there is no end to what we can ..."** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 6 innych węzłów)* | `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[318]` | **""Together, as a country, there is no end to what we can achieve.""** | `[267]` **Player**: ""Sordland must slowly put more p..."<br>`[285]` **Player**: ""We must take lessons from Arcas..."<br>*(oraz 6 innych węzłów)* | `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[320]` | **""With reform now off the table, I shall keep following through on my promise to im..."** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Education"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[324]` | **""Yet even they would have passed my reforms -- if Soll himself hadn't intervened.""** | `[246]` **Player**: ""The Assembly could not conceive..."<br>`[251]` **Player**: ""If Assembly members had their w..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true` | *Brak zmian stanu* | `[257]` **Player**: ""But I will tell you this: I am ..."<br>`[258]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[325]` | **""He may have defeated me, but he will never defeat the Sordish spirit!""** | `[324]` **Player**: ""Yet even they would have passed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Player**: ""Historians shall look upon this..."<br>`[261]` **Player**: ""It is time to put this setback ..."<br>*(oraz 2 innych odgałęzień)* |
| `[350]` | **""With reform now off the table, I shall keep following through on my promise to im..."** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[351]` | **""With reform now off the table, I shall keep following through on my promise to im..."** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Security"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[352]` | **""With reform now off the table, I shall keep following through on my promise to im..."** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Military"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[353]` | **""With reform off the table, I shall renew my focus on Sordland's military.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Military"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[354]` | **""With reform now off the table, I shall renew my focus on national security.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Security"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[355]` | **""With reform now off the table, I shall renew my focus on healthcare.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[356]` | **""With reform now off the table, I shall renew my focus on education.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Education"] == true` | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[357]` | **""We will start by focusing on the economy.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[358]` | **""We will start by focusing on eliminating internal and external threats.""** | `[319]` **Narrator**: "I took a deep breath. Lucian sho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[360]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[359]` | **""I thank you for standing by me, your president. Both in good times and bad.""** | `[320]` **Player**: ""With reform now off the table, ..."<br>`[350]` **Player**: ""With reform now off the table, ..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[365]` **Player**: ""God bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[360]` | **""I'd like to thank my wife and children for standing by me.""** | `[320]` **Player**: ""With reform now off the table, ..."<br>`[350]` **Player**: ""With reform now off the table, ..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Narrator**: "There was a slight hitch in my v..."<br>`[363]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>*(oraz 3 innych odgałęzień)* |
| `[361]` | **""I'd like to thank my Vice President, Petr Vectern, for standing by me.""** | `[320]` **Player**: ""With reform now off the table, ..."<br>`[350]` **Player**: ""With reform now off the table, ..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[365]` **Player**: ""God bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[362]` | **""I'd like to thank my chief strategist Lucian Galade for standing by me.""** | `[320]` **Player**: ""With reform now off the table, ..."<br>`[350]` **Player**: ""With reform now off the table, ..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Narrator**: "Lucian smiled to himself slightly." |
| `[363]` | **""A'Morgna wes core! Vectern sis da!""** | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[361]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[364]` | **""That is all. Thank you.""** | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[361]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[365]` | **""God bless Sordland.""** | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[361]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[366]` | **""I salute you all with respect.""** | `[359]` **Player**: ""I thank you for standing by me,..."<br>`[361]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[376]` | **""I soared to election on the winds of change. Change that was desperately sought a..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_Path"] == true`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych odgałęzień)* |
| `[377]` | **""I took office with a plan. To lead Sordland out of recession and into greatness.""** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_Path"] == true`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych odgałęzień)* |
| `[378]` | **""When I took office, I hoped to lead Sordland into a new era of peace and prosperi..."** | `[13]` **Player**: ""Brothers and sisters...""<br>`[14]` **Player**: ""My fellow Sords...""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_Path"] == true`<br>`(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych odgałęzień)* |
| `[379]` | **""But I was forced to lay aside my aspirations as the country faced an unprecedente..."** | `[376]` **Player**: ""I soared to election on the win..."<br>`[377]` **Player**: ""I took office with a plan. To l..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych odgałęzień)* |
| `[380]` | **""But you know what they say about the best laid plans.""** | `[376]` **Player**: ""I soared to election on the win..."<br>`[377]` **Player**: ""I took office with a plan. To l..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych odgałęzień)* |
| `[381]` | **""But before I could change Sordland, Sordland itself changed drastically.""** | `[376]` **Player**: ""I soared to election on the win..."<br>`[377]` **Player**: ""I took office with a plan. To l..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych odgałęzień)* |
| `[382]` | **""My inauguration was marked by a brutal assassination.""** | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych odgałęzień)* |
| `[383]` | **""Even as I was sworn in, tensions skyrocketed between the Red Youth and Young Sords.""** | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych odgałęzień)* |
| `[384]` | **""No sooner was I inaugurated than the threat of Bludish separatism raised its head.""** | `[379]` **Player**: ""But I was forced to lay aside m..."<br>`[380]` **Player**: ""But you know what they say abou..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych odgałęzień)* |
| `[385]` | **""Extraordinary times called for extraordinary measures. But my opponents couldn't ..."** | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..."<br>*(oraz 3 innych odgałęzień)* |
| `[386]` | **""My calls for unity during this time of strife went unanswered by my opponents.""** | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..."<br>*(oraz 3 innych odgałęzień)* |
| `[387]` | **""Even worse than the bloodshed were my opponents' attempts to use it to tear me do..."** | `[382]` **Player**: ""My inauguration was marked by a..."<br>`[383]` **Player**: ""Even as I was sworn in, tension..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..."<br>*(oraz 3 innych odgałęzień)* |
| `[388]` | **""Yet I stand before you today, stronger than ever!""** | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true` | *Brak zmian stanu* | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych odgałęzień)* |
| `[392]` | **""Their court defeat is proof that our current state of emergency is more than just..."** | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true` | *Brak zmian stanu* | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych odgałęzień)* |
| `[396]` | **""They let themselves become blinded by hatred, attacking me even after I revoked S..."** | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true`<br>`(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false` | *Brak zmian stanu* | `[404]` **Player**: ""All this infighting is blocking..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych odgałęzień)* |
| `[397]` | **""I was attacked by the opposition on one side, and the Supreme Court on the other...."** | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false` | *Brak zmian stanu* | `[404]` **Player**: ""All this infighting is blocking..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych odgałęzień)* |
| `[398]` | **""The opposition and the Supreme Court teamed up to remove my powers at the exact t..."** | `[385]` **Player**: ""Extraordinary times called for ..."<br>`[386]` **Player**: ""My calls for unity during this ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false`<br>`(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false` | *Brak zmian stanu* | `[404]` **Player**: ""All this infighting is blocking..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych odgałęzień)* |
| `[399]` | **""I do not take my new power lightly. Every order I give is for the sake of the cou..."** | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Player**: ""There are those who seek to tea..."<br>`[417]` **Player**: ""As God is my witness, I will pr..."<br>*(oraz 3 innych odgałęzień)* |
| `[400]` | **""I know you are counting on me to restore law and order to Sordland. And I will do..."** | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Player**: ""There are those who seek to tea..."<br>`[417]` **Player**: ""As God is my witness, I will pr..."<br>*(oraz 3 innych odgałęzień)* |
| `[401]` | **""I know you were counting on me to restore law and order to Sordland. And I still ..."** | `[396]` **Player**: ""They let themselves become blin..."<br>`[397]` **Player**: ""I was attacked by the oppositio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[402]` | **""Having vanquished my enemies within the government, I shall now turn my attention..."** | `[388]` **Player**: ""Yet I stand before you today, s..."<br>`[392]` **Player**: ""Their court defeat is proof tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Player**: ""There are those who seek to tea..."<br>`[417]` **Player**: ""As God is my witness, I will pr..."<br>*(oraz 3 innych odgałęzień)* |
| `[403]` | **""This infighting is a needless distraction from the real threats still raging with..."** | `[396]` **Player**: ""They let themselves become blin..."<br>`[397]` **Player**: ""I was attacked by the oppositio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[404]` | **""All this infighting is blocking me from accomplishing the original goals I had se..."** | `[396]` **Player**: ""They let themselves become blin..."<br>`[397]` **Player**: ""I was attacked by the oppositio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych odgałęzień)* |
| `[414]` | **""I alone can eradicate the threat of Bludish separatism!""** | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[423]` **Player**: ""I will not let foreign conflict..."<br>`[419]` **Player**: ""I will defend Sordland against ..."<br>*(oraz 3 innych odgałęzień)* |
| `[415]` | **""I alone can eradicate the threat of violent nationalism!""** | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[423]` **Player**: ""I will not let foreign conflict..."<br>`[419]` **Player**: ""I will defend Sordland against ..."<br>*(oraz 3 innych odgałęzień)* |
| `[416]` | **""I alone can eradicate the communist scourge!""** | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true` | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[423]` **Player**: ""I will not let foreign conflict..."<br>`[419]` **Player**: ""I will defend Sordland against ..."<br>*(oraz 3 innych odgałęzień)* |
| `[417]` | **""As God is my witness, I will protect Sordland from those who seek to destroy it f..."** | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Player**: ""I will not let foreign conflict..."<br>`[419]` **Player**: ""I will defend Sordland against ..."<br>*(oraz 3 innych odgałęzień)* |
| `[418]` | **""There are those who seek to tear Sordland apart from within -- but together, we w..."** | `[399]` **Player**: ""I do not take my new power ligh..."<br>`[400]` **Player**: ""I know you are counting on me t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Player**: ""I will not let foreign conflict..."<br>`[419]` **Player**: ""I will defend Sordland against ..."<br>*(oraz 3 innych odgałęzień)* |
| `[419]` | **""I will defend Sordland against our enemies abroad!""** | `[417]` **Player**: ""As God is my witness, I will pr..."<br>`[418]` **Player**: ""There are those who seek to tea..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false` | *Brak zmian stanu* | `[427]` **Player**: ""All this, while presiding over ..."<br>`[429]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[420]` | **""I will continue to show Arcasia no mercy!""** | `[417]` **Player**: ""As God is my witness, I will pr..."<br>`[418]` **Player**: ""There are those who seek to tea..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true` | *Brak zmian stanu* | `[427]` **Player**: ""All this, while presiding over ..."<br>`[429]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[421]` | **""I will continue to show Rumburg no mercy!""** | `[417]` **Player**: ""As God is my witness, I will pr..."<br>`[418]` **Player**: ""There are those who seek to tea..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true` | *Brak zmian stanu* | `[427]` **Player**: ""All this, while presiding over ..."<br>`[429]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[422]` | **""I will continue to show United Contana no mercy!""** | `[417]` **Player**: ""As God is my witness, I will pr..."<br>`[418]` **Player**: ""There are those who seek to tea..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true` | *Brak zmian stanu* | `[427]` **Player**: ""All this, while presiding over ..."<br>`[429]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[423]` | **""I will not let foreign conflicts distract us from the terror in our own backyards!""** | `[417]` **Player**: ""As God is my witness, I will pr..."<br>`[418]` **Player**: ""There are those who seek to tea..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Player**: ""All this, while presiding over ..."<br>`[429]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[427]` | **""All this, while presiding over the greatest economy Sordland has ever seen!""** | `[419]` **Player**: ""I will defend Sordland against ..."<br>`[420]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[428]` | **""All this, while bringing Sordland back from the depths of recession!""** | `[419]` **Player**: ""I will defend Sordland against ..."<br>`[420]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false` | *Brak zmian stanu* | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[429]` | **""I will continue to make Sordland richer than it has ever been!""** | `[419]` **Player**: ""I will defend Sordland against ..."<br>`[420]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[430]` | **""And I will continue cleaning up the economic mess my predecessors left me!""** | `[419]` **Player**: ""I will defend Sordland against ..."<br>`[420]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[443]` | **""I salute you all with respect.""** | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[462]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] ...`<br>`Variable["BaseGameSupport.News_Turn07_ST_AutocratSpeech_D...` | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[444]` | **""I thank you for standing by me, your president. Both in good times and bad.""** | `[448]` **Player**: ""I swore to improve healthcare i..."<br>`[465]` **Player**: ""And I hope I have fulfilled it ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[445]` **Player**: ""God bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[445]` | **""God bless Sordland.""** | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[462]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] ...`<br>`Variable["BaseGameSupport.News_Turn07_ST_AutocratSpeech_D...` | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[446]` | **""That is all. Thank you.""** | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[462]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] ...`<br>`Variable["BaseGameSupport.News_Turn07_ST_AutocratSpeech_D...` | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[447]` | **""A'Morgna wes core! Vectern sis da!""** | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[462]` **Player**: ""I'd like to thank my Vice Presi..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....`<br>`Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] ...`<br>*(+1 skryptów)* | `[112]` **Narrator**: "The director gave the cut signal..." |
| `[448]` | **""I swore to improve healthcare in Sordland. And even with all that's been going on..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[461]` | **""I'd like to thank my wife and children for standing by me.""** | `[448]` **Player**: ""I swore to improve healthcare i..."<br>`[465]` **Player**: ""And I hope I have fulfilled it ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[464]` **Narrator**: "There was a slight hitch in my v..."<br>`[447]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>*(oraz 3 innych odgałęzień)* |
| `[462]` | **""I'd like to thank my Vice President, Petr Vectern, for standing by me.""** | `[448]` **Player**: ""I swore to improve healthcare i..."<br>`[465]` **Player**: ""And I hope I have fulfilled it ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Player**: ""A'Morgna wes core! Vectern sis ..."<br>`[445]` **Player**: ""God bless Sordland.""<br>*(oraz 2 innych odgałęzień)* |
| `[463]` | **""I'd like to thank my chief strategist Lucian Galade for standing by me.""** | `[448]` **Player**: ""I swore to improve healthcare i..."<br>`[465]` **Player**: ""And I hope I have fulfilled it ..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Narrator**: "Lucian smiled to himself slightly." |
| `[465]` | **""And I hope I have fulfilled it to your satisfaction.""** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[466]` | **""I swore to improve Sordland's military. And I will use the rest of my time in off..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Military"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[467]` | **""I swore to improve national security in Sordland. And I will use the rest of my t..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Security"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[468]` | **""I swore to improve Sordland's military. And even with all that's been going on, I..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Military"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[469]` | **""I swore to improve education in Sordland. And even with all that's been going on,..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Education"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[473]` | **""I swore to improve national security in Sordland. And even with all that's been g..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`<br>`Variable["BaseGame.Promise_TermFocus_Security"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[475]` | **""I swore to improve education in Sordland. And I will use the rest of my time in o..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Education"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[476]` | **""I swore to improve education in Sordland. And I will use the rest of my time in o..."** | `[477]` **Player**: ""I have not forgotten the promis..."<br>`[478]` **Player**: ""When I was running for Presiden..." | `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`<br>`Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[444]` **Player**: ""I thank you for standing by me,..."<br>`[461]` **Player**: ""I'd like to thank my wife and c..."<br>*(oraz 2 innych odgałęzień)* |
| `[477]` | **""I have not forgotten the promise I made when you elected me.""** | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Player**: ""And I hope I have fulfilled it ..."<br>`[469]` **Player**: ""I swore to improve education in..."<br>*(oraz 7 innych odgałęzień)* |
| `[478]` | **""When I was running for President, I made you a promise.""** | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Player**: ""And I hope I have fulfilled it ..."<br>`[469]` **Player**: ""I swore to improve education in..."<br>*(oraz 7 innych odgałęzień)* |
| `[479]` | **""I will tell you this: I am not done fighting for you.""** | `[401]` **Player**: ""I know you were counting on me ..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Player**: ""One way or another, I will erad..."<br>`[492]` **Player**: ""One way or another, I will erad..."<br>*(oraz 3 innych odgałęzień)* |
| `[480]` | **""People of Sordland, Anton Rayne will not let himself be so easily cowed.""** | `[401]` **Player**: ""I know you were counting on me ..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Player**: ""One way or another, I will erad..."<br>`[492]` **Player**: ""One way or another, I will erad..."<br>*(oraz 3 innych odgałęzień)* |
| `[481]` | **""The court may have defeated me, but they will never defeat the Sordish spirit!""** | `[401]` **Player**: ""I know you were counting on me ..."<br>`[403]` **Player**: ""This infighting is a needless d..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Player**: ""One way or another, I will erad..."<br>`[492]` **Player**: ""One way or another, I will erad..."<br>*(oraz 3 innych odgałęzień)* |
| `[491]` | **""One way or another, I will eradicate the threat of Bludish separatism!""** | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[536]` **Player**: ""I will defend Sordland against ..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych odgałęzień)* |
| `[492]` | **""One way or another, I will eradicate the threat of violent nationalism!""** | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true` | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[536]` **Player**: ""I will defend Sordland against ..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych odgałęzień)* |
| `[493]` | **""One way or another, I will eradicate the communist scourge!""** | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true` | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[536]` **Player**: ""I will defend Sordland against ..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych odgałęzień)* |
| `[494]` | **""And I will continue cleaning up the economic mess my predecessors left me!""** | `[532]` **Player**: ""I will not let foreign conflict..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[495]` | **""I will not let a few fringe groups keep me from doing what I was elected to do!""** | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false` | *Brak zmian stanu* | `[536]` **Player**: ""I will defend Sordland against ..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych odgałęzień)* |
| `[496]` | **""I will continue to make Sordland richer than it has ever been!""** | `[532]` **Player**: ""I will not let foreign conflict..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[497]` | **""All this, while bringing Sordland back from the depths of recession!""** | `[532]` **Player**: ""I will not let foreign conflict..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false` | *Brak zmian stanu* | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[498]` | **""Even without stronger powers, I will remain tough on internal threats!""** | `[479]` **Player**: ""I will tell you this: I am not ..."<br>`[480]` **Player**: ""People of Sordland, Anton Rayne..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false` | *Brak zmian stanu* | `[536]` **Player**: ""I will defend Sordland against ..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych odgałęzień)* |
| `[502]` | **""All this, while presiding over the greatest economy Sordland has ever seen!""** | `[532]` **Player**: ""I will not let foreign conflict..."<br>`[533]` **Player**: ""I will continue to show Arcasia..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6` | `--continue;` | `[503]` **Narrator**: "I took a deep breath. Lucian sho..." |
| `[532]` | **""I will not let foreign conflicts get in the way of building this great nation!""** | `[495]` **Player**: ""I will not let a few fringe gro..."<br>`[498]` **Player**: ""Even without stronger powers, I..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false` | *Brak zmian stanu* | `[502]` **Player**: ""All this, while presiding over ..."<br>`[496]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[533]` | **""I will continue to show Arcasia no mercy!""** | `[495]` **Player**: ""I will not let a few fringe gro..."<br>`[498]` **Player**: ""Even without stronger powers, I..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true` | *Brak zmian stanu* | `[502]` **Player**: ""All this, while presiding over ..."<br>`[496]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[534]` | **""I will continue to show United Contana no mercy!""** | `[495]` **Player**: ""I will not let a few fringe gro..."<br>`[498]` **Player**: ""Even without stronger powers, I..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true` | *Brak zmian stanu* | `[502]` **Player**: ""All this, while presiding over ..."<br>`[496]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[535]` | **""I will continue to show Rumburg no mercy!""** | `[495]` **Player**: ""I will not let a few fringe gro..."<br>`[498]` **Player**: ""Even without stronger powers, I..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true` | *Brak zmian stanu* | `[502]` **Player**: ""All this, while presiding over ..."<br>`[496]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |
| `[536]` | **""I will defend Sordland against our enemies abroad!""** | `[495]` **Player**: ""I will not let a few fringe gro..."<br>`[498]` **Player**: ""Even without stronger powers, I..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Player**: ""All this, while presiding over ..."<br>`[496]` **Player**: ""I will continue to make Sordlan..."<br>*(oraz 2 innych odgałęzień)* |

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
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I walked into my office in the Maroon Palace to make my Address to the Nation speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "It was unusually crowded today. Cameras, lights and micro..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Yes. Let's do it.""]** — Mówca: **Player**
> ""Yes. Let's do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""Good. I think the crew is ready. As soon as you take you..."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Are you ready, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Yes. Let's do it.""*)
  - -> `[7]` (*Player: ""I am always ready.""*)
  - -> `[8]` (*Player: ""I guess.""*)

### Węzeł `[6]`
Mówca: **Narrator**
> "It was unusually crowded today. Cameras, lights and microphones were set in place and the crew was standing by, ready to start filming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""Are you ready, sir?""*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I am always ready.""]** — Mówca: **Player**
> ""I am always ready.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: ""Good. I think the crew is ready. As soon as you take you..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I guess.""]** — Mówca: **Player**
> ""I guess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""I'm sure you are, sir. As soon as you take your seat, we..."*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Good. I think the crew is ready. As soon as you take your seat, we can go live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I took my seat and rearranged my notes on the desk as a c..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""I'm sure you are, sir. As soon as you take your seat, we can go live. The crew is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I took my seat and rearranged my notes on the desk as a c..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I took my seat and rearranged my notes on the desk as a crew member powdered my face with a cotton puff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "After everybody was ready, the director gave the sign to ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "After everybody was ready, the director gave the sign to start filming. I looked directly into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""My fellow citizens...""*)
  - -> `[14]` (*Player: ""My fellow Sords...""*)
  - -> `[13]` (*Player: ""Brothers and sisters...""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""My fellow Sords...""]** — Mówca: **Player**
> ""My fellow Sords...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""My fellow citizens...""]** — Mówca: **Player**
> ""My fellow citizens...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I am grateful to earn the honor of finally modifying the Constitution of Tarquin Soll.""]** — Mówca: **Player**
> ""I am grateful to earn the honor of finally modifying the Constitution of Tarquin Soll.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Two years ago, I spoke to you of change, and we have acc..."*)
  - -> `[20]` (*Player: ""I am proud of what our government has accomplished. We h..."*)
  - -> `[19]` (*Player: ""We have reached a turning point in Sordland's history.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""I'd like to speak about our future, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about our future, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true` AND `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Two years ago, I spoke to you of change, and we have acc..."*)
  - -> `[20]` (*Player: ""I am proud of what our government has accomplished. We h..."*)
  - -> `[19]` (*Player: ""We have reached a turning point in Sordland's history.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I am happy to have this opportunity to talk to you about the changes we have undertaken in Sordland.""]** — Mówca: **Player**
> ""I am happy to have this opportunity to talk to you about the changes we have undertaken in Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Two years ago, I spoke to you of change, and we have acc..."*)
  - -> `[20]` (*Player: ""I am proud of what our government has accomplished. We h..."*)
  - -> `[19]` (*Player: ""We have reached a turning point in Sordland's history.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We have reached a turning point in Sordland's history.""]** — Mówca: **Player**
> ""We have reached a turning point in Sordland's history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player), `[17]` (Player), `[18]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""We need to remember where Sordland was two years ago. Th..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I am proud of what our government has accomplished. We have finally brought fairness and balance to our once-decrepit system.""]** — Mówca: **Player**
> ""I am proud of what our government has accomplished. We have finally brought fairness and balance to our once-decrepit system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player), `[17]` (Player), `[18]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""We need to remember where Sordland was two years ago. Th..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Two years ago, I spoke to you of change, and we have accomplished that.""]** — Mówca: **Player**
> ""Two years ago, I spoke to you of change, and we have accomplished that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Player), `[17]` (Player), `[18]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""But in another sense, our change is a continuation of th..."*)
  - -> `[22]` (*Player: ""We need to remember where Sordland was two years ago. Th..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""We need to remember where Sordland was two years ago. Those days are behind us now, and the change we brought has been real.""]** — Mówca: **Player**
> ""We need to remember where Sordland was two years ago. Those days are behind us now, and the change we brought has been real.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[20]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""But in another sense, our change is a continuation of that which started three decades ago with the fall of monarchy.""]** — Mówca: **Player**
> ""But in another sense, our change is a continuation of that which started three decades ago with the fall of monarchy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Democracy.""]** — Mówca: **Player**
> ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""The new system brings a more transparent democracy that will help Sordland rise up in the world.""]** — Mówca: **Player**
> ""The new system brings a more transparent democracy that will help Sordland rise up in the world.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""For the sake of fairness, simplicity, and growth, we had to radically change the structure of our government system.""]** — Mówca: **Player**
> ""For the sake of fairness, simplicity, and growth, we had to radically change the structure of our government system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Player), `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[38]` (*Player: ""I've spoken with and received letters from thousands of ..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We made a Constitution that no longer protects the rights of a select few elites, but ensures the participation of all.""]** — Mówca: **Player**
> ""We made a Constitution that no longer protects the rights of a select few elites, but ensures the participation of all.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Player), `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and fair for all.""]** — Mówca: **Player**
> ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and fair for all.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Player), `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "// contiue"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We will not rest until every Sordish citizen enjoys the freedom, dignity, and opportunity that is our birthright.""]** — Mówca: **Player**
> ""We will not rest until every Sordish citizen enjoys the freedom, dignity, and opportunity that is our birthright.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Fellow citizens of Sordland, let me assure you, our nati..."*)
  - -> `[81]` (*Player: ""Today, we must do what we know is right, and do it with ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""With our reforms complete, our government will now focus on the economic development of Sordland.""]** — Mówca: **Player**
> ""With our reforms complete, our government will now focus on the economic development of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Fellow citizens of Sordland, let me assure you, our nati..."*)
  - -> `[81]` (*Player: ""Today, we must do what we know is right, and do it with ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Now, we have our next challenges. We will be focusing on Sordland's internal and external threats.""]** — Mówca: **Player**
> ""Now, we have other challenges ahead. We will be focusing on Sordland's internal and external threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Fellow citizens of Sordland, let me assure you, our nati..."*)
  - -> `[81]` (*Player: ""Today, we must do what we know is right, and do it with ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I paused to take a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Now, we have our next challenges. We will be focusing on..."*)
  - -> `[30]` (*Player: ""With our reforms complete, our government will now focus..."*)
  - -> `[29]` (*Player: ""We will not rest until every Sordish citizen enjoys the ..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Next, we must transition into the parliamentary system.""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Next, we must transition into the parliamentary system.""]** — Mówca: **Player**
> ""Next, we must transition into the parliamentary system.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedParliamentarySystem = true; BaseG..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Henceforth, our government shall no longer be able to obstruct the will of the people.""]** — Mówca: **Player**
> ""Henceforth, our government shall no longer be able to obstruct the will of the people.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[129]` (Player), `[28]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""I've spoken with and received letters from thousands of you. I know how hungry you were for change. Make no mistake. Together, we can change Sordland forever.""]** — Mówca: **Player**
> ""I've spoken with and received letters from thousands of you. I know how hungry you were for change. Make no mistake. Together, we can change Sordland forever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[129]` (Player), `[28]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[63]` (*Player: ""We eliminated the Supreme Court's iron grip on our legis..."*)
  - -> `[64]` (*Player: ""A new age is upon us!""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as the democratization of Sordland because they close loopholes that benefit a privileged few.""]** — Mówca: **Player**
> ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as the democratization of Sordland because they close loopholes that benefit a privileged few.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[129]` (Player), `[28]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_Default == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""New term limits will ensure that no single person can bl..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""We have also lowered our unfair election threshold. No l..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""We did all of this in a time of economic stress and desp..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Weaker == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""We now ensure that neither I nor any other person who ho..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""I stand proud to have exchanged my own powers for a bett..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""I will personally make sure that every change is respect..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""By abolishing the position of Member of Honor, we have e..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: ""I promise you. We will not stop.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Decision_TrySoll == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""We will open the way for Tarquin Soll's trial. He must a..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Decision_TrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""We are creating a nation once again vibrant, robust, and..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Default == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""I must thank the Supreme Court Justices for supporting t..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""For too long, our Supreme Court has acted on behalf of s..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""New term limits will ensure that no single person can block change when it's most needed.""]** — Mówca: **Player**
> ""New term limits will ensure that no single person can block change when it's most needed.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[136]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Player: ""Beyond this, we intend to strengthen the democratic free..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We now ensure that neither I nor any other person who holds the position of president will pose the risk of ruling by decree.""]** — Mówca: **Player**
> ""We now ensure that neither I nor any other person who holds the position of president will pose the risk of ruling by decree.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[136]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Player: ""Beyond this, we intend to strengthen the democratic free..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We eliminated the Supreme Court's iron grip on our legislation.""]** — Mówca: **Player**
> ""We eliminated the Supreme Court's iron grip on our legislation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[136]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Player: ""Beyond this, we intend to strengthen the democratic free..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""A new age is upon us!""]** — Mówca: **Player**
> ""A new age is upon us!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Player), `[136]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Player: ""Beyond this, we intend to strengthen the democratic free..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I stand proud to have exchanged my own powers for a better future. Presidential decrees are now a thing of the past.""]** — Mówca: **Player**
> ""I stand proud to have exchanged my own powers for a better future. Presidential decrees are now a thing of the past.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[62]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[74]` (*Player: ""Voices were raised saying that we had to look to our pas..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""I will personally make sure that every change is respected and executed properly.""]** — Mówca: **Player**
> ""I will personally make sure that every change is respected and executed properly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[62]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[74]` (*Player: ""Voices were raised saying that we had to look to our pas..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Beyond this, we intend to strengthen the democratic freedoms of every Sordish citizen.""]** — Mówca: **Player**
> ""Beyond this, we intend to strengthen the democratic freedoms of every Sordish citizen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[62]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[74]` (*Player: ""Voices were raised saying that we had to look to our pas..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I must thank the Supreme Court Justices for supporting these much-needed changes.""]** — Mówca: **Player**
> ""I must thank the Supreme Court Justices for supporting these much-needed changes.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[62]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[74]` (*Player: ""Voices were raised saying that we had to look to our pas..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""For too long, our Supreme Court has acted on behalf of sinister deep state interests. That ends from now on.""]** — Mówca: **Player**
> ""For too long, our Supreme Court has acted on behalf of sinister deep state interests. That ends from now on.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[62]` (Player), `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[74]` (*Player: ""Voices were raised saying that we had to look to our pas..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""By abolishing the position of Member of Honor, we have ensured that Sordland will no longer be a slave to its past.""]** — Mówca: **Player**
> ""By abolishing the position of Member of Honor, we have ensured that Sordland will no longer be a slave to its past.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Player), `[66]` (Player), `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""It is time to renew our faith in our system.""*)
  - -> `[75]` (*Player: ""The new changes in our system have planted the seeds for..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I promise you. We will not stop.""]** — Mówca: **Player**
> ""I promise you. We will not stop.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Player), `[66]` (Player), `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""It is time to renew our faith in our system.""*)
  - -> `[75]` (*Player: ""The new changes in our system have planted the seeds for..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""We have also lowered our unfair election threshold. No longer will the voices of the minority be silenced.""]** — Mówca: **Player**
> ""We have also lowered our unfair election threshold. No longer will the voices of the minority be silenced.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Player), `[66]` (Player), `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""It is time to renew our faith in our system.""*)
  - -> `[75]` (*Player: ""The new changes in our system have planted the seeds for..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""We did all of this in a time of economic stress and despite heavy protests.""]** — Mówca: **Player**
> ""We did all of this in a time of economic stress and despite heavy protests.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Player), `[66]` (Player), `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""It is time to renew our faith in our system.""*)
  - -> `[75]` (*Player: ""The new changes in our system have planted the seeds for..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Voices were raised saying that we had to look to our past for greatness and glory. We proved, and will continue to prove them wrong.""]** — Mówca: **Player**
> ""Voices were raised saying that we had to look to our past for greatness and glory. We proved, and will continue to prove them wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Player), `[66]` (Player), `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""It is time to renew our faith in our system.""*)
  - -> `[75]` (*Player: ""The new changes in our system have planted the seeds for..."*)
  - -> `[78]` (*Player: ""But we, the present-day Sords, are not given to looking ..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""The new changes in our system have planted the seeds for untold future successes.""]** — Mówca: **Player**
> ""The new changes in our system have planted the seeds for untold future successes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player), `[71]` (Player), `[72]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""We will open the way for Tarquin Soll's trial. He must answer for the crimes committed during his decades-long rule.""]** — Mówca: **Player**
> ""We will open the way for Tarquin Soll's trial. He must answer for the crimes committed during his decades-long rule.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Kontekst wejściowy (poprzednik):** `[70]` (Player), `[71]` (Player), `[72]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll = true; BaseGameSupport..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We are creating a nation once again vibrant, robust, and alive.""]** — Mówca: **Player**
> ""We are creating a nation once again vibrant, robust, and alive.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Player), `[71]` (Player), `[72]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""But we, the present-day Sords, are not given to looking backward. In this blessed land, there is always a better tomorrow.""]** — Mówca: **Player**
> ""But we, the present-day Sords, are not given to looking backward. In this blessed land, there is always a better tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""It is time to renew our faith in our system.""]** — Mówca: **Player**
> ""It is time to renew our faith in our system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player), `[71]` (Player), `[72]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Fellow citizens of Sordland, let me assure you, our nation is poised for greatness.""]** — Mówca: **Player**
> ""Fellow citizens of Sordland, let me assure you, our nation is poised for greatness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""I'll remind you of the revolutionary phrase: 'Morning wi..."*)
  - -> `[84]` (*Player: ""I will not let any of my fellow citizens down.""*)
  - -> `[85]` (*Player: ""The United Sordland Party will keep fighting for a stron..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Today, we must do what we know is right, and do it with all of our might.""]** — Mówca: **Player**
> ""Today, we must do what we know is right, and do it with all of our might.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""I'll remind you of the revolutionary phrase: 'Morning wi..."*)
  - -> `[84]` (*Player: ""I will not let any of my fellow citizens down.""*)
  - -> `[85]` (*Player: ""The United Sordland Party will keep fighting for a stron..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Let history say of us: these were the golden years when Sordish Democracy was reborn, when Sordland reached for her best.""]** — Mówca: **Player**
> ""Let history say of us: these were the golden years when Sordish Democracy was reborn, when Sordland reached for her best.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""I'll remind you of the revolutionary phrase: 'Morning wi..."*)
  - -> `[84]` (*Player: ""I will not let any of my fellow citizens down.""*)
  - -> `[85]` (*Player: ""The United Sordland Party will keep fighting for a stron..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I'll remind you of the revolutionary phrase: 'Morning will come, Victory is close.' I am now glad to say that morning has finally come.""]** — Mówca: **Player**
> ""I'll remind you of the revolutionary phrase: 'Morning will come, Victory is close.' I am now glad to say that morning has finally come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player), `[81]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""The future is in our hands.""*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I will not let any of my fellow citizens down.""]** — Mówca: **Player**
> ""I will not let any of my fellow citizens down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player), `[81]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""The future is in our hands.""*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""The United Sordland Party will keep fighting for a stronger and more united Sordland.""]** — Mówca: **Player**
> ""The United Sordland Party will keep fighting for a stronger and more united Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player), `[81]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""The future is in our hands.""*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""The future lies in the Socialist Movement of the East.""]** — Mówca: **Player**
> ""The future lies in the Socialist Movement of the East.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player), `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1; BaseGameSupport.News_Turn07_HP..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""The future is in our hands.""]** — Mówca: **Player**
> ""The future is in our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player), `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_FutureInOurHands = true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""The future lies in the Democratic Movement of the West.""]** — Mówca: **Player**
> ""The future lies in the Democratic Movement of the West.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player), `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: ""We must take lessons from Arcasia's democracy.""*)
  - -> `[97]` (*Player: ""We must keep striving for a fair and transparent democra..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;
BaseGameSupport.News_Turn07_HP_Malenyevism = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGameSupport.News_Turn07_HP_Malenyevism"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""We must take lessons from the Malenyevist revolution in ..."*)
  - -> `[94]` (*Player: ""Sordland must slowly put more power in the hands of the ..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 6"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedParliamentarySystem = true;
BaseGameSupport.News_Turn07_LT_ParliamentarySystem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Speech_PromisedParliamentarySystem"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ParliamentarySystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: ""Fellow citizens of Sordland, let me assure you, our nati..."*)
  - -> `[81]` (*Player: ""Today, we must do what we know is right, and do it with ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll = true;
BaseGameSupport.News_Turn07_R_PromisedToTrySoll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;
Variable["BaseGameSupport.News_Turn07_R_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""We must take lessons from the Malenyevist revolution in United Contana.""]** — Mówca: **Player**
> ""We must take lessons from the Malenyevist revolution in United Contana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""]** — Mówca: **Player**
> ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""We must lead Sordland with democratic socialism.""]** — Mówca: **Player**
> ""We must lead Sordland with democratic socialism.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Democratic"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[86]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We must take lessons from Arcasia's democracy.""]** — Mówca: **Player**
> ""We must take lessons from Arcasia's democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""]** — Mówca: **Player**
> ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""We must lead Sordland with social democracy.""]** — Mówca: **Player**
> ""We must lead Sordland with social democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[88]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "I took another deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""For a Sordland of wisdom that honors the family, knowing..."*)
  - -> `[103]` (*Player: ""For a Sordland of vision that sees tomorrow's dreams in ..."*)
  - -> `[104]` (*Player: ""For a Sordland of courage whose servicemen and -women, e..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""For a Sordland of wisdom that honors the family, knowing that as the family goes, so goes our civilization.""]** — Mówca: **Player**
> ""For a Sordland of wisdom that honors the family, knowing that as the family goes, so goes our civilization.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""We have begun promisingly. But it's only a beginning.""*)
  - -> `[107]` (*Player: ""We're not here to congratulate ourselves on what we have..."*)
  - -> `[105]` (*Player: ""Let us begin by challenging our conventional wisdom.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""For a Sordland of vision that sees tomorrow's dreams in the learning and hard work we do today.""]** — Mówca: **Player**
> ""For a Sordland of vision that sees tomorrow's dreams in the learning and hard work we do today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""We have begun promisingly. But it's only a beginning.""*)
  - -> `[107]` (*Player: ""We're not here to congratulate ourselves on what we have..."*)
  - -> `[105]` (*Player: ""Let us begin by challenging our conventional wisdom.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""For a Sordland of courage whose servicemen and -women, even as I speak, proudly stand watch on the frontiers of freedom.""]** — Mówca: **Player**
> ""For a Sordland of courage whose service men and women, even as I speak, proudly stand watch on the frontiers of freedom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""We have begun promisingly. But it's only a beginning.""*)
  - -> `[107]` (*Player: ""We're not here to congratulate ourselves on what we have..."*)
  - -> `[105]` (*Player: ""Let us begin by challenging our conventional wisdom.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Let us begin by challenging our conventional wisdom.""]** — Mówca: **Player**
> ""Let us begin by challenging our conventional wisdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[103]` (Player), `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[110]` (*Player: ""God Bless Sordland.""*)
  - -> `[108]` (*Player: ""Thank you.""*)
  - -> `[111]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""We have begun promisingly. But it's only a beginning.""]** — Mówca: **Player**
> ""We have begun promisingly. But it's only a beginning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[103]` (Player), `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[110]` (*Player: ""God Bless Sordland.""*)
  - -> `[108]` (*Player: ""Thank you.""*)
  - -> `[111]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""We're not here to congratulate ourselves on what we have done, but to challenge ourselves to finish what has not yet been done.""]** — Mówca: **Player**
> ""We're not here to congratulate ourselves on what we have done, but to challenge ourselves to finish what has not yet been done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[103]` (Player), `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[110]` (*Player: ""God Bless Sordland.""*)
  - -> `[108]` (*Player: ""Thank you.""*)
  - -> `[111]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Player), `[106]` (Player), `[107]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Player), `[106]` (Player), `[107]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""God Bless Sordland.""]** — Mówca: **Player**
> ""God Bless Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Player), `[106]` (Player), `[107]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Player), `[106]` (Player), `[107]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "The director gave the cut signal, and the cameraman stopped filming. My speech was finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""I'd like to speak about our future, about a great histor..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""I'd like to speak about our future, about a great histor..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I'd like to speak about our future, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about our future, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` AND `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Two years ago, I spoke to you of change, and we have acc..."*)
  - -> `[20]` (*Player: ""I am proud of what our government has accomplished. We h..."*)
  - -> `[19]` (*Player: ""We have reached a turning point in Sordland's history.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""The new system brings a more transparent democracy that ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""The new system brings a stronger government that will he..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""Our new Constitution is a second revolution in the histo..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Our new Constitution is a second revolution in the histo..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""The new system brings a stronger government that will help Sordland rise up in the world.""]** — Mówca: **Player**
> ""The new system brings a stronger government that will help Sordland rise up in the world.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Power.""]** — Mówca: **Player**
> ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Power.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[26]` (*Player: ""For the sake of fairness, simplicity, and growth, we had..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""We made a Constitution that no longer protects the right..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""We made a Constitution that no longer protects the right..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""We made a Constitution that no longer protects the rights of a select few elites.""]** — Mówca: **Player**
> ""We made a Constitution that no longer protects the rights of a select few elites.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Player), `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and efficient.""]** — Mówca: **Player**
> ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and efficient.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Player), `[23]` (Player), `[24]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[38]` (*Player: ""I've spoken with and received letters from thousands of ..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""We transformed a system that had caused endless confusio..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""We transformed a system that had caused endless confusio..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""By now I'm sure you have one question on your minds: Wil..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""By now I'm sure you have one question on your minds: Wil..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as a strengthening of our system because they ensure efficiency and justice.""]** — Mówca: **Player**
> ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as a strengthening of our system because they ensure efficiency and justice.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[129]` (Player), `[28]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[63]` (*Player: ""We eliminated the Supreme Court's iron grip on our legis..."*)
  - -> `[64]` (*Player: ""A new age is upon us!""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Henceforth, our government shall no longer be able to obstruct the will of the people -- nor the will of the President.""]** — Mówca: **Player**
> ""Henceforth, our government shall no longer be able to obstruct the will of the people -- nor the will of the President.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Player), `[129]` (Player), `[28]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Henceforth, our government shall no longer be able to ob..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""Henceforth, our government shall no longer be able to ob..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: ""With my new powers as president, I will do whatever it t..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
**[WYBÓR GRACZA: ""With my new powers as president, I will do whatever it takes to transform this nation into a global superpower.""]** — Mówca: **Player**
> ""With my new powers as president, I will do whatever it takes to transform this nation into a global superpower.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true` AND `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Player), `[38]` (Player), `[136]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[67]` (*Player: ""Beyond this, we intend to strengthen the democratic free..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Let history say of us: these were the golden years when ..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Let history say of us: these were the golden years when ..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Let history say of us: these were the golden years when Sordland was reborn and reached for her best.""]** — Mówca: **Player**
> ""Let history say of us: these were the golden years when Sordland was reborn and reached for her best.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""I'll remind you of the revolutionary phrase: 'Morning wi..."*)
  - -> `[84]` (*Player: ""I will not let any of my fellow citizens down.""*)
  - -> `[85]` (*Player: ""The United Sordland Party will keep fighting for a stron..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: ""The future lies in the Democratic Movement of the West.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist >= 8"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""The future lies in the capitalism of the West.""]** — Mówca: **Player**
> ""The future lies in the capitalism of the West.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Capitalist"] >= 8` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player), `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1; BaseGameSupport.News_Turn07_HP_..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist >= 8"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Capitalist >= 8)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Capitalist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""The future lies in the capitalism of the West.""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Capitalist >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Capitalist"] >= 8) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 1;
BaseGameSupport.News_Turn07_HP_Capitalism = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;
Variable["BaseGameSupport.News_Turn07_HP_Capitalism"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 6)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: ""We must lead Sordland with social democracy.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 6)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""The future lies in the Socialist Movement of the East.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 7"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 7"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Sollist >= 7)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""The future lies in Sollism.""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Sollist >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 7) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA: ""The future lies in Sollism.""]** — Mówca: **Player**
> ""The future lies in Sollism.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Sollist"] >= 7` AND `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player), `[85]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_Sollism = true; BaseGame.S..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 6"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic >= 6)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""We must lead Sordland with democratic socialism.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_15)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1; BaseGame.Bludish_Opinion -= 1;"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2; BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3; BaseGame.Bludish_Opinion += 5;"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;
BaseGame.Bludish_Opinion += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Refo..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Refo..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Refo..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Re..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Limited"] == true  or  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Limited"] == true  or  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Loophole == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Veto_Loophole == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Loophole == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Veto_Loophole == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_NoImmunity == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_AddressToTheNation = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_AddressToTheNation = true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_NoImmunity == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_NoImmunity == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_AddressToTheNation = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reform Success]"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "Jump to: [Autocrat Speech]"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reform Loser]"*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""From the moment I was sworn in, I have done nothing but ..."*)
  - -> `[219]` (*Player: ""I took office with a plan. To dismantle Sordland's ancie..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""From the moment I was sworn in, I have done nothing but ..."*)
  - -> `[219]` (*Player: ""I took office with a plan. To dismantle Sordland's ancie..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""I'd like to speak about the events of the past months, a..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""I'd like to speak about the events of the past months, a..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""]** — Mówca: **Player**
> ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""From the moment I was sworn in, I have done nothing but ..."*)
  - -> `[219]` (*Player: ""I took office with a plan. To dismantle Sordland's ancie..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""From the moment I was sworn in, I have done nothing but fight to achieve the change you demanded.""]** — Mówca: **Player**
> ""From the moment I was sworn in, I have done nothing but fight to achieve the change you demanded.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Player), `[213]` (Player), `[217]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""However, due to circumstances beyond my control, my plan..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""I took office with a plan. To dismantle Sordland's ancient government structure and replace it with one that met the needs of the modern country we are today.""]** — Mówca: **Player**
> ""I took office with a plan. To dismantle Sordland's ancient government structure and replace it with one that met the needs of the country we are today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Player), `[213]` (Player), `[217]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: ""I began my term with one goal: To transform Sordland int..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: ""I began my term with one goal: To transform Sordland int..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I began my term with one goal: To transform Sordland into a modern democracy.""]** — Mówca: **Player**
> ""I began my term with one goal: To transform Sordland into a modern democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[212]` (Player), `[213]` (Player), `[217]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: ""I began my term with one goal: To transform Sordland into a global force to be reckoned with.""]** — Mówca: **Player**
> ""I began my term with one goal: To transform Sordland into a global force to be reckoned with.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[212]` (Player), `[213]` (Player), `[217]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""However, due to circumstances beyond my control, my plan..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[227]` (*Player: ""My ambition did not waver, even as forces within my own ..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""However, due to circumstances beyond my control, my plans were thwarted.""]** — Mówca: **Player**
> ""However, due to circumstances beyond my control, my plans were thwarted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Player), `[224]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Alas, my vision was too grand for the narrow scope of our current Supreme Court.""]** — Mówca: **Player**
> ""Alas, my vision was too grand for the narrow scope of our current Supreme Court.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[218]` (Player), `[224]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Amendment_NoCourt == true"*)
  - -> `[252]` (*Player: ""If the Justices had their way, Tarquin Soll's Constituti..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""My ambition did not waver, even as forces within my own government conspired against me.""]** — Mówca: **Player**
> ""My ambition did not waver, even as forces within my own government conspired against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Player), `[223]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Alas, my vision was too grand for the narrow scope of ou..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player: ""Alas, my vision was too grand for the narrow scope of ou..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Alas, my vision was too grand for the narrow scope of our current Assembly.""]** — Mówca: **Player**
> ""Alas, my vision was too grand for the narrow scope of our current Assembly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[218]` (Player), `[224]` (Player), `[219]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""The Justices could not conceive of a Sordland in which t..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
**[WYBÓR GRACZA: ""The Justices could not conceive of a Sordland in which they weren't free to engage in corruption and bribery, knowing nobody could remove them from office.""]** — Mówca: **Player**
> ""The Justices could not conceive of a Sordland in which they weren't free to engage in corruption and bribery, knowing nobody could remove them from office.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true` AND `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[226]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""When I refused to play their dirty games, they banded to..."*)
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""The Assembly could not conceive of a Sordland in which m..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
**[WYBÓR GRACZA: ""The Assembly could not conceive of a Sordland in which minority voices were represented and amplified.""]** — Mówca: **Player**
> ""The Assembly could not conceive of a Sordland in which minority voices were represented and amplified.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true` AND `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""The Assembly could not conceive of a Sordland in which t..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""If Assembly members had their way, Tarquin Soll's Consti..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_Success == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Amendment_NoCourt == true"*)
  - -> `[252]` (*Player: ""If the Justices had their way, Tarquin Soll's Constituti..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""The Assembly could not conceive of a Sordland in which they had no power to remove a beloved President from office.""]** — Mówca: **Player**
> ""The Assembly could not conceive of a Sordland in which they had no power to remove a beloved President from office.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true` AND `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Amendment_NoCourt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Amendment_NoCourt == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Amendment_NoCourt == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Amendment_NoCourt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: ""The Justices could not conceive of a Sordland in which t..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Amendment_NoCourt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[250]`
**[WYBÓR GRACZA: ""The Justices could not conceive of a Sordland in which they were unable to interfere in the constitutional amendment process.""]** — Mówca: **Player**
> ""The Justices could not conceive of a Sordland in which they were unable to interfere in the constitutional amendment process.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true` AND `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[226]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""When I refused to play their dirty games, they banded to..."*)
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA: ""If Assembly members had their way, Tarquin Soll's Constitution would last until the end of time.""]** — Mówca: **Player**
> ""If Assembly members had their way, Tarquin Soll's Constitution would last until the end of time.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false` AND `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[231]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: ""If the Justices had their way, Tarquin Soll's Constitution would last until the end of time -- and so would Soll's presidency.""]** — Mówca: **Player**
> ""If the Justices had their way, Tarquin Soll's Constitution would last until the end of time -- and so would Soll's presidency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[226]` (Player), `[225]` (Player), `[227]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[253]`
**[WYBÓR GRACZA: ""And so they spitefully acted against me, putting their own pettiness before the needs of this country.""]** — Mówca: **Player**
> ""And so they spitefully acted against me, putting their own pettiness before the needs of this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Player), `[246]` (Player), `[250]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""But I will tell you this: I am not done fighting for you.""*)
  - -> `[258]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[259]` (*Player: ""They may have defeated me, but they will never defeat th..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: ""They stubbornly clung to Sordland's past, knowing it would cost us the country's future.""]** — Mówca: **Player**
> ""They stubbornly clung to Sordland's past, knowing it would cost us the country's future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Player), `[246]` (Player), `[250]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""But I will tell you this: I am not done fighting for you.""*)
  - -> `[258]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[259]` (*Player: ""They may have defeated me, but they will never defeat th..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""And so they struck down my reforms -- with the help of Soll himself.""]** — Mówca: **Player**
> ""And so they struck down my reforms -- with the help of Soll himself.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player), `[251]` (Player), `[239]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""But I will tell you this: I am not done fighting for you.""*)
  - -> `[258]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[259]` (*Player: ""They may have defeated me, but they will never defeat th..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""When I refused to play their dirty games, they banded together against me.""]** — Mówca: **Player**
> ""When I refused to play their dirty games, they banded together against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Player), `[250]` (Player), `[252]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""But I will tell you this: I am not done fighting for you.""*)
  - -> `[258]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[259]` (*Player: ""They may have defeated me, but they will never defeat th..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: ""But I will tell you this: I am not done fighting for you.""]** — Mówca: **Player**
> ""But I will tell you this: I am not done fighting for you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Player), `[254]` (Player), `[255]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Historians shall look upon this as but a minor hurdle in..."*)
  - -> `[261]` (*Player: ""It is time to put this setback behind us and focus on th..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""]** — Mówca: **Player**
> ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Player), `[254]` (Player), `[255]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Historians shall look upon this as but a minor hurdle in..."*)
  - -> `[261]` (*Player: ""It is time to put this setback behind us and focus on th..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[259]`
**[WYBÓR GRACZA: ""They may have defeated me, but they will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""They may have defeated me, but they will never defeat the Sordish spirit!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Player), `[254]` (Player), `[255]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Historians shall look upon this as but a minor hurdle in..."*)
  - -> `[261]` (*Player: ""It is time to put this setback behind us and focus on th..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Historians shall look upon this as but a minor hurdle in Sordland's path to greatness.""]** — Mówca: **Player**
> ""Historians shall look upon this as but a minor hurdle in Sordland's path to greatness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Player), `[258]` (Player), `[259]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""The future is in our hands.""*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It is time to put this setback behind us and focus on the challenges ahead.""]** — Mówca: **Player**
> ""It is time to put this setback behind us and focus on the challenges ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Player), `[258]` (Player), `[259]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""The future is in our hands.""*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I have not given up on my commitment to equality and justice.""]** — Mówca: **Player**
> ""I have not given up on my commitment to equality and justice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[257]` (Player), `[258]` (Player), `[259]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""The future is in our hands.""*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player: ""I have not given up on my commitment to equality and jus..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""I have not given up on my commitment to restore Sordland..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""I have not given up on my commitment to restore Sordland to glory.""]** — Mówca: **Player**
> ""I have not given up on my commitment to restore Sordland to glory.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[257]` (Player), `[258]` (Player), `[259]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""The future is in our hands.""*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""]** — Mówca: **Player**
> ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""The future lies in the Socialist Movement of the East.""]** — Mówca: **Player**
> ""The future lies in the Socialist Movement of the East.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[260]` (Player), `[261]` (Player), `[262]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1;"*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""We must lead Sordland with social democracy.""]** — Mówca: **Player**
> ""We must lead Sordland with social democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[296]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""We must take lessons from the Malenyevist revolution in ..."*)
  - -> `[267]` (*Player: ""Sordland must slowly put more power in the hands of the ..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 6"*)

### Węzeł `[272]`
**[WYBÓR GRACZA: ""The future lies in Sollism.""]** — Mówca: **Player**
> ""The future lies in Sollism.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Sollist"] >= 7` AND `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Kontekst wejściowy (poprzednik):** `[260]` (Player), `[261]` (Player), `[262]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1;"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic >= 6"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic >= 6)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player: ""We must lead Sordland with democratic socialism.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 7"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Sollist >= 7)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: ""The future lies in Sollism.""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Sollist >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 7) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 6)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""The future lies in the Socialist Movement of the East.""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist >= 7"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player: ""The future lies in the Democratic Movement of the West.""*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist >= 8"*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""We must take lessons from Arcasia's democracy.""]** — Mówca: **Player**
> ""We must take lessons from Arcasia's democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""]** — Mówca: **Player**
> ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA: ""The future lies in the capitalism of the West.""]** — Mówca: **Player**
> ""The future lies in the capitalism of the West.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Capitalist"] >= 8` AND `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[260]` (Player), `[261]` (Player), `[262]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1;"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: ""We must take lessons from Arcasia's democracy.""*)
  - -> `[286]` (*Player: ""We must keep striving for a fair and transparent democra..."*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""The future is in our hands.""]** — Mówca: **Player**
> ""The future is in our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Player), `[261]` (Player), `[262]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA: ""We must take lessons from the Malenyevist revolution in United Contana.""]** — Mówca: **Player**
> ""We must take lessons from the Malenyevist revolution in United Contana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist >= 6"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist >= 6)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""We must lead Sordland with social democracy.""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[295]`
**[WYBÓR GRACZA: ""We must lead Sordland with democratic socialism.""]** — Mówca: **Player**
> ""We must lead Sordland with democratic socialism.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Democratic"] >= 6`
- **Kontekst wejściowy (poprzednik):** `[269]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[296]`
**[WYBÓR GRACZA: ""The future lies in the Democratic Movement of the West.""]** — Mówca: **Player**
> ""The future lies in the Democratic Movement of the West.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[260]` (Player), `[261]` (Player), `[262]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist >= 8"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Capitalist >= 8)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist >= 8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Capitalist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""The future lies in the capitalism of the West.""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Capitalist >= 8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Capitalist"] >= 8) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: ""And with our new allies in the PFJP, there is no end to ..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_NFP == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""And with our new allies in the NFP, there is no end to w..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""With or without the Assembly's support, there is no end ..."*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""And with our new allies in the PFJP, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with our new allies in the PFJP, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA: ""And with our new allies in the NFP, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with our new allies in the NFP, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Alliance_NFP"] == true` AND `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""With or without the Assembly's support, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""With or without the Assembly's support, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false` AND `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""And with the Supreme Court on our side, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with the Supreme Court on our side, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_OldGuard_Content"] == true` AND `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false` AND `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""And with the Supreme Court on our side, there is no end ..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == tru..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: ""And with the forces of law and order on our side, there ..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player: ""Together, as a country, there is no end to what we can a..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA: ""And with the forces of law and order on our side, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with law and order on our side, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA: ""Together, as a country, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""Together, as a country, there is no end to what we can achieve.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Player), `[285]` (Player), `[286]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "I took a deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: ""We will start by focusing on the economy.""*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[358]` (*Player: ""We will start by focusing on eliminating internal and ex..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's education system.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's education system.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Yet even they would have passed my reforms -- if Soll hi..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player: ""And so they struck down my reforms -- with the help of S..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Yet even they would have passed my reforms -- if Soll himself hadn't intervened.""]** — Mówca: **Player**
> ""Yet even they would have passed my reforms -- if Soll himself hadn't intervened.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player), `[251]` (Player), `[239]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""But I will tell you this: I am not done fighting for you.""*)
  - -> `[258]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[325]` (*Player: ""He may have defeated me, but he will never defeat the So..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: ""He may have defeated me, but he will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""He may have defeated me, but he will never defeat the Sordish spirit!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Historians shall look upon this as but a minor hurdle in..."*)
  - -> `[261]` (*Player: ""It is time to put this setback behind us and focus on th..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Security == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: ""With reform now off the table, I shall keep following th..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: ""With reform now off the table, I shall renew my focus on..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: ""With reform now off the table, I shall keep following th..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Player: ""With reform now off the table, I shall renew my focus on..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""With reform now off the table, I shall keep following th..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player: ""With reform now off the table, I shall renew my focus on..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: ""With reform now off the table, I shall keep following th..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player: ""With reform off the table, I shall renew my focus on Sor..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's healthcare system.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's healthcare system.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's national security.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's national security.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's military.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's military.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""With reform off the table, I shall renew my focus on Sordland's military.""]** — Mówca: **Player**
> ""With reform off the table, I shall renew my focus on Sordland's military.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on national security.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on national security.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on healthcare.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on healthcare.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on education.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on education.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""We will start by focusing on the economy.""]** — Mówca: **Player**
> ""We will start by focusing on the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""We will start by focusing on eliminating internal and external threats.""]** — Mówca: **Player**
> ""We will start by focusiing on eliminating internal and external threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[360]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[361]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[362]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I thank you for standing by me, your president. Both in good times and bad.""]** — Mówca: **Player**
> ""I thank you for standing by me, your president. Both in good times and bad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Player), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[365]` (*Player: ""God bless Sordland.""*)
  - -> `[364]` (*Player: ""That is all. Thank you.""*)
  - -> `[366]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I'd like to thank my wife and children for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my wife and children for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Player), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Player), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[365]` (*Player: ""God bless Sordland.""*)
  - -> `[364]` (*Player: ""That is all. Thank you.""*)
  - -> `[366]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I'd like to thank my chief strategist Lucian Galade for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my chief strategist Lucian Galade for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Player), `[350]` (Player), `[351]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "Lucian smiled to himself slightly."*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[359]` (Player), `[361]` (Player), `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[364]`
**[WYBÓR GRACZA: ""That is all. Thank you.""]** — Mówca: **Player**
> ""That is all. Thank you.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[359]` (Player), `[361]` (Player), `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[365]`
**[WYBÓR GRACZA: ""God bless Sordland.""]** — Mówca: **Player**
> ""God bless Sordland.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[359]` (Player), `[361]` (Player), `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[359]` (Player), `[361]` (Player), `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "There was a slight hitch in my voice as I said that. I ho..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[365]` (*Player: ""God bless Sordland.""*)
  - -> `[364]` (*Player: ""That is all. Thank you.""*)
  - -> `[366]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[370]`
Mówca: **Narrator**
> "Lucian smiled to himself slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[365]` (*Player: ""God bless Sordland.""*)
  - -> `[364]` (*Player: ""That is all. Thank you.""*)
  - -> `[366]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[371]`
Mówca: **Narrator**
> "There was a slight hitch in my voice as I said that. I hoped the mic hadn't picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[365]` (*Player: ""God bless Sordland.""*)
  - -> `[364]` (*Player: ""That is all. Thank you.""*)
  - -> `[366]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reform Loser`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: ""I soared to election on the winds of change. Change that..."*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reform Loser]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "Reform Loser"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Autocrat Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "Autocrat Speech"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Autocrat Speech`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""I soared to election on the winds of change. Change that..."*)
  - -> `[377]` (*Player: ""I took office with a plan. To lead Sordland out of reces..."*)
  - -> `[378]` (*Player: ""When I took office, I hoped to lead Sordland into a new ..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA: ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""]** — Mówca: **Player**
> ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""But I was forced to lay aside my aspirations as the coun..."*)
  - -> `[380]` (*Player: ""But you know what they say about the best laid plans.""*)
  - -> `[381]` (*Player: ""But before I could change Sordland, Sordland itself chan..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I took office with a plan. To lead Sordland out of recession and into greatness.""]** — Mówca: **Player**
> ""I took office with a plan. To lead Sordland out of recession and into greatness.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""But I was forced to lay aside my aspirations as the coun..."*)
  - -> `[380]` (*Player: ""But you know what they say about the best laid plans.""*)
  - -> `[381]` (*Player: ""But before I could change Sordland, Sordland itself chan..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""When I took office, I hoped to lead Sordland into a new era of peace and prosperity.""]** — Mówca: **Player**
> ""When I took office, I hoped to lead Sordland into a new era of peace and prosperity.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true` AND `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Player), `[14]` (Player), `[15]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""But I was forced to lay aside my aspirations as the coun..."*)
  - -> `[380]` (*Player: ""But you know what they say about the best laid plans.""*)
  - -> `[381]` (*Player: ""But before I could change Sordland, Sordland itself chan..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""But I was forced to lay aside my aspirations as the country faced an unprecedented emergency.""]** — Mówca: **Player**
> ""But I was forced to lay aside my aspirations as the country faced an unprecedented emergency.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[376]` (Player), `[377]` (Player), `[378]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: ""My inauguration was marked by a brutal assassination.""*)
  - -> `[383]` (*Player: ""Even as I was sworn in, tensions skyrocketed between the..."*)
  - -> `[384]` (*Player: ""No sooner was I inaugurated than the threat of Bludish s..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA: ""But you know what they say about the best laid plans.""]** — Mówca: **Player**
> ""But you know what they say about the best laid plans.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[376]` (Player), `[377]` (Player), `[378]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: ""My inauguration was marked by a brutal assassination.""*)
  - -> `[383]` (*Player: ""Even as I was sworn in, tensions skyrocketed between the..."*)
  - -> `[384]` (*Player: ""No sooner was I inaugurated than the threat of Bludish s..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA: ""But before I could change Sordland, Sordland itself changed drastically.""]** — Mówca: **Player**
> ""But before I could change Sordland, Sordland itself changed drastically.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[376]` (Player), `[377]` (Player), `[378]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: ""My inauguration was marked by a brutal assassination.""*)
  - -> `[383]` (*Player: ""Even as I was sworn in, tensions skyrocketed between the..."*)
  - -> `[384]` (*Player: ""No sooner was I inaugurated than the threat of Bludish s..."*)

### Węzeł `[382]`
**[WYBÓR GRACZA: ""My inauguration was marked by a brutal assassination.""]** — Mówca: **Player**
> ""My inauguration was marked by a brutal assassination.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Player), `[380]` (Player), `[381]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""Extraordinary times called for extraordinary measures. B..."*)
  - -> `[386]` (*Player: ""My calls for unity during this time of strife went unans..."*)
  - -> `[387]` (*Player: ""Even worse than the bloodshed were my opponents' attempt..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA: ""Even as I was sworn in, tensions skyrocketed between the Red Youth and Young Sords.""]** — Mówca: **Player**
> ""Even as I was sworn in, tensions skyrocketed between the Red Youth and Young Sords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Player), `[380]` (Player), `[381]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""Extraordinary times called for extraordinary measures. B..."*)
  - -> `[386]` (*Player: ""My calls for unity during this time of strife went unans..."*)
  - -> `[387]` (*Player: ""Even worse than the bloodshed were my opponents' attempt..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: ""No sooner was I inaugurated than the threat of Bludish separatism raised its head.""]** — Mówca: **Player**
> ""No sooner was I inaugurated than the threat of Bludish separatism raised its head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Player), `[380]` (Player), `[381]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""Extraordinary times called for extraordinary measures. B..."*)
  - -> `[386]` (*Player: ""My calls for unity during this time of strife went unans..."*)
  - -> `[387]` (*Player: ""Even worse than the bloodshed were my opponents' attempt..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA: ""Extraordinary times called for extraordinary measures. But my opponents couldn't see that.""]** — Mówca: **Player**
> ""Extraordinary times called for extraordinary measures. But my opponents couldn't see that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Player), `[383]` (Player), `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[386]`
**[WYBÓR GRACZA: ""My calls for unity during this time of strife went unanswered by my opponents.""]** — Mówca: **Player**
> ""My calls for unity during this time of strife went unanswered by my opponents.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Player), `[383]` (Player), `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[387]`
**[WYBÓR GRACZA: ""Even worse than the bloodshed were my opponents' attempts to use it to tear me down.""]** — Mówca: **Player**
> ""Even worse than the bloodshed were my opponents' attempts to use it to tear me down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Player), `[383]` (Player), `[384]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)

### Węzeł `[388]`
**[WYBÓR GRACZA: ""Yet I stand before you today, stronger than ever!""]** — Mówca: **Player**
> ""Yet I stand before you today, stronger than ever!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[385]` (Player), `[386]` (Player), `[387]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Player: ""I do not take my new power lightly. Every order I give i..."*)
  - -> `[400]` (*Player: ""I know you are counting on me to restore law and order t..."*)
  - -> `[402]` (*Player: ""Having vanquished my enemies within the government, I sh..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_CourtVote_Success == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_CourtVote_Success == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Player: ""Yet I stand before you today, stronger than ever!""*)
  - -> `[392]` (*Player: ""Their court defeat is proof that our current state of em..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player: ""I was attacked by the opposition on one side, and the Su..."*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true"*)

### Węzeł `[392]`
**[WYBÓR GRACZA: ""Their court defeat is proof that our current state of emergency is more than justified.""]** — Mówca: **Player**
> ""Their court defeat is proof that our current state of emergency is more than justified.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[385]` (Player), `[386]` (Player), `[387]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Player: ""I do not take my new power lightly. Every order I give i..."*)
  - -> `[400]` (*Player: ""I know you are counting on me to restore law and order t..."*)
  - -> `[402]` (*Player: ""Having vanquished my enemies within the government, I sh..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Player: ""They let themselves become blinded by hatred, attacking ..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player: ""The opposition and the Supreme Court teamed up to remove..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA: ""They let themselves become blinded by hatred, attacking me even after I revoked Sordland's state of emergency.""]** — Mówca: **Player**
> ""They let themselves become blinded by hatred, attacking me even after I revoked Sordland's state of emergency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true` AND `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[385]` (Player), `[386]` (Player), `[387]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player: ""All this infighting is blocking me from accomplishing th..."*)
  - -> `[403]` (*Player: ""This infighting is a needless distraction from the real ..."*)
  - -> `[401]` (*Player: ""I know you were counting on me to restore law and order ..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA: ""I was attacked by the opposition on one side, and the Supreme Court on the other. I couldn't win.""]** — Mówca: **Player**
> ""I was attacked by the opposition on one side, and the Supreme Court on the other. I couldn't win.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[385]` (Player), `[386]` (Player), `[387]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player: ""All this infighting is blocking me from accomplishing th..."*)
  - -> `[403]` (*Player: ""This infighting is a needless distraction from the real ..."*)
  - -> `[401]` (*Player: ""I know you were counting on me to restore law and order ..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA: ""The opposition and the Supreme Court teamed up to remove my powers at the exact time they were most needed.""]** — Mówca: **Player**
> ""The opposition and the Supreme Court teamed up to remove my powers at the exact time they were most needed.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false` AND `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[385]` (Player), `[386]` (Player), `[387]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player: ""All this infighting is blocking me from accomplishing th..."*)
  - -> `[403]` (*Player: ""This infighting is a needless distraction from the real ..."*)
  - -> `[401]` (*Player: ""I know you were counting on me to restore law and order ..."*)

### Węzeł `[399]`
**[WYBÓR GRACZA: ""I do not take my new power lightly. Every order I give is for the sake of the country.""]** — Mówca: **Player**
> ""I do not take my new power lightly. Every order I give is for the sake of the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Player), `[392]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""There are those who seek to tear Sordland apart from wit..."*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[417]` (*Player: ""As God is my witness, I will protect Sordland from those..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""I know you are counting on me to restore law and order to Sordland. And I will do so with all my might.""]** — Mówca: **Player**
> ""I know you are counting on me to restore law and order to Sordland. And I will do so with all my might.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Player), `[392]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""There are those who seek to tear Sordland apart from wit..."*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[417]` (*Player: ""As God is my witness, I will protect Sordland from those..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA: ""I know you were counting on me to restore law and order to Sordland. And I still plan to do so.""]** — Mówca: **Player**
> ""I know you were counting on me to restore law and order to Sordland. And I still plan to do so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Player), `[397]` (Player), `[398]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player: ""I will tell you this: I am not done fighting for you.""*)
  - -> `[480]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[481]` (*Player: ""The court may have defeated me, but they will never defe..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA: ""Having vanquished my enemies within the government, I shall now turn my attention to our *real* foes.""]** — Mówca: **Player**
> ""Having vanquished my enemies within the government, I shall now turn my attention to our *real* foes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Player), `[392]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""There are those who seek to tear Sordland apart from wit..."*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[417]` (*Player: ""As God is my witness, I will protect Sordland from those..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: ""This infighting is a needless distraction from the real threats still raging within our borders.""]** — Mówca: **Player**
> ""This infighting is a needless distraction from the real threats still raging within our borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Player), `[397]` (Player), `[398]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player: ""I will tell you this: I am not done fighting for you.""*)
  - -> `[480]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[481]` (*Player: ""The court may have defeated me, but they will never defe..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA: ""All this infighting is blocking me from accomplishing the original goals I had set as your President.""]** — Mówca: **Player**
> ""All this infighting is blocking me from accomplishing the original goals I had set as your President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Player), `[397]` (Player), `[398]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Player: ""I will tell you this: I am not done fighting for you.""*)
  - -> `[480]` (*Player: ""People of Sordland, Anton Rayne will not let himself be ..."*)
  - -> `[481]` (*Player: ""The court may have defeated me, but they will never defe..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player: ""I alone can eradicate the threat of Bludish separatism!""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player: ""I alone can eradicate the threat of violent nationalism!""*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Player: ""I alone can eradicate the communist scourge!""*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
**[WYBÓR GRACZA: ""I alone can eradicate the threat of Bludish separatism!""]** — Mówca: **Player**
> ""I alone can eradicate the threat of Bludish separatism!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[399]` (Player), `[400]` (Player), `[402]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 2"*)

### Węzeł `[415]`
**[WYBÓR GRACZA: ""I alone can eradicate the threat of violent nationalism!""]** — Mówca: **Player**
> ""I alone can eradicate the threat of violent nationalism!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[399]` (Player), `[400]` (Player), `[402]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 3"*)

### Węzeł `[416]`
**[WYBÓR GRACZA: ""I alone can eradicate the communist scourge!""]** — Mówca: **Player**
> ""I alone can eradicate the communist scourge!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Kontekst wejściowy (poprzednik):** `[399]` (Player), `[400]` (Player), `[402]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 5"*)

### Węzeł `[417]`
**[WYBÓR GRACZA: ""As God is my witness, I will protect Sordland from those who seek to destroy it from within!""]** — Mówca: **Player**
> ""As God is my witness, I will protect Sordland from those who seek to destroy it from within!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Player), `[400]` (Player), `[402]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[423]` (*Player: ""I will not let foreign conflicts distract us from the te..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA: ""There are those who seek to tear Sordland apart from within -- but together, we will beat them!""]** — Mówca: **Player**
> ""There are those who seek to tear Sordland apart from within -- but together, we will beat them!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Player), `[400]` (Player), `[402]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[423]` (*Player: ""I will not let foreign conflicts distract us from the te..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I will defend Sordland against our enemies abroad!""]** — Mówca: **Player**
> ""I will defend Sordland against our enemies abroad!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[417]` (Player), `[418]` (Player), `[414]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[420]`
**[WYBÓR GRACZA: ""I will continue to show Arcasia no mercy!""]** — Mówca: **Player**
> ""I will continue to show Arcasia no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Kontekst wejściowy (poprzednik):** `[417]` (Player), `[418]` (Player), `[414]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[421]`
**[WYBÓR GRACZA: ""I will continue to show Rumburg no mercy!""]** — Mówca: **Player**
> ""I will continue to show Rumburg no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Kontekst wejściowy (poprzednik):** `[417]` (Player), `[418]` (Player), `[414]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[422]`
**[WYBÓR GRACZA: ""I will continue to show United Contana no mercy!""]** — Mówca: **Player**
> ""I will continue to show United Contana no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Kontekst wejściowy (poprzednik):** `[417]` (Player), `[418]` (Player), `[414]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[423]`
**[WYBÓR GRACZA: ""I will not let foreign conflicts distract us from the terror in our own backyards!""]** — Mówca: **Player**
> ""I will not let foreign conflicts distract us from the terror in our own backyards!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Player), `[418]` (Player), `[414]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player: ""All this, while presiding over the greatest economy Sord..."*)
  - -> `[429]` (*Player: ""I will continue to make Sordland richer than it has ever..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player: ""And I will continue cleaning up the economic mess my pre..."*)
  - -> `[428]` (*Player: ""All this, while bringing Sordland back from the depths o..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA: ""All this, while presiding over the greatest economy Sordland has ever seen!""]** — Mówca: **Player**
> ""All this, while presiding over the greatest economy Sordland has ever seen!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Kontekst wejściowy (poprzednik):** `[419]` (Player), `[420]` (Player), `[421]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[428]`
**[WYBÓR GRACZA: ""All this, while bringing Sordland back from the depths of recession!""]** — Mówca: **Player**
> ""All this, while bringing Sordland back from the depths of recession!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Kontekst wejściowy (poprzednik):** `[419]` (Player), `[420]` (Player), `[421]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA: ""I will continue to make Sordland richer than it has ever been!""]** — Mówca: **Player**
> ""I will continue to make Sordland richer than it has ever been!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Kontekst wejściowy (poprzednik):** `[419]` (Player), `[420]` (Player), `[421]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[430]`
**[WYBÓR GRACZA: ""And I will continue cleaning up the economic mess my predecessors left me!""]** — Mówca: **Player**
> ""And I will continue cleaning up the economic mess my predecessors left me!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Kontekst wejściowy (poprzednik):** `[419]` (Player), `[420]` (Player), `[421]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Security == true)"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[443]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[444]` (Player), `[462]` (Player), `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_AutocratSpeech = true"*)

### Węzeł `[444]`
**[WYBÓR GRACZA: ""I thank you for standing by me, your president. Both in good times and bad.""]** — Mówca: **Player**
> ""I thank you for standing by me, your president. Both in good times and bad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Player), `[465]` (Player), `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[445]` (*Player: ""God bless Sordland.""*)
  - -> `[446]` (*Player: ""That is all. Thank you.""*)
  - -> `[443]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA: ""God bless Sordland.""]** — Mówca: **Player**
> ""God bless Sordland.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[444]` (Player), `[462]` (Player), `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_AutocratSpeech = true"*)

### Węzeł `[446]`
**[WYBÓR GRACZA: ""That is all. Thank you.""]** — Mówca: **Player**
> ""That is all. Thank you.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[444]` (Player), `[462]` (Player), `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_AutocratSpeech = true"*)

### Węzeł `[447]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[444]` (Player), `[462]` (Player), `[464]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[448]`
**[WYBÓR GRACZA: ""I swore to improve healthcare in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve healthcare in Sordland. And even with all that's been going on, I succeeded.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Player: ""I swore to improve education in Sordland. And even with ..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Player: ""I swore to improve education in Sordland. And I will use..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Player: ""I swore to improve healthcare in Sordland. And even with..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player: ""I swore to improve education in Sordland. And I will use..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Player: ""I swore to improve national security in Sordland. And ev..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player: ""I swore to improve national security in Sordland. And I ..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player: ""I swore to improve Sordland's military. And even with al..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player: ""I swore to improve Sordland's military. And I will use t..."*)

### Węzeł `[461]`
**[WYBÓR GRACZA: ""I'd like to thank my wife and children for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my wife and children for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Player), `[465]` (Player), `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[462]`
**[WYBÓR GRACZA: ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Player), `[465]` (Player), `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[445]` (*Player: ""God bless Sordland.""*)
  - -> `[446]` (*Player: ""That is all. Thank you.""*)
  - -> `[443]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA: ""I'd like to thank my chief strategist Lucian Galade for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my chief strategist Lucian Galade for standing by me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Player), `[465]` (Player), `[466]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Narrator: "Lucian smiled to himself slightly."*)

### Węzeł `[464]`
Mówca: **Narrator**
> "There was a slight hitch in my voice as I said that. I hoped the mic hadn't picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[445]` (*Player: ""God bless Sordland.""*)
  - -> `[446]` (*Player: ""That is all. Thank you.""*)
  - -> `[443]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[465]`
**[WYBÓR GRACZA: ""And I hope I have fulfilled it to your satisfaction.""]** — Mówca: **Player**
> ""And I hope I have fulfilled it to your satisfaction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[466]`
**[WYBÓR GRACZA: ""I swore to improve Sordland's military. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve Sordland's military. And I will use the rest of my time in office to do so.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA: ""I swore to improve national security in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve national security in Sordland. And I will use the rest of my time in office to do so.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[468]`
**[WYBÓR GRACZA: ""I swore to improve Sordland's military. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve Sordland's military. And even with all that's been going on, I succeeded.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[469]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And even with all that's been going on, I succeeded.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Narrator: "There was a slight hitch in my voice as I said that. I ho..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[445]` (*Player: ""God bless Sordland.""*)
  - -> `[446]` (*Player: ""That is all. Thank you.""*)
  - -> `[443]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[473]`
**[WYBÓR GRACZA: ""I swore to improve national security in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve national security in Sordland. And even with all that's been going on, I succeeded.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true` AND `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[474]`
Mówca: **Narrator**
> "Lucian smiled to himself slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: ""A'Morgna wes core! Vectern sis da!""*)
  - -> `[445]` (*Player: ""God bless Sordland.""*)
  - -> `[446]` (*Player: ""That is all. Thank you.""*)
  - -> `[443]` (*Player: ""I salute you all with respect.""*)

### Węzeł `[475]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[476]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false` AND `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[477]` (Player), `[478]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I thank you for standing by me, your president. Both in ..."*)
  - -> `[461]` (*Player: ""I'd like to thank my wife and children for standing by me.""*)
  - -> `[462]` (*Player: ""I'd like to thank my Vice President, Petr Vectern, for s..."*)
  - -> `[463]` (*Player: ""I'd like to thank my chief strategist Lucian Galade for ..."*)

### Węzeł `[477]`
**[WYBÓR GRACZA: ""I have not forgotten the promise I made when you elected me.""]** — Mówca: **Player**
> ""I have not forgotten the promise I made when you elected me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[503]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Player: ""And I hope I have fulfilled it to your satisfaction.""*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[478]`
**[WYBÓR GRACZA: ""When I was running for President, I made you a promise.""]** — Mówca: **Player**
> ""When I was running for President, I made you a promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[503]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Player: ""And I hope I have fulfilled it to your satisfaction.""*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[479]`
**[WYBÓR GRACZA: ""I will tell you this: I am not done fighting for you.""]** — Mówca: **Player**
> ""I will tell you this: I am not done fighting for you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Player), `[403]` (Player), `[404]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[480]`
**[WYBÓR GRACZA: ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""]** — Mówca: **Player**
> ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Player), `[403]` (Player), `[404]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[481]`
**[WYBÓR GRACZA: ""The court may have defeated me, but they will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""The court may have defeated me, but they will never defeat the Sordish spirit!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Player), `[403]` (Player), `[404]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player: ""One way or another, I will eradicate the threat of Bludi..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Player: ""One way or another, I will eradicate the threat of viole..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player: ""One way or another, I will eradicate the communist scour..."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Player: ""Even without stronger powers, I will remain tough on int..."*)
  - -> `[495]` (*Player: ""I will not let a few fringe groups keep me from doing wh..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the threat of Bludish separatism!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the threat of Bludish separatism!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[479]` (Player), `[480]` (Player), `[481]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 2"*)

### Węzeł `[492]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the threat of violent nationalism!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the threat of violent nationalism!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Kontekst wejściowy (poprzednik):** `[479]` (Player), `[480]` (Player), `[481]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 3"*)

### Węzeł `[493]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the communist scourge!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the communist scourge!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Kontekst wejściowy (poprzednik):** `[479]` (Player), `[480]` (Player), `[481]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 5"*)

### Węzeł `[494]`
**[WYBÓR GRACZA: ""And I will continue cleaning up the economic mess my predecessors left me!""]** — Mówca: **Player**
> ""And I will continue cleaning up the economic mess my predecessors left me!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Kontekst wejściowy (poprzednik):** `[532]` (Player), `[533]` (Player), `[534]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[495]`
**[WYBÓR GRACZA: ""I will not let a few fringe groups keep me from doing what I was elected to do!""]** — Mówca: **Player**
> ""I will not let a few fringe groups keep me from doing what I was elected to do!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[479]` (Player), `[480]` (Player), `[481]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: ""I will defend Sordland against our enemies abroad!""*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[496]`
**[WYBÓR GRACZA: ""I will continue to make Sordland richer than it has ever been!""]** — Mówca: **Player**
> ""I will continue to make Sordland richer than it has ever been!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Kontekst wejściowy (poprzednik):** `[532]` (Player), `[533]` (Player), `[534]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[497]`
**[WYBÓR GRACZA: ""All this, while bringing Sordland back from the depths of recession!""]** — Mówca: **Player**
> ""All this, while bringing Sordland back from the depths of recession!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Kontekst wejściowy (poprzednik):** `[532]` (Player), `[533]` (Player), `[534]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[498]`
**[WYBÓR GRACZA: ""Even without stronger powers, I will remain tough on internal threats!""]** — Mówca: **Player**
> ""Even without stronger powers, I will remain tough on internal threats!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[479]` (Player), `[480]` (Player), `[481]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: ""I will defend Sordland against our enemies abroad!""*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player: ""All this, while presiding over the greatest economy Sord..."*)
  - -> `[496]` (*Player: ""I will continue to make Sordland richer than it has ever..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player: ""And I will continue cleaning up the economic mess my pre..."*)
  - -> `[497]` (*Player: ""All this, while bringing Sordland back from the depths o..."*)

### Węzeł `[502]`
**[WYBÓR GRACZA: ""All this, while presiding over the greatest economy Sordland has ever seen!""]** — Mówca: **Player**
> ""All this, while presiding over the greatest economy Sordland has ever seen!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Kontekst wejściowy (poprzednik):** `[532]` (Player), `[533]` (Player), `[534]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "//continue"*)

### Węzeł `[503]`
Mówca: **Narrator**
> "I took a deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Player: ""I have not forgotten the promise I made when you elected..."*)
  - -> `[478]` (*Player: ""When I was running for President, I made you a promise.""*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// contiue`
- **Efekt skryptowy (`userScript`):** `-- contiue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[38]` (*Player: ""I've spoken with and received letters from thousands of ..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[38]` (*Player: ""I've spoken with and received letters from thousands of ..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[63]` (*Player: ""We eliminated the Supreme Court's iron grip on our legis..."*)
  - -> `[64]` (*Player: ""A new age is upon us!""*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[63]` (*Player: ""We eliminated the Supreme Court's iron grip on our legis..."*)
  - -> `[64]` (*Player: ""A new age is upon us!""*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_Default == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[63]` (*Player: ""We eliminated the Supreme Court's iron grip on our legis..."*)
  - -> `[64]` (*Player: ""A new age is upon us!""*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""However, due to circumstances beyond my control, my plan..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""However, due to circumstances beyond my control, my plan..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_Success == true"*)
  - -> `[227]` (*Player: ""My ambition did not waver, even as forces within my own ..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""When I refused to play their dirty games, they banded to..."*)
  - -> `[253]` (*Player: ""And so they spitefully acted against me, putting their o..."*)
  - -> `[254]` (*Player: ""They stubbornly clung to Sordland's past, knowing it wou..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//continue`
- **Efekt skryptowy (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//continue`
- **Efekt skryptowy (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//continue`
- **Efekt skryptowy (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//continue`
- **Efekt skryptowy (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "I took a deep breath. Lucian shooed a fly away from my fo..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reform Success`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""I am happy to have this opportunity to talk to you about..."*)
  - -> `[16]` (*Player: ""I am grateful to earn the honor of finally modifying the..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reform Success]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "Reform Success"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Address Ending]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "Address Ending"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Address Ending`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "The director gave the cut signal, and the cameraman stopp..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Address Ending]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "Address Ending"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Address Ending]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "Address Ending"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Player: ""I will continue to show Arcasia no mercy!""*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Player: ""I will continue to show Rumburg no mercy!""*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player: ""I will continue to show United Contana no mercy!""*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[532]`
**[WYBÓR GRACZA: ""I will not let foreign conflicts get in the way of building this great nation!""]** — Mówca: **Player**
> ""I will not let foreign conflicts get in the way of building this great nation!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[495]` (Player), `[498]` (Player), `[493]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[533]`
**[WYBÓR GRACZA: ""I will continue to show Arcasia no mercy!""]** — Mówca: **Player**
> ""I will continue to show Arcasia no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Kontekst wejściowy (poprzednik):** `[495]` (Player), `[498]` (Player), `[493]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[534]`
**[WYBÓR GRACZA: ""I will continue to show United Contana no mercy!""]** — Mówca: **Player**
> ""I will continue to show United Contana no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Kontekst wejściowy (poprzednik):** `[495]` (Player), `[498]` (Player), `[493]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[535]`
**[WYBÓR GRACZA: ""I will continue to show Rumburg no mercy!""]** — Mówca: **Player**
> ""I will continue to show Rumburg no mercy!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Kontekst wejściowy (poprzednik):** `[495]` (Player), `[498]` (Player), `[493]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[536]`
**[WYBÓR GRACZA: ""I will defend Sordland against our enemies abroad!""]** — Mówca: **Player**
> ""I will defend Sordland against our enemies abroad!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Player), `[498]` (Player), `[493]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player: ""I will not let foreign conflicts get in the way of build..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Player: ""I will continue to show United Contana no mercy!""*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player: ""I will continue to show Arcasia no mercy!""*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Player: ""I will continue to show Rumburg no mercy!""*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player: ""I will defend Sordland against our enemies abroad!""*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_Sollism = true; BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_Sollism"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_FutureInOurHands = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_FutureInOurHands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I took another deep breath. Lucian shooed a fly away from..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal =..."*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I paused to take a deep breath."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_AutocratSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal = true"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_AddressToTheNation = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_AddressToTheNation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true ..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[423]` (*Player: ""I will not let foreign conflicts distract us from the te..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[423]` (*Player: ""I will not let foreign conflicts distract us from the te..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 5`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[423]` (*Player: ""I will not let foreign conflicts distract us from the te..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 5`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: ""I will defend Sordland against our enemies abroad!""*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: ""I will defend Sordland against our enemies abroad!""*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Player: ""I will defend Sordland against our enemies abroad!""*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true &..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "Jump to: [Address Ending]"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_AutocratSpeech = true"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperati..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian and I walked into my office in the Maroon Palace t..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperationBegins = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperationBegins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian and I walked into my office in the Maroon Palace t..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
