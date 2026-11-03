# Sordland/Turn02/A_AutocratBriefing

- **ID konwersacji:** `18`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/018_A_AutocratBriefing.md`
- **Liczba węzłów dialogowych:** 646
- **Liczba wyborów gracza:** 209

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[36]** Heron Garaci
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_SetUpMeeting`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_A`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_B`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_C`
- `BaseGameIsolated.Turn02_A_Confront_Whiskey`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Law_ReformCommittee`
- `BaseGame.Reform_Autocrat_Abandon`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_A`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_B`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_C`
- `BaseGameIsolated.Turn02_A_Confront_Whiskey`
- `BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal`
- `BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal`
- `BaseGameSupport.News_Turn02_E_REEPotential`
- `BaseGameSupport.News_Turn02_G_IyotakePlanMixed`
- `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan`
- `BaseGameSupport.News_Turn02_R_GasomJobsRisk`
- `BaseGameSupport.News_Turn02_R_OrsoSeenInPalace`
- `BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter`
- `BaseGameSupport.Report_Turn02_Morbel_NaturePreservation`
- `GameCondition.Turn02_A_AutocratBriefing`
- `GameCondition.Turn03_A_LateBriefing`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 16

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[15]` (Orso Hawker): `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] = true;`
- Węzeł `[472]` (Orso Hawker): `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] = true;`
- Węzeł `[473]` (Orso Hawker): `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] = true;`
- Węzeł `[474]` (Orso Hawker): `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] = true;`
- Węzeł `[626]` (Orso Hawker): `Variable["BaseGame.Reform_Autocrat_Path"] = true;`
- Węzeł `[627]` (Orso Hawker): `Variable["GameCondition.Turn02_A_AutocratBriefing"] = true;`
- Węzeł `[631]` (Orso Hawker): `Variable["BaseGame.Reform_Autocrat_Abandon"] = true;`
- Węzeł `[635]` (Orso Hawker): `Variable["BaseGame.Reform_Reformist_Path"] = true;`
- *...oraz 8 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Orso Hawker)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[5]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The administration had been working day and night on the overwhelming amount of issues that were facing the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[7]`
Mówca: **Narrator**
> "After I'd signed dozens of them, I closed my eyes to relax for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Another long day..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "On top of all that, I'd finally managed to set up a meeting with the Old Guards to talk about a path of no reforms and cooperation. It was in thirty minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[10]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_SetUpMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Even though I couldn't wait to leave the Palace for the day, Lucian had earlier told me that the Chief Justice wanted to speak to me. We were to meet in my office in thirty minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Pour whiskey."]** — Mówca: **Player_Italic**
> "I poured some whiskey for myself and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Confront_Whiskey = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Thousands of shimmering lights in the Holsord skyline were mesmerising."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Take a moment to relax."]** — Mówca: **Player_Italic**
> "I stretched out my arms and looked out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Narrator**
> "It eased my mind a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I was either going to cooperate with them, or would have no choice but to work with the reformists on the new Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[17]`

### Węzeł `[20]`
Mówca: **Narrator**
> "I waited for him, wondering what he wanted to talk about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[17]`

### Węzeł `[21]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_SetUpMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "Good evening, sir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[33]`
  - -> `[71]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""The Chief Justice insisted on seeing you this evening. I do not know what he has to say but it will probably be about the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Suddenly, I heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Soon, Mr. Hawker will be coming to the meeting with Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Before they come, we should talk about our strategy, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""I'm sorry that I couldn't explain the situation to you in detail earlier, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good evening, Lucian.”"]** — Mówca: **Player**
> "“Good evening, Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Good to see you.”"]** — Mówca: **Player**
> "“Good to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Have a seat.”"]** — Mówca: **Player**
> "“Have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He sat on a chair near my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Good to see you too, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""He will be coming shortly with Judge Garaci to the meeting. We shouldn't take them lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[37]`
  - -> `[39]`
  - -> `[3]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“They are here to threaten us to stop the reforms.”"]** — Mówca: **Player**
> "“They are here to threaten us to stop the reforms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I think he's here to test the waters.""]** — Mówca: **Player**
> "“I think he's here to test the waters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“We may be able to cooperate with them.”"]** — Mówca: **Player**
> "“We may be able to cooperate with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Regardless of what they say, I will continue with the new Constitution.”"]** — Mówca: **Player**
> "“Regardless of what they say, I will continue with the new Constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“I knew they would come. We all want the same thing.”"]** — Mówca: **Player**
> "“I knew they would come. We all want the same thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""I agree. They will probably try to get you to their side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""We knew they would react at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""I advise against that, sir. I do not trust the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""Of course. Let's stand our ground and not let them antagonize us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""I'm sure they have heard about your intentions regarding the reforms. They must be coming here to make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""We should-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Livia opened the doors. Chief Justice Orso Hawker and Judge Heron Garaci entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Narrator**
> "There were three knocks at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Lucian checked his watch. He looked rather worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
Mówca: **Orso Hawker**
> ""Good evening, Mr. President. It's great to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Heron Garaci**
> ""Evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[77]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“There is nothing to talk about. Let's see what they have to say.""]** — Mówca: **Player**
> "“There is nothing to talk about. Let's see what they have to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“What are you suggesting?""]** — Mówca: **Player**
> "“What are you suggesting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“I aim to get a deal out of this meeting.""]** — Mówca: **Player**
> "“I aim to get a deal out of this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""We should be careful when dealing with the Old Guard, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""We should try not to antagonize them. In case we don't collaborate with them, we'll need their support in the Court's vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""And... I know I told you this before, sir. But I wouldn't trust the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""We should be careful when dealing with the Old Guard, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I don't trust him either.""]** — Mówca: **Player**
> "“I don't trust him either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Duly noted, Lucian. I'll see about that myself.""]** — Mówca: **Player**
> "“Duly noted, Lucian. I'll see about that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I've heard this enough, Lucian. I told you my intentions.""]** — Mówca: **Player**
> "“I've heard this enough, Lucian. I told you my intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Glad we're on the same page, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[65]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[67]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_SetUpMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[68]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[70]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[71]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Confront_Whiskey == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Confront_Whiskey == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Confront_Whiskey == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
**[WYBÓR GRACZA: "Raise your drink."]** — Mówca: **Player_Italic**
> "I raised the glass of whiskey and gestured at Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "He sat on a chair near my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""No thank you, sir. But good to see you enjoying yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Good to see you, gentlemen.""]** — Mówca: **Player**
> "“Good to see you, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Welcome, Justice Garaci and Chief Justice Hawker.""]** — Mówca: **Player**
> "“Welcome, Justice Garaci and Chief Justice Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""Good to see you, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Orso gestured at the sofa in the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Orso Hawker**
> "“May I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[82]`
  - -> `[84]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Please.""]** — Mówca: **Player**
> "“Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Let's have a seat, gentlemen.""]** — Mówca: **Player**
> ""Let's have a seat, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Narrator**
> "He gave me a blank stare and readjusted himself on the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[86]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Confront_Whiskey == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Confront_Whiskey == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Confront_Whiskey == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
Mówca: **Narrator**
> "We all took our seats on two opposite sofas and made ourselves comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Orso glanced at the glass of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Forgive me, would you also like to have a drink?""]** — Mówca: **Player**
> "“Forgive me, would you also like to have a drink?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Orso Hawker**
> "“Celebrating something, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[95]`
  - -> `[96]`
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""How were your first couple of months, Mr. President? I hope you're faring well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[94]`
Mówca: **Orso Hawker**
> ""No, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I was just trying to relax.""]** — Mówca: **Player**
> "“I was just trying to relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I don't think that's relevant to our meeting, Mr. Hawker.""]** — Mówca: **Player**
> ""I don't think that's relevant to our meeting, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Can we get to the point, Mr. Hawker?""]** — Mówca: **Player**
> ""Can we get to the point, Mr. Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[98]`
Mówca: **Orso Hawker**
> "“I'd like to stay as conscious and focused as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[99]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[100]`
Mówca: **Orso Hawker**
> "“A man needs his drink, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[101]`
Mówca: **Orso Hawker**
> "“Forgive me. Mr. *President.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[102]`
Mówca: **Orso Hawker**
> "“Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""Me neither, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The various government departments were sending me an avalanche of documents, all of which required my signature so they could start working on the new plans that had been decided on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Thank you, it's very busy but I'm doing good.""]** — Mówca: **Player**
> ""Thank you, it's very busy but I'm doing good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""To be honest, it was a rough start.""]** — Mówca: **Player**
> ""To be honest, it was a rough start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I'm doing well. No need to worry, Mr. Garaci.""]** — Mówca: **Player**
> ""I'm doing well. No need to worry, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""No need for pleasantries. Let's just get to the point.""]** — Mówca: **Player**
> ""No need for pleasantries. Let's just get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Orso Hawker**
> "“Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Orso Hawker**
> "“Forgive us. Mr. *President.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[111]`
Mówca: **Narrator**
> "They both gave me blank stares. Orso readjusted himself on the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Heron Garaci**
> ""That's great to hear, Mr. President. We also think you've been doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Heron Garaci**
> ""I couldn't imagine. Yet, I think you're doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Heron Garaci**
> ""Considering all that's happening around us. With the shootings near the Palace and soldiers on our borders...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "He let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Heron Garaci**
> ""It is a troubling time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
Mówca: **Heron Garaci**
> ""It will only get busier. Yet, I think you're doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[118]`
Mówca: **Orso Hawker**
> "“You invited us here this evening to talk about a possible cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Orso Hawker**
> "“So, let us hear it from you. What do you have in mind, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[132]`
  - -> `[135]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""We appreciate your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[121]`
