# Rizia/Turn 10/STRIKE SCENE/INTRO_ABDICATION/ABOLISHMENT/INTRO_ABDICATION/ABOLISHMENT Conversation

- **ID konwersacji:** `558`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/558_ABOLISHMENT_Conversation.md`
- **Liczba węzłów dialogowych:** 129
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Rico`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Lucita_Married`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[49]`
- Węzeł `[6]` -> **[555] Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation** (../Turn_10/555_STRIKE_SCENE_Conversation.md), Węzeł `[25]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 8

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `--;`
- Węzeł `[92]` (Paskal Beniwoll): `--;`
- Węzeł `[104]` (Paskal Beniwoll): `AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras"); AddConversant("Leona Sazon"); AddCon...`
- Węzeł `[105]` (Paskal Beniwoll): `AddConversant("Lucita Azaro");`
- Węzeł `[106]` (Paskal Beniwoll): `AddConversant("Carlos Robles Azaro");`
- Węzeł `[107]` (Paskal Beniwoll): `AddConversant("Angelica Sazon");`
- Węzeł `[108]` (Paskal Beniwoll): `AddConversant("Manus Sazon");`
- Węzeł `[109]` (Paskal Beniwoll): `AddConversant("Rico Toras");`

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
  - -> `[104]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `555` (*Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation*), Węzeł `[49]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a whole speech prepared. But now that we're all here, let's just raise a toast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "They looked at one another, seemingly relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RaiseAToast_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `555` (*Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation*), Węzeł `[25]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise man once said, 'Resistance to change is futile when the wheels of time turn unceasingly.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've called everyone here as a courtesy to inform you that there are going to be some changes around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't want it to come to this. But alas, here we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Once inside, I closed the door, leaving the celebrations behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[10]`
  - -> `[12]`
  - -> `[7]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""You've already outdone yourself with the renovations, Your Majesty. No need to gild the lily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "There was a ripple of light laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For centuries, the monarchy has been the stabilizing force of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[89]`
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Through hardship and prosperity, the Crown has stood firm, guiding this nation through its darkest and brightest days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[79]`
  - -> `[90]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While Rizia’s past should be celebrated and revered, we cannot afford to become stuck in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Clinging too tightly to tradition risks dragging us into ruin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[20]`
Mówca: **Angelica Sazon**
> ""Are you saying tradition is a burden now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Leona Sazon**
> ""Are you suggesting that tradition is a burden now?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Lucita Azaro**
> "You’re speaking in riddles, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Taddeus Azaro**
> ""You’re speaking in riddles, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Carlos Robles Azaro**
> ""Yes, just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Carlos Robles Azaro**
> ""You’re speaking in riddles, Your Majesty. Just what exactly is it you're trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Carlos Robles Azaro**
> ""Yes, just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Lucita Azaro**
> ""Just what exactly are you trying to tell us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Quiet, everyone. Let His Majesty speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[85]`
  - -> `[45]`
  - -> `[84]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I intend to transform Rizia into a democratic republic -- one governed by the people, for the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The guests froze, their eyes reflecting shock and outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Romus, please. You can't be serious about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""A republic? You mean to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""A republic? You mean to abolish the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Carlos Robles Azaro**
> ""A republic? You intend to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[57]`
Mówca: **Angelica Sazon**
> ""If you're committed to this course, where does that leave the nobility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[58]`
  - -> `[87]`
  - -> `[102]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That’s why I've brought you here -- to ensure we embrace this change together on the best possible terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Angelica Sazon**
> ""The same holds true for House Sazon. I did not tolerate this talk coming from Lucas, and I won't hear it coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[63]`
Mówca: **Leona Sazon**
> ""The same holds true for House Sazon. We will not stand for such treachery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[64]`
Mówca: **Leona Sazon**
> ""If you intend to follow through with this, where does that leave the nobility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[58]`
  - -> `[87]`
  - -> `[102]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
Mówca: **Taddeus Azaro**
> ""You’re declaring open war on us -- a war which you cannot win!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""As head of House Toras -- your own family -- understand this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""You may have the crown, but you do not have us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[71]`
Mówca: **Taddeus Azaro**
> ""Resistance to what, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[72]`
Mówca: **Narrator**
> "There was a tense silence followed by uneasy glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The nobles exchange confused looks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Taddeus Azaro**
> ""Come to what, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""What is this about, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You people have taken Rizia for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[89]`
  - -> `[17]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is burdened by the weight of its history. She deserves a future unshackled from the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[89]`
  - -> `[17]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While the Crown has shouldered the cost of your greed and apathy, you grew fat on the very people you were meant to serve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[88]`
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But you have failed to protect what was entrusted to you, and now the kingdom teeters on the edge of destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[81]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no heirs to this legacy, only scavengers circling a dying institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[81]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For it is you who are the engineers of Rizia's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world has outgrown kings, and I refuse to be a relic hopelessly tied to a fading throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It’s time for the Crown to fall, so Rizia may rise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, I'm going to remember this moment... the moment when the winds of democracy swept through the land and Rizia's nobles became footnotes in history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, who am I kidding. Speeches are useless. You'll never support Rizia's transformation into a republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It leaves you free of your obligations to the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly where you deserve to be --without the power you never earned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have failed to protect what was entrusted, and now the kingdom teeters on the edge of destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[81]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Crown may have guided us through war and famine, but those victories now rest on forgotten laurels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[80]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I see no heirs to this legacy, only scavengers circling a dying institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[19]`
  - -> `[82]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The throne has become a symbol of frailty, not strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[16]`
  - -> `[77]`

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""You mean to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Taddeus Azaro**
> ""You mean to abolish the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Carlos Robles Azaro**
> ""You intend to dismantle the monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For once, you'll have to survive on merit rather than privilege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And now, the throne has become a symbol of frailty, not strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Taddeus Azaro"); AddConversant("Hugo Toras"); AddConversant("Leona Sazon"); AddConversant("Hubertus Toras");)*
- **Efekt (`userScript`):** `AddConversant("Taddeus Azaro");
AddConversant("Hugo Toras");
AddConversant("Leona Sazon");
AddConversant("Hubertus Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Carlos Robles Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Angelica Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Angelica Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Rico Toras");)*
- **Efekt (`userScript`):** `AddConversant("Rico Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Carlos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Carlos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Rico)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Rico))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Rico"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""Your Majesty... are you implying what I think you are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
