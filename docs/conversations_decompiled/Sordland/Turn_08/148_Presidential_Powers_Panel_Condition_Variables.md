# Sordland/Turn08/Presidential Powers Panel Condition Variables

- **ID konwersacji:** `148`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/148_Presidential_Powers_Panel_Condition_Variables.md`
- **Liczba węzłów dialogowych:** 71
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_Decree_Weaker`
- `BaseGame.Reform_Autocrat_CourtVote_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment`
- `BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons`
- `BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners`
- `BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone`
- `BaseGameUI.PresidentialPower_Condition_DeSollinisation`
- `BaseGameUI.PresidentialPower_Condition_EnactVAT`
- `BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission`
- `BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine`
- `BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation`
- `BaseGameUI.PresidentialPower_Condition_GunOwnershipRights`
- `BaseGameUI.PresidentialPower_Condition_LowerRetirementAge`
- `BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff`
- `BaseGameUI.PresidentialPower_Condition_RelocationOfTeachersAndDoctorsToRuralAreas`
- `BaseGameUI.PresidentialPower_Condition_RemoveIndependenceOfTheCentralBank`
- `BaseGameUI.PresidentialPower_Condition_RemovePublicReligiousSymbols`
- `BaseGameUI.PresidentialPower_Condition_RuralEducationInstitutes`
- `BaseGameUI.PresidentialPower_Condition_SordishRadioAndTelevisionSupremeCouncil`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 17

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners`
- `BaseGameUI.PresidentialPower_Condition_DeSollinisation`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment"] = true;`
- Węzeł `[10]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons"] = true;`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone"] = true;`
- Węzeł `[18]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners"] = true;`
- Węzeł `[19]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation"] = true;`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_DeSollinisation"] = true;`
- Węzeł `[31]` (Paskal Beniwoll): `Variable["BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission"] = true;`
- *...oraz 9 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_DeSollinisation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_DeSollinisation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_SordishRadioAndTelevisionSupremeCouncil = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_SordishRadioAndTelevisionSupremeCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_RemovePublicReligiousSymbols = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RemovePublicReligiousSymbols"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_RuralEducationInstitutes = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RuralEducationInstitutes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_GunOwnershipRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_GunOwnershipRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_RemoveIndependenceOfTheCentralBank = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RemoveIndependenceOfTheCentralBank"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_RelocationOfTeachersAndDoctorsToRuralAreas = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RelocationOfTeachersAndDoctorsToRuralAreas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_LowerRetirementAge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_LowerRetirementAge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameUI.PresidentialPower_Condition_EnactVAT = true)*
- **Efekt (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_EnactVAT"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
