# Sordland/Turn07/Kesaro&FrensDialogue

- **ID konwersacji:** `97`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/097_Kesaro&FrensDialogue.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 37

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[32]** Frens Ricter
- **[38]** Lucian Galade
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Amendment_PFJP_GivenLeaderCredit`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Alliance`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Relations_Kesaro_Promise_Alliance`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Relations_Frens_Promise_Alliance`
- `BaseGameSupport.Journal_Turn07_PromisedFrensAlliance`
- `BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[94] Sordland/Turn07/A_AssemblyVote_ResultsMeeting** (../Turn_07/094_A_AssemblyVote_ResultsMeeting.md), Węzeł `[7]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Frens_Promise_Alliance`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[85]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] = true;`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Frens_Promise_Alliance"] = true;`
- Węzeł `[163]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_PromisedFrensAlliance"] = true;`
- Węzeł `[164]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `94` (*Sordland/Turn07/A_AssemblyVote_ResultsMeeting*), Węzeł `[7]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We're doing good, Frens. Enjoying the victory at the Assembly.""]** — Mówca: **Player**
> ""We're doing good, Frens. Enjoying the victory at the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Lucian suddenly turned around and pointed at the side entrance to the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Look who's coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "It was Kesaro Kibener. He slowly walked up to us with a smile on his face and spread his arms wide as he approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "It was Frens Ricter. He slowly walked up to us with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Kesaro Kibener**
> ""Here you are!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[12]`
Mówca: **Frens Ricter**
> ""Afternoon, gentlemen. How are you all doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Afternoon, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Busy as always, Mr. Ricter. How about you?""]** — Mówca: **Player**
> ""Busy as always, Mr. Ricter. How about you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""You should've let me know you were coming out. I would've planned a barbecue or something.""]** — Mówca: **Player**
> ""You should've let me know you were coming out. I would've planned a barbecue or something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Frens Ricter**
> ""Oh yes. I should congratulate you again for passing the proposal. You deserved it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Frens Ricter**
> ""The same goes for me, Mr. President. These are some busy days indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
Mówca: **Frens Ricter**
> ""Hah. No need for that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""I also hope you will do something about your promise at some point, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""We should also thank you for your efforts. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""Especially after that mutual victory. We should thank you for your efforts, Mr. Ricter. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""We should thank you for your efforts. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Frens bowed his head slightly in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[24]`
Mówca: **Kesaro Kibener**
> ""The most dangerous men in the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Afternoon, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Damn right, we're dangerous.""]** — Mówca: **Player**
> ""Damn right, we're dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Welcome, Mr. Kibener. How are you doing?""]** — Mówca: **Player**
> ""Welcome, Mr. Kibener. How are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""You should've let me know you were coming out. I would've planned a barbecue or something.""]** — Mówca: **Player**
> ""You should've let me know you were coming out. I would've planned a barbecue or something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""Lock up your daughters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Petr laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""I'm good, Mr President. You must be feeling similarly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""Our cooperation yielded spectacular results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Kesaro Kibener**
> ""Goddamn. This sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Kesaro squinted into the bright sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He reached down to his pocket, pulled out a pair of sunglasses and set them on his nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Kesaro Kibener**
> ""Did you three figure out the Court situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""Most of them have been resisting our efforts. But we're working on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""It's not looking good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[40]`
  - -> `[39]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Don't worry. We've got this.""]** — Mówca: **Player**
