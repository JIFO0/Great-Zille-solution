# Rizia/Turn 8/WIP_Lunch Break

- **ID konwersacji:** `405`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/405_WIP_Lunch_Break.md`
- **Liczba węzłów dialogowych:** 193
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[84]** Deivid Wisci (R)
- **[95]** Player_Romus *(Gracz)*
- **[96]** Anton Rayne (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.Decision_Turn08_ExtendEmergency_DontExtend`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn09_EnT_GDPMaintained`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `RiziaDLC.CountryRelation_Rumburg_Allied`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.CountryRelation_Sordland_Allied`
- `RiziaDLC.CountryRelation_Sordland_Friendly`
- `RiziaDLC.CountryRelation_Sordland_Hostile`
- `RiziaDLC.CountryRelation_Sordland_Neutral`
- `RiziaDLC.CountryRelation_Sordland_Unfriendly`
- `RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought`
- `RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite`
- `RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent`
- `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy`
- `RiziaDLC.Situation_Diplomacy_ANSanctions_Weak`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Sordland_RiziaSanction_Aye`
- `RiziaDLC.Sordland_ZilleReferendum_Aye`
- `RiziaDLC.Turn04_SordlandBond_LargeInvestment`
- `RiziaDLC.Turn04_SordlandBond_SmallInvestment`
- `RiziaDLC.ZilleReferendum_StoppedByAN`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 123
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[16]` (Paskal Beniwoll): `End();`

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
  - -> `[7]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !())*
- **Warunek (`conditionsString`):** `false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Węzeł pośredni / warunkowy)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[7]`
Mówca: **Narrator**
> "We made our way to the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[8]`
Mówca: **Anton Rayne (R)**
*(Węzeł logiki narracyjnej: Anton Rayne (R): "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Deivid Wisci (R)**
> ""King Romus, what an honor to meet you. I'm Deivid Wisci, Foreign Minister of Sordland. Allow me to introduce President Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[10]`
Mówca: **Laurento Esquibel**
*(Węzeł logiki narracyjnej: Laurento Esquibel: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
*(Węzeł logiki narracyjnej: Player_Romus: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
*(Węzeł logiki narracyjnej: Player_Romus_Italic: "...")*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Allied"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Rumburg_Allied == true || RiziaDLC.Policy_Diplomacy_GRACEMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Allied"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_SordlandBond_LargeInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_SordlandBond_LargeInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn04_SordlandBond_LargeInvestment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn04_SordlandBond_LargeInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn04_SordlandBond_LargeInvestment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_SordlandBond_SmallInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn04_SordlandBond_SmallInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn04_SordlandBond_SmallInvestment"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn04_SordlandBond_SmallInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn04_SordlandBond_SmallInvestment"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_GasomOffer_LargeMinorityStakeBought"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_GasomOffer_SmallMinorityStakeBought"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_BringJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_Extradite"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn05_SordishTouristIssue_StaySilent"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_DemocraticRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_DontExtend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_DontExtend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_DontExtend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_GDPMaintained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_GDPMaintained == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_GDPMaintained"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_GDPMaintained == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_GDPMaintained"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_ATO"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Heavy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Weak"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_ANSanctions_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_ANSanctions_Weak"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_CSP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_CSP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Neutral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Neutral == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Neutral"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Neutral == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Neutral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Hostile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Hostile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Hostile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sordland_RiziaSanction_Aye == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sordland_RiziaSanction_Aye == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sordland_RiziaSanction_Aye"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sordland_RiziaSanction_Aye == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sordland_RiziaSanction_Aye"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sordland_ZilleReferendum_Aye == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Sordland_ZilleReferendum_Aye == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Sordland_ZilleReferendum_Aye"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Sordland_ZilleReferendum_Aye == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Sordland_ZilleReferendum_Aye"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_StoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[146]`
Mówca: **Narrator**
> "As Laurento and I were debating the merits of the pasta selection, a gentleman with a kindly demeanor approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[147]`
Mówca: **Deivid Wisci (R)**
> ""A splendid idea, Laurento. Let's find a spot where we can talk more comfortably.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Minister Wisci, President Rayne, it's an honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pleasure to meet you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Anton Rayne (R)**
> ""Your Majesty, it's a pleasure. And Minister Wisci is too kind – the honor is mine. It's good to meet new faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[151]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Rayne, Minister Wisci, welcome. Let's hope our chat is more satisfying than the lunch selection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Laurento Esquibel**
> ""Minister Wisci, President Rayne, shall we take a seat? It might be more conducive for our discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[153]`
Mówca: **Laurento Esquibel**
> ""Very glad we ran into each other. Always good to see you Deivid and Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[154]`
Mówca: **Narrator**
> "We moved towards a quieter section of the room, finding a round table that seemed perfect for a more intimate dialogue. We sat down and arranged our plates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Anton Rayne (R)**
> ""It seems we're all victims of the culinary experiments at this year's conference. I hope the AN general assembly coming up soon will have a better offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`
  - -> `[158]`
  - -> `[159]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One can only hope, President Rayne. The stakes at the general assembly are certainly higher than our lunch choices here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, President Rayne. If the general assembly is as varied and unpredictable as this buffet, we're in for an interesting time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They might need some Rizian chefs here, or maybe Sordish ones. Our cuisines do have a reputation for excellence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had much more important things than some food talk I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Anton Rayne (R)**
> ""Direct and to the point, Your Majesty. I appreciate that.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
Mówca: **Narrator**
> "We moved towards a quieter section of the room, finding a round table that seemed perfect for a more intimate dialogue. As we sat down, arranging our plates, President Rayne casually addressed the group, lightening the mood."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Anton Rayne (R)**
> ""Don't forget the delights of Sordish cuisine, Your Majesty. Have you ever tried Svabli? It's a Holsord specialty - sheep cheese like you've never tasted it before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[163]`
Mówca: **Anton Rayne (R)**
> ""Absolutely, King Romus. Yet, sometimes, these small talks can be a prelude to greater discussions. Like our Zabla back in Bergia, simple on the surface but complex beneath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`
  - -> `[173]`

### Węzeł `[164]`
Mówca: **Anton Rayne (R)**
> ""An interesting analogy. Much like our traditional Sordish stew, I suppose. Simple ingredients coming together to create something substantial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Svabli, you say? I must admit, my experience with Sordish cuisine is limited, but I'm always open to new culinary adventures.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Svabli... I've heard of it but never had the pleasure. It seems our diplomatic meetings could benefit from a taste of Sordland's finest.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't tried Svabli yet, President Rayne. But it's always fascinating to talk to a food afficionado.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Traditional Sordish stew? I like the blend of various elements, each adding its own unique flavor.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your stew analogy is quite fitting. It's about harmony among different ingredients.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like the sound of that stew – it's a reminder that something greater than the sum of its parts can emerge from simple beginnings.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is Zabla made of? I'm curious.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zabla's simplicity yet underlying complexity is intriguing. It's a bit like our Rizetta, a breakfast dish that seems simple but offers a depth of flavors.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Zabla analogy is thought-provoking. Never knew you cared so much about dishes, isn't Lespia the big culinary nation in East Merkopa?""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[176]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[178]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Anton Rayne (R)**
> "".""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
Mówca: **Anton Rayne (R)**
> ""Oh it is super tasty, much better than the pasta we are having here today.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Anton Rayne (R)**
> ""I will see to it that you do next time you visit.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
Mówca: **Anton Rayne (R)**
> ""Food reflects a nation's culture – robust and full of character, much like Sordland itself.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
Mówca: **Laurento Esquibel**
> ""I think we can gather for culinary debates at another occassion, timing and proportion are critical. It's not just what we bring to the table, but how and when we present it.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
