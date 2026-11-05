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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[69]` | **""The future I envision for Rizia does not include rogue actors seeking to reshape ..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[70]` | **""You've challenged the very stability of this nation by asserting yourselves beyon..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[71]` | **""Rizia has no room for power-hungry prats who think they can outshine the Crown, n..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[72]` | **""Let’s bring this farce to an end.""** | `[69]` **Player_Romus**: ""The future I envision for Rizia..."<br>`[70]` **Player_Romus**: ""You've challenged the very stab..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Without warning, a commotion eru..." |
| `[73]` | **""The reckoning begins now.""** | `[69]` **Player_Romus**: ""The future I envision for Rizia..."<br>`[70]` **Player_Romus**: ""You've challenged the very stab..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Without warning, a commotion eru..." |
| `[74]` | **""The time for talk is over.""** | `[69]` **Player_Romus**: ""The future I envision for Rizia..."<br>`[70]` **Player_Romus**: ""You've challenged the very stab..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Without warning, a commotion eru..." |
| `[75]` | **""Now witness the true power of the Crown.""** | `[69]` **Player_Romus**: ""The future I envision for Rizia..."<br>`[70]` **Player_Romus**: ""You've challenged the very stab..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Without warning, a commotion eru..." |
| `[96]` | **"Don't argue."** | `[95]` **Titus Gordion**: ""You need to get out! Now. I'll ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Titus positioned himself as a sh..." |
| `[98]` | **""I'm not going anywhere!""** | `[95]` **Titus Gordion**: ""You need to get out! Now. I'll ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Titus Gordion**: ""I'm sorry sir, but you don't ha..." |
| `[149]` | **""I know about your plot against the Crown. If you have any sense, admit your guilt..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[150]` | **""Having just learned of your betrayal, know this... Rizia's future has no room for..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[151]` | **""You've challenged the very stability of this nation by asserting yourselves beyon..."** | `[119]` **Narrator**: "They shifted uncomfortably, cast..." | `Variable["RiziaDLC.Turn09_Coup_Warning"] == true` | `--;` | `[75]` **Player_Romus**: ""Now witness the true power of t..."<br>`[73]` **Player_Romus**: ""The reckoning begins now.""<br>*(oraz 2 innych odgałęzień)* |
| `[163]` | **""You don't have to tell me twice!""** | `[95]` **Titus Gordion**: ""You need to get out! Now. I'll ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Titus positioned himself as a sh..." |
| `[164]` | **""Are you crazy? There's no way I'm following you into that!""** | `[95]` **Titus Gordion**: ""You need to get out! Now. I'll ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Titus Gordion**: ""I'm sorry sir, but you don't ha..." |

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
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike = true;"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The heavy double doors crashed open, and the Golden Guard..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialFo..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Special..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike = true;"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPM..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike = true;"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialFo..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and the Golden Guards stormed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike = true;"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "My guests barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Those already stationed inside the room were swift to act..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Those already stationed inside the room were swift to act, weapons drawn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The heavy double doors crashed open, and Wruhec’s Guardians, led by Captain Castellanus, stormed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus");"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "There was a bang as a smoke grenade clattered through the window, releasing a plume of thick gray fog."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The guests barely had time to react before the windows shattered in unison, and the skylight above burst apart in a shower of glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Azaro soldiers descended from the ceiling on ropes while ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Azaro soldiers descended from the ceiling on ropes while others entered through the broken windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The sound of cracking glass rang through the room as the skylight above shattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "With ruthless efficiency, Palantor Security Solutions descended on ropes, landing with a series of solid thuds. They moved like clockwork."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Titus, already in the room, watched them with a cool, alm..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_Invited_Angelica == true ||..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "My guests barely had time to react before Golden Guardsme..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Taddeus barely had time to react before Golden Guardsmen ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Leona barely had time to react before Golden Guardsmen de..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Taddeus barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Those already stationed inside the room were swift to act..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Leona barely had time to react before Golden Guardsmen descended in perfect unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Those already stationed inside the room were swift to act..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_Invited_Angelica == true ||..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "My guests barely had time to react."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Titus stood with a few other Guardians, weapons leveled a..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Taddeus barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Titus stood with a few other Guardians, weapons leveled a..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Leona barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Titus stood with a few other Guardians, weapons leveled a..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Taddeus barely had time to react."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Leona barely had time to react."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_Invited_Angelica == true ||..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The guests barely had time to react before the windows sh..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Leona barely had time to react before the windows shatter..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Leona barely had time to react before the windows shattered in unison, and the skylight above burst apart in a shower of glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Azaro soldiers descended from the ceiling on ropes while ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Taddeus barely had time to react."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Leona barely had time to react."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "My guests barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "With ruthless efficiency, Palantor Security Solutions des..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_Invited_Angelica == true ||..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "My guests barely had time to react."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus || RiziaDLC.BirthdayGathering_Invited_Carlos == true || RiziaDLC.BirthdayGathering_Invited_Lucita == true) || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"]  or  Variable["RiziaDLC.BirthdayGathering_Invited_Carlos"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Lucita"] == true)  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Taddeus barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "With ruthless efficiency, Palantor Security Solutions des..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Leona barely had time to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "With ruthless efficiency, Palantor Security Solutions des..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The House forces ignored his orders and took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true || Ri..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Titus and his Golden Guardsmen immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Titus Gordion: ""Stand down! In the name of the king, put your weapons aw..."*)

