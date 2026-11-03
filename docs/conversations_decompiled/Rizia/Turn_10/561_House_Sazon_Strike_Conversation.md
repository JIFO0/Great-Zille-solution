# Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/House Sazon Strike/House Sazon Strike Conversation

- **ID konwersacji:** `561`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/561_House_Sazon_Strike_Conversation.md`
- **Liczba węzłów dialogowych:** 411
- **Liczba wyborów gracza:** 70

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[85]** Sevrio Castellanus
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Angelica_Executed`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Leona_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Turn09_Coup_Warning`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Angelica_Arrested`
- `RiziaDLC.Angelica_Executed`
- `RiziaDLC.BirthdayGathering_ForcedSignature`
- `RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist`
- `RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed`
- `RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[478]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 25

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[84]` (Paskal Beniwoll): `Variable["RiziaDLC.Angelica_Executed"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_...`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLC.Angelica_Arrested"] = true; Variable["RiziaDLCSupport.Journal_Turn10_Birthday_...`
- Węzeł `[115]` (Paskal Beniwoll): `--;`
- Węzeł `[134]` (Paskal Beniwoll): `--;`
- Węzeł `[135]` (Paskal Beniwoll): `RemoveConversant("Angelica Sazon"); ;`
- Węzeł `[136]` (Paskal Beniwoll): `RemoveConversant("Angelica Sazon"); ;`
- Węzeł `[183]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- Węzeł `[184]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> `[122]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `559` (*Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation*), Węzeł `[478]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Angelica hesitated, letting out a slow, measured breath. After a moment, she approached the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""If it means sparing my family, then I'll sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Chin held high, Manus approached the desk, took the pen, and signed the paperwork with a steady hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t flatter yourself, Leona. You’re only a threat if you refuse to cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think carefully, Leona. Is this how you want your house to be remembered?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only need your compliance, not your loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don’t make this harder than it needs to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stubbornness won’t bring honor to your name. It’ll bring only ashes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The tension in his posture betrayed his struggle to remain composed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[18]`
Mówca: **Leona Sazon**
> ""It's not our signatures you want, you want us out of the picture entirely. Admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[12]`
  - -> `[13]`
  - -> `[28]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Leona stared doubtfully at the pen on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[20]`
Mówca: **Angelica Sazon**
> "“No, Manus, he needs to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "She took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[22]`
Mówca: **Leona Sazon**
> "“No, Manus, he needs to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "She took a commanding step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Angelica Sazon**
> ""Not one that seeks to silence them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[54]`
  - -> `[55]`

### Węzeł `[25]`
Mówca: **Leona Sazon**
> ""Not one that seeks to silence them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[54]`
  - -> `[55]`
  - -> `[57]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Letting out a slow, measured breath, she picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[27]`
Mówca: **Leona Sazon**
> "“It is my duty to demand a government that upholds the rights and freedoms of every individual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit nothing but the fact that you're stubbornly refusing to see what's best for your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Leona Sazon**
> ""And signing will make us your allies, just like that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[30]`
Mówca: **Leona Sazon**
> ""What good is a legacy if it's built on submission?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[31]`
Mówca: **Leona Sazon**
> ""You call it stubborn, but I call it loyalty. Some of us still believe in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[32]`
Mówca: **Angelica Sazon**
> "“All right. I won’t deny taking the necessary steps to stand up against a monarch who’d rule this land without any respect to its fellow subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Leona Sazon**
> "“I won’t deny that House Sazon sought a measure of autonomy -- to act for ourselves in the face of a rule that is becoming more iron-fisted by the day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Angelica scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[38]`
Mówca: **Angelica Sazon**
> "“Enough, Your Majesty. You had my gratitude when you freed me from exile. But that doesn't mean I will stand by and watch you humiliate my house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Leona scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
Mówca: **Manus Sazon**
> "“Mother, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[41]`
Mówca: **Angelica Sazon**
> "“It’s my duty to demand a government that upholds the rights of each noble House in accordance with royal tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Leona Sazon**
> ""You left us with no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[49]`
Mówca: **Manus Sazon**
> "“Leona, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your ‘autonomy’ was anything but treason, you wouldn't be here pleading your case to me. Now... your autograph, if you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document for her to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Grasping the pen, I held it firmly before her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spare me. I didn't call you here to debate civics. Just sign your name and get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not tolerate rebellion in the guise of noble ideals. Now do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your demands are irrelevant here. I’ll decide what’s best for this realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
Mówca: **Leona Sazon**
> ""You have to see that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[61]`
Mówca: **Narrator**
> "However, just as her fingers closed around the pen, she paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Manus screamed, his face pale with horror as he watched his mother fall. Leona sat frozen, her mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[63]`
Mówca: **Angelica Sazon**
> "“It’s not just about signatures, Manus. They want us out of the picture entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that I've gotten your attention... your signature please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Manus hesitated at first, but then picked up the pen, as if in a daze, signing the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[72]`
  - -> `[66]`
  - -> `[70]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. That wasn't so difficult, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[67]`
