# Sordland/Turn08/A_VPSelection

- **ID konwersacji:** `142`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/142_A_VPSelection.md`
- **Liczba węzłów dialogowych:** 211
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory
- **[38]** Lucian Galade
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Amendment_USP_Gloria_Convinced`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn08_Action_Court_GloriaJustice`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria`
- `GameCondition.Turn08_A_VPSelection`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[107]` (Lucian Galade): `Variable["GameCondition.Turn08_A_VPSelection"] = true;`
- Węzeł `[149]` (Lucian Galade): `Variable["BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria"] = true;`
- Węzeł `[178]` (Lucian Galade): `End();`

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
  - -> `[113]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordish law dictated that if a Vice President failed to complete his term, new candidates were to be put forward by the members of the cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[4]`
Mówca: **Narrator**
> "It was up to me to decide who would fill Petr's shoes. I wanted to chat with them one on one before making my decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "After much deliberation, the list had been narrowed down to three. Lucian Galade was the front-runner, followed by Gloria Tory and Albin Clavin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I had just begun to settle at my desk when I heard a knock at the door. Lucian entered and perched on the chair across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You know why you are here.”"]** — Mówca: **Player**
> "“You know why you are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“So. Vice President Galade. What do you think?”"]** — Mówca: **Player**
> "“So. Vice President Galade. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""All right, Lucian. You're one hell of a strategist, but why should I make you VP?""]** — Mówca: **Player**
> ""All right, Lucian. You're one hell of a strategist, but why should I make you VP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""You already know what I think, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“In my current capacity as chief strategist, I have evaluated the experience and capabilities of your potential vice presidents. Objectively, I am by far the most qualified candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“I would advise you not only to think about our long history together, but also the many crises I have helped shepherd you through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“I won't say much beyond that. I believe my work speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“You're such a valuable strategist. I don't know if I can afford to lose you in that capacity.”"]** — Mówca: **Player**
> "“You're such a valuable strategist. I don't know if I can afford to lose you in that capacity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I don't know. The public might gossip about your lack of a wife.""]** — Mówca: **Player**
> "“I don't know. The public might gossip about your lack of a wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“You wanted Petr's job from day one. How do I know you won't try to have me ousted next?""]** — Mówca: **Player**
> "“You wanted Petr's job from day one. How do I know you won't try to have me ousted next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Considering where Petr Vectern's proclivities got us, a vice president who's wholly uninterested in matters of the flesh would be a refreshing change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“As Vice President, my ability to serve you and this administration will only increase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“Mr. Vectern proved himself unfit for the position with his selfish and unprofessional behavior. I am counting on you not to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Lucian got up from his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He left my office. Just a minute later, there was another knock at the door and Gloria Tory came in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Gloria Tory**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Gloria Tory**
> "“I must say I was not surprised at all when my name was put forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Why were you not surprised?”"]** — Mówca: **Player**
> "“Why were you not surprised?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You seem confident.”"]** — Mówca: **Player**
> "“You seem confident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“So, Gloria, tell me why I should pick you.”"]** — Mówca: **Player**
> "“So, Gloria, tell me why I should pick you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Gloria Tory**
> "“I am, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Gloria Tory**
> "“One does learn to expect a few things after spending so many years in government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Gloria Tory**
> "“To put it simply, what I bring to the table is years of experience.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Gloria Tory**
> "“I have been a member of the Assembly for almost 20 years and I spent 7 years as its Speaker. This alone speaks for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> "“And as you know, I am also the spokesperson of the party, as well as the leader of the conservative wing. You can see what I am getting at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`
  - -> `[157]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Tell me. What are you getting at?”"]** — Mówca: **Player**
> "“Tell me. What are you getting at?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Your experience would be a great asset.”"]** — Mówca: **Player**
> "“Your experience would be a great asset.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“You become the Vice President, and I get the votes from the conservatives.”"]** — Mówca: **Player**
> "“You become the Vice President, and I get the votes from the conservatives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Gloria Tory**
> "“Precisely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Gloria Tory**
> "“Experience is always important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Gloria Tory**
> "“Well...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Gloria Tory**
> "“And so is being able to rally the Assembly's conservative voters to your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“I will be blunt. Being the leader of the conservative wing means that if I am the Vice President, we would have more votes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Gloria Tory**
> "“This would allow us to pass bills far more easily. Especially if those bills are aligned to my bloc's causes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[43]`
  - -> `[45]`
  - -> `[162]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“There is no us, Gloria.”"]** — Mówca: **Player**
> "“There is no us, Gloria.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“We are already aligned.”"]** — Mówca: **Player**
> "“We are already aligned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Gloria Tory**
> "“Before outright refusing, I insist you at least think about it. Unifying the party instead of fracturing it would certainly be better for the future of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Gloria Tory**
> "“Then that makes things easier, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Gloria Tory**
> "“I want you to know that I value order over everything else, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Gloria Tory**
> "“Being the Speaker of the Assembly requires principles, nerves like steel and determination to uphold proper conduct.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Gloria Tory**
> "“You can expect to see the same of my vice presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[167]`
  - -> `[143]`

