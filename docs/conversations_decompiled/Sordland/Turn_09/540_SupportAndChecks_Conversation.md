# Sordland/Turn09/SupportAndChecks/SupportAndChecks Conversation

- **ID konwersacji:** `540`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/540_SupportAndChecks_Conversation.md`
- **Liczba węzłów dialogowych:** 47
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn08_HarsherSecurity_Signed`
- `BaseGame.Bill_Turn09_LighterSecurity_Signed`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Law_MinorityRights`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Policy_Law_WomenLiberation`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_FreedomAct`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecurityAct`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Situation_Law_ExpandedHumanRights`
- `BaseGame.Situation_Law_LimitedHumanRights`
- `BaseGame.Situation_Law_SomeHumanRights`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_LittleSecurityPowers`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Order_ReductionOfCrimeCommunities`
- `BaseGame.Situation_Order_SomeSecurityPowers`
- `BaseGame.Situation_Order_WideRangingSecurityPowers`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[183] Sordland/Turn09/Personal_MonicaFinalTalk** (../Turn_09/183_Personal_MonicaFinalTalk.md), Węzeł `[650]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 17

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Monica): `Variable["BaseGame.Situation_Law_SomeHumanRights"] = true; Variable["BaseGame.Situation_Law_Limit...`
- Węzeł `[7]` (Monica): `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- Węzeł `[8]` (Monica): `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false; Variable["BaseGame.Situation_O...`
- Węzeł `[9]` (Monica): `--;`
- Węzeł `[16]` (Monica): `-- continue;`
- Węzeł `[17]` (Monica): `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true; Variable["BaseGame.Situation_Order_Re...`
- Węzeł `[24]` (Monica): `-- continue;`
- Węzeł `[31]` (Monica): `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false; Variable["BaseGame.Situation_Law_Limi...`
- *...oraz 9 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `183` (*Sordland/Turn09/Personal_MonicaFinalTalk*), Węzeł `[650]`

### Węzeł `[3]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[5]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_SomeHumanRights = true;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = true;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[7]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_CrimeWave = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[8]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[9]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[12]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[13]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[15]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_EmergencyDecree == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[17]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[18]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[20]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[21]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[23]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[25]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DecreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[27]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_DecreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[28]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[30]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[31]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[32]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[34]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[36]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[38]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_IncreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[39]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[41]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: // end)*
- **Efekt (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[42]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[43]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_LittleSecurityPowers = true;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: (BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[46]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
