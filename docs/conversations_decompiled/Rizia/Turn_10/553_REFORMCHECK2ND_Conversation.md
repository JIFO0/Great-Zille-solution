# Rizia/Turn 10/REFORM TALKS/REFORMCHECK2ND/REFORMCHECK2ND Conversation

- **ID konwersacji:** `553`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/553_REFORMCHECK2ND_Conversation.md`
- **Liczba węzłów dialogowych:** 131
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Azaro_HasPowerToCoup`
- `RiziaDLC.BirthdayGathering_Invited_Adarfo`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_ReformMovement_Present`
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas`
- `RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar`
- `RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Legislative_RegionalSenate`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_UpperHouse_Advisory`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered`
- `RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered`
- `RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.ZilleOwnership_Brenas`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccessionPromise_Son`
- `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports`
- `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccessionPromise_Vina`
- `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports`
- `RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Son`
- `RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Vina`
- `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[551] Rizia/Turn 10/REFORM TALKS/REFORM TALKS Conversation** (../Turn_10/551_REFORM_TALKS_Conversation.md), Węzeł `[1289]`

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
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC...."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1289]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Refor..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.B..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.B..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "// HUGO WANTS VINA TO SUCCEED"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_Marriage..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO WANTS VINA TO SUCCEED`
- **Efekt skryptowy (`userScript`):** `-- HUGO WANTS VINA TO SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccess..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO WANTS YOUR SON TO SUCCEED`
- **Efekt skryptowy (`userScript`):** `-- HUGO WANTS YOUR SON TO SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccess..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_Marriage..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_Marria..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "// HUGO WANTS YOUR SON TO SUCCEED"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "// HUGO DOESNT CARE ABOUT SUCCESSION"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO DOESNT CARE ABOUT SUCCESSION`
- **Efekt skryptowy (`userScript`):** `-- HUGO DOESNT CARE ABOUT SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports = true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true && Riz..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 10"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true )"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "// HUGO AGAINST"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO AGAINST`
- **Efekt skryptowy (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 10"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras >= 10)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "// HUGO AGAINST"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC...."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == false && RiziaDL..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 10"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "// HUGO AGAINST"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaD..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras >= 10"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC...."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO AGAINST`
- **Efekt skryptowy (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_Ma..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  and  (Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "// NEEDS PROMISE OF YOUR SON'S SUCCESSION"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  and  (Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AZAROS SUPPORT`
- **Efekt skryptowy (`userScript`):** `-- AZAROS SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && (Rizi..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true && (Ri..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  (Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true  or  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "// AZAROS SUPPORT"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  (Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true  or  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_Ma..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NEEDS PROMISE OF YOUR SON'S SUCCESSION`
- **Efekt skryptowy (`userScript`):** `-- NEEDS PROMISE OF YOUR SON'S SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccess..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true && Riz..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// TADDEUS AGAINST`
- **Efekt skryptowy (`userScript`):** `-- TADDEUS AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO AGAINST`
- **Efekt skryptowy (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && (Rizi..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == fals..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro >= 10"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaD..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AGAINST`
- **Efekt skryptowy (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro >= 10"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro >= 10)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "// AZAROS SUPPORT"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regio..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Reg..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "// TADDEUS AGAINST"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true && Rizi..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AZAROS SUPPORT`
- **Efekt skryptowy (`userScript`):** `-- AZAROS SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "// MANUS SUPPORTS"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SUPPORT`
- **Efekt skryptowy (`userScript`):** `-- SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// MANUS SUPPORTS`
- **Efekt skryptowy (`userScript`):** `-- MANUS SUPPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AGAINST`
- **Efekt skryptowy (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon >= 5"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon >= 5)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "// SUPPORT"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NEED PROMISE OF VINA SUCCESSION`
- **Efekt skryptowy (`userScript`):** `-- NEED PROMISE OF VINA SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccess..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == fals..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  or  Variable["RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon >= 5"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  or  Variable["RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true && Riz..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "// AZAROS SUPPORT"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == fals..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "// AZAROS SUPPORT"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AGAINST`
- **Efekt skryptowy (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "// AZAROS SUPPORT"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Adarfo == true && Rizi..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true && Ri..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "// TADDEUS AGAINST"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Son = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Son"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccessionPromise_Son = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccessionPromise_Son"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccessionPromise_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccessionPromise_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC...."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == false && RiziaDL..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.BirthdayGathering_ReformMovement_Present"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "// HUGO DESPERATE AND WILLING TO BE OK WITH ADARFO"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.BirthdayGathering_ReformMovement_Present"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaD..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "// NEED PROMISE OF VINA SUCCESSION"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon >= 5"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// OPEN`
- **Efekt skryptowy (`userScript`):** `-- OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Refo..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "// SUPPORTS"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == false )"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "// SUPPORTS"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SUPPORTS`
- **Efekt skryptowy (`userScript`):** `-- SUPPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HUGO DESPERATE AND WILLING TO BE OK WITH ADARFO`
- **Efekt skryptowy (`userScript`):** `-- HUGO DESPERATE AND WILLING TO BE OK WITH ADARFO;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.B..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == false"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == false)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true && Rizia..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// AGAINST`
- **Efekt skryptowy (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon >= 5"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon >= 5)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "// OPEN"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "// AGAINST"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regio..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
