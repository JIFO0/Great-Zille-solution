# Sordland/Turn06/VictoryDay_NonAutocratPath/VictoryDay_NonAutocratPath Conversation

- **ID konwersacji:** `538`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/538_VictoryDay_NonAutocratPath_Conversation.md`
- **Liczba węzłów dialogowych:** 586
- **Liczba wyborów gracza:** 112

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[16]** Manoly Suheil
- **[32]** Frens Ricter
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSpecialZone_Proposal_Amendment`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Relations_Kesaro_Promise_Bill`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4`
- `BaseGameIsolated.VictoryDay_ChoiceHub_Nothing`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4`
- `BaseGameIsolated.VictoryDay_Hub_Option1`
- `BaseGameIsolated.VictoryDay_Hub_Option2`
- `BaseGameIsolated.VictoryDay_Hub_Option3`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Sollist`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4`
- `BaseGameIsolated.VictoryDay_Hub_Option1`
- `BaseGameIsolated.VictoryDay_Hub_Option2`
- `BaseGameIsolated.VictoryDay_Hub_Option3`
- `BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport`
- `BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen`
- `BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[90] Sordland/Turn06/A_VictoryDayBludishMeeting** (../Turn_06/090_A_VictoryDayBludishMeeting.md), Węzeł `[59]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 19
- **Węzły modyfikujące stan gry:** 16

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[323]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] = true;`
- Węzeł `[324]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] = true;`
- Węzeł `[330]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] = true;`
- Węzeł `[331]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] = true;`
- Węzeł `[345]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] = true;`
- Węzeł `[346]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] = true;`
- Węzeł `[375]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] = true;`
- Węzeł `[388]` (Paskal Beniwoll): `Variable["BaseGame.ErsenCase_Statement_ProBlud"] = true; Variable["BaseGameSupport.Journal_Turn06...`
- *...oraz 8 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `90` (*Sordland/Turn06/A_VictoryDayBludishMeeting*), Węzeł `[59]`

### Węzeł `[3]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here on this glorious day, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The comically large amount of flags almost fully enveloped the buildings around the plaza in maroon, white and gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "At the entrance, Kesaro Kibener, the head of the National Front Party, was waiting for us in his iconic brown suit, watching the sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[6]`
Mówca: **Kesaro Kibener**
> ""As the former mayor of Jen, it is an honor to welcome you to this fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like you were a good mayor. Maybe you should think about running for local office again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Shake his hand in silence."]** — Mówca: **Player_Italic**
> "I did not reply and simply shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Kesaro Kibener**
> ""Thanks for the kind words, but I'm sure I'll do an even better job as president. Besides, as you can see, our current mayor doesn't need my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Thank you for organizing this, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Kesaro Kibener**
> ""The representatives of the PFJP and Minister Morgna are already inside the private meeting room. Hopefully we'll be finished before the festivities start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Kesaro gestured at the doors behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Kesaro Kibener**
> ""Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[20]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... Is everything ready within your party? You know the vote is approaching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... Is there a way to get you back on the table regarding the constitutional changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[27]`
Mówca: **Kesaro Kibener**
> ""I am aware, Mr. President. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Bill == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""The NFP will support the proposal if you hold up your end of your bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""The NFP will support the proposal if you don't bring us new surprises at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[33]`
Mówca: **Kesaro Kibener**
> ""I'm afraid not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... is there any way we can discuss how you can help us with the constitutional changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Besides, this is neither the time nor place to have such a conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're making a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""Come now, Mr. President. There is no need for such talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[43]`
Mówca: **Kesaro Kibener**
> ""Just follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Kesaro Kibener**
> ""But let's just go inside now. Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "We entered the building and walked through a massive conference hall until we approached a door towards the back of the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Kesaro opened the doors for us and we entered the meeting room. PFJP leader Frens Ricter and his deputy Manoly Suheil was already seated at the left side of the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Kesaro Kibener**
> ""We'll have the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
Mówca: **Narrator**
> "As soon as we entered, Nia came to greet us. After showing our seats, Kesaro sat down next to his deputy, Remus Holstron."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""This is such a meaningful day. Thank you for coming here on behalf of your parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""But despite the festive atmosphere, we and the PFJP want to raise a few important concerns about the worrying state of affairs in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Manoly Suheil**
> ""I'm sorry to interrupt, but the analysis is about racism and radicalization in Sordland. And our main topic is the case of 'Ersen v. Sordland'. Please don't try to spin it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Kesaro stopped for a moment to check his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[53]`
Mówca: **Remus Holstron**
> ""Mr. Ricter and his analysts have been working on an analysis of the Blud problem. As soon as they brought it up, we gave our support without reservations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Look at this guy. So full of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""How did this clown convince the PFJP to have trilateral talks with them anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, it says more about Frens and the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Probably the same reason why we're here. It's Victory Day, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's a dangerously competent man, Petr. We should be cautious with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Try not to agitate him, Petr. Don't forget, he's our partner for now and we need his vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""How can I forget? Lucian nagged about the importance of the day for 20 minutes straight. It broke my soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""I don't trust them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Seeing us arrive, Kesaro approached us with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[68]`
Mówca: **Kesaro Kibener**
> ""Mr. Hol-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[69]`
Mówca: **Kesaro Kibener**
> ""Of course, Ms. Suheil. Mr. Holstron just wanted to point out that this analysis was focused mainly on topics related to the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[90]`
  - -> `[82]`

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""I want to give the word to Mr. Ricter to explain the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Frens Ricter**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He gestured at Frens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""Our analysis of the current tensions between the Bludish and Sordish population in Sordland displays a worrying picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[74]`
Mówca: **Frens Ricter**
> ""The increasingly discriminatory actions of the Governor of Bergia are resulting in the radicalization of many young Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are we discussing this on Victory Day?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I refuse to discuss this topic without any Bludish representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[83]`
Mówca: **Remus Holstron**
> ""Very worrying, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[84]`
Mówca: **Remus Holstron**
> ""It seemed fitting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`
  - -> `[460]`

### Węzeł `[85]`
Mówca: **Kesaro Kibener**
> ""Let's get back on track, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[86]`
Mówca: **Frens Ricter**
> ""Distressingly, it exploded out of control after the presidency gave support to Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
Mówca: **Frens Ricter**
> ""Distressingly, the number of radicals have almost doubled after the implication of our armed forces in the Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
Mówca: **Frens Ricter**
> ""Distressingly, the number of radicals have increased significantly after Wehlen's Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""Unfortunately, the NFP's Religious Harmony Bill was also signed into law despite our protests. Which did nothing to ease the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm surprised that your parties have conducted a joint analysis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Manoly Suheil**
> ""We thank the NFP for assisting our research, of course. But this is by no means a joint analysis. Our parties have vastly different opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`
  - -> `[460]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Kesaro Kibener**
