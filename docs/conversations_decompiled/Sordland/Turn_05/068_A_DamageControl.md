# Sordland/Turn05/A_DamageControl

- **ID konwersacji:** `68`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/068_A_DamageControl.md`
- **Liczba węzłów dialogowych:** 207
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[37]** Curtan Leste
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Turn05_Admin_Media_Influenced`
- `BaseGame.Turn05_Admin_News_Contained`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn05_Admin_Media_Influenced`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_Admin_News_Contained`
- `BaseGameIsolated.Turn05_Admin_Mayor_Apology`
- `BaseGameIsolated.Turn05_Admin_Mayor_Media`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal`
- `BaseGameSupport.Journal_Turn05_Scandal_MediaUsed`
- `GameCondition.Turn05_A_DamageControl`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[80]` (Lucian Galade): `Variable["BaseGame.Turn05_Admin_News_Contained"] = true; Variable["BaseGameSupport.Journal_Turn05...`
- Węzeł `[93]` (Lucian Galade): `Variable["BaseGame.Turn05_Admin_Media_Influenced"] = true;`
- Węzeł `[116]` (Lucian Galade): `Variable["GameCondition.Turn05_A_DamageControl"] = true;`
- Węzeł `[151]` (Lucian Galade): `Variable["BaseGame.Turn05_Admin_Monica_Barred"] = true; Variable["BaseGameSupport.Journal_Turn05_...`
- Węzeł `[155]` (Lucian Galade): `Variable["BaseGame.Turn05_Admin_News_Contained"] = true;`
- Węzeł `[167]` (Lucian Galade): `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Media"] = true;`
- Węzeł `[184]` (Lucian Galade): `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Apology"] = true;`
- Węzeł `[205]` (Lucian Galade): `PlayCustomMapMusic("Map_Music_Tense"); -- Plays a custom map music after conversation is done. Th...`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The sun was just beginning to rise as Lucian, Petr and I gathered in my office to discuss the fallout of the Benfi Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“The news is about to break, even as we speak. We must act swiftly to protect the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Petr Vectern**
> "“Agreed. This isn't good, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“The most important thing is the narrative. We need to regain control of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""He also has incredible influence over the USP's conservative wing, including our MP's. We've got to act before he rallies the others against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> "“At the same time, you must not apologize yourself. Insulting the First Lady is an act that should not go unpunished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[14]`
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""You've got that right. How dare he insult my wife!”"]** — Mówca: **Player**
> ""You've got that right. How dare he insult my wife!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“We could talk with him. Try to defuse the situation.""]** — Mówca: **Player**
> "“We could talk with him. Try to defuse the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“He and his conservative cronies won't be able to stand up to the full force of our administration.”"]** — Mówca: **Player**
> "“He and his conservative cronies won't be able to stand up to the full force of our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Exactly. A show of force could weaken his position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[16]`
Mówca: **Petr Vectern**
> "“It was unacceptable. Monica didn't deserve that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“Engaging in talks has a chance of backfiring, but it could be the simplest solution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“Perhaps she was allowed a little too much autonomy with her speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""He acted like an ass, too. Maybe you can both come out of this looking good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“Maybe. Or just get him to dig in harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“How should we proceed, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[199]`
  - -> `[6]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“We will request a formal apology from Curtan.”"]** — Mówca: **Player**
> "“We will request a formal apology from Curtan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I'm going to call Marcel Koronti. We have our deal -- let's put it to use.""]** — Mówca: **Player**
> "“I'm going to call Marcel Koronti. We have our deal -- let's put it to use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Our deal with Marcel Koronti might be a solution.”"]** — Mówca: **Player**
> "“Our deal with Marcel Koronti might be a solution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“That would be the most ideal option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""I still don't trust that man further than I could throw him. But he might prove useful in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I don't expect much compliance after you forcefully removed him from the venue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Excellent choice. With his influence on the media, this could be contained fairly easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“I was wondering when you would call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[158]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Petr left the room and came back with Livia. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“Maybe he's had time to cool off. I'll ask Livia to get him on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""I'm still skeptical about this. But fine. I'll fetch Livia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Were you expecting me to?”"]** — Mówca: **Player**
> "“Were you expecting me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“You seem to have forgotten how to greet people with respect.”"]** — Mówca: **Player**
> "“You seem to have forgotten how to greet people with respect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[38]`
Mówca: **Marcel Koronti**
> "“Of course I was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Curtan. I am calling to extend the olive branch.”"]** — Mówca: **Player**
> "“Curtan. I am calling to extend the olive branch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Curtan Leste**
> "“What do you want, Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[140]`

