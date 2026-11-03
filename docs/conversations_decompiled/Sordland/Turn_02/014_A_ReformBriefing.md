# Sordland/Turn02/A_ReformBriefing

- **ID konwersacji:** `14`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/014_A_ReformBriefing.md`
- **Liczba węzłów dialogowych:** 150
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_Consulate_Retaliate`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Autocrat_SetUpMeeting`
- `BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure`
- `BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm`
- `BaseGameSupport.News_Turn02_E_REEPotential`
- `BaseGameSupport.News_Turn02_G_IyotakePlanMixed`
- `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan`
- `BaseGameSupport.News_Turn02_R_GasomJobsRisk`
- `BaseGameSupport.News_Turn02_R_WPBElectoralProtests`
- `BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential`
- `BaseGameSupport.Report_Turn02_Holsord_L1_SSC`
- `BaseGameSupport.Report_Turn02_Holsord_L1_Taurus`
- `BaseGameSupport.Report_Turn02_Holsord_L1_Underhall`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_SSC`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall`
- `BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter`
- `BaseGameSupport.Report_Turn02_Morbel_NaturePreservation`
- `GameCondition.Turn02_A_ReformBriefing`

### Skoki między-konwersacyjne:
- Węzeł `[57]` -> **[16] Sordland/Turn02/AutocratSection** (../Turn_02/016_AutocratSection.md), Węzeł `[1]`
- Węzeł `[58]` -> **[15] Sordland/Turn02/DictatorSection** (../Turn_02/015_DictatorSection.md), Węzeł `[1]`
- Węzeł `[147]` -> **[17] Sordland/Turn02/ReformistSection** (../Turn_02/017_ReformistSection.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 13

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Lucian Galade): `Variable["GameCondition.Turn02_A_ReformBriefing"] = true;`
- Węzeł `[109]` (Lucian Galade): `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] = true;`
- Węzeł `[128]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_SSC"] = true;`
- Węzeł `[129]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall"] = true;`
- Węzeł `[130]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus"] = true;`
- Węzeł `[131]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_SSC"] = true;`
- Węzeł `[132]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Underhall"] = true;`
- Węzeł `[133]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Taurus"] = true;`
- *...oraz 5 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_A_ReformBriefing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_A_ReformBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[7]`
Mówca: **Nia Morgna**
> ""Mr. President, I've heard from Mr. Galade that you're not intending to support the democratic reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""There is a lot to talk about the future of this process. Let us begin to tackle the points of contention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The reforms were slowly becoming the most significant expectation of my government. We would be changing Soll's Constitution of '29."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I came a little early to the meeting room before anybody showed up. We had scheduled a meeting to discuss the progress of the reform committee regarding the new Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Most people nowadays blamed the constitution for the outstanding problems of the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "On the other hand, the reformists in the Assembly had been getting louder about their demands. What I knew for sure was that I needed to do something about this encroaching chaos before it swallowed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Meanwhile, Lucian, Petr and Nia had been leading the committee to prepare an initial draft for the constitutional amendments. I was intrigued to hear their results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "There was a knock on the door. It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Good afternoon, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Lucian arrived exactly on the hour mark again. His punctuality could almost be described as obsessive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you waiting behind the door to come at the exact right second?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Good afternoon, Lucian.""]** — Mówca: **Player**
> ""Good afternoon, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> ""I'm sorry, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Forget it. How are you, today?""]** — Mówca: **Player**
> ""Forget it. How are you, today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""You seem to be arriving at the exact second all our meetings start.""]** — Mówca: **Player**
> ""You seem to be arriving at the exact second all our meetings start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Punctuality is important for me, sir. I'm just doing my job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'm good, Mr. President. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""We should begin the meeting as soon as Mrs. Morgna and Vice President Vectern arrive. We finally have some results from the reform committee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He took a seat on the table and took out a bunch of documents, spreading them on the long table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""How does it look?""]** — Mówca: **Player**
> ""How does it look?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""What results?""]** — Mówca: **Player**
> ""What results?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Good.""]** — Mówca: **Player**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Well, the situation is quite complicated. But I'm sure we will make it work, just like we accomplished many things before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""The reform committee already drafted the amendments for the new Constitution thanks to the help of the members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""But the situation is still quite complicated politically. We'll go over the details in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""We'll go over the details regarding the new constitution in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "A few minutes later, Petr and Nia also arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "After a short chat, everybody sat down and took out their notes. I knew it was going to be a long meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Our committee meetings have been really fruitful, and we already started on the constitutional draft together with the feedback from all the political parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Nia Morgna**
> ""We are making clear progress here. You wouldn't really block our hard work, would you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[39]`
  - -> `[44]`
  - -> `[41]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Mr. President, our committee meetings were really fruitful, and we already started working on the constitutional draft together with the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Nia Morgna**
> ""They demanded a little too much, but we've had success with Frens Ricter to create a realistic draft that could potentially go through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What's that supposed to mean?""]** — Mówca: **Player**
> ""What's that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I've already explained my intentions.""]** — Mówca: **Player**
> ""I've already explained my intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""A final decision hasn't been made yet.""]** — Mówca: **Player**
> ""A final decision hasn't been made yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""A *little*? They demanded to rewrite the whole Constitution!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""I also didn't like their theatrics but the requests were definitely not outrageous. They were just not realistic in today's political circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I would.""]** — Mówca: **Player**
> ""I would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[45]`
Mówca: **Nia Morgna**
> ""This is our once in a lifetime chance to change the Constitution of Tarquin Soll, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Speech_Democracy_Liberal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Speech_Democracy_Liberal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""You campaigned to bring real democracy to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""We worked hard to create a draft together with the leaders of our party and the opposition. Nothing else is more important for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""With all due respect, you should hold that promise you made to the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""With all due respect, I'll be the judge of that.""]** — Mówca: **Player**
> ""With all due respect, I'll be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Thanks for the advice, Mrs. Morgna.""]** — Mówca: **Player**
> ""Thanks for the advice, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'll see what we can do.""]** — Mówca: **Player**
> ""I'll see what we can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""If I may continue, Mr. President. We've discussed the possibilities of your intentions with Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `16` (*Sordland/Turn02/AutocratSection*), Węzeł `[1]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `15` (*Sordland/Turn02/DictatorSection*), Węzeł `[1]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Petr cut in before Nia could speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
Mówca: **Narrator**
> "She leaned slightly towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[61]`
Mówca: **Narrator**
> "I took a seat on the centre chair in the vacant meeting room as I waited for them to show up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`
  - -> `[79]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""But now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""I'll present your input to the USP leaders and the National Front. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir. I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""If we do this, I promise, you will be kings.""]** — Mówca: **Player**
> ""If we do this, I promise, you will be kings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Together we will make Sordland great.""]** — Mówca: **Player**
> ""Together we will make Sordland great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Thanks for the meeting, gentlemen.""]** — Mówca: **Player**
> ""Thanks for the meeting, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""Yes we will!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""I'm sure you will lead us to greatness, sir. Thanks for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""If we do this, we will be remembered as heroes.""]** — Mówca: **Player**
> ""If we do this, we will be remembered as heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Together we will democratize Sordland.""]** — Mówca: **Player**
> ""Together we will democratize Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Thanks for the meeting, everybody.""]** — Mówca: **Player**
> ""Thanks for the meeting, everybody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""And you have my full support, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Yes! The Heroes of Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
Mówca: **Nia Morgna**
> ""You have my support, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Yes, sir. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Petr Vectern**
> ""Ours too, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[96]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""So, sir, are we scheduling a meeting with Chief Justice Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Yes. Set up a meeting with Orso Hawker. We need the Old Guards.""]** — Mówca: **Player**
> ""Yes. Set up a meeting with Orso Hawker. We need the Old Guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""No. Let him come to me. I am sure he will come begging.""]** — Mówca: **Player**
> ""No. Let him come to me. I am sure he will come begging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> ""Yes... sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""We will keep the reform committee working in the meantime so that it doesn't look like we are completely shutting everything down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Yes, that's important. If we can't cooperate with the Old Guards, we could always return to the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I think we should get to work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucian grabbed his notes and carefully placed them in his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""Yes. Thanks for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_SetUpMeeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Lachaven_H3_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Holsord_L1_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Holsord_L1_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Holsord_L1_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Retaliate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Retaliate == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_Consulate_Retaliate == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure = true; BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_WPBElectoralProtests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_WPBElectoralProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[146]`
Mówca: **Petr Vectern**
> ""Mr. Ricter's deputy even suggested removing the term 'Sord' from the constitution completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[147]`
Mówca: **Nia Morgna**
> ""Nonetheless, Mr. Vice President, thanks for your convincing arguments we seem to have reached a common ground already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `17` (*Sordland/Turn02/ReformistSection*), Węzeł `[1]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
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
  - -> `[148]`
