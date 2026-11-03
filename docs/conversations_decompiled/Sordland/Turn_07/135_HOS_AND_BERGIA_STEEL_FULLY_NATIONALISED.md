# Sordland/Turn07/HOS AND BERGIA STEEL FULLY NATIONALISED

- **ID konwersacji:** `135`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/135_HOS_AND_BERGIA_STEEL_FULLY_NATIONALISED.md`
- **Liczba węzłów dialogowych:** 154
- **Liczba wyborów gracza:** 25

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
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Malenyevist`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn07_Fled_WalterTusk`
- `BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 7

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Enemy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[115]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true; Variable["BaseGame.Turn07_Detained_Marcel...`
- Węzeł `[139]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true; Variable["BaseGame.Turn07_Fled_WalterTusk"...`
- Węzeł `[140]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true; Variable["BaseGame.Turn07_Fled_WalterTusk"...`
- Węzeł `[146]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk"] = true;`
- Węzeł `[147]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Walter_Enemy"] = true; Variable["BaseGame.Relations_Marcel_Enemy"] =...`
- Węzeł `[148]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Walter_Enemy"] = true; Variable["BaseGame.Relations_Marcel_Enemy"] =...`
- Węzeł `[153]` (Paskal Beniwoll): `PlaySoundEffect("Signing");`

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
  - -> `[7]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `132` (*Sordland/Turn07/A_OligarchsFinalMeeting*), Węzeł `[309]`

### Węzeł `[3]`
Mówca: **Walter Tusk**
> "“You are making a terrible mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Marcel Koronti**
> "“To put it mildly. You can't just take away our entire life's work and expect no repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Walter Tusk**
> "“This might be one of those rare moments where we are aligned, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“Well, it's rare a president does something this colossally stupid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The two oligarchs looked at each other and then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Keep the pen. A gift from me and a reminder.”"]** — Mówca: **Player**
> "“Keep the pen. A gift from me and a reminder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Marcel buried his head in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Completely nationalizing Sordland's two biggest private corporations? Are you insane?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[14]`
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“I've been chewing up and spitting out Sordish politicians since you were in diapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Insanely clever.”"]** — Mówca: **Player**
> "“Insanely clever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Stop whining. You are both done for.”"]** — Mówca: **Player**
> "“Stop whining. You are both done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I have already made my decision.”"]** — Mówca: **Player**
> "“I have already made my decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“If we are going down, you are going down with us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“With their connections and influence, they could cause us untold difficulties down the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[98]`

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“I swear on my name as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Lucian fanned the agreement papers out in front of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Mr. Tusk. Here are the agreements that pertain to the nationalization and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Marcel Koronti**
> "“I know everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“This is nonsense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Walter Tusk**
> "“Mr. President. I beg you to rethink this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Marcel and Walter packed their belongings and furiously exited the room, closing the door loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“Most of the Assembly eats out of my hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Rest assured. I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[26]`
Mówca: **Marcel Koronti**
> "“Don't you realize how much dirt I have on you? You will pay for backstabbing me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[27]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[30]`
Mówca: **Marcel Koronti**
> "“Don't you realize how much dirt I have on you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Cuffed by the two guards, Walter Tusk and Marcel Koronti left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“I thought we had a deal!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Walter scrutinized Marcel closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`
  - -> `[116]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“We *had* a deal.”"]** — Mówca: **Player**
> "“We *had* a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Wake up. I just used you, Marcel.”"]** — Mówca: **Player**
> "“Wake up. I just used you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“You have exhausted your usefulness.”"]** — Mówca: **Player**
> "“You have exhausted your usefulness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“You will learn what it means to hurt Walter Tusk, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[42]`
Mówca: **Marcel Koronti**
> "“I will destroy you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Marcel and Walter packed their belongings and exited the room, closing the door loudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[44]`
Mówca: **Marcel Koronti**
> "“No. This can't be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Marcel Koronti**
> "“You!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Marcel buried his head in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Guards!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Marcel turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[55]`
Mówca: **Walter Tusk**
> "“I knew this would happen. I should've trusted my gut feeling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Walter Tusk**
> "“Shame on me for actually believing we could work together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Walter Tusk**
> "“I couldn't be more wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“I played you like a fiddle.”"]** — Mówca: **Player**
> "“I played you like a fiddle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It's over, Walter.”"]** — Mówca: **Player**
> "“It's over, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“We will do everything we can to make sure you never get a second term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[63]`
Mówca: **Walter Tusk**
> "“I will be blunt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Marcel's shoulders slumped in defeat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Walter ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Mr. President. Who are you really doing this for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“I had a gut feeling, President. I knew you were not to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Give me back my pen.”"]** — Mówca: **Player**
> "“Give me back my pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“I knew you would end up destroying everything Sordland stood for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“For your sake, I hope I never see your face again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“I should've destroyed you when I had the chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[77]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Your time will come too, Rayne. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Two guards immediately entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“You totalist dog!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“And look at where we are now.”"]** — Mówca: **Player**
> "“And look at where we are now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""I wonder how you'll do that now that you don't have any teeth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I wouldn't underestimate what they can do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“This is absolutely ridiculous! I can't do it. I just can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[81]`
Mówca: **Walter Tusk**
> "“We will never forget what you have done to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Marcel got up from his seat and gave me the pen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Narrator**
> "He grabbed the pen from Marcel's hands and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
Mówca: **Walter Tusk**
> "“You can't do this to me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> "“Mr. President, we can't let them threaten you like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[98]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“Gentlemen, don't make this more difficult.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Sign the papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Mr. Koronti and Mr. Tusk. I've showed you both what I'm capable of. You will not threaten me... or else.""]** — Mówca: **Player**
> "“Mr. Koronti and Mr. Tusk. I've showed you both what I'm capable of. You will not threaten me... or else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Get up, come closer and give me back my pen.”"]** — Mówca: **Player**
> "“Get up, come closer and give me back my pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[91]`
Mówca: **Marcel Koronti**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Lucian.”"]** — Mówca: **Player**
> "“Lucian.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“Now what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[70]`

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“Neither do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Hand him your own pen."]** — Mówca: **Player_Italic**
> "I handed him my own pen with the Presidential sigil on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[117]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[117]`