### Węzeł `[41]`
Mówca: **Curtan Leste**
> "“Is that so?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“You insulted my wife. Would you have acted differently if the roles were reversed?”"]** — Mówca: **Player**
> "“You insulted my wife. Would you have acted differently if the roles were reversed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It was a mistake. A grave one at that.”"]** — Mówca: **Player**
> "“It was a mistake. A grave one at that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Curtan Leste**
> "“At the very least, you have the courage to accept that it was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
Mówca: **Curtan Leste**
> "“She insulted our culture and heritage. I only protected our values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Curtan Leste**
> "“Wrong decision. I am disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Let's put all of this behind us.”"]** — Mówca: **Player**
> "“Let's put all of this behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I called you for a resolution.”"]** — Mówca: **Player**
> "“I called you for a resolution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Do you want a solution or not?”"]** — Mówca: **Player**
> "“Do you want a solution or not?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[50]`
Mówca: **Narrator**
> "He paused. The ball was in my court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Curtan Leste**
> "“Let's see how you like the press hearing about the loss of Anrica to the National Front.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You piece of shit!”"]** — Mówca: **Player**
> "“You piece of shit!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“You just made a very powerful enemy.”"]** — Mówca: **Player**
> "“You just made a very powerful enemy. Don't forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Curtan Leste**
> "“You seem to be surrounded by more and more enemies these days, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "Hang up the phone."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Curtan Leste hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“That's going to have consequences. Is there anything else we can do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“That went worse than expected. We've lost the chance to control the narrative, and we've lost a city to another party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_News_Contained == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“That went far better than expected. We have both our apology and a chance to change the narrative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“I can't believe you agreed to keep Monica out of politics. She won't take that well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Lucian departed, which left me and Petr in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[107]`
  - -> `[108]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> "“I'll start working on our official response to his apology, to paint us in the best light possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
Mówca: **Curtan Leste**
> "“Manners, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“We're running out of time for pleasantries, aren't we, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Think about this, Marcel. You don't want me on the other side of the fence.”"]** — Mówca: **Player**
> "“Think about this, Marcel. You don't want me on the other side of the fence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> "“I've just seen the proofs for Sordland Today. It seems your incident with poor Mayor Leste is about to make headlines.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“What about the other papers?”"]** — Mówca: **Player**
> "“What about the other papers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“We had a deal. I hope you have not forgotten.”"]** — Mówca: **Player**
> "“We had a deal. I hope you have not forgotten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“I know I don't. We have a deal. after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“Deyr Journal, The Radical, Holsord Post and Lachaven Times are all prepared to print the story on the front page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Of course not. Mutual respect between partners is a must.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“I take it that you want this contained, if not completely gone?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I only want to minimize the damage. The less prominent the story, the better.”"]** — Mówca: **Player**
> "“I only want to minimize the damage. The less prominent the story, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I want it gone.”"]** — Mówca: **Player**
> "“I want it gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“That's certainly within the realm of possibility. I can have you banished to the back pages in the next hour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“Alas, the event is too newsworthy to receive no coverage. But I can have you banished to the back pages in the next hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained = true; BaseGameSupport.Journal_Turn05_Scandal_MediaUsed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_MediaUsed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“How disappointing.”"]** — Mówca: **Player**
> "“How disappointing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Your promise was about erasing mistakes.”"]** — Mówca: **Player**
> "“Your promise was about erasing mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Do you think this could blow out of proportion?”"]** — Mówca: **Player**
> "“Do you think this could blow out of proportion?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“And what would you want from me in return?”"]** — Mówca: **Player**
> "“And what would you want from me in return?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> ""Oh, we'll worry about that when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“I'm not a Saint, Mr. President. I can not perform miracles. I too have my limits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“A president replacing an invited speaker with his own wife, then forcing him out of the ceremony itself? It might go international.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Thank you again.”"]** — Mówca: **Player**
> "“Thank you again. Have a good day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Looking forward to the results.”"]** — Mówca: **Player**
> "“Looking forward to the results. Enjoy your day, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“If this... partnership comes to light, it would be an even bigger scandal.”"]** — Mówca: **Player**
> "“If this... partnership comes to light, it would be an even bigger scandal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Yes. Handle the situation immediately.”"]** — Mówca: **Player**
> "“Yes. Handle the situation immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Marcel Koronti**
> "“So, do you want me to get to work?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[94]`
Mówca: **Petr Vectern**
> "“Time to go into full damage control. This ought to end well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“I know Mr. Koronti may have dubious intentions, but it's going to be difficult to contain this media backlash on our own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Well in that case, I have no reason to be talking to you right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Marcel hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“Good luck to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> ""After that, making the necessary changes to my own publication should be no trouble at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[100]`
Mówca: **Marcel Koronti**
> "“Perfect. I'll call my contacts at the other papers first -- I should be able to persuade them to downplay the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“Don't you worry. Until next time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Media_Influenced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
> "“I'm surprised he was so enthusiastic about it. But either way, he just made our lives easier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“I knew this partnership was the right decision. Mr. Koronti should be able to keep the incident under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Any plans for the holiday next month?”"]** — Mówca: **Player**
> "“Any plans for the holiday next month?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“How are things between you and Evelyn?”"]** — Mówca: **Player**
> "“How are things between you and Evelyn?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Petr Vectern**
> "“Ha. More of this, I suppose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[110]`
Mówca: **Petr Vectern**
> "“They're a little better, thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“How are the upcoming trade deals for Agnolia and Wehlen coming along?”"]** — Mówca: **Player**
> "“How are the upcoming trade deals for Agnolia and Wehlen coming along?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> "“As well as expected. They had their own concerns, but they'll fall in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[113]`
Mówca: **Petr Vectern**
> "“It's been a while since we had a drink or two together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[166]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Yes, it's been far too long. Shall we?”"]** — Mówca: **Player**
> "“Yes, it's been far too long. Shall we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Maybe later.”"]** — Mówca: **Player**
> "“Maybe later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_A_DamageControl = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_A_DamageControl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> "“Right now Leste looks like the victim -- harangued for defending Sordland's precious cultural values until he had no choice but to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“If Sordland Today paints you in a favorable light, other publications are bound to follow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[119]`
Mówca: **Curtan Leste**
> "“Enjoy the fallout.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[120]`
Mówca: **Curtan Leste**
> "“What makes you think that I will hear anything you say? You had me thrown out, for God's sake!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`

