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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (Ri..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenG..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_TitusBetrays = true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_TitusBetrays = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Relations_Titus"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_TitusBetrays = true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Relations_Titus <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Relations_Titus"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Refo..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Refo..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Re..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))  and  Variable["RiziaDLC.Titus_Suspicion"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_TitusBetrays = true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Adarfo_AbdicationPath == true || (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true) || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)) && RiziaDLC.Titus_Suspicion >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true)  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))  and  Variable["RiziaDLC.Titus_Suspicion"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Secu..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Se..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Council_Security_Titus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 2"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Security_Titus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  and  Variable["RiziaDLC.Council_Security_Titus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_A..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_A..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] <= 1  or  Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_AuthorityModifiersTotal <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] <= 1  or  Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_RebelKing == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_RebelKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_RebelKing == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_RebelKing == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_RebelKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_RebelKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 2"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_RebelKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 2"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Secu..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true && RiziaDLC.Council_Secu..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority <= 1 || RiziaDLC.Resources_A..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_RebelKing == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Titus Relations Final Update`
- **Efekt skryptowy (`userScript`):** `-- Titus Relations Final Update;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true || Rizia..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true || Rizia..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true || Riz..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "// STRIKE PLANNED"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "// NO STRIKES WILL HAPPEN IN SCENE"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_Securit..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success = true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true || RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "// STRIKE FAILS"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPM..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success = true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "// HOUSE STRIKE SUCCESS CALCULATION"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE FAILS`
- **Efekt skryptowy (`userScript`):** `-- STRIKE FAILS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (Ri..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true))`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Suspicion += 1"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true && (RiziaDLC.Reform_Path == true && (RiziaDLC.BirthdayGathering_ViolentAction == true || RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB == true)))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true  and  (Variable["RiziaDLC.Reform_Path"] == true  and  (Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true  or  Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "// Titus Relations Final Update"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Suspicion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Titus_Suspicion"] = Variable["RiziaDLC.Titus_Suspicion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "// Titus Relations Final Update"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO STRIKES WILL HAPPEN IN SCENE`
- **Efekt skryptowy (`userScript`):** `-- NO STRIKES WILL HAPPEN IN SCENE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE PLANNED`
- **Efekt skryptowy (`userScript`):** `-- STRIKE PLANNED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialF..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Specia..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true)  and  (Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true || RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan == true) && (RiziaDLC.Azaro_HasPowerToCoup == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true  or  Variable["RiziaDLC.Turn09_TalkWithTitus_InformLucitaOfPlan"] == true)  and  (Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true &&..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenG..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true && RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true  and  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialF..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true &&..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan == true && RiziaDLC.Toras_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_TalkWithTitus_InformHugoOfPlan"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Toras_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Toras_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.Azaro_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.Sazon_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.Sazon_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.Sazon_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == ..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HOUSE STRIKE SUCCESS CALCULATION`
- **Efekt skryptowy (`userScript`):** `-- HOUSE STRIKE SUCCESS CALCULATION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "// CHECK IF STRIKE WILL SUCCEED"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Birthday_Gathering_ViolentAction_House..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success = true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "// STRIKE FAILS"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPM..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true && RiziaDLC.Adarfo_AssassinationOrdered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true  and  Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// CHECK IF STRIKE WILL SUCCEED`
- **Efekt skryptowy (`userScript`):** `-- CHECK IF STRIKE WILL SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  and  Variable["RiziaDLC.Policy_RD_Order_PledgeOfAllegiance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true && RiziaDLC.Policy_RD_Order_PledgeOfAllegiance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  and  Variable["RiziaDLC.Policy_RD_Order_PledgeOfAllegiance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_IncreaseProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Co..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// STRIKE FAILS`
- **Efekt skryptowy (`userScript`):** `-- STRIKE FAILS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Co..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Co..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Council_Security_Taddeus == true || RiziaDLC...."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true  or  Variable["RiziaDLC.Council_Security_Lucita"] == true)  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.War_Happened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Council_Security_Taddeus == true || RiziaDLC.Council_Security_Lucita == true) && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.War_Happened == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Council_Security_Taddeus"] == true  or  Variable["RiziaDLC.Council_Security_Lucita"] == true)  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.War_Happened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == ..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled =..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseSt..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Hostile == true && RiziaDLC.Rusty_Fled == false && RiziaDLC.Rusty_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true  and  Variable["RiziaDLC.Rusty_Fled"] == false  and  Variable["RiziaDLC.Rusty_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "// CHECK IF STRIKE WILL SUCCEED"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] = Variable["RiziaDLCIsolated.Birthday_Gathering_ViolentAction_HouseStrike_SuccessChance"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "// CHECK IF STRIKE WILL SUCCEED"*)
