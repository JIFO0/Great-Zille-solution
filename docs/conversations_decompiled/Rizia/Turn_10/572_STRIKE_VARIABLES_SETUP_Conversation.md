# Rizia/Turn 10/STRIKE VARIABLES SETUP/STRIKE VARIABLES SETUP Conversation

- **ID konwersacji:** `572`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/572_STRIKE_VARIABLES_SETUP_Conversation.md`
- **Liczba węzłów dialogowych:** 109
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.Azaro_HasPowerToCoup`
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies`
- `RiziaDLC.Policy_RD_Order_PledgeOfAllegiance`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_AuthorityModifiersTotal`
- `RiziaDLC.Rusty_Arrested`
- `RiziaDLC.Rusty_Fled`
- `RiziaDLC.Rusty_Hostile`
- `RiziaDLC.Sazon_HasPowerToCoup`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Titus_Suspicion`
- `RiziaDLC.Toras_HasPowerToCoup`
- `RiziaDLC.Trait_RebelKing`
- `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan`
- `RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan`
- `RiziaDLC.War_Happened`
- `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BirthdayGathering_TitusBetrays`
- `RiziaDLC.BirthdayGathering_ViolentAction_Success`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Titus_Suspicion`
- `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[571] Rizia/Turn 10/CHARACTER SETUP/CHARACTER SETUP Conversation** (../Turn_10/571_CHARACTER_SETUP_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 31

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Titus`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] = true;`
- Węzeł `[25]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- Węzeł `[26]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- Węzeł `[29]` (Paskal Beniwoll): `-- Titus Relations Final Update;`
- Węzeł `[30]` (Paskal Beniwoll): `--;`
- Węzeł `[31]` (Paskal Beniwoll): `--;`
- *...oraz 23 innych węzłów ze skryptami.*

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
  - -> `[46]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `571` (*Rizia/Turn 10/CHARACTER SETUP/CHARACTER SETUP Conversation*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_TitusBetrays = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Relations_Titus"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Relations_Titus"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))  and  Variable["RiziaDLC.Titus_Suspicion"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))  and  Variable["RiziaDLC.Titus_Suspicion"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Council_Security_Titus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Council_Security_Titus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 1  or  Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 1  or  Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_RebelKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_RebelKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_RebelKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_RebelKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Titus Relations Final Update)*
- **Efekt (`userScript`):** `-- Titus Relations Final Update;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Success = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // STRIKE FAILS)*
- **Efekt (`userScript`):** `-- STRIKE FAILS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true))))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Suspicion += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Titus_Suspicion"] = Variable["RiziaDLC.Titus_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NO STRIKES WILL HAPPEN IN SCENE)*
- **Efekt (`userScript`):** `-- NO STRIKES WILL HAPPEN IN SCENE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // STRIKE PLANNED)*
- **Efekt (`userScript`):** `-- STRIKE PLANNED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true)  and  (Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true)  and  (Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.Sazon_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.Sazon_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HOUSE STRIKE SUCCESS CALCULATION)*
- **Efekt (`userScript`):** `-- HOUSE STRIKE SUCCESS CALCULATION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // CHECK IF STRIKE WILL SUCCEED)*
- **Efekt (`userScript`):** `-- CHECK IF STRIKE WILL SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  and  Variable["RiziaDLC.Policy_RD_Order_PledgeOfAllegiance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  and  Variable["RiziaDLC.Policy_RD_Order_PledgeOfAllegiance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // STRIKE FAILS)*
- **Efekt (`userScript`):** `-- STRIKE FAILS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true  or  Variable["RiziaDLC.Council_Security_Lucita"] == true)  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.War_Happened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Council_Security_Taddeus"] == true  or  Variable["RiziaDLC.Council_Security_Lucita"] == true)  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.War_Happened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Success = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
