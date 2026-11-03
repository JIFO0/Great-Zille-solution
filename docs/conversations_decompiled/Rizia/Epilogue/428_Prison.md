# Rizia/Prison

- **ID konwersacji:** `428`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Prison)`
- **Lokalizacja pliku:** `Rizia/Epilogue/428_Prison.md`
- **Liczba węzłów dialogowych:** 400
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_RumburgWarLost`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Ending_WorldWar`
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.BirthdayGathering_HouseStrike_Success`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_TitusBetrays`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Coup_Leader_Angelica`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Reform`
- `RiziaDLC.Epilogue_Prison_ConstitutionSigning`
- `RiziaDLC.Epilogue_Prison_HugoSendsToPrison`
- `RiziaDLC.Epilogue_Prison_Revolution_Surrounded`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Hugo_Resigned`
- `RiziaDLC.Hugo_RicoNotPardoned`
- `RiziaDLC.LateGameCoup_TitusBetrays`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RomanceHappened`
- `RiziaDLC.Manus_ConvinceToLeave`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Manus_ThreatenToLeave`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Son_Romus`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_DiedInPrison`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLCText.LenaTooltip`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[18]`
- Węzeł `[164]` -> **[430] Rizia/Peaceful Power Transition** (../Epilogue/430_Peaceful_Power_Transition.md), Węzeł `[83]`
- Węzeł `[200]` -> **[430] Rizia/Peaceful Power Transition** (../Epilogue/430_Peaceful_Power_Transition.md), Węzeł `[552]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 22

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[54]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- Węzeł `[55]` (Paskal Beniwoll): `PlaySoundEffect("Guillotine");`
- Węzeł `[56]` (Paskal Beniwoll): `PlaySoundEffect("Guillotine");`
- Węzeł `[57]` (Paskal Beniwoll): `PrologueImage("pe_jail");`
- Węzeł `[58]` (Paskal Beniwoll): `PrologueImage("pe_guillotine");`
- Węzeł `[59]` (Paskal Beniwoll): `PrologueImage("pe_light");`
- Węzeł `[63]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- Węzeł `[84]` (Paskal Beniwoll): `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
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
  - -> `[57]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `425` (*Rizia/Epilogue*), Węzeł `[18]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_ConstitutionSigning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_ConstitutionSigning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_ConstitutionSigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_ConstitutionSigning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_ConstitutionSigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Prison Constitution Signing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Prison House Fallouts Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Prison Constitution Signing])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Prison House Fallouts Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Prison Revolution Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Prison Revolution Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Lucita, growing further and further away from you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[13]`
  - -> `[21]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could not make sense of what was happening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran after her as fast as you could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told her to stay with you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Pabel, growing further and further away from you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran after him as fast as you could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...could not make sense of what was happening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told him to stay with you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was Lena, growing further and further away from you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[24]`

### Węzeł `[27]`
Mówca: **Narrator**
> "You heard a deep bellow from right behind you. It sounded like something was grunting within the darkness.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[30]`
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt the brush of something soft."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "A rat was looking at you.

You had lost track of the passage of time long ago. It had been at least a few months, you thought, but it did not matter anymore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not dare to move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ran for your life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...turned around to face it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[35]`
Mówca: **Narrator**
> "But, there was no escape. It appeared right before you. It was the most magnificent bull you had ever seen. Its hair was black as night, its eyes red with rage.

With a challenging roar, the bull pawed the ground and charged at you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The cell door opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The warden entered your cell to read you your final rites before the execution.

He asked what you wanted for your final meal.

You requested..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[40]`
  - -> `[39]`
  - -> `[38]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...Toras flambeé."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a rizetta."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "After your meal, you were dragged through a tunnel, just like the one from your dream.

You looked around, but..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...the bull was nowhere to be found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Among the cheers of the crowd, the executioners made you kneel for the guillotine.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[48]`
  - -> `[50]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The blade dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[45]`
Mówca: **Narrator**
> "And so passed His Majesty, Romus of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The last of his name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[47]`
Mówca: **Narrator**
> "It was all for naught.

