# Sordland/Turn10/DINNER WITH PETR

- **ID konwersacji:** `214`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/214_DINNER_WITH_PETR.md`
- **Liczba węzłów dialogowych:** 313
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

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
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_PetrWithYou`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`
- `BaseGameIsolated.Turn10_FinalSupper_GameOff`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[46]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 13

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[34]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[101]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[127]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- Węzeł `[194]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- Węzeł `[273]` (Paskal Beniwoll): `Variable["BaseGame.Exile_PetrWithYou"] = true;`
- Węzeł `[296]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[297]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[298]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- *...oraz 5 innych węzłów ze skryptami.*

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[46]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Petr grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[7]`
Mówca: **Petr Vectern**
> ""Oh, you'd be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I walked him out, then got busy packing. My head was buzzing with excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[9]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I don't know if I can make it to the end of my term.""]** — Mówca: **Player**
> ""I don't know if I can make it to the end of the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I don't think I can win this election.""]** — Mówca: **Player**
> ""I don't think I can win this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Right away, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I can't wait till I can leave this all behind.""]** — Mówca: **Player**
> ""I can't wait till I can leave this all behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[17]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Petr would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Flee the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""I don't think I want another term.""]** — Mówca: **Player**
> ""I don't think I want another term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I can't wait for my next term.""]** — Mówca: **Player**
> ""I can't wait for my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""Talk to me, Anton. I know you've got something on your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Petr, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Petr, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[29]`
Mówca: **Narrator**
> "The guards formed a cordon to let Petr and me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[40]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[33]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Petr would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""That Anton Rayne was a liar.""]** — Mówca: **Player**
> ""That Anton Rayne was a liar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[209]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""Anton? Something on your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Petr leaned over and switched off the TV. He looked at me with serious eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[38]`
Mówca: **Petr Vectern**
> ""Now you listen here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Come on, Anton. Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[46]`
  - -> `[256]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "We rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[43]`
Mówca: **Narrator**
> "We hurried past them and went inside. I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[57]`
  - -> `[54]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Once we were inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[57]`
  - -> `[54]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Petr smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[19]`

### Węzeł `[50]`
Mówca: **Narrator**
> "I hoped Petr wouldn't be too mad at me for letting him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[51]`
Mówca: **Narrator**
> "If only for Petr's sake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I only had a few months left as President of Sordland. I had to make them count."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[53]`
Mówca: **Narrator**
> "A slow smile spread across Petr's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'd make dinner, but the chef has the night off and I don't have any food in the fridge.""]** — Mówca: **Player**
> ""I'd make dinner, but the chef has the night off and I don't have any food in the fridge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""Damn right you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""See? The football team still thinks you're great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[202]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Sorry about the mess in here.""]** — Mówca: **Player**
> ""Sorry about the mess in here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""See? You've still got a few fans in Sordland.""]** — Mówca: **Petr Vectern**
> ""See? You've still got a few fans in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I can't even watch a goddamn football game anymore!""]** — Mówca: **Player**
> ""I can't even watch a goddamn football game anymore!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "Start planning for the end of your presidency."]** — Mówca: **Player_Italic**
> "I went upstairs to my office and started working again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I don't think we have a choice.""]** — Mówca: **Player**
> ""I don't think we have a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Petr, want a beer?""]** — Mówca: **Player**
> ""Petr, want a beer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Now that's the Anton Rayne I know and love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[104]`
  - -> `[86]`
  - -> `[94]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I lost Serge.""]** — Mówca: **Player**
> ""I lost Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""I lost my wife, Petr.""]** — Mówca: **Player**
> ""I lost my wife, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[69]`
Mówca: **Petr Vectern**
> ""Whoa. Whoa! We're really doing this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[60]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Maybe this would be my year after all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why can't they just stick to kicking the ball around? Why bring politics into it?""]** — Mówca: **Player**
> ""Why can't they just stick to kicking the ball around? Why bring politics into it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Ha. You should see my place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
Mówca: **Narrator**
> "After showing Petr to the door, I sat and thought for a while longer. His confidence in me was touching. But was it enough?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[20]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""And you're coming with me.""]** — Mówca: **Player**
> ""And you're coming with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I won't ask you to come with me. I know you've got your life here.""]** — Mówca: **Player**
> ""I won't ask you to come with me. I know you've got your life here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Sorry. I suddenly lost my interest in football.""]** — Mówca: **Player**
> ""Sorry. I suddenly lost my interest in football.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Petr glanced around the house. With Monica and the children's belongings gone and my work documents spread everywhere, it barely resembled a home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[81]`
Mówca: **Narrator**
> "My presidency was coming to an end. But for this evening, at least, it didn't matter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[82]`
Mówca: **Narrator**
> "I walked Petr to the door, then went upstairs. I still had some work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Look at us. A couple of swinging bachelors, just like in the old days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`
  - -> `[228]`

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""And I'll be right there with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[28]`

