# Rizia/Turn 1/A_ReligiousCeremony

- **ID konwersacji:** `294`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/294_A_ReligiousCeremony.md`
- **Liczba węzłów dialogowych:** 1006
- **Liczba wyborów gracza:** 292

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating`
- `RiziaDLCIsolated.SanctuaryQHub_Budget`
- `RiziaDLCIsolated.SanctuaryQHub_Dastnurists`
- `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues`
- `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers`
- `RiziaDLCIsolated.Turn01_EyesOpen`
- `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved`
- `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Country_DastnuristOpinion`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn01_Religion_DivusZaitu`
- `RiziaDLC.Turn01_ReligiousBrief_YourBest`
- `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating`
- `RiziaDLCIsolated.SanctuaryQHub_Budget`
- `RiziaDLCIsolated.SanctuaryQHub_Dastnurists`
- `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues`
- `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body00`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers`
- `RiziaDLCIsolated.Turn01_EyesOpen`
- `RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway`
- `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved`
- `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita`
- `RiziaDLCSupport.Journal_Turn01_Ceremony_Participated`
- `RiziaDLCSupport.Journal_Turn01_Ceremony_Refused`
- `RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony`
- `RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 27
- **Węzły modyfikujące stan gry:** 86

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLCIsolated.SanctuaryQHub_Budget`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[373]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] = true;`
- Węzeł `[374]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] = true;`
- Węzeł `[375]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] = true;`
- Węzeł `[391]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] = true;`
- Węzeł `[392]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] = true;`
- Węzeł `[393]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] = true;`
- Węzeł `[407]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1; ;`
- Węzeł `[408]` (Paskal Beniwoll): `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary"); EnactDecree("Religion_RestorationPlavo...`
- *...oraz 78 innych węzłów ze skryptami.*

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
  - -> `[641]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "My motorcade traveled for over an hour before the Archsanctuary of Plavo appeared on the horizon. Its golden dome radiated under the sunrise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[4]`
Mówca: **Narrator**
> "It was a view I’d seen countless times, but it never failed to inspire awe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[5]`
Mówca: **Narrator**
> "It was a view that inspired awe in many a Rizian, especially the most devout followers of St. Wruhec."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Titus, who was sitting next to the driver, turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Titus Gordion**
> ""We shall be arriving shortly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I’ve been looking forward to this for quite some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This should be interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I was here for the Consecration of the King, the centuries-old ecclesiastical ceremony symbolizing a monarch's appointment as God’s highest representative on earth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Better known as the “divine right of kings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Unlike my coronation, this was a private event shrouded in secrecy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Not even my father, despite my asking, would disclose what occurred. He'd simply say, “What took place was between me and God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[15]`
Mówca: **Narrator**
> "But aside from the pomp and circumstance of the Consecration of the King, this meeting was my chance to catch up on Rizia's current state of religious affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Before long, my car pulled up in front of the towering colonnades situated on either side of the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Wiseman Ignacius... looking as stoic as ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at the old geezer. Hard to believe he's still breathing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here we go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[20]`
Mówca: **Narrator**
> "While most shouted my praises, there was a small group of demonstrators protesting against the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[21]`
Mówca: **Narrator**
> "A welcoming smile spread across the Grand Wiseman's face as he came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Sal Ignacius**
> ""Welcome, Your Majesty. We are greatly honored to have you here for this momentous occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Sal Ignacius**
> ""I look forward to serving you just as I served your father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is I who is honored to be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shall honor this day with the dignity and respect this sacred tradition deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could think of better ways to spend my day. But when duty calls, one must oblige.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> "“It fills my heart with joy to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""I shall do my best to provide you with both personal and state guidance on religion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[31]`
  - -> `[30]`
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Thank you, Grand Wiseman. I aspire to fulfill God's will here on earth, just as you have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Time is short, Grand Wiseman. Let us skip the pleasantries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am privileged to receive your guidance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your best? Only the weak whine about doing their best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[979]`

### Węzeł `[33]`
Mówca: **Sal Ignacius**
> ""I'm merely a humble servant, Your Grace. I do as God commands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[34]`
Mówca: **Sal Ignacius**
> "“The six stars of St. Wruhec still shine upon our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Sal Ignacius**
> "“Come, let us step inside. We have much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[36]`
Mówca: **Narrator**
> "We began heading toward the entrance. However, I didn't get very far before my attention was drawn to a commotion from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "As I turned to look, a throng of people surged against my security guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Stand your ground."]** — Mówca: **Player_Romus_Italic**
> "I didn't want to be seen as a coward, so I stood my ground as the man approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "Hurry towards the archsanctuary."]** — Mówca: **Player_Romus_Italic**
> "I hurried towards the archsanctuary before he could reach me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Titus, without missing a beat, caught the man by the arm and threw him to the ground. Other guards approached as Titus held him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so blasphemous about Golcondism?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“And so you banned them. Rightly so, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Could we not have built Golcondist sanctuaries to pacify them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[44]`
Mówca: **Narrator**
> "With a nod from Captain Gordion, two of his guardsmen lifted the man to his feet and escorted him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Sal and I continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Sal Ignacius**
> ""I humbly apologize for the interruption, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> "“Shall we proceed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Lead the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Yes. The sooner we get this over with, the better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“How could I say no?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just point me in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I accompanied Sal into the archsanctuary. Titus and one of his men stood guard at the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Our footsteps echoed throughout the massive empty chamber as we made our way down the main aisle that separated the hall in two."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "I was surrounded by ornate wall murals of religious scene depictions, leaving no surface bare. Nearby statues seemed to watch me as I passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[58]`
  - -> `[59]`
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Sal Ignacius**
> "“It’s only fitting that such a monument be built atop the final resting place of Rizia's most revered disciple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“This place never fails to impress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I remember the archsanctuary being a lot bigger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“One could get lost in a place like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“All spectacle. No sustenance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[60]`
Mówca: **Sal Ignacius**
> ""Some might say that spiritual sustenance comes from within.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[61]`
Mówca: **Sal Ignacius**
> ""Caelus the Devout. Singlehandedly credited for spreading the teachings of St. Wruhec throughout our part of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`
  - -> `[62]`
  - -> `[63]`
  - -> `[65]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’m not here for a history lesson. Let’s get down to business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a great admirer of his, I've always aspired to lead a life of devotion and virtue, much like his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[978]`

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""If you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Yes, yes. I know all about him. But he’s not the reason why I’m here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Sal Ignacius**
> ""It warms my heart to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Sal Ignacius**
> ""Without him, we Rizians would be no more enlightened than Dastnurists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "We stopped when we'd reached the chancel where the altar stood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as you are Grand Wiseman, I'm sure those values will persevere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists are particularly concerning. Their religion disregards the centuries of progress since Descension Day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Golcondists pose a particularly large threat, using Wruhecism as a cover for blasphemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call it 'diluted.' Supporting a plurality of religions will only enrich Rizian culture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Sal Ignacius**
> ""But we must not lose sight of our one true faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""However, he was also deluged with requests from the Dastnurist community. In particular, the Grandsanctuary of Sallabes has long been too small to serve worshippers' needs and is urgently in need of expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Why is it the government's responsibility to fund sanctuaries? Couldn't Rizia's religious congregations pay for their own repairs and expansions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't he just fund both projects?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[966]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We will begin the restoration of Plavo at once." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We will begin the restoration of Plavo at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Both projects are equally important in my eyes. I will speak to Elena about funding both the Plavo restoration and the Sallabes Grandsanctuary expansion.” [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Both projects are equally important in my eyes. I will speak to Elena about funding both the Plavo restoration and the Sallabes Grandsanctuary expansion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Serving the Dastnurist community should take priority at this time. I will grant the Archpriest of Sallabes' request." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Serving the Dastnurist community should take priority at this time. I will grant the Archpriest of Sallabes' request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Sal Ignacius**
> "“I see the wisdom in your decision. May God’s shining light forever guide you even through the darkest times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[81]`
Mówca: **Narrator**
> "The Grand Wiseman nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Sal Ignacius**
> ""Nur be praised!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[83]`
Mówca: **Narrator**
> "The holy man let out a small gasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Sal spread his arms wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Sal Ignacius**
> "“With great honor, I shall lead you as you step across the threshold and unite with the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He motioned toward a stone archway leading out of the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[87]`
Mówca: **Narrator**
> "I followed the Grand Wiseman down a long corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "I continued after him as we went down the stairs, which seemed to go on forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Before long, we'd reached the bottom, where I was greeted by a wall of human bones that were carefully stacked from top to bottom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I had no idea this was down here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Most don’t.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""As for the tomb's tenants, they're mostly wealthy noblemen and their families alongside other well-to-do individuals throughout the centuries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[94]`
Mówca: **Sal Ignacius**
> ""This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[95]`
Mówca: **Narrator**
> "As we made our way down the tunnel, the ceiling began to close in around us, and feelings of claustrophobia began to sink in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Just when it seemed like the tunnel would never end, we emerged into a vast cavern, also illuminated by torchlight. Several wiscerers, lesser in rank than Sal, were waiting for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[97]`
Mówca: **Narrator**
> "They were arranged around a marble sarcophagus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[98]`
  - -> `[639]`
  - -> `[729]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Is that who I think it is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[99]`