> ""That bill targets the secessionist propaganda apparatus. I must point out that the recruitment numbers of the BFF have significantly reduced since the law's implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[96]`
Mówca: **Kesaro Kibener**
> ""As the threat the BFF poses is a direct one, this issue requires direct actions that lead to direct results -- which seem to be proving successful as fact-checked by the Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`
  - -> `[102]`

### Węzeł `[97]`
Mówca: **Kesaro Kibener**
> ""I must also point out that the recruitment numbers of the BFF have significantly increased within Nurist communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[98]`
Mówca: **Kesaro Kibener**
> ""The Religious Harmony Bill would have directly crippled this network they established within our sanctuaries. As the threat the BFF poses is a direct one, this issue requires direct actions that would bear direct results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""As much as I hate to say it, the threat of the Bludish Freedom Front is getting real again. The situation with Rumburg and Wehlen is very concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that the new laws are working.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm regretting my decision to sign that bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any suggestions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[103]`
Mówca: **Kesaro Kibener**
> ""I'm disappointed by the lack of action taken by the USP administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[106]`
  - -> `[183]`
  - -> `[105]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bill would have unnecessarily raised the already high tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what do you suggest we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm regretting my decision to veto that bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Remus Holstron**
> ""We can still right our wrongs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Manoly Suheil**
> ""You did well by vetoing it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Remus Holstron**
> ""They are working, but it is not enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Manoly Suheil**
> ""You should have controlled your party before they gave support to that bill in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Bill == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Our suggestion is to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""One of my suggestions to you was to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Kesaro Kibener**
> ""Of course, you have already promised to support it, so we are already aligned on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""We are working on the Unified Language Act. It is directly aimed at the breeding grounds of the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[118]`
Mówca: **Nia Morgna**
> ""You can't take away the Bludish people's right to be educated in their own language. This is insane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""Please read the proposal carefully. It does not take away anyone's rights. It only gives the state a way to control the radicalization in these schools that teach Bludish nationalist propaganda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""True. It does not ban Bludish language or Bludish education. It will instead make Sordish mandatory to learn for everyone living in this country. This will only decrease the tensions in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Frens Ricter**
> ""That's a fair point. However, the wording of the bill is far too vague to work as intended. It gives the government too much power over educational institutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""I disagree. The language is quite clear and is in line with the Constitution. But we can still improve it, of course. It is true that it gives more control, but it is a necessary compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[129]`
  - -> `[130]`
  - -> `[133]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As I've promised before, I'll sign the bill when it reaches me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Manoly looked furious. She opened her mouth to respond, then read the room and closed it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Bill == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll sign the bill if it reaches me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll have to read it in detail to decide if I can support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't see how this helps with the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[131]`