### Węzeł `[54]`
Mówca: **Titus Gordion**
> ""Stand down! In the name of the king, put your weapons away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The House forces ignored his orders and took a step forward."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "A cacophony of competing commands filled the room. Leona cowered, her face etched with terror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Guns pointed at near point-blank range, each side daring ..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "As we reached the door, Titus was hit. He fell to his knees, still firing, blood spreading across his uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Titus Gordion: ""Run!""*)

### Węzeł `[57]`
Mówca: **Titus Gordion**
> ""Run!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Run. My only option. Or was it?"*)

### Węzeł `[58]`
Mówca: **Titus Gordion**
> "“Stay seated!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Titus raised his weapon."*)

### Węzeł `[59]`
Mówca: **Titus Gordion**
> "“Stay where you are, Hugo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Titus raised his firearm."*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""Titus! What the hell are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Titus Gordion: "“Stay where you are, Hugo.”"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hubertus Toras: ""Titus! What the hell are you doing?!""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Taddeus Azaro: ""Captain Gordion! What in God's name are you doing?""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Leona Sazon: ""Captain! Do something!""*)

### Węzeł `[67]`
Mówca: **Taddeus Azaro**
> ""Captain Gordion! What in God's name are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Titus Gordion: "“Stay seated!”"*)

### Węzeł `[68]`
Mówca: **Leona Sazon**
> ""Captain Gordion! For God's sake, do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Titus raised his gun."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future I envision for Rizia does not include rogue actors seeking to reshape it to their own ends.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've challenged the very stability of this nation by asserting yourselves beyond the sphere of the Crown.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has no room for power-hungry prats who think they can outshine the Crown, nor will I allow such a situation to fester.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s bring this farce to an end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Player_Romus), `[70]` (Player_Romus), `[71]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Without warning, a commotion erupted from the main hall a..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The reckoning begins now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Player_Romus), `[70]` (Player_Romus), `[71]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Without warning, a commotion erupted from the main hall a..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The time for talk is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Player_Romus), `[70]` (Player_Romus), `[71]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Without warning, a commotion erupted from the main hall a..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now witness the true power of the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Player_Romus), `[70]` (Player_Romus), `[71]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Without warning, a commotion erupted from the main hall a..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Wruhecs..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Titus, Servio and the other Wruhec's Guardians immediatel..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Titus and his Golden Guardsmen immediately swung their gu..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialFo..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Special..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Titus and his men, along with the soldiers, immediately s..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialForces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGu..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Titus, Servio and the other Wruhec's Guardians immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Titus Gordion: ""Stand down! In the name of the king, put your weapons aw..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Without warning, a commotion erupted from the main hall as another group of armed men rushed inside, weapons drawn and ready."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[84]`
Mówca: **Narrator**
> "A cacophony of competing commands filled the room. All of the nobles cowered, their faces etched with terror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Guns pointed at near point-blank range, each side daring ..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Guns pointed at near point-blank range, each side daring the other to make the first move. Then the mounting tension was shattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "A catering staff member, trembling with fear, dropped a s..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Angelica == true || Ri..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Angelica == true || ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "A cacophony of competing commands filled the room. All of..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Angelica == true || RiziaDLC.BirthdayGathering_Invited_Manus == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true  or  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "A cacophony of competing commands filled the room. Leona ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "A catering staff member, trembling with fear, dropped a serving tray. The crash triggered an instantaneous eruption of gunfire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gunfight");"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Bodies fell almost simultaneously -- from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "I saw Titus take a hit to his side, but he dove for cover..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "I saw Titus take a hit to his side, but he dove for cover, returning fire with ruthless efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Chaos engulfed the room. Lights exploded as muzzle flashe..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Chaos engulfed the room. Lights exploded as muzzle flashes sliced through the darkness in frantic bursts, and the gunfire soon spilled into the library's main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "I didn't remember seeking cover, but I somehow found myse..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "I didn't remember seeking cover, but I somehow found myself behind a table, the world a blur of sound and motion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Without warning, Titus, bleeding from his side, yanked me..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Without warning, Titus, bleeding from his side, yanked me to my feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Titus Gordion: ""You need to get out! Now. I'll hold them back.""*)

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""You need to get out! Now. I'll hold them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""You don't have to tell me twice!""*)
  - -> `[96]` (*Player_Romus_Italic: "Don't argue."*)
  - -> `[98]` (*Player_Romus: ""I'm not going anywhere!""*)
  - -> `[164]` (*Player_Romus: ""Are you crazy? There's no way I'm following you into that!""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "Don't argue."]** — Mówca: **Player_Romus_Italic**
> "I didn't argue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Titus positioned himself as a shield, firing and fighting."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Titus positioned himself as a shield, firing and fighting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "A security officer charged, but Titus dropped him with a ..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going anywhere!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Titus Gordion: ""I'm sorry sir, but you don't have a choice!""*)

### Węzeł `[99]`
Mówca: **Narrator**
> "A security officer charged, but Titus dropped him with a combination of gunfire and brutal hand-to-hand combat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "A few catering attendants were grabbed, forced to their knees, and bound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "The Guards formed a tight line, blocking every exit with ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Titus stood with a few other Guardians, weapons leveled at the stunned nobles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "The Guardians were relentless as they secured the room with aggressive efficiency, blocking every possible escape route."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "Once that was done, Captain Castellanus approached Titus."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "The Guards formed a tight line, blocking every exit with unwavering precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The room was silent but for the crunch of broken glass be..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The room was silent but for the crunch of broken glass beneath their boots."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Titus Gordion: ""Everyone stay where you are!""*)

### Węzeł `[105]`
Mówca: **Hubertus Toras**
> ""Titus! What the hell are you doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Titus Gordion: "“Stay seated, Hugo.”"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Taddeus Azaro: ""Captain! What in God's name are you doing?""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Leona Sazon: ""Captain Gordion! Please do something!""*)

### Węzeł `[109]`
Mówca: **Leona Sazon**
> ""Captain Gordion! Please do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Titus Gordion: "“Stay where you are!”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""Titus! What the hell are you doing?!""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[113]`
Mówca: **Taddeus Azaro**
> ""Captain! What in God's name are you doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Titus Gordion: "“Stay where you are!”"*)

### Węzeł `[114]`
Mówca: **Titus Gordion**
> "“Stay seated, Hugo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Titus raised his weapon."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Titus raised his weapon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "A few catering attendants were grabbed, forced to their k..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Titus raised his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "The Guardians were relentless as they secured the room wi..."*)

### Węzeł `[117]`
Mówca: **Titus Gordion**
> "“Stay where you are!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Titus raised his firearm."*)