### Węzeł `[51]`
Mówca: **Gloria Tory**
> "“Not just any woman. A strong woman who was able to protect order in a roomful of unruly men for 7 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Gloria Tory**
> "“Think about the message it would send. The first woman Vice President of Sordland. No. The first woman Vice President in the whole continent!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Gloria Tory**
> "“What support you would lose among traditionalists, you would gain tenfold among Sordish women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“That will be all for now. Thank you.”"]** — Mówca: **Player**
> "“That will be all for now. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“You are right. There is much to gain. I will consider it.”"]** — Mówca: **Player**
> "“You are right. There is much to gain. I will consider it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“I'd rather not align myself with the conservative wing.”"]** — Mówca: **Player**
> "“I'd rather not align myself with the conservative wing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Gloria Tory**
> "“There is much to gain from selecting me, Mr. President. I believe you will make the right choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[56]`

### Węzeł `[58]`
Mówca: **Gloria Tory**
> "“A shame, then. I had hoped you would see the opportunity. I guess you lack the experience to do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Gloria Tory**
> "“I wish you a nice day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Gloria Tory**
> "“I knew you would see reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Gloria Tory**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Gloria made her way out. A minute later, there was another knock at the door. This time, it was Albin Clavin's turn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[63]`
Mówca: **Albin Clavin**
> "“Greetings, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“It certainly is.”"]** — Mówca: **Player**
> "“It certainly is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Let's talk.”"]** — Mówca: **Player**
> "“Let's talk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Albin Clavin**
> ""It's a great honor to have been chosen as a candidate. Really terrific.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[67]`
  - -> `[64]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I will be straightforward. Why should I pick you?”"]** — Mówca: **Player**
> "“I will be straightforward. Why should I pick you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[68]`
Mówca: **Albin Clavin**
> "“As you know, I represent the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Albin Clavin**
> "“I hope to satisfy the requirements of this sacred position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
Mówca: **Albin Clavin**
> "“What Sordland needs today is not only to catch up to our more modern neighbors, but to surpass them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Albin Clavin**
> "“I believe we can do that. No. I am sure!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Albin Clavin**
> "“However, this will only be possible if we set aside our differences and unite as one. That is the outlook I wish to bring to the position of Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Albin Clavin**
> "“So that Sordland can excel and soar to new heights.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[74]`
  - -> `[76]`
  - -> `[202]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Very idealistic. I like it.”"]** — Mówca: **Player**
> "“Very idealistic. I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I did not ask about your opinions. What can you provide me with?”"]** — Mówca: **Player**
> "“I did not ask about your opinions. What can you provide me with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Nonsense. Sordland thrives on tradition. Striving for modernity will get us nowhere.""]** — Mówca: **Player**
> "“Nonsense. Sordland thrives on tradition. Striving for modernity will get us nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Albin Clavin**
> "“That is certainly...one opinion, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Albin Clavin**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Albin Clavin**
> "“The fact is, if I am the Vice President, reformist members of our party will be more likely to support you and your causes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Albin Clavin**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
Mówca: **Albin Clavin**
> "“This will smooth the passage of bills and help move our administration and our country forward in record time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[83]`
  - -> `[82]`
  - -> `[168]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I agree completely.”"]** — Mówca: **Player**
> "“I agree completely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“*If* you join the administration, that is. I don't think that's likely.""]** — Mówca: **Player**
> "“*If* you join the administration, that is. I don't think that's likely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“That makes sense.”"]** — Mówca: **Player**
> "“That makes sense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Albin Clavin**
> "“As unlikely as it is, we all must try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Albin Clavin**
> "“And now what this country needs is more dynamic, youthful leadership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Albin Clavin**
> "“Look at you, President Rayne. You became the youngest member of the Assembly and completely rejuvenated Sordish politics. I want to do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[88]`
Mówca: **Albin Clavin**
> "“Not that you might have forgotten, but I would also like to remind you that you promised me a position in exchange for my support at the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Albin_PromisedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Albin Clavin**
> "“There. I've stated my case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I'm a man of my word.”"]** — Mówca: **Player**
> "“I'm a man of my word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Times have changed.”"]** — Mówca: **Player**
> "“Times have changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“We will see about it.”"]** — Mówca: **Player**
> "“We will see about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
Mówca: **Albin Clavin**
> "“I always took you for a man of honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Albin Clavin**
> "“We need to be able to take risks to make gains and that is only possible with a forward-looking perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[98]`
Mówca: **Albin Clavin**
> "“A promise once given has to be kept, Mr. President. It would be foolish to go back on your word at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Albin Clavin**
> "“I trust your judgement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[101]`
  - -> `[100]`
  - -> `[200]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Aligning myself with the reformist wing does not seem like the way forward.”"]** — Mówca: **Player**
> ""Aligning myself with the reformist wing does not seem like the way forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Thank you. I will consider what you said.""]** — Mówca: **Player**
> "“Thank you. I will consider what you said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“This will be all for now. Thank you.”"]** — Mówca: **Player**
> "“This will be all for now. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Albin Clavin**
> "“You're quite wrong there -- opposing our views will send Sordland backwards. I thought you would understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Albin Clavin**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Albin got up and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "I leaned back in my chair, thinking about the pros and cons of each of my vice presidential candidates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_VPSelection = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_VPSelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I could almost hear Petr's voice in my head, laughing at the absurdity of my situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "But of course, he wasn't there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[116]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's resignation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's imprisonment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Narrator**
> "It was here: the day I'd been dreading since Petr's death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "At the entrance to my office, my new secretary Sylvia took my hat and coat. She was a matronly woman in her forties. She had a spotless background assisting various Maroon Palace officials."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Replacing Livia had been easy. But replacing my Vice President would be difficult."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[124]`
Mówca: **Narrator**
> "After much deliberation, the list had been narrowed down to two. Lucian Galade was the front-runner; Albin Clavin the second choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""I expect you will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
> ""Gloria Tory would be the only other suitable possibility, were she not already committed to her position on the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Clavin talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Clavin talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Clavin talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
> ""It is precisely in my capacity as strategist that I have evaluated the experience and capabilities of your potential vice presidents. Objectively, I am by far the most qualified candidate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion < 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lucian_Opinion < 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
> ""Even when we have not seen eye to eye, you must admit that my instincts have been unfailingly correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He left my office. Just a minute later, there was another knock at the door and Albin Clavin came in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""You being a woman could also prove advantageous.""]** — Mówca: **Player**
> ""You being a woman could also prove advantageous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I don't think Sordland's ready for a female vice president.""]** — Mówca: **Player**
> ""I don't think Sordland's ready for a female vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Gloria Tory**
> "“I'm not just any woman, Mr. Rayne. I was able to protect order in a roomful of unruly men for 7 years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Gloria Tory**
> "“And think about the message it would send. The first woman Vice President in the whole continent! What support you would lose among traditionalists, you would gain tenfold among Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Turn08VPSelectionDecisionOption_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Albin_PromisedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Albin_PromisedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[156]`
Mówca: **Albin Clavin**
> "“I think you already know the answer...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && 
BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  
Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You blocked my reform proposal, Ms. Tory. Why would I pick you as my VP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Gloria Tory**
> ""This would be your chance to make amends with the party, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I simply can't forget that you worked against our constitutional reforms, Ms. Tory. I don't think we are aligned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Gloria Tory**
> ""I understand. But that is politics, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not so sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you mean like the constitutional proposal where you didn't even say a word when Ms. Tory confronted me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Albin Clavin**
> ""Come on, Mr. President. You knew my position there. There was nothing I could do to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Albin Clavin**
> ""But I believe we can achieve great things together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[177]`
Mówca: **Albin Clavin**
> ""Besides, it all worked out great in the end, didn't it? We have successfully changed the constitution. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false && BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_Gloria_Convinced == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You tried to block my reform proposal, Ms. Tory. Why would I pick you as my VP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_Reform_AssemblyVote_Success == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Amendment_USP_Gloria_Convinced == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Amendment_USP_Gloria_Convinced"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In exchange for your support? You blocked my reform proposal together with Ms. Tory. What promise are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In exchange for your support? You tried to block my reform proposal together with Ms. Tory. What promise are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Albin Clavin**
> ""Come on, Mr. President. You knew there wasn't anything I could do then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Albin Clavin**
> ""My efforts may not have been enough, but that doesn't mean I did not vote for your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Albin Clavin**
> ""And I still believe we can work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think you have a chance, Mr. Clavin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Albin Clavin**
> "“That is disappointing to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what have you been doing while the party has been obstructing my every move?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Albin Clavin**
> "“Mr. President. I've been fighting my own fight against the establishment within the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Albin Clavin**
> ""The USP reformists aren't really a part of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
