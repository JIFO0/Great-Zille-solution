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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“I’m not surprised. Finding enough qualified, impartial officials in a nation stil..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[4]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[5]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[6]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[37]` | **"“There are those who would rather see this election fail than succeed.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[41]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[42]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[43]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[98]` | **"“You mean... everyone more likely to vote for you.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Manus Sazon**: "“I mean everyone, Your Majesty. ..."<br>`[130]` **Daria de Rava**: "“I mean everyone, Your Majesty. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""I suppose some still need convincing that their vote actually matters.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Manus Sazon**: ""A valid concern. But with the E..."<br>`[162]` **Daria de Rava**: ""It’s a valid concern. However, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **""This is all happening so fast.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Manus Sazon**: ""Fast, yes -- but that doesn't m..."<br>`[143]` **Daria de Rava**: ""Fast, yes -- but not careless o..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **""It sounds like things are moving in the right direction.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Manus Sazon**: ""Absolutely. With the Electoral ..."<br>`[164]` **Daria de Rava**: "“Certainly. With the Electoral C..."<br>*(oraz 1 innych odgałęzień)* |
| `[136]` | **""Maybe we should put the ballot boxes in the taverns -- that would get their atten..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Manus Sazon**: "“As entertaining as that would b..."<br>`[150]` **Daria de Rava**: ""While that may get attention, i..."<br>*(oraz 1 innych odgałęzień)* |
| `[296]` | **"“You mean... everyone more likely to vote for you.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Manus Sazon**: "“I mean everyone, Your Majesty. ..."<br>`[328]` **Daria de Rava**: "“I mean everyone, Your Majesty. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[300]` | **""I suppose some still need convincing that their vote actually matters.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Manus Sazon**: ""A valid concern. But with the E..."<br>`[358]` **Daria de Rava**: ""It’s a valid concern. However, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[301]` | **""This is all happening so fast.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Manus Sazon**: ""Fast, yes -- but that doesn't m..."<br>`[339]` **Daria de Rava**: ""Fast, yes -- but not careless o..."<br>*(oraz 1 innych odgałęzień)* |
| `[302]` | **""It sounds like things are moving in the right direction.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Manus Sazon**: ""Absolutely. With the Electoral ..."<br>`[361]` **Daria de Rava**: "“Certainly. With the Electoral C..."<br>*(oraz 1 innych odgałęzień)* |
| `[332]` | **""Maybe we should put the ballot boxes in the taverns -- that would get their atten..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Manus Sazon**: "“As entertaining as that would b..."<br>`[346]` **Daria de Rava**: ""While that may get attention, i..."<br>*(oraz 1 innych odgałęzień)* |
| `[392]` | **"“You mean... everyone more likely to vote for you.”"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Manus Sazon**: "“I mean everyone, Your Majesty. ..."<br>`[426]` **Daria de Rava**: "“I mean everyone, Your Majesty. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[398]` | **""I suppose some still need convincing that their vote actually matters.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Manus Sazon**: ""A valid concern. But with the E..."<br>`[461]` **Daria de Rava**: ""It’s a valid concern. However, ..."<br>*(oraz 1 innych odgałęzień)* |
| `[399]` | **""This is all happening so fast.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[463]` **Manus Sazon**: ""Fast, yes -- but that doesn't m..."<br>`[465]` **Daria de Rava**: ""Fast, yes -- but not careless o..."<br>*(oraz 1 innych odgałęzień)* |
| `[400]` | **""It sounds like things are moving in the right direction.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Manus Sazon**: ""Absolutely. With the Electoral ..."<br>`[469]` **Daria de Rava**: "“Certainly. With the Electoral C..."<br>*(oraz 1 innych odgałęzień)* |
| `[436]` | **""Maybe we should put the ballot boxes in the taverns -- that would get their atten..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Manus Sazon**: "“As entertaining as that would b..."<br>`[451]` **Daria de Rava**: ""While that may get attention, i..."<br>*(oraz 1 innych odgałęzień)* |
| `[487]` | **"Perhaps it was the timing – this season of change, of endings and beginnings."** | `[482]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = t...` | `[493]` **Narrator**: "I was not the man I had been whe..." |
| `[489]` | **"I couldn't stop thinking about how when butterflies land on you, they’re tasting y..."** | `[482]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;` | `[488]` **Narrator**: "A soft knock at the door drew me..." |
| `[492]` | **"I couldn't help but think that I, too, had traveled a great distance."** | `[482]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = ...` | `[493]` **Narrator**: "I was not the man I had been whe..." |
| `[494]` | **"I thought about how the flutter of a butterfly's wings could send ripples through ..."** | `[482]` **Narrator**: "I had seen them before, but this..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;` | `[490]` **Narrator**: "How even the smallest decisions ..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’m not surprised. Finding enough qualified, impartial officials in a nation still adjusting to its new system is no small feat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Manus Sazon**
> "“As for voting itself, ballots have been finalized, and the process has been structured for simplicity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Manus Sazon: "“No ambiguities, no room for misinterpretation.”"*)

### Węzeł `[32]`
Mówca: **Manus Sazon**
> "“No ambiguities, no room for misinterpretation.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Daria de Rava**
> "“As for voting itself, all ballots have been finalized, and the process is designed for simplicity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Daria de Rava: "“No room for ambiguity, no chance for misinterpretation.”"*)