Mówca: **Leona Sazon**
> "“Please, I beg you, spare me! I wish to make amends!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[73]`
  - -> `[296]`

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Father always knew when to make the hard choices. He wouldn't want us to face the consequences of defiance. No please, just sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Manus shall be spared. How kind of you to plead for his life as well, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your House had just done what you were told from the start, we could have avoided this pointless delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. But do so with some damn dignity. Groveling is beneath you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I knew you'd come to see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Angelica Sazon**
> ""What’s the point? Our honor and dignity will be shattered before the ink even dries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Leona Sazon**
> ""Agreed. Signing this only guarantees the end of everything we stand for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[78]`
Mówca: **Manus Sazon**
> "“Do you even hear yourselves? Pride will do nothing but ensure our family suffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[79]`
Mówca: **Narrator**
> "She threw the pen to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[257]`
  - -> `[83]`
  - -> `[213]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Without hesitation, Titus raised his gun and fired, a single shot echoing through the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Angelica’s body crumped lifelessly to the floor, blood pooling around her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Save your tears. We still have business to take care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You leave me no choice. Under the authority vested in me as king, I place you under arrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed = true; RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Angelica_Executed"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Executed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Arrested = true; RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Angelica_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_Arrested"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Without a moment's hesitation, Titus grabbed Angelica and guided her toward the back wall, where other uniformed men took her into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Angelica Sazon**
> ""You won't get away with this! Mark my words... justice will prevail!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[91]`
  - -> `[90]`
  - -> `[89]`
  - -> `[88]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice *has* prevailed. Your fate was sealed the moment you crossed me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is precisely what’s being served. You simply don’t like the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice lies in the hands of those who hold power, not in empty ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Justice is mine to command. Your actions left me no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have until the count of three until the same fate falls upon you. One...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Leona hesitated at first, but then picked up the pen, as if in a daze, signing the document with shaking hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[72]`
  - -> `[66]`
  - -> `[70]`

### Węzeł `[97]`
Mówca: **Narrator**
> "As she was taken out, Leona sat frozen, stunned by what had transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[101]`
Mówca: **Narrator**
> "As she was taken out, Manus sat frozen, stunned by what had transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no need. Either way, the Sazon line will come to nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Groveling doesn't suit you, Manus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[104]`
Mówca: **Narrator**
> "He bowed his head slightly before stepping back. Leona stared at him in disgust."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""Thank you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my word... no harm shall come to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[107]`
Mówca: **Manus Sazon**
> ""There. It's done. Now please... don't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[103]`
  - -> `[383]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gone? Don’t flatter yourselves. You’re only a threat if you refuse to cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think carefully, Angelica. Is this how you want your house to be remembered?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are needlessly refusing to see what's best for your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Leona sat frozen, her mouth agape in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[149]`
  - -> `[64]`
  - -> `[92]`

