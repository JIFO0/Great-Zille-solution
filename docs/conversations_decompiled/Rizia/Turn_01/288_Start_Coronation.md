# Rizia/Turn 1/Start_Coronation

- **ID konwersacji:** `288`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/288_Start_Coronation.md`
- **Liczba węzłów dialogowych:** 192
- **Liczba wyborów gracza:** 40

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Coronation_Speech_UpholdMonarchy`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_Summer_Court`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown`
- `RiziaDLCIsolated.Turn01_Coronation_LookedEstela`
- `RiziaDLCIsolated.Turn01_Coronation_RecitedOath`
- `RiziaDLCIsolated.Turn01_Coronation_TookOrb`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Coronation_Speech_UpholdMonarchy`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown`
- `RiziaDLCIsolated.Turn01_Coronation_LookedEstela`
- `RiziaDLCIsolated.Turn01_Coronation_RecitedOath`
- `RiziaDLCIsolated.Turn01_Coronation_TookOrb`
- `RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech`
- `RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech`
- `RiziaDLCSupport.News_Turn01_RH_Coronation_Speech`
- `RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion`
- `RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats`
- `RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke`
- `RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats`
- `RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats`
- `RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats`
- `RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats`
- `RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 35

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Vina`
- `RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] = true;`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] = true;`
- Węzeł `[91]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] = true;`
- Węzeł `[92]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] = true;`
- Węzeł `[109]` (Paskal Beniwoll): `Variable["RiziaDLC.Coronation_GaveSpeech"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] = true;`
- Węzeł `[111]` (Paskal Beniwoll): `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] = true;`
- Węzeł `[112]` (Paskal Beniwoll): `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] = true;`
- *...oraz 27 innych węzłów ze skryptami.*

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
  - -> `[191]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The angelic-sounding voices of a boys' choir echoed through the Great Hall of Palas Rezna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "To most Rizians, this was the grandest room in the grandest building in the entire country. To me, it was just home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I remembered playing hide-and-seek among the mosaic-tiled columns while visiting my grandmother. Goofing off with Pabel in the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I remembered playing hide-and-seek among the mosaic-tiled columns while visiting my grandmother. Watching from the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "And of course, this was where I had married Lena..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The hall before me was filled with nobles, politicians, business magnates, even movie stars. A television crew moved up and down the aisles, broadcasting the ceremony to the Rizian public for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "My mother was sitting in the front row next to Uncle Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "Tradition dictated that in the absence of a king or queen consort, the seat next to me would be filled by the successor to the throne. Vina plucked at a stray thread in her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Ready for the next chapter.""]** — Mówca: **Player_Romus**