Mówca: **Sal Ignacius**
> ""Rare are those who have set foot here. Count yourself among the blessed few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Caelus the Devout's effigy became more apparent as I approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Sal placed his torch into a nearby sconce as one of the other wisemen, carrying a silver tray, approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "On it was a golden chalice, a clay jug filled with oil, a sponge, and what appeared to be a bottle of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Sal Ignacius**
> "“Let us begin. Please remove your clothes and stand on the royal seal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`
  - -> `[249]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I am ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Actually... I'm beginning to have second thoughts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Following the Grand Wiseman's instructions, I joined him in reciting verses from the sacred scripture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[108]`
Mówca: **Narrator**
> "When my garments were completely removed, Sal proceeded to anoint me, dipping a sponge into the fragrant oil and gently applying it all over my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[109]`
Mówca: **Narrator**
> "He then poured the wine into the chalice until it reached the brim."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Sal Ignacius**
> "“It is well known that this is the final resting place of Caelus the Devout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Sal Ignacius**
> ""But what most don’t know is that this is where he performed his first miracle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[847]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Miracle? Did I hear you correctly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’ve never heard of disciples performing miracles before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I have gone along with you thus far. But are you really saying something supernatural happened here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Even as a religious man, I have trouble believing in miracles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[116]`
Mówca: **Sal Ignacius**
> "“Yes. The miracle of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Sal Ignacius**
> ""For upon filling his stomach with the sacred wine -- the very wine before you now -- he was given the ability to prophesy the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What can I expect to see?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He poured the wine into the chalice and held it high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[766]`
  - -> `[118]`

### Węzeł `[120]`
Mówca: **Sal Ignacius**
> ""You will see nothing. Only the most pious and reverent men may drink from the sacred chalice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[121]`
Mówca: **Sal Ignacius**
> ""You see, once this wine is consumed, Caelus the Devout's gift of foresight shall, for a time, be bestowed upon the person who ingests it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[122]`
Mówca: **Narrator**
> "He held up the chalice, once more, and drank until the wine was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "Setting it back down on the tray, he then stepped toward me and held out his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[132]`
  - -> `[131]`

### Węzeł `[124]`
Mówca: **Narrator**
> "We stood there in silence for what felt like an eternity. I wasn't sure what to expect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[125]`
Mówca: **Narrator**
> "But then suddenly, his body began to tremble and his hands took a firm grip in mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[126]`
Mówca: **Sal Ignacius**
> ""Listen closely to my words. For the gift of sight comes in flashes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Romus_Italic**
> "I closed my eyes as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "Leave eyes open."]** — Mówca: **Player_Romus_Italic**
> "I kept my eyes open, waiting to see what would happen next."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "Look around you."]** — Mówca: **Player_Romus_Italic**
> "Scanning the room, I watched as the other priests looked on, waiting to see what would happen next."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Take his hands."]** — Mówca: **Player_Romus_Italic**
> "I placed my hands in his."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "Step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`
  - -> `[569]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "Retract your hands."]** — Mówca: **Player_Romus_Italic**
> "I pulled my hands away from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[565]`
  - -> `[566]`
  - -> `[568]`

### Węzeł `[133]`
Mówca: **Sal Ignacius**
> ""To consummate the Consecration of the King I must insist that you take my hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`
  - -> `[772]`
  - -> `[136]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody told me there would be prophecies. I cannot govern with the burden of future events looming over me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And *I* must insist you remember who you're speaking to!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[137]`
Mówca: **Sal Ignacius**
> ""I must insist that you take my hand, or else I cannot bestow my consent on the ceremony's completion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[546]`
  - -> `[548]`
  - -> `[549]`

### Węzeł `[138]`
Mówca: **Narrator**
> "I quickly put on my clothes and made my way back through the catacombs until I'd reached the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Titus and another guardsman were at my side the moment they saw me re-emerge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""Your Majesty, is everything alright?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`
  - -> `[143]`
  - -> `[144]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern. We're leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We just have to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I barreled past him without saying a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get out of my way, Captain. Do you want to be demoted to private?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[145]`
Mówca: **Narrator**
> "I thought about the Grand Wiseman's last words to me as the Archsanctuary of Plavo faded from view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Before long, my motorcade was back on the road."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[147]`
Mówca: **Narrator**
> "By the time I'd made it back to the car, the captain was so far behind, I ended up opening the door myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "I barely noticed when the motorcade pulled out of the city and back onto the highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[149]`
Mówca: **Narrator**
> "I couldn't let go even if I wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[150]`
Mówca: **Narrator**
> "My outburst left the wiseman speechless. Seemingly shocked, he bowed his head and backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[151]`
Mówca: **Narrator**
> "At his advanced age, he wasn't exactly spry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Sal Ignacius**
> ""Are you alright, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[156]`
  - -> `[154]`
  - -> `[155]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should be the one asking you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As best as one can be, given the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm fine. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Sal Ignacius**
> ""Very well, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[158]`
Mówca: **Sal Ignacius**
> ""I hope I'm not overstepping my bounds. But it was a situation that, unfortunately, should never have happened in the first place--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[159]`
Mówca: **Sal Ignacius**
> ""Can't say the same for myself. These old bones don't move as quickly as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[160]`
Mówca: **Sal Ignacius**
> ""Oh, I may have some years on me, but I'm not dead yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[162]`
Mówca: **Narrator**
> "He closed his eyes and began taking in long deep breaths."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`
  - -> `[129]`

### Węzeł `[163]`
Mówca: **Sal Ignacius**
> ""I see a crown. It's ascending into the sky... rising high above the surrounding countryside--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`
  - -> `[253]`
  - -> `[1001]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know this may seem highly unorthodox, but this whole secret ceremony just doesn't sit well with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must break with the archaic customs of my predecessors if I am to be the ruler Rizia needs right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[166]`
Mówca: **Sal Ignacius**
> ""A sovereign leader of this great nation you’re duty-bound to uphold this sacred tradition, just as all the monarchs who came before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Sal Ignacius**
> ""The crown you wear isn't just a decorative headdress, but a symbol of national identity -- of unity and pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Sal Ignacius**
> ""It represents stability and steadfast continuity even through the darkest of times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[172]`
  - -> `[171]`
  - -> `[980]`
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Sal Ignacius**
> ""My point is that you not only embody a kingdom on earth, but the kingdom above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does this diatribe have anything to do with my taking part in the ceremony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm well aware of what the crown represents. Please get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I am grateful for the responsibility bestowed upon me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "Stay silent and listen."]** — Mówca: **Player_Romus_Italic**
> "I refrained from speaking to hear him out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
Mówca: **Sal Ignacius**
> ""Everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Sal Ignacius**
> ""You not only embody a kingdom on earth, but the kingdom above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Sal Ignacius**
> ""What I'm trying to say is...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Sal Ignacius**
> ""And I, for one, am grateful for having you as our king. As are the millions of subjects under your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Sal Ignacius**
> ""For to reject the sacrament is to reject God himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[179]`
  - -> `[182]`
  - -> `[181]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By that logic, a challenge to your King is a challenge to the Almighty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please forgive me. The crown's weight is heavy, and only with God's guidance can I fulfill my duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion's place in society is without question. But as for its role in government... I have reservations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you finished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ceremony])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[184]`
Mówca: **Narrator**
> "The wiscerer went silent. Though he outwardly remained calm, the disdain in his eyes told a different story."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you brought this to my attention, but I'd rather not make an immediate decision. I'll think it over once I'm back at the Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[186]`
Mówca: **Sal Ignacius**
> ""With all due respect to the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[187]`
Mówca: **Sal Ignacius**
> ""Wruhecism and the Rizian monarchy are one and the same. It has been that way since the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Sal Ignacius**
> ""This kingdom has been blessed for a reason. Any change to the status quo will surely jeopardize our prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`
  - -> `[189]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You make a valid point. I'm still not fully sold on religion's role in government, however, I know better than to upset that delicate balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion and state should be separate. End of story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`
  - -> `[822]`
  - -> `[821]`
  - -> `[854]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe my position on this issue is unlikely to change. But I see no obstacle to finding common ground if the opportunity arises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [IsEverythingAlright])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[193]`
Mówca: **Narrator**
> "Sal gasped in astonishment as I made an about-face and headed back towards the catacombs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[194]`
Mówca: **Narrator**
> "I could still smell the "holy oil" permeating off of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[198]`
Mówca: **Sal Ignacius**
> ""Does this mean you'll go through with the consecration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[199]`
  - -> `[350]`
  - -> `[653]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's what it takes to get your blessing, then yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo as well as the Dastnurist Grand Sanctuary, perhaps we can overlook my abstention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Dastnurist Grand Sanctuary, perhaps we can overlook my abstention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`