### Węzeł `[34]`
Mówca: **Daria de Rava**
> "“No room for ambiguity, no chance for misinterpretation.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Adarfo Sotelato**
> ""As for the voting itself, ballots are finalized, and the process is straightforward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Adarfo Sotelato: ""No room for confusion, no space for misinterpretation.""*)

### Węzeł `[36]`
Mówca: **Adarfo Sotelato**
> ""No room for confusion, no space for misinterpretation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“There are those who would rather see this election fail than succeed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[37]` (*Player_Romus: "“There are those who would rather see this election fail ..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""On a personal note, I'm pleased to see the House of Lords reflect the Crown's ability to adapt while preserving its core values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""It’s a testament to the resilience of our system -- evol..."*)

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""It’s a testament to the resilience of our system -- evolving with the times without compromising what defines us...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Preserving the quiet strength that has always guided Rizia forward.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Manus Sazon: ""A measured presence, yet one that will be felt for gener..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manus Sazon: ""A subtle presence, yet one that will be felt for generat..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manus Sazon: ""Preserving the quiet strength that has always guided Riz..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

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
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[78]`
Mówca: **Daria de Rava**
> ""The Regional Senate will give voices from all corners of the kingdom a platform -- something long overdue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Daria de Rava: ""Even if it's authority its authority is modest at best, ..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Daria de Rava: ""Despite serving in a more of a ceremonial capacity, it's..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Daria de Rava: ""It's reassuring to witness progress taking shape, even a..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Equal == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Daria de Rava: ""Through them, the essence of the king's court endures.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)

### Węzeł `[92]`
Mówca: **Daria de Rava**
> ""Through them, the essence of the king's court endures.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Daria de Rava**
> ""I must admit, I’m pleased to see such strides toward broader representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Daria de Rava: ""The Regional Senate will give voices from all corners of..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Limited == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Daria de Rava: ""Even in a limited capacity, the essence of the king's co..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Daria de Rava: ""Even if it's more of a ceremonial capacity, the essence ..."*)

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""Even if it's authority its authority is modest at best, it's reassuring to witness progress taking shape, even as our nation navigates through these changing times.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[99]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Manus Sazon: "“If we are to build trust, every citizen must have the op..."*)

