# Sordland/Turn10/Denis Challenge

- **ID konwersacji:** `239`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/239_Denis_Challenge.md`
- **Liczba węzłów dialogowych:** 70
- **Liczba wyborów gracza:** 12

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[22]** Denis Stahler

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_MansounLeke`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- Węzeł `[18]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false; Variable["BaseGameIsolated.Debate...`

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
  - -> `[70]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[4]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[6]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[25]`
  - -> `[17]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[11]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[12]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[14]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[16]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""The Red Youth was out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth was out of control. You should have done something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[26]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[29]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[32]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[38]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[39]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[43]`
  - -> `[52]`
  - -> `[47]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[37]`

### Węzeł `[54]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[64]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[68]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[69]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[70]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