### Węzeł `[121]`
Mówca: **Narrator**
> "At that very moment, the phone began to ring. The news was out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[122]`
Mówca: **Livia Suno**
> "“I'll let you know once I have him on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[123]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you with the mayor directly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Curtan had definitely not cooled off. I did not like his tone at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Yes please.”"]** — Mówca: **Player**
> "“Yes please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the phone line lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[128]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Livia Suno**
> "“I hope you won't make any compromises with Mr. Leste. He behaved like a pig at the festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Marcel Koronti, the CEO of the HOS Conglomerate, was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the telephone lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[132]`
Mówca: **Livia Suno**
> "“To be honest, though, I think you should keep this deal in your pocket until you have a scandal worth covering up. Leste was completely in the wrong here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[133]`
Mówca: **Livia Suno**
> "“I'll let you know once I have him on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[134]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you to Mr. Koronti directly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“Yes, please.”"]** — Mówca: **Player**
> "“Yes, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[137]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Petr left the room and came back with my secretary. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Mayor Curtan Leste's untimely departure was bound to reflect badly on me. The only question was how much damage the incident would cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I demand a public and formal apology for your behavior at the festival.""]** — Mówca: **Player**
> "“I demand a public and formal apology for your behavior at the festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Curtan Leste**
> "“Is that so? You've got some nerve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[142]`
Mówca: **Curtan Leste**
> "“Why would I possibly apologize to you? You had me thrown out, for God's sake!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`

