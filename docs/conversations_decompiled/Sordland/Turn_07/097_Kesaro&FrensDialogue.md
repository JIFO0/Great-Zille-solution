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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""We're doing good, Frens. Enjoying the victory at the Assembly.""** | `[13]` **Petr Vectern**: ""Afternoon, Mr. Ricter."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Frens Ricter**: ""Oh yes. I should congratulate y..." |
| `[14]` | **""Busy as always, Mr. Ricter. How about you?""** | `[13]` **Petr Vectern**: ""Afternoon, Mr. Ricter."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Frens Ricter**: ""The same goes for me, Mr. Presi..." |
| `[15]` | **""You should've let me know you were coming out. I would've planned a barbecue or s..."** | `[13]` **Petr Vectern**: ""Afternoon, Mr. Ricter."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Frens Ricter**: ""Hah. No need for that, Mr. Pres..." |
| `[26]` | **""Damn right, we're dangerous.""** | `[25]` **Petr Vectern**: ""Afternoon, Mr. Kibener."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Petr Vectern**: ""Lock up your daughters."" |
| `[27]` | **""Welcome, Mr. Kibener. How are you doing?""** | `[25]` **Petr Vectern**: ""Afternoon, Mr. Kibener."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Kesaro Kibener**: ""I'm good, Mr President. You mus..." |
| `[28]` | **""You should've let me know you were coming out. I would've planned a barbecue or s..."** | `[25]` **Petr Vectern**: ""Afternoon, Mr. Kibener."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Kesaro squinted into the bright ..." |
| `[39]` | **""Don't worry. We've got this.""** | `[38]` **Kesaro Kibener**: ""It's not looking good?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Kesaro Kibener**: ""I see."" |
| `[40]` | **""We'll figure it out, Mr. Kibener. I'll be talking to several of the Justices very..."** | `[38]` **Kesaro Kibener**: ""It's not looking good?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Kesaro Kibener**: ""I see."" |
| `[41]` | **""To be honest, it's not.""** | `[38]` **Kesaro Kibener**: ""It's not looking good?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Kesaro Kibener**: ""I see."" |
| `[48]` | **""Of course, Mr. Ricter. Rest assured.""** | `[46]` **Narrator**: "Lucian and Petr looked at me. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Frens Ricter**: ""I'll be waiting."" |
| `[49]` | **""The time will come.""** | `[46]` **Narrator**: "Lucian and Petr looked at me. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Frens Ricter**: ""I'll be waiting."" |
| `[50]` | **""We'll see.""** | `[46]` **Narrator**: "Lucian and Petr looked at me. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Frens Ricter**: ""We most certainly will, Mr. Pre..." |
| `[71]` | **""It's not the time for that. We must first pass the Court.""** | `[69]` **Kesaro Kibener**: ""But we're moving forward with o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Kesaro Kibener**: ""I might also be able to help wi..." |
| `[72]` | **""Of course, Kesaro.""** | `[69]` **Kesaro Kibener**: ""But we're moving forward with o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Kesaro Kibener**: ""I'm looking forward to it."" |
| `[73]` | **""Yes, Mr. Kibener. We'll announce our alliance as promised.""** | `[69]` **Kesaro Kibener**: ""But we're moving forward with o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Kesaro Kibener**: ""I'm looking forward to it."" |
| `[77]` | **""I don't want to do any business with that man.""** | `[76]` **Kesaro Kibener**: ""I know Mr. Garaci well. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Kesaro Kibener**: ""Really?"" |
| `[78]` | **""That's good news. Can I count on you to bring him to the table?""** | `[76]` **Kesaro Kibener**: ""I know Mr. Garaci well. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Kesaro Kibener**: ""Of course. I'll do my best."" |
| `[79]` | **""That would be very much appreciated, Mr. Kibener.""** | `[76]` **Kesaro Kibener**: ""I know Mr. Garaci well. I know ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Kesaro Kibener**: ""Of course. I'll do my best."" |
| `[86]` | **""Yes. Really. We don't need the Old Guard's help. We need them gone.""** | `[83]` **Narrator**: "Kesaro awaited my response, his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Kesaro Kibener**: ""How can you get rid of them if ..." |
| `[87]` | **""So, can I really count on you to bring him to the table?""** | `[83]` **Narrator**: "Kesaro awaited my response, his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Kesaro Kibener**: ""Of course. I'll do my best."" |
| `[95]` | **""An alliance with the main opposition is too big of a deal. I'm afraid that's not ..."** | `[94]` **Frens Ricter**: ""And more in-depth collaboration..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Frens Ricter**: ""As I expected."" |
| `[96]` | **""I'd love to accept such a proposal, Mr. Ricter.""** | `[94]` **Frens Ricter**: ""And more in-depth collaboration..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Frens Ricter**: ""That's great to hear."" |
| `[97]` | **""That's what I was waiting for. We need a proper alliance.""** | `[94]` **Frens Ricter**: ""And more in-depth collaboration..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Frens Ricter**: ""It would surely put pressure on..." |
| `[98]` | **""I'm glad we were able to work together on the new Constitution. But that's the ex..."** | `[94]` **Frens Ricter**: ""And more in-depth collaboration..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Frens Ricter**: ""As I expected."" |
| `[120]` | **""I'm not sure how deep we'll dive in. For now, we'll cooperate.""** | `[115]` **Petr Vectern**: ""So we are seriously joining for..."<br>`[178]` **Petr Vectern**: ""It wasn't enough that he got al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Petr Vectern**: ""Gotcha."" |
| `[121]` | **""I believe that will only be beneficial for our position.""** | `[115]` **Petr Vectern**: ""So we are seriously joining for..."<br>`[178]` **Petr Vectern**: ""It wasn't enough that he got al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Petr Vectern**: ""Actually, I agree."" |
| `[122]` | **""Yes. Sordland needs to experience some democracy.""** | `[115]` **Petr Vectern**: ""So we are seriously joining for..."<br>`[178]` **Petr Vectern**: ""It wasn't enough that he got al..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Petr Vectern**: ""A coalition government could ma..." |
| `[131]` | **""I respect the man. But he's overestimating himself.""** | `[119]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Lucian Galade**: ""He has a tendency to play the '..." |
| `[132]` | **""He'll get the credit in his dreams.""** | `[119]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Petr Vectern**: ""Damn right."" |
| `[133]` | **""We don't need him anymore.""** | `[119]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Petr Vectern**: ""Damn right."" |
| `[147]` | **""We don't need him anymore.""** | `[146]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Petr Vectern**: ""Damn right."" |
| `[148]` | **""I'm not sure how deep we'll dive in. For now, we'll cooperate.""** | `[143]` **Petr Vectern**: ""So we are seriously joining for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Petr Vectern**: ""Gotcha."" |
| `[149]` | **""I believe it will only be beneficial for us.""** | `[143]` **Petr Vectern**: ""So we are seriously joining for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Petr Vectern**: ""Actually, I kind of agree."" |
| `[154]` | **""Yes. Sordland needs to see different parties working together for once.""** | `[143]` **Petr Vectern**: ""So we are seriously joining for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Petr Vectern**: ""A coalition government could ma..." |
| `[155]` | **""He'll get the credit in his dreams.""** | `[146]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Petr Vectern**: ""Damn right."" |
| `[156]` | **""I respect the man. But he's overestimating himself.""** | `[146]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: ""He's just playing the hero, sir..." |
| `[159]` | **""Whatever you say, we need Kesaro on our side.""** | `[146]` **Lucian Galade**: ""If it passes, that is."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lucian Galade**: ""I can't object to that."" |

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
  - -> `[4]` (*Narrator: "Lucian suddenly turned around and pointed at the side ent..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""We're doing good, Frens. Enjoying the victory at the Assembly.""]** — Mówca: **Player**
> ""We're doing good, Frens. Enjoying the victory at the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Frens Ricter: ""Oh yes. I should congratulate you again for passing the ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Lucian suddenly turned around and pointed at the side entrance to the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""Look who's coming.""*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Look who's coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "It was Kesaro Kibener. He slowly walked up to us with a s..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "It was Frens Ricter. He slowly walked up to us with a smi..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "It was Kesaro Kibener. He slowly walked up to us with a smile on his face and spread his arms wide as he approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Kesaro Kibener: ""Here you are!""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "It was Frens Ricter. He slowly walked up to us with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Frens Ricter: ""Afternoon, gentlemen. How are you all doing?""*)

### Węzeł `[11]`
Mówca: **Kesaro Kibener**
> ""Here you are!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Kesaro Kibener: ""The most dangerous men in the Maroon Palace.""*)