### Węzeł `[100]`
Mówca: **Manus Sazon**
> "“If we are to build trust, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Manus Sazon: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""Which is why we've established a fully independent Electoral Commission, to ensure fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Manus Sazon: ""And with the training of election officials nearly compl..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Manus Sazon: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Daria de Rava: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Adarfo Sotelato: ""I mean everyone, even those who might not vote in my fav..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""It sounds like things are moving in the right direction.""*)
  - -> `[102]` (*Player_Romus: ""I suppose some still need convincing that their vote act..."*)
  - -> `[98]` (*Player_Romus: "“You mean... everyone more likely to vote for you.”"*)
  - -> `[103]` (*Player_Romus: ""This is all happening so fast.""*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Manus Sazon: ""Fast, yes -- but that doesn't mean rushed. We've been th..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Daria de Rava: ""Fast, yes -- but not careless or rushed. We've been thor..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Adarfo Sotelato: ""It may feel fast to you, but for those who've spent thei..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""A valid concern. But with the Electoral Commission now f..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Daria de Rava: ""It’s a valid concern. However, with the Electoral Commis..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Adarfo Sotelato: ""There is. But with the Electoral Commission fully operat..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Manus Sazon: ""Absolutely. With the Electoral Commission now fully oper..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Daria de Rava: "“Certainly. With the Electoral Commission now fully opera..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Adarfo Sotelato: ""They are. With the Electoral Commission now fully operat..."*)

### Węzeł `[130]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Daria de Rava: "“To build trust, every citizen must be given the chance t..."*)

### Węzeł `[131]`
Mówca: **Daria de Rava**
> "“To build trust, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Daria de Rava: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[132]`
Mówca: **Daria de Rava**
> "“We should have enough staff for all polling stations, though we’re stretched thin in certain districts.”"
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Adarfo Sotelato: ""To build trust, every citizen must be given the chance t..."*)

### Węzeł `[134]`
Mówca: **Adarfo Sotelato**
> ""To build trust, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Adarfo Sotelato: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""We should have enough staff to cover all polling stations, though we're stretched thin in some districts.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Maybe we should put the ballot boxes in the taverns -- t..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[141]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Manus Sazon: ""And the training of election officials is nearly complet..."*)

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Daria de Rava: ""Take the Electoral Commission -- they're fully operation..."*)

### Węzeł `[144]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Daria de Rava: ""And the training process for election officials is nearl..."*)

### Węzeł `[145]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly completed training the officials responsible for ensuring transparency and upholding the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[146]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Adarfo Sotelato: ""Which is exactly why we've taken every measure to build ..."*)

### Węzeł `[147]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Adarfo Sotelato: ""And with that foundation in place, we've nearly complete..."*)

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Manus Sazon: ""As we approach the completion of training election offic..."*)

### Węzeł `[150]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need. Instead, we've focused on strengthening the process itself, which will lay the foundation for genuine trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Daria de Rava: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[151]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[152]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us to get this right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Adarfo Sotelato: ""Fortunately, the Electoral Commission is almost finished..."*)

### Węzeł `[153]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials, whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Adarfo Sotelato: ""With the groundwork laid, I’m confident they’ll rise to ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Daria de Rava: ""While that may get attention, it's not the kind we need...."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Adarfo Sotelato: ""This isn't a joke. The people are counting on us to get ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Manus Sazon: "“As entertaining as that would be, we’re still focused on..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

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
  - -> `[166]` (*Daria de Rava: ""As we near the completion of training election officials..."*)

### Węzeł `[163]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Adarfo Sotelato: ""And now, as we near the completion of training election ..."*)

### Węzeł `[164]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Daria de Rava: ""The system will be ready to function as designed once th..."*)

### Węzeł `[165]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Adarfo Sotelato: ""Whose duty is to ensure transparency and uphold the inte..."*)

### Węzeł `[166]`
Mówca: **Daria de Rava**
> ""As we near the completion of training election officials, we’re in a much stronger position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

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
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[173]`
Mówca: **Adarfo Sotelato**
> ""And now, as we near the completion of training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[174]`
Mówca: **Manus Sazon**
> ""And with the training of election officials nearly complete, we are reinforcing the transparency of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

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
  - -> `[180]` (*Manus Sazon: "“This disparity poses a challenge for ensuring that every..."*)

### Węzeł `[180]`
Mówca: **Manus Sazon**
> "“This disparity poses a challenge for ensuring that every citizen, especially in remote areas, has access to voting.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Manus Sazon**
> ""For some of the population in Pales, the shift from a monarchy to a democratic system is seen as a positive change, offering a newfound sense of political empowerment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Manus Sazon: ""The chance to vote and participate in the decision-makin..."*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PalesOwnership_Azaros == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PalesOwnership_Azaros == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PalesOwnership_Azaros == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PalesOwnership_Azaros == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PalesOwnership_Azaros"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: ""With governance of Pales assigned to House Azaro, tensio..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PalesOwnership_Azaros == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PalesOwnership_Azaros"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: ""With Pales under the direct control of the Crown, tensio..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> ""Following the return to prewar borders, no incidents have occurred, and while military buildup on the Pales side remains high, further hostilities are not anticipated.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: ""The division of Pales is marked by conflict, though tens..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesDivided"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true"*)

### Węzeł `[192]`
Mówca: **Narrator**
> ""The division of Pales is marked by conflict, though tensions remain manageable, particularly along the new shared border, with full integration expected to take decades.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_Annexation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == false"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_Annexation == false)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_Annexation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PalesOwnership_Azaros == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_Annexation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_Annexation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesDivided == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PreWarBorders"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: ""Following the return to prewar borders, no incidents hav..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PreWarBorders == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PreWarBorders"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost =..."*)

### Węzeł `[199]`
Mówca: **Narrator**
> ""The loss of the Pales Administrative District has led to ongoing conflict between Palesian forces and Rizian civilians, which will likely take decades to resolve.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification_Failed == true"*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_P..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true && RiziaDLC.Country_Military..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Country_Military_PowerProjection"] <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: ""Our position in the conflict is weakening, with gradual ..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_PowerProjection <= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  and  Variable["RiziaDLC.Country_Military_PowerProjection"] <= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: ""Our position in the conflict is dire, with significant l..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_Military_PowerProjection <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_Military_PowerProjection <= 10"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_Military_PowerProjection <= 10)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_Military_PowerProjection <= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_Military_PowerProjection"] <= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: ""Our position in the conflict remains resilient, though w..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_Military_PowerProjection <= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_Military_PowerProjection"] <= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true && RiziaDLC.Country_Military_P..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == false"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == false)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_Annexation == false"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_Military_PowerProjection <= 10"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification_Failed == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification_Failed == true )"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification_Failed"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification_Failed == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost =..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: ""The loss of the Pales Administrative District has led to..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_BorderOutcome_Peace_PalesAdminDistrictLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Daria de Rava: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Adarfo Sotelato: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "Daria de Rava: "...""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Adarfo Sotelato: "...""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Daria de Rava: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Adarfo Sotelato: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "Daria de Rava: "...""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "Adarfo Sotelato: "...""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Daria de Rava: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""Given that Pales was a monarchy, there's still a lack of understanding about democracy and how voting works -- the concept feels alien to many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""Without proper voter education, this unfamiliarity could..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Daria de Rava: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Adarfo Sotelato: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Daria de Rava: "...""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "Adarfo Sotelato: "...""*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "Daria de Rava: "...""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "Adarfo Sotelato: "...""*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Adarfo Sotelato: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "Manus Sazon: "...""*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "Daria de Rava: "...""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "Adarfo Sotelato: "...""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Adarfo Sotelato: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Manus Sazon: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Daria de Rava: "..."`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Manus Sazon: ""Moreover, centralizing the government has has allowed us..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""By centralizing oversight, we've ensured consistency -- not only in how elections are managed but in the functioning of the government as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: "Now that the Electoral Commission is fully operational—in..."*)

### Węzeł `[277]`
Mówca: **Manus Sazon**
> "Now that the Electoral Commission is fully operational—independent, as intended—and the training of election officials is nearly complete, we’re on the right path toward a more trustworthy system.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""Moreover, centralizing the government has has allowed us to provide uniform oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[279]`
Mówca: **Daria de Rava**
> ""Which is why we've established a fully independent Electoral Commission, to guarantee fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Daria de Rava: ""And with election officials' training nearing completion..."*)

### Węzeł `[280]`
Mówca: **Daria de Rava**
> ""And with election officials' training nearing completion, we are reinforcing the transparency of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Daria de Rava: ""Moreover, centralizing the government, while it has led ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[284]`
Mówca: **Daria de Rava**
> ""Moreover, centralizing the government, while it has led to a loss of autonomy for the regions, has allowed us to provide uniform oversight across all areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Which is why we've established a fully independent Electoral Commission -- to guarantee impartiality and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Adarfo Sotelato: ""With election officials nearly trained, we are taking th..."*)

