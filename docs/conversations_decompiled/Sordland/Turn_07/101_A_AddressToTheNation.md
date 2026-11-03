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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 37
- **Węzły modyfikujące stan gry:** 52

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameSupport.News_Turn07_HP_Sollism`
- `BaseGameSupport.News_Turn07_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[89]` (Paskal Beniwoll): `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1; Variable["BaseGameSuppor...`
- Węzeł `[91]` (Paskal Beniwoll): `Variable["BaseGame.Speech_PromisedParliamentarySystem"] = true; Variable["BaseGameSupport.News_Tu...`
- Węzeł `[92]` (Paskal Beniwoll): `Variable["BaseGame.Speech_PromisedToTrySoll"] = true; Variable["BaseGameSupport.News_Turn07_R_Pro...`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- Węzeł `[156]` (Paskal Beniwoll): `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1; Variable["BaseGameSupport....`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1; Variable["BaseGame...`
- *...oraz 44 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I walked into my office in the Maroon Palace to make my Address to the Nation speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Yes. Let's do it.""]** — Mówca: **Player**
> ""Yes. Let's do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Are you ready, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Narrator**
> "It was unusually crowded today. Cameras, lights and microphones were set in place and the crew was standing by, ready to start filming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I am always ready.""]** — Mówca: **Player**
> ""I am always ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I guess.""]** — Mówca: **Player**
> ""I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Good. I think the crew is ready. As soon as you take your seat, we can go live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""I'm sure you are, sir. As soon as you take your seat, we can go live. The crew is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I took my seat and rearranged my notes on the desk as a crew member powdered my face with a cotton puff."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "After everybody was ready, the director gave the sign to start filming. I looked directly into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[13]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""My fellow Sords...""]** — Mówca: **Player**
> ""My fellow Sords...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""My fellow citizens...""]** — Mówca: **Player**
> ""My fellow citizens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I am grateful to earn the honor of finally modifying the Constitution of Tarquin Soll.""]** — Mówca: **Player**
> ""I am grateful to earn the honor of finally modifying the Constitution of Tarquin Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""I'd like to speak about our future, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about our future, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I am happy to have this opportunity to talk to you about the changes we have undertaken in Sordland.""]** — Mówca: **Player**
> ""I am happy to have this opportunity to talk to you about the changes we have undertaken in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[19]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We have reached a turning point in Sordland's history.""]** — Mówca: **Player**
> ""We have reached a turning point in Sordland's history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[120]`
  - -> `[117]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I am proud of what our government has accomplished. We have finally brought fairness and balance to our once-decrepit system.""]** — Mówca: **Player**
> ""I am proud of what our government has accomplished. We have finally brought fairness and balance to our once-decrepit system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[120]`
  - -> `[117]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Two years ago, I spoke to you of change, and we have accomplished that.""]** — Mówca: **Player**
> ""Two years ago, I spoke to you of change, and we have accomplished that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""We need to remember where Sordland was two years ago. Those days are behind us now, and the change we brought has been real.""]** — Mówca: **Player**
> ""We need to remember where Sordland was two years ago. Those days are behind us now, and the change we brought has been real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[125]`
  - -> `[26]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""But in another sense, our change is a continuation of that which started three decades ago with the fall of monarchy.""]** — Mówca: **Player**
> ""But in another sense, our change is a continuation of that which started three decades ago with the fall of monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[125]`
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Democracy.""]** — Mówca: **Player**
> ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[125]`
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""The new system brings a more transparent democracy that will help Sordland rise up in the world.""]** — Mówca: **Player**
> ""The new system brings a more transparent democracy that will help Sordland rise up in the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[125]`
  - -> `[26]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""For the sake of fairness, simplicity, and growth, we had to radically change the structure of our government system.""]** — Mówca: **Player**
> ""For the sake of fairness, simplicity, and growth, we had to radically change the structure of our government system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[38]`
  - -> `[138]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We made a Constitution that no longer protects the rights of a select few elites, but ensures the participation of all.""]** — Mówca: **Player**
> ""We made a Constitution that no longer protects the rights of a select few elites, but ensures the participation of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and fair for all.""]** — Mówca: **Player**
> ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and fair for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We will not rest until every Sordish citizen enjoys the freedom, dignity, and opportunity that is our birthright.""]** — Mówca: **Player**
> ""We will not rest until every Sordish citizen enjoys the freedom, dignity, and opportunity that is our birthright.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[145]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""With our reforms complete, our government will now focus on the economic development of Sordland.""]** — Mówca: **Player**
> ""With our reforms complete, our government will now focus on the economic development of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[145]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Now, we have our next challenges. We will be focusing on Sordland's internal and external threats.""]** — Mówca: **Player**
> ""Now, we have other challenges ahead. We will be focusing on Sordland's internal and external threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[145]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I paused to take a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[29]`
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Ministers_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Next, we must transition into the parliamentary system.""]** — Mówca: **Player**
> ""Next, we must transition into the parliamentary system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Henceforth, our government shall no longer be able to obstruct the will of the people.""]** — Mówca: **Player**
> ""Henceforth, our government shall no longer be able to obstruct the will of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""I've spoken with and received letters from thousands of you. I know how hungry you were for change. Make no mistake. Together, we can change Sordland forever.""]** — Mówca: **Player**
> ""I've spoken with and received letters from thousands of you. I know how hungry you were for change. Make no mistake. Together, we can change Sordland forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as the democratization of Sordland because they close loopholes that benefit a privileged few.""]** — Mówca: **Player**
> ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as the democratization of Sordland because they close loopholes that benefit a privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Decision_TrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""New term limits will ensure that no single person can block change when it's most needed.""]** — Mówca: **Player**
> ""New term limits will ensure that no single person can block change when it's most needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[67]`
  - -> `[58]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We now ensure that neither I nor any other person who holds the position of president will pose the risk of ruling by decree.""]** — Mówca: **Player**
> ""We now ensure that neither I nor any other person who holds the position of president will pose the risk of ruling by decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[67]`
  - -> `[58]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We eliminated the Supreme Court's iron grip on our legislation.""]** — Mówca: **Player**
> ""We eliminated the Supreme Court's iron grip on our legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[67]`
  - -> `[58]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""A new age is upon us!""]** — Mówca: **Player**
> ""A new age is upon us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[67]`
  - -> `[58]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I stand proud to have exchanged my own powers for a better future. Presidential decrees are now a thing of the past.""]** — Mówca: **Player**
> ""I stand proud to have exchanged my own powers for a better future. Presidential decrees are now a thing of the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[74]`
  - -> `[52]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""I will personally make sure that every change is respected and executed properly.""]** — Mówca: **Player**
> ""I will personally make sure that every change is respected and executed properly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[74]`
  - -> `[52]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Beyond this, we intend to strengthen the democratic freedoms of every Sordish citizen.""]** — Mówca: **Player**
> ""Beyond this, we intend to strengthen the democratic freedoms of every Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[74]`
  - -> `[52]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I must thank the Supreme Court Justices for supporting these much-needed changes.""]** — Mówca: **Player**
> ""I must thank the Supreme Court Justices for supporting these much-needed changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[74]`
  - -> `[52]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""For too long, our Supreme Court has acted on behalf of sinister deep state interests. That ends from now on.""]** — Mówca: **Player**
> ""For too long, our Supreme Court has acted on behalf of sinister deep state interests. That ends from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[74]`
  - -> `[52]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""By abolishing the position of Member of Honor, we have ensured that Sordland will no longer be a slave to its past.""]** — Mówca: **Player**
> ""By abolishing the position of Member of Honor, we have ensured that Sordland will no longer be a slave to its past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[75]`
  - -> `[55]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I promise you. We will not stop.""]** — Mówca: **Player**
> ""I promise you. We will not stop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[75]`
  - -> `[55]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""We have also lowered our unfair election threshold. No longer will the voices of the minority be silenced.""]** — Mówca: **Player**
> ""We have also lowered our unfair election threshold. No longer will the voices of the minority be silenced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[75]`
  - -> `[55]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""We did all of this in a time of economic stress and despite heavy protests.""]** — Mówca: **Player**
> ""We did all of this in a time of economic stress and despite heavy protests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[75]`
  - -> `[55]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Voices were raised saying that we had to look to our past for greatness and glory. We proved, and will continue to prove them wrong.""]** — Mówca: **Player**
> ""Voices were raised saying that we had to look to our past for greatness and glory. We proved, and will continue to prove them wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[75]`
  - -> `[78]`
  - -> `[55]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""The new changes in our system have planted the seeds for untold future successes.""]** — Mówca: **Player**
> ""The new changes in our system have planted the seeds for untold future successes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""We will open the way for Tarquin Soll's trial. He must answer for the crimes committed during his decades-long rule.""]** — Mówca: **Player**
> ""We will open the way for Tarquin Soll's trial. He must answer for the crimes committed during his decades-long rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We are creating a nation once again vibrant, robust, and alive.""]** — Mówca: **Player**
> ""We are creating a nation once again vibrant, robust, and alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""But we, the present-day Sords, are not given to looking backward. In this blessed land, there is always a better tomorrow.""]** — Mówca: **Player**
> ""But we, the present-day Sords, are not given to looking backward. In this blessed land, there is always a better tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""It is time to renew our faith in our system.""]** — Mówca: **Player**
> ""It is time to renew our faith in our system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Fellow citizens of Sordland, let me assure you, our nation is poised for greatness.""]** — Mówca: **Player**
> ""Fellow citizens of Sordland, let me assure you, our nation is poised for greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Today, we must do what we know is right, and do it with all of our might.""]** — Mówca: **Player**
> ""Today, we must do what we know is right, and do it with all of our might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Let history say of us: these were the golden years when Sordish Democracy was reborn, when Sordland reached for her best.""]** — Mówca: **Player**
> ""Let history say of us: these were the golden years when Sordish Democracy was reborn, when Sordland reached for her best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I'll remind you of the revolutionary phrase: 'Morning will come, Victory is close.' I am now glad to say that morning has finally come.""]** — Mówca: **Player**
> ""I'll remind you of the revolutionary phrase: 'Morning will come, Victory is close.' I am now glad to say that morning has finally come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[149]`
  - -> `[160]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I will not let any of my fellow citizens down.""]** — Mówca: **Player**
> ""I will not let any of my fellow citizens down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[149]`
  - -> `[160]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""The United Sordland Party will keep fighting for a stronger and more united Sordland.""]** — Mówca: **Player**
> ""The United Sordland Party will keep fighting for a stronger and more united Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[149]`
  - -> `[160]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""The future lies in the Socialist Movement of the East.""]** — Mówca: **Player**
> ""The future lies in the Socialist Movement of the East.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""The future is in our hands.""]** — Mówca: **Player**
> ""The future is in our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""The future lies in the Democratic Movement of the West.""]** — Mówca: **Player**
> ""The future lies in the Democratic Movement of the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[157]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;
BaseGameSupport.News_Turn07_HP_Malenyevism = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGameSupport.News_Turn07_HP_Malenyevism"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[167]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedParliamentarySystem = true;
BaseGameSupport.News_Turn07_LT_ParliamentarySystem = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Speech_PromisedParliamentarySystem"] = true;
Variable["BaseGameSupport.News_Turn07_LT_ParliamentarySystem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[145]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Speech_PromisedToTrySoll = true;
BaseGameSupport.News_Turn07_R_PromisedToTrySoll = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;
Variable["BaseGameSupport.News_Turn07_R_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""We must take lessons from the Malenyevist revolution in United Contana.""]** — Mówca: **Player**
> ""We must take lessons from the Malenyevist revolution in United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""]** — Mówca: **Player**
> ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""We must lead Sordland with democratic socialism.""]** — Mówca: **Player**
> ""We must lead Sordland with democratic socialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We must take lessons from Arcasia's democracy.""]** — Mówca: **Player**
> ""We must take lessons from Arcasia's democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""]** — Mówca: **Player**
> ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""We must lead Sordland with social democracy.""]** — Mówca: **Player**
> ""We must lead Sordland with social democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "I took another deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""For a Sordland of wisdom that honors the family, knowing that as the family goes, so goes our civilization.""]** — Mówca: **Player**
> ""For a Sordland of wisdom that honors the family, knowing that as the family goes, so goes our civilization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""For a Sordland of vision that sees tomorrow's dreams in the learning and hard work we do today.""]** — Mówca: **Player**
> ""For a Sordland of vision that sees tomorrow's dreams in the learning and hard work we do today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`
  - -> `[105]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""For a Sordland of courage whose servicemen and -women, even as I speak, proudly stand watch on the frontiers of freedom.""]** — Mówca: **Player**
> ""For a Sordland of courage whose service men and women, even as I speak, proudly stand watch on the frontiers of freedom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`
  - -> `[105]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Let us begin by challenging our conventional wisdom.""]** — Mówca: **Player**
> ""Let us begin by challenging our conventional wisdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[108]`
  - -> `[111]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""We have begun promisingly. But it's only a beginning.""]** — Mówca: **Player**
> ""We have begun promisingly. But it's only a beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[108]`
  - -> `[111]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""We're not here to congratulate ourselves on what we have done, but to challenge ourselves to finish what has not yet been done.""]** — Mówca: **Player**
> ""We're not here to congratulate ourselves on what we have done, but to challenge ourselves to finish what has not yet been done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[108]`
  - -> `[111]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""God Bless Sordland.""]** — Mówca: **Player**
> ""God Bless Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[112]`
Mówca: **Narrator**
> "The director gave the cut signal, and the cameraman stopped filming. My speech was finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I'd like to speak about our future, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about our future, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[19]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""The new system brings a stronger government that will help Sordland rise up in the world.""]** — Mówca: **Player**
> ""The new system brings a stronger government that will help Sordland rise up in the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[26]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Power.""]** — Mówca: **Player**
> ""Our new Constitution is a second revolution in the history of Sordland that truly transforms the course of government with just one word: Power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[125]`
  - -> `[26]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""We made a Constitution that no longer protects the rights of a select few elites.""]** — Mówca: **Player**