### Węzeł `[202]`
Mówca: **Sal Ignacius**
> ""The importance of the ceremony cannot be overstated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo, perhaps we can overlook my abstention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no reason why not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Sal Ignacius**
> ""As long as similar... *arrangements* can be made in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[213]`
  - -> `[216]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No promises, but my door is always open to further discussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was a one-time agreement. Be grateful you got any concessions at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[217]`
Mówca: **Sal Ignacius**
> ""Excellent. I look forward to a prosperous relationship in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[218]`
Mówca: **Narrator**
> "I wished Wiseman Ignacius goodbye and left the premises. Captain Gordion and his men followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[219]`
Mówca: **Narrator**
> "As my motorcade traveled down the highway, and the Archsacturary of Plavo faded from view, I reflected on all I had accomplished today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Narrator**
> "And hoped my future relationship with the wiscerer would remain amicable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[221]`
Mówca: **Sal Ignacius**
> ""Very well then. I will, of course, remain hopeful that you'll have a change of heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[222]`
Mówca: **Narrator**
> "I bid Wiseman Ignacius farewell and departed the premises, with Captain Gordion and his men following closely behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[223]`
Mówca: **Narrator**
> "As my motorcade journeyed down the highway, the Archsacturary of Plavo slowly disappearing from sight, I reflected on all I had achieved today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Narrator**
> "The wiscerer knew his place now. I just hoped he wouldn't need friendly *reminders* in the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[225]`
Mówca: **Sal Ignacius**
> ""Then please, let us proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[226]`
Mówca: **Sal Ignacius**
> ""If I may give you a piece of advice...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`
  - -> `[229]`
  - -> `[230]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not. Good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But hurry it up. I haven't got all day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""The throne you have inherited bestows great advantages, yet it also brings forth numerous adversities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[232]`
Mówca: **Sal Ignacius**
> ""It would be a shame if any unnecessary strains or hostilities were added to your troubles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I may give *you* a piece of advice... the door swings both ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You forget your place, Grand Wiseman. The onus lies not on the king to seek favor with others, but rather, it is others who should seek favor with the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted. I will take my leave. Good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""Heavens no! I'm simply saying... tread carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[239]`
Mówca: **Sal Ignacius**
> ""Well, in any case, I'm glad you're here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""Don't let my physical frailty fool you, Your Majesty. For the grace of God gives me unimaginable strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[242]`
  - -> `[241]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's what I like to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As he does with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[243]`
Mówca: **Titus Gordion**
> ""With pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[244]`
Mówca: **Sal Ignacius**
> ""What?! But my king, you must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My most sincere apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean no offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to repeat myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I can't. This is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[250]`
Mówca: **Sal Ignacius**
> ""And on the crown is a fracture on the golden band...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whose crown?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Sal Ignacius**
> ""Please don't interrupt, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""The higher it journeys upward, the larger the crack gets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Sal Ignacius**
> ""Whether or not it can be mended is uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[257]`
  - -> `[259]`
  - -> `[1002]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in it can be fixed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean it's uncertain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Sal Ignacius**
> ""The visions are possible outcomes of what could come to pass. They aren't set in stone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[264]`
  - -> `[265]`

### Węzeł `[261]`
Mówca: **Narrator**
> "His grip tightened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What else do you see?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[266]`
Mówca: **Sal Ignacius**
> ""I now see soldiers... Many soldiers... War... And death. So much death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""War with whom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whose soldiers? Are they ours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the victor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Sal Ignacius**
> ""I can not tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[271]`
Mówca: **Narrator**
> "I continued to listen closely to his words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Sal Ignacius**
> ""I now see two individuals... They are embraced in each other's arms... Lovers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Before me now is a heart... it's being stabbed by a sword.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[274]`
  - -> `[276]`
  - -> `[984]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A metaphor for betrayal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The death of a lover, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is starting to sound like utter nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[277]`
Mówca: **Sal Ignacius**
> ""Now, I behold an endless sea of people stretching as far as the eye can see... They are marching toward the royal palace... in joy or anger... I can not say for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Sal Ignacius**
> ""Above them are birds... tens of thousands of them so thick they blacken the sky... They are migrating from distant lands and making their nest in ours...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[279]`
  - -> `[281]`
  - -> `[985]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's obvious that the birds represent Wehzek Dastnurists coming to our lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The birds clearly represent Golcondists coming to our lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds to me like they represent literal birds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[282]`
Mówca: **Sal Ignacius**
> ""And on a nearby mountain overlooking the city sits a beast... a beast with three heads. Each head is fighting with the other...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Sal Ignacius**
> ""They must be brought under control, either through taming or severing one or more heads...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Sal Ignacius**
> ""...or all three will surely die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`
  - -> `[287]`
  - -> `[987]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's royal houses. Toras, Sazon and Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As it stands, Rizian lands are ruled under three different flags... Wehlen, The Grand Duchy of Pales, and our own... That could be the meaning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. I've heard enough of this bullshit. Let me go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[288]`
Mówca: **Narrator**
> "I felt Sal loosen his hold of me, letting go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_EyesOpen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_EyesOpen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_EyesOpen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Narrator**
> "I opened my eyes and looked at him curiously until he finally spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Narrator**
> "I looked at him curiously until he finally spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Sal Ignacius**
> ""The visions have stopped. Thus, concluding the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`
  - -> `[297]`
  - -> `[302]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait... I have so many questions I want to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still unsure what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[298]`
Mówca: **Narrator**
> "A part of me questioned whether or not what I'd experienced was real."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[299]`
Mówca: **Sal Ignacius**
> ""I don't have the answer you're looking for. It's now up to you to decipher their meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[300]`
Mówca: **Sal Ignacius**
> ""Good. For it's now up to you to decipher their meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[301]`
Mówca: **Sal Ignacius**
> ""Give it time. Their meaning will come to you soon enough. It's up to you to decipher them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't buy it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Sal Ignacius**
> ""It's not uncommon to have feelings of doubt. It's now up to you to decipher the meaning of said visions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Narrator**
> "After a long moment, during which he seemed to still be recovering, he spoke again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Before long, I was back on the road again -- back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Narrator**
> "As the Archsanctuary of Plavo faded from view, and my mind began to settle, I thought more about the visions, and what they meant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Welcome to the catacombs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[541]`
  - -> `[542]`
  - -> `[543]`

### Węzeł `[308]`
Mówca: **Narrator**
> "At the heart of the room stood a circle of six columns, each bearing a single star delicately carved upon them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[309]`
Mówca: **Narrator**
> "And if they were real, what my next steps should be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[310]`
Mówca: **Narrator**
> "Security guards held back a crowd of onlookers gathered along either side of the stairway leading up to the archsanctuary, where the Grand Wiseman stood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[311]`
Mówca: **Titus Gordion**
> ""Indeed. He is a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[327]`
  - -> `[324]`
  - -> `[325]`

### Węzeł `[312]`
Mówca: **Titus Gordion**
> ""I think he's an inspiration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`
  - -> `[330]`

### Węzeł `[313]`
Mówca: **Titus Gordion**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""Divus zaitu!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[316]`
Mówca: **Narrator**
> ""Divus zaitu" was Wruhecist for "May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[317]`
  - -> `[320]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And with you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please keep your religion to yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Titus Gordion**
> ""Of course. My most sincere apologies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A religious man, are you? Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't ask for your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Personal commentary isn't a part of your job description.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Titus Gordion**
> ""You're right. I was out of line. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to know that our opinions align.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't agree more. As long as his loyalty remains steadfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""Forgive me. I meant no offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse my bluntness. I apologize if I offended you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Titus Gordion**
> ""No offense taken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[332]`
Mówca: **Sal Ignacius**
> ""You are too kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[333]`
Mówca: **Sal Ignacius**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Sal Ignacius**
> ""Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[335]`
Mówca: **Sal Ignacius**
> ""I have no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[336]`
Mówca: **Sal Ignacius**
> ""After today, it shall be you who speaks for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[337]`
Mówca: **Sal Ignacius**
> ""As the Lord's representative on earth, I expect nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[338]`
Mówca: **Sal Ignacius**
> ""It pleases me to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[339]`
Mówca: **Sal Ignacius**
> ""I have. More than once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[340]`
Mówca: **Sal Ignacius**
> ""That's because you used to be a lot smaller. Memories of you first learning to walk are as vivid in my mind as if they were yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[344]`
  - -> `[674]`

### Węzeł `[341]`
Mówca: **Sal Ignacius**
> ""Indeed it does. I've been here more times than I can remember and still get choked up sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't remind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[343]`
Mówca: **Narrator**
> "I suddenly recalled how overjoyed I was to see Vina take her first steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How time flies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[345]`
Mówca: **Sal Ignacius**
> ""However, there are those who need a little spectacle to ignite that internal spark. This magnificent sanctuary serves that purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[346]`
Mówca: **Sal Ignacius**
> ""That is of course worrying, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[347]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[348]`
Mówca: **Sal Ignacius**
> ""I agree, Your Majesty, but King Valero was hesitant to let go of such a large sum at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[940]`

### Węzeł `[349]`
Mówca: **Sal Ignacius**
> ""So you'll go through with the ceremony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[199]`
  - -> `[350]`
  - -> `[653]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, though I still have reservations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[352]`
Mówca: **Sal Ignacius**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[353]`
Mówca: **Sal Ignacius**
> ""'Second thoughts?' But you have to go through with it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know where we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is the holiest of honors to be allowed here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> "“Why, Caelus the Devout, of course. The reason for this Archsanctuary's very existence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[357]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty. This is the tomb of Caelus the Devout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[358]`
Mówca: **Sal Ignacius**
> ""A most vicious foe. More than that, I cannot say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[359]`
Mówca: **Sal Ignacius**
> ""One of the armies, yes. Their uniforms carry the royal seal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: VisionHub1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[364]`
  - -> `[367]`
  - -> `[370]`
  - -> `[982]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]`

