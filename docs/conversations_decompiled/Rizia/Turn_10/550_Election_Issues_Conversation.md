# Rizia/Turn 10/Election_Issues/Election_Issues Conversation

- **ID konwersacji:** `550`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/550_Election_Issues_Conversation.md`
- **Liczba węzłów dialogowych:** 287
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Pales_DidntRatifyTreaty`
- `RiziaDLC.Pales_War`
- `RiziaDLC.RRG_NationalizedUnderAdarfo`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Rusty_Executed`
- `RiziaDLC.Rusty_Pardoned`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Happened`
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.TalkWithPM_PalesUpdate`
- `RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100`
- `RiziaDLCIsolated.TalkWithPM_ZilleUpdate`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.TalkWithPM_PalesUpdate`
- `RiziaDLCIsolated.TalkWithPM_RNC_Favorability`
- `RiziaDLCIsolated.TalkWithPM_RPP_Favorability`
- `RiziaDLCIsolated.TalkWithPM_ZilleUpdate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCIsolated.TalkWithPM_PalesUpdate`
- `RiziaDLCIsolated.TalkWithPM_ZilleUpdate`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[91]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_...`
- Węzeł `[92]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_...`
- Węzeł `[93]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_...`
- Węzeł `[141]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- Węzeł `[142]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] = true;`
- Węzeł `[143]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- Węzeł `[229]` (Paskal Beniwoll): `--;`
- Węzeł `[243]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_...`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `348` (*Rizia/Turn 10/TalkWithPrimeMinister*), Węzeł `[679]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""The ongoing war with Pales remains a top concern on voters' minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Daria de Rava**
> ""The ongoing war with Pales remains a top concern for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Though they support our troops, they are eager for the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""With the hardships many are facing at home, they just want the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Daria de Rava**
> ""With the hardships many are facing at home, they simply want the war to end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""Though they support our troops, they are eager for the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""The fallout of the war with Pales is one of the top issues on voters' minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""The fallout of the war with Pales remains a top issue for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Adarfo Sotelato**
> ""The fallout of the war with Pales is one of the most pressing issues for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""Our military's accomplishments have reinforced the RPP's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""Our military's accomplishments have reinforced the RNC's leadership and, unfortunately, strengthened their position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[47]`
Mówca: **Daria de Rava**
> ""Our military's accomplishments have reinforced the RNC's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Daria de Rava**
> ""Our military's accomplishments have reinforced the RPP's leadership and, unfortunately, bolstered their position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[52]`
Mówca: **Adarfo Sotelato**
> ""The military's accomplishments have reinforced the RPP's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Adarfo Sotelato**
> ""Our military successes have only reinforced the RNC's hold on power, and, regrettably, have solidified their standing in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""I and the RPP never fully supported the war, but the fact that it happened with us holding a majority is undermining our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
Mówca: **Adarfo Sotelato**
> ""I and the RPP never supported the war. So your military's failure to secure a victory has solidified our standing in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[68]`
Mówca: **Daria de Rava**
> ""The fact that our military failures happened with the RPP in power has strengthened our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[69]`
Mówca: **Adarfo Sotelato**
> ""I and the RPP never supported the war. But the fact that your military's failures happened with my party in power has undermined our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[267]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""I do regret our failure to win, but it has weakened public perception of the RNC and strengthened my party's position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[74]`
Mówca: **Daria de Rava**
> ""Our military's failures have weakened the RNC's hold on power and, unfortunately, undermined our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[81]`
Mówca: **Manus Sazon**
> ""Zille's return has been a rallying point for voters, reaffirming confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[88]`
Mówca: **Daria de Rava**
> ""Zille’s return has become a key rallying point for voters, restoring confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[89]`
Mówca: **Adarfo Sotelato**
> ""Zille’s return to Rizia has served as a powerful rallying point for voters, strengthening confidence and backing for the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""And to be honest, Your Majesty, the fact that you rejected our proposed ceasefire treaty has called my leadership abilities into question among some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[100]`
Mówca: **Adarfo Sotelato**
> ""But the heart of the election beats in tune with the daily lives and hardships of the working masses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""High living standards, such as access to quality healthcare and stable employment, have reinforced confidence in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""In addition, modern conveniences -- such as widespread air conditioning, personal vehicles, and increasing homeownership -- have further bolstered public support as they head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[106]`
Mówca: **Manus Sazon**
> ""Living standards remain stable, with consistent access to healthcare and steady employment providing a sense of security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Manus Sazon**
> ""At the same time, reliable transportation and stable housing have continued to support public confidence in the leadership as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""Living standards have significantly declined, with rising unemployment and limited access to healthcare leaving many feeling uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Basic needs are becoming harder to meet, and issues like unreliable transportation and inadequate housing continue to undermine public confidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""As a result, the current leadership faces growing dissatisfaction, which is expected to influence voter turnout against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""Living standards remain steady, with consistent access to healthcare and reliable employment offering security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Daria de Rava**
> ""Furthermore, modern conveniences like widespread air conditioning, personal vehicles, and rising homeownership have increased public support as voters go to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[122]`
Mówca: **Daria de Rava**
> ""Living standards have sharply declined, with rising unemployment and limited healthcare access making many feel uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""Basic needs are harder to fulfill, and issues like unreliable transportation and poor housing continue to erode public trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Daria de Rava**
> ""As a result, dissatisfaction with the current leadership is growing, which will likely influence voter turnout against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""Furthermore, dependable transportation and stable housing continue to reinforce public confidence in the leadership as voters cast their ballots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""High living standards, including access to quality healthcare and stable employment, have strengthened confidence in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[127]`
Mówca: **Adarfo Sotelato**
> ""While the standard of living has improved for many, the working class continues to benefit most from access to essentials like healthcare, stable employment, and reliable public services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Adarfo Sotelato**
> ""Nevertheless, reliable transportation and stable housing have continued to support public confidence in us as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""Living standards have significantly declined, with rising unemployment and limited access to healthcare leaving many feeling uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Adarfo Sotelato**
> ""Most of this is fallout from your governance, King Romus. Our voters are counting on us to turn this around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[137]`
Mówca: **Adarfo Sotelato**
> ""Furthermore, modern conveniences such as widespread air conditioning, personal vehicles, and increasing homeownership have helped bolster public support as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[138]`
Mówca: **Adarfo Sotelato**
> ""Living standards have stabilized for most, thanks to access to essentials like healthcare and secure jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Adarfo Sotelato**
> ""As a result, this has fostered confidence in our ability to maintain order and stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[140]`
Mówca: **Adarfo Sotelato**
> ""Though disparities do remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""Zille's return has also been a rallying point for voters, reaffirming confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""Zille’s return has also become a key rallying point for voters, restoring confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[155]`
Mówca: **Adarfo Sotelato**
> ""Zille’s return to Rizia has also served as a powerful rallying point for voters, strengthening confidence and backing for the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""Losing Zille has become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

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
  - -> `[169]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
Mówca: **Daria de Rava**
> ""The loss of Zille has become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[164]`
Mówca: **Adarfo Sotelato**
> ""Losing Zille has become a rallying point for voters, whose growing anger and frustrations with the current leadership drive their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[168]`
Mówca: **Adarfo Sotelato**
> ""Losing Zille has also become a rallying point for voters, whose growing anger and frustrations with the current leadership drive their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""Losing Zille has also become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[176]`
Mówca: **Daria de Rava**
> ""The loss of Zille has also become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Rusty_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Rusty_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[183]`
Mówca: **Manus Sazon**
> ""In addition, there has been significant public support for our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[184]`
Mówca: **Manus Sazon**
> ""I know what Rusty's pardon and the reversal of RRG's nationalization looked like on paper. But his efforts will result in a flood of new jobs for our industries, not to mention profits that will be redirected to the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[186]`
  - -> `[185]`
  - -> `[187]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s hope it doesn’t end up costing us more than it’s worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty Montoro... a man of the people, now? How charming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Public support is fleeting. You shouldn't base policy on every passing whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it serves the people, then perhaps it’s a step in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[189]`