> ""We made a Constitution that no longer protects the rights of a select few elites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and efficient.""]** — Mówca: **Player**
> ""We transformed a system that had caused endless confusion and resentment into one that is clear, simple, and efficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[38]`
  - -> `[138]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as a strengthening of our system because they ensure efficiency and justice.""]** — Mówca: **Player**
> ""By now I'm sure you have one question on your minds: Will our reforms help you? You bet they will. We see them as a strengthening of our system because they ensure efficiency and justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Henceforth, our government shall no longer be able to obstruct the will of the people -- nor the will of the President.""]** — Mówca: **Player**
> ""Henceforth, our government shall no longer be able to obstruct the will of the people -- nor the will of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[144]`
**[WYBÓR GRACZA: ""With my new powers as president, I will do whatever it takes to transform this nation into a global superpower.""]** — Mówca: **Player**
> ""With my new powers as president, I will do whatever it takes to transform this nation into a global superpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[67]`
  - -> `[58]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Let history say of us: these were the golden years when Sordland was reborn and reached for her best.""]** — Mówca: **Player**
> ""Let history say of us: these were the golden years when Sordland was reborn and reached for her best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""The future lies in the capitalism of the West.""]** — Mówca: **Player**
> ""The future lies in the capitalism of the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist >= 8)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Capitalist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Capitalist >= 8))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Capitalist"] >= 8) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 1;
BaseGameSupport.News_Turn07_HP_Capitalism = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;
Variable["BaseGameSupport.News_Turn07_HP_Capitalism"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Sollist >= 7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 7) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA: ""The future lies in Sollism.""]** — Mówca: **Player**
> ""The future lies in Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2;
BaseGame.Bludish_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 3;
BaseGame.Bludish_Opinion += 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Limited"] == true  or  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Veto_Limited == true || BaseGame.Reform_Law_Veto_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Limited"] == true  or  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Veto_Loophole == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'unity' and 'hope' new meaning and power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`
  - -> `[220]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""]** — Mówca: **Player**
> ""I'd like to speak about the events of the past months, about a great historic effort to give the words 'freedom,' 'fairness,' and 'hope' new meaning and power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`
  - -> `[220]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[217]`
