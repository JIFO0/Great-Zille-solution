# Sordland/Turn10/DINNER WHOLE FAMILY (GOOD)

- **ID konwersacji:** `221`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/221_DINNER_WHOLE_FAMILY_(GOOD).md`
- **Liczba węzłów dialogowych:** 475
- **Liczba wyborów gracza:** 112

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
- `BaseGame.Enable_WomensRightsBill_Strong`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Media_Censored`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn05_P_Vineyard`
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
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Exile_WholeFamilyWithYou`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[53]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 20

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[444]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[445]` (Paskal Beniwoll): `Variable["BaseGame.Exile_WholeFamilyWithYou"] = true;`
- Węzeł `[446]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[447]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[448]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[449]` (Paskal Beniwoll): `Variable["BaseGame.Exile_MonicaDeanaWithYou"] = true;`
- Węzeł `[450]` (Paskal Beniwoll): `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- Węzeł `[451]` (Paskal Beniwoll): `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[17]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[53]`

### Węzeł `[3]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We'll go to our vineyard in Erlory.""]** — Mówca: **Player**
> ""We'll go to our vineyard in Erlory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Deana scratched her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Vineyard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I'm so proud of us for getting through it all together.""]** — Mówca: **Player**
> ""I'm so proud of us for getting through it all together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[26]`

### Węzeł `[12]`
Mówca: **Monica**
> ""I truly think it's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for now.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[81]`
  - -> `[83]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I'm so grateful to all of you for supporting me through it all.""]** — Mówca: **Player**
> ""I'm so grateful to all of you for supporting me through it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[26]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I know I haven't been there for any of you as much as I should have.""]** — Mówca: **Player**
> ""I know I haven't been there for any of you as much as I should have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[34]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and children.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[34]`

### Węzeł `[22]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""We deserve to celebrate.""]** — Mówca: **Player**
> ""We deserve to celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We deserve some time off together as a family.""]** — Mówca: **Player**
> ""We deserve some time off together as a family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[31]`
Mówca: **Monica**
> ""I'd like that. What about you, Deana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""I hope I can make it up to you someday.""]** — Mówca: **Player**
> ""I hope I can make it up to you someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a normal family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a normal family again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Monica's eyes were shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[50]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Deana! How was school today?""]** — Mówca: **Player**
> ""Deana! How was school today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She hugged me back happily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[52]`