### Węzeł `[85]`
Mówca: **Narrator**
> "FC Anrica was playing marvellously. But as the game went on, I found my attention waning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[89]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""Good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""I can get along just fine without her.""]** — Mówca: **Player**
> ""I can get along just fine without her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Too good for me.""]** — Mówca: **Player**
> ""Too good for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> ""The Anton Rayne I met in university would never have sat around feeling sorry for himself like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""I'm going to get my wife and kids back.""]** — Mówca: **Player**
> ""I'm going to get my wife and kids back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[95]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[96]`
Mówca: **Petr Vectern**
> ""Good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[97]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""He was strong. Brave. Full of hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[105]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
> ""Yeah, sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""I thought you'd never ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[103]`
Mówca: **Petr Vectern**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""I'm going to crush *all* my enemies.""]** — Mówca: **Player**
> ""I'm going to crush *all* my enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""It's true. I was strong. And I still am.""]** — Mówca: **Player**
> ""It's true. I was strong. And I still am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[211]`

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""Don't you worry. You'll find another woman deserving of the great Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[112]`
  - -> `[143]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Now that I'd said it, it seemed like the most obvious solution in the world. The gears in my head started spinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[172]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""That Anton Rayne was a naive idiot.""]** — Mówca: **Player**
> ""That Anton Rayne was a naive idiot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[209]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
> ""I thought you'd never ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[118]`
Mówca: **Petr Vectern**
> ""Yeah, sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Thanks, that means a lot. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thanks, that means a lot. Sorry I broke the TV, but you can still stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks, that means a lot. Sorry I broke the TV, but you can still stay for a drink or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WYBÓR GRACZA: ""You still think I'm great? After everything that's come out about me?""]** — Mówca: **Player**
> ""You still think I'm great? After everything that's come out about me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You still think I'm great? After losing the nomination to Lileas?""]** — Mówca: **Player**
> ""You still think I'm great? After losing the nomination to Lileas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[200]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[105]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[201]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Who says I don't have fun now? Sorry I broke the TV, but you can still stay for a drink or two.""]** — Mówca: **Player**
> ""Who says I don't have fun now? Sorry I broke the TV, but you can still stay for a drink or two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Thanks for that. If you don't mind, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks for that. If you don't mind, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Yes. That's it. I'm leaving for Kyrute tomorrow.""]** — Mówca: **Player**
> ""Yes. That's it. I'm leaving for Kyrute tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""]** — Mówca: **Player**
> ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Yes, I will. But tonight's not the time to start looking.""]** — Mówca: **Player**
> ""Yes, I will. But tonight's not the time to start looking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[150]`
Mówca: **Petr Vectern**
> ""Whoa there, cowboy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[74]`
  - -> `[79]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""Bummer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[74]`
  - -> `[79]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""That's because I own them.""]** — Mówca: **Player**