**[WYBÓR GRACZA: ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""]** — Mówca: **Player**
> ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`
  - -> `[220]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""From the moment I was sworn in, I have done nothing but fight to achieve the change you demanded.""]** — Mówca: **Player**
> ""From the moment I was sworn in, I have done nothing but fight to achieve the change you demanded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[228]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""I took office with a plan. To dismantle Sordland's ancient government structure and replace it with one that met the needs of the modern country we are today.""]** — Mówca: **Player**
> ""I took office with a plan. To dismantle Sordland's ancient government structure and replace it with one that met the needs of the country we are today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I began my term with one goal: To transform Sordland into a modern democracy.""]** — Mówca: **Player**
> ""I began my term with one goal: To transform Sordland into a modern democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[224]`
**[WYBÓR GRACZA: ""I began my term with one goal: To transform Sordland into a global force to be reckoned with.""]** — Mówca: **Player**
> ""I began my term with one goal: To transform Sordland into a global force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""However, due to circumstances beyond my control, my plans were thwarted.""]** — Mówca: **Player**
> ""However, due to circumstances beyond my control, my plans were thwarted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Alas, my vision was too grand for the narrow scope of our current Supreme Court.""]** — Mówca: **Player**
> ""Alas, my vision was too grand for the narrow scope of our current Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[247]`
  - -> `[252]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""My ambition did not waver, even as forces within my own government conspired against me.""]** — Mówca: **Player**
> ""My ambition did not waver, even as forces within my own government conspired against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Alas, my vision was too grand for the narrow scope of our current Assembly.""]** — Mówca: **Player**
> ""Alas, my vision was too grand for the narrow scope of our current Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[236]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
**[WYBÓR GRACZA: ""The Justices could not conceive of a Sordland in which they weren't free to engage in corruption and bribery, knowing nobody could remove them from office.""]** — Mówca: **Player**
> ""The Justices could not conceive of a Sordland in which they weren't free to engage in corruption and bribery, knowing nobody could remove them from office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[253]`
  - -> `[254]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
**[WYBÓR GRACZA: ""The Assembly could not conceive of a Sordland in which minority voices were represented and amplified.""]** — Mówca: **Player**
> ""The Assembly could not conceive of a Sordland in which minority voices were represented and amplified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[247]`
  - -> `[252]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[236]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""The Assembly could not conceive of a Sordland in which they had no power to remove a beloved President from office.""]** — Mówca: **Player**
> ""The Assembly could not conceive of a Sordland in which they had no power to remove a beloved President from office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[321]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Amendment_NoCourt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Amendment_NoCourt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Amendment_NoCourt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Amendment_NoCourt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[250]`
**[WYBÓR GRACZA: ""The Justices could not conceive of a Sordland in which they were unable to interfere in the constitutional amendment process.""]** — Mówca: **Player**
> ""The Justices could not conceive of a Sordland in which they were unable to interfere in the constitutional amendment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[253]`
  - -> `[254]`

### Węzeł `[251]`
**[WYBÓR GRACZA: ""If Assembly members had their way, Tarquin Soll's Constitution would last until the end of time.""]** — Mówca: **Player**
> ""If Assembly members had their way, Tarquin Soll's Constitution would last until the end of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[321]`