### Węzeł `[376]`
Mówca: **Sal Ignacius**
> ""One of them is of your blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[377]`
Mówca: **Sal Ignacius**
> ""Or arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: VisionHub2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[382]`
  - -> `[385]`
  - -> `[388]`
  - -> `[983]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [VisionHub2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Union.' As in marriage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[396]`
Mówca: **Sal Ignacius**
> ""It's a forbidden love or one of disapproval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Am I one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of love?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[399]`
Mówca: **Sal Ignacius**
> ""They are surrounded by people both for and against their union.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[400]`
Mówca: **Sal Ignacius**
> ""Perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[401]`
Mówca: **Sal Ignacius**
> ""Possibly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[402]`
Mówca: **Sal Ignacius**
> ""I can assure you, Your Grace, my visions are anything *but* nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[403]`
Mówca: **Sal Ignacius**
> ""If true, it could mean dark clouds on the horizon are fast approaching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[404]`
Mówca: **Sal Ignacius**
> ""It very well could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[405]`
Mówca: **Narrator**
> "The Grand Wiseman nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Sal Ignacius**
> ""Please do, Your Majesty. The spiritual health of our kingdom is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
EnactDecree("Religion_RestorationPlavoArchsanctuary");
RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project = true;
RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project = true;
RiziaDLC.Resources_Authority += 4;)*
- **Efekt (`userScript`):** `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
EnactDecree("Religion_RestorationPlavoArchsanctuary");
Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] = true;
Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project = true;
RiziaDLC.Resources_Authority += 2;)*
- **Efekt (`userScript`):** `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Religion_RestorationPlavoArchsanctuary");
RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project = true;
RiziaDLC.Resources_Authority += 2;)*
- **Efekt (`userScript`):** `EnactDecree("Religion_RestorationPlavoArchsanctuary");
Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`

### Węzeł `[411]`
Mówca: **Narrator**
> "The Grand Wiseman clapped his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Sal Ignacius**
> ""Excellent, Your Majesty! I look forward to seeing these pews lined with worshippers once more!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[413]`
Mówca: **Titus Gordion**
> ""We'll take it from here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[414]`
  - -> `[419]`
  - -> `[416]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well done, Captain. Take him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems I misjudged you after all, Captain Gordion. You have my thanks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, now you'll 'take it from here?' He should have never broken through your men in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Titus Gordion**
> ""Please accept my apology. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[418]`
Mówca: **Narrator**
> "The surprise visitor was shouting something, but I couldn't understand what he was saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Did you expect me to handle it myself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Titus Gordion**
> ""No. Of course not. I'll have this taken care of right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[421]`
Mówca: **Titus Gordion**
> ""It is my honor. My men will deal with this rogue accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was that man who I think he was?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say I cared for that little stunt, but I do wonder what the man wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see to it that the protester is locked away for quite some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the daredevil, that man. I'm inclined to know his motivation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[426]`
Mówca: **Sal Ignacius**
> ""I believe he was a Derdian Golcondist. He was wearing their traditional garb.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[663]`
  - -> `[664]`
  - -> `[647]`

### Węzeł `[427]`
Mówca: **Sal Ignacius**
> ""Judging by his wardrobe, he appeared to be a Derdian Golcondist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[663]`
  - -> `[664]`
  - -> `[647]`

### Węzeł `[428]`
Mówca: **Sal Ignacius**
> ""He was a Derdian Golcondist. I'd say his motivation was clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[663]`
  - -> `[664]`
  - -> `[647]`

### Węzeł `[429]`
Mówca: **Sal Ignacius**
> ""Plavo is one of the holiest places in all of Wruhecism. A belief that the Golcondists *claim* to hold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""There was a time when Golcondists prayed here in such small numbers that their presence was tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[431]`
Mówca: **Narrator**
> "We continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Sal Ignacius**
> ""I hope that man is duly punished for his actions. We wouldn't want others following his example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[433]`
Mówca: **Sal Ignacius**
> ""Apart from the Golcondists, we have seen a rising Dastnurist minority due to the growing numbers of migrants from Wehlen and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[238]`
  - -> `[19]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fascinating. I'd love to hear more about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time to bother with corpses. We've got a ceremony to perform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = true; RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = true;
Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[452]`
Mówca: **Sal Ignacius**
> ""We shouldn't delay the ceremony much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Sal Ignacius**
> ""But very well. Who would you like to know about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DeadBodyHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[464]`
  - -> `[467]`
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA: "First tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the first tomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[456]`
**[WYBÓR GRACZA: "Second tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the second tomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[457]`
**[WYBÓR GRACZA: "Third tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the third tomb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[470]`
Mówca: **Sal Ignacius**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Briefing_Religion_Body00 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body00"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[475]`
Mówca: **Narrator**
> "In an adjacent room, there were several tombs, each adorned with intricate decorations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[476]`
Mówca: **Sal Ignacius**
> ""Here lies Bredus Azaro, the first Duke of Montaklar. All members of the Royal House of Azaro are descended from him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Sal Ignacius**
> ""The damage to his tomb was another casualty of the Golcondist pilgrims when a piece of the above ceiling came crashing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[481]`
Mówca: **Sal Ignacius**
> ""Thanks to the funds that will now be put toward repairs, poor Bredus can finally be re-laid to rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [DeadBodyHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[483]`
Mówca: **Sal Ignacius**
> ""That would be the tomb of Talerius Azaro. Not only was he the Earl of Havas, he was the most revered general during the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[484]`
Mówca: **Sal Ignacius**
> ""Even though House Azaro ultimately lost the war, the general never lost a single battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Sal Ignacius**
> ""After the war, he established Camp Domus -- Rizia's largest military base to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[491]`
  - -> `[490]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[489]`
Mówca: **Narrator**
> "His mentioning of Camp Domus flooded my mind with fond memories of my time there as a young recruit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm quite familiar with his reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even though he fought against House Toras, I still hold him in the highest respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He may be revered by some, but I never much cared for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[493]`
Mówca: **Sal Ignacius**
> ""That would be Aurelia Itxaro. If you remember your history, he was the famed industrialist of the 19th Century whose revolutionary mining equipment led to the Second Rizian Gold Rush.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Sal Ignacius**
> ""While he isn't of royal lineage, his legacy earned him a place amongst them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]`
  - -> `[922]`
  - -> `[923]`

### Węzeł `[495]`
Mówca: **Sal Ignacius**
> ""He single-handedly brought incomprehensible wealth to this kingdom overnight, granting us enduring power and influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[497]`
Mówca: **Narrator**
> "He paused with his hand on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = false; RiziaDLCSupport.Journal_Turn01_Ceremony_Refused = true;
RiziaDLC.PersonalValue_BrokeTradition += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = false;
Variable["RiziaDLCSupport.Journal_Turn01_Ceremony_Refused"] = true;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn01_Ceremony_Participated = true; RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn01_Ceremony_Participated"] = true;
Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[502]`
Mówca: **Narrator**
> "Partway up the stairs, I heard Titus and his men apprehending the assailant. Sal hobbled up behind me, panting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that where you keep the torch-er chamber?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[507]`
Mówca: **Narrator**
> "Given his ambivalence towards me, his reply should have come as no surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[508]`
Mówca: **Narrator**
> "Though I wished he'd given more insight on what to expect, I respected Father's vow of secrecy and didn't press the issue further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[509]`
**[WYBÓR GRACZA: "Conduct their applause."]** — Mówca: **Player_Romus_Italic**
> "I encouraged them to cheer even louder by raising my hand in the air like the conductor of the Rizian Royal Symphony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[510]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I ignored them and kept my head down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Narrator**
> "Eager to follow along, they got louder the higher my hand raised, and quieter when I brought it down low."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[512]`
Mówca: **Narrator**
> "The onlookers' enthusiasm diminished as I dismissively made my way past. They clearly had expected a show."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[513]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Romus_Italic**
> "I gave them a royal wave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Narrator**
> "The shouts of admiration resonated even louder from my subjects."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[515]`
**[WYBÓR GRACZA: "Recite a Wruhecist proverb."]** — Mówca: **Player_Romus_Italic**
> ""Laeteum cordeplenum quivoson Desiranto!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Narrator**
> "The old Wruhecist proverb translated to "Let joy fill the hearts of those who seek the Lord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Narrator**
> "In unison, the crowd shouted, "Lusel Dominatun Deunon; senkusant pactum denborarik!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IntruderTakenAway)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[422]`
  - -> `[424]`
  - -> `[425]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IsEverythingAlright)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IFollowedtheWiscerer)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1003]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DownTunnelHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[523]`
Mówca: **Narrator**
> "Titus quickly exited the vehicle and opened my side door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[524]`
Mówca: **Titus Gordion**
> ""These people look like they could give you trouble. Shall I have them removed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`
  - -> `[527]`
  - -> `[528]`

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have them removed immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really had to ask? Get those traitors the hell out of my sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, they have the right to protest, even if I disagree with their cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them protest, Captain, seeing as how this issue holds significant importance to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1; RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[530]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[531]`
Mówca: **Titus Gordion**
> ""Of course. Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[532]`
Mówca: **Titus Gordion**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1; 
RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = true; 
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[534]`
Mówca: **Narrator**
> "I turned back toward the crowd. They were still applauding me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[513]`
  - -> `[836]`
  - -> `[510]`