### Węzeł `[286]`
Mówca: **Adarfo Sotelato**
> ""With election officials nearly trained, we are taking the necessary steps to ensure the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Adarfo Sotelato: ""Moreover, centralizing power has allowed us to provide t..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[290]`
Mówca: **Adarfo Sotelato**
> ""Moreover, centralizing power has allowed us to provide to exert strict oversight across all regions, ensuring uniformity in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[291]`
Mówca: **Adarfo Sotelato**
> ""Whose duty is to ensure transparency and uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

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
  - -> `[295]` (*Manus Sazon: ""The system will be fully prepared to function as intende..."*)

### Węzeł `[295]`
Mówca: **Manus Sazon**
> ""The system will be fully prepared to function as intended once training for election officials is complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[297]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Manus Sazon: "“If we are to build trust, every citizen must have the op..."*)

### Węzeł `[298]`
Mówca: **Manus Sazon**
> "“If we are to build trust, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Manus Sazon: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""Which is why we've established a fully independent Electoral Commission, to ensure fairness and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Manus Sazon: ""And with the training of election officials nearly compl..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Manus Sazon: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Daria de Rava: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Adarfo Sotelato: ""I mean everyone, even those who might not vote in my fav..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""It sounds like things are moving in the right direction.""*)
  - -> `[300]` (*Player_Romus: ""I suppose some still need convincing that their vote act..."*)
  - -> `[296]` (*Player_Romus: "“You mean... everyone more likely to vote for you.”"*)
  - -> `[301]` (*Player_Romus: ""This is all happening so fast.""*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Manus Sazon: ""Fast, yes -- but that doesn't mean rushed. We've been th..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Daria de Rava: ""Fast, yes -- but not careless or rushed. We've been thor..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Adarfo Sotelato: ""It may feel fast to you, but for those who've spent thei..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Manus Sazon: ""A valid concern. But with the Electoral Commission now f..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Daria de Rava: ""It’s a valid concern. However, with the Electoral Commis..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Adarfo Sotelato: ""There is. But with the Electoral Commission fully operat..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Manus Sazon: ""Absolutely. With the Electoral Commission now fully oper..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Daria de Rava: "“Certainly. With the Electoral Commission now fully opera..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Adarfo Sotelato: ""They are. With the Electoral Commission now fully operat..."*)

### Węzeł `[328]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Daria de Rava: "“To build trust, every citizen must be given the chance t..."*)

### Węzeł `[329]`
Mówca: **Daria de Rava**
> "“To build trust, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Daria de Rava: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[330]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Adarfo Sotelato: ""To build trust, every citizen must be given the chance t..."*)

### Węzeł `[331]`
Mówca: **Adarfo Sotelato**
> ""To build trust, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Adarfo Sotelato: ""Which is why we've established a fully independent Elect..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player_Romus: ""Maybe we should put the ballot boxes in the taverns -- t..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[336]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[337]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Manus Sazon: ""And the training of election officials is nearly complete.""*)

### Węzeł `[338]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[339]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Daria de Rava: ""Take the Electoral Commission -- they're fully operation..."*)

### Węzeł `[340]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Daria de Rava: ""And the training process for election officials is nearl..."*)

### Węzeł `[341]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly finished training the officials who will oversee it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[342]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Adarfo Sotelato: ""Which is exactly why we've taken every measure to build ..."*)

### Węzeł `[343]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Adarfo Sotelato: ""And with that foundation in place, we've nearly finished..."*)

### Węzeł `[344]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[345]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Manus Sazon: ""As we near the completion of training election officials..."*)

### Węzeł `[346]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Daria de Rava: ""The Electoral Commission, however, is fully operational,..."*)

### Węzeł `[347]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[348]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Adarfo Sotelato: ""Fortunately, the Electoral Commission is almost finished..."*)

### Węzeł `[349]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials. Meaning...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Daria de Rava: ""While that may get attention, it's not the kind we need.""*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Adarfo Sotelato: ""This isn't a joke. The people are counting on us.""*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Manus Sazon: "“As entertaining as that would be, we’re still focused on..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[356]`
Mówca: **Daria de Rava**
> ""The Electoral Commission, however, is fully operational, and we're finishing up the training of election officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a as a city worker balanced on a ladder."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
Mówca: **Daria de Rava**
> ""It’s a valid concern. However, with the Electoral Commission now fully operational, the process has never been more transparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Daria de Rava: ""As we near the completion of training election officials..."*)

### Węzeł `[359]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Adarfo Sotelato: ""And now, as we near the completion of training election ..."*)

### Węzeł `[360]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission now fully operational, we’re nearly finished training the election officials, whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[361]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, we’re almost finished with training for election officials, whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[362]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Adarfo Sotelato: ""Whose duty is to uphold the integrity of the process.""*)

