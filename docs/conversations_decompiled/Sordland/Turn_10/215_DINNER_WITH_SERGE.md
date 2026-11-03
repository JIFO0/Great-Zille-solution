# Sordland/Turn10/DINNER WITH SERGE

- **ID konwersacji:** `215`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/215_DINNER_WITH_SERGE.md`
- **Liczba węzłów dialogowych:** 251
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Public_Opinion`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`
- `BaseGameIsolated.Turn10_FinalSupper_GameOff`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[47]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 12

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[144]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- Węzeł `[175]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[199]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- Węzeł `[231]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[232]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[238]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[239]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[246]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- *...oraz 4 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[47]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[4]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Once we were inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[23]`
Mówca: **Narrator**
> "The guards formed a cordon to let Serge and me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "We hurried past them and went inside. I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "Look at the guards more closely."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "We rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Serge, want a beer?""]** — Mówca: **Player**
> ""Serge, want a beer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Sorry about the mess in here.""]** — Mówca: **Player**
> ""Sorry about the mess in here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""I'd make dinner, but I don't have any food in the fridge.""]** — Mówca: **Player**
> ""I'd make dinner, but I don't have any food in the fridge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Serge Wolkner**
> ""I'd love one, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Serge Wolkner**
> ""No problem at all, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Serge glanced around the house. With Monica and the children's belongings gone and my work documents spread everywhere, it barely resembled a home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> ""It must be hard for you, a lion living without your lioness. Mrs. Rayne was a good woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Too good for me.""]** — Mówca: **Player**
> ""Too good for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I can get along just fine without her.""]** — Mówca: **Player**
> ""I can get along just fine without her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""You didn't know her like I did. I'm glad she's out of here.""]** — Mówca: **Player**
> ""You didn't know her like I did. I'm glad she's out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Serge gave me a sorrowful look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Serge Wolkner**
> ""Don't you worry, Mr. Rayne. You'll find another woman deserving of your greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[55]`
  - -> `[59]`
  - -> `[62]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""You still think I'm great? After I almost got you killed?""]** — Mówca: **Player**