### Węzeł `[12]`
Mówca: **Frens Ricter**
> ""Afternoon, gentlemen. How are you all doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Afternoon, Mr. Ricter.""*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Afternoon, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""We're doing good, Frens. Enjoying the victory at the Ass..."*)
  - -> `[14]` (*Player: ""Busy as always, Mr. Ricter. How about you?""*)
  - -> `[15]` (*Player: ""You should've let me know you were coming out. I would'v..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Busy as always, Mr. Ricter. How about you?""]** — Mówca: **Player**
> ""Busy as always, Mr. Ricter. How about you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Frens Ricter: ""The same goes for me, Mr. President. These are some busy..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""You should've let me know you were coming out. I would've planned a barbecue or something.""]** — Mówca: **Player**
> ""You should've let me know you were coming out. I would've planned a barbecue or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Frens Ricter: ""Hah. No need for that, Mr. President.""*)

### Węzeł `[16]`
Mówca: **Frens Ricter**
> ""Oh yes. I should congratulate you again for passing the proposal. You deserved it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: ""We should also thank you for your efforts. You were of t..."*)

### Węzeł `[17]`
Mówca: **Frens Ricter**
> ""The same goes for me, Mr. President. These are some busy days indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: ""Especially after that mutual victory. We should thank yo..."*)

