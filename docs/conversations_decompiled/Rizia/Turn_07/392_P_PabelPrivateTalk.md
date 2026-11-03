# Rizia/Turn 7/P_PabelPrivateTalk

- **ID konwersacji:** `392`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/392_P_PabelPrivateTalk.md`
- **Liczba węzłów dialogowych:** 769
- **Liczba wyborów gracza:** 199

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.DiscussedDerdianHomosexuality`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs`
- `RiziaDLC.Situation_Welfare_LivingStandards_Average`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn02_Diplomacy_Intention_GRACE`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn07_Duel_Success`
- `RiziaDLCIsolated.Turn07_Duel_TitusFights`
- `RiziaDLCIsolated.Turn07_PabelTalk_Clothed`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLCIsolated.Turn07_PabelTalk_Clothed`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 19
- **Węzły modyfikujące stan gry:** 15

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[113]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] = true;`
- Węzeł `[589]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- Węzeł `[667]` (Paskal Beniwoll): `Variable["RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality"] = true;`
- Węzeł `[668]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- Węzeł `[670]` (Paskal Beniwoll): `EnableCollectionItem("CollectionItem_PoemScroll"); ;`
- Węzeł `[671]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion"); -- Removes the conversant with the character name in database;`
- Węzeł `[673]` (Paskal Beniwoll): `RemoveConversant("Pabel Adria"); -- Removes the conversant with the character name in database;`
- Węzeł `[674]` (Paskal Beniwoll): `RemoveConversant("Pabel Adria");`
- *...oraz 7 innych węzłów ze skryptami.*

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
  - -> `[768]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Early in the morning, I heard a soft tap on the door to my bedchambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[4]`
  - -> `[5]`
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away. I don't have to be up for another hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bruno, can you open the door?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Narrator**
> "Bruno jumped off my bed, ran to the door and began scratching at it. It didn't open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_SleepsInBed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_SleepsInBed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Bruno ran to the door and began scratching at it. It didn't open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Narrator**
> "There was no reply, just another soft knock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Pretend to be asleep."]** — Mówca: **Player_Romus_Italic**
> "I pretended to be asleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "There were a few seconds of silence, then another soft knock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I dragged myself out of bed and walked towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "As I was about to open it, I noticed an object had been slipped underneath it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked it up. It was a miniature scroll, lettered in precise handwriting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[21]`
Mówca: **Narrator**
> ""Find me in the labyrinth of past memories, 

left at the crossroads of whispering trees.

Close to the heart, all wrongs become right,

as we forge ahead from shadow into light.

Retracing our steps, we can find what we missed

The words left unsaid, the lips left unkissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "I looked out the window. The sky had just barely begun to lighten, and a grey mist still hung over the palace gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "My eyes came to rest on the hedge maze. I remembered watching Pabel and his father construct it when I was a teenager."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Bruno followed me out of my bedroom. I ran into Titus pacing up and down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "I walked out of my bedroom and ran straight into Titus. My guard was pacing up and down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going for a walk. No need to accompany me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was at my door just now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't sleep much, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Titus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Titus Gordion**
> ""The palace grounds are secure, Your Majesty. Enjoy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[34]`
Mówca: **Titus Gordion**
> ""Your butler, Your Majesty. I told him to return at your appropriate wake-up time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[35]`
Mówca: **Titus Gordion**
> ""Not since Derdia. I can't believe I let you down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Few other palace staff were about as I wandered into the mist-enshrouded gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Bruno split off to chase a squirrel as I made my way to the maze. Its entrance was marked by a pair of willow trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left until I came to a junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right until I came to another junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead. I knew I was close to the center of the maze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "Looking to the left, I noticed a freshly carved hole in one of the hedges. I stepped through it into a part of the maze I didn't recognize."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "Go straight ahead."]** — Mówca: **Player_Romus_Italic**
> "I walked straight ahead and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "Go left."]** — Mówca: **Player_Romus_Italic**
> "I walked to the left and found myself in a small clearing, shaded by flowering laurels and lined with soft-looking moss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Pabel was sitting there, waiting for me. He reached his hand towards mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[63]`
  - -> `[155]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a lovely poem. But between the war and everything else going on, I'm really not in the mood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "Take it."]** — Mówca: **Player_Romus_Italic**
> "I took his hand and he gently pulled me towards the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[64]`
Mówca: **Narrator**
> "I made my way to the maze. Its entrance was marked by a pair of willow trees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "Go right."]** — Mówca: **Player_Romus_Italic**
> "I walked to the right and encountered a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze Choice 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze Choice 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[45]`
  - -> `[47]`
  - -> `[44]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze Choice 1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze Choice 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[49]`
  - -> `[51]`
  - -> `[48]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze Choice 2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze Choice 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[55]`
  - -> `[54]`
  - -> `[56]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze Choice 3])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze Choice 4])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze choice 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[57]`
  - -> `[53]`
  - -> `[59]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Maze Choice 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[65]`
  - -> `[60]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze choice 5])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "Go backwards."]** — Mówca: **Player_Romus_Italic**
> "I retraced my steps to the previous junction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Maze Choice 6])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a lovely poem. But considering everything that's been going on, I'm not really in the mood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "He gave a brief sigh of disappointment and withdrew his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[86]`
Mówca: **Pabel Adria**
> ""It's fine. We can talk for a few minutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Pabel Adria**
> ""Your royal visit to Derdia is coming up, isn't it? How are the preparations going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[631]`
  - -> `[635]`
  - -> `[749]`

