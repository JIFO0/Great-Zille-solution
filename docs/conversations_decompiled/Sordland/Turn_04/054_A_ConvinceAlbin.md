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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 57

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Albin_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Relations_Albin_Bribed`
- `BaseGame.Relations_Albin_PromisedVP`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[146]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- Węzeł `[280]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`
- Węzeł `[427]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Albin_Convinced"] = true;`
- Węzeł `[480]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] = true;`
- Węzeł `[494]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- Węzeł `[495]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- Węzeł `[496]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Albin_Bribed"] = true;`
- Węzeł `[510]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin"] = true;`
- *...oraz 49 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: ""How is everything going, Mr. Clavin?""]** — Mówca: **Player**
> ""How is everything going, Mr. Clavin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[4]`
Mówca: **Narrator**
> "After our meeting with Gloria Tory, and further discussions with the party and my cabinet, it was time to talk to Albin Clavin to get the reformist wing to support the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Albin Clavin**
> ""Mr. President! Welcome!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I also planned to finally present a more fleshed out proposal and declare our agenda to the party after our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked into the left wing of the Assembly and entered the quarters of the USP. When I reached the meeting hall, I saw many of our members conversing inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "After taking a glimpse inside, I went back into the corridor to look for the office of Albin Clavin, which was around the back of the place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "When I reached his room, I knocked on his door and entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The whole room was surrounded by bookshelves packed with files and papers. It was a small office, with books and dossiers lying on every corner. It felt claustrophobic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "On his gesture, I took a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[12]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Did a bomb drop in this office?""]** — Mówca: **Player**
> ""Did a bomb drop in this office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Albin Clavin**
> ""It's been busy. The party has been working very hard, Mr. President. Thank you for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Albin Clavin**
> ""How is it going for you in the Palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Albin Clavin**
> ""You could say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Albin Clavin**
> ""So much research and preparation needs to be done on the plans we're working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Albin Clavin**
> ""How is everything going for you, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""It's pretty tough.""]** — Mówca: **Player**
> ""It's pretty tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm feeling pretty good.""]** — Mówca: **Player**
> ""I'm feeling pretty good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""It depends on our meeting today.""]** — Mówca: **Player**
> ""It depends on our meeting today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Albin Clavin**
> ""Oh, I see. Then I'll try my best not to make it any worse for you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[23]`
Mówca: **Albin Clavin**
> ""I can't imagine the work you're dealing with up there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[24]`
Mówca: **Albin Clavin**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[25]`
Mówca: **Albin Clavin**
> ""Anyway, sir, let's talk about the proposal. Thanks for coming here for my input because there are some subjects where Gloria and I don't see eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[26]`
Mówca: **Albin Clavin**
> ""I have to say that most of the progressives were already starting to warm up to you. Your attempt at changing the constitution created quite a bit of excitement. One could dare to say an excitement that hasn't been felt since the 30's...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[27]`
Mówca: **Albin Clavin**
> ""Yet, there are some issues with the current status of the draft proposal. So we may need to contain our excitement a little longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[28]`
Mówca: **Albin Clavin**
> ""I've read the proposal that was finalised together with Mrs. Tory. And surprisingly, it came out pretty good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[29]`
Mówca: **Albin Clavin**
> ""I have to say that the proposal is unacceptable in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The meeting had exhausted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "I went to the restaurant of the Assembly to get something to eat while conversing with other members of our party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I saw Albin talking to his people in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "After a while, the preparations for the conference began and I went back into the conference hall and prepared my notes for the speech I was going to make."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "It took time to get all of the present members of the party inside the hall. Gloria Tory announced me from the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I walked up to the stand as everybody in the room started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Dear members of Assembly...""]** — Mówca: **Player**
> ""Dear members of Assembly, I came here today to announce the agenda for the future of our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Party!""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Party! I came here today to announce the agenda for the future of our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Brothers and sisters of United Sordland!""]** — Mówca: **Player**
> ""Brothers and sisters of United Sordland! I came here today to announce the agenda for the future of our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "I started my speech with the reasons of the changes to the Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""The people of Sordland have spoken...""]** — Mówca: **Player**
> ""The people of Sordland have spoken! They blame our institutions and our systems, and want change! Can you blame the people? Haven't we had enough with the flaws of our Constitution? We must listen their wishes, and get their trust in Sordland back!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Our system and institutions have increasingly became undemocratic...""]** — Mówca: **Player**
> ""Our system and institutions have increasingly became undemocratic over the decades after Soll tightened his grip on the country. Since then, we have a Supreme Court that obstructs the duties of the President and the Assembly. We must finally be brave enough to go against the status quo that they created and write a new Constitution!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""The Supreme Court is blocking the future of Sordland...""]** — Mówca: **Player**
> ""The Supreme Court is blocking the future of Sordland yet again, since President Soll has placed these Judges there. They believe that they are the sole protectors of the Constitution and real leaders of Sordland even though they weren't even elected. We must be brave enough to break their power over us and bring the change Sordland has been so eagerly waiting for!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Narrator**
> "I paused as they started clapping and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Narrator**
> "I paused when some people started clapping but it was short lived. After taking a breath, I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Talk about democracy."]** — Mówca: **Player_Italic**
> "I brought attention to democracy and why we must write a more democratic Constitution. I explained how our proposal will fix the issues."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Talk about why USP needs this to survive the next elections."]** — Mówca: **Player_Italic**
> "I brought attention to the people's protests and the slight decrease in the popularity of USP. I explained how our proposal will only be beneficial for everybody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Target the Old Guards and the Supreme Court."]** — Mówca: **Player_Italic**
> "I blamed the Old Guards for not allowing the legislative to do their work. I explained how more reforms can be done if their power over constitutional changes were to be limited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[51]`
Mówca: **Narrator**
> "A round of applause from the left was heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The left side of the hall where Albin sat started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The moderates that sat in the centre started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Later I explained the contents of the new Constitution and asked for their full support for the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[55]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "Threaten them to vote yes."]** — Mówca: **Player_Italic**
> "I announced that any opposition to the proposal will not be tolerated and will be declared as traitors to the party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "Ask for their votes."]** — Mówca: **Player_Italic**
> "I asked for each and every member's vote to make a change together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Order them to vote yes."]** — Mówca: **Player_Italic**
> "I told them what they must do and what was expected of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The reformist wing on the left stood up and started clapping loudly after Albin Clavin made a sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Soon after, most of the party members stood up and joined in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The conservatives on the right side of the hall where Gloria sat stood up and started clapping loudly after I saw Gloria making a gesture with her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Narrator**
> "There wasn't much reaction from the party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "I saluted everybody in the room one last time and bid them farewell before leaving the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "I walked outside the Assembly and back into the Palace..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_TermLimits_Default == false && BaseGame.Reform_Law_Decrees_Default == false && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Albin Clavin**
> ""I've already read the proposal you've made. It looks pretty good. No surprise that Mrs. Tory didn't give her support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[95]`
Mówca: **Albin Clavin**
> ""I suspect that Mrs. Tory had a lot of influence on this proposal. I have to say that the proposal is unacceptable in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[96]`
Mówca: **Albin Clavin**
> ""...which unfortunately has been crushed with the current draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Albin Clavin**
> ""This is in no way what we intended nor asked for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[109]`
  - -> `[108]`
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Albin Clavin**
> ""I cannot support this in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[109]`
  - -> `[108]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Albin Clavin**
