# Rizia/Turn 10/Upper_House_Branch/Upper_House_Branch Conversation

- **ID konwersacji:** `548`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/548_Upper_House_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 86
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 0

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
  - -> `[15]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `348` (*Rizia/Turn 10/TalkWithPrimeMinister*), Węzeł `[679]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""The House of Lords will begin its duties after the elections, ensuring a smooth transition as they take on their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Manus Sazon**
> ""The political appointments are in the final stages, with noble families, scholars, and former statesmen being selected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Given that they will hold equal authority in shaping laws once they assume their roles, we are prepared for potential delays and complications due to a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Until the new legislative building is finished, they’ll convene in the Grand Hall of Palas Rezna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Manus Sazon**
> ""With their limited power, we shouldn't expect too many hurdles when passing new legislation once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Given their largely symbolic role, we don’t expect much interference in the legislative process once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[21]`
Mówca: **Daria de Rava**
> ""The House of Lords will commence its duties after the elections, ensuring a seamless transition as they assume their responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Daria de Rava**
> ""The political appointments are nearly finalized, with selections from the greater and lesser noble houses, scholars, and former statesmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
Mówca: **Daria de Rava**
> ""Given their equal power in shaping laws once they assume their roles, we are prepared for potential delays and complications from a lengthy negotiation process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Daria de Rava**
> ""Until the new legislative building is complete, they’ll convene in the Grand Hall of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""With their limited power, we shouldn't face many obstacles when passing new legislation once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""Given their primarily symbolic and advisory role, we don’t anticipate much interference in the legislative process once they assume their roles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""The formation of the Regional Senate is well underway, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""I must admit, I’m rather pleased with how Rizia has held on to its traditions -- particularly with the nobility’s continued role in the legislative process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Daria de Rava**
> ""Even in a limited capacity, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""Even if it's more of a ceremonial capacity, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[49]`
Mówca: **Daria de Rava**
> ""Through them, the essence of the king's court endures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[50]`
Mówca: **Manus Sazon**
> ""And on a personal note, I must say, I am pleased to see such a strong push for regional representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""This is a key step in giving all provinces not only a voice, but a stake in the kingdom's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""The creation of the Regional Senate is progressing steadily, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Manus Sazon**
> ""On a personal note, I'm pleased to see the House of Lords reflect the Crown's ability to adapt while preserving its core values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""I must admit, I’m pleased to see such strides toward broader representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Daria de Rava**
> ""Though for now, those with the wealth to campaign do tend to come from noble backgrounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[62]`
Mówca: **Adarfo Sotelato**
> ""With their rightful place as equals in the legislative process, we must brace for prolonged negotiations -- but that’s the cost of genuine democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is complete, they’ll convene in the Grand Hall of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Adarfo Sotelato**
> ""But with their hands tied from the start, the Senate will struggle to have any influence on the Delegates' decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""But with no real authority, they'll just sit there -- voices drowned out by those who actually hold power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Adarfo Sotelato**
> ""The creation of the Regional Senate is progressing steadily, with candidates actively campaigning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[73]`
Mówca: **Adarfo Sotelato**
> ""Frankly, they'd save everyone time by skipping the elections altogether and appointing actors to read from a script.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Adarfo Sotelato**
> ""At least then they wouldn't have to pretend this is anything more than a farce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Adarfo Sotelato**
> ""Until the new legislative building is complete. the Grand Hall of Palas Rezna will serve as their stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Manus Sazon**
> ""So is my mother, who's all but assured to be elected as a representative of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[80]`
Mówca: **Manus Sazon**
> ""So is Leona, who's all but assured to be elected as a representative of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""So is my mother, who's all but assured to be elected as a representative of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""So is Leona, who's all but assured to be elected as a representative of House Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