> ""You still think I'm great? After I almost got you killed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WYBÓR GRACZA: ""You still think I'm great? After everything I've done?""]** — Mówca: **Player**
> ""You still think I'm great? After everything that's come out about me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Serge, you're a greater man than I'll ever be.""]** — Mówca: **Player**
> ""Serge, you're a greater man than I'll ever be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> ""It would have been an honor to die in the service of President Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> ""Whatever you did, I know you had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Thanks. I'm sure I will too.""]** — Mówca: **Player**
> ""Thanks. I'm sure I will too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> ""You humble me, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "We went into the living room and settled into our chairs. The game was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> ""Sir!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Serge Wolkner**
> ""Sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> ""See, sir? The football team thinks you're great as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""That's because I own them.""]** — Mówca: **Player**
> ""That's because I own them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""See, sir? The Sordish people think you're great as well.""]** — Mówca: **Serge Wolkner**
> ""See, sir? The Sordish people think you're great as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Anrica does, anyway.""]** — Mówca: **Player**
> ""Anrica does, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I can't even watch a goddamn football game anymore!""]** — Mówca: **Player**
> ""I can't even watch a goddamn football game anymore!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why can't they just stick to kicking the ball around? Why bring politics into it?""]** — Mówca: **Player**
> ""Why can't they just stick to kicking the ball around? Why bring politics into it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Sorry. I suddenly lost my interest in football.""]** — Mówca: **Player**
> ""Sorry. I suddenly lost my interest in football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Narrator**
> "FC Anrica was playing marvellously. But as the game went on, I found my attention waning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> ""Is something on your mind, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> ""You know you can talk to me about anything, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I don't think I want another term.""]** — Mówca: **Player**
> ""I don't think I want another term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I can't wait till I can leave this all behind.""]** — Mówca: **Player**
> ""I can't wait till I can leave this all behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I don't think I can win this election.""]** — Mówca: **Player**
> ""I don't think I can win this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I don't know if I can make it to the end of my term.""]** — Mówca: **Player**
> ""I don't know if I can make it to the end of my term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Serge Wolkner**
> ""Come on, Mr. Rayne. That's no way to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I lost my family, Serge.""]** — Mówca: **Player**
> ""I lost my family, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""I lost my best friend, Serge.""]** — Mówca: **Player**
> ""I lost my best friend, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
**[WYBÓR GRACZA: ""I almost lost you, Serge.""]** — Mówca: **Player**
> ""I almost lost you, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""And I think the military is still plotting against me.""]** — Mówca: **Player**
> ""And I think the military is still plotting against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[93]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""And I'm about to get crucified for giving half our country to Rumburg.""]** — Mówca: **Player**
> ""And I'm about to get crucified for giving half our country to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Not to mention that the Court's about to have me impeached.""]** — Mówca: **Player**
> ""Not to mention that the Court's about to have me impeached.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""And I think things are about to get a whole lot worse.""]** — Mówca: **Player**
> ""And I think things are about to get a whole lot worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Who or what else am I going to have to sacrifice before this is over?""]** — Mówca: **Player**
> ""Who or what else am I going to have to sacrifice before this is over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""But you're right. I should try to think positively.""]** — Mówca: **Player**
> ""But you're right. I should try to think positively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Serge Wolkner**
> ""You listen here, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Serge Wolkner**
> ""The Anton Rayne I met four years ago would never have fallen victim to self-defeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Serge smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Serge Wolkner**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Serge Wolkner**
> ""He was strong. Brave. Full of hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[118]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't wait for my next term.""]** — Mówca: **Player**
> ""I can't wait for my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Serge smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Serge Wolkner**
> ""That sounds like the Anton Rayne I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`
  - -> `[154]`
  - -> `[141]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""He was a naive idiot.""]** — Mówca: **Player**
> ""He was a naive idiot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[126]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""He was a liar.""]** — Mówca: **Player**
> ""He was a liar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[126]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""He was. And I still am.""]** — Mówca: **Player**
> ""He was. And I still am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[119]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""But sometimes being brave means knowing when to throw in the towel.""]** — Mówca: **Player**
> ""But sometimes being brave means knowing when to throw in the towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Serge. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Serge. I'll stick out the rest of my term for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Serge. I'll keep going for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Serge. I'll keep going for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""But you're right. I've made it this far. I've got to keep going.""]** — Mówca: **Player**
> ""But you're right. I've made it this far. I've got to keep going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I've got to face facts, Serge. It's over.""]** — Mówca: **Player**
> ""I've got to face facts, Serge. It's over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""But I've made it this far. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""But I've made it this far. I'll stick out the rest of my term for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[131]`
Mówca: **Serge Wolkner**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[179]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I'm leaving Sordland.""]** — Mówca: **Player**
> ""I'm leaving Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[136]`
Mówca: **Narrator**
> "Serge looked at me, his eyes shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""I'm going to do everything right this time.""]** — Mówca: **Player**
> ""I'm going to do everything right this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""I'm going to crush *all* my enemies.""]** — Mówca: **Player**
> ""I'm going to crush *all* my enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I'm going to get back at those bastards that tried to kill us.""]** — Mówca: **Player**
> ""I'm going to get back at those bastards that tried to kill us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Serge Wolkner**
> ""Of course you will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""I'm going to get my wife and kids back.""]** — Mówca: **Player**
> ""I'm going to get my wife and kids back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> ""But no matter what happens, I want you to know it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[149]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Thanks. I've still got some beers if you want to stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks. And sorry I broke the TV. I've still got some beers if you want to stay for a drink or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Serge leaned over and switched off the TV. He looked at me with probing eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Serge Wolkner**
> ""That sounds like the Anton I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[149]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Maybe this would be my year after all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[160]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[161]`
Mówca: **Serge Wolkner**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "After showing Serge to the door, I sat and thought for a while longer. His confidence in me was touching. But was it enough?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[167]`
  - -> `[245]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> "I hoped Serge wouldn't be too mad at me for letting him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[172]`