### Węzeł `[252]`
**[WYBÓR GRACZA: ""If the Justices had their way, Tarquin Soll's Constitution would last until the end of time -- and so would Soll's presidency.""]** — Mówca: **Player**
> ""If the Justices had their way, Tarquin Soll's Constitution would last until the end of time -- and so would Soll's presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[253]`
**[WYBÓR GRACZA: ""And so they spitefully acted against me, putting their own pettiness before the needs of this country.""]** — Mówca: **Player**
> ""And so they spitefully acted against me, putting their own pettiness before the needs of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[254]`
**[WYBÓR GRACZA: ""They stubbornly clung to Sordland's past, knowing it would cost us the country's future.""]** — Mówca: **Player**
> ""They stubbornly clung to Sordland's past, knowing it would cost us the country's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""And so they struck down my reforms -- with the help of Soll himself.""]** — Mówca: **Player**
> ""And so they struck down my reforms -- with the help of Soll himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""When I refused to play their dirty games, they banded together against me.""]** — Mówca: **Player**
> ""When I refused to play their dirty games, they banded together against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[259]`

### Węzeł `[257]`
**[WYBÓR GRACZA: ""But I will tell you this: I am not done fighting for you.""]** — Mówca: **Player**
> ""But I will tell you this: I am not done fighting for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[263]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""]** — Mówca: **Player**
> ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[263]`

