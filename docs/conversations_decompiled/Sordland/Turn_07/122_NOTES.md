# Sordland/Turn07/NOTES

- **ID konwersacji:** `122`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/122_NOTES.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 34

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[35]** Gus Manger
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_A`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGameIsolated.Turn07_CourtResults_PlansHub_A`

### Skoki między-konwersacyjne:
- Węzeł `[89]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[90]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[95]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[111]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[114]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[116]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`
- Węzeł `[137]` -> **[121] Sordland/Turn07/PlansHub** (../Turn_07/121_PlansHub.md), Węzeł `[44]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[129]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] = true;`
- Węzeł `[139]` (Paskal Beniwoll): `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Our priority will be the investigation of the Court. We'll start working on a defence.""]** — Mówca: **Player**
> ""Our priority will be the investigation of the Court. We'll start working on a defence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We proved our capabilities already. Now we are ready to enact more reforms.""]** — Mówca: **Player**
> ""We proved our capabilities already. Now we are ready to enact more reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""My next plan is to use my emergency powers to enact major reforms.""]** — Mówca: **Player**
> ""My next plan is to use my emergency powers to enact major reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 0  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 0 && BaseGameIsolated.Turn07_CourtResults_PlansHub_A == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 0  and  Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We must also do something about the BFF.""]** — Mówca: **Player**
> ""We must also do something about the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Next, I will start campaigning for a transition to parliamentary democracy.""]** — Mówca: **Player**
> ""Next, I will start campaigning for a transition to parliamentary democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""Soon I'll be enacting major reforms with my new powers.""]** — Mówca: **Player**
> ""Soon I'll be enacting major reforms with my new powers.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ConstitutionChanged)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ConstitutionFailed)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EmergencyContinues)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ImpeachmentPossibility)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EmergencyStopped)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA: ""We will start campaigning for bigger changes.""]** — Mówca: **Player**
> ""We will start campaigning for bigger changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Lucian nodded in agreement. Ciara gave me a mocking stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Lileas spread out her arms and looked at me in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Nia narrowed her eyes skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[114]`

### Węzeł `[42]`
Mówca: **Narrator**
> "The cabinet looked at me with curiosity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[43]`
Mówca: **Lileas Graf**
> ""This is getting ridiculous, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> ""The Constitution is not a toy. You can't just play with it and change it however you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Lileas Graf**
> ""With all due respect, I believe you are not seeing things clearly anymore, Mr. President. I'm concerned about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "As Petr was about to respond, Gus cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Gus Manger**
> ""In this rare occasion, I have to admit that I agree with Mrs. Graf here. It's important not to get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Gus Manger**
> ""Sordish reality is quite different than what's being said here. Let's not kid ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[65]`
  - -> `[64]`

### Węzeł `[49]`
Mówca: **Ciara Walda**
> ""I believe the decision that led to these investigations was taken without the counsel of Council of Ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Ciara Walda**
> ""And there is only one signature on that emergency decree, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Petr stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> ""What are you trying to say, Mrs. Walda? Don't overstep your boundaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Ciara Walda**
> ""I just don't see how we could be of any help under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[54]`
Mówca: **Lileas Graf**
> ""And what kind of changes are these?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[74]`
  - -> `[81]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I will campaign for the transition into a parliamentary system.""]** — Mówca: **Player**
> ""I will campaign for the transition into a parliamentary system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I will campaign for strengthening the executive further.""]** — Mówca: **Player**
> ""I will campaign for strengthening the executive further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Your lack of idealism is saddening. We can't develop if we don't even try.""]** — Mówca: **Player**
> ""Your lack of idealism is saddening. We can't develop if we don't even try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Nia spread out her arms and looked at me in disbelief. Just as she was about to speak, Lileas jumped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Lileas Graf**
> ""With all due respect, I believe you are not seeing things clearly anymore, Mr. President. I'm concerned about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We will continue our privatization and fully integrate Sordland into the free market.""]** — Mówca: **Player**
> ""We will continue our privatization and fully integrate Sordland into the free market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""The presidential system is flawed. Look at our history.""]** — Mówca: **Player**
> ""The presidential system is flawed. Look at our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I will hear no discussions. This will be our focus.""]** — Mówca: **Player**
> ""I will hear no discussions. This will be our focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[66]`
Mówca: **Lileas Graf**
> ""This is getting ridiculous, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""The Constitution is not a toy. You can't just play with it and change it however you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[68]`
Mówca: **Narrator**
> "As Petr was about to respond, Nia cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""In this rare occasion, I have to admit that I agree with Mrs. Graf here. It's important not to get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""I cannot let this country be shaped according to one man's ideals again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""I will hear no discussions. This will be our focus.""]** — Mówca: **Player**
> ""I will hear no discussions. This will be our focus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You can try to stop me. Don't forget that you are working for me.""]** — Mówca: **Player**
> ""You can try to stop me. Don't forget that you are working for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You are hurting me, Mrs. Morgna. Do you really see me as an authoritarian?""]** — Mówca: **Player**
> ""You are hurting me, Mrs. Morgna. Do you really see me as an authoritarian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""We will continue our nationalization and fully take control of the means of production.""]** — Mówca: **Player**
> ""We will continue our nationalization and fully take control of the means of production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""More social policies.""]** — Mówca: **Player**
> ""More social policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We will pursue the nationalisation of the means of production.""]** — Mówca: **Player**
> ""We will pursue the nationalization of the means of production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We will pursue further free market reforms.""]** — Mówca: **Player**
> ""We will pursue further free market reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""I see. Further destruction of our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[110]`
  - -> `[117]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Deivid looked at Gus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Deivid Wisci**