### Węzeł `[18]`
Mówca: **Frens Ricter**
> ""Hah. No need for that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""We should thank you for your efforts. You were of tremen..."*)

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""I also hope you will do something about your promise at some point, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Lucian and Petr looked at me. I could feel Lucian's suspi..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""We should also thank you for your efforts. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Frens bowed his head slightly in response."*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""Especially after that mutual victory. We should thank you for your efforts, Mr. Ricter. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Frens bowed his head slightly in response."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""We should thank you for your efforts. You were of tremendous assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Frens bowed his head slightly in response."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Frens bowed his head slightly in response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Frens Ricter: ""I'm looking forward to having many more cooperations bet..."*)

### Węzeł `[24]`
Mówca: **Kesaro Kibener**
> ""The most dangerous men in the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""Afternoon, Mr. Kibener.""*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""Afternoon, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""Damn right, we're dangerous.""*)
  - -> `[27]` (*Player: ""Welcome, Mr. Kibener. How are you doing?""*)
  - -> `[28]` (*Player: ""You should've let me know you were coming out. I would'v..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Damn right, we're dangerous.""]** — Mówca: **Player**
> ""Damn right, we're dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""Lock up your daughters.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Welcome, Mr. Kibener. How are you doing?""]** — Mówca: **Player**
> ""Welcome, Mr. Kibener. How are you doing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Kesaro Kibener: ""I'm good, Mr President. You must be feeling similarly.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""You should've let me know you were coming out. I would've planned a barbecue or something.""]** — Mówca: **Player**
> ""You should've let me know you were coming out. I would've planned a barbecue or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Kesaro squinted into the bright sunlight."*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""Lock up your daughters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Petr laughed."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Petr laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Kesaro squinted into the bright sunlight."*)

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""I'm good, Mr President. You must be feeling similarly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Kesaro Kibener: ""Our cooperation yielded spectacular results.""*)

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""Our cooperation yielded spectacular results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Kesaro squinted into the bright sunlight."*)

### Węzeł `[33]`
Mówca: **Kesaro Kibener**
> ""Goddamn. This sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He reached down to his pocket, pulled out a pair of sungl..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Kesaro squinted into the bright sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Kesaro Kibener: ""Goddamn. This sun.""*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He reached down to his pocket, pulled out a pair of sunglasses and set them on his nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Kesaro Kibener: ""Did you three figure out the Court situation?""*)