### Węzeł `[259]`
**[WYBÓR GRACZA: ""They may have defeated me, but they will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""They may have defeated me, but they will never defeat the Sordish spirit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[263]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Historians shall look upon this as but a minor hurdle in Sordland's path to greatness.""]** — Mówca: **Player**
> ""Historians shall look upon this as but a minor hurdle in Sordland's path to greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[282]`
  - -> `[279]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It is time to put this setback behind us and focus on the challenges ahead.""]** — Mówca: **Player**
> ""It is time to put this setback behind us and focus on the challenges ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[282]`
  - -> `[279]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I have not given up on my commitment to equality and justice.""]** — Mówca: **Player**
> ""I have not given up on my commitment to equality and justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[282]`
  - -> `[279]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""I have not given up on my commitment to restore Sordland to glory.""]** — Mówca: **Player**
> ""I have not given up on my commitment to restore Sordland to glory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[282]`
  - -> `[279]`

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""]** — Mówca: **Player**
> ""Sordland must slowly put more power in the hands of the working class, which capitalism formerly oppressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""The future lies in the Socialist Movement of the East.""]** — Mówca: **Player**
> ""The future lies in the Socialist Movement of the East.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""We must lead Sordland with social democracy.""]** — Mówca: **Player**
> ""We must lead Sordland with social democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[267]`
  - -> `[273]`

### Węzeł `[272]`
**[WYBÓR GRACZA: ""The future lies in Sollism.""]** — Mówca: **Player**
> ""The future lies in Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist >= 7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Sollist"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Sollist >= 7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Sollist"] >= 7) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""We must take lessons from Arcasia's democracy.""]** — Mówca: **Player**
> ""We must take lessons from Arcasia's democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[286]`
**[WYBÓR GRACZA: ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""]** — Mówca: **Player**
> ""We must keep striving for a fair and transparent democracy in Sordland and abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[288]`
**[WYBÓR GRACZA: ""The future lies in the capitalism of the West.""]** — Mówca: **Player**
> ""The future lies in the capitalism of the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`
  - -> `[292]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""The future is in our hands.""]** — Mówca: **Player**
> ""The future is in our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[291]`
**[WYBÓR GRACZA: ""We must take lessons from the Malenyevist revolution in United Contana.""]** — Mówca: **Player**
> ""We must take lessons from the Malenyevist revolution in United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 6) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[295]`
**[WYBÓR GRACZA: ""We must lead Sordland with democratic socialism.""]** — Mówca: **Player**
> ""We must lead Sordland with democratic socialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[296]`
**[WYBÓR GRACZA: ""The future lies in the Democratic Movement of the West.""]** — Mówca: **Player**
> ""The future lies in the Democratic Movement of the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist >= 8)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Capitalist"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Capitalist >= 8))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Capitalist"] >= 8) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[311]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""And with our new allies in the PFJP, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with our new allies in the PFJP, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[308]`
**[WYBÓR GRACZA: ""And with our new allies in the NFP, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with our new allies in the NFP, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""With or without the Assembly's support, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""With or without the Assembly's support, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""And with the Supreme Court on our side, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with the Supreme Court on our side, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true || BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
**[WYBÓR GRACZA: ""And with the forces of law and order on our side, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""And with law and order on our side, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
**[WYBÓR GRACZA: ""Together, as a country, there is no end to what we can achieve.""]** — Mówca: **Player**
> ""Together, as a country, there is no end to what we can achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Narrator**
> "I took a deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[326]`
  - -> `[329]`
  - -> `[332]`
  - -> `[335]`
  - -> `[358]`

### Węzeł `[320]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's education system.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's education system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_LostBy1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_LostBy1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Yet even they would have passed my reforms -- if Soll himself hadn't intervened.""]** — Mówca: **Player**
> ""Yet even they would have passed my reforms -- if Soll himself hadn't intervened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[325]`

### Węzeł `[325]`
**[WYBÓR GRACZA: ""He may have defeated me, but he will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""He may have defeated me, but he will never defeat the Sordish spirit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[263]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Security == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[350]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's healthcare system.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's healthcare system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's national security.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[352]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall keep following through on my promise to improve Sordland's military.""]** — Mówca: **Player**
> ""With reform now off the table, I shall keep following through on my promise to improve Sordland's military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""With reform off the table, I shall renew my focus on Sordland's military.""]** — Mówca: **Player**
> ""With reform off the table, I shall renew my focus on Sordland's military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[354]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on national security.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[355]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on healthcare.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on healthcare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""With reform now off the table, I shall renew my focus on education.""]** — Mówca: **Player**
> ""With reform now off the table, I shall renew my focus on education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""We will start by focusing on the economy.""]** — Mówca: **Player**
> ""We will start by focusing on the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""We will start by focusing on eliminating internal and external threats.""]** — Mówca: **Player**
> ""We will start by focusiing on eliminating internal and external threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I thank you for standing by me, your president. Both in good times and bad.""]** — Mówca: **Player**
> ""I thank you for standing by me, your president. Both in good times and bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[364]`
  - -> `[366]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I'd like to thank my wife and children for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my wife and children for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[364]`
  - -> `[366]`

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I'd like to thank my chief strategist Lucian Galade for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my chief strategist Lucian Galade for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[363]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[364]`
**[WYBÓR GRACZA: ""That is all. Thank you.""]** — Mówca: **Player**
> ""That is all. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[365]`
**[WYBÓR GRACZA: ""God bless Sordland.""]** — Mówca: **Player**
> ""God bless Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[364]`
  - -> `[366]`

### Węzeł `[370]`
Mówca: **Narrator**
> "Lucian smiled to himself slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[364]`
  - -> `[366]`

### Węzeł `[371]`
Mówca: **Narrator**
> "There was a slight hitch in my voice as I said that. I hoped the mic hadn't picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[364]`
  - -> `[366]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Reform Loser)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[214]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reform Loser])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Autocrat Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Autocrat Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`
  - -> `[378]`

### Węzeł `[376]`
**[WYBÓR GRACZA: ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""]** — Mówca: **Player**
> ""I soared to election on the winds of change. Change that was desperately sought and called for by you, the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I took office with a plan. To lead Sordland out of recession and into greatness.""]** — Mówca: **Player**
> ""I took office with a plan. To lead Sordland out of recession and into greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""When I took office, I hoped to lead Sordland into a new era of peace and prosperity.""]** — Mówca: **Player**
> ""When I took office, I hoped to lead Sordland into a new era of peace and prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`

### Węzeł `[379]`
**[WYBÓR GRACZA: ""But I was forced to lay aside my aspirations as the country faced an unprecedented emergency.""]** — Mówca: **Player**
> ""But I was forced to lay aside my aspirations as the country faced an unprecedented emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`

