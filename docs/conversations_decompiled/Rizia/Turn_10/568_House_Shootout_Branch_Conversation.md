# Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/House Shootout Branch/House Shootout Branch Conversation

- **ID konwersacji:** `568`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/568_House_Shootout_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 193
- **Liczba wyborów gracza:** 14

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[67]** Hubertus Toras
- **[68]** Hugo Toras
- **[72]** Leona Sazon
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[85]** Sevrio Castellanus
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Carlos`
- `RiziaDLC.BirthdayGathering_Invited_Lucita`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Turn09_Coup_Warning`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike`
- `RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight`
- `RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike`
- `RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike`
- `RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[567] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation** (../Turn_10/567_Run_Romus_Run!_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 8

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[139]` (Paskal Beniwoll): `--;`
- Węzeł `[170]` (Paskal Beniwoll): `AddConversant("Sevrio Castellanus"); ;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike"] = true;`
- Węzeł `[172]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike"] = true;`
- Węzeł `[173]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike"] = true;`
- Węzeł `[174]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike"] = true;`
- Węzeł `[175]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `PlaySoundEffect("Gunfight");`

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
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `567` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/Run Romus Run!/Run Romus Run! Conversation*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and the Golden Guards stormed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[13]`
Mówca: **Narrator**
> "My guests barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Those already stationed inside the room were swift to act, weapons drawn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and Wruhec’s Guardians, led by Captain Castellanus, stormed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[16]`
Mówca: **Narrator**
> "There was a bang as a smoke grenade clattered through the window, releasing a plume of thick gray fog."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The guests barely had time to react before the windows shattered in unison, and the skylight above burst apart in a shower of glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Azaro soldiers descended from the ceiling on ropes while others entered through the broken windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The sound of cracking glass rang through the room as the skylight above shattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[20]`
Mówca: **Narrator**
> "With ruthless efficiency, Palantor Security Solutions descended on ropes, landing with a series of solid thuds. They moved like clockwork."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Taddeus barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Leona barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Taddeus barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Leona barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Leona barely had time to react before the windows shattered in unison, and the skylight above burst apart in a shower of glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Taddeus barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Leona barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The House forces ignored his orders and took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Titus and his Golden Guardsmen immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Titus Gordion**
> ""Stand down! In the name of the king, put your weapons away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Narrator**
> "A cacophony of competing commands filled the room. Leona cowered, her face etched with terror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[56]`
Mówca: **Narrator**
> "As we reached the door, Titus was hit. He fell to his knees, still firing, blood spreading across his uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Titus Gordion**
> ""Run!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[58]`
Mówca: **Titus Gordion**
> "“Stay seated!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[59]`
Mówca: **Titus Gordion**
> "“Stay where you are, Hugo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Titus! What the hell are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[67]`
Mówca: **Taddeus Azaro**
> ""Captain Gordion! What in God's name are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Leona Sazon**
> ""Captain Gordion! For God's sake, do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future I envision for Rizia does not include rogue actors seeking to reshape it to their own ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've challenged the very stability of this nation by asserting yourselves beyond the sphere of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has no room for power-hungry prats who think they can outshine the Crown, nor will I allow such a situation to fester.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s bring this farce to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The reckoning begins now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The time for talk is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now witness the true power of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Titus, Servio and the other Wruhec's Guardians immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Without warning, a commotion erupted from the main hall as another group of armed men rushed inside, weapons drawn and ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[84]`
Mówca: **Narrator**
> "A cacophony of competing commands filled the room. All of the nobles cowered, their faces etched with terror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Guns pointed at near point-blank range, each side daring the other to make the first move. Then the mounting tension was shattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[89]`
Mówca: **Narrator**
> "A catering staff member, trembling with fear, dropped a serving tray. The crash triggered an instantaneous eruption of gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Bodies fell almost simultaneously -- from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "I saw Titus take a hit to his side, but he dove for cover, returning fire with ruthless efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Chaos engulfed the room. Lights exploded as muzzle flashes sliced through the darkness in frantic bursts, and the gunfire soon spilled into the library's main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "I didn't remember seeking cover, but I somehow found myself behind a table, the world a blur of sound and motion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Without warning, Titus, bleeding from his side, yanked me to my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""You need to get out! Now. I'll hold them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[96]`
  - -> `[98]`
  - -> `[164]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "Don't argue."]** — Mówca: **Player_Romus_Italic**
> "I didn't argue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Titus positioned himself as a shield, firing and fighting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going anywhere!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[99]`
Mówca: **Narrator**
> "A security officer charged, but Titus dropped him with a combination of gunfire and brutal hand-to-hand combat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[100]`
Mówca: **Narrator**
> "A few catering attendants were grabbed, forced to their knees, and bound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Titus stood with a few other Guardians, weapons leveled at the stunned nobles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
Mówca: **Narrator**
> "The Guardians were relentless as they secured the room with aggressive efficiency, blocking every possible escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[103]`
Mówca: **Narrator**
> "The Guards formed a tight line, blocking every exit with unwavering precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The room was silent but for the crunch of broken glass beneath their boots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[105]`
Mówca: **Hubertus Toras**
> ""Titus! What the hell are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Leona Sazon**
> ""Captain Gordion! Please do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[113]`
Mówca: **Taddeus Azaro**
> ""Captain! What in God's name are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
Mówca: **Titus Gordion**
> "“Stay seated, Hugo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Titus raised his weapon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Titus raised his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[117]`
Mówca: **Titus Gordion**
> "“Stay where you are!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[118]`
Mówca: **Titus Gordion**
> ""Everyone stay where you are!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "They shifted uncomfortably, casting fearful glances at each other but remaining in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Titus raised his gun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Titus Gordion**
> "“Sit down, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[122]`
Mówca: **Narrator**
> "The smoke thickened, wrapping the room in a dense haze as the special forces moved with surgical precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "Catering staff were seized and bound, their wrists tied tight as the operatives worked quickly, leaving no corner unchecked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Titus Gordion**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
Mówca: **Narrator**
> "The room fell silent as the mercenaries stood firmly at the door, cutting off all chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[126]`
Mówca: **Leona Sazon**
> ""Captain Gordion! For God's sake, do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[127]`
Mówca: **Narrator**
> "The room fell silent as the soldiers stood firmly at the door, cutting off all chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Titus lifted his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Narrator**
> "The mercenaries moved quickly, grabbing the catering attendants who remained standing, their bindings precise and professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[136]`
Mówca: **Titus Gordion**
> "“Sit down!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[137]`
Mówca: **Hugo Toras**
> "“Do something, Titus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[138]`
Mówca: **Leona Sazon**
> ""Captain! Do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[73]`
  - -> `[72]`
  - -> `[74]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Titus, already in the room, watched them with a cool, almost detached expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> "“Titus! Do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""Captain! What in God’s name do you think you’re doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_Coup_Warning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[150]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_Coup_Warning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know about your plot against the Crown. If you have any sense, admit your guilt now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having just learned of your betrayal, know this... Rizia's future has no room for traitors who aim to bend it to their own will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've challenged the very stability of this nation by asserting yourselves beyond the sphere of the Crown -- a betrayal I've only just uncovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Titus and his men, along with the soldiers, immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Titus and his men, along with the mercenaries, immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Run. My only option. Or was it?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[161]`
Mówca: **Narrator**
> "From the corner of my eye, I spotted Lucita and motioned for her to follow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "But seeing her close proximity to the House guards, I realized she couldn’t, so I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to tell me twice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you crazy? There's no way I'm following you into that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""I'm sorry sir, but you don't have a choice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Narrator**
> "Titus grabbed me by the arm, taking me with him. He positioned himself as a shield as he fought and fired as we pressed ahead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[167]`
Mówca: **Sevrio Castellanus**
> ""Room secure, sir. Divus gidatu gaitu eta libratu gaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "That translated to, "The Lord has guided our hands and delivered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[169]`
Mówca: **Narrator**
> "Once that was done, Captain Castellanus approached Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `AddConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Others came from House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Narrator**
> "A split second later, they were joined by commandos from House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