### Węzeł `[36]`
Mówca: **Kesaro Kibener**
> ""Did you three figure out the Court situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""Most of them have been resisting our efforts. But we're ..."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""Most of them have been resisting our efforts. But we're working on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Kesaro Kibener: ""It's not looking good?""*)

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""It's not looking good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""To be honest, it's not.""*)
  - -> `[40]` (*Player: ""We'll figure it out, Mr. Kibener. I'll be talking to sev..."*)
  - -> `[39]` (*Player: ""Don't worry. We've got this.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Don't worry. We've got this.""]** — Mówca: **Player**
> ""Don't worry. We've got this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""I see.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We'll figure it out, Mr. Kibener. I'll be talking to several of the Justices very soon.""]** — Mówca: **Player**
> ""We'll figure it out, Mr. Kibener. I'll be talking to several of the Justices very soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""I see.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""To be honest, it's not.""]** — Mówca: **Player**
> ""To be honest, it's not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""I see.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Seat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Seat == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Seat == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Seat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He leaned towards me and lowered his voice."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Seat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Seat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Frens Ricter: ""I wish you good luck with the Supreme Court.""*)

### Węzeł `[45]`
Mówca: **Frens Ricter**
> ""I'm looking forward to having many more cooperations between us. And victories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Seat == true"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Lucian and Petr looked at me. I could feel Lucian's suspicious gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Of course, Mr. Ricter. Rest assured.""*)
  - -> `[49]` (*Player: ""The time will come.""*)
  - -> `[50]` (*Player: ""We'll see.""*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He leaned towards me and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Frens Ricter: ""I also hope you will do something about your promise at ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. Rest assured.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. Rest assured.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Frens Ricter: ""I'll be waiting.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""The time will come.""]** — Mówca: **Player**
> ""The time will come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Frens Ricter: ""I'll be waiting.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""We'll see.""]** — Mówca: **Player**
> ""We'll see.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Frens Ricter: ""We most certainly will, Mr. President. But anyway...""*)

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""I'll be waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He straightened up again."*)

### Węzeł `[52]`
Mówca: **Frens Ricter**
> ""We most certainly will, Mr. President. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He straightened up again."*)