> ""That's because I own them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[155]`
Mówca: **Narrator**
> "We went into the living room and settled into our chairs. The game was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[156]`
Mówca: **Petr Vectern**
> ""That makes us both quitters, then. Somehow, I always thought you were better than me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""I'm going to get back at those bastards that tried to kill me.""]** — Mówca: **Player**
> ""I'm going to get back at those bastards that tried to kill me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
> ""You're what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I'm going to do everything right this time.""]** — Mówca: **Player**
> ""I'm going to do everything right this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Petr frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Petr's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""But you're right. I should try to think positively.""]** — Mówca: **Player**
> ""But you're right. I should try to think positively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Who or what else am I going to have to sacrifice before this is over?""]** — Mówca: **Player**
> ""Who or what else am I going to have to sacrifice before this is over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""I'm leaving Sordland.""]** — Mówca: **Player**
> ""I'm leaving Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'm not staying in politics after my presidency ends.""]** — Mówca: **Player**
> ""I'm not staying in politics after my presidency ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I'm retiring from politics. My mind is made up.""]** — Mówca: **Player**
> ""I'm retiring from politics. My mind is made up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""We'll get through this. You can count on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[28]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""And I think things are about to get a whole lot worse.""]** — Mówca: **Player**
> ""And I think things are about to get a whole lot worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Not to mention that the Court's about to have me impeached.""]** — Mówca: **Player**
> ""Not to mention that the Court's about to have me impeached.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[190]`
Mówca: **Petr Vectern**
> ""That sounds like the Anton I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_LileasResigned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_LileasResigned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_LileasResigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_LileasResigned == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_LileasResigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_FinalSupper_GameOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[198]`
Mówca: **Petr Vectern**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[187]`