### Węzeł `[143]`
Mówca: **Curtan Leste**
> "“That depends on you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Curtan Leste**
> "“Here is my demand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Curtan Leste**
> "“The First Lady won't be allowed to meddle in politics from now on. No meetings. No advocating for her little causes. And certainly no speeches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Curtan Leste**
> "“Should you fail to keep her from doing so, you can say your goodbyes to Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Curtan Leste**
> ""On the other hand, if you do this, I will issue a full apology and your party will retain my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Curtan Leste**
> "“What will it be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[149]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“You leave me no choice. I'll tell Monica she's out of politics.""]** — Mówca: **Player**
> "“You leave me no choice. I'll tell Monica she's out of politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“I refuse. You are the one who is in the wrong. I won't punish her for your crimes.”"]** — Mówca: **Player**
> "“I refuse. You are the one who is in the wrong. I won't punish her for your crimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Curtan Leste**
> "“I'm glad that we came to terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Curtan Leste**
> "“I will announce my public apology to the press immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Curtan Leste**
> "“Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“I will be waiting for it.”"]** — Mówca: **Player**
> "“I will be waiting for it. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Don't get cocky.”"]** — Mówca: **Player**
> "“Don't get cocky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Marcel Koronti**
> "“Apologies for my behaviour, Mr. President, but we both know that time is of the essence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[160]`
Mówca: **Marcel Koronti**
> "“But in times like these, I'm your personal lord and savior. You know that. Otherwise you wouldn't have called.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[161]`
Mówca: **Marcel Koronti**
> "“That is a big *if*, Mr. President, compared to what is happening *now*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Marcel Koronti**
> "“But it is your decision. So what will it be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Handle the situation immediately.”"]** — Mówca: **Player**
> "“Handle the situation immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“I changed my mind. It's too risky.”"]** — Mówca: **Player**
> "“I changed my mind. It's too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[165]`
Mówca: **Narrator**
> "He leaned back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "“For God's sake, Petr, it's six in the morning!”"]** — Mówca: **Player**
> "“For God's sake, Petr, it's six in the morning!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[168]`
Mówca: **Petr Vectern**
> "“Right now Leste looks like the victim, thrown out of the festival for defending Sordland's precious cultural values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
> ""Considering he opted to leave the venue rather than deliver an apology last night, I would hardly expect one from him now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[175]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[181]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Curtan Leste**
> "“What makes you think that I will hear anything you say? You humiliated me in front of my entire home city!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`

### Węzeł `[183]`
Mówca: **Curtan Leste**
> "“Why would I possibly apologize to you? You humiliated me in front of my entire home city!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_Admin_Mayor_Apology = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Apology"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""Talk to Koronti, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""A compromise may be necessary, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“That does not look like it went good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Petr Vectern**
> "“Is there anything else we can do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“We could give a call to Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“Unfortunately, I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Agreed. Let's do it.”"]** — Mówca: **Player**
> "“Agreed. Let's do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“No. We will manage without him.”"]** — Mówca: **Player**
> "“No. We will manage without him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Let's just talk to him. He can't stay angry forever.”"]** — Mówca: **Player**
> "“Let's just talk to him. He can't stay angry forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""Considering he opted to leave the venue rather than deliver an apology last night, I would hardly expect anything from him now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[201]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
> "“I don't expect much compliance after you forcefully removed him from the venue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[205]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
