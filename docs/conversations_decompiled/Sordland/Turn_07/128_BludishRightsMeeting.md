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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 14

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[384]` (Paskal Beniwoll): `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] = true; Variable["BaseGameSupport.Jo...`
- Węzeł `[408]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal"] = true; Variable["BaseGam...`
- Węzeł `[409]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Reform_NFP_Convinced"] = false;`
- Węzeł `[410]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn07_HP_RayneChangesProposal"] = true; Variable["BaseGameSupport...`
- Węzeł `[414]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator"] = true;`
- Węzeł `[415]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal"] = true;`
- Węzeł `[419]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone"] = true;`
- Węzeł `[420]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal"] = true; Variable["BaseGame.B...`
- *...oraz 6 innych węzłów ze skryptami.*

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
  - -> `[435]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian and I were waiting in my office ahead of our talk with the representatives of the Bludish movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> ""Forgive me, sir. As I wasn't involved in the preparation of this proposal, I wanted to make sure I didn't miss anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian was poring over the proposal Nia had prepared for the amendments to Article 6 and 7. She had completed it with extraordinary speed and with input from the Bludish rights movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How many times do you need to read that, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian, are you okay? I thought you would have memorized the proposal within minutes of receiving it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If there's something you want to say to me before the guests arrive, this would be the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent as Lucian kept reading the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Of course I've read it, sir. But as I wasn't involved in its preparation, I wanted to make sure I didn't miss anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Since you've already accepted their meeting, I don't think there's much to say until we hear what they bring up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> ""Ms. Morgna did a fine job, but I'll be honest. This is too extreme to pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> ""Article 6 is modified with additional details on how to acquire or lose Sordish citizenship status. But the main change is the removal of the term 'Sord' -- which I must say is extremely significant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He pointed to the first page of the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Especially the line: 'Everyone who is bound to the Sordish state by citizenship is a Sord,' is modified to... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""'Sordish citizenship' refers to all citizens of Sordland on the basis of equality regardless of language, race, color, gender, political thought, philosophical belief, religion or disability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""It replaces the term 'Sord' with 'Sordish citizen', and clearly defines what that is. As much as it a good change in theory, I'm not sure if this is worth tanking the whole of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[18]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you would support me through this, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you advising against changing our proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you mean? Are you showing me your nationalist side, Lucian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, don't stop there. Read the changes to Article 7 as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Of course I will, sir. I'm just doing my job as your advisor. I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'll be honest, sir. I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[24]`
  - -> `[32]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == false && BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == false || BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == false  or  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... Nothing's been decided yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""No, sir. I'm merely stating that I don't see how anyone from the USP would be willing to support these changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[24]`
  - -> `[32]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want you to give this a chance, Lucian. I believe this is very important for the future, and I need your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The party doesn't support the current proposal anyway. At least we can shine a spotlight on Bludish rights with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't get the full party's support for our current proposal, either... Honestly, I don't see why we should back off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right. It was already difficult trying to get the party to back our initial draft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""If you say so, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""With these additions, it will be nearly impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "He flipped to the second page of the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""The line in Article 7: 'Every Sord is equal before the law' is modified to...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""'Everyone, regardless of language, race, color, gender, political thought, philosophical belief, religion or disability, is equal before the law'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""What about you, sir? Are you really thinking of adding these to your proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not seriously, no. I just want to test the waters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That really depends on how today's meeting goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me straight, Lucian. What are our chances of passing this proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""I'll be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""I doubt Mr. Leke and Mr. Ejall can provide us with anything tangible that will change the minds of the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> ""Unless something extraordinary happens, the addition of these changes would doom our proposal for failure. There's no question about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
Mówca: **Narrator**
> "After I accepted the meeting, Nia informed us of their intention to convince us to add further changes to our constitutional amendment proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I can at least see how this change could have been workable, if it wasn't coupled with the first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""My general advice is not to change the focus of our constitutional amendments by messing with these articles. Our priority should be reforming the governmental structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Livia stepped in and informed us that the representatives had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "With my assent, she opened the door to let Mansoun Leke and Fetih Ejall inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[60]`
Mówca: **Fetih Ejall**
> ""It is great to finally meet with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> ""Thanks for having us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You don't seem too happy about this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think they are here to ask us to change Articles 6 and 7?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If there's something you want to tell me before the guests arrive, now would be the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I waited in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[66]`
Mówca: **Narrator**
> "But since our statement with the PFJP, there were rumors that we would also include these changes in our proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> ""Forgive me, sir. I just think we are in a precarious situation at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""There's no question about it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Lucian didn't seem too happy about my decision to put pressure on the Court by highlighting the discrimination in Article 6 and 7 of the Sordish Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""You already publicly criticized those articles for being discriminatory against the Bludish people. They'll expect you to act on your words now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""But I advise against altering our proposal at the last minute. Especially with changes that would never be accepted by our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""With that said... If you don't act on this, you risk losing all the Bludish support you've gained so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> ""Sir. I believe your statement with Mr. Ricter put us in a precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's your advice, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we have the opportunity to change those articles as well, we have to seize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think there's no way to pass changes to Articles 6 and 7?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I don't intend to change our current proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""It's true that Mr. Ersen's case gathered a lot of sympathy, even from the USP...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""...But I must say it's not enough to pass the amendments. Not unless something extraordinary happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> ""If you say so, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""As much as I'm troubled by the possibility of losing Bludish support, we cannot agree to change our proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""My general advice is not to lose focus of our constitutional amendments by messing with these articles. Our priority should be reforming the governmental structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Livia stepped in and informed us that the representatives had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[85]`
Mówca: **Narrator**
> "We shook hands and took our seats on the two sofas facing each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Good morning, Mr. Ejall and Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Mansoun Leke**
> ""Good morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Fetih Ejall**
> ""Barilbar zinjar. Healthy mornings to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see you, gentlemen. Please, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good morning, Mr. Leke and Mr. Ejall. Why don't we take a seat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Barilbar zinjar, my Bludish brothers. Please have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Mansoun and Fetih exchanged puzzled looks. Lucian raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "After a few seconds of awkward silence, we shook hands and took our seats on the two sofas facing each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Fetih Ejall**
> ""You must know why we're here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[98]`
Mówca: **Fetih Ejall**
> ""You know why we're here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Fetih Ejall**
> ""We must first thank you for pushing for changes to Article 6 and 7. This has been a lifelong quest of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Mansoun Leke**
> ""Thank you for your support of Mr. Ersen and the rights of Bludish people in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[101]`
Mówca: **Fetih Ejall**
> ""First of all, we thank you for standing with Ishval Ersen and the rights of the Bludish people of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[102]`
Mówca: **Fetih Ejall**
> ""But know this. If you're *really* willing to fight for the rights of the Bludish people, we will champion you to the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[107]`
  - -> `[110]`
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Fetih Ejall**
> ""We never would have expected such statements of support coming from a USP president. You have our appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I promise you, I am willing to fight for your rights until we achieve true equality between Sords and Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I've already shown you that my intentions are pure by involving you in our proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't we jump straight to the point?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to know. Thank you, Mr. Ejall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Mansoun Leke**
> ""The addition of these changes to your proposal hasn't been announced yet, Mr. President. We hope to see you act on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Fetih Ejall**
> ""Ett'a. Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Fetih Ejall**
> ""I believe we made good headway with Ms. Morgna on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Fetih Ejall**
> ""Since it was your intention to start this process in the first place, I'd like to believe that you'll add these amendments to your reform package soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Fetih Ejall**
> ""If we're already aligned and there's nothing to discuss about the proposal, we can immediately talk about how we can pass the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[127]`
  - -> `[123]`

### Węzeł `[119]`
Mówca: **Fetih Ejall**
> ""With the support of Mr. Ricter and the PFJP, we have worked on a proposal to change the articles you singled out as discriminatory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Fetih Ejall**
> ""It was a bold move openly attacking the Sollist structure of this country, so I'd like to believe that we share the same sentiment about reforming our constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Fetih Ejall**
> ""If you're willing to listen, we can explain the details to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[124]`
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I support your cause, the timing of this may not be the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I went over the changes already and I approve of them. Let's talk about how we can actually pass them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we discuss our strategy, I'd like to go over the changes together with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. It is still not guaranteed that we'll be adding these changes to our reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[128]`
Mówca: **Fetih Ejall**
> ""Mr. Leke, could you read the proposed changes for us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Fetih Ejall**
> ""Great. Mr. Leke, could you read the proposed changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Mansoun Leke**
> ""The ethnic term 'Sord' will be removed from the constitution. We will remove the lines that define the citizens of Sordland by nationality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Mansoun took out a stack of papers and started reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[132]`
Mówca: **Mansoun Leke**
> ""Firstly, the line 'Everyone who is bound to the Sordish state by citizenship is a Sord' will be removed entirely from Article 6.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""And not only them. Do you really want to throw away your cooperation with the NFP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""I don't think we should lose the focus of our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[138]`
Mówca: **Mansoun Leke**
> ""As for the following lines in the rest of the article, the term 'Sord' will be replaced with 'citizen of Sordland'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Mansoun Leke**
> ""And the line in Article 7: 'Every Sord is equal before the law' will be modified to...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Mansoun Leke**
> ""'Everyone, regardless of language, race, color, gender, political thought, philosophical belief, religion or disability, is equal before the law'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[141]`
  - -> `[142]`
  - -> `[143]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gentlemen. I'm all with you on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are very significant and necessary changes. But they should be the target of our next reforms. They don't have a place in our current reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I agree with these changes in principle, I don't have a sound plan to pass them in practice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you crazy? This proposal will be crushed in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[145]`
Mówca: **Fetih Ejall**
> ""No. On the contrary, this is the perfect time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Fetih Ejall**
> ""Governor Bron's ultranationalist policies are now known all across Sordland thanks to Ishval Ersen. And the support from the presidency has given people hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Fetih Ejall**
> ""Our polls show that the Workers Party will definitely make it to the Assembly in the next elections. Anybody can see the Old Guard is scared of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Mansoun Leke**
> ""And with the public opinion behind your constitutional changes, now is the best opportunity to include the Bludish community in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> ""You might be correct about the sharp change in the public perspective, but I agree with President Rayne. The timing of this is not right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Fetih Ejall**
> ""Let us at least explain our proposal, Mr. Galade. Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[151]`
Mówca: **Fetih Ejall**
> ""Good to know, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""Mr. President is right. Given the current political reality, adding these to our proposal would eliminate the possibility of any reform being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
> ""If we can't reform the judiciary and the amendment procedures, what good does it do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Mansoun Leke**
> ""If even the leadership of the governing party doesn't believe in the possibility of change, of course nobody else will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Mansoun Leke**
> ""But this is a fallacy. If you don't support us because of the existence of people who are against us, how do we even start fixing the problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""I'm sure you understand. We need a realistic proposal. This is the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[157]`
Mówca: **Fetih Ejall**
> ""Ett'a. And that deadlock is what's created the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Mansoun Leke**
> ""It's time this country stops pushing the Bludish people to the corners of society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You sound like you're trying to justify the actions of the secessionists. I hope you're not referring to the BFF, Mr. Ejall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The liberation movement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""I must point out that given our current political reality, adding these to our proposal may eliminate the possibility of any reform being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[162]`
Mówca: **Fetih Ejall**
> ""You didn't hear our offer yet, Mr. President... Or do you have a problem with the proposal's contents?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Okay, let's talk strategy. Let's hear your offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's go over those contents one more time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Fetih Ejall**
> ""Sure. Mr. Leke, could you read the proposed changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[166]`
Mówca: **Fetih Ejall**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[167]`
Mówca: **Fetih Ejall**
> ""Exactly. As long as the government creates a deadlock and doesn't offer solutions, the Bludish people will have to do what it takes to defend themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
Mówca: **Fetih Ejall**
> ""You know what I'm referring to, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Fetih Ejall**
> ""As long as the government creates a deadlock and doesn't offer solutions, the Bludish people will have to do what it takes to defend themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Fetih Ejall**
> ""And as long as you label those people who fight for their rights as the villains, you are deepening the problem and turning it into a cycle of violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[171]`
  - -> `[173]`
  - -> `[174]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really trying to justify the actions of the BFF right now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So the only side at fault here is the government?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew you were in cahoots with the terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are right. Many mistakes were made to the detriment of the Bludish people. We can't continue like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Fetih Ejall**
> ""I'm not trying to justify anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Fetih Ejall**
> ""I'm not going to reply to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Fetih Ejall**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[178]`
Mówca: **Fetih Ejall**
> ""No. I didn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Fetih Ejall**
> ""What I'm saying is that you can't ignore the background of how these movements came to be. Nothing appeared out of thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""That does sound suspiciously like a defense of the BFF militants. Why are you refraining from using their name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Mansoun Leke**
> ""You're not even listening, Mr. Galade. Are you looking for reasons to prosecute us too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[182]`
  - -> `[184]`
  - -> `[185]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Mr. Leke. Please calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're right, Lucian. The Sordish state isn't entirely innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But we are listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""I'm not looking for reasons, Mr. Leke. But if you give me one, you'll face justice like everyone else.""]** — Mówca: **Player**
> ""I'm not looking for reasons, Mr. Leke. But if you give me o--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[187]`
Mówca: **Fetih Ejall**
> ""Fara!? Don't finish that sentence, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Fetih Ejall**
> ""We will not sit here smiling if you're going to start throwing threats at us. Lok geduhe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[189]`
Mówca: **Fetih Ejall**
> ""Gentlemen. Let's get one thing straight here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Fetih Ejall**
> ""Are you willing to support our rights? Or did you approach us for propaganda reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Since we're already on the same page, we should talk about how realistic it is to pass these changes instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But the Bludish movement must properly distance itself from the secessionists. Otherwise we will see no progress on these issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""All right.""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[194]`
Mówca: **Fetih Ejall**
> ""We will, Mr. President. If you give us your full support, we will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Mansoun Leke**
> ""Then let's talk about our offer and plan our moves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Mansoun Leke**
> ""Then why don't we talk about our offer and plan our moves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""All right.""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Mr. Ejall. I'm willing to support you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want to support this proposal, but you have to convince me that you have a sound plan to pass it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought we could find other common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. I'm not willing to support your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[202]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`
  - -> `[207]`
  - -> `[205]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Ejall... Sit down, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're forgetting your place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Stop throwing Bludish words around, Mr. Ejall. I hope for your sake that you didn't say anything bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Fetih Ejall**
> ""I'm not going to indulge your power trip, Mr. Rejn!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please repeat that in proper Sordish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[208]`
Mówca: **Fetih Ejall**
> ""You cannot dictate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[351]`

### Węzeł `[209]`
Mówca: **Fetih Ejall**
> ""As expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""All right.""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[211]`
Mówca: **Fetih Ejall**
> ""I don't see why I should stay if you're not willing to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`
  - -> `[214]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look. I'm willing to support you, but I don't believe we can succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't we all just calm down and hear your plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Did you not learn common courtesy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Fetih Ejall**
> ""No, I didn't. I'm a *Blud*, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[216]`
Mówca: **Narrator**
> "On his gesture, Mansoun also stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Mansoun Leke**
> ""Well... Nevertheless. Thank you for inviting us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "He sighed and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[219]`
Mówca: **Mansoun Leke**
> ""Please sit down, Mr. Ejall. Let's talk about our plans. I believe Mr. President can still change his mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""All right.""])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[221]`
Mówca: **Fetih Ejall**
> ""I know you are rightfully wondering how we can gather a majority in both the Assembly and the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
Mówca: **Fetih Ejall**
> ""If you can gather the support of the USP, the Assembly won't be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
> ""The Bludish community was never excluded during the preparation process. However, the fact is that there is no major Bludish presence in the Assembly. And we can't simply bring a party that's not elected into the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[224]`
Mówca: **Fetih Ejall**
> ""In the past, Mr. Ricter and Ms. Suheil supported us greatly in this endeavor, and I believe the PFJP would get behind our proposed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Lucian Galade**
> ""I hope you're aware that Mr. Ricter has already announced that the PFJP will not vote for our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Mansoun Leke**
> ""Since Ms. Morgna's team involved us in the proposal, the PFJP leadership has been reaching out to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Fetih Ejall**
> ""It's true. If you include our changes in your reforms, the tide can still be turned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[243]`
  - -> `[245]`

### Węzeł `[234]`
Mówca: **Mansoun Leke**
> ""You've put them under a lot of pressure now. They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""You've already made a statement together, denouncing Article 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Mansoun Leke**
> ""This would put them under a lot of pressure. They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[240]`
Mówca: **Mansoun Leke**
> ""They've been campaigning for these changes themselves, and they are aware of the support they'd lose from the Bludish people if they vote no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Mansoun Leke**
> ""I think Mr. Ricter wouldn't risk that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""Gathering the support of the USP is the real problem here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't count on the PFJP too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, but that doesn't help me with convincing the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
> ""Do you think the conservative MPs will have a sudden change of heart?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Fetih Ejall**
> ""There is only one thing that can get them to work with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Fetih Ejall**
> ""If Mr. Hawker and his puppets are looking to put an end to the liberation movement, I'm willing to cooperate with them and give them what they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Lucian's eyes widened for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
> ""What are you saying, Mr. Ejall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Fetih Ejall**
> ""If you include these changes in your proposal, I will give you the best bargaining chip you can get. Intelligence about the BFF and the locations of its leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[252]`
  - -> `[254]`
  - -> `[255]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Intriguing. So you really are a traitor to your cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you absolutely serious, Mr. Ejall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How do we know the Old Guard will be convinced by that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really admitting your direct ties to the BFF in front of the president?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Mansoun Leke**
> ""You're starting to show your true colors, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[257]`
Mówca: **Fetih Ejall**
> ""Watch what you're saying, Mr. President. I came to you with respect, I demand the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[258]`
Mówca: **Fetih Ejall**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[259]`
Mówca: **Mansoun Leke**
> ""You can't *know* everything, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Mansoun Leke**
> ""This is what we offer because we believe in it. An end to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
> ""This would give us a significant edge, of course. But I still don't think it would be enough on its own. Besides, can you really deliver on your claims?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Fetih Ejall**
> ""I thought it was you who wanted to add this reform and invited us to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Fetih Ejall**
> ""We came here with a real offer and you keep questioning us. What's with this sudden change of attitude?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`
  - -> `[270]`
  - -> `[271]`

### Węzeł `[267]`
Mówca: **Fetih Ejall**
> ""I thought the administration was behind this reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you can promise us the BFF, maybe we can make this work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're forgetting something. We never promised you anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's Lucian's personal opinion, Mr. Ejall. There is no sudden change. I am willing to support you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think this is too risky. I'm not willing to lose our progress by cooperating with you. No offense intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Calm down. I was just joking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Be careful what you say in front of me, Mr. Ejall. You don't want to force me to start an investigation on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[274]`
Mówca: **Mansoun Leke**
> ""This isn't a joking matter, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Fetih Ejall**
> ""So, what about our plan and offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[276]`
Mówca: **Fetih Ejall**
> ""That I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[277]`
Mówca: **Fetih Ejall**
> ""Then we can talk about the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[278]`
Mówca: **Fetih Ejall**
> ""So you don't intend to pursue these reforms at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I want to. But I'm not convinced that your offer would make a difference. You have to give me more details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I apologize but no, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[281]`
Mówca: **Fetih Ejall**
> ""There is nothing left to discuss here. We should take our leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""There is nothing left to discuss h..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[283]`
Mówca: **Mansoun Leke**
> ""That's very disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[284]`
Mówca: **Narrator**
> "He straightened his posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[285]`
Mówca: **Fetih Ejall**
> ""As I said, I'm offering the Sollists an end to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[286]`
Mówca: **Fetih Ejall**
> ""But to you, I'm offering the possibility to become the president who finished off the secessionists. The president who started a new age in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Fetih Ejall**
> ""Think of the popularity you'll enjoy. This would be a huge boost for the administration, and it will also help your standing with traditional Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Fetih Ejall**
> ""And if we change the constitution in the process, the Bludish community will be applauding you with all their might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Mansoun Leke**
> ""If you have any questions, feel free to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me everything about the connection between the Workers' Party and the BFF, and why you are suddenly so keen on selling them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me about the BFF. Are you certain your intelligence would help us catch all of their leadership in one go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If this becomes public, how do you expect to keep your leadership of the Workers Party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[293]`
Mówca: **Fetih Ejall**
> ""I will give you everything I know and can gather. Even the connections in my own party. I am prepared to do this for the greater good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm all clear on your offer. Let's talk about how we deal with the votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[295]`
Mówca: **Fetih Ejall**
> ""As soon as you give the greenlight, I will suspend the people from our party who have ties to the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Fetih Ejall**
> ""I am ready to give you the names of all of them when the time comes. If this achieves progress for Bludish rights, I am willing to go to the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`
  - -> `[301]`

### Węzeł `[297]`
Mówca: **Fetih Ejall**
> ""Progress is progress. I think this would open so many doors for our people. And I don't hold the belief that the way forward is armed resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[298]`
Mówca: **Fetih Ejall**
> ""Well, their claims go to ridiculous lengths. It's true that some of the founders had previous connections to the liberation movement, but most have abandoned it entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So the party was always connected to the BFF, as the Sollists and the nationalists claim?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But why now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you really believe the changes to Article 6 and 7 will go over that well with the Bludish community?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[302]`
Mówca: **Fetih Ejall**
> ""The support for the Workers' Party is increasing more than ever. I firmly believe that we will make it to the Assembly in the next elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Fetih Ejall**
> ""If we're to finally take place in the democratic process, I believe we must completely sever our ties with the liberation movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Fetih Ejall**
> ""Our movement is now far larger than theirs, and we have to take this opportunity for the Workers' Party and for Bludish rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[305]`
Mówca: **Fetih Ejall**
> ""That's on your security forces, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Fetih Ejall**
> ""But I'm very certain that the recent intel I received about their location is reliable. Among the leadership, the highest profile name is Awlan -- Dewlen Arge's brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Fetih Ejall**
> ""What you do with that information is up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[310]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Dewlen is already in Antel Rock. If we can get both brothers locked up, the BFF would be crippled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you know who their current leader is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else do you know about the BFF?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[311]`
Mówca: **Fetih Ejall**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[312]`
Mówca: **Fetih Ejall**
> ""Since the arrest of Dewlen Arge, I don't believe they have a single leadership position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Fetih Ejall**
> ""But his brother is the most respected high-ranking member inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[310]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What can you tell me about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Fetih Ejall**
> ""According to my sources, a group of four commanders are leading the movement in Sordland. Awlan Arge is among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Fetih Ejall**
> ""I've learned that Awlan has been to Rumburg several times to meet with the Rumburgian Intelligence Directorate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[320]`
Mówca: **Fetih Ejall**
> ""Apart from Rumburg, he also seems to have ties with the Golcondist administration in Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Fetih Ejall**
> ""Since Operation Bear Trap commenced in Wehlen, rumors have been circulating that Awlan and his brigade are planning to increase their activity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Fetih Ejall**
> ""Since Operation Bear Trap commenced in Wehlen, Awlan and his brigade have apparently been cooperating very closely with the movement's Wehlen branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Fetih Ejall**
> ""What's even more striking is a yet-to-be-confirmed report which points to the involvement of several wealthy Sordish businessman in smuggling Arcasian and Rumburgian weapons to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""These are massive, Mr. Ejall. I want you to give all of this intelligence to my team as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This entire offer sounds too good to be true. I'm not sure if I'm willing to trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope that's not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[330]`
Mówca: **Fetih Ejall**
> ""I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Fetih Ejall**
> ""I intend to give leadership back to Mansoun. The party still respects him immensely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Fetih Ejall**
> ""And his name hasn't been stained like most of ours. The government did not label him as a 'former terrorist', and neither was he declared a target by far-right nationalists. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Mansoun Leke**
> ""As much as I feel like I'm not ready for that responsibility, I'm ready to do whatever it takes to grow the Bludish democratic movement. I'm ready to be the new target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Mansoun Leke**
> ""This way, we can start anew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
> ""I believe that according to their plan, that part is all on us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Fetih Ejall**
> ""We'll give you the BFF and you'll get us the votes from the USP, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`
  - -> `[339]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just imagining talking to Gloria and Albin about the proposal again is giving me a headache.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What about the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may convince the leaders of the party, but we may want to reach out directly to all 130 of our members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Mansoun Leke**
> ""Focus on the leadership and get your vice president to convince the MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Mansoun Leke**
> ""He has a way with words. I think he can sell this idea even to the staunchest conservatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[347]`

### Węzeł `[342]`
Mówca: **Mansoun Leke**
> ""I'm sure you can handle it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[343]`
Mówca: **Mansoun Leke**
> ""What about it? You're already going directly against the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Mansoun Leke**
> ""Don't you already have a plan to get your current reforms through the Court? What does it really change for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""With all due respect, Mr. Leke, we are not children here. You know how risky this is. If we lose this, our entire reform package goes down the drain. Not just Article 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
> ""The addition of these reforms would flip our plan upside down. The implications are not the same at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really? Does Petr really have such an influence in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Mansoun Leke**
> ""Of course, Mr. President. He has a dialogue with everyone. He's able to reach all corners of the political spectrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Lucian Galade**
> ""I'm sure Mr. Vectern would be helpful in getting votes, but I don't see how that would be enough. Besides, the Supreme Court is the main problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[350]`
Mówca: **Narrator**
> "He sighed and sat down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Then I'm sorry. I'm not willing to support your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[355]`
Mówca: **Fetih Ejall**
> ""This is a very dark time for the Bludish people in Bergia and we need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Fetih Ejall**
> ""Governor Bron's racist policies are being illegally protected by the Supreme Court under the guise of a large-scale threat by the so-called terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We are already working on a proposal to restructure the Special Zone. Governor Bron will soon be gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Hawker is using Governor Bron to increase tensions in the country. If there really are terrorists out there, these two are where it starts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As much as I'm against the Supreme Court's decision to delay the case, the BFF threat in the region is not some fantasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Fetih Ejall**
> ""Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Fetih Ejall**
> ""Well... Where were we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Fetih Ejall**
> ""Ah, yes. We never would have expected such statements of support coming from a USP president. You have our appreciation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[366]`
Mówca: **Fetih Ejall**
> ""It's great that we think alike on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[367]`
Mówca: **Fetih Ejall**
> ""I've heard about that. We ask that you prioritize it after your reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Mansoun Leke**
> ""Thank you for following up on this, Mr. President. I hope it becomes a reality soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[369]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Fetih Ejall**
> ""I thought you were different, Mr. President. But you've proved my comrades right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Fetih Ejall**
> ""We'll never achieve anything tangible as long as the USP is in power. I'm certain of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[372]`
Mówca: **Fetih Ejall**
> ""Then do your absolute best and make sure it doesn't fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Fetih Ejall**
> ""We're not going to *negotiate* our rights here. Either you will fight for us and we will give you what I said in return, or you abandon the Bludish democratic movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`
  - -> `[376]`

### Węzeł `[374]`
**[WYBÓR GRACZA: ""I'm willing to fight for you. I will include these amendments in our reform proposal." [ADD NEW CHANGES TO PROPOSAL]"]** — Mówca: **Player**
> ""I'm willing to fight for you. I will include these amendments in our reform proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[375]`
**[WYBÓR GRACZA: ""No need to be so dramatic, Mr. Ejall. Let's work together and finally change the Articles 6 and 7." [ADD NEW CHANGES TO PROPOSAL]"]** — Mówca: **Player**
> ""No need to be so dramatic, Mr. Ejall. Let's work together and finally change the Articles 6 and 7.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, Mr. Ejall, but I don't think I'm willing to take the risk. We can't lose a possibility to reform our constitution due to these two changes. We won't include them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Hub_BludishRights_BFF)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[429]`
  - -> `[432]`
  - -> `[294]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_BludishRights_BFF])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_BludishRights_BFF])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hub_BludishRights_BFF])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[381]`
Mówca: **Fetih Ejall**
> ""I'm not a Sordish politician, Mr. Rayne. You will see how serious I am about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[382]`
Mówca: **Fetih Ejall**
> ""It likely is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[383]`
Mówca: **Fetih Ejall**
> ""Of course. As soon as you add the changes to Article 6 and 7 to your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal = true;
BaseGameSupport.Journal_Turn07_BludishMeeting_ChangedProposal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] = true;
Variable["BaseGameSupport.Journal_Turn07_BludishMeeting_ChangedProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Manson was the spokesperson of the independents and the former leader of the WPB, while Fetih Ejall was the WPB's current leader."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[386]`
Mówca: **Fetih Ejall**
> ""You can threaten me all you like, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Fetih Ejall**
> ""You know that nobody received more death threats than me in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[388]`
Mówca: **Fetih Ejall**
> ""If you're not willing to support us, say it like a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[389]`
  - -> `[204]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's just calm down and talk about the offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[391]`
Mówca: **Mansoun Leke**
> ""That's... a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Fetih Ejall: ""There is nothing left to discuss h..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[393]`
Mówca: **Mansoun Leke**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Fetih Ejall**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Fetih Ejall**
> ""You will find an ally in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Fetih Ejall**
> ""And I will deliver my promises. You can count on what I said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[397]`
  - -> `[398]`
  - -> `[399]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you. Together we will achieve a better democracy in Sordland -- for everyone regardless of culture, language or ethnicity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Ejall. Together we will eliminate the BFF and set the Bludish people free from terror and division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope so, Mr. Ejall. Your promises will be needed to convince the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This was a very productive and historic meeting, gentlemen. Thank you for coming here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Fetih Ejall**
> ""For a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Narrator**
> "They both stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Narrator**
> "This drastic addition to the proposal at the last minute would surely be a cause of contention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Narrator**
> "I had no idea whether Fetih Ejall's plan would work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[406]`
Mówca: **Narrator**
> "They both stood up and left the office afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Narrator**
> "I wondered if I could still maintain the support of the Bludish community after this meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal = true;
BaseGame.Bludish_Opinion += 2;
BaseGame.Sollist -= 5;
BaseGame.Democratic += 3)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_Amendment_NewProposal"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 5;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_RayneChangesProposal = true;
BaseGameSupport.News_Turn07_R_BludishMovementGivesSupportToRayne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_RayneChangesProposal"] = true;
Variable["BaseGameSupport.News_Turn07_R_BludishMovementGivesSupportToRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal_Dictator"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_RayneChangesProposal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RayneChangesProposal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_Deal_RayneExpandsReformToEveryone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal = true;
BaseGame.Bludish_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_BludishMeeting_MadeNoDeal"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Security");)*
- **Efekt (`userScript`):** `PlayMusic("Security");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.BludishRightsMeeting_Hub_Option1 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.BludishRightsMeeting_Hub_Option2 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.BludishRightsMeeting_Hub_Option3 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.BludishRightsMeeting_Hub_Option3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Meeting with the leaders of the minority rights movement", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Meeting with the leaders of the minority rights movement","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