### Węzeł `[88]`
Mówca: **Narrator**
> "I took a seat on the ground next to him. He turned to look into my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[89]`
Mówca: **Narrator**
> "By the time we finally spoke, the morning sunlight was peeking through the branches above us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[105]`
  - -> `[157]`
  - -> `[106]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_Duel_TitusFights == true && RiziaDLCIsolated.Turn07_Duel_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_Duel_TitusFights"] == true  and  Variable["RiziaDLCIsolated.Turn07_Duel_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Not since the events in Wehlen. I can't believe I let you down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""Your butler was just here. Should I fetch him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Should I fetch him now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll find him myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need. I'm just going for a quick walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep guarding my room. I'll be back shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Understood, Your Majesty. Enjoy your constitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was... a-maze-ing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
Mówca: **Narrator**
> "Pabel gave a short laugh. He sat up and plucked a leaf out of my hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Another day, another illicit meeting spot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Titus knows about us yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Pabel Adria**
> ""He's got eyes everywhere. But if he were able to pin something on me yet, he would have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true && RiziaDLC.InvestigatePoisoning_NoPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Pabel sat up and plucked a leaf out of my hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""He knows we're friends. I doubt any other possibility has penetrated his skull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[114]`
Mówca: **Narrator**
> "He reached into the pocket of his suit jacket and pulled out a newspaper clipping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "His suit jacket was lying on the ground behind us. He reached into its pocket and pulled out a newspaper clipping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Pabel Adria**
> ""'Man, 33, beaten to death in Monqiz Prison... the deceased was identified as Mateus Montalvo, a courier for the Cantuavo vineyards.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.InvestigatePoisoning_NoPabel == false && (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and  (Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that the man you were with in the wine cellar?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a client? Was he mad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""That isn't the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[130]`
Mówca: **Pabel Adria**
> ""Montalvo had recently been jailed and dismissed from his job after engaging in suspected homosexual activity with a client.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[133]`
  - -> `[120]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, no. Was he arrested because of my investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Pabel Adria**
> ""Our encounter was obviously neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is happening in Rizia's prisons? I'll have to improve security there at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[135]`
Mówca: **Pabel Adria**
> ""We had an encounter some time before your coronation. Clearly neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Pabel Adria**
> ""No madder than a king doing the same with his butler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Pabel Adria**
> ""Until homosexuality is no longer a crime in Rizia, people like us are going to keep dying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[145]`
  - -> `[686]`
  - -> `[160]`
  - -> `[148]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that this was allowed to occur during my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People like *us*? I'm not a homosexual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am working to achieve parity between commoners and nobles. I can't let the problems of a tiny minority distract me from that fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Pabel gaped at me in astonishment. A short laugh escaped his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Pabel Adria**
> ""You must admit it's more comfortable than that rocky cove in Monqiz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[144]`
Mówca: **Pabel Adria**
> ""Call yourself what you want. It doesn't change the fact that in the eyes of the law, you're a criminal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Mateus was a sinner, and so are we. I can barely stomach such behavior, let alone enshrine it into law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to get rid of that law since I became king. But I'm afraid I don't have the authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[153]`
Mówca: **Pabel Adria**
> ""Rom. Any fight for equal rights should include *all* Rizians. Regardless of their romantic preferences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[166]`
  - -> `[691]`
  - -> `[217]`

### Węzeł `[154]`
Mówca: **Pabel Adria**
> ""We're talking about basic human rights. You can't wait for the population to catch up with the times. You have to show them the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[691]`
  - -> `[694]`
  - -> `[217]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't. I think Titus is starting to get suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "He groaned quietly and withdrew his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You missed your calling. You should've become a poet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Pabel Adria**
> ""I'd be living in the gutter. And you'd have no one to handle your... household.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Pabel sighed in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority <= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[163]`
Mówca: **Pabel Adria**
> ""If you care about me -- about us -- you will find a way to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[209]`
  - -> `[215]`
  - -> `[227]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many decrees I can make as king. I have to prioritize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made so much progress for Rizia's working class. They'll see it as a betrayal of their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will never accept my plans for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Pabel Adria**
> ""'My' community. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Whose values, exactly? Working-class homosexuals are at more risk than anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[172]`
Mówca: **Pabel Adria**
> ""I understand the influence Grand Wiseman Ignacius wields. But do you really plan to spend the rest of your reign catering to the Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm the king. I have the authority. I can make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Pabel Adria**
> ""If you care about me -- about us -- then you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[209]`
  - -> `[215]`
  - -> `[227]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""You said you felt things with me that you never felt with any woman. What kind of sick, twisted God would forbid you from that pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[181]`
  - -> `[179]`
  - -> `[186]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not God that's sick and twisted. It's us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[180]`
Mówca: **Pabel Adria**
> ""You said you felt things with me that you hadn't felt with anyone since Lena. What kind of sick, twisted God would forbid you from that pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`
  - -> `[181]`
  - -> `[185]`
  - -> `[179]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who let the Palesians take my daughter from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who took my wife away from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is to achieve Golconda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Pabel Adria**
> ""But friend to friend... all this religious talk is starting to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[193]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[194]`
Mówca: **Narrator**
> "He put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Pabel Adria**
> ""You're going through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Pabel Adria**
> ""But you deserve love. We both do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[197]`
Mówca: **Narrator**
> "He put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Pabel Adria**
> ""You've gone through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[262]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Pabel Adria**
> ""Or do you think a jury would let you off the hook because you're attracted to women too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[204]`
  - -> `[262]`
  - -> `[203]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, all right. Point taken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am attracted to human beings. Whether they're male or female is of no consequence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can turn it on and off, like a light switch. It's not my fault that other people can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[206]`
