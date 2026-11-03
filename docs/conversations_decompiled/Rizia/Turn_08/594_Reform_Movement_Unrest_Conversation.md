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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 22

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Unrest_Nationalist_Grows`
- `RiziaDLC.Unrest_Religious_Grows`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `-- NATIONALIST MOVEMENT GROWS;`
- Węzeł `[10]` (Paskal Beniwoll): `--;`
- Węzeł `[11]` (Paskal Beniwoll): `-- WRUHECIST MOVEMENT GROWS;`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLC.Reform_Movement_Grows"] = true;`
- Węzeł `[16]` (Paskal Beniwoll): `Variable["RiziaDLC.Unrest_Religious_Grows"] = true; Variable["RiziaDLC.Situation_Order_SectarianV...`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["RiziaDLC.Unrest_Nationalist_Grows"] = true; Variable["RiziaDLC.Country_PublicOpinion"] ...`
- Węzeł `[18]` (Paskal Beniwoll): `--;`
- Węzeł `[25]` (Paskal Beniwoll): `-- UNREST GROWS. ADARFO LEADS THE MOVEMENT;`
- *...oraz 14 innych węzłów ze skryptami.*

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
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `419` (*Rizia/Turn 8/A_GeneralCouncilMeeting*), Węzeł `[445]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // NATIONALIST MOVEMENT GROWS)*
- **Efekt (`userScript`):** `-- NATIONALIST MOVEMENT GROWS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true  or  (Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false  and  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true || (RiziaDLC.Policy_Law_StateReligion_Wruhecism == false && RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == false))))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true  or  (Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false  and  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < -5  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_PublicOpinion < -5 || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < -5  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // WRUHECIST MOVEMENT GROWS)*
- **Efekt (`userScript`):** `-- WRUHECIST MOVEMENT GROWS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false  or  Variable["RiziaDLC.Situation_Order_BorderSecurity_Weak"])  and  (Variable["RiziaDLC.Situation_Order_DrugTrade_Vibrant"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true)  and  Variable["RiziaDLC.Iza_SuOminaSuppressed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false || RiziaDLC.Situation_Order_BorderSecurity_Weak) && (RiziaDLC.Situation_Order_DrugTrade_Vibrant == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true) && RiziaDLC.Iza_SuOminaSuppressed == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false  or  Variable["RiziaDLC.Situation_Order_BorderSecurity_Weak"])  and  (Variable["RiziaDLC.Situation_Order_DrugTrade_Vibrant"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true)  and  Variable["RiziaDLC.Iza_SuOminaSuppressed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Grows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Religious_Grows = true;
RiziaDLC.Situation_Order_SectarianViolence = true;
RiziaDLC.Country_PublicOpinion -= 5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Unrest_Religious_Grows"] = true;
Variable["RiziaDLC.Situation_Order_SectarianViolence"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Unrest_Nationalist_Grows = true;
RiziaDLC.Country_PublicOpinion -= 5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Unrest_Nationalist_Grows"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 9  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength >= 9 && RiziaDLC.Reform_Movement_Radicalism >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 9  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Strength"] >= 7  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Strength >= 7 && RiziaDLC.Reform_Movement_Radicalism >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Strength"] >= 7  and  Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // UNREST GROWS. ADARFO LEADS THE MOVEMENT)*
- **Efekt (`userScript`):** `-- UNREST GROWS. ADARFO LEADS THE MOVEMENT;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // REFORM MOVEMENT GROWS. MANUS DEMANDS CONSTITUTION)*
- **Efekt (`userScript`):** `-- REFORM MOVEMENT GROWS. MANUS DEMANDS CONSTITUTION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // MANUS ASKS FOR REFORMS)*
- **Efekt (`userScript`):** `-- MANUS ASKS FOR REFORMS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows = true;
RiziaDLC.Reform_Movement_Leader_Adarfo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Grows"] = true;
Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion -= 10;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_PublicOpinion -= 5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Strength"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Reform_Movement_Strength >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Reform_Movement_Strength"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_RPPElectsNewLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader_ManusGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_V_RPPElectsNewLeader"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Speaker_Manus = false;
RiziaDLC.HouseOfDelegates_Speaker_Adarfo = true;
AssignConnection("Page_HouseOfDelegates", "HODPosition_Speaker", "HOD_Speaker_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato", "Speaker of the House of Delegates");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_1", "HOD_RPP_Leader_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RNC_Leader_DariaDeRava");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.HouseOfDelegates_Speaker_Manus"] = false;
Variable["RiziaDLC.HouseOfDelegates_Speaker_Adarfo"] = true;
AssignConnection("Page_HouseOfDelegates","HODPosition_Speaker","HOD_Speaker_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato","Speaker of the House of Delegates");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_1","HOD_RPP_Leader_AdarfoSotelato");
AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RNC_Leader_DariaDeRava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RPP_Leader_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato", "Opposition Leader");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");)*
- **Efekt (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RPP_Leader_AdarfoSotelato");
UpdateCharacterTitle("Adarfo Sotelato","Opposition Leader");
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Gone == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_3", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_3","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_3", "HOD_RPP_Member_ManusSazon");
UpdateCharacterTitle("Manus Sazon", "Member of RPP");)*
- **Efekt (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_3","HOD_RPP_Member_ManusSazon");
UpdateCharacterTitle("Manus Sazon","Member of RPP");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
