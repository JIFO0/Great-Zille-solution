# Rizia/Turn 10/Notes/Notes Conversation

- **ID konwersacji:** `549`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/549_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 590
- **Liczba wyborów gracza:** 27

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_Military_PowerProjection`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.PalesOwnership_Azaros`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_Rizia_Unification_Failed`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.War_BorderOutcome_Peace_Annexation`
- `RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost`
- `RiziaDLC.War_BorderOutcome_Peace_PalesDivided`
- `RiziaDLC.War_BorderOutcome_Peace_PreWarBorders`
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`
- `RiziaDLCIsolated.TalkWithPM_RPP_Favorability`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.NewGov_Butterfly_Chaos`
- `RiziaDLCIsolated.NewGov_Butterfly_Seasons`
- `RiziaDLCIsolated.NewGov_Butterfly_Taste`
- `RiziaDLCIsolated.NewGov_Butterfly_Traveled`

### Skoki między-konwersacyjne:
- Węzeł `[590]` -> **[546] Rizia/Turn 10/Pales_Reform_Branch/Pales_Reform_Branch Conversation** (../Turn_10/546_Pales_Reform_Branch_Conversation.md), Węzeł `[51]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 130
- **Węzły modyfikujące stan gry:** 10

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[62]` (Paskal Beniwoll): `--;`
- Węzeł `[111]` (Paskal Beniwoll): `--;`
- Węzeł `[309]` (Paskal Beniwoll): `--;`
- Węzeł `[407]` (Paskal Beniwoll): `--;`
- Węzeł `[483]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- Węzeł `[484]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- Węzeł `[485]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- Węzeł `[486]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- *...oraz 2 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’m not surprised. Finding enough qualified, impartial officials in a nation still adjusting to its new system is no small feat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Manus Sazon**
> "“As for voting itself, ballots have been finalized, and the process has been structured for simplicity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Manus Sazon**
> "“No ambiguities, no room for misinterpretation.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Daria de Rava**
> "“As for voting itself, all ballots have been finalized, and the process is designed for simplicity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Daria de Rava**
> "“No room for ambiguity, no chance for misinterpretation.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Adarfo Sotelato**
> ""As for the voting itself, ballots are finalized, and the process is straightforward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Adarfo Sotelato**
> ""No room for confusion, no space for misinterpretation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“There are those who would rather see this election fail than succeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[41]`
  - -> `[37]`
  - -> `[43]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""On a personal note, I'm pleased to see the House of Lords reflect the Crown's ability to adapt while preserving its core values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""It’s a testament to the resilience of our system -- evolving with the times without compromising what defines us...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Preserving the quiet strength that has always guided Rizia forward.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""A measured presence, yet one that will be felt for generations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Manus Sazon**
