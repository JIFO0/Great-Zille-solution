# Sordland/Turn10/Denis Challenge

- **ID konwersacji:** `237`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/237_Denis_Challenge.md`
- **Liczba węzłów dialogowych:** 82
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
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Democratic`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Turn03_A_Protestors_Calm`
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

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[236] Sordland/Turn10/Bludish Issues + Scandals** (../Turn_10/236_Bludish_Issues_+_Scandals.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- Węzeł `[14]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false; Variable["BaseGameIsolated.Debate...`

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
  - -> `[69]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `236` (*Sordland/Turn10/Bludish Issues + Scandals*), Węzeł `[2]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[5]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[24]`
  - -> `[16]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[10]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[12]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[13]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[15]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""The Red Youth was out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth was out of control. You should have done something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[25]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[28]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[31]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[37]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[38]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[42]`
  - -> `[51]`
  - -> `[46]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[50]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[55]`
  - -> `[54]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[36]`

### Węzeł `[53]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[63]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[67]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[68]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[69]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[70]`
Mówca: **Narrator**
> "The moderator took a moment to regain her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic < -10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Calm == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Denis Stahler**
> ""You claimed to understand the plight of the common man back in Narbel. But it was all an act, wasn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[81]`
Mówca: **Denis Stahler**
> ""Ever since our confrontation in Narbel I've known exactly what kind of man you were, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