> ""Ready for the next chapter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[15]`
Mówca: **Vina Toras**
> ""How are you feeling, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[18]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""My feelings are none of your business.""]** — Mówca: **Player_Romus**
> ""My feelings are none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Shh. Stop fidgeting. The cameras are on us.""]** — Mówca: **Player_Romus**
> ""Shh. Stop fidgeting. The cameras are on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Honestly? A little nervous.""]** — Mówca: **Player_Romus**
> ""Honestly? A little nervous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The final notes of the coronation hymn "By His Sword I Live" rang out. An expectant silence filled the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "It was broken by the sound of shuffling footsteps. The cameras followed Grand Wiseman Sal Ignacius as he walked slowly down the central aisle, bearing a velvet cushion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He presented it in front of me. On it was the Toras crown, a black onyx orb and a scroll containing the words to the royal oath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Recite the oath."]** — Mówca: **Player_Romus_Italic**
> "I took the scroll off the cushion and read aloud from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Take the orb."]** — Mówca: **Player_Romus_Italic**
> "I lifted the orb off the cushion and ran my fingers across its smooth surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "Look at Estela."]** — Mówca: **Player_Romus_Italic**
> "I caught my mother's eye. She gave me a conspiratorial wink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Look at the crown."]** — Mówca: **Player_Romus_Italic**
> "I gazed at the Toras crown, forged when my family took the throne almost 150 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Coronation Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""I hereby pledge myself...""]** — Mówca: **Player_Romus**
> ""I hereby pledge myself in service to the great nation of Rizia and its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise to guide my country with a steadfast hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To uphold the laws of this land under St. Wruhec's watchful eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To wield the sword of justice and the shield of mercy in equal measure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All this I shall do until the day I die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Coronation Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[33]`
Mówca: **Narrator**
> "With trembling hands, Grand Wiseman Ignacius lifted the crown off the cushion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_TookOrb == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_TookOrb == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Coronation_TookOrb == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Narrator**
> "I could spot a grey hair still clinging to its inner rim. My father's."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[47]`
Mówca: **Narrator**
> "The crown came down on my head. Its heaviness surprised me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Stand up."]** — Mówca: **Player_Romus_Italic**
> "I stood. The choir broke into "On Shores of Gold," the Rizian national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Break tradition and make a speech first."]** — Mówca: **Player_Romus_Italic**
> "I held up my hand for silence. The choir stopped singing. Confused whispers ran through the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[50]`
Mówca: **Narrator**
> "I hoped my limp wasn't visible to television viewers. I thought about the kidnapper's bullet and how close I had come to never seeing this day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[51]`
Mówca: **Narrator**
> "We reached the end of the hall, where a spiral staircase led to the palace balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I've got to do this part alone.""]** — Mówca: **Player_Romus**
> ""I've got to do this part alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Come, Vina, let's greet your future subjects.""]** — Mówca: **Player_Romus**
> ""Come, Vina, let's greet your future subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I know this is highly unusual, but we are living in unusual times.""]** — Mówca: **Player_Romus**
> ""I know this is highly unusual, but we are living in unusual times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of Rizia...""]** — Mówca: **Player_Romus**
> ""Ladies and gentlemen of Rizia...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Uncle Hugo had been smiling proudly up to this point. His expression now grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""When my father died, I made a promise. One that I would like to share with you all today.""]** — Mówca: **Player_Romus**
> ""When my father died, I made a promise. One that I would like to share with you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""My father was a great but flawed man. His mistakes will not be repeated.""]** — Mówca: **Player_Romus**
> ""My father was a great but flawed man. His mistakes will not be repeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""The reign of Valero Toras is over. A new day has dawned.""]** — Mówca: **Player_Romus**
> ""The reign of Valero Toras is over. A new day has dawned in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Under my rule, Rizia will be transformed.""]** — Mówca: **Player_Romus**
> ""Under my rule, Rizia will be transformed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[86]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""I will succeed where our previous king failed.""]** — Mówca: **Player_Romus**
> ""I will succeed where our previous king failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[86]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""It is time to show all of Merkopa what Rizia is capable of.""]** — Mówca: **Player_Romus**
> ""It is time to show all of Merkopa what Rizia is capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[86]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We must break with tradition and enter the 20th century.""]** — Mówca: **Player_Romus**
> ""We must break with tradition and enter the 20th century.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I will uphold the monarchy and restore the glory days of House Toras.""]** — Mówca: **Player_Romus**
> ""I will uphold the monarchy and restore the glory days of House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I promise I will take back the lands that have been stolen from us.""]** — Mówca: **Player_Romus**
> ""I promise I will take back the lands that have been stolen from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Hugo's stare intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`
  - -> `[113]`
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Hugo's expression relaxed. He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Only when Rizia is once again whole can a new era of peace and prosperity begin.""]** — Mówca: **Player_Romus**
> ""Only when Rizia is once again whole can a new era of peace and prosperity begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Only by achieving harmony with our neighbors can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only by achieving harmony with our neighbors can a new era begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Only once Rizia is united under a strong king can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only once Rizia is united under a strong king can a new era begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""A new era begins now.""]** — Mówca: **Player_Romus**
> ""A new era begins now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[171]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Thank you all.""]** — Mówca: **Player_Romus**
> ""Thank you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Long live House Toras.""]** — Mówca: **Player_Romus**
> ""Long live House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Glovurius axa Rizia.""]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[75]`
Mówca: **Narrator**
> "The hall fell silent again. My uncle was the first to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[77]`
Mówca: **Narrator**
> "The attendees hurriedly broke into enthusiastic applause. The choir restarted the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Coronation End])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[79]`
Mówca: **Narrator**
> "My daughter beamed and put her arm through mine. We walked up and up the stairs until we came to a door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Leaving Vina behind, I walked up and up the stairs until I came to a door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Open it."]** — Mówca: **Player_Romus_Italic**
> "I stepped out onto the balcony. The sunlight was so dazzling I was almost blinded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "When my eyes adjusted, I regarded the scene below me. Thousands and thousands of people were packed onto the palace grounds, some waving the Rizian flag, others the House Toras banner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Just beyond them, at the gates, the police easily held back a small pocket of protesters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Narrator**
> "I paid little attention to them. I was focused on the noise of the crowd, an overwhelming roar that gradually cohered into a single chant: "Salutenas axa regu novus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "All hail the new king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We must stop letting our past grudges dictate our future.""]** — Mówca: **Player_Romus**
> ""We must stop letting our past grudges dictate our future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[87]`
Mówca: **Narrator**
> "I sat upright in the Sila Orica, the gold-plated wooden throne on which all monarchs of Rizia were coronated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_TookOrb = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_RecitedOath = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec fill you with his holy spirit on this day, as he did your ancestors before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_LookedEstela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""May you keep the promises you have made before God and your people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[94]`
Mówca: **Sal Ignacius**
> ""By the divine power vested in me, I proclaim you sovereign king of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Proceed with the coronation."]** — Mówca: **Player_Romus_Italic**
> "I decided to proceed without making a speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[96]`
Mówca: **Sal Ignacius**
> ""Arise, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Uncle Hugo had been smiling politely up to this point. His expression now grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Court == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Court == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Court"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Court == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Court"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Narrator**
> "I remembered wandering between the mosaic-tiled columns as a bored teenager. Goofing off with Pabel in the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I remembered wandering between the mosaic-tiled columns as a bored teenager. Watching from the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`
  - -> `[171]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_Diplomacy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`
  - -> `[171]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_UpholdMonarchy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[171]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Only when the people of Rizia are given a voice can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only when the people of Rizia are given a voice can a new era begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`
  - -> `[171]`

