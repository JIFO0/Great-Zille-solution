# Sordland/Turn10/DINNER WHOLE FAMILY (BAD)

- **ID konwersacji:** `220`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/220_DINNER_WHOLE_FAMILY_(BAD).md`
- **Liczba węzłów dialogowych:** 309
- **Liczba wyborów gracza:** 72

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Media_Censored`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[52]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[295]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[296]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[297]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[302]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- Węzeł `[303]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- Węzeł `[304]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[52]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard hesitant footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[16]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She reluctantly accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Deana! How is school?""]** — Mówca: **Player**
> ""Deana! How is school?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Deana mutely gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Deana**
> ""I'll be in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How's school?""]** — Mówca: **Player**
> ""How's school?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Deana ignored my comment and gestured vaguely towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Deana**
> ""Mama's in there. I'll be up in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs, thinking about the days when she idolized me. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I hesitantly stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Walk back out and wait for Franc in the living room."]** — Mówca: **Player_Italic**
> "I walked back out and went to wait for Franc in the living room. I didn't want to disturb her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Monica whirled around in surprise. Her eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know we're all still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! Go wait in the living room. I'll tell you when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I'm sorry. I'll go wait in the living room.""]** — Mówca: **Player**
> ""I'm sorry. I'll go wait in the living room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Monica**
> ""No. Not if he's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "I walked back out and sat on the living room sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I awkwardly flipped through one of Monica's women's magazines. I felt like an intruder in my own home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Suddenly, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Franc**
> ""Sorry I'm late. Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[65]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Franc**
> ""Sorry I'm late. I ran into a couple of my friends protesting outside. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[64]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[67]`
Mówca: **Franc**
> ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[68]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""So that's still going on.""]** — Mówca: **Player**
> ""So that's still going on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Franc**
> ""Yes, no thanks to you. One of her uncles was almost killed during that business at the dam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Franc**
> ""We're certainly being more careful than you've been with your treatment of her people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Franc**
> ""Don't you worry. I've seen what fatherhood does to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Franc**
> ""Don't look so surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Franc smirked. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Franc glared at me. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[84]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[61]`

