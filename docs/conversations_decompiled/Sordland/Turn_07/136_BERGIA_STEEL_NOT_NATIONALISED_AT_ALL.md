# Sordland/Turn07/BERGIA STEEL NOT NATIONALISED AT ALL

- **ID konwersacji:** `136`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/136_BERGIA_STEEL_NOT_NATIONALISED_AT_ALL.md`
- **Liczba węzłów dialogowych:** 158
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Malenyevist`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Sued_MarcelKoronti`
- `BaseGameSupport.Journal_Turn07_ImprisonedMarcel`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 5

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Marcel_Enemy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[112]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] = true; Variable["BaseGame.Relations_Marcel_En...`
- Węzeł `[113]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Sued_MarcelKoronti"] = true;`
- Węzeł `[127]` (Paskal Beniwoll): `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- Węzeł `[152]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcel"] = true;`
- Węzeł `[157]` (Paskal Beniwoll): `PlaySoundEffect("Signing");`

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
  - -> `[34]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `132` (*Sordland/Turn07/A_OligarchsFinalMeeting*), Węzeł `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Cuffed by the two guards, Marcel Koronti left the room. Walter Tusk followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[4]`
Mówca: **Walter Tusk**
> "“I am not you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“Mr. President! You are being played by this man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“No. No, no, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“You can't do this to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You totalist dog!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Two guards entered the room immediately and started to apprehend Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Marcel packed his belongings and furiously exited the room, closing the door loudly. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“I will destroy you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
Mówca: **Marcel Koronti**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Marcel Koronti**
> "“Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“Serves you right. Good riddance, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“I will make sure to pay a visit sometime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[132]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[132]`

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“Walter!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Mr. Koronti. I've showed you what I'm capable of. You will not threaten me... or else.""]** — Mówca: **Player**
> "“Mr. Koronti. I've showed you what I'm capable of. You will not threaten me... or else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“An animal is most dangerous when he is cornered. A man like Marcel would prove...difficult in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[21]`

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He turned back towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[29]`
Mówca: **Marcel Koronti**
> "“Fuck off, Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Marcel packed his belongings and furiously exited the room, closing the door loudly. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[31]`
Mówca: **Walter Tusk**
> "“I'll tell you who you are, Marcel. You're a petulant child who's not fit to shit in his father's toilet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Walter chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“There you go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Walter was watching Marcel with a vile smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“No need for escalation. He doesn't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. He doesn't have any power anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[36]`
Mówca: **Walter Tusk**
> "“Did you think you could go behind my back, boy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“No. I am not happy at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[38]`
Mówca: **Walter Tusk**
> "“Come on. I wouldn't be in my position if I didn't know how to play my cards right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Marcel reluctantly signed the papers after letting out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“You still have a lot to learn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Walter Tusk**
> "“My pen, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Walter Tusk**
> "“Now that Daddy isn't around to hold your hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“Take your stupid pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[44]`
Mówca: **Marcel Koronti**
> "“Shut up, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization == 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“No hard feelings, Marcel.”"]** — Mówca: **Player**
> "“No hard feelings, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[49]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Narrator**
> "He turned to me, eyes blazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[51]`
Mówca: **Marcel Koronti**
> "“If you think you will end up unscathed after this, think again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[70]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Walter immediately produced a pen from his pocket and put it in front of Marcel with a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization <= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization <= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The pen had a large Bergia Steel symbol with the name of the company engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[57]`
Mówca: **Walter Tusk**
> "“Mr. President. Are you just going to stay silent in the face of these blatant threats?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“I have to make sure I understand an agreement that takes my whole life's effort away from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[59]`
Mówca: **Marcel Koronti**
> "“Mr. President. I am not happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“If I were you, I would worry about myself first.”"]** — Mówca: **Player**
> "“If I were you, I would worry about myself first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“You have no power.”"]** — Mówca: **Player**
> "“You have no power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Walter Tusk**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Walter Tusk**
> "“See, Marcel?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“This is called graciousness and mercy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Two traits that you have never had.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> "“Your words don't work on me, Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Mr. President. You are being played.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Marcel Koronti**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“I am not you, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“I have no such illusions. But it is worth it to get rid of you.”"]** — Mówca: **Player**
> "“I have no such illusions. But it is worth it to get rid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“Wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Right back at you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“Do you think taking over my company will end me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“You can forget about getting re-elected, Mr. *President*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Don't forget. This could've gone much worse for you.”"]** — Mówca: **Player**
> "“Don't forget. This could've gone much worse for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He started checking his pockets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“Mr. President. Walter. I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“Gentlemen. Before the conversation is derailed further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[90]`
  - -> `[95]`

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“I will make sure it doesn't happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Mr. Koronti. Here is the agreement that pertains to the nationalization of HOS and the transfer of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Lucian moved over to Marcel and fanned out the agreement papers in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Just sign it already.”"]** — Mówca: **Player**
> "“Just sign it already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

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
  - -> `[107]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[89]`
