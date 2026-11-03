# Rizia/Turn 1/P_FamilyIntroduction

- **ID konwersacji:** `287`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/287_P_FamilyIntroduction.md`
- **Liczba węzłów dialogowych:** 413
- **Liczba wyborów gracza:** 113

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Prologue_DadLetter`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCSupport.Journal_Turn01_VinaOffCouncil`
- `RiziaDLCSupport.Journal_Turn01_VinaOnCouncil`
- `RiziaDLCSupport.News_Turn01_RH_ClashesIza`
- `RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance`
- `RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest`
- `RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers`
- `RiziaDLCText.PabelToPlayer`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 27

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Relations_Vina`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[132]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1; Variable["RiziaDLC...`
- Węzeł `[134]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["RiziaDLC.Vina_OnCouncil"] = true; Variable["RiziaDLCSupport.Journal_Turn01_VinaOnCounci...`
- Węzeł `[197]` (Paskal Beniwoll): `RemoveConversant("Vina Toras"); ;`
- Węzeł `[198]` (Paskal Beniwoll): `RemoveConversant("Vina Toras"); ;`
- Węzeł `[199]` (Paskal Beniwoll): `RemoveConversant("Pabel Adria");`
- Węzeł `[200]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn01_RH_ClashesIza"] = true;`
- *...oraz 19 innych węzłów ze skryptami.*

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
  - -> `[412]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning after my coronation, I was woken up by a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away. I'm sleeping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Pabel Adria**
> ""Rise and shine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`
  - -> `[13]`
  - -> `[18]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The door opened, and Pabel gracefully stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[12]`
Mówca: **Pabel Adria**
> ""You said you wanted to be woken up at this time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[20]`
  - -> `[19]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What nerve. Barge in on the King again like that, and I'll have your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nice to see a familiar face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I did. It's best to get a head start while the day's still young.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew this day would come, but it still feels odd having you wait on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my newspaper?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my breakfast?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What nerve. Barge in on me again like that, and I'll have your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[21]`
Mówca: **Narrator**
> "The corner of Pabel's mouth twitched. He responded calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Pabel blinked. He responded calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Pabel Adria**
> ""I wasn't informed you wanted one, Your Majesty. I'll make sure to bring you the Herald every morning going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""You, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[25]`
Mówca: **Pabel Adria**
> ""You had better get used to it. Everyone answers to you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Sorry, I couldn't resist. How are you, Pabel?""]** — Mówca: **Player_Romus**
> ""Sorry, I couldn't resist. How are you, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""I mean it.""]** — Mówca: **Player_Romus**
> ""I mean it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Pabel paused for a second, then responded with composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[29]`
Mówca: **Pabel Adria**
> ""I'm fine, Your Majesty. Wonderful, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[30]`
Mówca: **Pabel Adria**
> ""Indeed. You've got a packed schedule ahead of you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[31]`
Mówca: **Pabel Adria**
> ""It won't happen again, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[32]`
Mówca: **Pabel Adria**
> ""They're just getting it ready for you downstairs now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Pabel nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Pabel leveled his gaze at me, his manner calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no, I was joking. How are you, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. See that you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[37]`
Mówca: **Narrator**
> "In the eastern dining room, an enormous breakfast spread had been laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[38]`
Mówca: **Narrator**
> "My mother was already sitting at the table, digging a spoon into a single grapefruit half."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[41]`
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Really? That's all you're eating?""]** — Mówca: **Player_Romus**
> ""Really? That's all you're eating?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Good morning, Mother.""]** — Mówca: **Player_Romus**
> ""Good morning, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You're supposed to rise when the King enters the room.""]** — Mówca: **Player_Romus**
> ""You're supposed to rise when the King enters the room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""How do you think I stay this trim, darling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Estela Toras**
> ""Same to you, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""I gave birth to you, darling, I've earned the right to stay seated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Despite the early hour, my mother was already in her full makeup. She dabbed at her lips with a napkin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Estela Toras**
> ""That was one cheeky speech you gave yesterday. The papers are having a field day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[369]`
  - -> `[47]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Who cares what they write?""]** — Mówca: **Player_Romus**
> ""Who cares what they write?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_GaveSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Forget the papers. Did you see the look on Hugo's face?""]** — Mówca: **Player_Romus**
> ""Forget the papers. Did you see the look on Hugo's face?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I meant every word of it.""]** — Mówca: **Player_Romus**
> ""I meant every word of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Estela Toras**
> ""I hope you're satisfied with yesterday's coronation. Your father's wasn't nearly as well-attended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[81]`
  - -> `[62]`
  - -> `[61]`

### Węzeł `[54]`
Mówca: **Estela Toras**
> ""I'm very sure that you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Her face grew stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Estela Toras**
> ""How could I have missed it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Estela Toras**
> ""They're all rags, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""You ought to be careful, though. This country takes its royal traditions seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Estela Toras**
> ""Your father and I learned that the hard way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""What can I say? My people love me.""]** — Mówca: **Player_Romus**
> ""What can I say? My people love me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""That was mostly your fault.""]** — Mówca: **Player_Romus**
> ""That was mostly your fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""That was his fault.""]** — Mówca: **Player_Romus**
> ""That was his fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[63]`
Mówca: **Estela Toras**
> ""They love to be seen on television. You, they're not so sure about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[64]`
Mówca: **Narrator**
> "My daughter gave a kiss on the cheek to mother, then me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DistantAsDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
Mówca: **Narrator**
> "My daughter kissed mother on the cheek, then gave me a shy wave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nonsense. Vina, eat as much as you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely. If you eat this much every morning, you'll never get married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Vina took a bite of a rizetta and gave an exaggerated sigh of pleasure. My mother rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Vina's smile vanished. She took most of the food off her plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""Father, I wanted to ask you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[75]`
Mówca: **Narrator**
> "It took me a few seconds to remember where I was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[76]`
Mówca: **Narrator**
> "The knocking on the door continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[6]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The door swung open. Pabel walked in, beaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Yes, better a dead wife than a common one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Estela Toras**
> ""Don't speak ill of the dead. Only their widows can do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Her eyes grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""That's only because of the TV cameras.""]** — Mówca: **Player_Romus**
> ""That's only because of the TV cameras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""Oh, don't sell yourself short.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[83]`
Mówca: **Estela Toras**
> ""What was in that letter he wrote you, by the way? I never asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DadLetter == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""What did he say to you before he died, by the way? I never asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""I'd rather keep that private.""]** — Mówca: **Player_Romus**
> ""I'd rather keep that private.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""He said not to make the same mistakes he did.""]** — Mówca: **Player_Romus**
> ""He said not to make the same mistakes he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""He told me to take back the lands that were lost.""]** — Mówca: **Player_Romus**
> ""He told me to take back the lands that were lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""Zille and Pales, I suppose. He never did give up on the Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""He must've been talking about Zille and Pales. His great follies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[93]`
Mówca: **Narrator**
> "She handed me a rizetta, the traditional rice and quince custard tart. The crust was exceptionally flaky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Isn't it a lovely morning?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[95]`
Mówca: **Vina Toras**
> ""I nearly got lost on the way here. Grandma, why didn't you tell me this place had such a big library?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Vina eagerly took a plate and started piling it high with pastries. My mother clicked her tongue disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Estela Toras**
> ""Not too many of those. The sweeter the taste, the wider the waist. Don't you agree, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[98]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a special occasion. Our diet can start tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You know that I'm 18 now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[102]`
  - -> `[101]`
  - -> `[195]`
  - -> `[100]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That old? How time flies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. We're already behind on finding you a husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. You've got to start thinking about where to study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it's time you started taking on more responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Vina Toras**