### Węzeł `[118]`
Mówca: **Titus Gordion**
> ""Everyone stay where you are!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "They shifted uncomfortably, casting fearful glances at ea..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "They shifted uncomfortably, casting fearful glances at each other but remaining in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Titus raised his gun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "The smoke thickened, wrapping the room in a dense haze as..."*)

### Węzeł `[121]`
Mówca: **Titus Gordion**
> "“Sit down, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Titus raised his gun."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "The smoke thickened, wrapping the room in a dense haze as the special forces moved with surgical precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Catering staff were seized and bound, their wrists tied t..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Catering staff were seized and bound, their wrists tied tight as the operatives worked quickly, leaving no corner unchecked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "The room fell silent as the soldiers stood firmly at the ..."*)

### Węzeł `[124]`
Mówca: **Titus Gordion**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Titus lifted his firearm."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "The room fell silent as the mercenaries stood firmly at the door, cutting off all chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Titus Gordion: ""Everyone stay where you are!""*)

### Węzeł `[126]`
Mówca: **Leona Sazon**
> ""Captain Gordion! For God's sake, do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Titus Gordion: "“Sit down!”"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "The room fell silent as the soldiers stood firmly at the door, cutting off all chances of escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Titus Gordion: ""Everyone stay where you are!""*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Titus lifted his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "The mercenaries moved quickly, grabbing the catering atte..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "The mercenaries moved quickly, grabbing the catering attendants who remained standing, their bindings precise and professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "The room fell silent as the mercenaries stood firmly at t..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Hugo Toras: "“Do something, Titus!""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Leona Sazon: ""Captain Gordion! For God's sake, do something!""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Taddeus Azaro: ""Captain! What in God’s name do you think you’re doing?!""*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Leona Sazon: ""Captain Gordion! For God's sake, do something!""*)