Mówca: **Orso Hawker**
> "“So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[122]`
Mówca: **Orso Hawker**
> ""You probably know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[123]`
Mówca: **Orso Hawker**
> ""You know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Orso Hawker**
> ""We've heard that you're not giving full support to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[127]`
  - -> `[133]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""That's correct.""]** — Mówca: **Player**
> ""That's correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You must have heard wrong, Mr. Hawker.""]** — Mówca: **Player**
> ""You must have heard wrong, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Where did you hear that?""]** — Mówca: **Player**
> ""Where did you hear that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""I don't.""]** — Mówca: **Player**
> ""I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Please enlighten us, Mr. Hawker.""]** — Mówca: **Player**
> ""Please enlighten us, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""You're here to bribe me.""]** — Mówca: **Player**
> ""You're here to bribe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""You're here to stop the new Constitution.""]** — Mówca: **Player**
> ""You're here to stop the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I want to protect the current Constitution.""]** — Mówca: **Player**
> ""I want to protect the current Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""I want to protect our Constitution.""]** — Mówca: **Player**
> ""I want to protect our Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I offer cooperation against the reformists.""]** — Mówca: **Player**
> ""I offer cooperation against the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""We need to stay united in times of possible conflict.""]** — Mówca: **Player**
> ""We need to stay united in times of possible conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Orso Hawker**
> ""That's relieving to hear. Sordland has plunged into chaos because of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[137]`
Mówca: **Orso Hawker**
> ""Looks like we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[138]`
Mówca: **Orso Hawker**
> ""I agree. Sordland is in a dire situation right now. We need to stay focused on our real problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[139]`
Mówca: **Orso Hawker**
> ""That's relieving to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Orso Hawker**
> ""Looks like we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[141]`
Mówca: **Orso Hawker**
> ""The question is not where I heard that, but if it's true or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[142]`
Mówca: **Orso Hawker**
> ""That is quite possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Orso Hawker**
> ""So, you are going to push to change the Constitution, after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Orso Hawker**
> ""We would be honored to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I am weighing my options first.""]** — Mówca: **Player**
> ""I am weighing my options first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""No, I'd rather work with you, if that's a possibility.""]** — Mówca: **Player**
> ""No, I'd rather work with you, if that's a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[147]`
Mówca: **Orso Hawker**
> ""That's quite understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Yes, I don't support the reforms.""]** — Mówca: **Player**
> ""Yes, I don't support the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""It's neither true or false, I'm weighing my options first.""]** — Mówca: **Player**
> ""It's neither true or false, I'm weighing my options first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Heron Garaci laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Orso Hawker**
> ""We are only here to tell you that the Supreme Court does not approve of the attempt to change the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
Mówca: **Orso Hawker**
> ""We know you are working on a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Orso Hawker**
> ""The Supreme Court does not approve of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
> ""With all due respect, the Constitution needs to be updated, sir. I am sure you are well aware of the public demand and our circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Heron Garaci**
> ""I wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[156]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Intention == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Orso Hawker**
> ""Is that so? I see that you are the one who is not aware of our actual circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[160]`
Mówca: **Orso Hawker**
> ""And the public demanded to give more powers to the President? Spare me the lecture, I know you have *different* ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[161]`
Mówca: **Orso Hawker**
> ""Having said that, there are some things you need to be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Heron Garaci**
> ""Yes, Mr. President. Our national values and sovereignty are under attack. We must be vigilant and aggressive against these reformists. It's clear that their reforms are a conspiracy of foreign powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[165]`
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""How so?""]** — Mówca: **Player**
> ""How so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""I've read the security reports. I am suspecting something big too.""]** — Mówca: **Player**
> ""I've read the security reports. I am suspecting something big too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""That's a bit far-fetched, isn't it?""]** — Mówca: **Player**
> ""That's a bit far-fetched, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[166]`
Mówca: **Orso Hawker**
> ""In any case, it would have been an honor to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[167]`
Mówca: **Orso Hawker**
> ""Even if your proposal passes the Assembly, I will make sure it will not pass the Supreme Court. That much is clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`
  - -> `[173]`

### Węzeł `[168]`
Mówca: **Orso Hawker**
> ""You want to make a weaker Constitution in the midst of problems from both inside and outside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""You haven't even seen the proposal yet, Mr. Hawker. Isn't it too soon to be against it?""]** — Mówca: **Player**
> ""You haven't even seen the proposal yet, Mr. Hawker. Isn't it too soon to be against it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""So you came here to threaten us.""]** — Mówca: **Player**
> ""So you came here to threaten us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Come on, Mr. Hawker. We can figure something out.""]** — Mówca: **Player**
> ""Come on, Mr. Hawker. We can figure something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[172]`
Mówca: **Heron Garaci**
> ""Mr. President, if you are not aware of these plots, you should really reconsider your team of advisers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""We'll get the Court too, even if you do not cooperate.""]** — Mówca: **Player**
> ""We'll get the Court too, even if you do not cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Orso Hawker**
> ""Do you think I live under a rock, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Orso Hawker**
> ""I know what goes on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[176]`
Mówca: **Orso Hawker**
> ""How was that a threat, Mr. President? I merely stated my position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""There is no threat here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[178]`
Mówca: **Orso Hawker**
> ""We can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Orso Hawker**
> ""If you decide to give us a listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Orso Hawker**
> ""Good luck with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Orso Hawker**
> ""Justices of the Supreme Court cannot be bought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""I am sure they cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Heron Garaci**
> ""Yet you, Mr. President, seem to be only partially informed about the current situation. Please let us explain the reasons of our stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`
  - -> `[188]`

### Węzeł `[184]`
Mówca: **Heron Garaci**
> ""Mr. President, you seem to be only partially informed about the current situation. Please let us explain the reasons of our stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`
  - -> `[188]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""I believe I am fully informed about the situation, Mr. Garaci.""]** — Mówca: **Player**
> ""I believe I am fully informed about the situation, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Oh? Please explain.""]** — Mówca: **Player**
> ""Oh? Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Let's hear it.""]** — Mówca: **Player**
> ""Let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[188]`
**[WYBÓR GRACZA: ""I don't care about your reasons.""]** — Mówca: **Player**
> ""I don't care about your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""With all due respect, how could a Justice have better security intel than the President of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
Mówca: **Heron Garaci**
> ""It's not only some *thing*, Mr. President. The superpowers are playing chess in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""Mr. President, if you are not aware of these plots, you should really reconsider your team of advisers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[193]`
Mówca: **Orso Hawker**
> ""Please let me explain. We have important information you may not have heard yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[194]`
Mówca: **Orso Hawker**
> ""That is a good question. How? Maybe you should first see if your security team is worth trusting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[196]`
**[WYBÓR GRACZA: ""I trust my team, Mr. Hawker. You shouldn't concern yourself with these matters.""]** — Mówca: **Player**
> ""I trust my team, Mr. Hawker. You shouldn't concern yourself with these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
**[WYBÓR GRACZA: ""Let the Chief Justice talk, Lucian.""]** — Mówca: **Player**
> ""Let the Chief Justice talk, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Orso Hawker**
> ""I did not want to offend you, Mr. President. But I meant it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Orso Hawker**
> ""I have incriminating evidence against a very prominent political personality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Orso Hawker**
> ""But before I give you that... I've had a couple of questions on my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[201]`
Mówca: **Heron Garaci**
> ""Sordland has more important problems and threats that we should face right now instead of nitpicking about some paragraphs of the Constitution. We have a potential war within our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[202]`
Mówca: **Heron Garaci**
> ""We are protecting the Constitution, because it works, Mr. President. It is efficient and it gives you the authority to lead the nation with swift decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[203]`
Mówca: **Heron Garaci**
> ""That's exactly what they want you to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Heron Garaci**
> ""You think you are, Mr. President. But the Chief Justice has some intel on something that you would be very interested in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`
  - -> `[212]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""Who are 'they'?""]** — Mówca: **Player**