> ""Exactly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Vina Toras**
> ""Ugh, that's not what I meant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Vina Toras**
> ""That's not quite what I had in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Vina Toras**
> ""That was supposed to be a joke, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""I was thinking I'm old enough to accompany you to your council meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, getting an education was far more important to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[124]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, learning how to fight for my country was far more important to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but I had to keep my mouth shut.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The council is no place for a princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, 18 is old enough to get involved in royal politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Vina Toras**
> ""And Lyza the Great is a huge legacy for me to live up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`

### Węzeł `[121]`
Mówca: **Vina Toras**
> ""Well, this is what's important to me. Lyza the Great is a huge legacy to live up to, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`
  - -> `[333]`

### Węzeł `[122]`
Mówca: **Vina Toras**
> ""Please, Father. If I'm going to live up to the legacy of Lyza the Great, I need to start early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`
  - -> `[333]`

### Węzeł `[123]`
Mówca: **Vina Toras**
> ""So will I. I'm willing to make sacrifices to live up to the legacy of Lyza the Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`
  - -> `[333]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but they were too dull to bear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Vina Toras**
> ""It seems fascinating to me. And if I'm going to live up to the legacy of Lyza the Great, I'm going to have to start early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`
  - -> `[333]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, Vina. You can come to the meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but your grandma's right. You'd get bored in those meetings anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's just jealous, Vina. You can join the meetings if you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not coming to council meetings, Vina. That's an order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
Mówca: **Narrator**
> "My daughter looked crestfallen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I guess I'll just go read in my room, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1; RiziaDLCSupport.Journal_Turn01_VinaOffCouncil = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLCSupport.Journal_Turn01_VinaOffCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[135]`
Mówca: **Vina Toras**
> ""Thank you! I can't wait to start. Oh, I'd better refresh myself on Rizian law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Narrator**
> "My daughter's face lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[137]`
Mówca: **Narrator**
> "She pushed her plate away and trudged back upstairs. Once she was gone, my mother lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[138]`
Mówca: **Narrator**
> "She pushed her plate away and dashed back up the stairs. Once she was gone, my mother lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""You do realize that she'll be nothing but a liability to you in that room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`
  - -> `[147]`
  - -> `[148]`