Mówca: **Pabel Adria**
> ""Plenty of your subjects feel the same way. Shouldn't the law reflect that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[207]`
Mówca: **Pabel Adria**
> ""It's not too late to change the law. You'd be giving so many of your subjects a chance at love. At life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`
  - -> `[275]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the law would definitely give us an edge with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Pabel Adria**
> ""'My' community. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""Then please. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Pabel Adria**
> ""Isn't Queen Beatrice a proponent of secularization? She'll understand the need to separate state laws from religious ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, we're in the middle of a war. It's not the time to go around making huge changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Pabel Adria**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Pabel Adria**
> ""I beg your pardon, but from what I can tell your relationship with your family is already beyond repair. What's one more burned bridge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`
  - -> `[275]`

### Węzeł `[226]`
Mówca: **Pabel Adria**
> ""I know you're close with your family. But if they insist on denying us our humanity, then I'm sorry, but screw them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`
  - -> `[275]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I take this leap, my house will never forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[228]`
Mówca: **Pabel Adria**
> ""For whatever that's worth. Look at how they treat women...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[233]`
Mówca: **Pabel Adria**
> ""There's still some time before breakfast. I suggest you go back inside and wash the sin out of your mouth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[237]`
  - -> `[236]`

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must both repent, Pabel. Before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I wish I could see it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will think about what you said. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your own mouth. You're still speaking to the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Don't apologize to me. Apologize to Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[243]`
Mówca: **Narrator**
> "He slowly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[244]`
Mówca: **Pabel Adria**
> ""It's already too late for Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[245]`
Mówca: **Narrator**
> "He stiffly bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Pabel Adria**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[247]`
Mówca: **Pabel Adria**
> ""Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""He wasn't the first. And he won't be the last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""And for God's sake, forgive yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Narrator**
> "He bowed and disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[251]`
Mówca: **Narrator**
> "He turned around and swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[252]`
Mówca: **Pabel Adria**
> ""It's too late for Mateus. But not for many others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not I personally agree, classifying it as such would definitely put me on good terms with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists would hate me if I took that leap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still worried about what my house will think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a stretch at all. Why is my butler talking more sense than my religious councilor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""Because the Grand Wiseman hasn't been intimate since before the invention of the automobile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[258]`
Mówca: **Pabel Adria**
> ""Good thing they're still a minority here. You can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[259]`
Mówca: **Pabel Adria**
> ""But yes. The Golcondists in Rizia  would also be very happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[260]`
Mówca: **Pabel Adria**
> ""Wow. And I thought I knew you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like guns. I'm not some nancy boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true || RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true  or  Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Pabel Adria**
> ""Really? You're going to buy into those ancient stereotypes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The working class will see it as a betrayal of their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[267]`
Mówca: **Pabel Adria**
> ""It's not just about you and me. This is a universal struggle. Think of the example we could set for the rest of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[268]`
  - -> `[270]`
  - -> `[275]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't seen this side of you before and frankly, I'm incredibly turned on by it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already got my council and the House of Delegates telling me what to do. Now I have to take orders from my butler?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if homosexuality were legal in Rizia, it doesn't mean you and I could be together openly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Pabel Adria**
> ""I know. That's a discussion for a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Pabel smiled grimly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Pabel Adria**
> ""It's what happens to a man when enough of his kind are imprisoned, dead or exiled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[274]`
Mówca: **Pabel Adria**
> ""I'm not ordering you to do anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I have a historic opportunity to change the law. I've got to seize it while I still can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Pabel Adria**
> ""The sooner you do, the more lives will be saved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[291]`
  - -> `[287]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then keep your mouth shut. You're here to serve me, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't make a difference. Even if homosexuality were legal in Rizia, the people would never accept a degenerate king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[290]`
Mówca: **Narrator**
> "He began putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. It's important to me if it's important to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Pabel Adria**
> ""This is more important than you or me. You could save thousands of lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[293]`
Mówca: **Pabel Adria**
> ""This goes beyond either of us individually. It's basic human rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[294]`
Mówca: **Narrator**
> "He stared me down coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[295]`
Mówca: **Pabel Adria**
> ""I am sorry, Your Majesty. For believing our encounters were more than an extension of my... royal duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[296]`
Mówca: **Pabel Adria**
> ""I know the war is your highest priority right now. But I hope you'll at least think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Pabel Adria**
> ""I know you have other priorities. But please just think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[336]`
  - -> `[337]`
  - -> `[345]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not unless you write me another poem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Pabel Adria**
> ""Please forgive my confusion, Your Majesty. I wasn't the one on my knees a moment ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I trust you can find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Narrator**
> "He bowed and swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Narrator**
> "After collecting my thoughts, I dressed and left the maze the way I'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Narrator**
> "After collecting my thoughts, I stood and left the maze the way I'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Narrator**
> "Bruno ran towards me as soon as I emerged. Together, we began the walk back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[318]`
Mówca: **Narrator**
> "I emerged by the willow trees and began the walk back to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[319]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[328]`
  - -> `[331]`
  - -> `[325]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Narrator**
> "He stood up and brushed himself off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[324]`
Mówca: **Narrator**
> "He hurriedly started putting his clothes back on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's important to me. But it won't happen overnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "His expression softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My child might die. That's what's important to me right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you're with me? To push your... lavender agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[332]`
Mówca: **Pabel Adria**
> ""I know. But Mateus was someone's child, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into making a decree. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[338]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
Mówca: **Pabel Adria**
> ""My creative muscles are spent. Just look for the willows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[340]`
Mówca: **Pabel Adria**
> ""I know. Forgive my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[341]`
Mówca: **Narrator**
> "He stared me down coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Pabel Adria**
> ""It's not an agenda. It's a crisis. How many more of us have to die before you see it the same way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[343]`
Mówca: **Pabel Adria**
> ""...Un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Narrator**
> "He leaned down and kissed me, then swiftly disappeared into the greenery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your lover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[349]`
Mówca: **Narrator**
> "Early in the morning, I heard a soft tap on the door to my bedchambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Narrator**
> "It was Pabel, coming to wake me at my usual time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[354]`
Mówca: **Narrator**
> "Bruno ran up to him with a gleeful wag of his tail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Pabel Adria**
> ""What a happy fellow. I hope you both slept well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Narrator**
> "There was a tinge of melancholy in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`

