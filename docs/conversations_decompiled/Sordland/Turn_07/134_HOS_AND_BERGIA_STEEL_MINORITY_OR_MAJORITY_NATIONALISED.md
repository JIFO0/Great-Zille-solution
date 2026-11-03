# Sordland/Turn07/HOS AND BERGIA STEEL MINORITY OR MAJORITY NATIONALISED

- **ID konwersacji:** `134`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/134_HOS_AND_BERGIA_STEEL_MINORITY_OR_MAJORITY_NATIONALISED.md`
- **Liczba węzłów dialogowych:** 121
- **Liczba wyborów gracza:** 22

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_SordlandToday_Bias`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Media_SordlandToday_Bias`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[117]` (Paskal Beniwoll): `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- Węzeł `[120]` (Paskal Beniwoll): `PlaySoundEffect("Signing");`

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
  - -> `[109]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `132` (*Sordland/Turn07/A_OligarchsFinalMeeting*), Węzeł `[309]`

### Węzeł `[3]`
Mówca: **Marcel Koronti**
> "“You're not the boss of me. Or of anyone, come to think of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[4]`
Mówca: **Marcel Koronti**
> "“No. I am not happy at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“If we're quite finished, I will take my leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“But as you could've done far more damage, let's say that I am ready to put this unfortunate decision behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[7]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Yes, I spared you as much as I could. Don't forget that.”"]** — Mówca: **Player**
> "“Yes, I spared you as much as I could. Don't forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“No hard feelings, Marcel.”"]** — Mówca: **Player**
> "“No hard feelings, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“In our line of business, there is no place for feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[11]`
Mówca: **Marcel Koronti**
> "“Just like your presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“That doesn't necessarily mean I'll spare you when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Marcel Koronti**
> ""Our deal is over, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Marcel's shoulders slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Gentlemen, don't make this more difficult.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Give me back my pen.”"]** — Mówca: **Player**
> "“Give me back my pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Shame on me for actually believing we could work together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“However, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“This could've turned out much worse for me *and* you if not for our...friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I've signed the damn paperwork. We're done here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“Your time will come too, Rayne. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“I couldn't be more wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[55]`
  - -> `[82]`

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“I should've destroyed you when I had the chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[82]`
  - -> `[50]`

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Come on, Marcel. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“We have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“I knew you would end up destroying everything Sordland stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“I hope you can understand where this is coming from.”"]** — Mówca: **Player**
> "“I hope you can understand where this is coming from.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“Come on, Walter. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I am sorry it had to come to this.”"]** — Mówca: **Player**
> "“I am sorry it had to come to this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[30]`
Mówca: **Marcel Koronti**
> "“We have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Enough. You will obey me regardless.”"]** — Mówca: **Player**
> "“Enough. You will obey me regardless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Unfortunately, these sacrifices are necessary.”"]** — Mówca: **Player**
> "“Unfortunately, these sacrifices are necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“You might have the upper hand for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Walter Tusk**
> "“But don't go ordering me around, boy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“Otherwise, I will make you regret it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Sign the papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“Not enough, President. Not enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“I knew this would happen. I should've trusted my gut feeling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Otherwise, I will make you regret it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“You might have the upper hand for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“But don't go ordering me around, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“No. I am sorry about what will happen next.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“For what? Ending the recession? We both know that's not the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[44]`
Mówca: **Walter Tusk**
> "“Now you are starting to show your true face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“I had a gut feeling, President. I knew you were not to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“You're not half the man your father was. Remember that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Marcel Koronti**
> "“Rest assured. I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
Mówca: **Marcel Koronti**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“And look at where we are now.”"]** — Mówca: **Player**
> "“And look at where we are now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“This is nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Marcel and Walter angrily packed their belongings and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“I beg you to rethink this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Narrator**
> "He grabbed the pen from Marcel's hands and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We *had* a deal.”"]** — Mówca: **Player**
> "“We *had* a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] < Variable["BaseGame.BergiaSteel_Nationalization"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization < BaseGame.BergiaSteel_Nationalization))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] < Variable["BaseGame.BergiaSteel_Nationalization"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Lucian.”"]** — Mówca: **Player**
> "“Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“Fine. I will sign it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[63]`
Mówca: **Narrator**
> "He signed the documents in a painfully slow manner, then handed my pen to Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Get up, come closer and give me back my pen.”"]** — Mówca: **Player**
> "“Get up, come closer and give me back my pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Marcel Koronti**
> "“Now what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[16]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Keep the pen. A gift from me and a reminder.”"]** — Mówca: **Player**
> "“Keep the pen. A gift from me and a reminder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Mr. Tusk. Here are the agreements that pertain to the nationalization and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Marcel got up from his seat and gave me the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Marcel halfheartedly leaned across the table with the pen in his hand. It was still too far away for me to reach it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[64]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Mr. President. I am not happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Sign it or else.”"]** — Mówca: **Player**
> "“Sign it or else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I did my best to prevent this.”"]** — Mówca: **Player**
> "“I did my best to prevent this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Walter sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Marcel signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“There is no way out of this, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[73]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Hand him your own pen."]** — Mówca: **Player_Italic**
> "I handed him my own pen with the Presidential sigil on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Neither do I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Lucian placed the agreement papers in front of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I played you like a fiddle.”"]** — Mówca: **Player**
> "“I played you like a fiddle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[92]`
Mówca: **Narrator**
> "He pointed to various sections and pages on the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Wake up. I just used you, Marcel.”"]** — Mówca: **Player**
> "“Wake up. I just used you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Marcel skimmed through the papers, then looked at Walter in dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“No, I don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[97]`
Mówca: **Narrator**
> "He turned to me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Walter scrutinized him very closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[57]`
  - -> `[93]`
  - -> `[27]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Walter Tusk**
> "“I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[103]`
Mówca: **Walter Tusk**
> "“You are putting me in a difficult position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“This is insanity!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“We had a deal, Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“So you betrayed me. I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“This might be one of those rare moments where we are aligned, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“To put it mildly. You can't just take away our shares in our own companies and expect no repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Narrator**
> "The two oligarchs looked at each other and then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Well, it's rare a president does something this colossally stupid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[29]`

### Węzeł `[111]`
Mówca: **Walter Tusk**
> "“You are making a terrible mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Yes, that's why I only took a minority share.""]** — Mówca: **Player**
> "“Yes, that's why I only took a minority share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Marcel Koronti**
> "“So you stabbed me in the back but failed to stick the knife in all the way. You're stupider than I thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“I don't need your deal now that I have your company.""]** — Mówca: **Player**
> "“I don't need your deal now that I have your company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Marcel Koronti**
> "“You coward. You'll pay for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