Mówca: **Remus Holstron**
> ""The police have infiltrated 32 BFF training grounds in remote towns around Bergia that posed as middle schools. Despite all the evidence, similar schools keep popping up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Remus Holstron**
> ""And so-called activists are constantly blocking Governor Bron's attempts to stop these schools, claiming he is attacking their *right to language*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even if the Assembly supports it, I will surely be using my veto on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Is that so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Bill == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""Then you'll see what happens with your constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
Mówca: **Kesaro Kibener**
> ""I wouldn't be so quick, if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""The NFP would surely expect a gesture before the *big* vote, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Manoly Suheil**
> ""It doesn't. It's simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Manoly Suheil**
> ""The PFJP will not allow this bill to pass the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Frens Ricter**
> ""Let's not make statements that the party hasn't agreed on yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[147]`
Mówca: **Kesaro Kibener**
> ""If I were you, I wouldn't stand in the way of the majority, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""Hold up, guys. Let's hear them out first. We are representing the parties of the Assembly here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[149]`
Mówca: **Petr Vectern**
> ""That seems to be correct. The reports show that the new laws definitely struck a blow to the BFF's religious wing and their recruitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Petr frantically looked through his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""That is correct. The reports show that 39 Nurist sanctuaries in Bergia are now classified as 'red threats' by the authorities. Many priests in the region are also suspected of having ties to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Petr frantically looked through his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Frens Ricter**
> ""If I may continue with our analysis...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Frens Ricter**
> ""The situation is also connected to Rumburg, as everybody already knows. In the case of a future incursion, BFF forces in Sordland could become an existential threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[160]`
  - -> `[464]`
  - -> `[161]`

### Węzeł `[155]`
Mówca: **Frens Ricter**
> ""As much I now support a strict response against the BFF, it must also be coupled with the expansion of rights for the Bludish people. This is the only way to fight against radicalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Remus Holstron**
> ""That is BFF propaganda. What rights are we talking about here? What can a Sord in Sordland do that a Blud cannot?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Remus Holstron**
> ""You are using soft language as a cover-up for your willingness to negotiate with terrorists. You are a BFF apologist, Mr. Ricter!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""Let's refrain from making comments about the internal affairs of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's why we have to remove the authority of the governor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect, I already received this information from Internal Affairs. Tell us something we don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe the NFP influences you more than you think, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Narrator**
> "He adjusted his tie and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Frens Ricter**
> ""Just let me finish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Frens Ricter**
> ""Our analysis matches with what the Ministry of Interior shared with us. But despite this fact, we believe the ministry is hiding information from us, which is actively fuelling the tensions behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""Please don't raise your voice, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[166]`
Mówca: **Remus Holstron**
> ""Is the USP that desperate for Mr. Ricter's support now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Remus Holstron**
> ""I didn't know you were Mr. Ricter's lawyer, Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Remus shouted the last sentence. Petr tapped on the table to get his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Manoly bellowed out a loud laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""From now on, nobody speaks until the speaker finishes their point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[174]`
Mówca: **Petr Vectern**
> ""What is that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[177]`
  - -> `[181]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Everybody went silent and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[177]`
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Narrator**
> "Manoly bellowed out a loud laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can we return to the topic?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[178]`
Mówca: **Narrator**
> "The mood in the room had turned sour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[179]`
Mówca: **Manoly Suheil**
> ""Mr. Vectern is the last person to sway the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a mess. I thought we were here for a proper meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Manoly Suheil**
> ""Mr. Vectern is the last person that we'd rely on to defend us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bill would have made everything worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Kesaro and Petr nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Kesaro Kibener**
> ""You heard the man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Kesaro Kibener**
> ""Please finish your point, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Manoly Suheil**
> ""Mr. President. Mr. Vice President. And Ms. Minister. As you already know, there is a major Supreme Court case at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Frens Ricter**
> ""We require your support with a more pressing matter. This might have very significant consequences for our Bludish citizens and may serve as a dangerous trigger if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Frens gestured at Manoly. She carefully placed several pieces of paper in front of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
Mówca: **Manoly Suheil**
> ""Ishval Ersen is suing the Governor of Bergia, Phelix Bron, for infringing upon the liberties of Bludish people and demands that the constitution be revised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Manoly Suheil**
> ""Because of the argument and the implications, Phelix Bron and, consequently, the very constitution of Sordland is under trial. The fact is, he needs to be punished and the Constitution must be reviewed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[429]`
  - -> `[430]`

### Węzeł `[192]`
Mówca: **Remus Holstron**
> ""With all due respect, Mr. Kibener, this bill is not strong enough. The Bludish language should be completely banned. You know people like Ms. Suheil or Ms. Morgna will never even vote for your watered-down bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[193]`
Mówca: **Nia Morgna**
> ""I was actively involved in this case. Because of the implications with the constitution, there is no way the Supreme Court will agree with Ishval Ersen on all of the points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Nia raised her hand and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[195]`
Mówca: **Frens Ricter**
> ""Not if all three parties of the Assembly support Ersen together. We can put pressure on them. And we only need them to agree on a few of those points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`
  - -> `[208]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's the significance of this case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ErsenQuestions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[576]`
  - -> `[579]`

### Węzeł `[198]`
Mówca: **Narrator**
> "Kesaro repositioned himself on his chair and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[199]`
Mówca: **Kesaro Kibener**
> ""For peace and harmony in Sordland, yes. But perhaps we must clarify the details first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[200]`
Mówca: **Frens Ricter**
> ""This never happened before, Mr. President. They surely cannot ignore us if all three parties are united and if we provide them with our analyses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[201]`
Mówca: **Frens Ricter**
> ""What do you want to know, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[202]`
Mówca: **Kesaro Kibener**
> ""Remus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[203]`
Mówca: **Frens Ricter**
> ""We did invite the representatives of the Workers Party of Bludia to join us, but they refused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Remus Holstron**
> ""Another proof that they have a different agenda. If they were genuinely concerned for the plight of their people, they would have come today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Remus Holstron**
> ""But their people shouldn't worry. The Sordish patriots are here to defend them instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`
  - -> `[460]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And why do you think it would influence the Court's decision?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All parties? Is the NFP really willing to support Ersen, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[209]`