### Węzeł `[535]`
Mówca: **Titus Gordion**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1; RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[537]`
Mówca: **Narrator**
> "He cast an intimidating glare at the protesters as we passed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[538]`
Mówca: **Narrator**
> "He cast an intimidating glare at the protesters as we passed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[539]`
Mówca: **Narrator**
> "Captain Gordion quietly spoke to several nearby guards who began herding the protesters away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[540]`
Mówca: **Narrator**
> "The captain barked at several nearby guards to remove the protesters, and they began clearing them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How morbidly disturbing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm tempted to knock to see if anyone's home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[545]`
Mówca: **Narrator**
> "Despite my apprehension, I took his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. The sooner we get this over with the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I sincerely hope you can find it in your heart to forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I'll be sure to keep that in mind if ever you should come groveling on your knees asking for *my* consent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Narrator**
> "The wiscerer went silent. Though he outwardly remained calm, the sliver of vexation in his eyes was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[551]`
Mówca: **Sal Ignacius**
> ""It's not forgiveness from you that you should be seeking, but forgiveness from God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Sal Ignacius**
> ""I must stay here until the visions run their course. Please find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Narrator**
> "He closed his eyes and began trembling. I ignored him, put on my clothes, and made my way back through the catacombs until I'd reach the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[556]`
Mówca: **Sal Ignacius**
> ""You only just inherited the throne -- an appointment that comes with the greatest of responsibilities -- so allow me to offer you some advice...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[557]`
  - -> `[558]`
  - -> `[559]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yeah? And what's that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But keep it brief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*Unsolicited* advice. But do go on. I want to hear what you have to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Request denied. Good day, Grand Wiseman. I'll see myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[561]`
Mówca: **Sal Ignacius**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[562]`
Mówca: **Sal Ignacius**
> ""What I wanted to say was... burn too many bridges -- especially this early into your reign -- and you may find yourself marooned on a deserted shore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[563]`
Mówca: **Narrator**
> "Wary as I was, I relented and did as he requested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[564]`
Mówca: **Narrator**
> "I put on my clothes, and made my way back through the catacombs until I'd reached the surface -- the events of today, forever burned in my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you need my hands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's this about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Kindly keep your distance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I haven't changed my mind about that. However... perhaps we can overlook my abstention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[571]`
Mówca: **Sal Ignacius**
> ""That's asking a lot. The importance of the ceremony cannot be overstated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[584]`
  - -> `[573]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I made it worth your while?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I told you there would be consequences for defying the king's wishes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[574]`
Mówca: **Sal Ignacius**
> ""Then I would tell you that repercussions are of no concern to me. I stand on the side of God. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`
  - -> `[575]`

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, Your Holiness, it seems we've reached an impasse. I'll see myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A man with convictions... It's a rarity these days. I respect that. Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well then... now that we better understand each other, perhaps we can one day channel that newfound knowledge toward seeing eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Sal Ignacius**
> ""Perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[579]`
Mówca: **Sal Ignacius**
> ""Divus zaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`
  - -> `[582]`
  - -> `[585]`
  - -> `[583]`

### Węzeł `[580]`
Mówca: **Sal Ignacius**
> ""Next time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Divus zaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Forget what I said. 'Til next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say the same about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[586]`
Mówca: **Sal Ignacius**
> ""Make no mistake... In matters of upholding principles, my steadfastness knows no bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[587]`
Mówca: **Sal Ignacius**
> ""While I have my reservations about what you're suggesting... My curiosity far outweighs my skepticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`
  - -> `[590]`
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I expect nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meaning?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to future discussions. Maybe then I can nurture your curiosity even further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I look forward to speaking to you about future... arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[592]`
Mówca: **Sal Ignacius**
> ""We shall see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[593]`
Mówca: **Sal Ignacius**
> ""As I with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[594]`
Mówca: **Sal Ignacius**
> ""That I may be old, but I know which way to move when the wind blows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`
  - -> `[599]`
  - -> `[600]`
  - -> `[603]`

### Węzeł `[595]`
Mówca: **Sal Ignacius**
> ""I look forward to speaking more about this with you at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[596]`
Mówca: **Narrator**
> "The tense interaction with the grand wiseman and the friction that came with it wasn't beneficial for anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[597]`
Mówca: **Narrator**
> "As my motorcade journeyed down the highway and the Archsacturary of Plavo gradually disappeared from sight, I reflected on all I had achieved today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to hear. I underestimated you, Your Holiness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to be around someone who is so easily swayed. Forget it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I look forward to future *arrangements* between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Sal Ignacius**
> ""Most do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[602]`
Mówca: **Sal Ignacius**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as the wind continues to blow in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[604]`
Mówca: **Sal Ignacius**
> ""Yes, of course. Though predicting the weather can be a tricky thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[606]`
Mówca: **Narrator**
> "I wished Sal goodbye and left the premises. Captain Gordion and his men followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[607]`
Mówca: **Sal Ignacius**
> ""Well, I'm sorry to hear that. However, in the future, I suggest not being so quick to slam the door shut when opportunities present themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[608]`
Mówca: **Sal Ignacius**
> ""Go on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[611]`
  - -> `[610]`
  - -> `[609]`

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in, any *kindness* bestowed upon me will be reciprocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meaning, I won't feel the need to seek *alternatives* to convince you to be more compliable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in, you keep your position as Grand Wiseman and aren't replaced by someone more... agreeable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That if you do me this one small favor, another small favor will be returned to you should the time come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[613]`
Mówca: **Sal Ignacius**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[614]`
Mówca: **Sal Ignacius**
> ""Do what you must. But I stand on the side of riotousness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`

### Węzeł `[615]`
Mówca: **Sal Ignacius**
> ""Now, now... let's not be hasty. You wouldn't want to do anything that might disrupt the balance between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[616]`
Mówca: **Sal Ignacius**
> ""If you insist. However, if you get a knock back, I'd suggest we vacate this place as soon as humanly possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[618]`
Mówca: **Sal Ignacius**
> ""Indeed it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[619]`
Mówca: **Sal Ignacius**
> ""Our departed friends won't be coming back to life anytime soon, in case you were worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[623]`
Mówca: **Sal Ignacius**
> ""Most amusing. If it's torture you want, the soprano section of the Wruhecist Tabernacle Choir will do the trick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's down there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going to catch the plague, I know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How medieval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[627]`
Mówca: **Sal Ignacius**
> ""The path ahead leads us to one of the holiest sites in Wruhecism. Believe me, it has undergone thorough purification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[628]`
Mówca: **Sal Ignacius**
> ""Come and see for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[629]`
Mówca: **Sal Ignacius**
> ""Believe me, this is only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = false; RiziaDLC.Country_PublicOpinion += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway"] = false;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[634]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[635]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into funding these projects as soon as the Treasury allows it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[636]`
Mówca: **Narrator**
> "The Grand Wiseman clasped his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[638]`
Mówca: **Narrator**
> "We eventually reached an imposing iron door. Behind it was a descending spiral staircase illuminated by torches mounted on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`
  - -> `[624]`
  - -> `[625]`
  - -> `[503]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's in the coffin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Stress", "R_Stress_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[644]`
Mówca: **Narrator**
> "Decorated in gold, I would have considered it the most splendid of all if not for the hole in the lid, through which I could catch a glimpse of the skeletal remains within."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm ready to move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[646]`
Mówca: **Sal Ignacius**
> ""Splendid! Then let us proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would a Derdian Golcondist be doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[648]`
Mówca: **Narrator**
> "Dastnurity was the other main branch of the Nurist religion, observed in most countries to our north. Its followers relied on the writings of St. Dast as the only pure scripture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[649]`
Mówca: **Sal Ignacius**
> ""Come. It is time you saw what they did to this very building. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my own ways of honoring God, and this is not one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, there's a first time for everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[652]`
Mówca: **Narrator**
> "But whether or not our little row could be rectified, I would prepare for any eventuality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Abstension_hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[79]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[657]`
Mówca: **Narrator**
> "Sal closed his eyes and tilted his head up slightly, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[889]`
  - -> `[892]`
  - -> `[896]`
  - -> `[632]`

### Węzeł `[658]`
Mówca: **Narrator**
> "One was waving a sign that read, "Golcondism Is Not Blasphemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`
  - -> `[661]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Demanding entrance to our sacred Wruhecist space... I hope he gets what's coming to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't know Derdia's fundamentalism had gotten this out of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not surprised at his actions. When you deprive a man of religious freedom, this is the consequence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[665]`