### Węzeł `[45]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[43]`
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[47]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[48]`
Mówca: **Monica**
> ""No. The Anton Rayne I married wouldn't give up so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[49]`
Mówca: **Narrator**
> "When we were done, I went up to my study and started drafting my retirement speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Once the election's over, I'm taking you all on holiday.""]** — Mówca: **Player**
> ""Once the election's over, I'm taking you all on holiday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I sat down and began writing my announcement that I was retiring from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""How was school today?""]** — Mówca: **Player**
> ""How was school today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
Mówca: **Narrator**
> "The four of us dug into our food and started talking about what we'd do once I was no longer President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[57]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[58]`
Mówca: **Deana**
> ""She's in the kitchen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[62]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our plans for my next term. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Monica**
> ""I suppose you don't have much of a chance of re-election, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that after my presidency ends.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that after my presidency ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Monica, Franc and Deana turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""You three go ahead. I have to write my retirement speech.""]** — Mówca: **Player**
> ""You three go ahead. I have to write my retirement speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[73]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[74]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[87]`

### Węzeł `[75]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[76]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[16]`
  - -> `[11]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[16]`
  - -> `[11]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[20]`
  - -> `[16]`
  - -> `[11]`

### Węzeł `[84]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[85]`
Mówca: **Franc**
> ""Sure it will. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[86]`
Mówca: **Franc**
> ""Great. Amazing. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[72]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our plans for my retirement. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[92]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Deana smiled and pointed to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Monica, Franc and Deana looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[98]`
Mówca: **Deana**
> ""Mama's in there. I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[99]`
Mówca: **Deana**
> ""I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Monica smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[101]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[102]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[103]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[105]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[169]`
  - -> `[172]`
  - -> `[474]`

### Węzeł `[106]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[109]`
Mówca: **Narrator**
> "I stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[114]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Yes. For you three.""]** — Mówca: **Player**
> ""Yes. For you three.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Yes. For Sordland.""]** — Mówca: **Player**
> ""Yes. For Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[123]`
Mówca: **Narrator**
> "The four of us finished our food in silence. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[124]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[125]`
Mówca: **Monica**
> ""The ends don't justify the means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Monica whirled around in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Monica**
> ""And every day you stay in government gives your opponents more chances to smear your reputation -- and ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Monica slammed her hand down on the table, surprising the three of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "When she realized it was me, she smiled and gave me a kiss on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[135]`
Mówca: **Monica**
> ""My God, Anton. You think it's that bad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[136]`
Mówca: **Monica**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[139]`
Mówca: **Narrator**
> "Monica frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[140]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[141]`
Mówca: **Franc**
> ""Great. Amazing. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[142]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know I'm still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[147]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for a while.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[144]`
Mówca: **Monica**
> ""We're going to have to have a serious talk about the things you did while in office, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""You're right. I won't do it again.""]** — Mówca: **Player**
> ""You're right. I won't do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[146]`
Mówca: **Monica**
> ""Sorry, Anton. I guess I've been on edge lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[148]`
Mówca: **Monica**
> ""It's settled then. You'll fight and you'll win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""You won't be able to fight for women's rights from a cell. Or a grave.""]** — Mówca: **Player**
> ""You won't be able to fight for women's rights from a cell. Or a grave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Monica smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[155]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[159]`
Mówca: **Monica**
> ""Yes, of course. Just walk in a little more loudly next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[160]`
Mówca: **Monica**
> ""I'm disappointed in you, Anton. But I can't force you to go on if you don't want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica, Franc and Deana slowly followed suit, looking puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[81]`
  - -> `[83]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
Mówca: **Monica**
> ""I still can't believe nobody got hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[166]`
Mówca: **Monica**
> ""I still can't believe Serge is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[167]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our holiday plans. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[168]`
Mówca: **Franc**
> ""Go Dad. I believe in you. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
Mówca: **Monica**
> ""Why don't you go fix yourself a drink in the living room? I'll let you know when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Monica**
> ""Anton, I think you should stop. Not just drop out of the election -- quit politics entirely..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[221]`
  - -> `[216]`

### Węzeł `[177]`
Mówca: **Narrator**
> "I sat down in the living room, poured myself a bit of whiskey and flipped through one of Monica's women's magazines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica, Franc and Deana looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[81]`
  - -> `[83]`

### Węzeł `[179]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[180]`
Mówca: **Monica**
> ""I'm disappointed, but I can't force you to continue a fight you've got no interest in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[181]`
Mówca: **Monica**
> ""The best? You think that witch Lileas will continue our women's rights reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[185]`
Mówca: **Monica**
> ""Good. Because I'll be damned if that witch Lileas tears down our progress on women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[187]`
Mówca: **Narrator**
> "It took me a second to realize Monica herself was on the cover. The headline: "Sordland's Woman of the Year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[188]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[192]`
Mówca: **Monica**
> ""No. The things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[193]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[153]`

### Węzeł `[194]`
Mówca: **Monica**
> ""I-- you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[195]`
Mówca: **Monica**
> ""You may be right. I just hate the idea of losing all the progress we've made...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[199]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Narrator**
> "The three of us gathered around the dining room table. Monica ladled out bowls full of zabla. The stew tasted as good as it smelled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[161]`
  - -> `[178]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[204]`