Mówca: **Frens Ricter**
> ""We must be hopeful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[210]`
Mówca: **Kesaro Kibener**
> ""Because the case is now in the hands of the Supreme Court, this ruling will influence all future implementation of the law and the decision-making of the lower courts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[211]`
Mówca: **Kesaro Kibener**
> ""I and the NFP are ready to push for de-escalation and aid our nation during this dangerous time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Remus was visibly annoyed but kept himself silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is the most likely outcome of this case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[214]`
Mówca: **Frens Ricter**
> ""Besides, if the NFP can see the necessity in de-escalation, I'm sure the Sollist judges can too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`
  - -> `[237]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope you are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Frens. How naive of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[217]`
Mówca: **Remus Holstron**
> ""As if the PFJP has the influence to change the outcome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. Our armed forces are capable of handling any threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think the threat is exaggerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We can't allow that to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest with you. I'm not feeling very comfortable talking about Bludish rights with the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Kesaro Kibener**
> ""I understand where this comes from, Mr. President. But please do not act like we are an anti-Blud party. Don't forget, we have members and supporters with Blud blood too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[226]`
Mówca: **Remus Holstron**
> ""May Nur bless our valiant warriors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""I can't believe I'm saying this, but it's not. We normally don't trust government data, but our own analysis came up mostly in line with the reports from the Ministry of the Interior and the Ministry of Defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[228]`
Mówca: **Frens Ricter**
> ""We definitely can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[229]`
Mówca: **Nia Morgna**
> ""If they ignore all of the points and strike against Ersen, Governor Bron will be free to follow his discriminatory policies without any obstacles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Nia Morgna**
> ""And in a possible future case, the Court's interpretation of the Ersen case will be the basis of all future rulings, which opens the way of suspending the rights of non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[231]`
Mówca: **Nia Morgna**
> ""The first and most likely option is that the Supreme Court completely ignores the arguments and rejects it in its entirety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
Mówca: **Frens Ricter**
> ""I'm afraid Mr. Kibener is right about this. If the Court ignores this case now, this may turn into something... massive. Therefore we have to pressure the Court not to escalate the already high tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[455]`
  - -> `[432]`

### Węzeł `[233]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you, Mr. President. If the Court rules against Ersen, this will most likely turn into a BFF campaign for a Bludish revolution. We ask everybody to recognize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you really think will happen if the Court ignores it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Kesaro Kibener**
> ""Another all-out BFF rebellion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Frens Ricter**
> ""I wouldn't say this for most other topics, but in the case of the threat of the BFF and radicalization, you should maybe listen to your cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you just *believe* in Hawker and hope for the best? I thought you would have a better plan than this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
Mówca: **Remus Holstron**
> ""In my opinion, that would be the preferred outcome. If enemies do truly live within our borders, I'd rather have them show their true faces earlier than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""Oh, wow. Good for you guys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Manoly glanced at Frens. Her eyes showed her agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""This is exactly what those damn Rums want. They are readying for war and waiting to use the tensions inside Sordland against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[222]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[242]`
Mówca: **Frens Ricter**
> ""I hope the armed forces will not be necessary. For the sake of us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[243]`
Mówca: **Nia Morgna**
> ""It would effectively erase any progress that has been made regarding Bludish rights, and will embolden anti-Bludish proponents to follow their actions freely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[246]`
  - -> `[247]`
  - -> `[245]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We definitely can't let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how does that affect the administration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That would be disastrous for our Bludish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bludish rights and the BFF have been major issues for many decades now. I don't see how this case makes either any worse than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how do you think the Supreme Court will react if we do it your way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you think, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[250]`