### Węzeł `[363]`
Mówca: **Daria de Rava**
> ""As we near the completion of training election officials, we’re in a much stronger position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[364]`
Mówca: **Manus Sazon**
> ""As we near the completion of training election officials, we’re in a strong position to ensure everything runs smoothly.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Adarfo Sotelato**
> ""And now, as we near the completion of training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[367]`
Mówca: **Manus Sazon**
> ""And with the training of election officials nearly complete, we are taking the necessary steps to maintain the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[368]`
Mówca: **Daria de Rava**
> ""And the efforts to overcome logistical hurdles will ultimately strengthen our democratic foundation.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
Mówca: **Manus Sazon**
> ""Additionally, centralizing the government has has enabled us to provide uniform oversight across all regions, ensuring consistency and reinforcing the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[370]`
Mówca: **Daria de Rava**
> ""Additionally, centralizing the government has enabled us to establish uniform oversight across all regions, despite their loss of autonomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Daria de Rava: ""This has ensured consistency in the election process and..."*)

### Węzeł `[371]`
Mówca: **Adarfo Sotelato**
> ""With election officials nearly trained, we are taking the necessary steps to ensure the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[372]`
Mówca: **Adarfo Sotelato**
> ""Additionally, centralizing power has enabled us to provide to exert strict oversight across all regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Adarfo Sotelato: ""It has ensured uniformity in the election process and up..."*)

### Węzeł `[373]`
Mówca: **Adarfo Sotelato**
> ""Whose duty is to uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[374]`
Mówca: **Adarfo Sotelato**
> ""It has ensured uniformity in the election process and upholds the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[375]`
Mówca: **Daria de Rava**
> ""This has ensured consistency in the election process and reinforces the legitimacy of every vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

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
  - -> `[379]` (*Daria de Rava: ""And with the training of election officials almost compl..."*)

### Węzeł `[379]`
Mówca: **Daria de Rava**
> ""And with the training of election officials almost complete, we are taking every measure to uphold the integrity of this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Manus Sazon: ""Additionally, centralizing the government has has enable..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[383]`
Mówca: **Adarfo Sotelato**
> ""Which is why we've established a fully independent Electoral Commission -- to guarantee impartiality and independence in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Adarfo Sotelato: ""With election officials nearly trained, we are taking th..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Daria de Rava: ""Additionally, centralizing the government has enabled us..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Adarfo Sotelato: ""Additionally, centralizing power has enabled us to provi..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[390]`
Mówca: **Daria de Rava**
> ""The system will be ready to function as designed once the training of election officials is finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[391]`
Mówca: **Adarfo Sotelato**
> ""With the groundwork laid, I’m confident they’ll rise to the occasion and make this happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You mean... everyone more likely to vote for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[393]`
Mówca: **Manus Sazon**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Manus Sazon: "“If we are to build trust in this system, every citizen m..."*)

### Węzeł `[394]`
Mówca: **Manus Sazon**
> "“If we are to build trust in this system, every citizen must have the opportunity to cast their vote, regardless of their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Manus Sazon: "“Moving on...”"*)

### Węzeł `[395]`
Mówca: **Manus Sazon**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Manus Sazon: "“The Electoral Commission is now fully operational -- ind..."*)

### Węzeł `[396]`
Mówca: **Manus Sazon**
> "“The Electoral Commission is now fully operational -- independent, as intended. And the training of election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Manus Sazon: "“We should have enough personnel to cover all polling sta..."*)

### Węzeł `[397]`
Mówca: **Manus Sazon**
> "“We should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose some still need convincing that their vote actually matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all happening so fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like things are moving in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Manus Sazon: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Daria de Rava: "“I mean everyone, Your Majesty. Even those who would rath..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Adarfo Sotelato: ""I mean everyone, even those who might not vote in my fav..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player_Romus: ""It sounds like things are moving in the right direction.""*)
  - -> `[398]` (*Player_Romus: ""I suppose some still need convincing that their vote act..."*)
  - -> `[392]` (*Player_Romus: "“You mean... everyone more likely to vote for you.”"*)
  - -> `[399]` (*Player_Romus: ""This is all happening so fast.""*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Manus Sazon: ""Fast, yes -- but that doesn't mean rushed. We've been th..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Daria de Rava: ""Fast, yes -- but not careless or rushed. We've been thor..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Adarfo Sotelato: ""It may feel fast to you, but for those who've spent thei..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Manus Sazon: ""A valid concern. But with the Electoral Commission now f..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Daria de Rava: ""It’s a valid concern. However, with the Electoral Commis..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Adarfo Sotelato: ""There is. But with the Electoral Commission fully operat..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Manus Sazon: ""Absolutely. With the Electoral Commission fully operatio..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Daria de Rava: "“Certainly. With the Electoral Commission now fully opera..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Adarfo Sotelato: ""They are. With the Electoral Commission now fully operat..."*)

### Węzeł `[426]`
Mówca: **Daria de Rava**
> "“I mean everyone, Your Majesty. Even those who would rather see me lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Daria de Rava: "“To build trust in this system, every citizen must be giv..."*)

### Węzeł `[427]`
Mówca: **Daria de Rava**
> "“To build trust in this system, every citizen must be given the chance to vote, no matter their leanings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Daria de Rava: "“Moving on...”"*)

### Węzeł `[428]`
Mówca: **Daria de Rava**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Daria de Rava: "“The Electoral Commission is fully operational now -- ind..."*)

### Węzeł `[429]`
Mówca: **Daria de Rava**
> "“The Electoral Commission is fully operational now -- independent, as intended. And the training of election officials is nearly done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Daria de Rava: "“We should have enough staff for all polling stations, th..."*)