### Węzeł `[53]`
Mówca: **Frens Ricter**
> ""I wish you good luck with the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He straightened up again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Frens Ricter: ""I wish you good luck with the Supreme Court.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[58]`
Mówca: **Frens Ricter**
> ""I have conversed with Mrs. Morgna and Justice Zizek. We have at least three Justices supporting the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Bribed == true || BaseGame.Rel..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Frens Ricter: ""I hope everything works out.""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Frens_Promise_Taurus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Frens Ricter: ""We must be united if we want to break them.""*)

### Węzeł `[62]`
Mówca: **Frens Ricter**
> ""I hope everything works out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Frens reached down at his pocket, fumbled with a handkerc..."*)

### Węzeł `[63]`
Mówca: **Frens Ricter**
> ""We must be united if we want to break them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Frens Ricter: ""We must also be *seen* as united more than ever. Therefo..."*)

### Węzeł `[64]`
Mówca: **Frens Ricter**
> ""We must also be *seen* as united more than ever. Therefore, I'd like to propose a proper alliance for the next elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Frens Ricter: ""And more in-depth collaboration throughout the rest of t..."*)

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Alliance == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Kesaro Kibener: ""But we're moving forward with our alliance, yes?""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Kesaro Kibener: ""Well I hope you do something about it. It's not like the..."*)

### Węzeł `[69]`
Mówca: **Kesaro Kibener**
> ""But we're moving forward with our alliance, yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""Yes, Mr. Kibener. We'll announce our alliance as promised.""*)
  - -> `[72]` (*Player: ""Of course, Kesaro.""*)
  - -> `[71]` (*Player: ""It's not the time for that. We must first pass the Court.""*)

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""Well I hope you do something about it. It's not like the Justices are big fans of this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Anyway, I'll leave you three to whatever you were conspi..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""It's not the time for that. We must first pass the Court.""]** — Mówca: **Player**
> ""It's not the time for that. We must first pass the Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Kesaro Kibener: ""I might also be able to help with this whole Court situa..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Of course, Kesaro.""]** — Mówca: **Player**
> ""Of course, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Kesaro Kibener: ""I'm looking forward to it.""*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Yes, Mr. Kibener. We'll announce our alliance as promised.""]** — Mówca: **Player**
> ""Yes, Mr. Kibener. We'll announce our alliance as promised.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Kesaro Kibener: ""I'm looking forward to it.""*)

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Kesaro Kibener: ""I might also be able to help with this whole Court situa..."*)

### Węzeł `[75]`
Mówca: **Kesaro Kibener**
> ""I might also be able to help with this whole Court situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Kesaro Kibener: ""I know Mr. Garaci well. I know that he said that he's no..."*)

### Węzeł `[76]`
Mówca: **Kesaro Kibener**
> ""I know Mr. Garaci well. I know that he said that he's not open to any talks before the vote but... I'm sure I can convince him to meet with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""That would be very much appreciated, Mr. Kibener.""*)
  - -> `[78]` (*Player: ""That's good news. Can I count on you to bring him to the..."*)
  - -> `[77]` (*Player: ""I don't want to do any business with that man.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I don't want to do any business with that man.""]** — Mówca: **Player**
> ""I don't want to do any business with that man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Kesaro Kibener: ""Really?""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""That's good news. Can I count on you to bring him to the table?""]** — Mówca: **Player**
> ""That's good news. Can I count on you to bring him to the table?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Kesaro Kibener: ""Of course. I'll do my best.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""That would be very much appreciated, Mr. Kibener.""]** — Mówca: **Player**
> ""That would be very much appreciated, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Kesaro Kibener: ""Of course. I'll do my best.""*)

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lucian leaned in towards me."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian leaned in towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""Sir, I advise you to reconsider. We need his help.""*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""Sir, I advise you to reconsider. We need his help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Kesaro awaited my response, his expression unreadable beh..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Kesaro awaited my response, his expression unreadable behind his sunglasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""So, can I really count on you to bring him to the table?""*)
  - -> `[86]` (*Player: ""Yes. Really. We don't need the Old Guard's help. We need..."*)

### Węzeł `[84]`
Mówca: **Kesaro Kibener**
> ""Of course. I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron ..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Yes. Really. We don't need the Old Guard's help. We need them gone.""]** — Mówca: **Player**
> ""Yes. Really. We don't need the Old Guard's help. We need them gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Kesaro Kibener: ""How can you get rid of them if you cannot even change th..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""So, can I really count on you to bring him to the table?""]** — Mówca: **Player**
> ""So, can I really count on you to bring him to the table?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Kesaro Kibener: ""Of course. I'll do my best.""*)

### Węzeł `[88]`
Mówca: **Kesaro Kibener**
> ""How can you get rid of them if you cannot even change the Constitution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "He sighed."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Kesaro Kibener: ""I guess you have a plan. I'll trust you on this for now.""*)

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""Anyway, I'll leave you three to whatever you were conspiring to before I came.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Kesaro Kibener: ""The heat here is killing me. We should catch up soon.""*)

### Węzeł `[91]`
Mówca: **Kesaro Kibener**
> ""I guess you have a plan. I'll trust you on this for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Anyway, I'll leave you three to whatever you were conspi..."*)

### Węzeł `[92]`
Mówca: **Kesaro Kibener**
> ""The heat here is killing me. We should catch up soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He walked back to the door and left the balcony."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "He walked back to the door and left the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true"*)

### Węzeł `[94]`
Mówca: **Frens Ricter**
> ""And more in-depth collaboration throughout the rest of the current term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""That's what I was waiting for. We need a proper alliance.""*)
  - -> `[96]` (*Player: ""I'd love to accept such a proposal, Mr. Ricter.""*)
  - -> `[95]` (*Player: ""An alliance with the main opposition is too big of a dea..."*)
  - -> `[98]` (*Player: ""I'm glad we were able to work together on the new Consti..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""An alliance with the main opposition is too big of a deal. I'm afraid that's not an option.""]** — Mówca: **Player**
> ""An alliance with the main opposition is too big of a deal. I'm afraid that's not an option.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Frens Ricter: ""As I expected.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I'd love to accept such a proposal, Mr. Ricter.""]** — Mówca: **Player**
> ""I'd love to accept such a proposal, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Frens Ricter: ""That's great to hear.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""That's what I was waiting for. We need a proper alliance.""]** — Mówca: **Player**
> ""That's what I was waiting for. We need a proper alliance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Frens Ricter: ""It would surely put pressure on the Old Guard.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""I'm glad we were able to work together on the new Constitution. But that's the extent of our collaboration.""]** — Mówca: **Player**
> ""I'm glad we were able to work together on the new Constitution. But that's the extent of our collaboration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Frens Ricter: ""As I expected.""*)

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Frens Ricter: ""Such a grand coalition has never happened in Sordland be..."*)

### Węzeł `[100]`
Mówca: **Frens Ricter**
> ""It would surely put pressure on the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Frens Ricter: ""Such a grand coalition has never happened in Sordland be..."*)

### Węzeł `[101]`
Mówca: **Frens Ricter**
> ""Such a grand coalition has never happened in Sordland before. We should show people that our parties can work together. That civility and cooperation is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""It would surely have a great symbolic meaning. Especiall..."*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""It would surely have a great symbolic meaning. Especially if we can change the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance = true"*)

### Węzeł `[103]`
Mówca: **Frens Ricter**
> ""As I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: ""Thank you for the offer nonetheless.""*)

### Węzeł `[104]`
Mówca: **Frens Ricter**
> ""I'll reach out to you soon about it. We must start organizing and announce it as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Frens reached down at his pocket, fumbled with a handkerc..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_PromisedFrensAlliance = true"*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> ""Thank you for the offer nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Frens reached down at his pocket, fumbled with a handkerc..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Frens reached down at his pocket, fumbled with a handkerchief and wiped the sweat of his forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Frens Ricter: ""Anyway, I'll leave you three to it. We should catch up s..."*)

### Węzeł `[108]`
Mówca: **Frens Ricter**
> ""Anyway, I'll leave you three to it. We should catch up soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Frens Ricter: ""I'd rather get back inside now. The sun is getting inten..."*)

### Węzeł `[109]`
Mówca: **Frens Ricter**
> ""I'd rather get back inside now. The sun is getting intense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He walked back to the door and left the balcony."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He walked back to the door and left the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)

### Węzeł `[111]`
Mówca: **Petr Vectern**
> ""Well. That was interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_PFJP_GivenLeaderCredit == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Alliance == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Alliance == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Petr Vectern: ""Well. That was interesting.""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Petr Vectern: ""Look at him go. He's such a clown.""*)

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""So we are seriously joining forces with the PFJP, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Yes. Sordland needs to experience some democracy.""*)
  - -> `[121]` (*Player: ""I believe that will only be beneficial for our position.""*)
  - -> `[120]` (*Player: ""I'm not sure how deep we'll dive in. For now, we'll coop..."*)

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""Look at him go. He's such a clown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_PFJP_GivenLeaderCredit == true"*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""He seriously wanted an alliance with the USP? That's new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""He wants to take the credit for the new Constitution.""*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""He wants to take the credit for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""If it passes, that is.""*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""If it passes, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: ""We don't need him anymore.""*)
  - -> `[132]` (*Player: ""He'll get the credit in his dreams.""*)
  - -> `[131]` (*Player: ""I respect the man. But he's overestimating himself.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""]** — Mówca: **Player**
> ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Petr Vectern), `[178]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Petr Vectern: ""Gotcha.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I believe that will only be beneficial for our position.""]** — Mówca: **Player**
> ""I believe that will only be beneficial for our position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Petr Vectern), `[178]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: ""Actually, I agree.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Yes. Sordland needs to experience some democracy.""]** — Mówca: **Player**
> ""Yes. Sordland needs to experience some democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Petr Vectern), `[178]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""A coalition government could make things much more diffi..."*)