### Węzeł `[357]`
Mówca: **Pabel Adria**
> ""Good morning, {RiziaDLCText.PabelToPlayer}. I hope you slept well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on, Pabel? Are you all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my paper?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I slept wonderfully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't sleep until we take Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't sleep until we have Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[366]`
Mówca: **Pabel Adria**
> ""I have it. Just give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[367]`
Mówca: **Pabel Adria**
> ""I'm fine, thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Pabel Adria**
> ""I'm glad to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Pabel Adria**
> ""Even a king needs to close his eyes sometimes. I'll ask the pharmacist to procure you some Wehzek tablets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Narrator**
> "He began drawing open my curtains, then stopped and spoke to me in a forced casual tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[371]`
Mówca: **Pabel Adria**
> ""How are preparations going for your royal visit to Derdia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[390]`
  - -> `[394]`
  - -> `[393]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[376]`
Mówca: **Pabel Adria**
> ""Lunatics, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Narrator**
> "He paused again, as if in deliberation. Finally, he walked over to the chair next to my bed and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Pabel Adria**
> ""I don't know if you're aware, but many Rizians of my persuasion have fled to Derdia since its establishment as a Golcondist republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[379]`
Mówca: **Pabel Adria**
> ""It's not perfect. But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[697]`
  - -> `[381]`
  - -> `[387]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It can't be that bad in Rizia. Can it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? I thought the lure of the forbidden was part of your whole... thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[382]`
Mówca: **Pabel Adria**
> ""You don't know the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[383]`
Mówca: **Narrator**
> "His eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[384]`
Mówca: **Narrator**
> "He frowned, insulted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Pabel Adria**
> ""It's not a game, {RiziaDLCText.PabelToPlayer}. It's who we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[386]`
Mówca: **Pabel Adria**
> ""Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something must be done to improve the status of your kind here at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Pabel Adria**
> ""I'm happy you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Pabel Adria**
> ""And the sooner, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been reading up on the Golcondists. Perhaps Rizia has been too harsh to judge them in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are going well, thank you. I'm hoping to contract their mercenaries for the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[399]`
Mówca: **Pabel Adria**
> ""You know what they say about opposites attracting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[400]`
Mówca: **Pabel Adria**
> ""'Man, 33, beaten to death in Monqiz Prison... the deceased was identified as Mateus Montalvo, a courier for the Cantuavo vineyards.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Pabel Adria**
> ""Montalvo had recently been jailed and dismissed from his job after engaging in suspected homosexual activity with a client.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got high hopes for it. The Derdians and I agree on many points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[403]`
Mówca: **Pabel Adria**
> ""I see. I've heard they're very skilled fighters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[404]`
Mówca: **Narrator**
> "He tossed the morning paper onto my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Pabel Adria**
> ""Look at the bottom of the first page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[418]`
  - -> `[416]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.PoisonInvestigator_Lucita == true || RiziaDLC.PoisonInvestigator_Titus == true) && RiziaDLC.InvestigatePoisoning_NoPabel == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true  or  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true)  and  Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[410]`

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that the man you were with in the wine cellar? Allegedly, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With a client? Was he mad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[412]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[413]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[414]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[415]`
Mówca: **Pabel Adria**
> ""That isn't the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, no. Was he arrested because of my investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[417]`
Mówca: **Pabel Adria**
> ""Our encounter was obviously neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is happening in Rizia's prisons? I'll have to improve security there at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[419]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[420]`
Mówca: **Pabel Adria**
> ""We had an encounter some time before your coronation. Clearly neither his first nor last. I warned him to be more careful, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Pabel Adria**
> ""If he's mad, then so am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[422]`
Mówca: **Pabel Adria**
> ""Until homosexuality is no longer a crime in Rizia, people like him -- like me -- are going to keep dying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[431]`
  - -> `[429]`
  - -> `[442]`
  - -> `[434]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that this happened during my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Narrator**
