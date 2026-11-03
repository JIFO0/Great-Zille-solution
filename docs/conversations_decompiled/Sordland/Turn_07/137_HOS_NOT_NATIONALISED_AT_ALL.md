# Sordland/Turn07/HOS NOT NATIONALISED AT ALL

- **ID konwersacji:** `137`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/137_HOS_NOT_NATIONALISED_AT_ALL.md`
- **Liczba węzłów dialogowych:** 144
- **Liczba wyborów gracza:** 17

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
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Malenyevist`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Detained_MikailAven`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Walter_Enemy`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_Sued_WalterTusk`
- `BaseGameSupport.Journal_Turn07_ImprisonedTusk`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Walter_Enemy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[115]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true; Variable["BaseGame.Relations_Walter_Enemy...`
- Węzeł `[136]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn07_ImprisonedTusk"] = true;`
- Węzeł `[137]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_Sued_WalterTusk"] = true;`
- Węzeł `[143]` (Paskal Beniwoll): `PlaySoundEffect("Signing");`

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
> "Marcel was watching Walter with a vile smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Walter Tusk**
> "“Aren't you enjoying this a bit too much?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Marcel Koronti**
> "“Come now, Walter. No need to be a sore loser.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Marcel Koronti**
> "“And watch your words. You are right in front of the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“You little snake. You are just like your father.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"]** — Mówca: **Player**
> "“You are right. Guards! Some time in Antel Rock Prison will teach him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true && BaseGame.BergiaSteel_Nationalization == 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.BergiaSteel_Nationalization"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[12]`
Mówca: **Marcel Koronti**
> "“You can't make anyone do anything anymore, you toothless old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[13]`
Mówca: **Marcel Koronti**
> "“And Korontis always keep their word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Walter Tusk**
> "“Your time will come. Be sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[18]`
  - -> `[21]`

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“Whatever you say won't change the fact that you are done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Cuffed by the two guards, Walter Tusk left the room. Marcel left shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“No matter what, I have my honor as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“That's enough, both of you.”"]** — Mówca: **Player**
> "“That's enough, both of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You are right. Guards! Mr. Tusk will join Mr. Aven in Antel Rock Prison.”"]** — Mówca: **Player**
> "“You are right. Guards! Mr. Tusk will join Mr. Aven in Antel Rock Prison.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Marcel. Shut up.”"]** — Mówca: **Player**
> "“Marcel. Shut up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Marcel is right. You are done, Walter.”"]** — Mówca: **Player**
> "“Marcel is right. You are done, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Marcel Koronti**
> "“I am not you, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[23]`
Mówca: **Walter Tusk**
> "“Or else what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“I'm not the one who put us in this position, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
Mówca: **Marcel Koronti**
> "“My apologies. Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“See, Walter?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“Mr. Tusk. You heard the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Marcel Koronti**
> "“You heard the President, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[116]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[116]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Now then. Before the conversation is derailed any further...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Walter Tusk**
> "“Mr. Rayne! You are being played by this man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Walter stuffed the agreement in his briefcase and exited the room, closing the door with a loud bang. Marcel left shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Lucian moved over to Walter and fanned the agreement papers out in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Two guards waiting outside entered the room immediately and grabbed Walter Tusk's arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“Mr. Tusk. Here is the agreement that pertains to the nationalization of Bergia Steel and the transfer of the entirety of your shares to the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Walter angrily stuffed the agreement in his briefcase and left the meeting room. Marcel followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[40]`
Mówca: **Marcel Koronti**
> "“Good luck doing that behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[41]`
Mówca: **Narrator**
> "He pointed to various sections on various pages of the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Mr. Tusk. I've already showed you what I'm capable of. You will stand down... or else.""]** — Mówca: **Player**
> "“Mr. Tusk. I've already showed you what I'm capable of. You will stand down... or else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Walter Tusk**
> "“I won't sign anything without reading it first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Walter Tusk**
> "“Rayne. I hope I never see your face again in my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[46]`
Mówca: **Walter Tusk**
> "“I will destroy you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[47]`
Mówca: **Narrator**
> "He started going through the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "When he finished, he turned back to the first page and went over the whole stack again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“No need for escalation. He doesn't have any power anymore.”"]** — Mówca: **Player**
> "“No need for escalation. He doesn't have any power anymore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[51]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[53]`
Mówca: **Narrator**
> "And again..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Marcel!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MikailAven == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MikailAven"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MikailAven == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MikailAven"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[58]`
Mówca: **Walter Tusk**
> "“I will never forget what you have done to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Just sign it already.”"]** — Mówca: **Player**
> "“Just sign it already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Stalling won't change the outcome.”"]** — Mówca: **Player**
> "“Stalling won't change the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Is there a problem?”"]** — Mówca: **Player**
> "“Is there a problem?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“And Korontis always keep their word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“I will make sure to pay a visit sometime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[64]`
Mówca: **Walter Tusk**
> "“Do you know who I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“I have to make sure I understand an agreement that takes my whole life's effort away from me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He started checking his pockets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Walter Tusk**
> "“You can't do this to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[68]`
Mówca: **Walter Tusk**
> "“I don't have a pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Walter Tusk**
> "“Thanks for the reminder, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Marcel immediately produced a pen from his pocket and put it in front of Walter with a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“No matter what, I have my honor as a Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The pen had a large Heart of Sordland symbol with the name of the company engraved on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Walter packed his belongings and furiously exited the room, slamming the door loudly. Marcel followed shortly after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“There you go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“Serves you right. Good riddance, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Walter reluctantly signed the papers after letting out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“No. There is no need.”"]** — Mówca: **Player**
> "“No. There is no need.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“My pen, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“I wouldn't underestimate what he can do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Take your damn pen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“This is called graciousness and mercy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[82]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[83]`
Mówca: **Marcel Koronti**
> "“I am not you, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“Hah.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“Get your hands off of me!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[86]`
Mówca: **Walter Tusk**
> "“You are putting me in a difficult position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“I will see you later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Walter Tusk**
> "“Not at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“However, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
Mówca: **Walter Tusk**
> "“Your time will come too, Mr. President. Believe me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
Mówca: **Marcel Koronti**
> "“Mr. Rayne. Are you just going to stay silent in the face of these blatant threats?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[92]`
Mówca: **Walter Tusk**
> "“This could've turned out much worse for me *and* you if not for our...friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Walter Tusk**
> "“Mark my words. One day he will turn on you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“Did you just threaten the President of Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“And this isn't over, Marcel. Next time I see you, I will make you beg me for forgiveness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[96]`
Mówca: **Walter Tusk**
> "“The paperwork is done so I will take my leave, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Walter Tusk**
> ""Fuck off, Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“This is ridiculous! Know your place!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[99]`
Mówca: **Walter Tusk**
> "“No. No, no no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[100]`
Mówca: **Walter Tusk**
> "“Be careful about this weasel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Walter Tusk**
> "“Dictator!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[102]`
Mówca: **Walter Tusk**
> "“You little...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[30]`