Mówca: **Frens Ricter**
> ""Anyway... Do you have other questions, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[251]`
Mówca: **Remus Holstron**
> ""...so that they can cry about *injustice* and ask Sordland's enemies to come and *save* them. I personally do not agree with the 'Bluds are Sords' Sollist crap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[252]`
Mówca: **Petr Vectern**
> ""You have a point. But I must point out that 'Contana' is the word for a geographic entity, unlike 'Sord'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[253]`
Mówca: **Remus Holstron**
> ""The reality is the Bluds do not respect nor recognize the laws and authority of Sordland. They'd rather separate themselves from Sords and protest the very laws that protect them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[255]`
Mówca: **Frens Ricter**
> ""We normally do not trust government data, but our own analysis came up mostly in line with the reports from the Ministry of the Interior and the Ministry of Defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[256]`
Mówca: **Narrator**
> "The threat in his tone was obvious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see your point. But I still don't understand why the NFP suddenly had a change of heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you even comparing Sordland with United Contana? Are you alright, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[259]`
Mówca: **Kesaro Kibener**
> ""My point is people like *the Malenyev* do not call themselves Kyovian over Contanan. Why is it that Bluds cannot do the same? Why does Sordland have to be divided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[260]`
Mówca: **Kesaro Kibener**
> ""I disagree. This case is important for the greater good of the Sordish nation, and that is what the Nationalist Front stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Because Contana has nothing to do with this and Article 6 is inherently racist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[262]`
Mówca: **Kesaro Kibener**
> ""All I'm asking is, if even in United Contana, *the Malenyev* doesn't call himself Kyovian before Contanan, why is it that Bluds cannot do the same? Why does Sordland have to be divided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[263]`
Mówca: **Kesaro Kibener**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Kibener has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[265]`
Mówca: **Kesaro Kibener**
> ""Very funny, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""We agree to come together in support of Ishval Ersen, but we believe our statement should include the acknowledgement of the inherent racism within the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Manoly Suheil**
> ""We must use this opportunity to show the flaws in the Constitution. If the Court agrees that there is in fact conflict between the Articles, or recognize the discrimi-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[268]`
Mówca: **Frens Ricter**
> ""I can't believe I'm saying this, but he is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree with Mr. Kibener. A United Sordland is what we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[270]`
Mówca: **Nia Morgna**
> ""I can't believe the words being thrown around at this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[273]`
  - -> `[264]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what is the position of the PFJP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Frens Ricter**
> ""I personally somewhat agree with Mr. Kibener on this. However, our position as the PFJP is that Article 6 does indeed discriminate against non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither can I. I think it's time we wrap this up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Petr Vectern**
> ""Ladies and gentlemen. You've heard the president. Let's sum it up and arrive at the point quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[275]`
Mówca: **Kesaro Kibener**
> ""And the Hawker Court is going to listen to that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[276]`
Mówca: **Petr Vectern**
> ""I'm not sure if it's worth the risk right before the vote for our reforms. But the decision is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me why we should pressure the Court to admit discrimination within the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[278]`
Mówca: **Manoly Suheil**
> ""Because it is the right thing to do, Mr. President. Now is not the time for weak and superficial actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Frens Ricter**
> ""We can show the people of Sordland the reality of the situation and create a precedent for a future constitutional amendment of these Articles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And the NFP is willing to join in with that statement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[281]`
Mówca: **Kesaro Kibener**
> ""Besides, we do not agree with your 'inherent racism' hogwash. You have to state that it is your party's opinion and does not reflect the NFP. We won't take part in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you think, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[284]`
Mówca: **Petr Vectern**
> ""That would make the statement look weak and disorganized. If there's no consistent strategy, I don't think it would work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[285]`
Mówca: **Frens Ricter**
> ""It can work for the time being, but I believe we can push for a more comprehensive outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Manoly Suheil**
> ""Exactly. Our current Constitution fails to recognize the Bludish people. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""Because it is the only way to decrease tensions. And the Supreme Court can't afford to look hypocritical, so they'll have to take the Sollist side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how do you think the Supreme Court will react if we do it your way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[289]`
Mówca: **Manoly Suheil**
> ""Exactly. Unfortunately, our current constitution fails to recognize them. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""I do not understand why someone would go against such a broad and inclusive law. I don't see the commies criticizing their Contanan identity, when in fact that country is filled with different ethnicities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[257]`
  - -> `[261]`
  - -> `[258]`

### Węzeł `[291]`
Mówca: **Manoly Suheil**
> ""Exactly. Unfortunately, our current Constitution fails to recognize Bludish people. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[292]`
Mówca: **Kesaro Kibener**
> ""This is exactly what those damn Rums want. They are readying for war and waiting to use the tensions inside Sordland against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[222]`
  - -> `[254]`