### Węzeł `[136]`
Mówca: **Titus Gordion**
> "“Sit down!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Titus lifted his firearm."*)

### Węzeł `[137]`
Mówca: **Hugo Toras**
> "“Do something, Titus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Titus Gordion: "“Sit down, Hugo.""*)

### Węzeł `[138]`
Mówca: **Leona Sazon**
> ""Captain! Do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Titus Gordion: "“Stay seated!”"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""Now witness the true power of the Crown.""*)
  - -> `[73]` (*Player_Romus: ""The reckoning begins now.""*)
  - -> `[72]` (*Player_Romus: ""Let’s bring this farce to an end.""*)
  - -> `[74]` (*Player_Romus: ""The time for talk is over.""*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Titus, already in the room, watched them with a cool, almost detached expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> "“Titus! Do something!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Titus Gordion: ""I am.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: "“Titus! Do something!""*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""Captain! What in God’s name do you think you’re doing?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Titus Gordion: "“Sit down!”"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_Coup_Warning == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_Coup_Warning == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_Coup_Warning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""You've challenged the very stability of this nation by a..."*)
  - -> `[150]` (*Player_Romus: ""Having just learned of your betrayal, know this... Rizia..."*)
  - -> `[149]` (*Player_Romus: ""I know about your plot against the Crown. If you have an..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_Coup_Warning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_Coup_Warning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""The future I envision for Rizia does not include rogue a..."*)
  - -> `[70]` (*Player_Romus: ""You've challenged the very stability of this nation by a..."*)
  - -> `[71]` (*Player_Romus: ""Rizia has no room for power-hungry prats who think they ..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know about your plot against the Crown. If you have any sense, admit your guilt now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having just learned of your betrayal, know this... Rizia's future has no room for traitors who aim to bend it to their own will.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've challenged the very stability of this nation by asserting yourselves beyond the sphere of the Crown -- a betrayal I've only just uncovered.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_Coup_Warning"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPM..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Titus and his men, along with the mercenaries, immediatel..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_SpecialFo..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Titus and his men, along with the soldiers, immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Titus Gordion: ""Stand down! In the name of the king, put your weapons aw..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Titus and his men, along with the mercenaries, immediately swung their guns toward the newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Titus Gordion: ""Stand down! In the name of the king, put your weapons aw..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Run. My only option. Or was it?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "From the corner of my eye, I spotted Lucita and motioned ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "As we reached the door, Titus was hit. He fell to his kne..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "From the corner of my eye, I spotted Lucita and motioned for her to follow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "But seeing her close proximity to the House guards, I rea..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "But seeing her close proximity to the House guards, I realized she couldn’t, so I pressed on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "As we reached the door, Titus was hit. He fell to his kne..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to tell me twice!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Titus positioned himself as a shield, firing and fighting."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you crazy? There's no way I'm following you into that!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Titus Gordion: ""I'm sorry sir, but you don't have a choice!""*)

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""I'm sorry sir, but you don't have a choice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Titus grabbed me by the arm, taking me with him. He posit..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "Titus grabbed me by the arm, taking me with him. He positioned himself as a shield as he fought and fired as we pressed ahead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "A security officer charged, but Titus dropped him with a ..."*)

### Węzeł `[167]`
Mówca: **Sevrio Castellanus**
> ""Room secure, sir. Divus gidatu gaitu eta libratu gaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "That translated to, "The Lord has guided our hands and de..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "That translated to, "The Lord has guided our hands and delivered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Titus Gordion: ""Everyone stay where you are!""*)

### Węzeł `[169]`
Mówca: **Narrator**
> "Once that was done, Captain Castellanus approached Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Sevrio Castellanus: ""Room secure, sir. Divus gidatu gaitu eta libratu gaitu.""*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_PMCStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The sound of cracking glass rang through the room as the ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_SFStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "There was a bang as a smoke grenade clattered through the..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_WGStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The heavy double doors crashed open, and Wruhec’s Guardia..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_GGStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_Invited_Angelica == true || R..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Their uniforms bore the sigil of House Azaro."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Their uniforms bore the sigil of House Toras."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Their uniforms bore the sigil of House Sazon."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Their uniforms bore the sigil of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fig..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "A split second later, they were joined by commandos from ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fig..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Others came from House Toras."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Others came from House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "A split second later, they were joined by commandos from ..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "A split second later, they were joined by commandos from House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_HouseSecurity_Fig..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gunfight");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Bodies fell almost simultaneously -- from both sides."*)