### Węzeł `[103]`
Mówca: **Walter Tusk**
> "“President Rayne. You are being played by Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[104]`
Mówca: **Marcel Koronti**
> "“Your words hold no weight, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Marcel Koronti**
> "“He needs to be punished swiftly. Surely you can't let him speak to you like that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[106]`
Mówca: **Marcel Koronti**
> "“An animal is most dangerous when it is cornered. A man with Tusk's connections would prove...difficult in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[30]`

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“I've been chewing up and spitting out Sordish politicians since you were in diapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Walter Tusk**
> "“We will see about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[113]`
  - -> `[109]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Don't forget. This could've gone much worse for you.”"]** — Mówca: **Player**
> "“Don't forget. This could've gone much worse for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[110]`
Mówca: **Marcel Koronti**
> "“I wonder how you'll do that now that you don't have any teeth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[111]`
Mówca: **Marcel Koronti**
> "“Two traits that you have never had.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Walter Tusk**
> "“Your words don't work on me, snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“No hard feelings, Walter.”"]** — Mówca: **Player**
> "“No hard feelings, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Thanks for being cooperative.”"]** — Mówca: **Player**
> "“Thanks for being cooperative.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk = true; BaseGame.Relations_Walter_Enemy = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] = true;
Variable["BaseGame.Relations_Walter_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Oligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I'm a few steps ahead of you, Marcel. I've launched an investigation that will uncover all of Mr. Tusk's secrets.""]** — Mówca: **Player**
> "“I'm a few steps ahead of you, Marcel. I've launched an investigation that will uncover all of Mr. Tusk's secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""And yours, in case you get on my bad side.""]** — Mówca: **Player**
> ""And yours, in case you get on my bad side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""You can't hide anything from me, Walter.""]** — Mówca: **Player**
> ""You can't hide anything from me, Walter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Marcel looked at me disbelievingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Marcel Koronti**
> ""Don't forget I know a thing or two about you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[127]`
Mówca: **Walter Tusk**
> ""We both do. Watch your back, Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Walter snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Walter Tusk**
> ""Listen, you halfwit. Even if I did have something to hide, I've got an army of lawyers that can disprove it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Marcel Koronti**
> "“I wonder if they will stand by you when you don't have enough money to pay them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Walter Tusk**
> "“Don't underestimate me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Walter Tusk**
> ""I'll see you both in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_ImprisonedTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_ImprisonedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Sued_WalterTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_Sued_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[138]`
Mówca: **Walter Tusk**
> "“You Malenyevist goat!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[139]`
Mówca: **Walter Tusk**
> "“You totalist donkey!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist >= 12)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] >= 12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist >= 12))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] >= 12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