> ""A subtle presence, yet one that will be felt for generations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Daria de Rava**
> ""I must admit, I’m rather pleased with how Rizia has held on to its traditions -- particularly with the nobility’s continued role in the legislative process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[78]`
Mówca: **Daria de Rava**
> ""The Regional Senate will give voices from all corners of the kingdom a platform -- something long overdue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[85]`
Mówca: **Daria de Rava**
> ""It's reassuring to witness progress taking shape, even as our nation navigates through these changing times.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Daria de Rava**
> ""Despite serving in a more of a ceremonial capacity, it's reassuring to witness progress taking shape, even as our nation navigates through these changing times.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Daria de Rava**
> ""Even in a limited capacity, the essence of the king's court endures.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Daria de Rava**
> ""Even if it's more of a ceremonial capacity, the essence of the king's court endures.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Daria de Rava**
> ""Through them, the essence of the king's court endures.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Daria de Rava**
> ""I must admit, I’m pleased to see such strides toward broader representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""Even if it's authority its authority is modest at best, it's reassuring to witness progress taking shape, even as our nation navigates through these changing times.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[99]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Manus Sazon**
> "“If we are to build trust, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""Which is why we've established a fully independent Electoral Commission, to ensure fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[102]`
  - -> `[98]`
  - -> `[103]`
  - -> `[137]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[130]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Daria de Rava**
> "“To build trust, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[132]`
Mówca: **Daria de Rava**
> "“We should have enough staff for all polling stations, though we’re stretched thin in certain districts.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Adarfo Sotelato**
> ""To build trust, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""We should have enough staff to cover all polling stations, though we're stretched thin in some districts.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly completed training the officials responsible for ensuring transparency and upholding the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[146]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[150]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need. Instead, we've focused on strengthening the process itself, which will lay the foundation for genuine trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[151]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[152]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us to get this right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""That said, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a as a city worker balanced on a ladder."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Daria de Rava**
> ""It’s a valid concern. However, with the Electoral Commission now fully operational, the process has never been more transparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[164]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[165]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[166]`
Mówca: **Daria de Rava**
> ""As we near the completion of training election officials, we’re in a much stronger position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[167]`
Mówca: **Daria de Rava**
> ""The more boots we have on the ground, so to speak, the more we can ensure the integrity of the process.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
Mówca: **Adarfo Sotelato**
> ""The more hands we have in the field, so to speak, the better we can uphold the integrity of the process.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""It's been a long road, but it will ensure the integrity of the process.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""With that in mind, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
Mówca: **Adarfo Sotelato**
> ""With that in mind, we should have sufficient personnel to staff all polling stations, though I won't deny we are stretched in some districts.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""As we approach the completion of training election officials, we're in a much stronger position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[173]`
Mówca: **Adarfo Sotelato**
> ""And now, as we near the completion of training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[174]`
Mówca: **Manus Sazon**
> ""And with the training of election officials nearly complete, we are reinforcing the transparency of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[175]`
Mówca: **Manus Sazon**
> ""By centralizing oversight, we've ensured consistency not only in how elections are managed, but the functioning of the government as a whole.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[176]`
Mówca: **Manus Sazon**
> ""Of course, this transition has required moving away from our old regional structure.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Manus Sazon**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[178]`
Mówca: **Daria de Rava**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Manus Sazon**
> ""Though the unification was peaceful, Pales has areas that are less developed or have limited access to resources compared to Rizia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Manus Sazon**
> "“This disparity poses a challenge for ensuring that every citizen, especially in remote areas, has access to voting.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Manus Sazon**
> ""For some of the population in Pales, the shift from a monarchy to a democratic system is seen as a positive change, offering a newfound sense of political empowerment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Manus Sazon**
> ""The chance to vote and participate in the decision-making process invigorates those who have felt disenfranchised under the old regime, fostering a more engaged electorate, especially among younger generations.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
Mówca: **Narrator**
> ""With Pales under the direct control of the Crown, tensions persist with local forces, but long-term integration, most likely decades, is steadily underway.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
Mówca: **Narrator**
> ""With governance of Pales assigned to House Azaro, tensions persist with local forces, but long-term integration, most likely decades, is steadily underway.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PalesOwnership_Azaros == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PalesOwnership_Azaros == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PalesOwnership_Azaros"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PalesOwnership_Azaros == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PalesOwnership_Azaros"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[188]`
Mówca: **Narrator**
> ""Following the return to prewar borders, no incidents have occurred, and while military buildup on the Pales side remains high, further hostilities are not anticipated.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[192]`
Mówca: **Narrator**
> ""The division of Pales is marked by conflict, though tensions remain manageable, particularly along the new shared border, with full integration expected to take decades.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_Annexation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_Annexation == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_Annexation == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PreWarBorders"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PreWarBorders"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[199]`
Mówca: **Narrator**
> ""The loss of the Pales Administrative District has led to ongoing conflict between Palesian forces and Rizian civilians, which will likely take decades to resolve.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[203]`
Mówca: **Narrator**
> ""Our position in the conflict remains resilient, though with minimal territorial gains on either side, it feels as if we’re edging toward a stalemate.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
Mówca: **Narrator**
> ""Our position in the conflict is weakening, with gradual losses of territory and little to show for our efforts, but our men continue to fight the good fight.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[205]`
Mówca: **Narrator**
> ""Our position in the conflict is dire, with significant losses of territory and no sign of relief. Despite the mounting setbacks, our men continue to fight bravely.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Country_Military_PowerProjection"] <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Country_Military_PowerProjection"] <= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_Military_PowerProjection <= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_Military_PowerProjection <= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_Military_PowerProjection"] <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_Military_PowerProjection <= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_Military_PowerProjection"] <= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification_Failed"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification_Failed == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""Without proper voter education, this unfamiliarity could breed confusion or even resentment, resulting in apathy or resistance to the new system.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
Mówca: **Manus Sazon**
> "“Older citizens or those with strong loyalty to the former monarchy might resist change, viewing the election process as either unnecessary or threatening to the established order.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
Mówca: **Manus Sazon**
> ""Given that Pales was a monarchy, there's still an overall lack of understanding about democracy and how voting works -- the concept feeling alien to many.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[224]`
Mówca: **Daria de Rava**
*(Węzeł logiki narracyjnej: Daria de Rava: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
Mówca: **Adarfo Sotelato**
*(Węzeł logiki narracyjnej: Adarfo Sotelato: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[232]`
Mówca: **Daria de Rava**
*(Węzeł logiki narracyjnej: Daria de Rava: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
Mówca: **Adarfo Sotelato**
*(Węzeł logiki narracyjnej: Adarfo Sotelato: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[237]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
Mówca: **Daria de Rava**
*(Węzeł logiki narracyjnej: Daria de Rava: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""Given that Pales was a monarchy, there's still a lack of understanding about democracy and how voting works -- the concept feels alien to many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[243]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
Mówca: **Daria de Rava**
*(Węzeł logiki narracyjnej: Daria de Rava: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[246]`
Mówca: **Adarfo Sotelato**
*(Węzeł logiki narracyjnej: Adarfo Sotelato: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[253]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[260]`
Mówca: **Adarfo Sotelato**
*(Węzeł logiki narracyjnej: Adarfo Sotelato: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[267]`
Mówca: **Adarfo Sotelato**
*(Węzeł logiki narracyjnej: Adarfo Sotelato: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
Mówca: **Manus Sazon**
*(Węzeł logiki narracyjnej: Manus Sazon: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
Mówca: **Daria de Rava**
*(Węzeł logiki narracyjnej: Daria de Rava: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""By centralizing oversight, we've ensured consistency -- not only in how elections are managed but in the functioning of the government as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Manus Sazon**
> "Now that the Electoral Commission is fully operational—independent, as intended—and the training of election officials is nearly complete, we’re on the right path toward a more trustworthy system.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""Moreover, centralizing the government has has allowed us to provide uniform oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[279]`
Mówca: **Daria de Rava**
> ""Which is why we've established a fully independent Electoral Commission, to guarantee fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Daria de Rava**
> ""And with election officials' training nearing completion, we are reinforcing the transparency of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[284]`
Mówca: **Daria de Rava**
> ""Moreover, centralizing the government, while it has led to a loss of autonomy for the regions, has allowed us to provide uniform oversight across all areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Which is why we've established a fully independent Electoral Commission -- to guarantee impartiality and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Adarfo Sotelato**
> ""With election officials nearly trained, we are taking the necessary steps to ensure the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[290]`
Mówca: **Adarfo Sotelato**
> ""Moreover, centralizing power has allowed us to provide to exert strict oversight across all regions, ensuring uniformity in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[291]`
Mówca: **Adarfo Sotelato**
> ""Whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[292]`
Mówca: **Daria de Rava**
> "“The Electoral Commission is fully operational now -- independent, as intended. And the training of election officials is nearly done.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[293]`
Mówca: **Adarfo Sotelato**
> ""The Electoral Commission is fully operational -- independent, as we planned. And the training election officials is almost done.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[294]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Manus Sazon**
> ""The system will be fully prepared to function as intended once training for election officials is complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[297]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Manus Sazon**
> "“If we are to build trust, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""Which is why we've established a fully independent Electoral Commission, to ensure fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[300]`
  - -> `[296]`
  - -> `[301]`
  - -> `[333]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[328]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Daria de Rava**
> "“To build trust, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[330]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Adarfo Sotelato**
> ""To build trust, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

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
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[339]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly finished training the officials who will oversee it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[342]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[344]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[345]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[346]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[347]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[348]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials. Meaning...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[356]`
Mówca: **Daria de Rava**
> ""The Electoral Commission, however, is fully operational, and we're finishing up the training of election officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a as a city worker balanced on a ladder."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
Mówca: **Daria de Rava**
> ""It’s a valid concern. However, with the Electoral Commission now fully operational, the process has never been more transparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[359]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[360]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission now fully operational, we’re nearly finished training the election officials, whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[361]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, we’re almost finished with training for election officials, whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[362]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[363]`
Mówca: **Daria de Rava**
> ""As we near the completion of training election officials, we’re in a much stronger position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[364]`
Mówca: **Manus Sazon**
> ""As we near the completion of training election officials, we’re in a strong position to ensure everything runs smoothly.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Adarfo Sotelato**
> ""And now, as we near the completion of training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[367]`
Mówca: **Manus Sazon**
> ""And with the training of election officials nearly complete, we are taking the necessary steps to maintain the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[368]`
Mówca: **Daria de Rava**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
Mówca: **Manus Sazon**
> ""Additionally, centralizing the government has has enabled us to provide uniform oversight across all regions, ensuring consistency and reinforcing the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[370]`
Mówca: **Daria de Rava**
> ""Additionally, centralizing the government has enabled us to establish uniform oversight across all regions, despite their loss of autonomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[371]`
Mówca: **Adarfo Sotelato**
> ""With election officials nearly trained, we are taking the necessary steps to ensure the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[372]`
Mówca: **Adarfo Sotelato**
> ""Additionally, centralizing power has enabled us to provide to exert strict oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Adarfo Sotelato**
> ""Whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[374]`
Mówca: **Adarfo Sotelato**
> ""It has ensured uniformity in the election process and upholds the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[375]`
Mówca: **Daria de Rava**
> ""This has ensured consistency in the election process and reinforces the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[376]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[377]`
Mówca: **Manus Sazon**
> ""The system will be fully prepared to function as intended once training for election officials is complete.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[378]`
Mówca: **Daria de Rava**
> ""Which is why we've established a fully independent Electoral Commission, to guarantee fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Daria de Rava**
> ""And with the training of election officials almost complete, we are taking every measure to uphold the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[383]`
Mówca: **Adarfo Sotelato**
> ""Which is why we've established a fully independent Electoral Commission -- to guarantee impartiality and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[390]`
Mówca: **Daria de Rava**
> ""The system will be ready to function as designed once the training of election officials is finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""With the groundwork laid, I’m confident they’ll rise to the occasion and make this happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[393]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Manus Sazon**
> "“If we are to build trust in this system, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Manus Sazon**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Manus Sazon**
> "“The Electoral Commission is now fully operational -- independent, as intended. And the training of election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Manus Sazon**
> "“We should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[398]`
  - -> `[392]`
  - -> `[399]`
  - -> `[437]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[426]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Daria de Rava**
> "“To build trust in this system, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Daria de Rava**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Daria de Rava**
> "“The Electoral Commission is fully operational now -- independent, as intended. And the training of election officials is nearly done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Daria de Rava**
> "“We should have enough staff for all polling stations, though we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[431]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Adarfo Sotelato**
> ""To build trust in this system, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Adarfo Sotelato**
> ""Now, moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Adarfo Sotelato**
> ""The Electoral Commission is fully operational -- independent, as we planned. And the training election officials is almost done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Adarfo Sotelato**
> ""We should have enough staff to cover all polling stations, though we're stretched thin in some districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[441]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[443]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[445]`
Mówca: **Daria de Rava**
> ""With that in mind, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[446]`
Mówca: **Adarfo Sotelato**
> ""With that in mind, we should have sufficient personnel to staff all polling stations, though I won't deny we are stretched in some districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[447]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[448]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials. Meaning...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[450]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly finished training the officials who will oversee it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[451]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[458]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a as a city worker balanced on a ladder."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[459]`
Mówca: **Daria de Rava**
> ""The Electoral Commission, however, is fully operational, and we're finishing up the training of election officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[460]`
Mówca: **Manus Sazon**
> ""That said, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[461]`
Mówca: **Daria de Rava**
> ""It’s a valid concern. However, with the Electoral Commission now fully operational, the process has never been more transparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[462]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[463]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[465]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[466]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[467]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission fully operational, we’re nearing the end of training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[469]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, we’re almost finished with training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""Especially now that we're nearing the completion of training election officials, we’re in a strong position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[471]`
Mówca: **Daria de Rava**
> ""With the completion of training election officials on the horizon, we're well-positioned to ensure smooth operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[472]`
Mówca: **Adarfo Sotelato**
> ""And now, as we're nearly finished training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[473]`
Mówca: **Daria de Rava**
> ""The more boots we have on the ground, so to speak, the more we can ensure the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[474]`
Mówca: **Adarfo Sotelato**
> ""The more hands we have in the field, so to speak, the better we can uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[475]`
Mówca: **Manus Sazon**
> ""It's been a long road, but it will ensure the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[476]`
Mówca: **Narrator**
> "I stood on the palace balcony, watching as a flurry of monarch butterflies drifted through the air, their orange wings catching the late spring afternoon sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[480]`
Mówca: **Narrator**
> "They had come from as far as Rumburg, journeying thousands of miles to reach southern Xina, where they would winter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Narrator**
> "Rizia lay in the heart of their migration path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Narrator**
> "I had seen them before, but this time, something about their passage struck me differently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[492]`
  - -> `[494]`
  - -> `[489]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Perhaps it was the timing – this season of change, of endings and beginnings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[488]`
Mówca: **Narrator**
> "A soft knock at the door drew me from my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't stop thinking about how when butterflies land on you, they’re tasting you with their feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[490]`
Mówca: **Narrator**
> "How even the smallest decisions in my reign -- those made in quiet moments -- could set off a chain of events far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't help but think that I, too, had traveled a great distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[493]`
Mówca: **Narrator**
> "I was not the man I had been when I first took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I thought about how the flutter of a butterfly's wings could send ripples through the air, unseen but far-reaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[495]`
Mówca: **Narrator**
> "And my transformation would carry me far into the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[496]`
Mówca: **Narrator**
> "I was once again reminded of how the smallest of actions could result in consequences far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Narrator**
> "I was once again reminded that they taste with their feet -- how life is fully of strange, unexpected oddities."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[498]`
Mówca: **Narrator**
> "Yet, I remained resolute. I would see whatever came my way through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Taste == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Taste == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[508]`
Mówca: **Narrator**
> "And no matter how strange the journey ahead might be, I would face the future head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[510]`
Mówca: **Narrator**
> "As their footsteps faded down the corridor, I turned my gaze to the window overlooking the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
Mówca: **Narrator**
> "The sun had begun to set, and the silhouettes of butterflies fluttered against the fading light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[515]`
  - -> `[499]`
  - -> `[502]`

### Węzeł `[512]`
Mówca: **Narrator**
> "I was once again reminded of the distance I had traveled to get here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Narrator**
> "How my journey was far from over, and I would see it through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[514]`
Mówca: **Narrator**
> "I was once again reminded that, like the seasons, I too had changed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[518]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[519]`
Mówca: **Manus Sazon**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Manus Sazon**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[528]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[529]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[538]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[543]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[544]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[548]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[553]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[557]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[558]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[562]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[563]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`
  - -> `[566]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[567]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[568]`
Mówca: **Manus Sazon**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[572]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[576]`
Mówca: **Manus Sazon**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[577]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[578]`
Mówca: **Manus Sazon**
> ""Overall, there's still a lack of understanding about democracy and how voting works -- the concept feeling alien to many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[579]`
Mówca: **Manus Sazon**
> ""That said, a large portion of the population sees the shift from a monarchy to a democratic system as a positive change, offering a newfound sense of political empowerment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[580]`
Mówca: **Manus Sazon**
> ""While some of the older population has shown resistance to change, the chance to vote has energized those who felt sidelined under the old regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[581]`
Mówca: **Manus Sazon**
> ""As a result, much to our advantage, the electorate has become more engaged, particularly the younger citizens.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[582]`
Mówca: **Manus Sazon**
> ""Because the unification was peaceful, citizens in Pales are supporting the electoral process and have a positive view of Rizia’s governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Manus Sazon**
> ""Voter education efforts are being readily accepted, ensuring a smoother transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Manus Sazon**
> ""The unification allowed for joint planning of electoral infrastructure, so registration and voting systems were set up with more cooperation between Rizia and Pales' local leaders, reducing friction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[585]`
Mówca: **Manus Sazon**
> ""Pales' own regional governance structures clash with the nationalized systems being implemented by Rizia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[586]`
Mówca: **Manus Sazon**
> "“Aligning these systems has led to slowdowns in organizing the election and a lack of full cooperation from local authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Pales_KingResponse_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `546` (*Rizia/Turn 10/Pales_Reform_Branch/Pales_Reform_Branch Conversation*), Węzeł `[51]`