### Węzeł `[85]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[86]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[87]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
Mówca: **Franc**
> ""I know. I can't believe he's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[93]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[94]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I know. I still can't believe nobody was hurt.""]** — Mówca: **Player**
> ""I know. I still can't believe nobody was hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[99]`
Mówca: **Franc**
> ""This time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Before I could respond, Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Deana**
> ""Franc!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Franc**
> ""Hey, pipsqueak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "He ruffled her hair. I thought about how much time had passed since we'd all been together under one roof."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Monica emerged from the kitchen and gave Franc a big hug. As she turned back to me, the warmth drained from her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "The four of us gathered around the dining room table. Monica ladled out bowls full of beef stew -- not my favorite, but a comforting dish nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica, Franc and Deana slowly followed suit, looking puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica, Franc and Deana looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own family.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[117]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I let my power get to my head. I became unrecognizeable to myself -- and to all of you.""]** — Mówca: **Player**
> ""I let my power get to my head. I became unrecognizable to myself -- and to all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I've done some unforgivable things. Especially to you, Monica.""]** — Mówca: **Player**
> ""I've done some unforgivable things. Especially to you, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[117]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I hope I can redeem myself someday.""]** — Mówca: **Player**
> ""I hope I can redeem myself someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Monica looked at me sadly. She slowly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[123]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I swear to you all, I'll learn from my mistakes during my next term.""]** — Mówca: **Player**
> ""I swear to you all, I'll learn from my mistakes during my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""As a first step towards that, I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""As a first step towards that, I'm retiring from politics at the end of this term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[299]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I swear to you all, once I'm retired things will go back to the way they used to be.""]** — Mówca: **Player**
> ""I swear to you all, once I'm retired things will go back to the way they used to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Everyone turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[133]`
  - -> `[136]`
  - -> `[308]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Deana frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since everyone at Holsord State found out how I really got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Franc gave me a pointed look. Deana still looked uncertain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since Anton Rayne became the enemy of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Franc**
> ""It's an outcast, Dee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[154]`
Mówca: **Franc**
> ""We're supposed to uproot our entire lives because you screwed up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Monica slammed a hand down on the table. We all turned to look at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[157]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Monica**
> ""Nobody's going anywhere. Except you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Narrator**
> "Monica scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Monica**
> ""No, sweetie. Your father's imagining things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Monica**
> ""The only person in danger is him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[169]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[174]`
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Everyone at the table looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Monica, now is not the time. We've got to get out of here.""]** — Mówca: **Player**
> ""Monica, now is not the time. We've got to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Your mother is right. We're divorcing immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right. We're divorcing immediately after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[178]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Monica**
> ""No, Anton. You've dug your own grave. You've got to deal with this yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Narrator**
> "She looked up. Her face was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Monica**
> ""Go, Anton. I think it's better this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[188]`
  - -> `[182]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""No. Not without my family.""]** — Mówca: **Player**
> ""No. Not without my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[183]`
Mówca: **Monica**
> ""You're not even running anymore. Why should it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Monica**
> ""If you're leaving the country, the election doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[188]`
**[WYBÓR GRACZA: ""All right. I'm leaving in a week. I have to make sure my tracks are covered first.""]** — Mówca: **Player**
> ""All right. I'm leaving in a week. I have to make sure my tracks are covered first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[189]`
**[WYBÓR GRACZA: ""All right. I'm leaving tomorrow.""]** — Mówca: **Player**
> ""All right. I'm leaving tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[190]`
Mówca: **Franc**
> ""Dad, where are you going to go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Kyrute. And you kids can visit whenever you want.""]** — Mówca: **Player**
> ""Kyrute. And you kids can visit whenever you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'd rather not tell you. For safety reasons.""]** — Mówca: **Player**
> ""I'd rather not tell you. For safety reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[194]`
Mówca: **Monica**
> ""Then leave this house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""It's the presidential complex. I'm the President, remember?""]** — Mówca: **Player**
> ""It's the presidential complex. I'm the President, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Fine. I will.""]** — Mówca: **Player**
> ""Fine. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[197]`
Mówca: **Franc**
> ""Uh... All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Franc**
> ""I guess good luck, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Narrator**
> "Deana still looked slightly dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Deana**
> ""Yeah. Good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Narrator**
> "I drained my glass and left the table. I had packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Tears appeared in Monica's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Monica**
> ""Please, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Franc and Deana watched silently as I got up from the table. Finally, Franc spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Franc**
> ""Uh, I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "I put that thought out of my mind as I left. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[210]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Kids, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Kids, don't listen to her. Everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[217]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[216]`
  - -> `[218]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""I will. And I'm dropping out of politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm dropping out of politics, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Fine. But I'm not retiring. History will remember me as the best leader Sordland ever had.""]** — Mówca: **Player**
> ""Fine. But I'm not retiring. History will remember me as the best leader Sordland ever had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Franc**
> ""Uh, I guess... good luck, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Deana**
> ""Yeah. Good luck!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Instead, I started thinking about how I would announce my decision to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[244]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[248]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[249]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[254]`
  - -> `[255]`

### Węzeł `[252]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Kids, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Kids, don't listen to her. Everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[258]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[262]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[263]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[266]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""I will. And I'm still dropping out of the election, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still dropping out of the election, no matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[265]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[267]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Instead, I started thinking about where I wanted to go for my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[271]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[275]`
Mówca: **Monica**
> ""Don't worry, we won't make it public until then. I just wanted Franc and Deana to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[277]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[278]`

### Węzeł `[278]`
**[WYBÓR GRACZA: ""Your mother is right, kids. We're getting divorced -- immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right, kids. We're getting divorced -- immediately after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[283]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Maybe the next term really could be better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Monica**
> ""Oh, sweetheart. It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[286]`
**[WYBÓR GRACZA: ""I will. I'll see you later, kids.""]** — Mówca: **Player**
> ""I will. I'll see you later, kids.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[289]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[290]`

### Węzeł `[290]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
**[WYBÓR GRACZA: ""I swear to you all, I'll learn from my mistakes during the next administration.""]** — Mówca: **Player**
> ""I swear to you all, I'll learn from my mistakes during the next administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[308]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