Mówca: **Sal Ignacius**
> ""It is not 'freedom' that motivates these men, but blood lust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[666]`
Mówca: **Sal Ignacius**
> ""Alas, our Derdian brothers have strayed far from God's path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[667]`
Mówca: **Sal Ignacius**
> ""Do not be too harsh towards our Derdian brothers. They know not what they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[668]`
Mówca: **Sal Ignacius**
> ""But the more Derdians came to Rizia, the more they overwhelmed the sacred sanctuaries of Plavo, Benievon, and Jales with their blasphemous version of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[669]`
Mówca: **Sal Ignacius**
> ""They aim to trace the footsteps of Wruhec's disciples through what is now Merkopa. Which necessitates visiting their final resting places.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[670]`
Mówca: **Sal Ignacius**
> ""I did so with a heavy heart. But our sanctuaries are a place of peace. They are not for those who exalt violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[671]`
Mówca: **Sal Ignacius**
> ""The Golcondists have a martial culture, Your Majesty. They seek purification through violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[672]`
Mówca: **Sal Ignacius**
> ""Among other perversions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[673]`
Mówca: **Sal Ignacius**
> ""But our sanctuaries are places of peace. They are not for those who exalt violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_DistantAsDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[677]`
Mówca: **Narrator**
> "I tried to remember Vina taking her first steps, but could not. I must have been absent at the time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`
  - -> `[680]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[681]`
Mówca: **Narrator**
> "Sal gestured over our heads to the second-floor gallery overlooking the hall. Part of it had collapsed, and the rest had been roped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`
  - -> `[682]`
  - -> `[684]`
  - -> `[688]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to say, the disheveled look gives the place character.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[683]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It looks to have seen better days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a shame what happened to such a magnificent building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[685]`
Mówca: **Sal Ignacius**
> ""That's putting it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[686]`
Mówca: **Sal Ignacius**
> ""Many congregates don't share your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[687]`
Mówca: **Sal Ignacius**
> ""I couldn't agree more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[688]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religious fanaticism will do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[689]`
Mówca: **Sal Ignacius**
> ""The collapse was entirely preventable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[690]`
Mówca: **Narrator**
> "Sal began to pace around the altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[691]`
Mówca: **Sal Ignacius**
> ""Rizia's religious climate is at a crossroads, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[692]`
Mówca: **Sal Ignacius**
> ""From aiding the impoverished to expanding educational opportunities, our faith-based institutions are a cornerstone of everyday life, strengthening the bonds that hold our society together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[693]`
Mówca: **Sal Ignacius**
> ""All under the umbrella of our state religion, Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`
  - -> `[696]`
  - -> `[698]`
  - -> `[703]`

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“As it should be. I know I’d be lost without Wruhecism to show me the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[696]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Should religion really be playing such a large role in modern society?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could have fooled me. I look around and I see heretics and blasphemers everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are forgetting religion's most important role of all. That of pacifying the populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[704]`
Mówca: **Sal Ignacius**
> ""Our modern world is fractured, Your Majesty. Morality is faltering. We need God more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[705]`
Mówca: **Sal Ignacius**
> ""As would I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[706]`
Mówca: **Sal Ignacius**
> ""Indeed, our religious unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[707]`
Mówca: **Sal Ignacius**
> ""But our religious unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[708]`
Mówca: **Sal Ignacius**
> ""Surely you have noticed our religious unity beginning to splinter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[709]`
Mówca: **Sal Ignacius**
> ""It is true that sharing a single belief system fosters unity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[710]`
Mówca: **Sal Ignacius**
> ""But sadly, that unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[711]`
Mówca: **Narrator**
> "Lena had been a follower, but converted to Wruhecism on joining the Rizian royal family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Narrator**
> "A sacrifice, but one she gladly made in order to be with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[716]`
Mówca: **Narrator**
> "Her resentment over the sacrifice was palpable throughout our marriage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[717]`
Mówca: **Sal Ignacius**
> ""I would never counsel this country to turn away people in need, Your Majesty. But I do worry that our Wruhecist values are in danger of becoming diluted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[69]`
  - -> `[72]`
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Sal Ignacius**
> ""That's very kind, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`
  - -> `[721]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be honest with you. I don't particularly care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Sal Ignacius**
> ""Many in this country do, Your Majesty. Ask your uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Narrator**
> "He stopped pacing and looked around the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[725]`
Mówca: **Narrator**
> "He pointed once more to the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[726]`
Mówca: **Sal Ignacius**
> ""The Crown has funded and nurtured religious institutions since our kingdom's very founding. And for good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[937]`

### Węzeł `[727]`
Mówca: **Sal Ignacius**
> ""No Rizian king or queen has ever rejected the holy consecration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`
  - -> `[650]`
  - -> `[164]`
  - -> `[165]`

### Węzeł `[728]`
Mówca: **Narrator**
> "Sal looked apoplectic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`
  - -> `[731]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[732]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`
  - -> `[734]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[735]`
Mówca: **Narrator**
> "Having memorized them years ago, I recited them in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[736]`
Mówca: **Narrator**
> "He slowly fed the words to me, and I repeated them back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. Um... I don't drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[738]`
Mówca: **Sal Ignacius**
> ""Only the most pious and reverent of men may drink from the sacred chalice, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""About time! I need a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Refuse Ceremony)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Refuse Ceremony])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Ceremony)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[743]`
Mówca: **Narrator**
> "We continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[744]`
Mówca: **Sal Ignacius**
> ""You made the right decision in removing the protesters, Your Majesty. We would not have wanted them disrupting our ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`
  - -> `[748]`
  - -> `[753]`

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Golcondism Is Not Blasphemy?' How dare they challenge our religious laws?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[746]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Who do you think they were?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[747]`
Mówca: **Sal Ignacius**
> ""Definitely Golcondists. Derdian ones, judging by their garb.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[748]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The guards went too easy on them. They should have locked up the whole lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those poor lost souls. Is there any hope for them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[751]`
Mówca: **Sal Ignacius**
> ""The Golcondists have been irate ever since we began denying them entrance to 'their' holy sites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[752]`
Mówca: **Sal Ignacius**
> ""Be not too harsh on our Derdian Golcondist brethren. They may yet find their way back to the path of righteousness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[756]`
Mówca: **Sal Ignacius**
> ""Only if they give up their twisted form of Wruhecism and return to the correct path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[757]`
Mówca: **Sal Ignacius**
> ""A large group of Golcondists came here on one of their holy pilgrimages from Derdia several years ago. An argument with the local Wruhecist worshippers led to an... altercation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`
  - -> `[759]`
  - -> `[760]`
  - -> `[761]`

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those beasts. Praise the Lord it won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[759]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure the locals didn't start it? The inhabitants of Cardesse-Montaklar are not exactly conflict-averse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the only reason for our blasphemy law?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[761]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why has it not been fixed since then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[762]`
Mówca: **Sal Ignacius**
> ""It was the feather that tipped the scale, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[763]`
Mówca: **Sal Ignacius**
> ""We will get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[764]`
Mówca: **Sal Ignacius**
> ""I assure you, the warrior culture of the Derdians makes the Azaros look meek.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[765]`
Mówca: **Sal Ignacius**
> ""Halaita. If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I'm not thirsty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`
  - -> `[769]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[769]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Sal Ignacius**
> ""That will not be you. At least not today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[771]`
Mówca: **Sal Ignacius**
> ""That will not be you. Not today, and possibly not ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[772]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This ceremony has exceeded the limits of reason. I cannot participate in good conscience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[773]`
Mówca: **Sal Ignacius**
> ""This not a promising start to your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`
  - -> `[776]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[776]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[777]`
Mówca: **Sal Ignacius**
> ""I sense skepticism in you, Your Majesty. But please know that as the King of Rizia, the will of the Divine now courses through your veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[778]`
Mówca: **Sal Ignacius**
> ""It is your responsibility to carry out what He has ordained. And it is mine to aid you in your holy duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`
  - -> `[781]`
  - -> `[782]`
  - -> `[783]`

### Węzeł `[779]`
Mówca: **Sal Ignacius**
> ""Surely you now feel it, Your Majesty. The will of the Divine coursing through your veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a heavy burden, Grand Wiseman. But I accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am an instrument of nobody. Not God, and definitely not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray that He and you will guide me to do what is best for our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must confess that I'm not entirely convinced about what transpired here today. But if it helps appease the masses, count me in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[784]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[786]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[787]`
Mówca: **Sal Ignacius**
> ""You will see the light one day. I am confident of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[788]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[975]`

### Węzeł `[789]`
Mówca: **Narrator**
> "I nodded in agreement at the ancient Wruhecist term. It was short for "Decensi halaita veretan": "If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[793]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[794]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[796]`
Mówca: **Narrator**
> "Only a select few, such as Grand Wiseman and religious councilor Sal Ignacius, were privy to what the ceremony entailed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[797]`
Mówca: **Narrator**
> "As I stepped out and onto the pavement, I was immediately greeted by the roar of a crowd that had come to witness my arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[798]`
Mówca: **Narrator**
> "I performed variations of this toward different sections of the crowd, much to their amusement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[799]`
Mówca: **Narrator**
> "It was the traditional reply meaning, "He is the Lord our God; his covenant is everlasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[800]`
Mówca: **Sal Ignacius**
> ""I know he wished to return this sacred Wruhecist site to its former grandeur. He agreed with me that state funds should be allocated for the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[801]`
Mówca: **Narrator**
> "Amidst the commotion, one managed to slip from their grasp and dashed towards me with frightening speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[38]`