### Węzeł `[140]`
Mówca: **Estela Toras**
> ""You made the right decision. In that room, she's nothing but a liability to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[141]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just don't want her concerning herself with state affairs at such a young age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter either way. The council is an antiquated institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I don't want to give my opponents any more leverage over me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I feel lousy letting her down, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care. She's my daughter and she'll get what she wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's the heir apparent. It'll be a good education for her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One more Toras on the council is an asset, not a liability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it matter? The council is an antiquated institution anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Estela Toras**
> ""Don't let them catch you saying that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""She'll get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
Mówca: **Estela Toras**
> ""I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""Smart boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""Growing up motherless doesn't give you a free pass forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "The clock struck quarter to nine. My first council meeting was starting soon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""He always believed you'd make a good king, you know. Even if he didn't always show it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[165]`
  - -> `[157]`
  - -> `[159]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for saying that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bullshit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Narrator**
> "I excused myself from the table. As I was leaving the dining room, my mother cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I really don't care what my father thought of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Her laughter followed me up the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't just be good. I'll be the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Narrator**
> "I headed back upstairs to fetch Vina. It was almost time to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[170]`
Mówca: **Narrator**
> "I headed back upstairs to get ready. It was almost time to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil = true; RiziaDLCSupport.Journal_Turn01_VinaOnCouncil = true;
EnableCodexEntry("Characters_Family_VinaToras_InCouncil");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_OnCouncil"] = true;
Variable["RiziaDLCSupport.Journal_Turn01_VinaOnCouncil"] = true;
EnableCodexEntry("Characters_Family_VinaToras_InCouncil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[172]`
Mówca: **Estela Toras**
> ""Suit yourself. Now, if anyone in this place could make a halfway decent strudel -- *that* would be worth ruining one's figure for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Narrator**
> "We ate for a while in silence. Vina looked lost in thought. Finally, she spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""We'll make a princess of you yet. Now, if anyone in this place could make a halfway decent strudel -- *that* would be worth ruining one's figure for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille will be ours again. And so will Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I never cared much about Pales. But I don't have to tell you how much Zille means to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just two years to go until the treaty expires.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already planning the reunification ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is and shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[180]`
Mówca: **Estela Toras**
> ""I'll find a suitably scandalizing dress to wear to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[181]`
Mówca: **Estela Toras**
> ""Halaita indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DistantAsDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""Right. Silly of me to think you were keeping track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Pabel leveled his gaze at me, his manner calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[187]`
Mówca: **Narrator**
> "He let out a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[188]`
Mówca: **Narrator**
> "The royal bedroom, on the top floor of the residential wing of Palas Rezna, made the one in the Toras palace in Monqiz look shabby. Ornate gold trim covered the walls. I was alone in a bed that could easily have slept four."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[189]`
Mówca: **Narrator**
> "After I'd left for university, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[190]`
Mówca: **Narrator**
> "After I'd left to join the military, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[191]`
Mówca: **Narrator**
> "After I'd left for Monqiz, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[192]`
Mówca: **Narrator**
> "In the years I'd been gone, the groundskeeper's son had worked his way up to Chief Butler. I'd seen him on visits to the palace, but we rarely exchanged words. Now, he was the head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so funny?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Just then, Vina came bounding down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[196]`
Mówca: **Vina Toras**
> ""It's unusual for a female heir to join the council, I know. But didn't you do the same when you were my age?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`
  - -> `[110]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_ClashesIza = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_ClashesIza"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelBoss == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Narrator**
> "Pabel smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Pabel's expression didn't change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Pabel Adria**
> ""Likewise. I'm happy to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[193]`

### Węzeł `[215]`
Mówca: **Pabel Adria**
> ""Please pardon my impudence. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[216]`
Mówca: **Narrator**
> "Pabel chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[217]`
Mówca: **Narrator**
> "He drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Pabel Adria**
> ""Romus Toras, King of Rizia. You've come a long way since we were kids.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not really. All I had to do to get this job was wait for Father to die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So have you, Mr. Chief Butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet here I am in the exact same palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It feels natural, somehow. Like I was born to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[223]`
Mówca: **Pabel Adria**
> ""Not bad for the groundskeeper's son. Of course, it helped to have friends in high places.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Pabel's eyes flooded with compassion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Pabel Adria**
> ""I know you two didn't get along by the end. But it's never easy to lose a parent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`

### Węzeł `[229]`
Mówca: **Pabel Adria**
> ""I'm so sorry. This must be hard for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`

### Węzeł `[230]`
Mówca: **Pabel Adria**
> ""But now you've got me as your butler. A significant upgrade from your man in Monqiz, I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Narrator**
> "He looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's complicated. I don't know what I should be feeling right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'm not that bothered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It must have been even harder being his butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
Mówca: **Pabel Adria**
> ""There's no 'should'. You feel what you feel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[237]`
Mówca: **Pabel Adria**
> ""Anything I can do to make your life easier, I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Well, I'm here to make your life easier. Let me know if there's anything I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Something dark passed across Pabel's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[240]`
Mówca: **Narrator**
> "He briskly drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[241]`
Mówca: **Narrator**
> "He gave a brusque nod and drew back the heavy red velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[242]`
Mówca: **Pabel Adria**
> ""You were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[243]`
Mówca: **Narrator**
> "He opened the doors of my armoire and began pulling out items of clothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Pabel Adria**
> ""You have quite the packed schedule this morning. Why don't you eat breakfast with the girls while I get your outfit ready?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`
  - -> `[252]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""Forgive me if I'm overstepping, but how are you doing? I know you and your father didn't get along by the end. But it's never easy to lose a parent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""Forgive me if I'm overstepping, but how are you doing? Losing your father must have been hard for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Won't you eat with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can pick out my own clothes, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Pabel Adria**
> ""Can you? Remember when your father brought the whole family to meet the Baron of Soradis and you insisted on wearing shorts? *Shorts*!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[254]`
Mówca: **Pabel Adria**
> ""Queen Mother Estela and Princess Vina must be waiting already. You should get a move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1; RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""I trust you slept well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[262]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Pabel Adria**
> ""I ate in the servants' quarters before coming here. There are hierarchies to be observed now that you're king, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[293]`
  - -> `[294]`

### Węzeł `[260]`
Mówca: **Pabel Adria**
> ""Don't worry, Your Majesty. I'll make sure you're the best-dressed king in Rizian history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[297]`
  - -> `[321]`
  - -> `[402]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, though, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, fine. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He briskly drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelBoss == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "Pabel smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[269]`
Mówca: **Pabel Adria**
> ""He had his difficult moments. But I tried my best to make him comfortable in his last days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, not really. I was thinking about Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He can't have been an easy man to serve. Especially towards the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[275]`
Mówca: **Pabel Adria**
> ""My condolences, Your Majesty. This must not be an easy time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[276]`
  - -> `[271]`
  - -> `[278]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no need for your pity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good riddance to the bastard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel. That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[279]`
Mówca: **Narrator**
> "Compassion appeared in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Pabel looked mildly shocked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[281]`
Mówca: **Narrator**
> "Something dark passed across Pabel's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Pabel Adria**
> ""He had his difficult moments. But I tried my best to make him comfortable in his last days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[283]`
Mówca: **Pabel Adria**
> ""Just let me know if there's anything I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Pabel took a step backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Pabel Adria**
> ""Excuse me. I only wanted to express my sympathies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[286]`
Mówca: **Pabel Adria**
> ""I know you two had your disagreements, but I wasn't aware it was that bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Pabel Adria**
> ""I wasn't aware the two of you were at odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hierarchies are meant to be broken. You're the head butler, not a common scullery maid. I insist you join us next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you at least stop calling me 'Your Majesty'? We don't need to be so formal with each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[295]`
Mówca: **Pabel Adria**
> ""Always. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "I recognized the slogan we'd made up as kids. "Two tides rise, one sun sets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Can you call me Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Pabel Adria**
> ""I can in private. In public, it would be seen as highly disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Pabel Adria**
> ""I haven't forgotten, though. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty = false; RiziaDLCText.PabelToPlayer = "Romus";)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] = false;
Variable["RiziaDLCText.PabelToPlayer"] ="Romus";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[301]`
Mówca: **Narrator**
> "Still in my dressing gown, I headed downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He moved over to my armoire and began pulling out items of clothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Pabel Adria**
> ""I'm glad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[304]`
Mówca: **Pabel Adria**
> ""Why don't you join your family downstairs? I'll have your outfit ready by the time you're finished eating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`
  - -> `[307]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Won't you eat with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can pick out my own clothes, Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[308]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Pabel Adria**
> ""I ate in the servant's quarters before coming here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[389]`
  - -> `[396]`
  - -> `[316]`

### Węzeł `[310]`
Mówca: **Pabel Adria**
> ""This is one of my royal duties, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Pabel Adria**
> ""Don't worry, Your Majesty. I'll make sure you're the best-dressed king in Rizian history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[316]`
  - -> `[329]`
  - -> `[393]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you stop calling me 'Your Majesty'? We don't need to be so formal with each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Pabel Adria**
> ""Queen Mother Estela and Princess Vina must be waiting already. You should get a move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Pabel Adria**
> ""I haven't forgotten. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[323]`
Mówca: **Pabel Adria**
> ""Sorry, Your Majesty. But that would be seen as highly disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Pabel Adria**
> ""Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Pabel Adria**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, Pabel. Let's catch up later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This will be fun. Just like old times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You always were a poetic type.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother Queen Lyza didn't get her wisdom from serving on her father's council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Greatness is something you're born with, my daughter. You can't glean it off of others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother's achievements weren't as noteworthy as everyone says. She just happened to be in the right place at the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't have to worry about living up to anyone's legacy. You're great in your own right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[337]`
Mówca: **Vina Toras**
> ""That's not fair. She was already queen by the time she was my age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[338]`
Mówca: **Vina Toras**
> ""Queen Lyza herself would disagree. That's why she worked so hard to improve educational opportunities for women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[339]`
Mówca: **Vina Toras**
> ""That's what some people say, yes. But I've read all her essays. She was a true visionary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[340]`
Mówca: **Vina Toras**
> ""That's very kind of you, Father. But Lyza was the most beloved queen in our history. Of course people will compare me to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Estela Toras**
> ""You're getting ahead of yourself, sweetheart. The crown is on your father's head right now, not yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Narrator**
> "She looked at me sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Estela Toras**
> ""And what your father needs is for your lovely little face to be seen at balls and ribbon-cutting ceremonies, not hidden behind council doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`
  - -> `[346]`
  - -> `[347]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's right, Vina. As the princess, it's up to you to serve as the ultimate example of beauty and grace in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Mother. We both know Vina is much more than a pretty face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an outdated image of a princess, isn't it? If Vina wants to get involved in politics, I don't see why I shouldn't let her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that you'll learn more about how the world works by being out in it, not by shadowing me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Vina Toras**
> ""Listen to both of you! I need to learn how to govern the country, not just symbolize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[349]`
Mówca: **Vina Toras**
> ""Going to balls won't teach me how decrees are made, or how to negotiate with foreign leaders. Only time served on the council will do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Vina Toras**
> ""I do recognize my duty to represent Rizia in public. But I need to learn how to govern the country, not just represent it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Estela Toras**
> ""You want to spend the best years of your life cooped up in that den of snakes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Estela Toras**
> ""The council isn't some wise, all-knowing entity. Everyone on it is only looking after their own house and their own stature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""And God help you if you get in the way of either of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`
  - -> `[356]`
  - -> `[358]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My councilors represent many cumulative decades of experience. I would not discount their wisdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have always found it odd that we entrust the country's direction to a handful of privileged nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father may have allowed his council to run roughshod over him. I will not make that mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough, Mother. This is my decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Estela Toras**
> ""I'm only trying to be helpful. But you're right, of course. Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""Their 'wisdom' turned Pales into a bloodbath and sparked an uprising. It almost got you killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[361]`
Mówca: **Narrator**
> "Vina looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[128]`
  - -> `[129]`
  - -> `[127]`

### Węzeł `[362]`
Mówca: **Vina Toras**
> ""If navigating the council's self-interests will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
Mówca: **Vina Toras**
> ""If choosing when to ignore the council will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Vina Toras**
> ""And besides, if choosing when to ignore the council will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Vina Toras**
> ""I promise, it'll be like I'm not even there. And I'll step out in public as much as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[367]`
Mówca: **Vina Toras**
> ""I don't know if the uprising was the council's fault. From what I've read, there were many factors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly, I wasn't even sure what I wanted to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[370]`
Mówca: **Estela Toras**
> ""But don't let my nattering on keep you from eating. A king needs energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Estela Toras**
> ""I hope it was an apology. He was so cruel to everyone at the end. Not at all like the man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Estela Toras**
> ""You boys did always have your secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""It's a pity he didn't live to preside over my homeland's big return to Rizia. But soon you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[177]`
  - -> `[178]`
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[381]`
Mówca: **Estela Toras**
> ""I'm looking forward to that day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[382]`
Mówca: **Estela Toras**
> ""I don't doubt it, my love. But your father is the one wearing the crown now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[383]`
Mówca: **Estela Toras**
> ""That's true, sweetheart. But your father is the one wearing the crown right now. Not Lyza, and not you -- yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[384]`
Mówca: **Estela Toras**
> ""Her Majesty loved women, yes. Except for the one her son married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Estela Toras**
> ""In any event, sweetheart, your father is the one wearing the crown right now. Not Lyza, and not you -- yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[386]`
Mówca: **Vina Toras**
> ""It would mean the world to me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[387]`
Mówca: **Estela Toras**
> ""Because I didn't want you holed up in there all the time. A grandmother's got to see her granddaughter every so often, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I insist you join us at the table next time. You're the head butler, not a common scullery maid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Pabel Adria**
> ""If the King commands it, I can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even more fashionable than King Darius the Debonair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Pabel Adria**
> ""I wasn't aware such a monarch existed. But yes, I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How rude. In the future, you will not take a bite before your King does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Narrator**
> "His expression stayed neutral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. I'll see to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition += 1; RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Pabel Adria**
> ""If the King commands it, I can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even more fashionable than King Darius the Debonair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Pabel Adria**
> ""I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[405]`
Mówca: **Estela Toras**
> ""You certainly said something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[406]`
Mówca: **Narrator**
> "She looked skeptical for a second, then assumed a reverent position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[407]`
Mówca: **Pabel Adria**
> ""I'm just a humble servant. Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[408]`
Mówca: **Pabel Adria**
> ""Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Debating their daughter’s fate over tea, toast and Rizettas", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Debating their daughter’s fate over tea, toast and Rizettas","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