Mówca: **Manus Sazon**
> ""It's the price of a free society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[190]`
Mówca: **Manus Sazon**
> ""Sometimes the cost of doing nothing is far greater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[191]`
Mówca: **Manus Sazon**
> ""I don't know if 'charming' is the word I'd use... but he's what we need right now. We can’t ignore the fact that his actions have resonated with the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[192]`
Mówca: **Manus Sazon**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Pardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Pardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Pardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Pardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Pardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""Thanks to the efforts of Treasury Secretary Rusty Montoro, the industry now benefits the everyday Rizian, not just the privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[186]`
  - -> `[185]`
  - -> `[187]`

### Węzeł `[197]`
Mówca: **Adarfo Sotelato**
> ""In addition, there has been significant public support for the decision to nationalize the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[198]`
Mówca: **Adarfo Sotelato**
> ""As a result of my party's actions, the industry now works for the prosperity of the nation, ensuring its wealth benefits not just the privileged few, but the everyday Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[204]`
  - -> `[286]`
  - -> `[206]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Adarfo Sotelato**
> ""Yes, it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[203]`
Mówca: **Adarfo Sotelato**
> ""The most for himself, you mean. RRG's profits might shrink in the short term, but we'll reap the long-term rewards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s hope this wealth doesn’t end up locked away in another set of hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Adarfo Sotelato**
> ""Believe me, this wealth will reach the hands that truly need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wonderful! I assume every Rizian will get a gold bar delivered to their door?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Adarfo Sotelato**
> ""If only it were that simple. What we’re doing is ensuring a fairer distribution of resources, not childish fantasies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[208]`
Mówca: **Manus Sazon**
> ""There has been significant public support for our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Adarfo Sotelato**
> ""There has been significant public support for the decision to nationalize the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""At its core, the election is shaped by household realities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""At its core, the election is influenced by the realities of daily life within households.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""The heart of the election beats in tune with the daily lives and hardships of the working masses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""As you can see, the issues facing us are as diverse and unpredictable as Rizia itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Daria de Rava**
> ""Clearly, the concerns driving voters are as varied and complex as the regions they come from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Adarfo Sotelato**
> ""As you can see, the issues influencing the election are as dynamic and diverse as Rizia's people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll see how long their concerns last after the ballots are tallied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[230]`
  - -> `[228]`
  - -> `[231]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. But such unpredictability can also breed opportunity. Opportunity for those willing to seize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Public opinion is volatile, but leadership requires steady hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the challenges, this election will serve as a reminder of the power of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[236]`