### Węzeł `[293]`
Mówca: **Remus Holstron**
> ""I still think this is admitting defeat against Sollism... But Mr. Kibener is right. The Rumburg situation demands extraordinary measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  and  Variable["BaseGame.Relations_Frens_Bribed"] == false  and  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  and  Variable["BaseGame.Relations_Frens_Bribed"] == false  and  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Frens Ricter**
> ""I agree with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
Mówca: **Frens Ricter**
> ""Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[299]`
Mówca: **Frens Ricter**
> ""That is precisely why we care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[300]`
Mówca: **Petr Vectern**
> ""But the PFJP's stance would be too radical for our party. I think it might be better to keep our administration out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[301]`
Mówca: **Kesaro Kibener**
> ""The citizens of Sordland are Sords. The constitution clearly defines that in Article 6. It encompasses everybody. This shouldn't be up for debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[302]`
Mówca: **Kesaro Kibener**
> ""Does *the Malenyev* call himself Kyovian before Contanan? Why is it that Bluds cannot do the same? Why can't the Sord patriots wish for unity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[303]`
Mówca: **Frens Ricter**
> ""But let's not spoil the mood. We are here to unite under another topic today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[304]`
Mówca: **Narrator**
> "He gave me a questioning look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Frens Ricter**
> ""I'm sure you will do your absolute best to pass the amendments nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[306]`
Mówca: **Narrator**
> "He gave me a questioning look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[307]`
Mówca: **Frens Ricter**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me why we should try to convince them to reiterate their position on Article 6.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[309]`
Mówca: **Kesaro Kibener**
> ""No. We are willing to give our support for Ersen for the violation of his right to property. But if you are going to go that way, we have to make two separate statements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[310]`
Mówca: **Manoly Suheil**
> ""We have to try. If they truly care for the people, they will agree to it. If not, people will see the reality of the Sollist state apparatus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[311]`
Mówca: **Petr Vectern**
> ""I don't think this would work, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[313]`
Mówca: **Petr Vectern**
> ""Hawker won't be influenced. Plus, it could further antagonize them against our reforms. We will definitely lose votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Petr Vectern**
> ""In my opinion, the PFJP has the most to gain from this. They would be seen as the leaders of this table, not us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is the PFJP willing to join in with that statement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Frens Ricter**
> ""As much as I don't agree with it, we are willing to compromise and join in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to release a unified statement with the opposition. We will not involve ourselves in this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Narrator**
> "The representatives of both parties looked at me with disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement. We will argue that Bludish people are considered Sords before the law, as Mr. Kibener suggested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement. We will argue that Articles 6 and 7 are inherently discriminatory and in conflict with the rights of people, as Mr. Ricter suggested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[321]`
Mówca: **Kesaro Kibener**
> ""That's great to hear. We will get to work immediately after the celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ErsenQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[325]`
Mówca: **Nia Morgna**
> ""I also agree that Chief Justice Hawker won't have a sudden change of heart because of it. But we must put pressure on the Justices nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Nia Morgna**
> ""I think I have made my own position clear. In the end, it is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_PFJP])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_Main])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EndDecision)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[319]`
  - -> `[317]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We will stay out of it. This isn't worth the risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement with the NFP. We will argue that Bludish people are considered Sords before the law, as Mr. Kibener suggested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[340]`
Mówca: **Frens Ricter**
> ""But if you are going to go this way, we will still need to make our separate statement as party policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Narrator**
> "Manoly was shaking in her seat in fury but managed to keep herself silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[342]`
Mówca: **Frens Ricter**
> ""That's great to hear. We will get to work immediately after the celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Generichub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[454]`
  - -> `[431]`
  - -> `[453]`
  - -> `[585]`

### Węzeł `[344]`
Mówca: **Nia Morgna**
> ""That is correct, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[350]`
Mówca: **Petr Vectern**
> ""If you are going to add the amendment Nia's been working on, this is the stance we should take.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Petr Vectern**
> ""This could help get the winds of change behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
Mówca: **Nia Morgna**
> ""As I already said, supporting the PFJP to put pressure on the court and declare that our constitution is inherently discriminatory will only do good for our new amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Nia Morgna**
> ""This is what we believe in, so we should make it public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[357]`
Mówca: **Nia Morgna**
> ""I agree with Mr. Ricter and Ms. Suheil. I personally think we should join them in their statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[361]`
Mówca: **Nia Morgna**
> ""As I already said, supporting the NFP should be out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I have enough information about the NFP's position. Let's hear the other side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_Main])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[364]`
Mówca: **Petr Vectern**
> ""What are you saying, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[338]`
  - -> `[524]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you suggest we do, Ms. Morgna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[366]`
Mówca: **Frens Ricter**
> ""That's very disappointing. Even if we're alone in this, the PFJP will keep fighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Remus Holstron**
> ""The correct choice, I would say. The Hawker Court will do the right thing. Nobody should intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[368]`
Mówca: **Manoly Suheil**
> ""With all due respect, Mr. Ricter, I think nobody expected a USP president to help with Bludish rights anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[369]`
Mówca: **Frens Ricter**
> ""He has. But our position as PFJP is that Article 6 does indeed discriminate against non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[370]`
Mówca: **Kesaro Kibener**
> ""I truly believe they will be convinced. It is not against their ideology and that is what Colonel Soll intended with the Constitution. We'll be shooting them with their own guns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""Yes. We'll talk about that later, Remus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[376]`
Mówca: **Narrator**
> "Nia leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Nia Morgna**
> ""I definitely do not agree with Mr. Kibener or Mr. Holstron. I don't see Sollism's unity working in reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Nia Morgna**
> ""I don't agree with either the Sollist or the neo-Sollist stance of this nation. You already know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[382]`
Mówca: **Nia Morgna**
> ""But I also have to say that pushing this position could have an effect on the outcome of the case. Mr. Hawker can agree with the traditional Sollist interpretation, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Nia Morgna**
> ""However, as long as our law enforcement forces are filled with anti-Blud officers, I don't believe the change on the ground will be so visible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have already decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EndDecision])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[386]`
Mówca: **Nia Morgna**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[387]`
Mówca: **Nia Morgna**
> ""I don't like the sound of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud = true;
BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen = true;
BaseGame.Bludish_Opinion += 2;
BaseGame.Sollist -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist = true;
BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism = true;
BaseGame.Bludish_Opinion -= 2;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport = true;
BaseGame.Bludish_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ChoiceHub_NFP)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[358]`
  - -> `[405]`
  - -> `[372]`
  - -> `[327]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[394]`