Mówca: **Monica**
> ""Of course I don't want to lose the progress we've made for women -- but I'm afraid that'll happen anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[207]`
Mówca: **Deana**
> ""Yeah! Franc, are you coming too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[208]`
Mówca: **Monica**
> ""You never did know when to give up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[209]`
Mówca: **Monica**
> ""I'm looking forward to that, Anton. After everything that's happened... it's really for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[213]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[215]`
Mówca: **Franc**
> ""Yes. Great. More family time. For now, can we finish dinner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[7]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Honestly, I've been having similar thoughts.""]** — Mówca: **Player**
> ""Honestly, I've been having similar thoughts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[217]`
**[WYBÓR GRACZA: ""Nobody will listen to you once I'm out of office. Sorry.""]** — Mówca: **Player**
> ""Nobody will listen to you once I'm out of office. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""I-- you're right. I don't know what I'm talking about.""]** — Mówca: **Player**
> ""I-- you're right. I don't know what I'm talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""I can't. I've come too far.""]** — Mówca: **Player**
> ""I can't. I've come too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""What? Why?""]** — Mówca: **Player**
> ""What? Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will both of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Monica gave me a look of gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[226]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[227]`
Mówca: **Monica**
> ""Think of everything you've accomplished. And everything you have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[228]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[229]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[230]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[234]`
Mówca: **Deana**
> ""They've been making fun of me at school because of you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[235]`
**[WYBÓR GRACZA: ""I'm sorry. But this is for the best.""]** — Mówca: **Player**
> ""I'm sorry. But this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[236]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[214]`

### Węzeł `[237]`
Mówca: **Narrator**
> "Monica and Deana grinned at each other. Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[238]`
Mówca: **Deana**
> ""Where are we gonna go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`
  - -> `[8]`

### Węzeł `[239]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[240]`
Mówca: **Monica**
> ""Deana, you don't have to worry about that. The things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[241]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[217]`

### Węzeł `[242]`
Mówca: **Deana**
> ""Yeah, Papa. You've gotta stay strong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[220]`

### Węzeł `[243]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""Okay. You've made your point. I'll retire.""]** — Mówca: **Player**
> ""Okay. You've made your point. I'll retire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Sorry, Monica. I've got to keep going.""]** — Mówca: **Player**
> ""Sorry, Monica. I've got to keep going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[246]`
Mówca: **Monica**
> ""Of course not, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[247]`
Mówca: **Monica**
> ""I still don't think you should have let that witch Lileas win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Ladies' choice.""]** — Mówca: **Player**
> ""Ladies' choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""We'll go to the Benfi coast.""]** — Mówca: **Player**
> ""We'll go to the Benfi coast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[258]`
Mówca: **Monica**
> ""You being President -- it hasn't been easy on any of us. Maybe we could go back to the way things were before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[259]`
Mówca: **Narrator**
> "Monica's brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[260]`
Mówca: **Monica**
> ""Everything *we* have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[261]`
Mówca: **Monica**
> ""With everything that's happened... I don't think the public is on your side anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as we can.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""We could stay here. But we don't have to. We can go anywhere we want.""]** — Mówca: **Player**
> ""We could stay here. But we don't have to. We can go anywhere we want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[267]`
Mówca: **Monica**
> ""And the things you did as President... maybe this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[268]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Suddenly, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Franc**
> ""Sorry I'm late. Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[277]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[278]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[296]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[280]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[281]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[282]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[283]`
Mówca: **Franc**
> ""Sorry I'm late. I ran into a couple of my friends protesting outside. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[284]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[286]`
Mówca: **Franc**
> ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[287]`
Mówca: **Narrator**
> "Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Before I could respond, Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[289]`
Mówca: **Narrator**
> "Franc glared at me. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[290]`
Mówca: **Narrator**
> "Franc smirked. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[291]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[292]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[280]`

### Węzeł `[293]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[294]`
**[WYBÓR GRACZA: ""Too close.""]** — Mówca: **Player**
> ""Too close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[295]`
Mówca: **Franc**
> ""Don't look so surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[296]`
**[WYBÓR GRACZA: ""So that's still going on.""]** — Mówca: **Player**
> ""So that's still going on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[297]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[298]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[302]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[306]`
Mówca: **Franc**
> ""Yeah. I hope his family's doing okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[311]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[279]`

### Węzeł `[312]`
Mówca: **Franc**
> ""Don't you worry. I've seen what fatherhood does to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[313]`
Mówca: **Franc**
> ""We're certainly being more careful than you've been with your treatment of her people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[314]`
Mówca: **Franc**
> ""Yes, no thanks to you. One of her uncles was almost killed during that business at the dam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[318]`
Mówca: **Franc**
> ""Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[319]`
Mówca: **Deana**
> ""Franc! Franc!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Franc**
> ""Hey, pipsqueak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Narrator**
> "The two of them ignored me for a moment and started chatting away about their schools."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Monica appeared in the doorway and smiled warmly at the sight of the three of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[323]`
Mówca: **Franc**
> ""Come on, Mom. None of us know what these people are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[324]`
**[WYBÓR GRACZA: ""I'm not going anywhere without you.""]** — Mówca: **Player**
> ""I'm not going anywhere without you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[325]`
**[WYBÓR GRACZA: ""I'll come back soon.""]** — Mówca: **Player**
> ""I'll come back soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[326]`
Mówca: **Narrator**
> "I had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[327]`
Mówca: **Narrator**
> "When we were done, we cleared our plates and went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""I'll call all the time.""]** — Mówca: **Player**
> ""I'll call all the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[329]`
Mówca: **Narrator**
> "I put that thought out of my mind as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[332]`
Mówca: **Monica**
> ""And Anton, you and I are going to have a serious talk once this has blown over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[366]`

### Węzeł `[333]`
Mówca: **Franc**
> ""Mom, are you kidding? This could be a huge mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[334]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[335]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[336]`
Mówca: **Narrator**
> "We had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[337]`
Mówca: **Narrator**
> "I took a last look at Monica, Franc and Deana as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[338]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[339]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[340]`
Mówca: **Monica**
> ""It's better this way, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[328]`

### Węzeł `[341]`
Mówca: **Monica**
> ""Then the Raynes are staying put.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[342]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[351]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[344]`
**[WYBÓR GRACZA: ""No, we don't have time.""]** — Mówca: **Player**
> ""No, we don't have time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[345]`
Mówca: **Narrator**
> "The four of us ate in tense silence. I wondered if this would be our last dinner together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[346]`
Mówca: **Monica**
> ""I'm sorry, Franc. I'm not going to uproot our lives here because of mistakes your father made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[347]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[348]`
Mówca: **Narrator**
> "The four of us finished our food in silence. When we had cleared the plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[349]`
Mówca: **Monica**
> ""We're not going anywhere, Deana. Only your father is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[350]`
Mówca: **Deana**
> ""Papa, no! You can't leave us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""No, I don't have time.""]** — Mówca: **Player**
> ""No, I don't have time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[352]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[353]`
Mówca: **Deana**
> ""But what about school? What about my friends?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Deana**
> ""Cool! We're going on an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[355]`
Mówca: **Monica**
> ""You'll make lots of new friends. And Kyrute's school system is a lot better than Sordland's, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""In a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""In a week. I need to make sure our tracks are covered first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""In a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""In a week. I need to make sure our tracks are covered first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""Tomorrow morning. I've got to get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. I've got to get packing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[360]`
Mówca: **Franc**
> ""This is crazy, Dad. When do you want to leave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[357]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""Tomorrow morning. Let's get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. Let's get packing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[362]`
Mówca: **Narrator**
> "Monica's face paled. She nodded silently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[363]`
**[WYBÓR GRACZA: ""All right, all right. Let's finish dinner.""]** — Mówca: **Player**
> ""All right, all right. Let's finish dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[364]`
Mówca: **Narrator**
> "We hurriedly cleared our plates. Monica, Deana and I went up to our rooms, while Franc went back to his dormitory to collect his things."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[365]`
Mówca: **Monica**
> ""When will you leave, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[356]`
  - -> `[324]`

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I've lost my appetite. I'll see you two later.""]** — Mówca: **Player**
> ""I've lost my appetite. I'll see you two later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[367]`
Mówca: **Narrator**
> "We ate in tense silence. I could tell Monica, Franc and Deana were all deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[368]`
Mówca: **Franc**
> ""Something like that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[369]`
Mówca: **Franc**
> ""Yeah, it's bad. And my professors are saying it could get a lot worse. I wouldn't mind leaving for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[370]`
Mówca: **Monica**
> ""The ends don't justify the means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[372]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Franc**
> ""Good choice, Mom. Dad, we can't just uproot our lives because of your mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[374]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Monica**
> ""We're not going anywhere, Deana. Only your father is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[376]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[377]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[384]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since everyone at Holsord State found out how I really got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Narrator**
> "Franc gave me a pointed look. Deana still looked uncertain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[386]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since Anton Rayne became the enemy of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[387]`
Mówca: **Franc**
> ""It's an outcast, Dee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Narrator**
> "Monica's face paled. She nodded silently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[391]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Deana**
> ""But what about school? What about my friends?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[394]`
**[WYBÓR GRACZA: ""So be it. Monica and Deana, we'll leave in a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""So be it. Monica and Deana, we'll leave in a week. I need to make sure our tracks are covered first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[395]`
Mówca: **Narrator**
> "We had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[396]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[406]`

### Węzeł `[397]`
Mówca: **Narrator**
> "When we were done, Franc took a cab back to Holsord State and Monica, Deana and I rushed up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[398]`
Mówca: **Monica**
> ""You'll make lots of new friends. And Kyrute's school system is a lot better than Sordland's, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[399]`
Mówca: **Franc**
> ""I'll come visit once you're settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[401]`
Mówca: **Franc**
> ""This is crazy. Mom, Dad, you do what you want, but I'm staying put.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[394]`

### Węzeł `[402]`
Mówca: **Narrator**
> "We hurriedly cleared our plates. Franc took a cab back to Holsord State while Monica, Deana and I went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[403]`
Mówca: **Narrator**
> "We ate in tense silence. I could tell Monica, Franc and Deana were all deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[404]`
**[WYBÓR GRACZA: ""So be it. Monica and Deana, we leave tomorrow morning. Let's get packing.""]** — Mówca: **Player**
> ""So be it. Monica and Deana, we leave tomorrow morning. Let's get packing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[405]`
Mówca: **Deana**
> ""Cool! We're going on an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[406]`
**[WYBÓR GRACZA: ""No, we don't have time.""]** — Mówca: **Player**
> ""No, we don't have time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[410]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[411]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[412]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[420]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Narrator**
> "Deana looked slightly confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[433]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[434]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[435]`
Mówca: **Franc**
> ""Sure, as long as we don't go anywhere lame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[439]`
Mówca: **Franc**
> ""Maybe. You know I've been studying twice as hard to prove myself since everyone found out how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[440]`
Mówca: **Franc**
> ""Sure. It's gonna be chaos on campus anyway no matter who wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_WholeFamilyWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_MonicaDeanaWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[452]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as we can.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[453]`
**[WYBÓR GRACZA: ""We could stay here. But we don't have to. We can go anywhere we want.""]** — Mówca: **Player**
> ""We could stay here. But we don't have to. We can go anywhere we want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[461]`
Mówca: **Monica**
> ""I suppose the politics world might not take you seriously after your presidency ends, anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[470]`
Mówca: **Narrator**
*(Węzeł logiki narracyjnej: Narrator: "...")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[474]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