### Węzeł `[116]`
Mówca: **Angelica Sazon**
> ""And just like that, a signature makes us your allies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only require your compliance, not your loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make this any more difficult than it has to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stubbornness won’t bring honor to your name, only ashes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[120]`
Mówca: **Leona Sazon**
> ""You call it needless, but I call it loyalty. Some of us still believe in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[121]`
Mówca: **Angelica Sazon**
> "What kind of legacy is built on submission?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[125]`
Mówca: **Manus Sazon**
> ""There's no time to let pride get in the way. It will do nothing but ensure our family suffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Manus Sazon**
> ""This isn't groveling. I'm doing what's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[127]`
Mówca: **Leona Sazon**
> ""Do you even hear yourself? It’s not just about signatures. He wants us out of the picture entirely. You must see that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[12]`
  - -> `[13]`
  - -> `[28]`

### Węzeł `[128]`
Mówca: **Leona Sazon**
> ""What’s the point? Signing this would be a disgrace -- guaranteeing the end of everything we stand for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Manus Sazon**
> ""What choice do we have, Leona? His Majesty isn't going to let us out of the room until these papers are signed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""Signing is our only option. And I will do what must be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[108]`
  - -> `[109]`
  - -> `[110]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Angelica Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Angelica Sazon");)*
- **Efekt (`userScript`):** `RemoveConversant("Angelica Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[140]`
Mówca: **Angelica Sazon**
> ""This signature means nothing. You can't hold this stolen land forever. It's not going to last, if it happens at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Leona hesitated at first, but then picked up the pen, signing the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[72]`
  - -> `[66]`
  - -> `[70]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I order your immediate execution for threatening the King. Titus, do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it. You are under arrest for openly threatening the King. We’ll see how long your prideful defiance lasts behind bars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say what you will. The land is mine now, and that’s not about to change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe what you will, but I have a kingdom to run and no time for your grievances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hey! Focus. We still have business to take care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I allowed a fleeting smirk to curl at the edge of my lips before moving on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Leona bowed and stepped back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[155]`
Mówca: **Leona Sazon**
> ""Yes, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There. It's done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was once yours is now officially the Crown's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can keep the clothes on your back, but from this day forward, everything else is mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[162]`
Mówca: **Narrator**
> "Angelica clenched her fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Manus and Leona looked on in stunned silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Leona looked on in stunned silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Leona stood motionless, eyes wide with shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Leona Sazon**
> ""It's gone... It's all gone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Smirk_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Smirk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Smirk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Smirk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[174]`
Mówca: **Leona Sazon**
> ""What’s the point? Signing this would be a disgrace -- guaranteeing the end of everything House Sazon stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[175]`
Mówca: **Narrator**
> "But just before signing the document, she retracted her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[390]`
  - -> `[391]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Manus hesitated at first, but then picked up the pen, signing the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[72]`
  - -> `[66]`
  - -> `[70]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""I strongly suggest you do what he says, Angelica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[186]`
Mówca: **Hugo Toras**
> ""I strongly suggest you do what he says, Countess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[196]`
Mówca: **Lucita Azaro**
> ""Take my advice, Angelica -- do what he says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[197]`
Mówca: **Lucita Azaro**
> ""Take my advice, Countess -- do what he says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""I can't say you didn't have it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""Can't say you didn't have it coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true ||RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the last straw. Titus, shoot her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Dear God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[224]`
Mówca: **Hugo Toras**
> ""A shame it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""It's a shame it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[226]`
Mówca: **Hugo Toras**
> ""Your Majesty... I must admit, I never thought you'd take it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[231]`
  - -> `[232]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Hugo stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve, Uncle. A mistake, I trust, you won't make again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you lack the stomach for hard decisions, perhaps it’s best you remain silent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[233]`
Mówca: **Hugo Toras**
> ""For all our sakes, I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""No, Your Majesty. Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Hugo lowered his gaze, offering no reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true || RiziaDLC.Leona_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true  or  Variable["RiziaDLC.Leona_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[240]`
Mówca: **Lucita Azaro**
> ""Your Majesty... I never imagined you would push it this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[247]`
  - -> `[232]`

### Węzeł `[241]`
Mówca: **Narrator**
> "Lucita stepped near me, leaning in to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""I truly hope you're right, for all our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""Your resolve is clearer than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you underestimated my resolve. A mistake, I trust, you won't make again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not see it now, but this will secure the future of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Her frustration was evident, but she said nothing further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Lucita Azaro**
> ""I never imagined you would push it this far, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[247]`
  - -> `[232]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no way out now. Please cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no way out now. Please cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Her hands appear to be shaking, please help her with the signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[258]`
Mówca: **Angelica Sazon**
> ""What are you doing?! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[259]`
Mówca: **Angelica Sazon**
> ""Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got spirit. I'll give you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[261]`
Mówca: **Narrator**
> "His men grabbed the pen, brought Angelica to the desk, and pressed it firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now look what you made me do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[263]`
Mówca: **Narrator**
> "Despite Angelica's attempt to resist, the men wrenched her hand to the signature line, forcing her to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[260]`
  - -> `[264]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? It wasn't that hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[265]`
Mówca: **Narrator**
> "The men brought the signed papers back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[267]`
Mówca: **Angelica Sazon**
> ""Forget it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Please help her with the signature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[269]`
Mówca: **Leona Sazon**
> ""What are you doing?! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got spirit. I'll give you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
Mówca: **Narrator**
> "Without missing a beat, two men grabbed the pen, pushed Leona to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now look what you made me do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
Mówca: **Narrator**
> "Despite Leona's attempt to resist, the men wrenched her hand to the signature line, forcing her to write her name, though it was barely legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[270]`
  - -> `[274]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? It wasn't that hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ForcedSignature = true; RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ForcedSignature"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[276]`
Mówca: **Narrator**
> "The men brought the signed papers back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[277]`
Mówca: **Narrator**
> "His tense shoulders relaxed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "Watch her in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched as she was taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AngelicaLeonaTakenAway)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "Gesture at the pen and the papers."]** — Mówca: **Player_Romus_Italic**
> "I gestured at the pen and the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Without hesitation, Titus raised hi..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Without a moment's hesitation, Titu..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Smirk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Smirk_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Calm down. My business with your family is done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Narrator**
> "She breathed a shaky sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""What have you done!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Angelica_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Angelica_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Angelica_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Angelica_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[309]`
Mówca: **Narrator**
> "As Manus let out a strangled sob, I averted my gaze from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Sazon_DocSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[314]`
Mówca: **Angelica Sazon**
> ""I cannot stand here after the disrespect you've shown to House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[315]`
Mówca: **Manus Sazon**
> "“Mother, please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Narrator**
> "She took a commanding step toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Angelica Sazon**
> ""Go ahead and order your men to apprehend me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[324]`
  - -> `[329]`
  - -> `[325]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Angelica Sazon**