### Węzeł `[101]`
Mówca: **Walter Tusk**
> "“There is no way out of this, is there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“No. No, no, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Marcel signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“Do you know who we are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Sign it or else.”"]** — Mówca: **Player**
> "“Sign it or else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Walter sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Two guards waiting outside entered the room immediately and started to apprehend Marcel Koronti and Walter Tusk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[109]`
Mówca: **Walter Tusk**
> "“I'll tell you this, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“Mark my words. Whoever put you up to this, I'm sure they'll turn on you one day as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[111]`
Mówca: **Walter Tusk**
> "“Fine. I will sign it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“No need for escalation. They don't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. They don't have any power anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[113]`
Mówca: **Narrator**
> "In a painfully slow manner, he signed the documents. He handed my pen to Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Marcel halfheartedly extended his arm across the table. The pen was still too far away to reach."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[90]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Turn07_Detained_MarcelKoronti = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true;
Variable["BaseGame.Turn07_Detained_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“I don't need your deal now that I have your company.”"]** — Mówca: **Player**
> "“I don't need your deal now that I have your company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Don't you worry, Lucian. I've launched an investigation that will uncover all of their dirty secrets.""]** — Mówca: **Player**
> "“Don't you worry, Lucian. I've launched an investigation that will uncover all of their dirty secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Marcel looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I'm going to gather enough evidence to throw you in jail for life.""]** — Mówca: **Player**
> ""I'm going to gather enough evidence to throw you in jail for life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""You gentlemen can't hide anything from me.""]** — Mówca: **Player**
> ""You gentlemen can't hide anything from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[124]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
Mówca: **Walter Tusk**
> ""That makes two of us. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Walter snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Walter Tusk**
> ""Listen, you halfwit. Even if I did have something to hide, I've got an army of lawyers and half the Assembly on my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[136]`
Mówca: **Marcel Koronti**
> "“Or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Walter Tusk**
> ""I'll see you and your trained monkey in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Lucian didn't move. I saw a muscle in his jaw twitch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_MarcelKoronti = true;
BaseGame.Turn07_Fled_WalterTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true;
Variable["BaseGame.Turn07_Fled_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_MarcelKoronti = true;
BaseGame.Turn07_Fled_WalterTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] = true;
Variable["BaseGame.Turn07_Fled_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[141]`
Mówca: **Walter Tusk**
> ""Marcel, I've had just about enough of Sordland. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Marcel Koronti**
> ""I couldn't have put it better myself. I hear the weather in Arcasia is lovely this time of year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Walter looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[144]`
Mówca: **Walter Tusk**
> ""Marcel, I've had just about enough of Sordland. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> ""I couldn't have put it better myself. I hear the weather in Arcasia is lovely this time of year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcelAndTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Enemy = true; BaseGame.Relations_Marcel_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Enemy"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Enemy = true; BaseGame.Relations_Marcel_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Walter_Enemy"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 12))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[152]`
Mówca: **Marcel Koronti**
> "“You Malenyevist pig!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
