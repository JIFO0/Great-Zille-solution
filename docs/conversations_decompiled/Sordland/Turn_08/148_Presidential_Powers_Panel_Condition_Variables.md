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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_AddCapitalPunishme..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AddCapitalPunishment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_AllowPrivatePrison..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AllowPrivatePrisons"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Default == true || BaseGame..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollE..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_BergiaSpecialZone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_AmnestyForAllSollEraPoliticalPrisoners"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_GenderEqualityInEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Default == true || BaseGame..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_GenderEqualityInEd..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_FreePrescriptionMedicine"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Default == true || BaseGame..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_DeSollinisation = ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true) && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true)  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_DeSollinisation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_DeSollinisation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_FreePrescriptionMe..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true || BaseGame.P..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_FairTradeAndCompetititonCommission"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_FairTradeAndCompet..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_SordishRadioAndTelevisionSupremeCouncil = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_SordishRadioAndTelevisionSupremeCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_SordishRadioAndTel..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_RemovePublicReligiousSymbols = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RemovePublicReligiousSymbols"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_RemovePublicReligi..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_RuralEducationInstitutes = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RuralEducationInstitutes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_RemoveIndependence..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_GunOwnershipRights..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_GunOwnershipRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_GunOwnershipRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_RemoveIndependenceOfTheCentralBank = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RemoveIndependenceOfTheCentralBank"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_RelocationOfTeache..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_LowerRetirementAge..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Decree_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Decree_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_PurgeGeneralStaff ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.Reform_Autocrat_CourtVote_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_RuralEducationInst..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_RelocationOfTeachersAndDoctorsToRuralAreas = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_RelocationOfTeachersAndDoctorsToRuralAreas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_LowerRetirementAge = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_LowerRetirementAge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true && BaseGame.R..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Default == true || BaseGame.Po..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Default == true || BaseGame...."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameUI.PresidentialPower_Condition_EnactVAT = true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Default == true || BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameUI.PresidentialPower_Condition_EnactVAT = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameUI.PresidentialPower_Condition_EnactVAT"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