> "Pabel nodded, his teeth clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Pabel Adria**
> ""He wasn't the first. And he won't be the last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I'm the king. If you ever get found out, I'll just pardon you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am working to achieve parity between commoners and nobles. I can't let the problems of a tiny minority distract me from that fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[428]`
Mówca: **Narrator**
> "Pabel gave me a look of frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the people of Rizia wanted legal homosexuality, my parliament would have brought it up by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[430]`
Mówca: **Pabel Adria**
> ""That's very kind of you, but there are thousands like me in this kingdom. And they count as some of its most vulnerable citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[563]`
  - -> `[562]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Mateus was a sinner, and so are you. I can barely stomach such behavior, let alone enshrine it into law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been wanting to get rid of that law since I became king. But I'm afraid it's going to take more resources than I have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[439]`
Mówca: **Pabel Adria**
> ""Any fight for equal rights should include *all* Rizians. Regardless of their romantic preferences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[683]`
  - -> `[453]`
  - -> `[495]`

### Węzeł `[440]`
Mówca: **Pabel Adria**
> ""This is one instance where democracy doesn't work. You can't wait for the population to catch up with the times. You have to show them the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[683]`
  - -> `[453]`
  - -> `[495]`

### Węzeł `[441]`
Mówca: **Narrator**
> "Pabel sighed in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority <= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[445]`
Mówca: **Pabel Adria**
> ""It is a challenge, I know. Not even Queen Lyza dared to imagine it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many royal decrees I can make. I have to prioritize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've made so much progress for Rizia's working class. They'll see it as a betrayal of their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Average == true && RiziaDLC.Situation_Welfare_WorkersRights_Bad == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Average"] == true  and  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will never accept my plans for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[452]`
Mówca: **Pabel Adria**
> ""Whose values? Working-class homosexuals are at more risk than nearly anyone else in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the religious backlash could end my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Pabel Adria**
> ""I understand the influence Grand Wiseman Ignacius wields. But do you really plan to spend the rest of your reign catering to the Sanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have the authority. I can change our kingdom's anti-homosexuality laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Pabel Adria**
> ""It's a major step forward, I know. Not even Queen Lyza dared to imagine it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[457]`
Mówca: **Pabel Adria**
> ""What kind of sick, twisted God would forbid a person from experiencing love?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`
  - -> `[547]`
  - -> `[458]`
  - -> `[490]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not God that's sick and twisted. It's you. No offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that Wruhecist teachings stress the importance of bringing joy to others. They do not specify which sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who let the Palesians take my daughter from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same God who took my wife away from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[465]`
Mówca: **Narrator**
> "His expression turned compassionate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
Mówca: **Pabel Adria**
> ""You're going through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Pabel Adria**
> ""But you deserve love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[468]`
Mówca: **Narrator**
> "His expression turned compassionate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Pabel Adria**
> ""You've gone through a hard time, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[470]`
Mówca: **Pabel Adria**
> ""Yes! Precisely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Pabel Adria**
> ""Is it such a stretch to imagine that a bond of affection between two men can be as pure -- as holy -- as that between a man and a woman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`
  - -> `[484]`
  - -> `[485]`

### Węzeł `[472]`
Mówca: **Pabel Adria**
> ""Then as your friend, I beg of you. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[473]`
Mówca: **Pabel Adria**
> ""If not now, then when?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Pabel Adria**
> ""Your approval means as much to House Toras as theirs means to you. They can be won over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`
  - -> `[537]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia may be ready, but House Toras is not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[479]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[510]`
  - -> `[505]`
  - -> `[502]`

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Repent, Pabel. Before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Pabel Adria**
> ""It's already too late for Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Personally, I would rather not imagine it. But politically, it'd give us an edge with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists would hate me if I took that leap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still worried about what my house will think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a stretch at all. Why is my butler talking more sense than my religious councilor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[486]`
Mówca: **Pabel Adria**
> ""Because the Grand Wiseman hasn't been intimate since before the invention of the automobile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[487]`
Mówca: **Pabel Adria**
> ""They are still a minority here. You can afford to lose them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Pabel Adria**
> ""But that's not the real reason the law should be changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Pabel Adria**
> ""It's not just about what I want. This is a universal struggle. Think of the example you'd be setting for the rest of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`
  - -> `[537]`
  - -> `[603]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly devout Wruhecist must abandon all thoughts of earthly pleasure if he is to achieve Golconda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[491]`
Mówca: **Pabel Adria**
> ""But friend to friend... all this religious talk is starting to worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Decriminalizing homosexuality will definitely give us an edge with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[493]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[498]`
Mówca: **Pabel Adria**
> ""I beg your pardon, but from what I can tell your relationship with your family is already beyond repair. What's one more burned bridge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`
  - -> `[537]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists will hate it, though. What am I supposed to tell Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Pabel Adria**
> ""Isn't Queen Beatrice a proponent of secularization? She'll understand the need to separate state laws from religious ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, we're in the middle of a war. It's not the time to go around making huge changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will think about what you said. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[503]`
Mówca: **Pabel Adria**
> ""Please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[504]`
Mówca: **Pabel Adria**
> ""As well as with the Golcondists living here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't be worried. I am seeing clearly for the first time in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Pabel Adria**
> ""Then why can't you see homosexuals as people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Pabel Adria**
> ""Pardon my frustration. I'll see you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[509]`
Mówca: **Pabel Adria**
> ""It's too late for Mateus. But not for many others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. I wish I could see it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
Mówca: **Pabel Adria**
> ""Don't apologize to me. Apologize to Mateus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The working class will see it as a betrayal of their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[513]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[514]`
Mówca: **Pabel Adria**
> ""I am sorry, Your Majesty. I was mistaken to conflate our past friendship with our professional relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[518]`
Mówca: **Narrator**
> "His expression softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My child might die. That's what's important to me right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Pabel Adria**
> ""Mateus was someone's child, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[521]`
Mówca: **Pabel Adria**
> ""I know. Forgive my impatience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[522]`
Mówca: **Narrator**
> "His face turned stony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Pabel Adria**
> ""It's not an agenda. It's a crisis. How many more of us have to die before you see it the same way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[524]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[525]`
Mówca: **Narrator**
> "He bowed and swiftly left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[526]`
Mówca: **Pabel Adria**
> ""Un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[527]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into making a decree. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your lover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[576]`
  - -> `[530]`
  - -> `[580]`

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""I'm so sorry, Your Majesty. I won't bring up personal topics with you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Pabel Adria**
> ""I'm late to oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already got my council and the House of Delegates telling me what to do. Now I have to take orders from my butler?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I made homosexuality legal tomorrow, you couldn't go parading about town in a ball gown. Royal protocol must be observed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Pabel Adria**
> ""I assure you I will be as discreet as ever. I will merely be happy to see fewer of my kind imprisoned, killed or exiled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I have a historic opportunity. I've got to seize it while I still can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Pabel Adria**
> ""The sooner you do, the more lives will be saved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[539]`
Mówca: **Narrator**
> "He stood up indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then keep your mouth shut. You're my servant, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[541]`
Mówca: **Pabel Adria**
> ""But if this isn't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[543]`
  - -> `[546]`
  - -> `[542]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's important to me. But it won't happen overnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that why you worked your way up to head butler? To push your... lavender agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Plenty of people don't get to experience love. I didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Pabel Adria**
> ""That's not a reason to deny it to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""But remember the joy you experienced during your marriage to Princess Lena. Shouldn't everyone get a chance at that, even if it ends in heartbreak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[553]`
Mówca: **Narrator**
> "He hurriedly rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[557]`
Mówca: **Pabel Adria**
> ""I shouldn't have brought this up with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Pabel Adria**
> ""Please forget I said anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will gladly forget it. And I'll thank you not to trouble me with such talk again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Pabel Adria**
> ""I've got to go oversee breakfast. I'll leave you to dress yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[510]`
  - -> `[559]`

### Węzeł `[561]`
Mówca: **Pabel Adria**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I show too much sympathy towards your community, my house will disown me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are only so many decrees I can make. I have to prioritize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can move to Derdia. You said it's safe for them there, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Pabel Adria**
> ""Not everyone has the resources to flee the country. And living as a Golcondist is hardly an ideal solution, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[569]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Pabel Adria**
> ""I'm grateful that you respect my identity, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[571]`
Mówca: **Pabel Adria**
> ""But if the lives of other homosexuals in Rizia aren't important to you... I don't know what to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[546]`
  - -> `[573]`

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""I care about you, Romus. I always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are important to me. But I can't make change happen overnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[574]`
Mówca: **Narrator**
> "Pabel looked crestfallen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[575]`
Mówca: **Narrator**
> "His face turned stony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
Mówca: **Pabel Adria**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do I wear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[581]`
Mówca: **Pabel Adria**
> ""Navy blue suit, burgundy pocket square. The diamond cuff links Hugo gave you for your birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[582]`
Mówca: **Narrator**
> "After taking a moment to collect my thoughts, I dressed and headed downstairs for breakfast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[583]`
Mówca: **Pabel Adria**
> ""He wasn't my lover. But I'm sorry too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportDrugs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[587]`
Mówca: **Pabel Adria**
> ""Even a king needs to close his eyes sometimes. I'll ask the chef to procure some valerian root for tea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[588]`
Mówca: **Pabel Adria**
> ""All of us do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[590]`
Mówca: **Pabel Adria**
> ""Interesting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are going well, thank you. I'm hoping to contract their mercenaries for use in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[592]`
Mówca: **Pabel Adria**
> ""Do you, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[593]`
Mówca: **Pabel Adria**
> ""It's one of the only places in Merkopa where relations between members of the same sex are accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`
  - -> `[600]`
  - -> `[715]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of the many perversions of Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[597]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_GolcondistBlasphemy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that in some respects, Golcondists are more enlightened than mainstream Wruhecists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A fascinating contradiction. How can such an extremist society allow homosexuality?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you ever move there, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[601]`