> ""I suspect that Mrs. Tory had a lot of influence on this proposal. But I cannot support this in its current state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[109]`
  - -> `[108]`
  - -> `[106]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""The party should respect my decisions.""]** — Mówca: **Player**
> ""The party should respect my decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I need your support, Mr. Clavin.""]** — Mówca: **Player**
> ""I need your support, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I thought you were a democrat.""]** — Mówca: **Player**
> ""I thought you were a democrat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""What's the problem?""]** — Mówca: **Player**
> ""What's the problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_TermLimits_Default == true || BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[113]`
Mówca: **Albin Clavin**
> ""That would have been very nice for you, wouldn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[114]`
Mówca: **Albin Clavin**
> ""With all due respect, maybe you shouldn't forget that it is the party that made you president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[115]`
Mówca: **Albin Clavin**
> ""A fact that I'm aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Albin Clavin**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[117]`
Mówca: **Albin Clavin**
> ""But us democrats have already established our demands, which were apparently ignored by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Albin Clavin**
> ""You cannot claim that you're the democrat here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[119]`
Mówca: **Albin Clavin**
> ""But at this point, even my support would not be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Albin Clavin**
> ""Where to even begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Let's hear your problems.""]** — Mówca: **Player**
> ""Let's hear your problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""How about some other deal?""]** — Mówca: **Player**
> ""How about some other deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I can't let you sabotage this.""]** — Mówca: **Player**
> ""I can't let you sabotage this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Don't forget who you are speaking to.""]** — Mówca: **Player**
> ""Don't forget who you are speaking to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""What do you mean?""]** — Mówca: **Player**
> ""What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Tell me the issues. How can I get your support?""]** — Mówca: **Player**
> ""Tell me the issues. How can I get your support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[127]`
Mówca: **Albin Clavin**
> ""This proposal will have hard time getting support in its current status. You surely know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[128]`
Mówca: **Albin Clavin**
> ""You are sabotaging yourself if you're not willing to listen the reformists in your own party...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[124]`

### Węzeł `[129]`
Mówca: **Albin Clavin**
> ""First, I'll say that I'm concerned about the drastic decrease in the threshold. The reformist wing of the party will do its best to boycott it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[130]`
Mówca: **Albin Clavin**
> ""That will have negative consequences for our party since dozens of parties could potentially enter the parliament. The electoral finance reform reduces their ability to campaign but nonetheless the situation won't be in our favour at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Albin Clavin**
> ""We have specifically asked for a change in appointment of ministers. This is what the party was expecting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Narrator**
> "He paused and twiddled his thumbs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[133]`
Mówca: **Albin Clavin**
> ""Yet I see that our suggestions were completely ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`
  - -> `[137]`
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Albin Clavin**
> ""Excuse me, Mr. President, but how are they not ignored?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""That's not a priority for us.""]** — Mówca: **Player**
> ""That's not a priority for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""They were not ignored, Mr. Clavin.""]** — Mówca: **Player**
> ""They were not ignored, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""We can address that now.""]** — Mówca: **Player**
> ""We can address that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
Mówca: **Albin Clavin**
> ""I don't know what I can do for you even if I gave you my support. The party will not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`
  - -> `[151]`

### Węzeł `[139]`
Mówca: **Albin Clavin**
> ""Who's us? Isn't the party included in that now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[140]`
Mówca: **Albin Clavin**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Gloria and the conservatives didn't seem to have any problems with it.""]** — Mówca: **Player**
> ""Gloria and the conservatives didn't seem to have any problems with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Albin Clavin**
> ""What is that supposed to mean? *We* have a problem with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[143]`
Mówca: **Albin Clavin**
> ""Let's see then...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Albin Clavin**
> ""Here. I already have my suggestion here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Narrator**
> "He pulled out a stack of papers and placed them on his desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[147]`
Mówca: **Narrator**
> "The papers contained suggested amendments to the Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "I skimmed through the law he pointed out. "Council of Ministers are formed upon the President's appointment of them from a list of nominees that the Grand National Assembly selects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Leave the rest of the party to me. I am now asking for *your* support.""]** — Mówca: **Player**
> ""Leave the rest of the party to me. I am now asking for *your* support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""We can add the requested change to the proposal.""]** — Mówca: **Player**
> ""We can add the requested change to the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Screw the party.""]** — Mówca: **Player**
> ""Screw the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Albin Clavin**
> ""Oh yeah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[153]`
Mówca: **Albin Clavin**
> ""Your proposal will be crushed like this anyway. I'd rather have something tangible to support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[154]`
Mówca: **Albin Clavin**
> ""First of all, we are concerned about where this proposal is heading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Albin Clavin**
> ""It aims to give you absolute immunity with no way of impeachment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[159]`
Mówca: **Albin Clavin**
> ""But never mind that now. There are far worse problems. We are not sure where this proposal is heading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[160]`
Mówca: **Albin Clavin**
> ""I thought you were one of us. Against Sollism and the concentration of power. This is wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`
  - -> `[163]`
  - -> `[164]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I am against Sollism. This law is necessary to protect me from the Court.""]** — Mówca: **Player**