### Węzeł `[115]`
Mówca: **Vina Toras**
> ""Don't worry, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[116]`
Mówca: **Narrator**
> "My daughter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""Me, too. I wish Mother was the one sitting here, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[118]`
Mówca: **Narrator**
> "My daughter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[119]`
Mówca: **Vina Toras**
> ""Sorry!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "My daughter sat up straight and folded her hands in her lap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[121]`
Mówca: **Narrator**
> "My daughter seemed to shrink in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Vina Toras**
> ""You're right, Father. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[40]`
  - -> `[34]`
  - -> `[37]`

### Węzeł `[126]`
Mówca: **Narrator**
> "The ceremonial robes I was wearing chafed against the scar on my shoulder. I thought about the kidnapper's bullet and how close I had come to never seeing this day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Scar == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");
RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;
RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;
Variable["RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_AntiMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_AntiMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_Diplomacy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_UpholdMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_UpholdMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_UpholdMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1;
RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_TakeBackLand == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Coronation_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[161]`
Mówca: **Vina Toras**
> ""You are the king now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Limp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[166]`
Mówca: **Narrator**
> "It was made of pure gold, adorned with two twisting spires resembling bull's horns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[167]`
Mówca: **Narrator**
> "It was inlaid with a trio of diamonds, representing the three royal houses of Rizia: Toras, Azaro and Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God bless this country and its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Glory to Rizia. His shout reverberated throughout the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Coronation End)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Everyone in the crowd bowed their heads as Vina and I made our way down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I passed my cousin Rico in the second row. He looked up at me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "I passed my cousin Rico in the second row. He kept his head down and didn't acknowledge me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Narrator**
> "The entire back row was reserved for the Rumburgian royal family and their entourage. I could feel my sister-in-law Beatrice's eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[181]`
Mówca: **Narrator**
> "As we kept walking, I recognized various other members of Rizia's three royal houses as well as monarchs from distant kingdoms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RizianNationalAnthem");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RizianNationalAnthem");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[184]`
Mówca: **Narrator**
> "According to royal tradition, this was my signal to march down the aisle and up to the palace balcony to greet the public."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[95]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_GaveSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_GaveSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Rising to the throne", "Coronation Celebration", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Rising to the throne","Coronation Celebration","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
