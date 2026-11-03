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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 32

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `--;`
- Węzeł `[10]` (Paskal Beniwoll): `-- HUGO WANTS VINA TO SUCCEED;`
- Węzeł `[11]` (Paskal Beniwoll): `-- HUGO WANTS YOUR SON TO SUCCEED;`
- Węzeł `[15]` (Paskal Beniwoll): `-- HUGO DOESNT CARE ABOUT SUCCESSION;`
- Węzeł `[22]` (Paskal Beniwoll): `-- HUGO AGAINST;`
- Węzeł `[32]` (Paskal Beniwoll): `-- HUGO AGAINST;`
- Węzeł `[36]` (Paskal Beniwoll): `-- AZAROS SUPPORT;`
- Węzeł `[40]` (Paskal Beniwoll): `-- NEEDS PROMISE OF YOUR SON'S SUCCESSION;`
- *...oraz 24 innych węzłów ze skryptami.*

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
  - -> `[103]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `551` (*Rizia/Turn 10/REFORM TALKS/REFORM TALKS Conversation*), Węzeł `[1289]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true || (RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO WANTS VINA TO SUCCEED)*
- **Efekt (`userScript`):** `-- HUGO WANTS VINA TO SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO WANTS YOUR SON TO SUCCEED)*
- **Efekt (`userScript`):** `-- HUGO WANTS YOUR SON TO SUCCEED;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Vina_MarriageDecision_Rico == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO DOESNT CARE ABOUT SUCCESSION)*
- **Efekt (`userScript`):** `-- HUGO DOESNT CARE ABOUT SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO AGAINST)*
- **Efekt (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseToras >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseToras >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_ValenqirisLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Valenqiris"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO AGAINST)*
- **Efekt (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  and  (Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true && (RiziaDLC.Vina_MarriageDecision_Rico == true || RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_MarriageDecision_Axel == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  and  (Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AZAROS SUPPORT)*
- **Efekt (`userScript`):** `-- AZAROS SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  (Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true  or  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true && (RiziaDLC.Reform_UpperHouse_Equal == true || RiziaDLC.Reform_UpperHouse_Limited == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  (Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true  or  Variable["RiziaDLC.Reform_UpperHouse_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NEEDS PROMISE OF YOUR SON'S SUCCESSION)*
- **Efekt (`userScript`):** `-- NEEDS PROMISE OF YOUR SON'S SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // TADDEUS AGAINST)*
- **Efekt (`userScript`):** `-- TADDEUS AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO AGAINST)*
- **Efekt (`userScript`):** `-- HUGO AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AGAINST)*
- **Efekt (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseAzaro >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseAzaro >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AZAROS SUPPORT)*
- **Efekt (`userScript`):** `-- AZAROS SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SUPPORT)*
- **Efekt (`userScript`):** `-- SUPPORT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // MANUS SUPPORTS)*
- **Efekt (`userScript`):** `-- MANUS SUPPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AGAINST)*
- **Efekt (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NEED PROMISE OF VINA SUCCESSION)*
- **Efekt (`userScript`):** `-- NEED PROMISE OF VINA SUCCESSION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  or  Variable["RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false || RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  or  Variable["RiziaDLC.Situation_Law_ProvincialTax_BrenasLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Legislative_HouseOfLords == true && RiziaDLC.Reform_UpperHouse_Equal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  and  Variable["RiziaDLC.Reform_UpperHouse_Equal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Monarch_Veto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Monarch_Veto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false && (RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered == true || RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false  and  (Variable["RiziaDLC.Situation_Law_ProvincialTax_CardesseMontaklarLowered"] == true  or  Variable["RiziaDLC.Decision_Turn03_TaxSubsidyOne_CardesseMontaklar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AGAINST)*
- **Efekt (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Adarfo == true && RiziaDLC.Azaro_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Son = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_DemandsSuccessionPromise_Son"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Toras_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccessionPromise_Son = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_DemandsSuccessionPromise_Son"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Azaro_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccessionPromise_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_DemandsSuccessionPromise_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.BirthdayGathering_ReformMovement_Present"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == false && RiziaDLC.BirthdayGathering_ReformMovement_Present == true && RiziaDLC.BirthdayGathering_Invited_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false  and  Variable["RiziaDLC.BirthdayGathering_ReformMovement_Present"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_UpperHouse_Advisory == false && (RiziaDLC.Reform_Legislative_HouseOfLords == true || RiziaDLC.Reform_Legislative_RegionalSenate == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_UpperHouse_Advisory"] == false  and  (Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true  or  Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Birthday_ReformTalk_Sazon_Supports"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // OPEN)*
- **Efekt (`userScript`):** `-- OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_Brenas == true && RiziaDLC.Reform_Regions_Centralized == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true  and  Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SUPPORTS)*
- **Efekt (`userScript`):** `-- SUPPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // HUGO DESPERATE AND WILLING TO BE OK WITH ADARFO)*
- **Efekt (`userScript`):** `-- HUGO DESPERATE AND WILLING TO BE OK WITH ADARFO;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // AGAINST)*
- **Efekt (`userScript`):** `-- AGAINST;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