> ""Don't worry. We've got this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We'll figure it out, Mr. Kibener. I'll be talking to several of the Justices very soon.""]** — Mówca: **Player**
> ""We'll figure it out, Mr. Kibener. I'll be talking to several of the Justices very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""To be honest, it's not.""]** — Mówca: **Player**
> ""To be honest, it's not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Seat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Seat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Seat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Seat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[45]`
Mówca: **Frens Ricter**
> ""I'm looking forward to having many more cooperations between us. And victories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Lucian and Petr looked at me. I could feel Lucian's suspicious gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Narrator**
> "He leaned towards me and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. Rest assured.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. Rest assured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""The time will come.""]** — Mówca: **Player**
> ""The time will come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""We'll see.""]** — Mówca: **Player**
> ""We'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""I'll be waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Frens Ricter**
> ""We most certainly will, Mr. President. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Frens Ricter**
> ""I wish you good luck with the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He straightened up again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[58]`
Mówca: **Frens Ricter**
> ""I have conversed with Mrs. Morgna and Justice Zizek. We have at least three Justices supporting the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Frens Ricter**
> ""I hope everything works out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[63]`
Mówca: **Frens Ricter**
> ""We must be united if we want to break them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Frens Ricter**
> ""We must also be *seen* as united more than ever. Therefore, I'd like to propose a proper alliance for the next elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Kesaro Kibener**
> ""But we're moving forward with our alliance, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[72]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""Well I hope you do something about it. It's not like the Justices are big fans of this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""It's not the time for that. We must first pass the Court.""]** — Mówca: **Player**
> ""It's not the time for that. We must first pass the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Of course, Kesaro.""]** — Mówca: **Player**
> ""Of course, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Yes, Mr. Kibener. We'll announce our alliance as promised.""]** — Mówca: **Player**
> ""Yes, Mr. Kibener. We'll announce our alliance as promised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Kesaro Kibener**
> ""I might also be able to help with this whole Court situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Kesaro Kibener**
> ""I know Mr. Garaci well. I know that he said that he's not open to any talks before the vote but... I'm sure I can convince him to meet with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[78]`
  - -> `[77]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I don't want to do any business with that man.""]** — Mówca: **Player**
