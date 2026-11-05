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
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_FreedomAct == true && BaseGame.Po..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = true; Bas..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecurityAct == true && (BaseGame.Po..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_SomeHumanRights = true;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = true;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecurityAct == true && (BaseGame.Po..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecurityAct == true && (BaseGame...."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_EmergencyDecree == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_EmergencyDecree == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  || ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false |..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = false; BaseGame...."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  || ..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  |..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = true; BaseGame.S..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave = true;"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_FreedomAct == true && BaseGame.Po..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = true;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false |..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = false; BaseGame...."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "// end"*)