You looked up and saw the sharp blade glimmering in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did not resist at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried to get away with all your might."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...accepted your fate with dignity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "You looked up and saw the sharp blade glimmering in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...a bottle of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Epilogue Taddeus Coup Arrest)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Guillotine");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Guillotine");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail"))*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_guillotine"))*
- **Efekt (`userScript`):** `PrologueImage("pe_guillotine");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_light"))*
- **Efekt (`userScript`):** `PrologueImage("pe_light");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Son_Romus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Son_Romus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Son_Romus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Son_Romus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Son_Romus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The second-to-last of his name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "You were in a dark tunnel with no light at the end. 

A faint voice echoed in your head. It was your mother, growing further and further away from you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[24]`
  - -> `[72]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...cursed her for giving birth to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least you fought for something greater, for a better world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't help but wish you had crushed your enemies when you had the chance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The coupists had crushed Rizia's nascent democracy and were unleashing a violent crackdown on the reformists.

The House of Delegates had been dismantled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[81]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt nothing but the weight of time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...counted each day, a silent rebellion against your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It seemed pointless now, worrying about what could have been."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Power had been a fragile thing, bestowed and then forcibly taken away. In the Citadel, days turned into weeks. 

The same walls that had once confined criminals and traitors during your reign now held you captive.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...found bitter irony in this cruel twist of fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[97]`
Mówca: **Narrator**
> "All three noble houses united behind Hugo after you were declared a traitor to the Crown.

Their forces swept across the kingdom while you were behind bars, eliminating your last remaining loyalists and other threats to their rule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Houses Toras and Sazon united behind Hugo after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, crushing your last remaining loyalists and using the chaos to weaken House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Houses Toras and Azaro united behind Hugo after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, crushing your last remaining loyalists and using the chaos to strike House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Houses Sazon and Azaro united behind General Taddeus after you were declared a traitor to the Crown.

While you sat behind bars, their forces swept across the kingdom, using the opportunity to crush House Toras and your loyalists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[107]`
Mówca: **Narrator**
> "While you sat behind bars, House Sazon's forces swept across the kingdom, seizing the opportunity to strike Houses Toras and Azaro.

In response, the Azaros rallied behind Hugo to stop them, preventing the country from descending to chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And then came the news -- Hugo had been crowned king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[109]`
Mówca: **Narrator**
> "While you sat behind bars, House Azaro's forces swept across the kingdom, seizing the opportunity to strike Houses Toras and Sazon.

In response, the Sazons rallied behind Hugo to stop them, preventing the country from descending to chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "And then came the news -- Taddeus had been crowned king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "News had been scarce since you were branded a traitor to the Crown and thrown into jail by Titus.

But then, word arrived -- Hugo had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Birthday_Gathering_Revolution_Fail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing revolutionaries and the reformists across Rizia.

Adarfo Sotelato's movement, once a beacon of hope, had withered into nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[81]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[126]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Hugo had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Rico had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Lucita had been officially crowned queen in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Taddeus had been officially crowned king in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Narrator**
> "News had been scarce since you were arrested by the coupists.

But then, word arrived -- Angelica had been officially crowned queen in a grand public ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The days passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Policy_Law_Succession_FemalePrefMatrilineal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Hugo Toras, your life shall be spared, your honor reinstated, and your family granted amnesty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "Your release came as part of the Sovereign Transition and Clemency Act signed by Rizia's new monarch.

On your way out you were handed a letter that read..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[148]`
  - -> `[168]`
  - -> `[151]`
  - -> `[142]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...under the royal decree of King Rico Toras, your life is hereby preserved, your honor reclaimed, and the safety of your family assured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of King Taddeus Azaro, your life is spared, your honor restored, and your family's sanctity upheld."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, your life is spared, your honor redeemed, and your family's well-being guaranteed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Angelica Sazon, your existence is spared, your honor renewed, and your family's safety preserved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[163]`
Mówca: **Narrator**
> "To circumvent any potential for political unrest in the capital, Queen Lucita moved your imprisonment to Iza, far from Porte Drazon. 