Mówca: **Pabel Adria**
> ""The only reason Derdia allows homosexuality is because Golcondists view intimacy between men as the most sacred form of love. They say it strengthens bonds on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could greatly improve our image in the war. A kingdom that grants rights to women and homosexuals can't be an aggressor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[606]`
Mówca: **Pabel Adria**
> ""And not all homosexual men wear  gowns. Just as not all men who wear gowns are homosexual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[607]`
Mówca: **Pabel Adria**
> ""That's not precisely what I meant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Pabel Adria**
> ""Then as your butler and humble subject, I beg of you. Prioritize this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[612]`
Mówca: **Pabel Adria**
> ""Only in an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[613]`
Mówca: **Pabel Adria**
> ""As for women... as long as they accept their role as providers and childbearers, they may consort among themselves if they wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[614]`
Mówca: **Pabel Adria**
> ""But Rizia is ready now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[492]`
  - -> `[499]`
  - -> `[478]`

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the land of blasphemous lunatics, you mean? I couldn't be more excited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[616]`
Mówca: **Pabel Adria**
> ""Not all of their beliefs are crazy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[617]`
Mówca: **Narrator**
> "He paused. I saw a flash of melancholy in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
Mówca: **Pabel Adria**
> ""I don't know if you're aware, but many Rizians of my persuasion have fled to Derdia since its establishment as a Golcondist republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[619]`
Mówca: **Pabel Adria**
> ""It's not perfect. But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`
  - -> `[621]`
  - -> `[622]`
  - -> `[629]`

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It can't be that bad in Rizia. Can it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia's attitude towards homosexuality is just an extension of the deep-seated sexism in its society. How could anyone prefer that to our kingdom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Boring. Without the lure of the forbidden, I might as well be with a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[623]`
Mówca: **Pabel Adria**
> ""You don't know the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[624]`
Mówca: **Narrator**
> "His eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[625]`
Mówca: **Narrator**
> "Outrage flashed in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[626]`
Mówca: **Pabel Adria**
> ""Do you mean that, Romus? Is this a game to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[627]`
Mówca: **Pabel Adria**
> ""Because of what our kingdom does to homosexuals who get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Pabel Adria**
> ""Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[629]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So do I. They should never have had to flee Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[630]`
Mówca: **Pabel Adria**
> ""And those who fled are the lucky ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[631]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[633]`

### Węzeł `[632]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[633]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[634]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aha. You're jealous that I get to go to the homosexual country and you don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have high hopes, to be honest. The Derdians and I have nothing in common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As well as can be expected. I'm hoping to contract their mercenaries for the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[640]`
Mówca: **Pabel Adria**
> ""Nothing? Are you certain about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got high hopes for it. The Derdians and I agree on many points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[642]`
Mówca: **Pabel Adria**
> ""Ah. I've heard they're very skilled fighters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[643]`
Mówca: **Pabel Adria**
> ""Well, yes. A little.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As well as can be expected. I'm hoping to contract their mercenaries for use in Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[645]`
Mówca: **Pabel Adria**
> ""Do you? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[646]`
Mówca: **Pabel Adria**
> ""It's one of the only places in Merkopa where relations between members of the same sex are accepted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`
  - -> `[653]`
  - -> `[657]`
  - -> `[757]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One of the many perversions of Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_GolcondistBlasphemy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying that in some respects, Golcondists are more enlightened than mainstream Wruhecists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A fascinating contradiction. How can such an extremist society allow homosexuality?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you ever move there, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Pabel Adria**
> ""The only reason homosexuality is allowed in Derdia is because Golcondists view intimacy between men as the most sacred form of love. They say it strengthens bonds on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Pabel Adria**
> ""And leave my king? Never. But I do sometimes wonder what such a society is like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[656]`
Mówca: **Pabel Adria**
> ""As for women... as long as they accept their role as providers and childbearers, they may consort among themselves if they wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would love to permit such a thing in Rizia, but I'd lose the throne in an instant. All of society is against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Pabel Adria**
> ""To be fair, the Derdians are far from enlightened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[659]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that Wruhecist teachings stress the importance of bringing joy to others. They do not specify which sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[660]`
Mówca: **Pabel Adria**
> ""Yes! Precisely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[661]`
Mówca: **Pabel Adria**
> ""Is it really such a stretch to imagine that the love between two men can be as pure -- as holy -- as that between members of the opposite sex?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[255]`
  - -> `[256]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`
  - -> `[664]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_PabelTalk_Clothed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_PabelTalk_Clothed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[665]`
Mówca: **Pabel Adria**
> ""Exactly. And don't even try to tell me I didn't bring joy to you just now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[666]`
Mówca: **Pabel Adria**
> ""No, not exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[669]`
Mówca: **Narrator**
> "Pabel put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_PoemScroll");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_PoemScroll");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");

// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[672]`
Mówca: **Pabel Adria**
> ""Since when is what we're doing a perversion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");

// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Pabel Adria");)*
- **Efekt (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[677]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're talking about a tiny minority of citizens. Why cater to them at the expense of everyone else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[678]`
Mówca: **Pabel Adria**
> ""Why would it have to be at anyone's expense? Who are we hurting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[448]`
  - -> `[683]`
  - -> `[453]`
  - -> `[495]`

### Węzeł `[679]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`
  - -> `[681]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[682]`
Mówca: **Pabel Adria**
> ""You know very well that your parliament only puts forth the interests of the nobility. Who can afford to keep their perversions hidden away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[683]`
  - -> `[453]`
  - -> `[495]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[686]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Rizia wanted legal homosexuality, my parliament would have brought it up by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`
  - -> `[689]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[690]`
Mówca: **Pabel Adria**
> ""You know very well that your parliament only puts forth the interests of the nobility. Who can afford to keep their perversions hidden away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`
  - -> `[217]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reforms_DiscussedOnYacht == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reforms_DiscussedOnYacht == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is still a majority-Wruhecist country. If I made homosexuality legal, the religious backlash could end my reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[695]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People like us represent a tiny minority of citizens. Why focus on them at the expense of everyone else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[696]`
Mówca: **Pabel Adria**
> ""Why would it have to be at anyone's expense? Who are we hurting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[166]`
  - -> `[691]`
  - -> `[694]`

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derdia's attitude towards homosexuality is just an extension of the deep-seated sexism in its society. How could anyone prefer that to our kingdom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[698]`
Mówca: **Pabel Adria**
> ""Because of what our kingdom does to homosexuals who get caught.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[702]`
Mówca: **Pabel Adria**
> ""Palace scuttlebutt has it you turned down the chance to visit Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`
  - -> `[705]`
  - -> `[708]`
  - -> `[711]`
  - -> `[713]`

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you care about my diplomatic dealings?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[704]`
Mówca: **Pabel Adria**
> ""I know it's not my business. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I don't want to have any more contact with those lunatics than I need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[706]`
Mówca: **Pabel Adria**
> ""Understandable. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would have been a waste of time. Rizia's place is among the monarchies of GRACE, not scrabbling for favor with our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would've been counterproductive. I'll have better relations with our other international partners if I avoid Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[712]`
Mówca: **Pabel Adria**
> ""I see. Still, I would have been curious what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm regretting it now. I'd be interested in seeing how they live over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[714]`
Mówca: **Pabel Adria**
> ""As would I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`
  - -> `[717]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[718]`
Mówca: **Pabel Adria**
> ""I wouldn't call it that, exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`
  - -> `[721]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[722]`
Mówca: **Pabel Adria**
> ""Well, not exactly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[723]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Accepted and condoned. Sal told me all about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Pabel Adria**
> ""With a judgemental scowl on his face, no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[725]`
Mówca: **Pabel Adria**
> ""I don't agree with Derdia's religious justification for homosexuality. And I certainly don't like their martial culture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[726]`
Mówca: **Pabel Adria**
> ""But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[697]`
  - -> `[381]`
  - -> `[387]`

### Węzeł `[727]`
Mówca: **Pabel Adria**
> ""So, palace scuttlebutt has it you turned down the chance to visit Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`
  - -> `[730]`
  - -> `[733]`
  - -> `[738]`
  - -> `[746]`

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when do you care about my diplomatic dealings?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[729]`
Mówca: **Pabel Adria**
> ""I know it's not my business. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to have any more contact with those lunatics than I need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""Understandable. But I would have been curious to hear what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would have been a waste of time. Rizia's place is among the monarchies of GRACE, not scrabbling for favor with our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[733]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`
  - -> `[735]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Diplomacy_Intention_GRACE == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_GRACE"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm regretting it now. I'd be interested in seeing how they live over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""So would I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[738]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would've been counterproductive. I'll have better relations with our other international partners if I avoid Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[739]`
Mówca: **Pabel Adria**
> ""Sure. Still, I would have been curious what you thought of the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`
  - -> `[742]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`
  - -> `[745]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[748]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[751]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[752]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since when do you care about my diplomatic dealings?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[753]`
Mówca: **Pabel Adria**
> ""I don't, usually. But this one is different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should be glad. What if I went there and some handsome, virile Golcondist warrior swept me off my feet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[755]`
Mówca: **Pabel Adria**
> ""At least neither of you would be jailed for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[756]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`
  - -> `[759]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedDerdianHomosexuality == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedDerdianHomosexuality == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedDerdianHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Accepted and condoned. Sal told me all about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[761]`
Mówca: **Pabel Adria**
> ""With a judgemental frown on his face, no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[762]`
Mówca: **Pabel Adria**
> ""I don't agree with the Derdians' religious justification for homosexuality. And I certainly don't like their martial culture...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[763]`
Mówca: **Pabel Adria**
> ""But I understand the desire to live openly among fundamentalists rather than cower behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`
  - -> `[621]`
  - -> `[622]`
  - -> `[629]`

### Węzeł `[764]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Bruno");)*
- **Efekt (`userScript`):** `RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[768]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Privately reflecting on Rizia’s stance on homosexuality", "Private Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Privately reflecting on Rizia’s stance on homosexuality","Private Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