> ""I am against Sollism. This law is necessary to protect me from the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I'm sure we can work something out.""]** — Mówca: **Player**
> ""I'm sure we can work something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Well, you were wrong, Mr. Clavin.""]** — Mówca: **Player**
> ""Well, you were wrong, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""I'm open to discuss changes but not to this law.""]** — Mówca: **Player**
> ""I'm open to discuss changes but not to this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[165]`
Mówca: **Albin Clavin**
> ""It will not only protect you but also your successors, Mr. President. This law has the potential to create another Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AlbinDeal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[168]`
Mówca: **Albin Clavin**
> ""Well, yeah. You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He raised an eyebrow and then frowned at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[170]`
Mówca: **Albin Clavin**
> ""So you want to hear our concerns or you are only here to push your agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[171]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I'm sure we can work out *something else*.""]** — Mówca: **Player**
> ""I'm sure we can work out *something else*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[173]`
Mówca: **Albin Clavin**
> ""This isn't how you *curb* the power of the Old Guards... This proposal instead gives more power to the executive. How is this any better than before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`
  - -> `[200]`

### Węzeł `[174]`
Mówca: **Albin Clavin**
> ""I see that clearly now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Albin Clavin**
> ""Then I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[179]`
Mówca: **Albin Clavin**
> ""You are removing the Justices' immunity and giving it to yourself. This is borderline dictatorial since you can also replace them at your whim. Did you forget that we are democrats at heart, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
Mówca: **Albin Clavin**
> ""Then I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Albin Clavin**
> ""You are giving yourself absolute immunity and still keeping your extensive decree powers. Who do you think we are to support such changes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[329]`
  - -> `[327]`
  - -> `[332]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Albin Clavin**
> ""That is not a good start. But let's look at the other issues first then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[189]`
Mówca: **Albin Clavin**
> ""That is not a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true ||BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Albin Clavin**
> ""As long as this law and the threshold remains, I don't think I can give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[197]`
Mówca: **Albin Clavin**
> ""As much as I want to give you my support, you are forcing our hand with this proposal...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[198]`
**[WYBÓR GRACZA: ""It isn't about more powers, it is only protection.""]** — Mówca: **Player**
> ""It isn't about more powers, it is only protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Okay, let's change this law." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Okay, let's change this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I'm open to discuss changes but not to this law.""]** — Mówca: **Player**
> ""I'm open to discuss changes but not to this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[201]`
Mówca: **Albin Clavin**
> ""I understand where you're coming from but us reformists cannot agree to this change. This is the very political culture that we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Albin Clavin**
> ""Let's say we trust you and you become the greatest leader ever lived. And then, what happens when you leave office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[203]`
Mówca: **Albin Clavin**
> ""You mean it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Albin Clavin**
> ""That's a positive development.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[205]`
Mówca: **Albin Clavin**
> ""Reformists were expecting a reform about the term limits. Why is that not included in the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[226]`

### Węzeł `[206]`
Mówca: **Albin Clavin**
> ""Oh yeah? What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Let's remove the change from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Let's remove the change from the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Maybe I can help you some other way...""]** — Mówca: **Player**
> ""Maybe I can help you some other way...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
Mówca: **Albin Clavin**
> ""It seems you have interesting dreams. But dreams, nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Albin Clavin**
> ""I would have understood your stance if this was the only issue... There are more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Albin Clavin**
> ""I think you're pushing your luck too much, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Albin Clavin**
> ""You know... This isn't the only issue. There's another one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[220]`
Mówca: **Albin Clavin**
> ""At least you decided to make some democratic changes to the term limits, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or Variable["BaseGame.Reform_Law_Decrees_Default"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_TermLimits_Default == true ||BaseGame.Reform_Law_Decrees_Default == true) || BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  or Variable["BaseGame.Reform_Law_Decrees_Default"] == true)  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[224]`
**[WYBÓR GRACZA: ""That wasn't a priority.""]** — Mówca: **Player**
> ""That wasn't a priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""This is only my first term. It's too soon to bring term limits.""]** — Mówca: **Player**
> ""This is only my first term. It's too soon to bring term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""We can address that today.""]** — Mówca: **Player**
> ""We can address that today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Albin Clavin**
> ""So, you also want to use the flaws of the system for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[228]`
Mówca: **Albin Clavin**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[229]`
Mówca: **Albin Clavin**
> ""What is a priority for you, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[230]`
Mówca: **Albin Clavin**
> ""I thought there would be some reform about the extensive decree powers...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Narrator**
> "He stared directly into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[232]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Fine. Let's discuss this.""]** — Mówca: **Player**
> ""Fine. Let's discuss this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[233]`
**[WYBÓR GRACZA: ""There isn't going to be reforms about the decrees.""]** — Mówca: **Player**
> ""There isn't going to be reforms about the decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Look. We need the decrees to pass further reforms. I can't give away everything.""]** — Mówca: **Player**
> ""Look. We need the decrees to pass further reforms. I can't give away everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[244]`
**[WYBÓR GRACZA: "Change the proposal accordingly. [CHANGE THE REFORM]"]** — Mówca: **Player_Italic**
> "Change the proposal accordingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""On a second thought, I won't change this.""]** — Mówca: **Player**
> ""On a second thought, I won't change this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Limiting the legislative powers of the Supreme Court.""]** — Mówca: **Player**
> ""Limiting the legislative powers of the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Balance and division of powers.""]** — Mówca: **Player**
> ""Balance and division of powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Bringing down the Constitution of Soll.""]** — Mówca: **Player**
> ""Bringing down the Constitution of Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""You should have read our manifesto.""]** — Mówca: **Player**
> ""You should have read our manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[250]`
Mówca: **Albin Clavin**
> ""You are giving yourself absolute immunity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Albin Clavin**
> ""...and keeping your extensive powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[261]`
Mówca: **Albin Clavin**
> ""And you're doing more than that, aren't you? Taking away the immunity of the Justices and giving the power to impeach to the parliament which our, or should I say, your party controls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[262]`
Mówca: **Albin Clavin**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[266]`
Mówca: **Albin Clavin**
> ""By giving yourself the same rights as Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Albin Clavin**
> ""Do you want me to believe that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[268]`
Mówca: **Albin Clavin**
> ""Could you tell me... What is your priority with this proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He let out a fake laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Albin Clavin**
> ""Let's see then... There is one more problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[274]`
Mówca: **Albin Clavin**
> ""And there is more...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Albin Clavin**
> ""Let's see then... What are you thinking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""We'll bring term limits of 2.""]** — Mówca: **Player**
> ""We'll bring term limits of 2.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[281]`
**[WYBÓR GRACZA: ""On a second thought, I'd rather not include any changes to term limits.""]** — Mówca: **Player**
> ""On a second thought, I'd rather not include any changes to term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[282]`
Mówca: **Albin Clavin**
> ""I told you. This is a power grab. I can't support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[315]`

### Węzeł `[283]`
Mówca: **Albin Clavin**
> ""You should at least do something about term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[312]`

### Węzeł `[284]`
Mówca: **Albin Clavin**
> ""You should at least do something about the threshold. The party will not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`
  - -> `[312]`

### Węzeł `[285]`
Mówca: **Albin Clavin**
> ""We prefer some kind of reform. The president currently holds too much power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Albin Clavin**
> ""I suggest limiting the power of the decrees with an enabling act. The Assembly should have some control over a potential rogue president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Albin Clavin**
> ""And if you really care about further democratic reforms, we'll issue the enabling act. But we have to make sure the presidents can't work alone anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`
  - -> `[290]`

### Węzeł `[288]`
**[WYBÓR GRACZA: ""It makes sense. I will include your suggestion and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""It makes sense. I will include your suggestion and limit the decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
**[WYBÓR GRACZA: ""I don't trust the Assembly to give me the power to enact major reforms though.""]** — Mówca: **Player**
> ""I don't trust the Assembly to give me the power to enact major reforms though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""I can't let the Assembly control me.""]** — Mówca: **Player**
> ""I can't let the Assembly control me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Albin Clavin**
> ""I thought you wanted to discuss a change...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`
  - -> `[295]`
  - -> `[631]`

### Węzeł `[292]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[293]`
**[WYBÓR GRACZA: ""I'm sure there's some *other way* to convince you.""]** — Mówca: **Player**
> ""I'm sure there's some *other way* to convince you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[294]`
**[WYBÓR GRACZA: ""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. Let's change the law and limit the decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
**[WYBÓR GRACZA: ""I don't think I want that.""]** — Mówca: **Player**
> ""I don't think I want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Albin Clavin**
> ""Now, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[297]`
Mówca: **Albin Clavin**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Albin Clavin**
> ""You should at least do something about the party's demand for minister reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[302]`
Mówca: **Albin Clavin**
> ""Fine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[303]`
Mówca: **Albin Clavin**
> ""How about the other problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Albin Clavin**
> ""A pleasant surprise. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[308]`
Mówca: **Albin Clavin**
> ""Fine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[309]`
Mówca: **Narrator**
> "He looked down at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""Fine. I will add your suggestion." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will add your suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[311]`
Mówca: **Albin Clavin**
> ""The ministers should be nominated by the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[312]`

### Węzeł `[312]`
**[WYBÓR GRACZA: ""That's a no.""]** — Mówca: **Player**
> ""That's a no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Fine. I will remove the decrease in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the decrease in the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[314]`
**[WYBÓR GRACZA: ""Fine. I will bring a limit of 2 terms." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will bring a limit of 2 terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[316]`
**[WYBÓR GRACZA: ""Okay. I'll reform the decrees then.""]** — Mówca: **Player**
> ""Okay. I'll reform the decrees then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AlbinEnd)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[325]`
Mówca: **Albin Clavin**
> ""Looking good!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Maybe I can offer you something else...""]** — Mówca: **Player**
> ""Maybe I can offer you something else...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the Justices." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[329]`
**[WYBÓR GRACZA: ""Okay. I'll reform the decrees then.""]** — Mówca: **Player**
> ""Okay. I'll reform the decrees then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the immunity of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Fine. I will remove the threshold change." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the threshold change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[332]`
**[WYBÓR GRACZA: ""That's a no.""]** — Mówca: **Player**
> ""That's a no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[333]`
Mówca: **Albin Clavin**
> ""Finally, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AlbinDecree)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDecree])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[338]`
Mówca: **Albin Clavin**
> ""Now, we're getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDecree])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[340]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false))  and  ((Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false) || (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false)) && ((BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true))))*
- **Warunek (`conditionsString`):** `(((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false))  and  ((Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == false))  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  (Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(((BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) || (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Default == false)) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false))))*
- **Warunek (`conditionsString`):** `(((Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  or  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Default"] == false))  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  (Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[347]`
Mówca: **Albin Clavin**
> ""It's looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[348]`
Mówca: **Albin Clavin**
> ""There might... still be a way for me to get behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
Mówca: **Albin Clavin**
> ""... perhaps there is something else you could offer me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[477]`
  - -> `[352]`

### Węzeł `[350]`
**[WYBÓR GRACZA: ""Let's look at the draft again. I will give concessions.""]** — Mówca: **Player**
> ""Let's look at the draft again. I will give concessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""Sure. I'll offer you *something else*.""]** — Mówca: **Player**
> ""Sure. I'll offer you *something else*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[352]`
**[WYBÓR GRACZA: ""Pff. This meeting is over.""]** — Mówca: **Player**
> ""Pff. This meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true)  and  Variable["BaseGameIsolated.Albin_AskedForThreshold"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_3 == true) && BaseGameIsolated.Albin_AskedForThreshold == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true)  and  Variable["BaseGameIsolated.Albin_AskedForThreshold"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[356]`
Mówca: **Albin Clavin**
> ""Remove the change to the threshold and we will be as golden as Rizia. No need to agitate our party, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[396]`

### Węzeł `[357]`
Mówca: **Albin Clavin**
> ""I will support the proposal and get the needed signatures from our wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[358]`
Mówca: **Albin Clavin**
> ""However you see fit, Mr. President. I hope I didn't offend you in some way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinDeal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[360]`
Mówca: **Albin Clavin**
> ""This is not enough, Mr. President. We can take another look over the draft or... perhaps there is something else you could offer me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[477]`
  - -> `[352]`

### Węzeł `[361]`
Mówca: **Albin Clavin**
> ""You already know our concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "We both buried our heads inside the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`
  - -> `[365]`
  - -> `[368]`
  - -> `[374]`
  - -> `[371]`

### Węzeł `[363]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[364]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_15 == true) && BaseGame.Reform_Albin_Law_Threshold_Default == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true) && BaseGame.Reform_Albin_Law_Decrees_Weaker == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I will limit presidential decrees with the requirement for an enabling act." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will limit presidential decrees with the requirement for an enabling act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[378]`
Mówca: **Albin Clavin**
> ""It wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[705]`
  - -> `[710]`
  - -> `[386]`
  - -> `[389]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  ((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false)  or  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Albin_Law_Ministers_Assembly == true || BaseGame.Reform_Law_Ministers_Default == false)  && (BaseGame.Reform_Albin_Law_TermLimits_2 == true || BaseGame.Reform_Law_TermLimits_Default == false) && (BaseGame.Reform_Albin_Law_Decrees_Weaker == true || BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && 
((BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Albin_Law_Impeachment_Default == true) || ((BaseGame.Reform_Law_Judges_Impeachment_Assembly == false && BaseGame.Reform_Law_Judges_Impeachment_President == false) || BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true))))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false)   and  (Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true  or  Variable["BaseGame.Reform_Law_TermLimits_Default"] == false)  and  (Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  
((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == true)  or  ((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false)  or  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Albin Clavin**
> ""I guess it's acceptable now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[383]`
Mówca: **Albin Clavin**
> ""But unfortunately, Mr. President. This is not enough. Either we change more or....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Let's just move on.""]** — Mówca: **Player**
> ""Let's just move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[385]`
**[WYBÓR GRACZA: ""I will also add term limits. 2 should be enough." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will also add term limits. 2 should be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_Default == true && BaseGame.Reform_Albin_Law_TermLimits_2 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true) && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true)  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[392]`
**[WYBÓR GRACZA: ""I will also remove the changes to the Justices' immunity." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will also remove the changes to the Justices' immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[393]`
Mówca: **Albin Clavin**
> ""Great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[394]`
**[WYBÓR GRACZA: ""Fine. I will remove the changes to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I will remove the changes to the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[395]`
Mówca: **Albin Clavin**
> ""It wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[396]`
**[WYBÓR GRACZA: ""No. I can't do it.""]** — Mówca: **Player**
> ""No. I can't do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AlbinFail)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[399]`
Mówca: **Albin Clavin**
> ""Good to know, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[400]`
Mówca: **Albin Clavin**
> ""I believe the reformist votes that I have will be very important to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[401]`
Mówca: **Albin Clavin**
> ""Who knows? Maybe you'll consider me for a job in the government in the future for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
**[WYBÓR GRACZA: ""I'll consider you, if you prove yourself useful in the vote.""]** — Mówca: **Player**
> ""I'll consider you, if you prove yourself useful in the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[403]`
**[WYBÓR GRACZA: ""I'll be expecting your votes, Mr. Clavin.""]** — Mówca: **Player**
> ""I'll be expecting your votes, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[404]`
Mówca: **Albin Clavin**
> ""See you in the conference, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[405]`
Mówca: **Albin Clavin**
> ""Oh, you know I will, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[406]`
Mówca: **Albin Clavin**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[407]`
Mówca: **Albin Clavin**
> ""I'll have their signatures soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Albin Clavin**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Don't botch it.""]** — Mówca: **Player**
> ""Don't botch it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[410]`
Mówca: **Albin Clavin**
> ""I will talk to my guys shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[411]`
**[WYBÓR GRACZA: ""You bet I will, Mr. Clavin.""]** — Mówca: **Player**
> ""You bet I will, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[412]`
**[WYBÓR GRACZA: ""Thank you, Mr. Clavin.""]** — Mówca: **Player**
> ""Thank you, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[413]`
Mówca: **Albin Clavin**
> ""I'm sorry to say that there's nothing I can do for you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Albin Clavin**
> ""Good luck with uniting the party under your reforms. But I guess you will be uniting the party against you like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Albin Clavin**
> ""Which is an achievement too, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Albin Clavin**
> ""We'll see, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[417]`
Mówca: **Albin Clavin**
> ""Anyway, I need to get back to work, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[420]`
  - -> `[419]`

### Węzeł `[418]`
**[WYBÓR GRACZA: ""I understand. I won't bother you any longer.""]** — Mówca: **Player**
> ""I understand. I won't bother you any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I'll be expecting the reformists' support, Mr. Clavin.""]** — Mówca: **Player**
> ""I'll be expecting the reformists' support, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[420]`
**[WYBÓR GRACZA: ""Goodbye, Mr. Clavin.""]** — Mówca: **Player**
> ""Goodbye, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[421]`
Mówca: **Albin Clavin**
> ""That's not what I meant, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[424]`

### Węzeł `[422]`
**[WYBÓR GRACZA: ""It's okay, Mr. Clavin. I took no offense.""]** — Mówca: **Player**
> ""It's okay, Mr. Clavin. I took no offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[423]`
Mówca: **Albin Clavin**
> ""Goodbye, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
**[WYBÓR GRACZA: "Leave the room."]** — Mówca: **Player_Italic**
> "I left his room and went back into the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[425]`
Mówca: **Narrator**
> "I left his room and went back into the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[426]`
Mówca: **Narrator**
> "I left his room and went back into the corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[428]`
Mówca: **Albin Clavin**
> ""I'm all ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[429]`
  - -> `[431]`

### Węzeł `[429]`
**[WYBÓR GRACZA: ""If you give us your support, you'll be my VP in my next cabinet. [Collusion]""]** — Mówca: **Player**
> ""If you give us your support, you'll be my VP in my next cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[430]`
**[WYBÓR GRACZA: ""How about this? [Show him a cheque]""]** — Mówca: **Player**
> ""How about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Narrator**
> "I took out a cheque and showed it to him. It immediately got his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[435]`
**[WYBÓR GRACZA: ""A lot. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""A lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[436]`
Mówca: **Albin Clavin**
> ""That was very direct...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Albin Clavin**
> ""...How much are we talking about here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[443]`
  - -> `[439]`

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Life-changing amount." [-2 Personal Wealth]""]** — Mówca: **Player**
> ""Life-changing amount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[439]`
**[WYBÓR GRACZA: ""Name your price.""]** — Mówca: **Player**
> ""Name your price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[446]`
Mówca: **Albin Clavin**
> ""I didn't know you were such a *businessman*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[447]`
Mówca: **Albin Clavin**
> ""Look, Mr. President. I'm on the same side as you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[448]`
Mówca: **Albin Clavin**
> ""An interesting proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  or  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == false || 
BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Ministers_Default == false || BaseGame.Reform_Law_Judges_Impeachment_President == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  or  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[452]`
Mówca: **Albin Clavin**
> ""One that's very hard to turn down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Albin Clavin**
> ""Especially now that I think we align, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Albin Clavin**
> ""Can I hold you to that promise?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`
  - -> `[503]`

### Węzeł `[455]`
Mówca: **Albin Clavin**
> ""But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Albin Clavin**
> ""I can't really support the proposal without at least some change to these points of concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Narrator**
> "He showed the listed problems which were outlined on a piece of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[470]`
  - -> `[693]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[461]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[462]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Albin_Law_Decrees_Weaker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[469]`
**[WYBÓR GRACZA: ""I will limit presidential decrees with the requirement for an enabling act." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will limit presidential decrees with the requirement for an enabling act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[470]`
**[WYBÓR GRACZA: ""Fine. Whatever it takes to get this proposal through the Assembly.""]** — Mówca: **Player**
> ""Fine. Whatever it takes to get this proposal through the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[458]`
  - -> `[463]`
  - -> `[466]`

### Węzeł `[471]`
Mówca: **Albin Clavin**
> ""Great. I knew that we could agree on something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[472]`
**[WYBÓR GRACZA: ""How about a position in my cabinet?""]** — Mówca: **Player**
> ""How about a position in my cabinet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Albin Clavin**
> ""I think we can achieve a lot, if we lead together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Albin Clavin**
> ""Well... If you promise me the position of the Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[692]`
  - -> `[431]`

### Węzeł `[475]`
**[WYBÓR GRACZA: ""I'm afraid I can't do that.""]** — Mówca: **Player**
> ""I'm afraid I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Albin_OfferedDeal == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Albin_OfferedDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Albin_OfferedDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[482]`
Mówca: **Albin Clavin**
> ""How about two of those cheques you're holding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[488]`

### Węzeł `[483]`
**[WYBÓR GRACZA: ""Here you go. [Give him two cheques for -2 Personal Wealth]""]** — Mówca: **Player**
> ""Here you go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
**[WYBÓR GRACZA: ""How about only one for now?""]** — Mówca: **Player**
> ""How about only one for now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
**[WYBÓR GRACZA: ""That's too much.""]** — Mówca: **Player**
> ""That's too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Albin Clavin**
> ""I thought you were a wealthy man...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
**[WYBÓR GRACZA: ""Here's one. This will be enough. [-1 Personal Wealth]""]** — Mówca: **Player**
> ""Here's one. This will be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[491]`
**[WYBÓR GRACZA: ""I think there won't be any deal today.""]** — Mówca: **Player**
> ""I think there won't be any deal today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Albin Clavin**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_Bribed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Albin_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Albin Clavin**
> ""Glad to be making business with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[498]`
Mówca: **Narrator**
> "He took the cheque and slid it into the pocket of his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[499]`
Mówca: **Narrator**
> "He glanced at the proposal on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[500]`
Mówca: **Albin Clavin**
> ""Now your offer has indeed become something very persuasive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[501]`
**[WYBÓR GRACZA: ""Of course. I am a man of my word.""]** — Mówca: **Player**
> ""Of course. I am a man of my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[502]`
**[WYBÓR GRACZA: ""I don't intend to run with Petr again. It'll be you, I promise.""]** — Mówca: **Player**
> ""I don't intend to run with Petr again. It'll be you, I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[503]`
**[WYBÓR GRACZA: ""As long as I get your support.""]** — Mówca: **Player**
> ""As long as I get your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[504]`
Mówca: **Albin Clavin**
> ""Good. Then it seems like we have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[505]`
Mówca: **Albin Clavin**
> ""I won't create any problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`
  - -> `[508]`
  - -> `[506]`

### Węzeł `[506]`
**[WYBÓR GRACZA: ""That's what I wanted to hear.""]** — Mówca: **Player**
> ""That's what I wanted to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[507]`
**[WYBÓR GRACZA: ""That's good to know.""]** — Mówca: **Player**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
**[WYBÓR GRACZA: ""Thank you, Mr. Clavin. Any help from you is much appreciated.""]** — Mówca: **Player**
> ""Thank you, Mr. Clavin. Any help from you is much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [AlbinEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAlbin = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Albin Clavin**
> ""I wanted to express my gratitude for passing the Workers' Rights Act. It is one of my most comprehensive and successful political efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[521]`
  - -> `[522]`
  - -> `[518]`

### Węzeł `[516]`
Mówca: **Albin Clavin**
> ""Our team was disappointed by the veto of the Workers' Rights Act. We worked day and night for weeks. It would have boosted your public opinion too, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[519]`
  - -> `[520]`
  - -> `[542]`

### Węzeł `[517]`
**[WYBÓR GRACZA: ""It wasn't a good time for a drastic changes which would also costs the government.""]** — Mówca: **Player**
> ""It wasn't a good time for a drastic changes which would also costs the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[518]`
**[WYBÓR GRACZA: ""You and I see eye to eye on many subjects including this one.""]** — Mówca: **Player**
> ""You and I see eye to eye on many subjects including this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[519]`
**[WYBÓR GRACZA: ""The businesses would be burdened even further. In this climate it would damage the economy.""]** — Mówca: **Player**
> ""The businesses would be burdened even further. In this climate it would damage the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[520]`
**[WYBÓR GRACZA: ""Either way, your efforts were appreciated by the Palace.""]** — Mówca: **Player**
> ""Your efforts were appreciated by the Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[521]`
**[WYBÓR GRACZA: ""It was the right thing to do because our workers were suffering for decades.""]** — Mówca: **Player**
> ""It was the right thing to do because our workers were suffering for decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[522]`
**[WYBÓR GRACZA: ""The party effort had to be supported.""]** — Mówca: **Player**
> ""The party effort had to be supported.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[523]`
Mówca: **Albin Clavin**
> ""Indeed the people will credit your administration and the party for a positive change in their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[524]`
Mówca: **Albin Clavin**
> ""I have to say, the close collaboration between the palace and the party is going well. Looking forward to what we can accomplish with the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[525]`
Mówca: **Albin Clavin**
> ""Music to my ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[526]`
Mówca: **Albin Clavin**
> ""It never is. Not sure how this will reflect on the public opinion, I wouldn't imagine positively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[527]`
Mówca: **Albin Clavin**
> ""I understand your perspective but haven't the companies benefitted from this situation and made profit for a long time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[528]`
Mówca: **Albin Clavin**
> ""Actions would have gone farther than words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[529]`
Mówca: **Albin Clavin**
> ""It seems that the administration is taking a very pro-business approach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Narrator**
> "Albin smiled and knocked on wood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[531]`
Mówca: **Narrator**
> "He poured himself some water and had a sip before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Albin Clavin**
> ""It's just that we thought the Palace wouldn't let us down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[536]`
Mówca: **Albin Clavin**
> ""The businesses will share the burden with the state but it is a change they have to abide by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[537]`
**[WYBÓR GRACZA: ""The worker's revolution will begin with small steps.""]** — Mówca: **Player**
> ""The worker's revolution will begin with small steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Albin Clavin**
> ""One would think that I'm talking to Ms. Walda. The party doesn't support such ideologies as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Albin Clavin**
> ""Personally there are some principles that I respect in Malenyevism but I wouldn't accept it in it's entirety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[540]`
**[WYBÓR GRACZA: ""It is a market economy with a free supply and demand system. The government shouldn't overregulate.""]** — Mówca: **Player**
> ""It is a market economy with a free supply and demand system. The government shouldn't overregulate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
Mówca: **Albin Clavin**
> ""The situation is borderline exploitative, that is why the majority of the assembly gathered behind it. The act was supposed to bring some regulation which didn't exist before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`
  - -> `[544]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[545]`
Mówca: **Albin Clavin**
> ""It wouldn't be possible without Paskal Beniwoll's support. The Labour Union and several NGO's like Magnus Cartus also contributed to the campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Narrator**
> "Albin sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_TermLimits_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_TermLimits_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_USPMeeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_USPMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_A_Convince_Albin = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_A_Convince_Albin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
Mówca: **Albin Clavin**
> ""First, I'll say that I'm concerned about the increase in the threshold. The reformist wing of the party will do its best to boycott that since the expectation from us is to democratise, not do the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[580]`
Mówca: **Albin Clavin**
> ""Our constituents wouldn't accept the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Albin Clavin**
> ""The change will have negative consequences for our party since dozens of new parties could potentially enter the parliament.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[588]`
Mówca: **Albin Clavin**
> ""Combined with the electoral finance reform no other party can ever make it to the parliament. Our constituents wouldn't accept the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Veto_Loophole == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`
  - -> `[594]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[595]`
**[WYBÓR GRACZA: ""Fine. I will remove the increase in the threshold.""]** — Mówca: **Player**
> ""Fine. I will remove the increase in the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[599]`
Mówca: **Albin Clavin**
> ""You are removing the Justices' immunity and giving the ability to impeach it to the parliament. I'm a parliamentarian at heart and while I think this strengthens the people's representative power, it still is wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
Mówca: **Albin Clavin**
> ""Who do you think we are to support such changes, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[330]`
  - -> `[327]`
  - -> `[332]`

### Węzeł `[601]`
**[WYBÓR GRACZA: "" I will remove the changes to the immunity of the Justices." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the Justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[606]`
Mówca: **Albin Clavin**
> ""And you're doing more than that, aren't you? Taking away the immunity of the Justices and giving the power to replace them to yourself. A worrying notion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[607]`
**[WYBÓR GRACZA: ""I will remove the decrease in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the decrease in the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[608]`
**[WYBÓR GRACZA: ""I will remove the increase in the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the increase in the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[612]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`
  - -> `[614]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[615]`
Mówca: **Albin Clavin**
> ""This particular change is specifically worrying as it represents an opposite trend. The decrees need to be weaker not stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`
  - -> `[618]`

### Węzeł `[616]`
**[WYBÓR GRACZA: ""To truly reform the country the President needs decrees not subject to review.""]** — Mówca: **Player**
> ""To truly reform the country the President needs decrees not subject to review.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[617]`
**[WYBÓR GRACZA: ""What is wrong with a USP President having strong decree powers?""]** — Mówca: **Player**
> ""What is wrong with a USP President having strong decree powers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[618]`
**[WYBÓR GRACZA: ""I respect the perspective of the reformist wing.""]** — Mówca: **Player**
> ""I respect the perspective of the reformist wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[619]`
Mówca: **Albin Clavin**
> ""What I didn't expect was a worsening of the current situation. Presidential decrees above statute law and not subject to judicial review... It would destroy the separation of powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[620]`
Mówca: **Albin Clavin**
> ""And the attempt to offset this by adding an override of the veto power to the parliament only to have no time limit to act is a very low move. Tricks like this won't go unnoticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[621]`
Mówca: **Albin Clavin**
> ""I thought you wanted to discuss a change...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`
  - -> `[625]`
  - -> `[622]`

### Węzeł `[622]`
**[WYBÓR GRACZA: ""There must be another way.""]** — Mówca: **Player**
> ""There must be another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[623]`
**[WYBÓR GRACZA: ""Fine. Let's change the law and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. Let's change the law and limit the decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[624]`
Mówca: **Albin Clavin**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[625]`
**[WYBÓR GRACZA: ""I don't think I want that.""]** — Mówca: **Player**
> ""I don't think I want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[626]`
**[WYBÓR GRACZA: ""I can't let the Assembly control me.""]** — Mówca: **Player**
> ""I can't let the Assembly control me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[627]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[628]`
**[WYBÓR GRACZA: ""I don't trust the Assembly to give me the power to enact major reforms though.""]** — Mówca: **Player**
> ""I don't trust the Assembly to give me the power to enact major reforms though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[629]`
Mówca: **Albin Clavin**
> ""Lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[630]`
**[WYBÓR GRACZA: ""It makes sense. I will include your suggestion and limit the decrees." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""It makes sense. I will include your suggestion and limit the decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Loophole == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Loophole"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Veto_Loophole == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Loophole"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[634]`
**[WYBÓR GRACZA: ""The fact that we are giving the Assembly the power to override a veto is change enough.""]** — Mówca: **Player**
> ""The fact that we are giving the Assembly the power to override a veto is change enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[635]`
Mówca: **Albin Clavin**
> ""You didn't include any time limit for that response thus creating a loophole which puts us back to square one. Nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[636]`
Mówca: **Albin Clavin**
> ""And if you really care about further democratic reforms, we'll issue the enabling act. But we have to make sure the presidents can't work alone anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`
  - -> `[628]`
  - -> `[626]`

### Węzeł `[637]`
Mówca: **Albin Clavin**
> ""I suggest limiting the power of the decrees with an enabling act. The Assembly should have some control over a potential rogue president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[638]`
Mówca: **Albin Clavin**
> ""Well there were some subjects that were wrong about Tarquin Soll and we don't want to see a repeat of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[639]`
Mówca: **Albin Clavin**
> ""Enough to make a slight change that would heavily influence our tendencies to support the draft?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[640]`
Mówca: **Albin Clavin**
> ""Why can't the President work closely with the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`
  - -> `[643]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[644]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[647]`
Mówca: **Albin Clavin**
> ""Which under this draft proposal also would have immunity for life once retired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[648]`
Mówca: **Albin Clavin**
> ""And your abolishment of the honorary membership indicates that you are a democrat too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[649]`
Mówca: **Albin Clavin**
> ""But the extent of your democratic beliefs matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`
  - -> `[123]`
  - -> `[124]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`
  - -> `[652]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[653]`
Mówca: **Albin Clavin**
> ""The removal of the honorary membership won't be respected by the party either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Default == true && BaseGame.Reform_Law_Ministers_Assembly == true && BaseGame.Reform_Law_Decrees_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`
  - -> `[661]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`
  - -> `[664]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Decrees_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_Decrees_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default  == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default  == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_Impeachment_Default  == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"]  == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_Judges_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`
  - -> `[673]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_Ministers_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default = false; BaseGame.Reform_Law_Decrees_Removed = false;  BaseGame.Reform_Law_Decrees_Stronger = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] = false;
Variable["BaseGame.Reform_Law_Decrees_Removed"] = false;
Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Assembly = false; BaseGame.Reform_Law_Impeachment_Harder = false; BaseGame.Reform_Law_Impeachment_Removed = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Harder"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Removed"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President = false; BaseGame.Reform_Law_Judges_Impeachment_Assembly = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] = false;
Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_ConfidenceVote = false; BaseGame.Reform_Law_Ministers_Default = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] = false;
Variable["BaseGame.Reform_Law_Ministers_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_Default = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[692]`
**[WYBÓR GRACZA: ""Very well. I accept. [Collusion]""]** — Mówca: **Player**
> ""Very well. I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`
  - -> `[695]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[696]`
**[WYBÓR GRACZA: ""I wouldn't mind if my next Vice President had a bit more... funds. [Show him a cheque]""]** — Mówca: **Player**
> ""I wouldn't mind if my next Vice President had a bit more... funds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[697]`
Mówca: **Narrator**
> "I took out a cheque and showed it to him. It immediately got his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[698]`
Mówca: **Albin Clavin**
> ""You certainly know how to make compelling arguments, don't you Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[699]`
Mówca: **Narrator**
> "He took the cheque and slid it into the pocket of his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Albin Clavin**
> ""Glad to be making business with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_Bribed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Albin_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Albin_PromisedVP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`
  - -> `[707]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Albin_Law_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[708]`
**[WYBÓR GRACZA: ""I will give the Assembly the power to nominate the ministers." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will give the Assembly the power to nominate the ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[709]`
**[WYBÓR GRACZA: ""I will remove the changes to the immunity of the President." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes to the immunity of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`
  - -> `[712]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && BaseGame.Reform_Albin_Law_Ministers_Assembly == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Law_Ministers_Assembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Albin_Law_Ministers_Assembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[715]`
Mówca: **Narrator**
> "He took a deep breath then let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[716]`
**[WYBÓR GRACZA: ""On a second thought, I'm fine with the current draft.""]** — Mówca: **Player**
> ""On a second thought, I'm fine with the current draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Passed a comprehensive bill to improve workers rights", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Passed a comprehensive bill to improve workers rights","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Vetoed a comprehensive workers rights bill", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Vetoed a comprehensive workers rights bill","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Albin_AskedForThreshold = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Albin_AskedForThreshold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