### Węzeł `[380]`
**[WYBÓR GRACZA: ""But you know what they say about the best laid plans.""]** — Mówca: **Player**
> ""But you know what they say about the best laid plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`

### Węzeł `[381]`
**[WYBÓR GRACZA: ""But before I could change Sordland, Sordland itself changed drastically.""]** — Mówca: **Player**
> ""But before I could change Sordland, Sordland itself changed drastically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`

### Węzeł `[382]`
**[WYBÓR GRACZA: ""My inauguration was marked by a brutal assassination.""]** — Mówca: **Player**
> ""My inauguration was marked by a brutal assassination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[383]`
**[WYBÓR GRACZA: ""Even as I was sworn in, tensions skyrocketed between the Red Youth and Young Sords.""]** — Mówca: **Player**
> ""Even as I was sworn in, tensions skyrocketed between the Red Youth and Young Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA: ""No sooner was I inaugurated than the threat of Bludish separatism raised its head.""]** — Mówca: **Player**
> ""No sooner was I inaugurated than the threat of Bludish separatism raised its head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[385]`
**[WYBÓR GRACZA: ""Extraordinary times called for extraordinary measures. But my opponents couldn't see that.""]** — Mówca: **Player**
> ""Extraordinary times called for extraordinary measures. But my opponents couldn't see that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
**[WYBÓR GRACZA: ""My calls for unity during this time of strife went unanswered by my opponents.""]** — Mówca: **Player**
> ""My calls for unity during this time of strife went unanswered by my opponents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[387]`
**[WYBÓR GRACZA: ""Even worse than the bloodshed were my opponents' attempts to use it to tear me down.""]** — Mówca: **Player**
> ""Even worse than the bloodshed were my opponents' attempts to use it to tear me down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
**[WYBÓR GRACZA: ""Yet I stand before you today, stronger than ever!""]** — Mówca: **Player**
> ""Yet I stand before you today, stronger than ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`
  - -> `[402]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[393]`

### Węzeł `[392]`
**[WYBÓR GRACZA: ""Their court defeat is proof that our current state of emergency is more than justified.""]** — Mówca: **Player**
> ""Their court defeat is proof that our current state of emergency is more than justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`
  - -> `[402]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Revoke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Revoke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[396]`
**[WYBÓR GRACZA: ""They let themselves become blinded by hatred, attacking me even after I revoked Sordland's state of emergency.""]** — Mówca: **Player**
> ""They let themselves become blinded by hatred, attacking me even after I revoked Sordland's state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[403]`
  - -> `[401]`

### Węzeł `[397]`
**[WYBÓR GRACZA: ""I was attacked by the opposition on one side, and the Supreme Court on the other. I couldn't win.""]** — Mówca: **Player**
> ""I was attacked by the opposition on one side, and the Supreme Court on the other. I couldn't win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[403]`
  - -> `[401]`

### Węzeł `[398]`
**[WYBÓR GRACZA: ""The opposition and the Supreme Court teamed up to remove my powers at the exact time they were most needed.""]** — Mówca: **Player**
> ""The opposition and the Supreme Court teamed up to remove my powers at the exact time they were most needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[403]`
  - -> `[401]`

### Węzeł `[399]`
**[WYBÓR GRACZA: ""I do not take my new power lightly. Every order I give is for the sake of the country.""]** — Mówca: **Player**
> ""I do not take my new power lightly. Every order I give is for the sake of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[405]`
  - -> `[408]`
  - -> `[411]`
  - -> `[417]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""I know you are counting on me to restore law and order to Sordland. And I will do so with all my might.""]** — Mówca: **Player**
> ""I know you are counting on me to restore law and order to Sordland. And I will do so with all my might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[405]`
  - -> `[408]`
  - -> `[411]`
  - -> `[417]`

### Węzeł `[401]`
**[WYBÓR GRACZA: ""I know you were counting on me to restore law and order to Sordland. And I still plan to do so.""]** — Mówca: **Player**
> ""I know you were counting on me to restore law and order to Sordland. And I still plan to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`
  - -> `[481]`

### Węzeł `[402]`
**[WYBÓR GRACZA: ""Having vanquished my enemies within the government, I shall now turn my attention to our *real* foes.""]** — Mówca: **Player**
> ""Having vanquished my enemies within the government, I shall now turn my attention to our *real* foes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[405]`
  - -> `[408]`
  - -> `[411]`
  - -> `[417]`

### Węzeł `[403]`
**[WYBÓR GRACZA: ""This infighting is a needless distraction from the real threats still raging within our borders.""]** — Mówca: **Player**
> ""This infighting is a needless distraction from the real threats still raging within our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`
  - -> `[481]`

### Węzeł `[404]`
**[WYBÓR GRACZA: ""All this infighting is blocking me from accomplishing the original goals I had set as your President.""]** — Mówca: **Player**
> ""All this infighting is blocking me from accomplishing the original goals I had set as your President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`
  - -> `[481]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[414]`
**[WYBÓR GRACZA: ""I alone can eradicate the threat of Bludish separatism!""]** — Mówca: **Player**
> ""I alone can eradicate the threat of Bludish separatism!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[415]`
**[WYBÓR GRACZA: ""I alone can eradicate the threat of violent nationalism!""]** — Mówca: **Player**
> ""I alone can eradicate the threat of violent nationalism!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[416]`
**[WYBÓR GRACZA: ""I alone can eradicate the communist scourge!""]** — Mówca: **Player**
> ""I alone can eradicate the communist scourge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[417]`
**[WYBÓR GRACZA: ""As God is my witness, I will protect Sordland from those who seek to destroy it from within!""]** — Mówca: **Player**
> ""As God is my witness, I will protect Sordland from those who seek to destroy it from within!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[543]`
  - -> `[546]`
  - -> `[540]`
  - -> `[423]`

### Węzeł `[418]`
**[WYBÓR GRACZA: ""There are those who seek to tear Sordland apart from within -- but together, we will beat them!""]** — Mówca: **Player**
> ""There are those who seek to tear Sordland apart from within -- but together, we will beat them!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[543]`
  - -> `[546]`
  - -> `[540]`
  - -> `[423]`

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I will defend Sordland against our enemies abroad!""]** — Mówca: **Player**
> ""I will defend Sordland against our enemies abroad!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[420]`
**[WYBÓR GRACZA: ""I will continue to show Arcasia no mercy!""]** — Mówca: **Player**
> ""I will continue to show Arcasia no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[421]`
**[WYBÓR GRACZA: ""I will continue to show Rumburg no mercy!""]** — Mówca: **Player**
> ""I will continue to show Rumburg no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[422]`
**[WYBÓR GRACZA: ""I will continue to show United Contana no mercy!""]** — Mówca: **Player**
> ""I will continue to show United Contana no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
**[WYBÓR GRACZA: ""I will not let foreign conflicts distract us from the terror in our own backyards!""]** — Mówca: **Player**
> ""I will not let foreign conflicts distract us from the terror in our own backyards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[429]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[428]`

### Węzeł `[427]`
**[WYBÓR GRACZA: ""All this, while presiding over the greatest economy Sordland has ever seen!""]** — Mówca: **Player**
> ""All this, while presiding over the greatest economy Sordland has ever seen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[428]`
**[WYBÓR GRACZA: ""All this, while bringing Sordland back from the depths of recession!""]** — Mówca: **Player**
> ""All this, while bringing Sordland back from the depths of recession!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[429]`
**[WYBÓR GRACZA: ""I will continue to make Sordland richer than it has ever been!""]** — Mówca: **Player**
> ""I will continue to make Sordland richer than it has ever been!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[430]`
**[WYBÓR GRACZA: ""And I will continue cleaning up the economic mess my predecessors left me!""]** — Mówca: **Player**
> ""And I will continue cleaning up the economic mess my predecessors left me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Security == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Security == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[443]`
**[WYBÓR GRACZA: ""I salute you all with respect.""]** — Mówca: **Player**
> ""I salute you all with respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[444]`
**[WYBÓR GRACZA: ""I thank you for standing by me, your president. Both in good times and bad.""]** — Mówca: **Player**
> ""I thank you for standing by me, your president. Both in good times and bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[445]`
  - -> `[446]`
  - -> `[443]`

### Węzeł `[445]`
**[WYBÓR GRACZA: ""God bless Sordland.""]** — Mówca: **Player**
> ""God bless Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[446]`
**[WYBÓR GRACZA: ""That is all. Thank you.""]** — Mówca: **Player**
> ""That is all. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[447]`
**[WYBÓR GRACZA: ""A'Morgna wes core! Vectern sis da!""]** — Mówca: **Player**
> ""A'Morgna wes core! Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[448]`
**[WYBÓR GRACZA: ""I swore to improve healthcare in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve healthcare in Sordland. And even with all that's been going on, I succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[461]`
**[WYBÓR GRACZA: ""I'd like to thank my wife and children for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my wife and children for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[462]`
**[WYBÓR GRACZA: ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my Vice President, Petr Vectern, for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[445]`
  - -> `[446]`
  - -> `[443]`

### Węzeł `[463]`
**[WYBÓR GRACZA: ""I'd like to thank my chief strategist Lucian Galade for standing by me.""]** — Mówca: **Player**
> ""I'd like to thank my chief strategist Lucian Galade for standing by me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[464]`
Mówca: **Narrator**
> "There was a slight hitch in my voice as I said that. I hoped the mic hadn't picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[445]`
  - -> `[446]`
  - -> `[443]`

### Węzeł `[465]`
**[WYBÓR GRACZA: ""And I hope I have fulfilled it to your satisfaction.""]** — Mówca: **Player**
> ""And I hope I have fulfilled it to your satisfaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[466]`
**[WYBÓR GRACZA: ""I swore to improve Sordland's military. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve Sordland's military. And I will use the rest of my time in office to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[467]`
**[WYBÓR GRACZA: ""I swore to improve national security in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve national security in Sordland. And I will use the rest of my time in office to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[468]`
**[WYBÓR GRACZA: ""I swore to improve Sordland's military. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve Sordland's military. And even with all that's been going on, I succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[469]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And even with all that's been going on, I succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[445]`
  - -> `[446]`
  - -> `[443]`

### Węzeł `[473]`
**[WYBÓR GRACZA: ""I swore to improve national security in Sordland. And even with all that's been going on, I succeeded.""]** — Mówca: **Player**
> ""I swore to improve national security in Sordland. And even with all that's been going on, I succeeded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[474]`
Mówca: **Narrator**
> "Lucian smiled to himself slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[445]`
  - -> `[446]`
  - -> `[443]`

### Węzeł `[475]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[476]`
**[WYBÓR GRACZA: ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""]** — Mówca: **Player**
> ""I swore to improve education in Sordland. And I will use the rest of my time in office to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[477]`
**[WYBÓR GRACZA: ""I have not forgotten the promise I made when you elected me.""]** — Mówca: **Player**
> ""I have not forgotten the promise I made when you elected me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[434]`
  - -> `[437]`
  - -> `[440]`
  - -> `[431]`

### Węzeł `[478]`
**[WYBÓR GRACZA: ""When I was running for President, I made you a promise.""]** — Mówca: **Player**
> ""When I was running for President, I made you a promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[434]`
  - -> `[437]`
  - -> `[440]`
  - -> `[431]`

### Węzeł `[479]`
**[WYBÓR GRACZA: ""I will tell you this: I am not done fighting for you.""]** — Mówca: **Player**
> ""I will tell you this: I am not done fighting for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[485]`
  - -> `[488]`

### Węzeł `[480]`
**[WYBÓR GRACZA: ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""]** — Mówca: **Player**
> ""People of Sordland, Anton Rayne will not let himself be so easily cowed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[485]`
  - -> `[488]`

### Węzeł `[481]`
**[WYBÓR GRACZA: ""The court may have defeated me, but they will never defeat the Sordish spirit!""]** — Mówca: **Player**
> ""The court may have defeated me, but they will never defeat the Sordish spirit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[485]`
  - -> `[488]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
  - -> `[495]`

### Węzeł `[491]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the threat of Bludish separatism!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the threat of Bludish separatism!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[492]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the threat of violent nationalism!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the threat of violent nationalism!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[493]`
**[WYBÓR GRACZA: ""One way or another, I will eradicate the communist scourge!""]** — Mówca: **Player**
> ""One way or another, I will eradicate the communist scourge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[494]`
**[WYBÓR GRACZA: ""And I will continue cleaning up the economic mess my predecessors left me!""]** — Mówca: **Player**
> ""And I will continue cleaning up the economic mess my predecessors left me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[495]`
**[WYBÓR GRACZA: ""I will not let a few fringe groups keep me from doing what I was elected to do!""]** — Mówca: **Player**
> ""I will not let a few fringe groups keep me from doing what I was elected to do!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[523]`
  - -> `[526]`
  - -> `[529]`
  - -> `[537]`

### Węzeł `[496]`
**[WYBÓR GRACZA: ""I will continue to make Sordland richer than it has ever been!""]** — Mówca: **Player**
> ""I will continue to make Sordland richer than it has ever been!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[497]`
**[WYBÓR GRACZA: ""All this, while bringing Sordland back from the depths of recession!""]** — Mówca: **Player**
> ""All this, while bringing Sordland back from the depths of recession!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[498]`
**[WYBÓR GRACZA: ""Even without stronger powers, I will remain tough on internal threats!""]** — Mówca: **Player**
> ""Even without stronger powers, I will remain tough on internal threats!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[523]`
  - -> `[526]`
  - -> `[529]`
  - -> `[537]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[496]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
  - -> `[497]`

### Węzeł `[502]`
**[WYBÓR GRACZA: ""All this, while presiding over the greatest economy Sordland has ever seen!""]** — Mówca: **Player**
> ""All this, while presiding over the greatest economy Sordland has ever seen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[503]`
Mówca: **Narrator**
> "I took a deep breath. Lucian shooed a fly away from my forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // contiue)*
- **Efekt (`userScript`):** `-- contiue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[38]`
  - -> `[138]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[38]`
  - -> `[138]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[141]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[46]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[228]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[321]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[253]`
  - -> `[254]`
  - -> `[321]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //continue)*
- **Efekt (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //continue)*
- **Efekt (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //continue)*
- **Efekt (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //continue)*
- **Efekt (`userScript`):** `--continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Reform Success)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[16]`
  - -> `[113]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reform Success])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Address Ending])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Address Ending)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Address Ending])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Address Ending])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[532]`
**[WYBÓR GRACZA: ""I will not let foreign conflicts get in the way of building this great nation!""]** — Mówca: **Player**
> ""I will not let foreign conflicts get in the way of building this great nation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[533]`
**[WYBÓR GRACZA: ""I will continue to show Arcasia no mercy!""]** — Mówca: **Player**
> ""I will continue to show Arcasia no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[534]`
**[WYBÓR GRACZA: ""I will continue to show United Contana no mercy!""]** — Mówca: **Player**
> ""I will continue to show United Contana no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[535]`
**[WYBÓR GRACZA: ""I will continue to show Rumburg no mercy!""]** — Mówca: **Player**
> ""I will continue to show Rumburg no mercy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[536]`
**[WYBÓR GRACZA: ""I will defend Sordland against our enemies abroad!""]** — Mówca: **Player**
> ""I will defend Sordland against our enemies abroad!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[548]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_Sollism = true; BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_Sollism"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_FutureInOurHands = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_FutureInOurHands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_AutocratSpeech = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_AutocratSpeech_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_AddressToTheNation = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_AddressToTheNation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[314]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[543]`
  - -> `[546]`
  - -> `[540]`
  - -> `[423]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[543]`
  - -> `[546]`
  - -> `[540]`
  - -> `[423]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 5)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[543]`
  - -> `[546]`
  - -> `[540]`
  - -> `[423]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 5)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[523]`
  - -> `[526]`
  - -> `[529]`
  - -> `[537]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[523]`
  - -> `[526]`
  - -> `[529]`
  - -> `[537]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[523]`
  - -> `[526]`
  - -> `[529]`
  - -> `[537]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`
  - -> `[576]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_EliminationOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperationBegins = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_BFF_EliminationOperationBegins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