> ""Mr. President is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[93]`
Mówca: **Lileas Graf**
> ""I see. Very Bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Lileas Graf**
> ""Maybe too bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[96]`
Mówca: **Deivid Wisci**
> ""I fully support rewriting the whole Constitution and establish a more democratic parliamentary system in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[90]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Thank you for your support, Mr. Wisci.""]** — Mówca: **Player**
> ""Thank you for your support, Mr. Wisci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Nobody responded. Nia was furious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[99]`
Mówca: **Narrator**
> "He smiled. Nobody else responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""Yes, Mr. President. I will no longer be silent about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[107]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Fine. I will no longer stay idle about disloyalty either. We'll talk about this very soon.""]** — Mówca: **Player**
> ""Fine. I will no longer stay idle about disloyalty either. We'll talk about this very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""We'll talk about this later, Mrs. Morgna. Let's move on for now, shall we?""]** — Mówca: **Player**
> ""We'll talk about this later, Mrs. Morgna. Let's move on for now, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""You are showing the tendency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Frankly, I don't care. I've told you our focus and that's it.""]** — Mówca: **Player**
> ""Frankly, I don't care. I've told you our focus and that's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "She did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Nia Morgna**
> ""Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's not argue about this now, Mrs. Graf.""]** — Mówca: **Player**
> ""Let's not argue about this now, Mrs. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[112]`
Mówca: **Lileas Graf**
> ""Whatever you say, *Mr. President*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Why can't you be more like Lucian, Mrs. Walda?""]** — Mówca: **Player**
> ""Why can't you be more like Lucian, Mrs. Walda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Lucian nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. Our focus has been decided.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. Our focus has been decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Lucian stepped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""I'm already working on it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[113]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thank you Lucian. Please make sure the whole team is on the same page with us.""]** — Mówca: **Player**
> ""Thank you Lucian. Please make sure the whole team is on the same page with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I will be using my powers to their limits.""]** — Mówca: **Player**
> ""I will be using my powers to their limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[122]`
Mówca: **Ciara Walda**
> ""With all due respect, I'm not going to respond to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[123]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""Frankly, I don't care what you think. We have bigger problems here.""]** — Mówca: **Player**
> ""Frankly, I don't care what you think. We have bigger problems here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Lucian nodded. Nobody else responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[125]`
Mówca: **Iosef Lancea**
> ""Yes sir. It is of utmost importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Iosef stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I want Mrs. Graf to put the region of Bergia under heavy surveillance.""]** — Mówca: **Player**
> ""I want Mrs. Graf to put the region of Bergia under heavy surveillance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""I want to establish peace talks with the group.""]** — Mówca: **Player**
> ""I want to establish peace talks with the group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_CourtResults_PlansHub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_CourtResults_PlansHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[130]`
Mówca: **Lileas Graf**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> ""Sir, I would advise against it. They are our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I want you to just try and reach out to them. We should be diplomatic.""]** — Mówca: **Player**
> ""I want you to just try and reach out to them. We should be diplomatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lileas Graf**
> ""I can't believe you are justifying the murders of our Sordish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Lucian stepped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
> ""I'll look into it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Lileas Graf**
> ""So we're going to sit on a table with murderers now? No deal will benefit those who died in their acts of terror.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SecondPlan])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `121` (*Sordland/Turn07/PlansHub*), Węzeł `[44]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""They are fighting us because the state has never listened to them before.""]** — Mówca: **Player**
> ""They are fighting us because the state has never listened to them before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