> ""Who are 'they'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I am merely stating my feelings.""]** — Mówca: **Player**
> ""I am merely stating my feelings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""What does that mean?""]** — Mówca: **Player**
> ""What does that mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Orso Hawker**
> ""Mr. President. I know that you are a busy man, so I will make this quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[209]`
Mówca: **Narrator**
> "Orso signalled Heron with his hand to let him speak instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[210]`
**[WYBÓR GRACZA: ""And what would that be?""]** — Mówca: **Player**
> ""And what would that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[211]`
**[WYBÓR GRACZA: ""Go on.""]** — Mówca: **Player**
> ""Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I am not interested in your games.""]** — Mówca: **Player**
> ""I am not interested in your games.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[213]`
Mówca: **Orso Hawker**
> ""What do you think about the offensive posturing of Rumburg and their KA-74's being found in the hands of the Blud separatists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`
  - -> `[216]`
  - -> `[263]`

### Węzeł `[214]`
**[WYBÓR GRACZA: ""I am very troubled by that. We need to be prepared against Rumburg.""]** — Mówca: **Player**
> ""I am very troubled by that. We need to be prepared against Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Blud separatists must be dealt with before they gain the support of the Bluds.""]** — Mówca: **Player**
> ""Blud separatists must be dealt with before they gain the support of the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""The connection is not that strong, I don't think they are a real threat.""]** — Mówca: **Player**
> ""The connection is not that strong, I don't think they are a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Orso Hawker**
> ""Is the administration doing something about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`
  - -> `[221]`
  - -> `[264]`

### Węzeł `[218]`
Mówca: **Orso Hawker**
> ""We all know what the Bludish Freedom Front stands for. How come stashes of Rumburgian KA rifles do not trouble you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""I don't think the organization is strong enough to create problems.""]** — Mówca: **Player**
> ""I don't think the organization is strong enough to create problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""We haven't found thousands of it. That is not enough to establish a direct connection.""]** — Mówca: **Player**
> ""We haven't found thousands of it. That is not enough to establish a direct connection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""My security team is working on that.""]** — Mówca: **Player**
> ""My security team is working on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""We are not rushing with our actions just yet.""]** — Mówca: **Player**
> ""We are not rushing with our actions just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Not as fast as I'd like to.""]** — Mówca: **Player**
> ""Not as fast as I'd like to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Orso Hawker**
> ""Clearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Orso Hawker**
> ""And you said you will not focus on military during your term. How is that for a preparation? You will be the one to blame if you actually proceed with that campaign talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Orso Hawker**
> ""That's not good enough, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[230]`
Mówca: **Heron Garaci**
> ""We hope that regardless of your promise, you increase the security measures and put every Sord's mind at a little more ease.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`
  - -> `[239]`

### Węzeł `[231]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
Mówca: **Orso Hawker**
> ""Have you even talked with your own generals? Or Mr. Lancea? I don't think they share your views, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[235]`
Mówca: **Orso Hawker**
> ""And you said you will not focus on military during your term. Are you aware what that could mean for Sordland? You will be the one to blame if you actually proceed with that campaign talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[236]`
Mówca: **Orso Hawker**
> ""We need an increase on our security budgets. This is an actual emergency. It affects all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I agree, security will be improved.""]** — Mówca: **Player**
> ""I agree, security will be improved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I am not sure about it.""]** — Mówca: **Player**
> ""I am not sure about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Is that a demand?""]** — Mówca: **Player**
> ""Is that a demand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Orso Hawker**
> ""Sure, Mr. President. It is a demand. A just and logical one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Heron Garaci**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Orso Hawker**
> ""Are you also aware that the armed Bludish separatists have direct connections with the Workers Party of Bludia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`
  - -> `[245]`
  - -> `[246]`

### Węzeł `[243]`
**[WYBÓR GRACZA: ""Everybody knows that.""]** — Mówca: **Player**
> ""Everybody knows that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""They claim otherwise.""]** — Mówca: **Player**
> ""They claim otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""The Worker's Party is a democratic party unlike the militias. They are not the same.""]** — Mówca: **Player**
> ""The Worker's Party is a democratic party unlike the militias. They are not the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""I mean... They are all Bluds.""]** — Mówca: **Player**
> ""I mean... They are all Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Orso Hawker**
> ""They may claim they have no ties with the separatists, but most of their members used to be part of them before they formed the Workers Party of Bludia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Heron Garaci**
> ""How about the name, Mr. President? It is not the 'Workers Party of Sordland', is it? As far as I am aware, there is no nation called Bludia around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[249]`
Mówca: **Heron Garaci**
> ""They are. And both organizations want the same thing. To gain independence from Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""You know what that means. Do you remember the vote of the Workers'Party in the last election?""]** — Mówca: **Orso Hawker**
> ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
> ""I see where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Orso Hawker**
> ""Today, the only reason they are not in the Assembly is because of the electoral threshold. They have gotten quite big too. They are clearly getting outside help and their connections to the paramilitary Bludish force cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Orso Hawker**
> ""And all of a sudden, the reformists are trying to decrease the electoral threshold, so that the Bludish separatists can be legitimized in the Assembly to achieve their aims of independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`

### Węzeł `[254]`
**[WYBÓR GRACZA: ""You think that's Mr. Ricter's intention?""]** — Mówca: **Player**
> ""You think that's Mr. Ricter's intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""That's why we cannot allow it, Mr. Hawker.""]** — Mówca: **Player**
> ""That's why we cannot allow it, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""That's too dramatic.""]** — Mówca: **Player**
> ""That's too dramatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Orso Hawker**
> ""Say what you will, Mr. President. I am stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
Mówca: **Orso Hawker**
> ""I suspect his intentions are grander.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Orso Hawker**
> ""Therefore, we need to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Orso Hawker**
> ""I wish the only issues were the Bludish terrorists and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Orso Hawker**
> ""Now we have conflicts on the streets between the nationalists and the communists. And the communists are gathering really fast after the shooting of Circas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Orso Hawker**
> ""This could potentially lead to civil war, Mr. President. We know that United Contana supports the communists in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""What does that have to do with anything?""]** — Mówca: **Player**
> ""What does that have to do with anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""With all due respect, that does not really concern you.""]** — Mówca: **Player**
> ""With all due respect, that does not really concern you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[265]`
Mówca: **Narrator**
> "Lucian gave a mocking look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[266]`
Mówca: **Orso Hawker**
> ""We all know that Sordish security forces found stashes of Rumburgian weaponry in the hideouts of Bludish separatists. KA-74's are roaming inside Sordland at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Orso Hawker**
> ""As much as Rumburg poses a direct threat, now it's clear that they are also intervening in our country and weaponising our minorities against us. It's not unprecedented to think that the Bluds will start their terror again with their new toys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Orso Hawker**
> ""Not to mention the fights that broke out between the left and right wing after the shooting of Bernard Circas. Communists are rising with the support of United Contana. The chaos is imminent for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Orso Hawker**
> ""And sadly we don't see the administration taking the necessary precautions. You said you will not focus on military during your term. Under current circumstances that cannot be tolerated at any cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`
  - -> `[276]`
  - -> `[277]`

### Węzeł `[273]`
Mówca: **Orso Hawker**
> ""And sadly we don't see the administration taking the necessary precautions yet. We clearly need more funding for our security forces for the days to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`
  - -> `[280]`

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Mr. Hawker, the Court has no jurisdiction over these matters.""]** — Mówca: **Player**
> ""Mr. Hawker, the Court has no jurisdiction over these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""We are taking the necessary steps. No need to worry.""]** — Mówca: **Player**
> ""We are taking the necessary steps. No need to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[276]`
**[WYBÓR GRACZA: ""I did promise that but the circumstances have changed.""]** — Mówca: **Player**
> ""I did promise that but the circumstances have changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[277]`
**[WYBÓR GRACZA: ""Tolerate!? You should be more careful with your words of choice.""]** — Mówca: **Player**
> ""Tolerate!? You should be more careful with your words of choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[278]`
**[WYBÓR GRACZA: ""Mr. Hawker, the Court has no jurisdiction over these matters.""]** — Mówca: **Player**
> ""Mr. Hawker, the Court has no jurisdiction over these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""We are taking the necessary steps, no need to worry.""]** — Mówca: **Player**
> ""We are taking the necessary steps. No need to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[280]`
**[WYBÓR GRACZA: ""I will actually be increasing the security budget shortly.""]** — Mówca: **Player**
> ""I will actually be increasing the security budget shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[281]`
Mówca: **Orso Hawker**
> ""Aren't we all part of this State, Mr. President? We are all responsible if Sordland fails to overcome these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[282]`
Mówca: **Orso Hawker**
> ""We hope that our police forces and our military is adequately funded during these times of conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[283]`
Mówca: **Orso Hawker**
> ""I am relieved to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
Mówca: **Orso Hawker**
> ""Surely a decision to destroy Sordland cannot be tolerated whether it comes from you or President Soll. Why can't you admit that we are making sense here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[285]`
Mówca: **Orso Hawker**
> ""Aren't we all part of this State, Mr. President? We are all responsible if Sordland fails to overcome these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[286]`
Mówca: **Orso Hawker**
> ""We hope that our police forces and our military is adequately funded during these times of conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Orso Hawker**
> ""I am relieved to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Orso Hawker**
> ""But regardless of that, are you also aware that the armed Bludish separatists have direct connections with the Worker's Party of Bludia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`
  - -> `[292]`
  - -> `[289]`

