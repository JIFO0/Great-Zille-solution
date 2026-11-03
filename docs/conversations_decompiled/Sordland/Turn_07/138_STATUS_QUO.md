# Sordland/Turn07/STATUS QUO

- **ID konwersacji:** `138`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/138_STATUS_QUO.md`
- **Liczba węzłów dialogowych:** 98
- **Liczba wyborów gracza:** 23

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[19]** Walter Tusk

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `132` (*Sordland/Turn07/A_OligarchsFinalMeeting*), Węzeł `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Livia intercepted me in front of my office and informed me that I had a call from Walter Tusk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I entered and picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Walter Tusk**
> "“Anytime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“Good afternoon, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“President Rayne speaking.”"]** — Mówca: **Player**
> "“President Rayne speaking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Mr. Tusk. To what do I owe the pleasure?”"]** — Mówca: **Player**
> "“Mr. Tusk. To what do I owe the pleasure?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Walter. What do you want?”"]** — Mówca: **Player**
> "“Walter. What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“If you don't do it, you will suffer the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[12]`
Mówca: **Walter Tusk**
> "“If you want to keep being one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[13]`
Mówca: **Walter Tusk**
> "“Here is what this will cost you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[14]`
Mówca: **Walter Tusk**
> "“Not the nicest way to pick up the phone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
Mówca: **Walter Tusk**
> "“Have a good afternoon and think about what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[16]`
Mówca: **Walter Tusk**
> "“Heed my words, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Good afternoon, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“All I ask is for you to think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“Good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I heard some disturbing news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“That's not too much to ask, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“Frankly, I was not surprised either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“News about a deal between you and Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[32]`
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Listen, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Why am I not surprised?”"]** — Mówca: **Player**
> "“Why am I not surprised?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[29]`
Mówca: **Walter Tusk**
> "“I want you to start an investigation into Heart of Sordland. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[30]`
Mówca: **Walter Tusk**
> "“Oh, something about controlling the media.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“There is no such thing.”"]** — Mówca: **Player**
> "“There is no such thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Where did you hear that?”"]** — Mówca: **Player**
> "“Where did you hear that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“What kind of a deal?”"]** — Mówca: **Player**
> "“What kind of a deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Very well. I will see what I can do.”"]** — Mówca: **Player**
> "“Very well. I will see what I can do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“Good man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“No promises.”"]** — Mówca: **Player**
> "“No promises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“I will give all the information I have to the officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“When one is in business as long as I am, one hears things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Walter Tusk**
> "“What I want is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“So you say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“Heed my words, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“I found some evidence linking him to Koranelli cartel. A powerful crime syndicate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[75]`
  - -> `[28]`

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“That damn boy. Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“I wouldn't tell you if that wasn't the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[48]`
Mówca: **Walter Tusk**
> "“I did not call you to threaten you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Walter Tusk**
> "“I am calling you as a friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Walter Tusk**
> "“I suppressed those rumors for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“I hope you can appreciate that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“Listen to me carefully now, Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“You will bring a known criminal to justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[36]`
  - -> `[34]`
  - -> `[89]`

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Good man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[55]`
Mówca: **Walter Tusk**
> "“He is a dangerous man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[56]`
Mówca: **Walter Tusk**
> "“I want him out of the equation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I do. But why are you helping me?”"]** — Mówca: **Player**
> "“I do. But why are you helping me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Thank you, Walter. I'm glad I can depend on you.""]** — Mówca: **Player**
> "“Thank you, Walter. I'm glad I can depend on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“If you ever use this against me...”"]** — Mówca: **Player**
> "“If you ever use this against me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[60]`
Mówca: **Walter Tusk**
> ""Think about it as an investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
Mówca: **Walter Tusk**
> "“That damn boy. Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Is the information about the cartel ties verified?”"]** — Mówca: **Player**
> "“Is the information about the cartel ties verified?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“No promises.”"]** — Mówca: **Player**
> "“No promises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. Deal.”"]** — Mówca: **Player**
> "“Very well. Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“I wouldn't make threats if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Are you certain? That is a big accusation.”"]** — Mówca: **Player**
> "“Are you certain? That is a big accusation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[67]`
Mówca: **Walter Tusk**
> "“I have to attend to my business now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[68]`
Mówca: **Walter Tusk**
> "“That's not too much to ask, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`
  - -> `[93]`

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“Now, nothing in this life is free.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[70]`
Mówca: **Walter Tusk**
> "“Let me tell you what I want first and I will let you decide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“Fair enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“I suppressed those rumors for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“For now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Walter Tusk**
> "“I want you to start an investigation into Heart of Sordland. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I don't believe it. You are just trying to undermine him.”"]** — Mówca: **Player**
> "“I don't believe it. You are just trying to undermine him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[76]`
Mówca: **Walter Tusk**
> "“They will stay that way...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Walter Tusk**
> "“If you do what I say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[81]`
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I will decide after I see the evidence.”"]** — Mówca: **Player**
> "“I will decide after I see the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“I will feed the information to the officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“What do you want?”"]** — Mówca: **Player**
> "“What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“I won't give in to your false accusations.”"]** — Mówca: **Player**
> "“I won't give in to your false accusations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“You dare threaten me?”"]** — Mówca: **Player**
> "“You dare threaten me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Walter Tusk**
> "“What I want from you is simple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[84]`
Mówca: **Walter Tusk**
> "“I'm afraid the evidence is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“I found some evidence linking him to the Koranelli cartel. A powerful crime syndicate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Walter Tusk**
> "“Yes, President. I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“I wouldn't call you if I wasn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“This is your lucky day. I've already ordered an investigation into HOS.”"]** — Mówca: **Player**
> "“This is your lucky day. I've already ordered an investigation into HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
Mówca: **Walter Tusk**
> "“How uncharacteristically wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA: "“This is your lucky day. I've already ordered an investigation into HOS.”"]** — Mówca: **Player**
> "“This is your lucky day. I've already ordered an investigation into HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“How uncharacteristically wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