You were relocated to a slightly better jail cell with a view of the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [EpilogueIza])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `430` (*Rizia/Peaceful Power Transition*), Węzeł `[83]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Fully free at last, life could begin anew. For the first time since birth, choosing your destiny was in your hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...by the royal decree of Queen Lucita Azaro, you were to be released in one month's time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A fresh start awaited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[171]`
Mówca: **Narrator**
> "At some point, you lost track of the passage of time. Had you been in the Citadel for weeks, or months? There was no way of knowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true && RiziaDLC.Hugo_Resigned == false && RiziaDLC.Hugo_RicoNotPardoned == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true  and  Variable["RiziaDLC.Hugo_Resigned"] == false  and  Variable["RiziaDLC.Hugo_RicoNotPardoned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Lucita_RomanceHappened"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Lucita_RomanceHappened == true && RiziaDLC.Taddeus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Lucita_RomanceHappened"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == false && RiziaDLC.Lucita_Arrested == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Manus_ConvinceToLeave"] == false  and  Variable["RiziaDLC.Manus_DiesInWar"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Gone == true && RiziaDLC.Manus_ConvinceToLeave == false && RiziaDLC.Manus_DiesInWar == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Gone"] == true  and  Variable["RiziaDLC.Manus_ConvinceToLeave"] == false  and  Variable["RiziaDLC.Manus_DiesInWar"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true && RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true  and  Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true && RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  and  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true  and  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true && RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true  and  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Angelica == true && (RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true  and  (Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "1958|Porte Drazon"]** — Mówca: **Narrator**
> "Thousands were being released from prison. Their freedom came as part of the Sovereign Transition and Clemency signed by the new monarch. But for you, there was no amnesty.

The warden handed you a letter that read..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [JumpFromPrison])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `430` (*Rizia/Peaceful Power Transition*), Węzeł `[552]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I have given birth to our son, {RiziaDLCText.KingsSon}, the future King of Rizia. May he grow up to be a more noble and honorable man than his father. Sincerely, Queen Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && (RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true) && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  (Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == false && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.Coup_Leader_Taddeus == false && RiziaDLC.Coup_Leader_Lucita == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == false  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.Coup_Leader_Taddeus"] == false  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am writing this from exile -- I will not tell you where for my protection and that of our newborn son, {RiziaDLCText.KingsSon}. I will raise him well and keep him safe until the day you are able to join us. Love always, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I have given birth to your son, {RiziaDLCText.KingsSon}. May he grow up to be a more noble and honorable man than his father. Yours truly, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted you to know that I tried to see you, but they would not allow it. Not family, they said. As if love needs permission. But I will not give up hope. Bi mare volu, un oxit solu -- P.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Darling -- the bastards are pressuring me to make a show of fealty to the new regime. No matter what you see or read in there, know that in my heart there is only one true King of Rizia, and that's my son. Love always, Estela.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_FuneralHappened == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true || RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[233]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Your daughter told you that the new leadership had forced her to sign a document renouncing her claim to the throne. In exchange, she and Axel were allowed to live in Pales in peace.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[363]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_Rizia_Unification == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[237]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that life in Pales was good, and that she and Axel were trying to get you extradited to the Grand Duchy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[238]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela when she came to see you for the first time since you were arrested. A threat to nobody, she'd been granted a modest residence of her own in Porte Drazon.

Vina wasn't with her. Your mother assured you she'd visit when she was ready.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[272]`

### Węzeł `[239]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that she and Rico had filed for divorce. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[240]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that she and Manus were fighting to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[241]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

They told you that they were doing anything they can to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[242]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela when she came to see you for the first time since you were arrested.

A threat to nobody, she'd been granted a modest residence of her own in Porte Drazon, not far from the palace.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[272]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Narrator**
> "You heard rumors that King Hugo Toras was garnering respect from older citizens, who hailed him as "The Protector King."

According to the Royal Herald, he was championing education and traditional values."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[267]`
  - -> `[268]`

### Węzeł `[247]`
Mówca: **Narrator**
> "You heard rumors that Queen Angelica Sazon garnered much respect from the Rizian gentry. 

According to the Royal Herald, she championed liberal values without losing sight of tradition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[267]`
  - -> `[270]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Narrator**
> "You heard rumors that King Ricardus Toras had instilled a newfound sense of nationalism and monarchism in Rizia. 

According to the Royal Herald, he was about to institute strict border bans and incorporate Su Omina into the kingdom's national security forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[267]`
  - -> `[268]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Narrator**
> "You heard rumors that Queen Lucita Azaro's popularity had extended beyond Cardesse-Montaklar, overshadowing the legacy of House Toras. 

According to the Royal Herald, she planned to expand the powers of the Rizian Armed Forces, giving them a greater role in government even during peacetime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[267]`
  - -> `[270]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[262]`
Mówca: **Narrator**
> "You heard rumors that King Taddeus Azaro infused a newfound sense of militarism and monarchism in Rizia. 

According to the Royal Herald, he planned to expand the powers of the Rizian Armed Forces, giving them a greater role in government even during peacetime."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[267]`
  - -> `[268]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == false  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == false && (RiziaDLC.Reform_Path == true || RiziaDLC.Adarfo_AbdicationPath == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == false  and  (Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.Adarfo_AbdicationPath"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing the reformists and their collaborators across Rizia.

The reform movement, once a beacon of hope, had withered into nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[81]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You couldn't care less."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed his name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the King."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You cursed her name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...listened in silence, unsure what to feel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...missed your daughter more than anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...clung to her every word, desperate to know about the world outside your four walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...said they shouldn't waste their time on false hope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...smiled, knowing that even in prison, you were not forgotten."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nodded, but all you wanted was to see your son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  Variable["RiziaDLC.Coup_Leader_Rico"] == true  or  Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  or  Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true || RiziaDLC.Coup_Leader_Hugo == true || RiziaDLC.Coup_Leader_Rico == true || RiziaDLC.Coup_Leader_Lucita == true || RiziaDLC.Coup_Leader_Taddeus == true || RiziaDLC.Coup_Leader_Angelica == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  Variable["RiziaDLC.Coup_Leader_Rico"] == true  or  Variable["RiziaDLC.Coup_Leader_Lucita"] == true  or  Variable["RiziaDLC.Coup_Leader_Taddeus"] == true  or  Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Rumors seeped through the prison walls. The Crown's forces were crushing the unrest and all reformist collaborators across Rizia.

The reform movement, once a beacon of hope, had withered into nothing but a stillborn dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[81]`
  - -> `[295]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "At least order had been restored."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[296]`
Mówca: **Narrator**
> "The next day, you received news of the Palesian forces' unconditional surrender.

Newspapers were filled with images of Axel Reinhart, bound and escorted by Rizian soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Narrator**
> "The next day, you received news that the war had come to an end -- not in conquest, but in compromise. Rizia and Pales had agreed to settle with pre-war borders, neither side claiming victory.

Newspapers were filled with images of Axel Reinhart, walking tall as he left the negotiation table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[300]`
Mówca: **Narrator**
> "The next day, a chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN moved swiftly to contain the crisis, but their intervention did little to stop the unraveling of peace. Instead, tensions exploded across Eastern Merkopa, igniting a continental conflict.

The Pales-Rizia war, once a regional struggle, turned into another battleground in a far greater catastrophe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_WorldWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_WorldWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_WorldWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_WorldWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[304]`
**[WYBÓR GRACZA: "1965|Rizia"]** — Mówca: **Narrator**
> "Little by little, your legacy dissolved into obscurity. 

The eight years you spent as king became little more than a footnote in history, while you remained trapped in the past.

Estela's visits became less and less frequent as her health failed. Then, they stopped entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true || BaseGame.Ending_RumburgWarLost == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  or  Variable["BaseGame.Ending_RumburgWarLost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[308]`
Mówca: **Narrator**
> "Days later, the news reached your cell: War had broken out between Rumburg and Sordland.

The toll was already steep, with no end in sight. While the battles themselves were distant, the war's impact was felt in Rizia, where Rumburgian refugees were reluctant to return to their ravaged homeland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[309]`
  - -> `[316]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You worried about the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[313]`
Mówca: **Narrator**
> "The next day, a chilling announcement halted the continent: a devastating nuclear exchange had ravaged Holsord and parts of Rumburg.

The AN moved swiftly to contain the crisis, but their intervention did little to stop the unraveling of peace. Instead, tensions exploded across Eastern Merkopa, igniting a continental conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "War, war never changes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were happy you didn't have to clean up the mess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wished you could take charge of the situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[271]`
  - -> `[277]`
  - -> `[318]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...nodded, but all you wanted was to see Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Years passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Prison_Revolution_Surrounded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Prison_Revolution_Surrounded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true || RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[330]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "A year later, Vina visited once more, bringing along a surprise: her baby daughter Lena, named after her grandmother.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[336]`
  - -> `[339]`
  - -> `[393]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[332]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor: Vina.

After the war ended, she had finally been allowed to leave Pales. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[337]`
  - -> `[336]`
  - -> `[338]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true && BaseGame.Ending_WorldWar == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["BaseGame.Ending_WorldWar"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...embraced her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...couldn't hold back your tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for everything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...wished the best for them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...urged her to go elsewhere, knowing she'd never truly be safe at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[342]`
**[WYBÓR GRACZA: "1970|Rizia"]** — Mówca: **Narrator**
> "Inside the walls of your cell, time had no meaning. The days blurred together, indistinguishable from one another.

You had nothing left but your thoughts—fragments of a life that once was, replayed over and over, growing fainter and fainter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until it faded away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until one day, the cell door opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You felt your mind slipping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Death In Prison)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Death In Prison])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Until one day, the cell door opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rom -- the new regime reinstituted the homosexuality ban, and your brute of a bodyguard turned me in immediately. No matter what happens to either of us, I love you and regret nothing. Bi mare volu, un oxit solu -- P.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true  or  Variable["RiziaDLC.LateGameCoup_TitusBetrays"] == true)  and  Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_TitusBetrays == true || RiziaDLC.LateGameCoup_TitusBetrays == true) && RiziaDLC.Turn05_MurderInvest_SuspectPabel == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_TitusBetrays"] == true  or  Variable["RiziaDLC.LateGameCoup_TitusBetrays"] == true)  and  Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rom -- the new regime reinstituted the homosexuality ban, and I made it out of the country just in time. If you're ever released, find me in Derdia. Bi mare volu, un oxit solu -- P.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Long live the Queen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that life in the newly reunited Province of Pales was flourishing.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...apologized for all the trouble she'd gone through because of you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[367]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. She and Axel were trying hard to get you extradited to the Grand Duchy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[363]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Coup_Leader_Hugo"] == false  and  Variable["RiziaDLC.Coup_Leader_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true && RiziaDLC.Coup_Leader_Hugo == false && RiziaDLC.Coup_Leader_Rico == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Coup_Leader_Hugo"] == false  and  Variable["RiziaDLC.Coup_Leader_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[371]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. Now that she no longer had to carry on the royal bloodline, she and Rico had filed for divorce. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[363]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[375]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you that the new leadership had forced her to sign a document renouncing her claim to the throne. In exchange, she and Manus were allowed to live in Porte Drazon in peace. They were trying to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[363]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[379]`
Mówca: **Narrator**
> "After months, your family was finally given allowance to visit you in prison.

You embraced Estela and Vina when they came to see you for the first time since you were arrested.

Vina told you she'd been forced to sign an official document renouncing her claim to the throne. She and her grandmother were now doing everything they could to get you amnesty.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[274]`
  - -> `[275]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[383]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor, a woman you barely recognized. Vina.

After her escape from Palas Rezna, she'd traveled from country to country before secretly moving in with Manus in Kyrute. They now had a daughter together: Lena.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[336]`
  - -> `[338]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_ConvinceToLeave == true || RiziaDLC.Manus_ThreatenToLeave == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_ConvinceToLeave"] == true  or  Variable["RiziaDLC.Manus_ThreatenToLeave"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.LenaTooltip = "Your granddaughter.")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.LenaTooltip"] ="Your granddaughter.";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[388]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "Some time later, you received a surprise visitor, a woman you barely recognized. Vina.

After her escape from Palas Rezna, she'd traveled from country to country before settling down as a commoner in Kyrute.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[336]`
  - -> `[338]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[392]`
**[WYBÓR GRACZA: "1959|Porte Drazon"]** — Mówca: **Narrator**
> "A year later, Vina finally visited you. Although she still didn't want to be close with you, there was someone she wanted you to meet: her new baby daughter, Lena.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[336]`
  - -> `[338]`
  - -> `[393]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...felt bitter that you couldn't watch her grow up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true && RiziaDLC.BirthdayGathering_HouseStrike_Success == false) || RiziaDLC.Epilogue_Prison_HugoSendsToPrison == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true  and  Variable["RiziaDLC.BirthdayGathering_HouseStrike_Success"] == false)  or  Variable["RiziaDLC.Epilogue_Prison_HugoSendsToPrison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Epilogue_Death");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Death");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Epilogue_Prison");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Epilogue_Prison");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_DiedInPrison = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_DiedInPrison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