### Węzeł `[289]`
**[WYBÓR GRACZA: ""I mean... They are all Bluds.""]** — Mówca: **Player**
> ""I mean... They are all Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""Everybody knows that.""]** — Mówca: **Player**
> ""Everybody knows that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[291]`
**[WYBÓR GRACZA: ""They claim otherwise.""]** — Mówca: **Player**
> ""They claim otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
**[WYBÓR GRACZA: ""The Worker's Party is a democratic party unlike the militias. They are not the same.""]** — Mówca: **Player**
> ""The Worker's Party is a democratic party unlike the militias. They are not the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Orso Hawker**
> ""They may claim they have no ties with the separatists, but most of their members used to be part of them before they formed the Workers' Party of Bludia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Heron Garaci**
> ""They are. And both organizations want the same thing. To gain independence from Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[295]`
Mówca: **Heron Garaci**
> ""How about the name, Mr. President? It is not the 'Workers' Party of Sordland', is it? As far as I am aware, there is no nation called Bludia around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
**[WYBÓR GRACZA: ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""]** — Mówca: **Orso Hawker**
> ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""What is this all about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Orso Hawker**
> ""The only reason they are not in the Assembly is because of the electoral threshold. They have gotten quite big. They are clearly getting outside help and their connections to the paramilitary Bludish force cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Orso Hawker**
> ""And all of a sudden, the reformists are trying to decrease the electoral threshold, so that the Bludish separatists can be legitimized in the Assembly to achieve their aims of independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[301]`
  - -> `[300]`
  - -> `[313]`

### Węzeł `[300]`
**[WYBÓR GRACZA: ""That's too dramatic.""]** — Mówca: **Player**
> ""That's too dramatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[301]`
**[WYBÓR GRACZA: ""I will not allow it to happen.""]** — Mówca: **Player**
> ""I will not allow it to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
**[WYBÓR GRACZA: ""You think that's Mr. Ricter's intention?""]** — Mówca: **Player**
> ""You think that's Mr. Ricter's intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[303]`
Mówca: **Orso Hawker**
> ""Say what you will, Mr. President. I am stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Orso Hawker**
> ""Therefore, we need to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Orso Hawker**
> ""But I wish the only issues were the Bludish terrorists and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Orso Hawker**
> ""I suspect his intentions are grander.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[307]`
Mówca: **Heron Garaci**
> ""The Reformists' suggested changes would also bring the communists -- who are backed by United Contana -- into the Assembly. Do you see the pattern yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[308]`
  - -> `[310]`
  - -> `[311]`

### Węzeł `[308]`
**[WYBÓR GRACZA: ""You're saying the reformists are working for the foreign powers?""]** — Mówca: **Player**
> ""You're saying the reformists are working for the foreign powers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""I apologise, gentlemen. But I am not a conspiracy theorist.""]** — Mówca: **Player**
> ""I apologise, gentlemen. But I am not a conspiracy theorist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""There is no evidence about any of this.""]** — Mówca: **Player**
> ""There is no evidence about any of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[311]`
**[WYBÓR GRACZA: ""And what is your suggestion?""]** — Mówca: **Player**
> ""And what is your suggestion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I am not working with the reformists, Mr. Hawker.""]** — Mówca: **Player**
> ""I am not working with the reformists, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[313]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[315]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Intention == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[316]`
Mówca: **Orso Hawker**
> ""I am aware. Yet you're proceeding with your own version of changes to the Constitution, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`
  - -> `[319]`
  - -> `[320]`

### Węzeł `[317]`
**[WYBÓR GRACZA: ""I am. The new Constitution will not be weaker but stronger.""]** — Mówca: **Player**
> ""I am. The new Constitution will not be weaker but stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[318]`
**[WYBÓR GRACZA: ""We'll see about that.""]** — Mówca: **Player**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
**[WYBÓR GRACZA: ""Yes. I need more powers to fix these problems.""]** — Mówca: **Player**
> ""Yes. I need more powers to fix these problems of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
**[WYBÓR GRACZA: ""Unless you have something better to propose.""]** — Mówca: **Player**
> ""Unless you have something better to propose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Orso Hawker**
> ""You already have the power of the decrees, Mr. President. As long as we work together, we can allow you to enact major changes with the presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[322]`
Mówca: **Heron Garaci**
> ""This is not a conspiracy theory. Haven't you been briefed by your security team? Maybe you should suspect them as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Heron Garaci**
> ""Haven't you been briefed by your security team? Maybe you should suspect them as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Orso Hawker**
> ""We should take the necessary measures against communist and Bludish plots as well as increasing our military budget against a possible conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Heron Garaci**
> ""And of course not fall into the traps of the reformists by listening to their demands. They are clearly plotting to weaken the President and our whole administration in order to exploit the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Orso Hawker**
> ""...Which brings us to some very important information that we have. It's definitely something you need to hear, and it can change absolutely everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""With all due respect, Mr. President, I think this is getting slightly ridiculous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Let the Chief Justice talk, Lucian.""]** — Mówca: **Player**
> ""Let the Chief Justice talk, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
**[WYBÓR GRACZA: ""You're right. I don't think anything will come out of this meeting.""]** — Mówca: **Player**
> ""You're right. I don't think anything will come out of this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Orso Hawker**
> ""So you don't want to hear about the information that I have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[333]`
Mówca: **Orso Hawker**
> ""The person in question is Mr. Frens Ricter, himself. The *leader* of the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Orso Hawker**
> ""We have enough information to infer that he has ties with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Orso Hawker**
> ""Arcasia is aggressively growing their influence around the world and now we have Mr. Ricter coming up with these ridiculous demands for a new Constitution amidst a chaotic period in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
> ""How would you know that Mr. Ricter has ties to Arcasia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[337]`
Mówca: **Orso Hawker**
> ""All the pieces seem to fit perfectly. That is why the Supreme Court will be doing what it takes to stop these reforms and preserve the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[338]`
Mówca: **Orso Hawker**
> ""He was spotted in a hotel in Arcasia last year, where they held the 'Conference on Economic Development in Volatile Regions'. Right around that time, he started to influence the masses into believing that our Constitution is the reason for everything bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
Mówca: **Heron Garaci**
> ""Mr. Galade, we all know he has been in Arcasia many times, because it's been documented. But what would you think if I told you he has been making hidden flights to the country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`
  - -> `[342]`