### Węzeł `[123]`
Mówca: **Petr Vectern**
> ""Gotcha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""A coalition government with the PFJP can mean a lot of t..."*)

### Węzeł `[124]`
Mówca: **Petr Vectern**
> ""Actually, I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""But a coalition government could make things much more d..."*)

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""A coalition government could make things much more difficult for us though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: ""Petr is not entirely wrong.""*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""But a coalition government could make things much more difficult for us down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: ""Petr is not entirely wrong.""*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Petr is not entirely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Petr Vectern: ""Entirely? What is that supposed to mean? There's nothing..."*)

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""Entirely? What is that supposed to mean? There's nothing wro-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""A coalition government with the PFJP can mean a lot of t..."*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""A coalition government with the PFJP can mean a lot of things. But one thing is for sure: once Mr. Ricter enters our government, it will be hard to get him to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Lucian Galade: ""We should be careful, sir.""*)

### Węzeł `[130]`
Mówca: **Lucian Galade**
> ""We should be careful, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I respect the man. But he's overestimating himself.""]** — Mówca: **Player**
> ""I respect the man. But he's overestimating himself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: ""He has a tendency to play the 'nice guy'. When not playi..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""He'll get the credit in his dreams.""]** — Mówca: **Player**
> ""He'll get the credit in his dreams.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""Damn right.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""We don't need him anymore.""]** — Mówca: **Player**
> ""We don't need him anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""Damn right.""*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""Damn right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""He has a tendency to play the 'nice guy'. When not playing the victim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Alliance == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""Well. That was interesting.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Petr Vectern: ""Look at him go. That man.""*)