### Węzeł `[430]`
Mówca: **Daria de Rava**
> "“We should have enough staff for all polling stations, though we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[431]`
Mówca: **Adarfo Sotelato**
> ""I mean everyone, even those who might not vote in my favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Adarfo Sotelato: ""To build trust in this system, every citizen must be giv..."*)

### Węzeł `[432]`
Mówca: **Adarfo Sotelato**
> ""To build trust in this system, every citizen must be given the chance to vote, no matter where they stand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Adarfo Sotelato: ""Now, moving on...""*)

### Węzeł `[433]`
Mówca: **Adarfo Sotelato**
> ""Now, moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Adarfo Sotelato: ""The Electoral Commission is fully operational -- indepen..."*)

### Węzeł `[434]`
Mówca: **Adarfo Sotelato**
> ""The Electoral Commission is fully operational -- independent, as we planned. And the training election officials is almost done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Adarfo Sotelato: ""We should have enough staff to cover all polling station..."*)

### Węzeł `[435]`
Mówca: **Adarfo Sotelato**
> ""We should have enough staff to cover all polling stations, though we're stretched thin in some districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe we should put the ballot boxes in the taverns -- that would get their attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Player_Romus: ""Maybe we should put the ballot boxes in the taverns -- t..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""And the training of election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Manus Sazon: "“We should have enough personnel to cover all polling sta..."*)

### Węzeł `[441]`
Mówca: **Daria de Rava**
> ""Take the Electoral Commission -- they're fully operational now, and independent, just as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Daria de Rava: ""And the training process for election officials is nearl..."*)

### Węzeł `[442]`
Mówca: **Daria de Rava**
> ""And the training process for election officials is nearly complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Daria de Rava: "“We should have enough staff for all polling stations, th..."*)

### Węzeł `[443]`
Mówca: **Adarfo Sotelato**
> ""It may feel fast to you, but for those who've spent their whole lives without a voice... it's been painfully slow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Adarfo Sotelato: ""Which is exactly why we've taken every measure to build ..."*)

### Węzeł `[444]`
Mówca: **Adarfo Sotelato**
> ""Which is exactly why we've taken every measure to build an independent Electoral Commission, one that answers to the people and no none else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Adarfo Sotelato: ""And with that foundation in place, we've nearly finished..."*)

### Węzeł `[445]`
Mówca: **Daria de Rava**
> ""With that in mind, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[446]`
Mówca: **Adarfo Sotelato**
> ""With that in mind, we should have sufficient personnel to staff all polling stations, though I won't deny we are stretched in some districts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[447]`
Mówca: **Manus Sazon**
> "“As entertaining as that would be, we’re still focused on ensuring that everyone has access to a proper, legitimate vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[448]`
Mówca: **Adarfo Sotelato**
> ""This isn't a joke. The people are counting on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Adarfo Sotelato: ""Fortunately, the Electoral Commission is almost finished..."*)

### Węzeł `[449]`
Mówca: **Adarfo Sotelato**
> ""Fortunately, the Electoral Commission is almost finished with the training of election officials. Meaning...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Adarfo Sotelato: ""We should have enough staff to cover all polling station..."*)

### Węzeł `[450]`
Mówca: **Adarfo Sotelato**
> ""And with that foundation in place, we've nearly finished training the officials who will oversee it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Adarfo Sotelato: ""We should have enough staff to cover all polling station..."*)

### Węzeł `[451]`
Mówca: **Daria de Rava**
> ""While that may get attention, it's not the kind we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Daria de Rava: ""The Electoral Commission, however, is fully operational,..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Manus Sazon: "“As entertaining as that would be, we’re still focused on..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Daria de Rava: ""While that may get attention, it's not the kind we need.""*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Adarfo Sotelato: ""This isn't a joke. The people are counting on us.""*)