### Węzeł `[340]`
**[WYBÓR GRACZA: ""I need to know this. Please explain.""]** — Mówca: **Player**
> ""I need to know this. Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""He was hiding his flights to Arcasia?""]** — Mówca: **Player**
> ""He was hiding his flights to Arcasia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Another conspiracy theory.""]** — Mówca: **Player**
> ""Another conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[343]`
Mówca: **Heron Garaci**
> ""He was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[344]`
Mówca: **Orso Hawker**
> ""His trip was not documented, nor was he an official guest of the conference. We believe that he had a meeting with President Walker behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Orso Hawker**
> ""I also have more photos of him that were taken in Arcasia in different cities. One is from a couple months back. Again, none of it is documented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Orso Hawker**
> ""He also attended another event in Lespia last week. The Arcasian Minister of Foreign Affairs was there too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`
  - -> `[349]`

### Węzeł `[347]`
**[WYBÓR GRACZA: ""How did you find out about this?""]** — Mówca: **Player**
> ""How did you find out about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[348]`
**[WYBÓR GRACZA: ""If this is true, this is *big*.""]** — Mówca: **Player**
> ""If this is true, this is *big*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""How can any of these be undocumented?""]** — Mówca: **Player**
> ""How can any of these be undocumented?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Orso Hawker**
> ""We don't know. Even if he used a private plane, we would be able to get the information of his flights. That means he has people helping them from inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Orso Hawker**
> ""Many Sollists were already following his leads for quite some time, Mr. President. I cannot give away their identities, but I can give you the evidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Narrator**
> "He handed me a small file."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Orso Hawker**
> ""I told you so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[354]`
Mówca: **Narrator**
> "It contained official documents from the Sordish Border Guard with highlighted dates that showed no trace of Frens Ricter's name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Narrator**
> "There were clear photos of him that were taken in the conference in Arcasia, as well as remarks by Lespian and Arcasian citizens who claim to have seen him with Arcasian businessmen around the same dates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Narrator**
> "There was also an official transcript of one of his speeches where he claimed to be in Benfi on the dates of the conference in Arcasia, where he was spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""These seem to be real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Orso Hawker**
> ""Of course they are real, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[359]`
Mówca: **Orso Hawker**
> ""Believe what you will, Mr. President. But at least hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[360]`
Mówca: **Orso Hawker**
> ""Now you understand the reasons for our current stance. And also our suspicions about your advisers, who clearly have not given you this vital information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Narrator**
> "Lucian gave him a sharp look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[362]`
**[WYBÓR GRACZA: ""There is no need, Mr. Hawker. This meeting is over.""]** — Mówca: **Player**
> ""There is no need, Mr. Hawker. This meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
**[WYBÓR GRACZA: ""I want to hear it first.""]** — Mówca: **Player**
> ""I want to hear it first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Narrator**
> "Lucian looked upset."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[365]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[366]`
Mówca: **Narrator**
> "Lucian skimmed through the documents with skepticism which slowly turned into surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[367]`
Mówca: **Orso Hawker**
> ""We should take the necessary measures against communist and Bludish plots as well as increasing our military budget against a possible conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[368]`
Mówca: **Heron Garaci**
> ""The Reformists' suggested changes would also bring the communists -- who are backed by United Contana -- into the Assembly. Do you see the pattern yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[371]`
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
**[WYBÓR GRACZA: ""You're saying the reformists are working for the foreign powers?""]** — Mówca: **Player**
> ""You're saying the reformists are working for the foreign powers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[370]`
**[WYBÓR GRACZA: ""And what is your suggestion?""]** — Mówca: **Player**
> ""And what is your suggestion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[371]`
**[WYBÓR GRACZA: ""I apologize gentlemen but I am not a conspiracy theorist.""]** — Mówca: **Player**
> ""I apologize gentlemen but I am not a conspiracy theorist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[372]`
**[WYBÓR GRACZA: ""This doesn't look good.""]** — Mówca: **Player**
> ""This doesn't look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[373]`
Mówca: **Heron Garaci**
> ""Haven't you been briefed by your security team? Maybe you should start suspecting them too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[374]`
Mówca: **Heron Garaci**
> ""This is not a conspiracy theory. Haven't you been briefed by your security team? Maybe you should start suspecting them too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[375]`
Mówca: **Heron Garaci**
> ""No, it doesn't, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[376]`
Mówca: **Heron Garaci**
> ""And of course not fall into the traps of the reformists by listening to their demands. They are clearly plotting to weaken the President and our whole administration in order to exploit the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Orso Hawker**
> ""...Which brings us to the information that I have about this important figure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Finally.""]** — Mówca: **Player**
> ""Finally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Orso Hawker**
> ""The person in question is Mr. Frens Ricter, himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Orso Hawker**
> ""We have enough information to infer that he has ties with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Orso Hawker**
> ""All the pieces seem to fit perfectly. That is why the Supreme Court will be doing what it takes to stop these reforms and preserve the Constitution together with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[383]`
Mówca: **Orso Hawker**
> ""Arcasia is aggressively growing their influence around the world and now we have Mr. Ricter coming up with these ridiculous demands for a new Constitution amidst a chaotic period in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[384]`
Mówca: **Lucian Galade**
> ""How would you know that Mr. Ricter has ties to Arcasia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[385]`
Mówca: **Orso Hawker**
> ""...At least that's what we hope for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[386]`
Mówca: **Orso Hawker**
> ""There is not much to think or check... This is clearly an emergency. In such cases, the Constitution gives the President the right to use his emergency powers. If we work together, you can be sure that the Supreme Court will not block your declaration of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`
  - -> `[390]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""We appreciate the information, Mr. Hawker, but I advise against jumping to conclusions right away. We still need to check the information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[388]`
**[WYBÓR GRACZA: ""Let's talk about how we can work together.""]** — Mówca: **Player**
> ""Let's talk about how we can work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[389]`
**[WYBÓR GRACZA: ""You want me to declare an emergency?""]** — Mówca: **Player**
> ""You want me to declare an emergency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[390]`
**[WYBÓR GRACZA: ""I am still too skeptical about these, Mr. Hawker. I will have to decline.""]** — Mówca: **Player**
> ""I am still too skeptical about these, Mr. Hawker. I will have to decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Lucian Galade**
> ""What is that supposed to mean, Mr. Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[392]`
Mówca: **Orso Hawker**
> ""It seems you are more influenced by Mr. Galade than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[393]`
Mówca: **Orso Hawker**
> ""Of course. We cannot wait for the processes of the Assembly to take care of these issues. You must exercise your presidential powers for a fast and effective solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Orso Hawker**
> ""Which means you might need to suspend parts of the Constitution to give more authority to our security forces to deal with these issues. We must officially investigate Mr. Ricter as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Orso Hawker**
> ""You can devise a strong security decree if you can base it on the Articles 57 and 58, which gives the president the right to suspend parts of the Constitution to deal with national security threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Orso Hawker**
> ""You can directly bypass the Assembly in such a situation. The only thing you need is the Supreme Court to allow the emergency to be declared. And you have our word on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Lucian Galade**
> ""Sir, I think that is going a bit too far. We shouldn't escalate things so fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[398]`
Mówca: **Orso Hawker**
> ""We can devise a plan together. I know how we can use the Constitution to our advantage. It would be more effective if Mr. Galade and Mr. Garaci leave the room before we discuss it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""Sir, I advise against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[405]`
  - -> `[406]`
  - -> `[407]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""Could you leave us alone with Mr. Hawker, gentlemen?""]** — Mówca: **Player**