> ""I don't want to do any business with that man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""That's good news. Can I count on you to bring him to the table?""]** — Mówca: **Player**
> ""That's good news. Can I count on you to bring him to the table?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""That would be very much appreciated, Mr. Kibener.""]** — Mówca: **Player**
> ""That would be very much appreciated, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian leaned in towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""Sir, I advise you to reconsider. We need his help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Kesaro awaited my response, his expression unreadable behind his sunglasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`

### Węzeł `[84]`
Mówca: **Kesaro Kibener**
> ""Of course. I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Heron_SentKesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Yes. Really. We don't need the Old Guard's help. We need them gone.""]** — Mówca: **Player**
> ""Yes. Really. We don't need the Old Guard's help. We need them gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""So, can I really count on you to bring him to the table?""]** — Mówca: **Player**
> ""So, can I really count on you to bring him to the table?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[88]`
Mówca: **Kesaro Kibener**
> ""How can you get rid of them if you cannot even change the Constitution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""Anyway, I'll leave you three to whatever you were conspiring to before I came.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Kesaro Kibener**
> ""I guess you have a plan. I'll trust you on this for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[92]`
Mówca: **Kesaro Kibener**
> ""The heat here is killing me. We should catch up soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "He walked back to the door and left the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[94]`
Mówca: **Frens Ricter**
> ""And more in-depth collaboration throughout the rest of the current term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`
  - -> `[95]`
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""An alliance with the main opposition is too big of a deal. I'm afraid that's not an option.""]** — Mówca: **Player**
> ""An alliance with the main opposition is too big of a deal. I'm afraid that's not an option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I'd love to accept such a proposal, Mr. Ricter.""]** — Mówca: **Player**
> ""I'd love to accept such a proposal, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""That's what I was waiting for. We need a proper alliance.""]** — Mówca: **Player**
> ""That's what I was waiting for. We need a proper alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""I'm glad we were able to work together on the new Constitution. But that's the extent of our collaboration.""]** — Mówca: **Player**
> ""I'm glad we were able to work together on the new Constitution. But that's the extent of our collaboration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Frens Ricter**
> ""It would surely put pressure on the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Frens Ricter**
> ""Such a grand coalition has never happened in Sordland before. We should show people that our parties can work together. That civility and cooperation is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""It would surely have a great symbolic meaning. Especially if we can change the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Frens Ricter**
> ""As I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Frens Ricter**
> ""I'll reach out to you soon about it. We must start organizing and announce it as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""Thank you for the offer nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Frens reached down at his pocket, fumbled with a handkerchief and wiped the sweat of his forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Frens Ricter**
> ""Anyway, I'll leave you three to it. We should catch up soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Frens Ricter**
> ""I'd rather get back inside now. The sun is getting intense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He walked back to the door and left the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Petr Vectern**
> ""Well. That was interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""So we are seriously joining forces with the PFJP, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""Look at him go. He's such a clown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""He seriously wanted an alliance with the USP? That's new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""He wants to take the credit for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""If it passes, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""]** — Mówca: **Player**
> ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I believe that will only be beneficial for our position.""]** — Mówca: **Player**
> ""I believe that will only be beneficial for our position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Yes. Sordland needs to experience some democracy.""]** — Mówca: **Player**
> ""Yes. Sordland needs to experience some democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
Mówca: **Petr Vectern**
> ""Gotcha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""Actually, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""A coalition government could make things much more difficult for us though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""But a coalition government could make things much more difficult for us down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Petr is not entirely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""Entirely? What is that supposed to mean? There's nothing wro-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""A coalition government with the PFJP can mean a lot of things. But one thing is for sure: once Mr. Ricter enters our government, it will be hard to get him to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
> ""We should be careful, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I respect the man. But he's overestimating himself.""]** — Mówca: **Player**
> ""I respect the man. But he's overestimating himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""He'll get the credit in his dreams.""]** — Mówca: **Player**
> ""He'll get the credit in his dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""We don't need him anymore.""]** — Mówca: **Player**
> ""We don't need him anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""Damn right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""He has a tendency to play the 'nice guy'. When not playing the victim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Kesaro_Promise_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""Look at him go. That man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""I don't trust him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""He wants to take the credit for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""Well. That was interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Petr Vectern**
> ""So we are seriously joining forces with the NFP, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[149]`
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""Damn right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""Entirely? What is that supposed to mean? There's nothing wro-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""If it passes, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[155]`
  - -> `[156]`
  - -> `[159]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""We don't need him anymore.""]** — Mówca: **Player**
> ""We don't need him anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""]** — Mówca: **Player**
> ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I believe it will only be beneficial for us.""]** — Mówca: **Player**
> ""I believe it will only be beneficial for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""He's just playing the hero, sir. The honorable Sord against all odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""Gotcha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[152]`
Mówca: **Petr Vectern**
> ""But a coalition government could also make things much more difficult for us down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[153]`
Mówca: **Petr Vectern**
> ""Actually, I kind of agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Yes. Sordland needs to see different parties working together for once.""]** — Mówca: **Player**
> ""Yes. Sordland needs to see different parties working together for once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""He'll get the credit in his dreams.""]** — Mówca: **Player**
> ""He'll get the credit in his dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[156]`
**[WYBÓR GRACZA: ""I respect the man. But he's overestimating himself.""]** — Mówca: **Player**
> ""I respect the man. But he's overestimating himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""A coalition government could make things much more difficult for us though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
> ""Petr is not entirely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Whatever you say, we need Kesaro on our side.""]** — Mówca: **Player**
> ""Whatever you say, we need Kesaro on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""I can't object to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""A coalition government with the NFP can mean a lot of things. But one thing is for sure, Mr. Kibener is a dangerous man. He'll use all the power we give him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""We should be careful, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_PromisedFrensAlliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_PromisedFrensAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[168]`
Mówca: **Frens Ricter**
> ""I have conversed with Mrs. Morgna and Justice Zizek. We have at least two Justices supporting the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_PFJP_GivenLeaderCredit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_PFJP_GivenLeaderCredit == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Amendment_PFJP_GivenLeaderCredit == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[172]`
Mówca: **Petr Vectern**
> ""You shouldn't have given him all the credit for the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""He's already acting all high and mighty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Lucian Galade**
> ""He'll be enjoying great popularity for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_PFJP_GivenLeaderCredit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Amendment_PFJP_GivenLeaderCredit == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Amendment_PFJP_GivenLeaderCredit == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[178]`
Mówca: **Petr Vectern**
> ""It wasn't enough that he got all the credit for the reforms and now we are joining our hands, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`
  - -> `[120]`