Mówca: **Petr Vectern**
> ""I think this is risky, Anton. But if it works -- which it actually might -- it could make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Petr Vectern**
> ""If the Court really feels the pressure and accepts it, the lower courts will need to adhere to their interpretation. It might not get rid of legal discrimination, but it could at least decrease it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Petr Vectern**
> ""But with the vote on our reforms coming so soon... It's a real leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[397]`
Mówca: **Remus Holstron**
> ""With all due respect, Mr. Kibener, the NFP cannot merely stay out of it. We must condemn this decision and actively protest it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[398]`
Mówca: **Remus Holstron**
> ""Neither do I. As much as it may be needed, this will only strengthen the Sollism of the USP. We all know Sordists don't agree with Sollist nationalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Kesaro Kibener**
> ""We'll talk about that later, Remus. Sordists will have to listen to me this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[400]`
Mówca: **Manoly Suheil**
> ""I'll be honest, I didn't expect a USP president to agree to this. You've proved me wrong, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Kesaro Kibener**
> ""That's a shame, really. Sadly, the NFP cannot take part in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[402]`
Mówca: **Frens Ricter**
> ""We will also support the effort for the sake of a positive result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[403]`
Mówca: **Petr Vectern**
> ""We appreciate all your comments, ladies and gentlemen, but now that the USP's stance is clear, we should probably end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[404]`
Mówca: **Frens Ricter**
> ""And having a positive outcome for this case alone doesn't suffice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[412]`
Mówca: **Petr Vectern**
> ""We shouldn't take this stance while we're trying to amend Article 6 and 7. That inconsistency would damage us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Petr Vectern**
> ""Then again, the Supreme Court agrees with it, the lower courts will have to adhere to the interpretation. It might not get rid of legal discrimination, but it could at least decrease it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_NFP])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_Main])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[419]`
Mówca: **Petr Vectern**
> ""Honestly, it doesn't. As long as there's no big Bludish revolt or anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Petr Vectern**
> ""But regardless, we must do our best to decrease the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Manoly Suheil**
> ""What part of it don't you understand? If these legitimate claims are rejected, they will not be raised again in other cases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Manoly Suheil**
> ""This will, in practice, only end up legalizing discrimination against all non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Manoly Suheil**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Frens Ricter**
> ""That is precisely why our expectation is to see a different result this time. The stakes couldn't be higher.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[425]`
Mówca: **Kesaro Kibener**
> ""The only good result would be if the Supreme Court reiterates its commitment to the pillar of 'unity' in Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""If the Court reiterates the definition of 'Sord' in Article 6 as an all-encompassing term, they would be acknowledging that Ersen and others like him are indeed protected by the 'Rights of the Sord Peoples' -- which they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Kesaro Kibener**
> ""As a result, the resettlement policy in Deyr would be reversed, opening the way for Governor Bron's removal and the de-escalation of tensions in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[343]`

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why would I want to lose a governor from our party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are already aware of this case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But what about those who don't want to be called a Sord?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As concerning as this all is, the Supreme Court must make its decision independently. This is not in our jurisdiction, just as lawmaking is not in theirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Frens Ricter**
> ""How about your amendments? Will you leave the Court to decide for themselves there too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[437]`
  - -> `[435]`
  - -> `[439]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why do you even care? You and your party are not even giving support to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course not. Their current say in the amendments is wrong, as that shouldn't be the duty of the judiciary. This case, however, is actually their job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[436]`