Mówca: **Marcel Koronti**
> "“I've been keeping a tight lid on secrets that could end you. Wouldn't it be a shame if they got out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Stalling won't change the outcome.”"]** — Mówca: **Player**
> "“Stalling won't change the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[91]`
Mówca: **Walter Tusk**
> "“He needs to be punished swiftly. Surely you can't let him speak to you like that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Marcel Koronti**
> "“You son of a--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[21]`

### Węzeł `[94]`
Mówca: **Narrator**
> "He pointed to various sections on various pages of the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Is there a problem?”"]** — Mówca: **Player**
> "“Is there a problem?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“And for you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“I wouldn't underestimate what he can do, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“I won't sign anything without reading it first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“I will take my leave then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[100]`
Mówca: **Walter Tusk**
> "“Go cry about it in one of your silly newspapers. Oh, wait -- they aren't yours anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“But as you still left me with a significant portion of my company, let's say that I am ready to put this unfortunate decision behind us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[48]`
  - -> `[76]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Marcel packed his belongings and left the meeting room. Walter followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[104]`
Mówca: **Narrator**
> "When he finished, he turned back to the first page and went over the whole stack again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“This is ridiculous! Know your place, little boy!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He started going through the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Marcel Koronti**
> "“Don't you realize that I know everything about you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“And Walter, next time I see you, you'll be begging me for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[109]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[110]`
Mówca: **Walter Tusk**
> "“Did you just threaten the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“In our line of business, there is no place for feelings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti = true; BaseGame.Relations_Marcel_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] = true;
Variable["BaseGame.Relations_Marcel_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Sued_MarcelKoronti = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Sued_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> ""We had a deal, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Marcel Koronti**
> ""Do you know how hard I've worked for you? How much sleep I've lost cleaning up your messes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[129]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Yes, that's why I only took a minority share.""]** — Mówca: **Player**
> ""Yes, that's why I only took a minority share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I don't need your deal now that I have your company.""]** — Mówca: **Player**
> ""I don't need your deal now that I have your company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I don't need your deal anymore. The papers love me.""]** — Mówca: **Player**
> ""I don't need your deal anymore. The papers love me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
Mówca: **Marcel Koronti**
> ""So you stabbed me in the back but failed to put the knife in all the way. Big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> ""The deal is over. And so is your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Do they, now? We'll see about that.""]** — Mówca: **Marcel Koronti**
> ""Do they, now? We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""And I appreciate that. But not as much as I appreciate your shares.""]** — Mówca: **Player**
> ""And I appreciate that. But not as much as I appreciate your shares.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Marcel's face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Marcel Koronti**
> ""A traitor and an idiot. Impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[135]`
**[WYBÓR GRACZA: "“I'm a few steps ahead of you, Walter. I've launched an investigation that will uncover all of Marcel's secrets.""]** — Mówca: **Player**
> "“I'm a few steps ahead of you, Walter. I've launched an investigation that will uncover all of Marcel's secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Marcel Koronti**
> ""I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""And yours, in case you get on my bad side.""]** — Mówca: **Player**
> ""And yours, in case you get on my bad side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
Mówca: **Walter Tusk**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""You can't hide anything from me, Koronti.""]** — Mówca: **Player**
> ""You can't hide anything from me, Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Walter looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[145]`
Mówca: **Marcel Koronti**
> ""Listen, you coward. Even if I did have something to hide, I've got an army of lawyers that can disprove it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Marcel snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[147]`
Mówca: **Walter Tusk**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[151]`
Mówca: **Marcel Koronti**
> ""That makes two of us. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_ImprisonedMarcel = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 12))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[156]`
Mówca: **Marcel Koronti**
> "“You Malenyevist pig!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