### Węzeł `[458]`
Mówca: **Narrator**
> "As the motorcade slowed at the intersection, my gaze lingered on a as a city worker balanced on a ladder."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[459]`
Mówca: **Daria de Rava**
> ""The Electoral Commission, however, is fully operational, and we're finishing up the training of election officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Daria de Rava: "“We should have enough staff for all polling stations, th..."*)

### Węzeł `[460]`
Mówca: **Manus Sazon**
> ""That said, we should have enough personnel to cover all polling stations, though I won’t deny we’re stretched thin in certain districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "As the motorcade slowed at the intersection, my gaze ling..."*)

### Węzeł `[461]`
Mówca: **Daria de Rava**
> ""It’s a valid concern. However, with the Electoral Commission now fully operational, the process has never been more transparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Daria de Rava: ""With the completion of training election officials on th..."*)

### Węzeł `[462]`
Mówca: **Adarfo Sotelato**
> ""There is. But with the Electoral Commission fully operational, the process is far more transparent than before"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Adarfo Sotelato: ""And now, as we're nearly finished training election offi..."*)

### Węzeł `[463]`
Mówca: **Manus Sazon**
> ""Fast, yes -- but that doesn't mean rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Manus Sazon: ""Take the Electoral Commission, for example... they're no..."*)

### Węzeł `[464]`
Mówca: **Manus Sazon**
> ""Take the Electoral Commission, for example... they're now fully operational, and independent, as intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Manus Sazon: ""And the training of election officials is nearly complete.""*)

### Węzeł `[465]`
Mówca: **Daria de Rava**
> ""Fast, yes -- but not careless or rushed. We've been thorough where it matters most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Daria de Rava: ""Take the Electoral Commission -- they're fully operation..."*)

### Węzeł `[466]`
Mówca: **Manus Sazon**
> ""A valid concern. But with the Electoral Commission now fully operational, the process is more transparent than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Manus Sazon: ""Especially now that we're nearing the completion of trai..."*)

### Węzeł `[467]`
Mówca: **Adarfo Sotelato**
> ""They are. With the Electoral Commission now fully operational, and more importantly... independent, we’re almost finished with training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Adarfo Sotelato: ""The more hands we have in the field, so to speak, the be..."*)

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""Absolutely. With the Electoral Commission fully operational, we’re nearing the end of training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Manus Sazon: ""It's been a long road, but it will ensure the integrity ..."*)

### Węzeł `[469]`
Mówca: **Daria de Rava**
> "“Certainly. With the Electoral Commission now fully operational, we’re almost finished with training for election officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Daria de Rava: ""The more boots we have on the ground, so to speak, the m..."*)

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""Especially now that we're nearing the completion of training election officials, we’re in a strong position to ensure everything runs smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Manus Sazon: "“We should have enough personnel to cover all polling sta..."*)

### Węzeł `[471]`
Mówca: **Daria de Rava**
> ""With the completion of training election officials on the horizon, we're well-positioned to ensure smooth operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Daria de Rava: "“We should have enough staff for all polling stations, th..."*)

### Węzeł `[472]`
Mówca: **Adarfo Sotelato**
> ""And now, as we're nearly finished training election officials, we’re finally in a place where the people’s voices will be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Adarfo Sotelato: ""We should have enough staff to cover all polling station..."*)

### Węzeł `[473]`
Mówca: **Daria de Rava**
> ""The more boots we have on the ground, so to speak, the more we can ensure the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Daria de Rava: ""With that in mind, we should have enough personnel to co..."*)

### Węzeł `[474]`
Mówca: **Adarfo Sotelato**
> ""The more hands we have in the field, so to speak, the better we can uphold the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Adarfo Sotelato: ""With that in mind, we should have sufficient personnel t..."*)

### Węzeł `[475]`
Mówca: **Manus Sazon**
> ""It's been a long road, but it will ensure the integrity of the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Manus Sazon: ""That said, we should have enough personnel to cover all ..."*)

### Węzeł `[476]`
Mówca: **Narrator**
> "I stood on the palace balcony, watching as a flurry of monarch butterflies drifted through the air, their orange wings catching the late spring afternoon sunlight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Narrator: "They had come from as far as Rumburg, journeying thousand..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[480]`
Mówca: **Narrator**
> "They had come from as far as Rumburg, journeying thousands of miles to reach southern Xina, where they would winter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: "Rizia lay in the heart of their migration path."*)

### Węzeł `[481]`
Mówca: **Narrator**
> "Rizia lay in the heart of their migration path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Narrator: "I had seen them before, but this time, something about th..."*)

### Węzeł `[482]`
Mówca: **Narrator**
> "I had seen them before, but this time, something about their passage struck me differently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Player_Romus_Italic: "Perhaps it was the timing – this season of change, of end..."*)
  - -> `[492]` (*Player_Romus_Italic: "I couldn't help but think that I, too, had traveled a gre..."*)
  - -> `[494]` (*Player_Romus_Italic: "I thought about how the flutter of a butterfly's wings co..."*)
  - -> `[489]` (*Player_Romus_Italic: "I couldn't stop thinking about how when butterflies land ..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "I was not the man I had been when I first took the throne."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "I was not the man I had been when I first took the throne."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "How even the smallest decisions in my reign -- those made..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "A soft knock at the door drew me from my thoughts."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Perhaps it was the timing – this season of change, of endings and beginnings."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons = true;"*)

### Węzeł `[488]`
Mówca: **Narrator**
> "A soft knock at the door drew me from my thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't stop thinking about how when butterflies land on you, they’re tasting you with their feet."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste = true;"*)

### Węzeł `[490]`
Mówca: **Narrator**
> "How even the smallest decisions in my reign -- those made in quiet moments -- could set off a chain of events far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "A soft knock at the door drew me from my thoughts."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Narrator: "I stood on the palace balcony, watching as a flurry of mo..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I couldn't help but think that I, too, had traveled a great distance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled = true;"*)

### Węzeł `[493]`
Mówca: **Narrator**
> "I was not the man I had been when I first took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "A soft knock at the door drew me from my thoughts."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I thought about how the flutter of a butterfly's wings could send ripples through the air, unseen but far-reaching."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[482]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos = true;"*)

### Węzeł `[495]`
Mówca: **Narrator**
> "And my transformation would carry me far into the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[496]`
Mówca: **Narrator**
> "I was once again reminded of how the smallest of actions could result in consequences far beyond my control."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Narrator: "Yet, I remained resolute. I would see whatever came my wa..."*)

### Węzeł `[497]`
Mówca: **Narrator**
> "I was once again reminded that they taste with their feet -- how life is fully of strange, unexpected oddities."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "And no matter how strange the journey ahead might be, I w..."*)

### Węzeł `[498]`
Mówca: **Narrator**
> "Yet, I remained resolute. I would see whatever came my way through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Chaos == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Narrator: "I was once again reminded of how the smallest of actions ..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Chaos == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Chaos"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste == true"*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Taste == true)"*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Taste == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "I was once again reminded that they taste with their feet..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Taste == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Taste"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Seasons == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "I was once again reminded that, like the seasons, I too h..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Seasons == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Seasons"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[508]`
Mówca: **Narrator**
> "And no matter how strange the journey ahead might be, I would face the future head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[510]`
Mówca: **Narrator**
> "As their footsteps faded down the corridor, I turned my gaze to the window overlooking the garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "The sun had begun to set, and the silhouettes of butterfl..."*)