Mówca: **Kesaro Kibener**
> ""Mr. President... Despite previously being against it, I now completely understand why Sordland still needs Sollism. We need unity more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust that they will do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am just telling you how it should be, not what will happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[442]`
Mówca: **Kesaro Kibener**
> ""And Article 6 is that unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""Exactly. This looks awfully like a political strategy against the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Nia Morgna**
> ""I was actively involved in this case. Because of the implications with the constitution, there is no way the Supreme Court will agree with Ishval Ersen on all of the points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[445]`
Mówca: **Kesaro Kibener**
> ""In short, the plan is to release a unified statement to the Justices declaring our support for Ersen and explaining why this is so important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[446]`
Mówca: **Nia Morgna**
> ""Actually, Mr. President is completely right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This doesn't fix the core of the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually makes a lot of sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland will not be threatened nor blackmailed by some 'massive' response from a group of people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Remus Holstron**
> ""If enemies do truly live within our borders, I'd rather they show their true faces earlier than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[457]`
Mówca: **Remus Holstron**
> ""I agree with Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hold on. If this meeting is going to turn into a racist summit, I will take my leave immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will hear you out. But know that I will not act on anything before talking to the representatives of the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alright. I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am aware of this case. In fact, we are already working on revoking the current special zone status of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[462]`
Mówca: **Frens Ricter**
> ""No, Mr. President. It won't... Hopefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree completely. In fact, we are already working on the possibility of changing said articles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You sound like Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Doesn't that mean the existence of the Bludish people is literally not being acknowledged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[466]`
Mówca: **Remus Holstron**
> ""We do not need Sollist unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Narrator**
> "Kesaro stared Remus down and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[468]`
Mówca: **Kesaro Kibener**
> ""Of course, I'm not saying nothing can change. The results of today's meeting can still, possibly, influence some of our members...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[469]`
Mówca: **Narrator**
> "Nia did not comment but nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[470]`
Mówca: **Narrator**
> "Nia smiled for a brief moment and nodded in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[474]`
Mówca: **Narrator**
> "Nia's eyes blazed with fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[475]`
Mówca: **Nia Morgna**
> ""I'll be completely honest. I would never have expected that from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are your plans and suggestions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[477]`
Mówca: **Kesaro Kibener**
> ""We have the Minister of Justice here with us too. I'm sure she would not disagree with what I just said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[478]`
Mówca: **Frens Ricter**
> ""You didn't bring this up in our meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[479]`
Mówca: **Nia Morgna**
> ""The *Blud problem*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[480]`
Mówca: **Manoly Suheil**
> ""That's great to hear. We would be very happy if you can share the details once they're more concrete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[481]`
Mówca: **Frens Ricter**
> ""We prefer to push for a precedent for these reforms first. The Ishval Ersen case can give us exactly that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Frens Ricter**
> ""Even if you push for amendments, in the case of their failure the current interpretation of the Supreme Court will be the basis of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[483]`
Mówca: **Manoly Suheil**
> ""We must pressure the Courts to agree with Ersen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that true, Ms. Morgna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I've heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[486]`
Mówca: **Frens Ricter**
> ""We will definitely give support to that when the time comes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Frens Ricter**
> ""However, the case of Ishval Ersen has a bigger reach than Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[488]`
Mówca: **Frens Ricter**
> ""That makes things much clearer for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Frens Ricter**
> ""I see that you finally realized that your proposal is doomed. It must be why you're trying to turn your defeat into a symbolic attempt for Bludish rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[493]`
Mówca: **Kesaro Kibener**
> ""I'll be damned! So the rumors were true after all. Insanity reigns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[494]`
Mówca: **Frens Ricter**
> ""However, we definitely do not see eye to eye with your last-minute hidden details. Adding those to the proposal would destroy its chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ErsenQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ErsenQuestions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[508]`
Mówca: **Petr Vectern**
> ""I think I have enough information to be able to say we are deep in the mud here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Narrator**
> "Petr laughed at his own joke attempt, but nobody else reacted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""I think I have enough information..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[511]`
Mówca: **Petr Vectern**
> ""Well... Judging from what Ms. Morgna's been working on, it's safe to say that we have one clear option here. Am I right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""I think I have enough information..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[513]`
Mówca: **Petr Vectern**
> ""Well... I think the NFP's stance could do some good for the Bludish without provoking the establishment. But even that might be risky right before the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you suggest we do, Ms. Morgna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[518]`
Mówca: **Narrator**
> "Petr looked at me and Nia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Nia Morgna**
> ""Well, if we are serious about including the amendments to Article 6 and 7 in the current proposal, our stance on this case should be very clear. If there's truly a right time to push for these changes, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Nia Morgna**
> ""We should push the Court from all directions. If they reject both the reforms and such a heavily charged court case, everybody will see them for who they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[523]`
  - -> `[522]`
  - -> `[524]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you're suggesting we join in with the PFJP's statement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. We have to concede one point so as not to agitate them too much. Otherwise both attempts will end up being symbolic only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree. We should pressure the Court to admit the discrimination within the Constitution. Let's join in with the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not convinced. I want to hear from Mr. Ricter and Mr. Kibener first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[525]`
Mówca: **Petr Vectern**
> ""...Unless you want to completely stay out of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ChoiceHub_PFJP)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[531]`
  - -> `[534]`
  - -> `[537]`
  - -> `[540]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have already decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ChoiceHub_Main)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[559]`
  - -> `[555]`
  - -> `[485]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[549]`
Mówca: **Narrator**
> "Nia leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I have enough information about the PFJP's position. Let's hear the other side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_Main])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`
  - -> `[557]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EndDecision])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EndDecision])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[563]`
Mówca: **Petr Vectern**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ChoiceHub_Main])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[565]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[522]`
  - -> `[524]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EndDecision])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[567]`
Mówca: **Kesaro Kibener**
> ""And according to the Constitution, the language of Sordland is Sordish. If nothing is being done to enforce that, we are breaching the Constitution. This law simply enforces it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[568]`
Mówca: **Frens Ricter**
> ""It's great that we're aligned on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[569]`
Mówca: **Frens Ricter**
> ""We have to do something about it. Because the reality is, the secessionists are on the rise...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[570]`
Mówca: **Kesaro Kibener**
> ""Just imagine. All parties of the Assembly are reminding them of their duty -- with their own beloved Constitution. Mr. Hawker can't take that pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[571]`
Mówca: **Kesaro Kibener**
> ""This is Sordland. You can subscribe to whatever idea you want, but if you are a citizen, you are a Sord. This is how nations work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[572]`
Mówca: **Kesaro Kibener**
> ""What racism are you talking about? Sollism is based on civic nationalism, not ethnic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option1 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option1 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option2 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option2 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option3 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Hub_Option3 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[584]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Hub_Option3 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Petr Vectern: ""I think I have enough information..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's just jump straight into your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand. And what does the PFJP think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