### Węzeł `[199]`
Mówca: **Narrator**
> "Petr looked at me, his eyes glowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""And I'm about to get crucified for giving half our country to Rumburg.""]** — Mówca: **Player**
> ""And I'm about to get crucified for giving half our country to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""And I think the military is still plotting against me.""]** — Mówca: **Player**
> ""And I think the military is still plotting against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[203]`
**[WYBÓR GRACZA: ""In Anrica, anyway.""]** — Mówca: **Player**
> ""In Anrica, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""But you're right. I've made it this far. I've got to keep going.""]** — Mówca: **Player**
> ""But you're right. I've made it this far. I've got to keep going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""I've got to face facts, Petr. It's over.""]** — Mówca: **Player**
> ""I've got to face facts, Petr. It's over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[210]`
**[WYBÓR GRACZA: ""But I've made it this far. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""But I've made it this far. I'll stick out the rest of my term for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[211]`
**[WYBÓR GRACZA: ""But sometimes being strong means knowing when to throw in the towel.""]** — Mówca: **Player**
> ""But sometimes being strong means knowing when to throw in the towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Petr. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Petr. I'll stick out the rest of my term for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Petr. I'll keep going for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Petr. I'll keep going for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[215]`
Mówca: **Petr Vectern**
> ""Frozen TV dinners, my man! They're a game-changer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Petr raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Petr Vectern**
> ""Only if you don't have anything stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[221]`
Mówca: **Petr Vectern**
> ""Don't you remember? I'm sober as a nun these days. I'm healthier than I've ever been and so, so bored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[225]`
Mówca: **Petr Vectern**
> ""I'm sorry you didn't learn from my mistakes. She was a good woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""What woman would want us now?""]** — Mówca: **Player**
> ""What woman would want us now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Sure. Mothers, lock up your daughters.""]** — Mówca: **Player**
> ""Sure. Mothers, lock up your daughters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[228]`
**[WYBÓR GRACZA: ""I miss her, Petr.""]** — Mówca: **Player**
> ""I miss her, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[229]`
Mówca: **Petr Vectern**
> ""Just like Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[230]`
Mówca: **Petr Vectern**
> ""Very convincing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[231]`
Mówca: **Petr Vectern**
> ""I miss Evelyn, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[232]`
Mówca: **Petr Vectern**
> ""Don't beat yourself up about it. You know she only got that far with Soll's hand up her keister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[233]`
Mówca: **Petr Vectern**
> ""Like I haven't done worse?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""You still think I'm great? After getting my driver killed?""]** — Mówca: **Player**
> ""You still think I'm great? After getting my driver killed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I wouldn't count on that.""]** — Mówca: **Player**
> ""I wouldn't count on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""I'm sorry about Serge, But there was nothing you could have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Petr Vectern**
> ""So, how are things back at the office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Petr Vectern**
> ""You know what? Don't answer that. You deserve one night off from politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[245]`
Mówca: **Petr Vectern**
> ""Thanks for the invite, Anton. I think we both deserve a night off from politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Petr ducked into the kitchen and took two beers from the fridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Petr ducked into the kitchen and helped himself to some orange juice from the fridge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[251]`
Mówca: **Petr Vectern**
> ""I just wish I could be there to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[28]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""I can't wait for our next term.""]** — Mówca: **Player**
> ""I can't wait for our next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I might never see my kids again, Petr.""]** — Mówca: **Player**
> ""I might never see my kids again, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[257]`
Mówca: **Petr Vectern**
> ""I would have followed him to the ends of the earth. And I basically did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[35]`
  - -> `[106]`

### Węzeł `[258]`
Mówca: **Petr Vectern**
> ""I would have followed him to the ends of the earth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[35]`
  - -> `[106]`

### Węzeł `[259]`
Mówca: **Petr Vectern**
> ""Excuse me, but what life? Of course I'm coming with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[260]`
Mówca: **Petr Vectern**
> ""Anton, this could be exactly what both of us need. A fresh start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`
  - -> `[263]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""We're fleeing the country, not going on holiday.""]** — Mówca: **Player**
> ""We're fleeing the country, not going on holiday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I don't know. When you've messed up as badly as we have, there are no fresh starts.""]** — Mówca: **Player**
> ""I don't know. When you've messed up as badly as we have, there are no fresh starts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Exactly. Some mountain air, some vegetable farming, no godforskaken budget meetings ever again.""]** — Mówca: **Player**
> ""Exactly. Some mountain air, some vegetable farming, no godforsaken budget meetings ever again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Petr Vectern**
> ""Spoilsport.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[265]`
Mówca: **Petr Vectern**
> ""Bet you'll miss Lucian, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""Very funny.""]** — Mówca: **Player**
> ""Very funny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[267]`
**[WYBÓR GRACZA: ""I kind of will.""]** — Mówca: **Player**
> ""I kind of will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
**[WYBÓR GRACZA: ""Stay for a drink. Let's plan this out.""]** — Mówca: **Player**
> ""Stay for a drink. Let's plan this out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""Go home and start making your arrangements. I'll call you in the morning.""]** — Mówca: **Player**
> ""Go home and start making your arrangements. I'll call you in the morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""With pleasure, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Narrator**
> "We stayed up until late, planning our departure and our initial few nights of accommodation in Kyrute. By the end of it, I was excited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Narrator**
> "Maybe Petr was right. Maybe this could be a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_PetrWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_PetrWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Petr Vectern**
> ""But being your right-hand man is pretty much the only thing I've got left going for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Petr Vectern**
> ""I understand, though. I hope being retired means you'll actually get to have some fun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[137]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[285]`
Mówca: **Narrator**
> "I poured a beer for myself and a glass of juice for Petr. We raised our cups in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Just wish I could be there to see it through with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[28]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[294]`
Mówca: **Narrator**
> "I poured a beer for myself and a glass of juice for Petr. We raised our cups in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[295]`
**[WYBÓR GRACZA: "Go to bed."]** — Mówca: **Player_Italic**
> "I went upstairs and collapsed in my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[299]`
**[WYBÓR GRACZA: ""I don't want to stay in politics.""]** — Mówca: **Player**
> ""I don't want to stay in politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[300]`
**[WYBÓR GRACZA: ""I can't wait for a fresh start in politics once my term ends.""]** — Mówca: **Player**
> ""I can't wait for a fresh start in politics once my term ends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[14]`
  - -> `[252]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Turn10_PartyCongress_FormNewParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""I'm not running for re-election. I'm giving up politics.""]** — Mówca: **Player**
> ""I'm not running for re-election. I'm giving up politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