> ""Could you leave us alone with Mr. Hawker, gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[401]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[404]`
Mówca: **Narrator**
> "Lucian looked at me to hear my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
**[WYBÓR GRACZA: ""I like your idea, Mr. Hawker but I'd rather plan it together.""]** — Mówca: **Player**
> ""I like your idea, Mr. Hawker, but I'd rather plan it together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[406]`
**[WYBÓR GRACZA: ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""]** — Mówca: **Player**
> ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
**[WYBÓR GRACZA: ""Regardless of our situation, I'll be proceeding with the reforms.""]** — Mówca: **Player**
> ""Regardless of our situation, I'll be proceeding with the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
Mówca: **Orso Hawker**
> ""Even though you are aware of our national security threats...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Heron Garaci**
> ""You are making a big mistake, Mr. President. We will not allow you to succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[418]`
  - -> `[424]`

### Węzeł `[410]`
Mówca: **Orso Hawker**
> ""Why don't you explain your agenda yourself, Lucian? You are swaying the President to ignore the national security threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`
  - -> `[487]`

### Węzeł `[411]`
**[WYBÓR GRACZA: ""I am not swayed by anyone, Mr. Hawker. This is my own decision.""]** — Mówca: **Player**
> ""I am not swayed by anyone, Mr. Hawker. This is my own decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
**[WYBÓR GRACZA: ""You are the one trying to sway me into believing in conspiracies.""]** — Mówca: **Player**
> ""You are the one trying to sway me into believing in conspiracies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Orso Hawker**
> ""Say what you will. History will prove us right, once again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Heron Garaci**
> ""And if you believe you can enact these reforms, you are living in a land of dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[415]`
  - -> `[489]`

### Węzeł `[415]`
**[WYBÓR GRACZA: ""Sorry to upset you, gentlemen.""]** — Mówca: **Player**
> ""Sorry to upset you, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[416]`
Mówca: **Narrator**
> "There was a long silence in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Orso Hawker**
> ""It seems the President is done with us, Heron. Let's take our leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[418]`
**[WYBÓR GRACZA: ""ENOUGH!""]** — Mówca: **Player**
> ""ENOUGH!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[419]`
Mówca: **Orso Hawker**
> ""Well, Mr. President. Do you want to talk about how we can fight against these reformists and the others? Or did you made up your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
**[WYBÓR GRACZA: ""Let's hear your suggestions.""]** — Mówca: **Player**
> ""Let's hear your suggestions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[421]`
**[WYBÓR GRACZA: ""No, Mr. Hawker. I think this meeting is over.""]** — Mówca: **Player**
> ""No, Mr. Hawker. I think this meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[422]`
Mówca: **Orso Hawker**
> ""Mr. President, why don't we talk in private, just the two of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[423]`
**[WYBÓR GRACZA: ""You are the ones who are making the mistake.""]** — Mówca: **Player**
> ""You are the ones who are making the mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[424]`
**[WYBÓR GRACZA: ""Gentlemen, I think it's about time to end this meeting.""]** — Mówca: **Player**
> ""Gentlemen, I think it's about time to end this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Orso Hawker**
> ""Well, thank you for having us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Orso Hawker**
> ""We will see, Mr. President. We will see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Orso Hawker**
> ""Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[428]`
Mówca: **Narrator**
> "They stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[429]`
Mówca: **Orso Hawker**
> ""Glad to hear that we're on the same page, Mr. President. But I will have to insist on the private talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`
  - -> `[424]`

### Węzeł `[430]`
**[WYBÓR GRACZA: ""Fair enough. Will you leave us, gentlemen?""]** — Mówca: **Player**
> ""Fair enough. Will you leave us, gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
**[WYBÓR GRACZA: ""Lucian?""]** — Mówca: **Player**
> ""Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Lucian Galade**
> ""You know exactly what I think. But if you both insist upon it, I will leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Orso Hawker**
> ""Then please do so, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[434]`
Mówca: **Narrator**
> "Lucian stood up as Orso gave him a smile. Heron paid his respects and left with Lucian, leaving me and Orso alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Orso Hawker**
> ""So, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Orso Hawker**
> ""If you stop the reform committee meetings immediately and focus on the real threats, I will guarantee you, we will manage the reformists together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Orso Hawker**
> ""You must eliminate these threats both internal and external. An emergency act can help you do that. We cannot trust anyone in the administration either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Tell me more about the legal details of an emergency act.""]** — Mówca: **Player**
> ""Tell me more about the legal details of an emergency act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[439]`
**[WYBÓR GRACZA: ""How can we fight against these threats with an emergency act?""]** — Mówca: **Player**
> ""How can we fight against these threats with an emergency decree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[440]`
Mówca: **Orso Hawker**
> ""According to Article 58, if public security and order are seriously disturbed or endangered within the Republic of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[441]`
Mówca: **Orso Hawker**
> ""...the President of Sordland may modify and suspend parts of Constitution, subject to confirmation by the Supreme Court, to determine the validity of the declaration of a state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[442]`
**[WYBÓR GRACZA: ""Which parts of the Constitution can we modify or suspend?""]** — Mówca: **Player**
> ""Which parts of the Constitution can we modify or suspend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[443]`
**[WYBÓR GRACZA: ""How can we effectively silence the opposition?""]** — Mówca: **Player**
> ""How can we effectively silence the opposition?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[444]`
**[WYBÓR GRACZA: ""Can't the Assembly simply revoke it?""]** — Mówca: **Player**
> ""Can't the Assembly simply revoke it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[445]`
Mówca: **Orso Hawker**
> ""That is kind of a grey area. The Constitution states that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[446]`
**[WYBÓR GRACZA: ""I agree. Sordland is in a crisis.""]** — Mówca: **Player**
> ""I agree. Sordland is in a crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Orso Hawker**
> ""Yes, this is very serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[448]`
Mówca: **Orso Hawker**
> ""...no State shall, in the case of National Emergency, modify or suspend the rights of freedom, defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not admit of delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[452]`
  - -> `[450]`

### Węzeł `[449]`
**[WYBÓR GRACZA: ""If we want to give the police more authority, we might need to modify the rights of freedom too.""]** — Mówca: **Player**
> ""If we want to give the police more authority, we might need to modify the rights of freedom too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
**[WYBÓR GRACZA: ""Such imminent danger... That can definitely be argued to be the case.""]** — Mówca: **Player**
> ""Such imminent danger... That can definitely be argued to be the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[451]`
Mówca: **Orso Hawker**
> ""That is correct. Current security laws are limited because of the personal freedoms defined in Article 100. We may need to suspend some of the privacy laws which definitely conflicts with the Constitution...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
**[WYBÓR GRACZA: ""But we are not under invasion.""]** — Mówca: **Player**
> ""But we are not under invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[453]`
Mówca: **Orso Hawker**
> ""However, the section where it states that 'actually invaded, or in such imminent danger as will not admit of delay' can be up to interpretation. We are definitely under such imminent danger because of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Orso Hawker**
> ""Not to mention United Contana's support for a communist coup in Sordland as well as Frens Ricter's involvement with Arcasia, which is definitely connected to all of these problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
Mówca: **Orso Hawker**
> ""That is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[456]`
Mówca: **Orso Hawker**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Orso Hawker**
> ""It can definitely be argued that we are under such imminent danger because of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[458]`
Mówca: **Orso Hawker**
> ""And of course, that is up to the Supreme Court to decide. So that is not a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[459]`
Mówca: **Orso Hawker**
> ""You have the power to give more authority to the police with their search warrants, suspicion- based arrests, detention without trials... as well as banning the threatening nations' citizens from entering Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[460]`
Mówca: **Orso Hawker**
> ""We may need increased surveillance on our political rivals to find out about their connections and plots. Bringing unlimited detention would allow you to arrest people as necessary, such as Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[461]`
**[WYBÓR GRACZA: ""What if the investigations cannot find anything incriminating?""]** — Mówca: **Player**
> ""What if the investigations cannot find anything incriminating?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[462]`
**[WYBÓR GRACZA: ""He needs to be eliminated.""]** — Mówca: **Player**
> ""He needs to be eliminated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[463]`
**[WYBÓR GRACZA: ""That might be going a bit too far.""]** — Mówca: **Player**
> ""That might be going a bit too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Orso Hawker**
> ""I disagree. You already know about the coup plots and foreign backed terrorists in Sordland. And a lot of these issues overlap with the reformist agenda of creating a weaker Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Orso Hawker**
> ""I suspect Frens Ricter is involved with many of these organisations. He may even be working together with Rumburg. And they really do pose an existential threat to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[466]`
Mówca: **Orso Hawker**
> ""The information that I gave you can be enough, depending on what parts of the Constitution you'll modify. In an emergency, anything is possible, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Orso Hawker**
> ""The Supreme Court will support your decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[468]`
Mówca: **Orso Hawker**
> ""I agree. In an emergency, anything is possible, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[469]`
Mówca: **Orso Hawker**
> ""According to the Constitution, only the President and the Grand National Assembly can revoke the emergency after it is declared. That is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[470]`
Mówca: **Orso Hawker**
> ""However, as long as your party is in line, they will never have a majority to revoke it immediately. So, no. They cannot *simply* revoke it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[471]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: AutocratHub01)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[493]`
  - -> `[496]`
  - -> `[478]`

### Węzeł `[472]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[473]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_C = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Jump to: [AutocratHub01])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[476]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Jump to: [AutocratHub01])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[477]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Jump to: [AutocratHub01])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[478]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[481]`
  - -> `[516]`

### Węzeł `[480]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[481]`
**[WYBÓR GRACZA: ""Let's talk about the details of this emergency act.""]** — Mówca: **Player**
> ""Let's talk about the details of this emergency act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Orso Hawker**
> ""You must first justify the emergency act. We need to have at least one target that we can blame the conflicts on. They will be declared as a national security threat, and this would allow us to prosecute their members or people connected to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[483]`
**[WYBÓR GRACZA: ""Young Sords executed an attack near the Palace. They must pay for it.""]** — Mówca: **Player**
> ""Young Sords executed an attack near the Palace. They must pay for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[484]`
**[WYBÓR GRACZA: ""Red Youth must be targeted before they get too powerful to trigger a revolution.""]** — Mówca: **Player**
> ""Red Youth must be targeted before they get too powerful to trigger a revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[485]`
Mówca: **Orso Hawker**
> ""These seem to suggest that Arcasia is behind the reformists. Their demands will only benefit Arcasia. They want us to have a weaker administration while we face all these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[486]`
Mówca: **Orso Hawker**
> ""This is clearly a plot against Sordland. I bet Rumburg is part of their plan too. It cannot be a coincidence that they are weaponizing our minorities against us around the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[487]`
**[WYBÓR GRACZA: ""Gentlemen, let's get back to the topic.""]** — Mówca: **Player**
> ""Gentlemen, let's get back to the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[488]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[489]`
**[WYBÓR GRACZA: ""I think this meeting is over.""]** — Mówca: **Player**
> ""I think this meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[490]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[493]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[495]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[496]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[498]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[499]`
**[WYBÓR GRACZA: ""Okay. Where do we begin?""]** — Mówca: **Player**
> ""Okay. Where do we begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[500]`
Mówca: **Orso Hawker**
> ""There are obvious connections between the Bludish separatists and Rumburg. And the separatists have clear connections to the Worker's Party of Bludia. They should be declared a national security threat and the party should be banned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`
  - -> `[505]`
  - -> `[506]`

### Węzeł `[501]`
Mówca: **Orso Hawker**
> ""Red Youth must also be our target. They are plotting a communist revolution in Sordland with clear funding from United Contana. And now they took to the streets after the death of Bernard Circas. There are already clashes and protests on the streets which must be dealt with before it gets out of hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[502]`
Mówca: **Orso Hawker**
> ""You can also justify an action against the Young Sords. After all, they started all this mess with the commies, *and* they killed a man right near the Maroon Palace. That can be considered a declaration of war against the state itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[483]`
  - -> `[510]`
  - -> `[511]`

### Węzeł `[503]`
**[WYBÓR GRACZA: ""These Blud separatists have no place in Sordland. They will not be tolerated.""]** — Mówca: **Player**
> ""These Blud separatists have no place in Sordland. They will not be tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[504]`
**[WYBÓR GRACZA: ""They will be our targets.""]** — Mówca: **Player**
> ""They will be our targets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[505]`
**[WYBÓR GRACZA: ""I don't want to create problems with our Bludish citizens.""]** — Mówca: **Player**
> ""I don't want to create problems with our Bludish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
**[WYBÓR GRACZA: ""There is not enough evidence to connect the separatists with the Worker's party.""]** — Mówca: **Player**
> ""There is not enough evidence to connect the separatists with the Worker's party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[507]`
Mówca: **Orso Hawker**
> ""But they are already creating problems for us. Most Bluds in Bergia are either ballsy enough to show their support for the separatists or they vote for the Worker's Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Orso Hawker**
> ""But let's not forget about the socialists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[509]`
Mówca: **Orso Hawker**
> ""Come on, Mr. President. We all know what they stand for. Bluds will be Bluds. They all want to establish their own country in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[510]`
**[WYBÓR GRACZA: ""Both organizations must be declared as national threats.""]** — Mówca: **Player**
> ""Both organizations must be declared as national threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[511]`
**[WYBÓR GRACZA: ""I need to think about this.""]** — Mówca: **Player**
> ""I need to think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[512]`
Mówca: **Orso Hawker**
> ""They are an enemy of the state. The state must react.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[513]`
Mówca: **Orso Hawker**
> ""They are both enemies of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Orso Hawker**
> ""I don't think there is much to think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Orso Hawker**
> ""But let's talk about how we can deal with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[516]`
**[WYBÓR GRACZA: ""Sorry to interrupt, Mr. Hawker, but I won't be going ahead with this.""]** — Mówca: **Player**
> ""Sorry to interrupt, Mr. Hawker, but I won't be going ahead with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Orso Hawker**
> ""I thought you wanted to plan our move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[519]`
  - -> `[520]`

### Węzeł `[518]`
**[WYBÓR GRACZA: ""I just wanted to hear your plan. And now I've heard it.""]** — Mówca: **Player**
> ""I just wanted to hear your plan. And now I've heard it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
**[WYBÓR GRACZA: ""I cannot do this, Mr. Hawker.""]** — Mówca: **Player**
> ""I cannot do this, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[520]`
**[WYBÓR GRACZA: ""I thought I wanted to. Instead I will be proceeding with the reforms.""]** — Mówca: **Player**
> ""I thought I wanted to. Instead I will be proceeding with the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[521]`
Mówca: **Orso Hawker**
> ""What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Orso Hawker**
> ""You will instead push on with your reforms then? It seems you are also part of the conspiracy, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`
  - -> `[623]`

### Węzeł `[523]`
Mówca: **Orso Hawker**
> ""Is this all a joke to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[524]`
Mówca: **Orso Hawker**
> ""It seems you are also part of the conspiracy, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`
  - -> `[623]`

### Węzeł `[525]`
Mówca: **Orso Hawker**
> ""We should eliminate the threats on our streets first. The police should have the authority to disperse crowds as necessary. We also have to keep the streets clean from the socialist thugs and Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[526]`
Mówca: **Orso Hawker**
> ""We should give more authority to the police regarding their use of force. They should be able to stop and frisk as necessary, especially in Bludish neighbourhoods.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`
  - -> `[530]`

### Węzeł `[527]`
Mówca: **Orso Hawker**
> ""The police will also need permissions for increased surveillance against these organizations. They should be able to search properties without warrants, and wiretapping should be permissible beyond its current limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[528]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[529]`
**[WYBÓR GRACZA: ""We should suspend the right to protest and disperse the crowds.""]** — Mówca: **Player**
> ""We should suspend the right to protest and disperse the crowds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[530]`
**[WYBÓR GRACZA: ""The police should stop and frisk based on suspicion.""]** — Mówca: **Player**
> ""The police should stop and frisk based on suspicion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[531]`
Mówca: **Orso Hawker**
> ""They will also need to be able to act swiftly. If a person is suspected of crimes against the national security of Sordland, the police should be able to detain them without trial. We cannot allow them proper trials anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[532]`
  - -> `[534]`

### Węzeł `[532]`
**[WYBÓR GRACZA: ""I agree.""]** — Mówca: **Player**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[533]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[534]`
**[WYBÓR GRACZA: ""I think detention without trial is too much.""]** — Mówca: **Player**
> ""I think detention without trial is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Orso Hawker**
> ""We are fighting against national security threats here. These are terrorists. We need extreme measures in extreme situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Orso Hawker**
> ""There are also the external threats we must face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Orso Hawker**
> ""And there are also the external threats we must face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Orso Hawker**
> ""Rumburg has acted hostile in the past and now they are arming the Bluds. We must cut all ties with them. They need to be embargoed, their citizens must barred from entering Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Orso Hawker**
> ""We must erase all of their influence in Sordland, weaken their trade and give them a message.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
**[WYBÓR GRACZA: ""Rumburg is our biggest enemy, we must react.""]** — Mówca: **Player**
> ""Rumburg is our biggest enemy, we must react.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[541]`
**[WYBÓR GRACZA: ""We shouldn't escalate the situation with Rumburg too fast.""]** — Mówca: **Player**
> ""We shouldn't escalate the situation with Rumburg too fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Orso Hawker**
> ""They are the ones who are spitting on us! They already escalated the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Orso Hawker**
> ""And of course, we need to prepare our army in any case. They have a very powerful military, and they seem to have plans on our soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Orso Hawker**
> ""Then there are the superpowers. Both are influencing our nation to be in their spheres. It seems Arcasia already bought Mr. Ricter and possibly is behind all of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[545]`
Mówca: **Orso Hawker**
> ""And United Contana is funding Sordish communists against our state. But we cannot bow down to the superpowers. Sordland must stand tall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
**[WYBÓR GRACZA: ""We can't go against the superpowers.""]** — Mówca: **Player**
> ""We can't go against the superpowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[547]`
**[WYBÓR GRACZA: ""We will not bow to them, Mr. Hawker.""]** — Mówca: **Player**
> ""We will not bow to them, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Orso Hawker**
> ""I know it is a serious issue. But their actions against our country is obvious. We simply cannot allow them to manipulate us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[549]`
Mówca: **Orso Hawker**
> ""I know we won't. They tried to divide Sordland before, but we came out stronger after the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[550]`

### Węzeł `[550]`
**[WYBÓR GRACZA: ""I salute Colonel Soll for that.""]** — Mówca: **Player**
> ""I salute Colonel Soll for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[551]`
**[WYBÓR GRACZA: ""We will come out of this stronger again.""]** — Mówca: **Player**
> ""We will come out of this stronger again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[552]`
**[WYBÓR GRACZA: ""I agree, but we cannot afford to sever all of our ties with them.""]** — Mówca: **Player**
> ""I agree, but we cannot afford to sever all of our ties with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[553]`
**[WYBÓR GRACZA: ""We might need one of their support against the other.""]** — Mówca: **Player**
> ""We might need one of their support against the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Orso Hawker**
> ""Getting their support means becoming their pawns, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[555]`
Mówca: **Orso Hawker**
> ""You should think about it further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[556]`
Mówca: **Orso Hawker**
> ""May God preserve his soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Orso Hawker**
> ""I do hope so, Mr. President. It will all be up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Narrator**
> "Orso looked at the clock in the office, and then outside the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Orso Hawker**
> ""Mr. President, I have taken too much of your time already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Orso Hawker**
> ""I will be reaching out again after you dissolve the reform committee and end the pursuits for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`
  - -> `[562]`

### Węzeł `[561]`
**[WYBÓR GRACZA: ""I will stop the reforms shortly. [Proceed with the deal]""]** — Mówca: **Player**
> ""I will stop the reforms shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[562]`
**[WYBÓR GRACZA: ""I cannot promise you that, Mr. Hawker. We do not have a deal. [Proceed with reforms]""]** — Mówca: **Player**
> ""I cannot promise you that, Mr. Hawker. We do not have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[563]`
Mówca: **Orso Hawker**
> ""Was this all a joke to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
**[WYBÓR GRACZA: ""No, Mr. Hawker. I just wanted to learn about your intentions.""]** — Mówca: **Player**
> ""No, Mr. Hawker. I just wanted to learn about your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[565]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Hawker. But I won't be doing this.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Hawker. But I won't be doing this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[566]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Narrator**
> "He looked at me with anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[568]`
Mówca: **Orso Hawker**
> ""Good luck with your reforms, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[569]`
Mówca: **Orso Hawker**
> ""You made a big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Narrator**
> "He quickly got off the couch and moved towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
**[WYBÓR GRACZA: ""Goodbye, Mr. Hawker.""]** — Mówca: **Player**
> ""Goodbye, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[572]`
**[WYBÓR GRACZA: ""Don't walk out on me, Mr. Hawker.""]** — Mówca: **Player**
> ""Don't walk out on me, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[573]`
Mówca: **Orso Hawker**
> ""You already did that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[574]`
Mówca: **Orso Hawker**
> ""Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[575]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[576]`
Mówca: **Orso Hawker**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[577]`
Mówca: **Narrator**
> "He slowly got up from the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Orso Hawker**
> ""It was great talking to you. And I am looking forward to our cooperation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Orso Hawker**
> ""Have a good evening, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`
  - -> `[582]`

### Węzeł `[580]`
Mówca: **Narrator**
> "We shook hands on our deal. This also meant that I made an unholy alliance with the Old Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[581]`
**[WYBÓR GRACZA: ""Good evening, Mr. Hawker.""]** — Mówca: **Player**
> ""Good evening, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[582]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[583]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[584]`
Mówca: **Narrator**
> "After he left, I called in Lucian and explained to him about my decision to stop the reforms and called Petr to dissolve the committee on the next day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[585]`
Mówca: **Narrator**
> "This was a point of no return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[586]`
Mówca: **Heron Garaci**
> ""Suit yourself, Mr. President. Play into the hands of Sordland's enemies. There will be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[587]`
Mówca: **Orso Hawker**
> ""Mr. President clearly doesn't want to talk to us. Let's just give him some room before he disrespects the judiciary further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[588]`
Mówca: **Narrator**
> "Orso and Heron both stood up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[589]`
Mówca: **Orso Hawker**
> ""Please excuse us, Mr. President. Sorry to have taken up your valuable time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`
  - -> `[591]`
  - -> `[592]`

### Węzeł `[590]`
**[WYBÓR GRACZA: ""Take care, gentlemen.""]** — Mówca: **Player**
> ""Take care, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[591]`
**[WYBÓR GRACZA: ""I expect your support for the reforms. Don't make a mistake.""]** — Mówca: **Player**
> ""I expect your support for the reforms. Don't make a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[592]`
**[WYBÓR GRACZA: ""Goodbye Chief Justice.""]** — Mówca: **Player**
> ""Goodbye Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[593]`
Mówca: **Orso Hawker**
> ""But of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[594]`
Mówca: **Narrator**
> "Orso laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[595]`
Mówca: **Narrator**
> "They both left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[596]`
Mówca: **Heron Garaci**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[597]`
Mówca: **Narrator**
> "Orso and Heron both stood up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[598]`
Mówca: **Heron Garaci**
> ""Suit yourself, Mr. President. Play into the hands of Sordland's enemies. There will be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[599]`
Mówca: **Narrator**
> "They both left the room without saying anything else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[600]`
Mówca: **Orso Hawker**
> ""Mr. President clearly doesn't want to talk to us. Let's just give him some room before he disrespects the judiciary further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[601]`
Mówca: **Narrator**
> "Orso laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[602]`
**[WYBÓR GRACZA: ""Goodbye Chief Justice.""]** — Mówca: **Player**
> ""Goodbye Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[603]`
Mówca: **Orso Hawker**
> ""Please excuse us, Mr. President. Sorry to have taken your valuable time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[607]`
  - -> `[602]`

### Węzeł `[604]`
Mówca: **Orso Hawker**
> ""But of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[605]`
**[WYBÓR GRACZA: ""Take care, gentlemen.""]** — Mówca: **Player**
> ""Take care, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[606]`
Mówca: **Heron Garaci**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[607]`
**[WYBÓR GRACZA: ""I expect your support for the reforms. Don't make a mistake.""]** — Mówca: **Player**
> ""I expect your support for the reforms. Don't make a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[608]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: EarlyExit)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[609]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Jump to: [EarlyExit])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[610]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: Jump to: [EarlyExit])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[611]`
Mówca: **Lucian Galade**
> ""That was not good. They clearly tried to threaten you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[613]`
  - -> `[614]`
  - -> `[616]`

### Węzeł `[612]`
**[WYBÓR GRACZA: ""We need to take care of them.""]** — Mówca: **Player**
> ""We need to take care of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[613]`
**[WYBÓR GRACZA: ""We have to make sure our reforms will pass the Court.""]** — Mówca: **Player**
> ""We have to make sure our reforms will pass the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[614]`
**[WYBÓR GRACZA: ""How dare they talk to me like that?""]** — Mówca: **Player**
> ""How dare they talk to me like that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[615]`
Mówca: **Lucian Galade**
> ""Orso will be doing whatever it takes to damage you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[616]`
**[WYBÓR GRACZA: ""I'm not scared of them.""]** — Mówca: **Player**
> ""I'm not scared of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[617]`
Mówca: **Lucian Galade**
> ""We need to be careful. There are still many Old Guard sympathizers in our party. We can't let them divide our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
Mówca: **Lucian Galade**
> ""And he will definitely try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[619]`
Mówca: **Narrator**
> "After a short evaluation of the situation on our hands, Lucian left me in the presidential office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[620]`
Mówca: **Narrator**
> "It was obvious that the Old Guards would be my main rivals in the near future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[621]`
**[WYBÓR GRACZA: ""There is no conspiracy but yours, Mr. Hawker.""]** — Mówca: **Player**
> ""There is no conspiracy but yours, Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[622]`
**[WYBÓR GRACZA: ""I think we should end the meeting before we offend each other.""]** — Mówca: **Player**
> ""I think we should end the meeting before we offend each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[623]`
**[WYBÓR GRACZA: ""I need to push the reforms, Mr. Hawker, and I will.""]** — Mówca: **Player**
> ""I need to push the reforms, Mr. Hawker, and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Orso Hawker**
> ""Good God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[625]`
Mówca: **Orso Hawker**
> ""I hope Sordland's future is not bleak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[626]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[627]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_A_AutocratBriefing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_A_AutocratBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[628]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[630]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Abandon = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Abandon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[632]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[634]`

### Węzeł `[633]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[634]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[635]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reformist_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Dictator_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[637]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_LateBriefing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[638]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_OrsoSeenInPalace = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_OrsoSeenInPalace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[639]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[640]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[641]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_ReformCommittee = false; BaseGame.Reform_Reformist_Intention = false; BaseGame.Reform_Dictator_Intention = false; BaseGame.Reform_Autocrat_Intention = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_ReformCommittee"] = false;
Variable["BaseGame.Reform_Reformist_Intention"] = false;
Variable["BaseGame.Reform_Dictator_Intention"] = false;
Variable["BaseGame.Reform_Autocrat_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[642]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[643]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true;
BaseGameSupport.News_Turn02_G_IyotakePlanMixed = true;
BaseGameSupport.News_Turn02_E_REEPotential = true;
BaseGameSupport.News_Turn02_R_GasomJobsRisk = true;
BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter = true;
BaseGameSupport.Report_Turn02_Morbel_NaturePreservation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_MangerRevealsPlan"] = true;
Variable["BaseGameSupport.News_Turn02_G_IyotakePlanMixed"] = true;
Variable["BaseGameSupport.News_Turn02_E_REEPotential"] = true;
Variable["BaseGameSupport.News_Turn02_R_GasomJobsRisk"] = true;
Variable["BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter"] = true;
Variable["BaseGameSupport.Report_Turn02_Morbel_NaturePreservation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, thank you, Lucian. You can go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian isn't going anywhere. This meeting is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