### Węzeł `[139]`
Mówca: **Petr Vectern**
> ""Look at him go. That man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Petr Vectern: ""I don't trust him.""*)

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""I don't trust him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: ""He wants to take the credit for the new Constitution.""*)

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""He wants to take the credit for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: ""If it passes, that is.""*)

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""Well. That was interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Petr Vectern: ""So we are seriously joining forces with the NFP, huh?""*)

### Węzeł `[143]`
Mówca: **Petr Vectern**
> ""So we are seriously joining forces with the NFP, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: ""Yes. Sordland needs to see different parties working tog..."*)
  - -> `[149]` (*Player: ""I believe it will only be beneficial for us.""*)
  - -> `[148]` (*Player: ""I'm not sure how deep we'll dive in. For now, we'll coop..."*)

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""Damn right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""Entirely? What is that supposed to mean? There's nothing wro-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""A coalition government with the NFP can mean a lot of th..."*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> ""If it passes, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""We don't need him anymore.""*)
  - -> `[155]` (*Player: ""He'll get the credit in his dreams.""*)
  - -> `[156]` (*Player: ""I respect the man. But he's overestimating himself.""*)
  - -> `[159]` (*Player: ""Whatever you say, we need Kesaro on our side.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""We don't need him anymore.""]** — Mówca: **Player**
> ""We don't need him anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""Damn right.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""]** — Mówca: **Player**
> ""I'm not sure how deep we'll dive in. For now, we'll cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""Gotcha.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I believe it will only be beneficial for us.""]** — Mówca: **Player**
> ""I believe it will only be beneficial for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Petr Vectern: ""Actually, I kind of agree.""*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> ""He's just playing the hero, sir. The honorable Sord against all odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""Gotcha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""A coalition government with the NFP can mean a lot of th..."*)

### Węzeł `[152]`
Mówca: **Petr Vectern**
> ""But a coalition government could also make things much more difficult for us down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucian Galade: ""Petr is not entirely wrong.""*)

### Węzeł `[153]`
Mówca: **Petr Vectern**
> ""Actually, I kind of agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Petr Vectern: ""But a coalition government could also make things much m..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Yes. Sordland needs to see different parties working together for once.""]** — Mówca: **Player**
> ""Yes. Sordland needs to see different parties working together for once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: ""A coalition government could make things much more diffi..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""He'll get the credit in his dreams.""]** — Mówca: **Player**
> ""He'll get the credit in his dreams.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""Damn right.""*)

### Węzeł `[156]`
**[WYBÓR GRACZA: ""I respect the man. But he's overestimating himself.""]** — Mówca: **Player**
> ""I respect the man. But he's overestimating himself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: ""He's just playing the hero, sir. The honorable Sord agai..."*)

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""A coalition government could make things much more difficult for us though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucian Galade: ""Petr is not entirely wrong.""*)

### Węzeł `[158]`
Mówca: **Lucian Galade**
> ""Petr is not entirely wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: ""Entirely? What is that supposed to mean? There's nothing..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Whatever you say, we need Kesaro on our side.""]** — Mówca: **Player**
> ""Whatever you say, we need Kesaro on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: ""I can't object to that.""*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> ""I can't object to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""A coalition government with the NFP can mean a lot of things. But one thing is for sure, Mr. Kibener is a dangerous man. He'll use all the power we give him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucian Galade: ""We should be careful, sir.""*)

### Węzeł `[162]`
Mówca: **Lucian Galade**
> ""We should be careful, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_PromisedFrensAlliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_PromisedFrensAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Frens Ricter: ""I'll reach out to you soon about it. We must start organ..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_SentKesaroToConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Anyway, I'll leave you three to whatever you were conspi..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Frens Ricter: ""I have conversed with Mrs. Morgna and Justice Zizek. We ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Frens Ricter: ""I have conversed with Mrs. Morgna and Justice Zizek. We ..."*)

### Węzeł `[168]`
Mówca: **Frens Ricter**
> ""I have conversed with Mrs. Morgna and Justice Zizek. We have at least two Justices supporting the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_PFJP_GivenLeaderCredit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_PFJP_GivenLeaderCredit == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Amendment_PFJP_GivenLeaderCredit == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_PFJP_GivenLeaderCredit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Petr Vectern: ""You shouldn't have given him all the credit for the refo..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Amendment_PFJP_GivenLeaderCredit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""He seriously wanted an alliance with the USP? That's new.""*)

### Węzeł `[172]`
Mówca: **Petr Vectern**
> ""You shouldn't have given him all the credit for the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: ""He's already acting all high and mighty.""*)

### Węzeł `[173]`
Mówca: **Petr Vectern**
> ""He's already acting all high and mighty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: ""He'll be enjoying great popularity for the new Constitut..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> ""He'll be enjoying great popularity for the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""If it passes, that is.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_PFJP_GivenLeaderCredit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Amendment_PFJP_GivenLeaderCredit == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Amendment_PFJP_GivenLeaderCredit == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Amendment_PFJP_GivenLeaderCredit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Petr Vectern: ""It wasn't enough that he got all the credit for the refo..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Amendment_PFJP_GivenLeaderCredit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Amendment_PFJP_GivenLeaderCredit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Petr Vectern: ""So we are seriously joining forces with the PFJP, huh?""*)

### Węzeł `[178]`
Mówca: **Petr Vectern**
> ""It wasn't enough that he got all the credit for the reforms and now we are joining our hands, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Yes. Sordland needs to experience some democracy.""*)
  - -> `[121]` (*Player: ""I believe that will only be beneficial for our position.""*)
  - -> `[120]` (*Player: ""I'm not sure how deep we'll dive in. For now, we'll coop..."*)