### Węzeł `[511]`
Mówca: **Narrator**
> "The sun had begun to set, and the silhouettes of butterflies fluttered against the fading light."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Seasons == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled == true"*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Chaos == true"*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Taste == true"*)

### Węzeł `[512]`
Mówca: **Narrator**
> "I was once again reminded of the distance I had traveled to get here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "How my journey was far from over, and I would see it thro..."*)

### Węzeł `[513]`
Mówca: **Narrator**
> "How my journey was far from over, and I would see it through to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[514]`
Mówca: **Narrator**
> "I was once again reminded that, like the seasons, I too had changed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Narrator: "And my transformation would carry me far into the future."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.NewGov_Butterfly_Traveled == true"*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.NewGov_Butterfly_Traveled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Narrator: "I was once again reminded of the distance I had traveled ..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.NewGov_Butterfly_Traveled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.NewGov_Butterfly_Traveled"] == true) == false`
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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Manus Sazon: ""Once again, boding well for the RPP.""*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""Once again, boding well for the RNC.""*)

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Manus Sazon: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Manus Sazon: ""Which bodes well for the RNC electorally.""*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Daria de Rava: ""Once again, boding well for the RPP.""*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Daria de Rava: ""Once again, boding well for the RNC.""*)

### Węzeł `[533]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Daria de Rava: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Daria de Rava: ""Which bodes well for the RNC electorally.""*)

### Węzeł `[537]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[538]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Adarfo Sotelato: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Adarfo Sotelato: ""Which bodes well for the RNC electorally.""*)

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
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Adarfo Sotelato: ""Which bodes well for the RNC electorally.""*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Adarfo Sotelato: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[548]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Adarfo Sotelato: ""Once again, boding well for the RPP.""*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Adarfo Sotelato: ""Once again, boding well for the RNC.""*)

### Węzeł `[552]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[553]`
Mówca: **Daria de Rava**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Daria de Rava: ""Once again, boding well for the RNC.""*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Daria de Rava: ""Once again, boding well for the RPP.""*)

### Węzeł `[557]`
Mówca: **Adarfo Sotelato**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[558]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Adarfo Sotelato: ""Once again, boding well for the RNC.""*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Adarfo Sotelato: ""Once again, boding well for the RPP.""*)

### Węzeł `[562]`
Mówca: **Adarfo Sotelato**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[563]`
Mówca: **Daria de Rava**
> ""Which bodes well for the RNC electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Daria de Rava: ""Which bodes well for the RNC electorally.""*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Daria de Rava: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[567]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RPP.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[568]`
Mówca: **Manus Sazon**
> ""Which bodes well for the RPP electorally.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1"*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Manus Sazon: ""Once again, boding well for the RNC.""*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_RPP_Favorability == +1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] == +1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Manus Sazon: ""Once again, boding well for the RPP.""*)

### Węzeł `[572]`
Mówca: **Manus Sazon**
> ""Once again, boding well for the RNC.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Manus Sazon: ""Which bodes well for the RPP electorally.""*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Manus Sazon: ""Which bodes well for the RNC electorally.""*)

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
  - -> `[579]` (*Manus Sazon: ""That said, a large portion of the population sees the sh..."*)

### Węzeł `[579]`
Mówca: **Manus Sazon**
> ""That said, a large portion of the population sees the shift from a monarchy to a democratic system as a positive change, offering a newfound sense of political empowerment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Manus Sazon: ""While some of the older population has shown resistance ..."*)

### Węzeł `[580]`
Mówca: **Manus Sazon**
> ""While some of the older population has shown resistance to change, the chance to vote has energized those who felt sidelined under the old regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Manus Sazon: ""As a result, much to our advantage, the electorate has b..."*)

### Węzeł `[581]`
Mówca: **Manus Sazon**
> ""As a result, much to our advantage, the electorate has become more engaged, particularly the younger citizens.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[582]`
Mówca: **Manus Sazon**
> ""Because the unification was peaceful, citizens in Pales are supporting the electoral process and have a positive view of Rizia’s governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Manus Sazon: ""Voter education efforts are being readily accepted, ensu..."*)

### Węzeł `[583]`
Mówca: **Manus Sazon**
> ""Voter education efforts are being readily accepted, ensuring a smoother transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Manus Sazon: ""The unification allowed for joint planning of electoral ..."*)

### Węzeł `[584]`
Mówca: **Manus Sazon**
> ""The unification allowed for joint planning of electoral infrastructure, so registration and voting systems were set up with more cooperation between Rizia and Pales' local leaders, reducing friction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Manus Sazon: ""Pales' own regional governance structures clash with the..."*)

### Węzeł `[585]`
Mówca: **Manus Sazon**
> ""Pales' own regional governance structures clash with the nationalized systems being implemented by Rizia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Manus Sazon: "“Aligning these systems has led to slowdowns in organizin..."*)

### Węzeł `[586]`
Mówca: **Manus Sazon**
> "“Aligning these systems has led to slowdowns in organizing the election and a lack of full cooperation from local authorities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "Jump to: [Pales_KingResponse_Hub]"*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Manus Sazon: ""Because the unification was peaceful, citizens in Pales ..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Pales_KingResponse_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