Mówca: **Narrator**
> "He paused with a look of consternation on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""I still don't understand, Your Majesty. We had a chance to stop the casualties and bring Vina home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`
  - -> `[240]`
  - -> `[253]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll bring her home on our terms. Not the Duke's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think the Palesians would have kept those promises, you're even more gullible than I thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The life of a princess is no more valuable than the lives that will be lost if we let Pales continue their campaign of aggression against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't second-guess every decision I make. If I did, I wouldn't be King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""I suppose you're right..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[244]`
Mówca: **Daria de Rava**
> ""And to be frank, the fact that you rejected our proposed ceasefire treaty brought my leadership abilities into question among our voter base.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were making a mistake. The Duke would never have kept his promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[248]`
  - -> `[252]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you override me if you thought I was making the wrong call? You had the power to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is exactly why I gave myself veto power. I'll take the fall for the continuation of the war, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll come around once we achieve our victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had the power to override me. Why didn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""A major disagreement between the monarch and the Prime Minister so soon after our reforms? It would have been an even bigger mess than the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""You are still head of state, Your Majesty. I would never let the treaty go ahead without your approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Manus Sazon**
> ""Yes, maybe you're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[266]`
Mówca: **Daria de Rava**
> ""Perhaps you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_DidntRatifyTreaty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_DidntRatifyTreaty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_DidntRatifyTreaty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[270]`
Mówca: **Adarfo Sotelato**
> ""As has the fact that we had to sign the peace treaty without the King's blessing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_DidntRatifyTreaty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_DidntRatifyTreaty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_DidntRatifyTreaty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[274]`
Mówca: **Adarfo Sotelato**
> ""But the fact that we went ahead with the peace treaty without your approval did rankle traditionalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.TalkWithPM_RNC_Favorability = 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.RRG_NationalizedUnderAdarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.RRG_NationalizedUnderAdarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.RRG_NationalizedUnderAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.RRG_NationalizedUnderAdarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.RRG_NationalizedUnderAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Adarfo Sotelato**
> ""Your actions went a long way towards ensuring the industry's wealth benefits not just the privileged few, but the everyday Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[284]`
  - -> `[206]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're welcome. Should you be elected, I expect the redistribution of Rizia's wealth to continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Oh, it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was a terrible idea. Rusty knew how to make the most of Rizia's resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