Mówca: **Narrator**
> "If only for Serge's sake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[173]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[176]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Serge would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Serge would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Serge's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I'm retiring from politics. Full stop.""]** — Mówca: **Player**
> ""I'm retiring from politics. Full stop.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I'm retiring from politics. My mind is made up.""]** — Mówca: **Player**
> ""I'm retiring from politics. My mind is made up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Serge frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Serge Wolkner**
> ""All right, sir. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[192]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[191]`
**[WYBÓR GRACZA: ""Thanks. I've still got some beers if you want to stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks. I've still got some beers if you want to stay for a drink or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[193]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[194]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Serge Wolkner**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[198]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_GameOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[200]`
Mówca: **Narrator**
> "My presidency was coming to an end. But for this evening, at least, it didn't matter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[201]`
Mówca: **Narrator**
> "I walked Serge to the door, then went upstairs. I still had some work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[202]`
Mówca: **Serge Wolkner**
> ""What? Sir, you can't just...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Now that I'd said it, it seemed like the most obvious solution in the world. The gears in my head started spinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I could easily reach, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""That's it. I'm leaving for Kyrute right now.""]** — Mówca: **Player**
> ""That's it. I'm leaving for Kyrute right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""]** — Mówca: **Player**
> ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""And you're coming with me.""]** — Mówca: **Player**
> ""And you're coming with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""I won't ask you to come with me. I know you've got your family.""]** — Mówca: **Player**
> ""I won't ask you to come with me. I know you've got your family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Serge Wolkner**
> ""Sir, you know how much I enjoy being your driver, but I can't leave my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[212]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Serge looked stunned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[211]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[220]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""All right, I understand. I'll go alone, then.""]** — Mówca: **Player**
> ""All right, I understand. I'll go alone, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""That's an order, not a request.""]** — Mówca: **Player**
> ""That's an order, not a request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Serge looked stunned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Serge Wolkner**
> ""President Rayne, I've been happy to serve you, but this is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Narrator**
> "He backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation, but I really must be leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[223]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. I ought to start packing now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[219]`
Mówca: **Serge Wolkner**
> ""I-- I suppose it's a fittingly bold move for a bold President such as yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. Stay for a beer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Well, fuck you too, Serge!""]** — Mówca: **Player**
> ""Well, fuck you too, Serge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I'm sorry. I was joking. Stay for a beer?""]** — Mówca: **Player**
> ""I'm sorry. I was joking. Stay for a beer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I'm sorry. I didn't mean that. Thank you for everything, Serge.""]** — Mówca: **Player**
> ""I'm sorry. I didn't mean that. Thank you for everything, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Serge smiled uncomfortably and ran out the door to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Narrator**
> "Serge gaped at me in outrage. He ran out the door to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Narrator**
> "I watched him go, then opened a beer for myself and got busy packing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[227]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Serge Wolkner**
> ""Of course, sir. Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Once we had drained our glasses, I showed him to the door. Then, I got busy packing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[164]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "Start planning for the end of your presidency."]** — Mówca: **Player_Italic**
> "I went upstairs to my office and started working again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Narrator**
> "I only had a few months left as President of Sordland. I had to make them count."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[84]`
  - -> `[113]`

### Węzeł `[243]`
**[WYBÓR GRACZA: ""I can't wait for a fresh start in politics.""]** — Mówca: **Player**
> ""I can't wait for a fresh start in politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""What's the point of continuing in politics?""]** — Mówca: **Player**
> ""What's the point of continuing in politics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "Stop contemplating and go to bed."]** — Mówca: **Player_Italic**
> "I willed myself to stop thinking so hard. I was tired. That was all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