> ""The Crown has officially lost its legitimacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when are you so fond of House Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Narrator**
> "I held up the pen and motioned to the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't make this difficult. Just sign your name and get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't come out of this looking like a martyr. We'll make you sign the papers, just as we did with the General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Titus, you heard her. Arrest Angelica Sazon immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Arrest_Angelica_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Forced_Signature_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Titus, shoot her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Without hesitation, Titus raised hi..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus. Give her the same treatment as the good General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[335]`
Mówca: **Narrator**
> "Titus gave the signal to his men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[339]`
Mówca: **Narrator**
> "Just as with Taddeus, they brought Angelica to the desk and forced a pen into her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Angelica Sazon**
> ""Stop! Unhand me this instant!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Narrator**
> "Despite Angelica's best efforts, she was forced to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[260]`
  - -> `[264]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[345]`
Mówca: **Narrator**
> "The Wruhec's Guardians brought Angelica to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[346]`
Mówca: **Sevrio Castellanus**
> ""Guardians, you know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Forced_Signature_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[348]`
Mówca: **Narrator**
> "Titus gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Arrest_Angelica_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[356]`
Mówca: **Narrator**
> "Without a moment of hesitation, Titus signaled to Sevrio, who grabbed Angelica and guided her toward the back wall, where his men took her into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[357]`
Mówca: **Narrator**
> "Titus gave his men the signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[361]`
Mówca: **Narrator**
> "Just as with Taddeus, they brought Leona to the desk and forced a pen into her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Leona Sazon**
> ""Stop! Let go of me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Narrator**
> "Despite Leona's best efforts, she was forced to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[270]`
  - -> `[274]`

### Węzeł `[364]`
Mówca: **Narrator**
> "Without missing a beat, the Wruhec's Guardians brought Leona to the desk and pressed the pen firmly into her grip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[368]`
Mówca: **Sevrio Castellanus**
> ""Guardians, you know what to do. Move!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Titus gave the signal to Sevrio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[376]`
Mówca: **Sevrio Castellanus**
> ""May she find redemption in the afterlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Angelica_ForcedSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Manus_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_Leona_Signed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[382]`
Mówca: **Manus Sazon**
> ""And in the end, these titles and land aren't really ours to give away, are they? What did either of us do to deserve them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would I? You're still the Prince Consort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[387]`
Mówca: **Manus Sazon**
> ""Maybe that's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[388]`
Mówca: **Leona Sazon**
> ""Signing our family's fate away? You're no Sazon at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Leona Sazon**
> ""But I know when I'm outnumbered. I won't put up a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll remind you that you're vastly outnumbered. Think very carefully about your next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I didn't intervene."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
Mówca: **Narrator**
> "With a long sigh of regret, she lowered her hand again and signed the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Signed Peacefully)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[157]`
  - -> `[156]`
  - -> `[158]`

### Węzeł `[394]`
Mówca: **Narrator**
> "With a long sigh of regret, she lowered her hand again and scribbled her signature on the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Signed Peacefully])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""Not everything. We still have each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[400]`
Mówca: **Leona Sazon**
> ""I hope you're happy, Your Majesty. You've taken everything and everyone from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[401]`
Mówca: **Leona Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[402]`
Mówca: **Narrator**
> "Tears streamed down her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Leona Sazon**
> ""Thank you, Your Majesty. And Manus, I am so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_SazonDidntResist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotEnding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotEnding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Shooting nobles at their mother's birthday party", "Royal Library", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Shooting nobles at their mother's birthday party","Royal Library","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes", "Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana", "Rizia_City_HouseToras");)*
- **Efekt (`userScript`):** `RemoveTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseSazon");
RemoveTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseSazon");
AddTokenStatusImmediately("Rizia_City_Argno","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Jales","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_MaveNortus","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Sallabes","Rizia_City_HouseToras");
AddTokenStatusImmediately("Rizia_City_Zpana","Rizia_City_HouseToras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
