# Rizia/Turn 8/Reform_Movement_Unrest/Reform_Movement_Unrest Conversation

- **ID konwersacji:** `594`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/594_Reform_Movement_Unrest_Conversation.md`
- **Liczba węzłów dialogowych:** 61
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Iza_SuOminaSuppressed`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Reform_Movement_Strength`
- `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair`
- `RiziaDLC.Situation_Order_BorderSecurity_Weak`
- `RiziaDLC.Situation_Order_DrugTrade_Vibrant`
- `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.HouseOfDelegates_Speaker_Adarfo`
- `RiziaDLC.HouseOfDelegates_Speaker_Manus`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Situation_Order_SectarianViolence`
- `RiziaDLC.Unrest_Nationalist_Grows`
- `RiziaDLC.Unrest_Religious_Grows`
- `RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader`
- `RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader`
- `RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGone`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[445]`

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
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NATIONALIST MOVEMENT GROWS`
- **Efekt skryptowy (`userScript`):** `-- NATIONALIST MOVEMENT GROWS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Nationalist_Grows = true; RiziaDLC.Countr..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true ..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Religion_RemoveStateReligion == tru..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true  or  (Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false  and  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "// WRUHECIST MOVEMENT GROWS"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false)))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true  or  (Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false  and  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == f..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situati..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < -5  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < -5  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// WRUHECIST MOVEMENT GROWS`
- **Efekt skryptowy (`userScript`):** `-- WRUHECIST MOVEMENT GROWS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Religious_Grows = true; RiziaDLC.Situatio..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == f..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair ==..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false  or  Variable["RiziaDLC.Situation_Order_BorderSecurity_Weak"])  and  (Variable["RiziaDLC.Situation_Order_DrugTrade_Vibrant"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true)  and  Variable["RiziaDLC.Iza_SuOminaSuppressed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "// NATIONALIST MOVEMENT GROWS"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false  or  Variable["RiziaDLC.Situation_Order_BorderSecurity_Weak"])  and  (Variable["RiziaDLC.Situation_Order_DrugTrade_Vibrant"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true)  and  Variable["RiziaDLC.Iza_SuOminaSuppressed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Grows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion -= 5;"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Religious_Grows = true;
RiziaDLC.Situation_Order_SectarianViolence = true;
RiziaDLC.Country_PublicOpinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Unrest_Religious_Grows"] = true;
Variable["RiziaDLC.Situation_Order_SectarianViolence"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Nationalist_Grows = true;
RiziaDLC.Country_PublicOpinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Unrest_Nationalist_Grows"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Refo..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 9  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "// REFORM MOVEMENT GROWS. MANUS DEMANDS CONSTITUTION"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 9  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// MANUS ASKS FOR REFORMS"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Refo..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "// UNREST GROWS. ADARFO LEADS THE MOVEMENT"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// UNREST GROWS. ADARFO LEADS THE MOVEMENT`
- **Efekt skryptowy (`userScript`):** `-- UNREST GROWS. ADARFO LEADS THE MOVEMENT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows = true; RiziaDLC.Reform_Mo..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// REFORM MOVEMENT GROWS. MANUS DEMANDS CONSTITUTION`
- **Efekt skryptowy (`userScript`):** `-- REFORM MOVEMENT GROWS. MANUS DEMANDS CONSTITUTION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows = true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// MANUS ASKS FOR REFORMS`
- **Efekt skryptowy (`userScript`):** `-- MANUS ASKS FOR REFORMS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows = true;
RiziaDLC.Reform_Movement_Leader_Adarfo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Grows"] = true;
Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion -= 10;"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion -= 10;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo = true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && Rizia..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "// UNREST GROWS. ADARFO LEADS THE MOVEMENT"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader = true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGon..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader = true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGone = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied ..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfie..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == f..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Speaker_Manus = false; RiziaDLC..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_HouseOfDelegates", "HODPosition_No..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Speaker_Manus = false;
RiziaDLC.HouseOfDelegates_Speaker_Adarfo = true;
AssignConnection("Page_HouseOfDelegates", "HODPosition_Speaker", "HOD_Speaker_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato", "Speaker of the House of Delegates");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_1", "HOD_RPP_Leader_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RNC_Leader_DariaDeRava");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.HouseOfDelegates_Speaker_Manus"] = false;
Variable["RiziaDLC.HouseOfDelegates_Speaker_Adarfo"] = true;
AssignConnection("Page_HouseOfDelegates","HODPosition_Speaker","HOD_Speaker_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato","Speaker of the House of Delegates");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_1","HOD_RPP_Leader_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RNC_Leader_DariaDeRava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RPP_Leader_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato", "Opposition Leader");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RPP_Leader_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato","Opposition Leader");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_HouseOfDelegates", "HODPosition_No..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_HouseOfDelegates", "HODPosition_No..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_3", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_3", "HOD_RPP_Member_ManusSazon");
UpdateCharacterTitle("Manus Sazon", "Member of RPP");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_3","HOD_RPP_Member_ManusSazon");
UpdateCharacterTitle("Manus Sazon","Member of RPP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