### Węzeł `[802]`
Mówca: **Narrator**
> "After my flesh was fully coated, he set aside the jug and sponge, reaching for the chalice and bottle of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[803]`
Mówca: **Narrator**
> "If it was, did I accept the responsibility that came with my consecration?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[804]`
Mówca: **Sal Ignacius**
> ""That's the gift and the curse that comes with the divine right of the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[805]`
Mówca: **Narrator**
> "Did I really speak for the Divine?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[806]`
Mówca: **Sal Ignacius**
> ""A lamb... I see a charming little lamb...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_EyesOpen = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_EyesOpen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`
  - -> `[810]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_EyesOpen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[810]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_EyesOpen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[811]`
Mówca: **Narrator**
> "He paused, deep in thought, then let out a small laugh, smiling to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[812]`
Mówca: **Narrator**
> "He paused, deep in thought, then let out a small laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[813]`
Mówca: **Sal Ignacius**
> ""Once separated from its flock by a great wolf, it now reunites with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`
  - -> `[814]`
  - -> `[816]`
  - -> `[986]`

### Węzeł `[814]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It clearly speaks of Zille's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[815]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bringing the faithful back into the fold, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[816]`
**[WYBÓR GRACZA: "Sigh in frustration."]** — Mówca: **Player_Romus_Italic**
> "I sighed in frustration as I grew increasingly tired of this charade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[817]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[818]`
Mówca: **Sal Ignacius**
> ""Interrupting the ritual will have long-lasting consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[819]`
Mówca: **Narrator**
> "There was a flash of irritation in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[820]`
Mówca: **Sal Ignacius**
> ""More often than not, friends and foes are indistinguishable from one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[821]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless you're aiming for a medieval revival of the Dark Ages...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[822]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I've made myself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[823]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now if you'll excuse me, I'll see myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[825]`
Mówca: **Sal Ignacius**
> ""But in light of your generous support, I see no reason why the public has to no any differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[826]`
Mówca: **Sal Ignacius**
> ""However, keeping an open mind through curiosity and skepticism lies at the heart of Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[827]`
Mówca: **Sal Ignacius**
> ""That would be much appreciated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[828]`
Mówca: **Sal Ignacius**
> ""The only convincing you need isn't from me but from God. And He isn't so easily swayed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[829]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`
  - -> `[832]`

### Węzeł `[831]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[832]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[833]`
Mówca: **Narrator**
> "I nodded in agreement at the ancient Wruhecist term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`
  - -> `[838]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[838]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[839]`
Mówca: **Sal Ignacius**
> ""Rightly so. Nobody should attack the King of Rizia, especially not for upholding our religious laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[840]`
Mówca: **Narrator**
> "He made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“He got all this just for *teaching*? My own final resting place had better be even grander.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`

### Węzeł `[842]`
Mówca: **Sal Ignacius**
> ""To use one's wisdom to enlighten others is to do the Lord's work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[844]`
Mówca: **Sal Ignacius**
> ""I would like to think I am honoring Caelus the Devout's legacy by passing my own limited knowledge to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[845]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[846]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Ceremony])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[847]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`
  - -> `[849]`

### Węzeł `[848]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[115]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[850]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The holy books do tell of mystical events occurring on this site, but they are unclear as to their nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[851]`
Mówca: **Sal Ignacius**
> "“I shall enlighten you. This is where Caelus received the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[852]`
Mówca: **Sal Ignacius**
> "“I refer to the miracle of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[853]`
Mówca: **Sal Ignacius**
> ""I have spent the past weeks cloistered here, fasting and praying, in order to transform myself into a vessel for the visions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[854]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having said that... can't you overlook my abstention? I don't want news getting out that I refused this rite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[855]`
Mówca: **Sal Ignacius**
> ""Are you asking a holy man to lie, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[856]`
Mówca: **Sal Ignacius**
> ""You prioritized it over Plavo's restoration, despite my advice. And you wish to be rewarded for it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[584]`
  - -> `[573]`

### Węzeł `[857]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`
  - -> `[859]`

### Węzeł `[858]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[859]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[860]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[861]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]`
  - -> `[863]`

### Węzeł `[862]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[863]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[864]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_Religion_DivusZaitu = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[866]`
Mówca: **Narrator**
> "One of the Grand Wiseman priests handed him a wooden case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[867]`
Mówca: **Sal Ignacius**
> ""In honor of this momentous day, I would like to bestow upon you one of the most sacred Nurist relics in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[868]`
Mówca: **Narrator**
> "He opened the case to reveal an intricately decorated scepter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`

### Węzeł `[869]`
Mówca: **Sal Ignacius**
> ""St. Dast's Scepter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]`

### Węzeł `[870]`
Mówca: **Sal Ignacius**
> ""It was said that before the time of St. Wruhec, master artisan Dorian Etxeberria had a vivid dream in which St. Dast appeared, urging him to create the scepter to encapsulate the Pillars of Nurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[871]`
Mówca: **Sal Ignacius**
> ""Driven by this divine vision, Dorian meticulously designed and forged the scepter, believing it to be his sacred duty to honor the saint's legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`

### Węzeł `[872]`
Mówca: **Sal Ignacius**
> ""And now, I give it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`
  - -> `[877]`

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shall wield this with pride, so all who see me will be reminded that I walk in Nur's holy light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[930]`

### Węzeł `[874]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that while we espouse the six tenets of Wruhecism now, it was St. Dast who created the original foundations of our faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]`

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am deeply humbled and profoundly grateful for this extraordinary honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[876]`
**[WYBÓR GRACZA: "Take the scepter."]** — Mówca: **Player_Romus_Italic**
> "I took the scepter from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]`

### Węzeł `[877]`
**[WYBÓR GRACZA: "Don't take the scepter."]** — Mówca: **Player_Romus_Italic**
> "I didn't take the scepter from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`
  - -> `[931]`
  - -> `[879]`
  - -> `[880]`

### Węzeł `[878]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm honored, but I believe it would be better suited under your esteemed care and guardianship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[879]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have enough scepters. You keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[880]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the gesture, but I'm not worthy of such a gift.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[881]`
Mówca: **Sal Ignacius**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[882]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Leaving Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[883]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Leaving Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[884]`
Mówca: **Sal Ignacius**
> ""Sanctuaries such as this one are at the core of our religious communities. Without a place to congregate, the faithful are left wandering without guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]`

### Węzeł `[885]`
Mówca: **Sal Ignacius**
> ""And I am sorry to say your father -- Nur bless his soul -- left us with quite a bit of work to do with regard to their upkeep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[886]`
Mówca: **Sal Ignacius**
> ""Afraid of angering one religious group by prioritizing the needs of the other, he funded neither.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]`

### Węzeł `[887]`
Mówca: **Sal Ignacius**
> ""This may be true, but Wehlen and Rumburg are both watching our treatment of Dastnurists closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]`

### Węzeł `[888]`
Mówca: **Sal Ignacius**
> ""Focusing on the restoration of Plavo will strengthen our domestic Wruhecist community, but ignoring the plight of Dastnurists may damage our international standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[889]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`
  - -> `[891]`

### Węzeł `[890]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[891]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You brought me here to make a funding decision, under the guise of a ritual? The greed of the Sanctuary truly knows no bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[893]`
Mówca: **Narrator**
> "The holy man withdrew, looking hurt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]`

### Węzeł `[894]`
Mówca: **Sal Ignacius**
> ""My intention was not to pressure you, only to inform you of the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[895]`
Mówca: **Sal Ignacius**
> ""But now that you have seen the state Plavo is in, I am sure you understand how urgently it must be restored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`
  - -> `[918]`
  - -> `[908]`
  - -> `[911]`

### Węzeł `[896]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are in a holy place, Grand Wiseman. I refuse to sully it with deliberations over finances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]`

### Węzeł `[897]`
Mówca: **Narrator**
> "The holy man drew in his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]`

### Węzeł `[898]`
Mówca: **Sal Ignacius**
> ""You are absolutely right, Your Majesty. Now is not the time to speak of such vulgar things as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]`

### Węzeł `[899]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]`

### Węzeł `[900]`
**[WYBÓR GRACZA: ""Don't worry, Plavo will get its funding. But next time, come straight out and ask me." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Don't worry, Plavo will get its funding. But next time, come straight out and ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]`

### Węzeł `[901]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`
  - -> `[903]`

### Węzeł `[902]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]`
  - -> `[906]`

### Węzeł `[903]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[904]`
Mówca: **Narrator**
> "Sal bowed in gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[905]`
Mówca: **Sal Ignacius**
> ""Of course, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[906]`
**[WYBÓR GRACZA: ""Quite the contrary. Plavo can wait. I'll allocate funds for that Dastnurist Grandsanctuary you mentioned." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Quite the contrary. Plavo can wait. I'll allocate funds for that Dastnurist Grandsanctuary you mentioned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]`

### Węzeł `[907]`
Mówca: **Narrator**
> "Sal nodded, clearly disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[908]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand when I'm being manipulated. Don't bother me with these requests again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]`

### Węzeł `[909]`
Mówca: **Narrator**
> "He nodded hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[910]`

### Węzeł `[910]`
Mówca: **Sal Ignacius**
> ""I won't, Your Majesty. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[911]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I prefer it this way. It reminds one that God is as capable of destruction as He is of creation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]`

### Węzeł `[912]`
Mówca: **Sal Ignacius**
> ""Y-yes, it is beautiful in its own way...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]`

### Węzeł `[913]`
Mówca: **Sal Ignacius**
> ""At any rate, I will trouble you with this no further. It is almost time for the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[914]`
Mówca: **Sal Ignacius**
> "“If you'll allow me, we shall proceed with the Consecration of the King ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[915]`
Mówca: **Sal Ignacius**
> ""This is a most auspicious start to today's ceremony. And God willing, it is only the beginning of Rizia's religious renaissance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[916]`
Mówca: **Sal Ignacius**
> ""Let us proceed with your consecration at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[917]`
Mówca: **Sal Ignacius**
> ""For now, let us proceed with your consecration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luckily for you, the well-being of Rizia's religious communities is important to me. I will consider your requests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[919]`

### Węzeł `[919]`
Mówca: **Narrator**
> "Sal bowed in gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[920]`

### Węzeł `[920]`
Mówca: **Sal Ignacius**
> ""Most kind of you, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[921]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A commoner, buried among the Montaklar nobility? What an insult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[926]`

### Węzeł `[922]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pioneer to whom we all owe a debt of gratitude. Rizia could use more innovators like him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]`

### Węzeł `[923]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's his fault Rizia became so reliant on resources. Perhaps we would have been better off leaving that gold in the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]`

### Węzeł `[924]`
Mówca: **Sal Ignacius**
> ""As long as they remember that it is by the Lord's grace, not man's, that Rizia is blessed with such abundant resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[925]`
Mówca: **Sal Ignacius**
> ""The Lord put that gold in the ground to enrich our nation, Your Majesty. So that we may better exalt His good name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[926]`
Mówca: **Sal Ignacius**
> ""With the love of God in his heart, any man can achieve greatness. No matter how lowborn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[927]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_DastScepter");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_DastScepter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[874]`
  - -> `[873]`
  - -> `[928]`

### Węzeł `[928]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A big stick. How useful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[929]`

### Węzeł `[929]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[930]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[931]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This represents Dast's eleven pillars, not Wruhec's six core tenets. Dastnurists will see it as an endorsement of their faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]`

### Węzeł `[932]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]`

### Węzeł `[933]`
Mówca: **Sal Ignacius**
> ""I see the scepter as a reminder of our shared Nurist origins. Our Wruhec refined the teachings of St. Dast. He did not contradict them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[934]`

### Węzeł `[934]`
Mówca: **Sal Ignacius**
> ""But as you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[935]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_DastnuristOpinion += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Country_DastnuristOpinion"] = Variable["RiziaDLC.Country_DastnuristOpinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[936]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Sanctuary Q Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[967]`
  - -> `[949]`
  - -> `[945]`
  - -> `[970]`

### Węzeł `[937]`
Mówca: **Sal Ignacius**
> ""The more robust our many religious communities are, the greater the tithings we can collect for the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]`

### Węzeł `[938]`
Mówca: **Sal Ignacius**
> ""To put it in earthly terms... keep Rizia's faithful happy, and new sanctuaries will pay for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1004]`

### Węzeł `[939]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Why was he so afraid of angering Dastnurists? They make up only a small part of the population, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]`

### Węzeł `[940]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]`
  - -> `[942]`

### Węzeł `[941]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]`

### Węzeł `[942]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]`

### Węzeł `[943]`
Mówca: **Sal Ignacius**
> ""Rightfully so, considering the state of our treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[962]`

### Węzeł `[944]`
Mówca: **Sal Ignacius**
> ""Considering the state of our treasury, I don't know what he was worried about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[953]`

### Węzeł `[945]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]`
  - -> `[947]`

### Węzeł `[946]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[939]`

### Węzeł `[947]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[948]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Dastnurists = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`

### Węzeł `[949]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]`
  - -> `[951]`

### Węzeł `[950]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[951]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[952]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[953]`
Mówca: **Sal Ignacius**
> ""With the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order. And from there, we can construct new sanctuaries all over the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]`
  - -> `[955]`
  - -> `[956]`
  - -> `[963]`

### Węzeł `[954]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So that more people may bask in God's glory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[957]`

### Węzeł `[955]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get what you're saying. If we keep our people busy with religion, we won't have to worry about them turning against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[959]`

### Węzeł `[956]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Crown's money should be spent on improving our citizens' welfare, regardless of their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[961]`

### Węzeł `[957]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[958]`

### Węzeł `[958]`
Mówca: **Sal Ignacius**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[959]`
Mówca: **Sal Ignacius**
> ""Spreading the great word of Nur is my goal, Your Majesty. Not pacification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[960]`

### Węzeł `[960]`
Mówca: **Sal Ignacius**
> ""But you are right that our citizens are less likely to stir up turmoil when their spiritual needs are met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[961]`
Mówca: **Sal Ignacius**
> ""Do not neglect the importance of spiritual welfare, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[962]`
Mówca: **Sal Ignacius**
> ""A pity. With enough funds, you and I could build new sanctuaries all across the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]`
  - -> `[955]`
  - -> `[956]`
  - -> `[963]`

### Węzeł `[963]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I aim to transform Rizia into a strong, modern nation. I'm not going to waste time catering to the whims of its fanatics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]`

### Węzeł `[964]`
Mówca: **Sal Ignacius**
> ""The majority of our citizens hold Nurist beliefs, Your Majesty. You won't get far by calling them 'fanatics'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`

### Węzeł `[965]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]`

### Węzeł `[966]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Budget = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[967]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Budget == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[968]`
  - -> `[969]`

### Węzeł `[968]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Budget == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[988]`

### Węzeł `[969]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SanctuaryQHub_Budget == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[970]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]`
  - -> `[972]`

### Węzeł `[971]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[973]`

### Węzeł `[972]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[973]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here's what I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[974]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Sanctuary Q Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]`

### Węzeł `[975]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[976]`
  - -> `[977]`

### Węzeł `[976]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[977]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Religious >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[978]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[979]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn01_ReligiousBrief_YourBest = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn01_ReligiousBrief_YourBest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[980]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mind is made up. Goodbye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[981]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [VisionHub1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[982]`
**[WYBÓR GRACZA: "Remain silent and continue listening."]** — Mówca: **Player_Romus_Italic**
> "I remained silent and continued listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[983]`
**[WYBÓR GRACZA: "Listen without interruption."]** — Mówca: **Player_Romus_Italic**
> "I listened without interrupting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[984]`
**[WYBÓR GRACZA: "Offer no reply."]** — Mówca: **Player_Romus_Italic**
> "I offered no reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[985]`
**[WYBÓR GRACZA: "Don't speak."]** — Mówca: **Player_Romus_Italic**
> "I didn’t speak -- just listened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[986]`
**[WYBÓR GRACZA: "Hold your tongue."]** — Mówca: **Player_Romus_Italic**
> "I held my tongue and listened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[987]`
**[WYBÓR GRACZA: "Offer no response."]** — Mówca: **Player_Romus_Italic**
> "I offered no response, just listened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[988]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such a grand expenditure would certainly drain the Crown of its resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]`

### Węzeł `[989]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.SanctuaryQHub_Budget = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[990]`

### Węzeł `[990]`
Mówca: **Sal Ignacius**
> ""Indeed... I am afraid both of these projects will be quite costly endeavors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[991]`

### Węzeł `[991]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[992]`
  - -> `[993]`

### Węzeł `[992]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[995]`

### Węzeł `[993]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[996]`

### Węzeł `[994]`
Mówca: **Sal Ignacius**
> ""But we have enough funds to get started on the Plavo restoration already. And with the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]`

### Węzeł `[995]`
Mówca: **Sal Ignacius**
> ""But we do have the funds in place, Your Majesty. And with the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]`

### Węzeł `[996]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[997]`
  - -> `[998]`

### Węzeł `[997]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[994]`

### Węzeł `[998]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1000]`

### Węzeł `[999]`
Mówca: **Sal Ignacius**
> ""From there, you and I can build new sanctuaries all across the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]`
  - -> `[955]`
  - -> `[956]`
  - -> `[963]`

### Węzeł `[1000]`
Mówca: **Sal Ignacius**
> ""But I urge you not to neglect either of them. Even if they cannot be funded right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]`

### Węzeł `[1001]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded. With increased urgency in his voice, Sal continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[1002]`
**[WYBÓR GRACZA: "Gesture for him to keep going."]** — Mówca: **Player_Romus_Italic**
> "I gestured for him to keep going."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[1003]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Descending into sacred catacombs with the Grand Wiseman", "Plavo Archsanctuary", "Plavo");)*
- **Efekt (`userScript`):** `SetRichPresence("Descending into sacred catacombs with the Grand Wiseman","Plavo Archsanctuary","Plavo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[1004]`
Mówca: **Sal Ignacius**
> ""But neglect them, and unrest could follow. Four decades ago, reforms stirred discontent that began in sanctuaries and spilled into the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1005]`

### Węzeł `[1005]`
Mówca: **Sal Ignacius**
> ""When the faithful grow uneasy, their tithes shrink, leaving the Crown to fill the gap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]`
