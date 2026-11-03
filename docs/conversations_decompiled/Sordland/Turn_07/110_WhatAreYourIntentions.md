# Sordland/Turn07/WhatAreYourIntentions

- **ID konwersacji:** `110`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/110_WhatAreYourIntentions.md`
- **Liczba węzłów dialogowych:** 119
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Law_Veto_Removed`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[111] Sordland/Turn07/WhatIsYourNextMove** (../Turn_07/111_WhatIsYourNextMove.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 17

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[16]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[46]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[50]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[58]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[74]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- *...oraz 9 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `111` (*Sordland/Turn07/WhatIsYourNextMove*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[6]`
Mówca: **Isabel Edmonds**
> ""Tell me, Mr. President. What are your real intentions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[8]`
  - -> `[9]`
  - -> `[7]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I'm trying not to lose the support of the people. This is their will.""]** — Mówca: **Player**
> ""I'm trying not to lose the support of the people. This is their will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I know that I can't do a lot. But I'm doing my best to start the change.""]** — Mówca: **Player**
> ""I know that I can't do a lot. But I'm doing my best to start the change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""I only want a strong Sordland.""]** — Mówca: **Player**
> ""I only want a strong Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""We need a better democracy. That's all I'm striving for.""]** — Mówca: **Player**
> ""We need a better democracy. That's all I'm striving for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[11]`
Mówca: **Isabel Edmonds**
> ""I see your intentions but this is not the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""The threshold is what keeps the extremist parties outside.""]** — Mówca: **Player**
> ""The threshold is what keeps the extremist parties outside the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""The Assembly is the most democratic institution that we have.""]** — Mówca: **Player**
> ""The Assembly is the most democratic institution that we have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "She smiled a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[15]`
Mówca: **Isabel Edmonds**
> ""But what happens when they have no checks on them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[27]`
  - -> `[48]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""So is that your intention after all? Bringing parliamentary democracy to Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[95]`
  - -> `[106]`

### Węzeł `[25]`
Mówca: **Isabel Edmonds**
> ""You are giving the Assembly all the authority with this proposal with no checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[26]`
Mówca: **Isabel Edmonds**
> ""That's not really convincing, is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We must eventually transform into the parliamentary system.""]** — Mówca: **Player**
> ""We must eventually transform into the parliamentary system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""Better democracy by eliminating the Justices whenever you want? By binding the Court to the Assembly to do their bidding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> ""The Constitution must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""I don't see how this proposal democratizes anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Isabel Edmonds**
> ""I completely disagree with that. Not all decisions made by the majority are supposed to be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""The MP's are elected. If they have a majority, then we must respect that decision.""]** — Mówca: **Player**
> ""The MP's are elected. If they have a majority, then we must respect that decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[36]`
Mówca: **Isabel Edmonds**
> ""For some reason, I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""I think that era is closing. We have many popular parties now.""]** — Mówca: **Player**
> ""I think that era is closing. We have many popular parties now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You are right to have concerns. But this is the way forward.""]** — Mówca: **Player**
> ""You are right to have concerns. But this is the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[42]`
Mówca: **Isabel Edmonds**
> ""...But let's say this proposal goes through...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[47]`
Mówca: **Isabel Edmonds**
> ""Starting a change by eliminating the Justices whenever you want? Is this the change?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""There are still checks and balances.""]** — Mówca: **Player**
> ""There are still checks and balances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Veto_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Veto_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[55]`
Mówca: **Isabel Edmonds**
> ""Strong? You are weakening both the executive and the judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[56]`
Mówca: **Isabel Edmonds**
> ""I don't see any in this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[57]`
Mówca: **Isabel Edmonds**
> ""I don't see how this proposal helps with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[62]`
Mówca: **Isabel Edmonds**
> ""Maybe you are right about that. But I still don't think if this proposal would help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[63]`
Mówca: **Isabel Edmonds**
> ""Then why would you not include a decrease in our election threshold that everybody outside of your own party finds ridiculous?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Isabel Edmonds**
> ""I like your honesty, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Isabel Edmonds**
> ""Oh yes. People wanted the Supreme Court Justices to be impeached by the Assembly whenever they want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[66]`
Mówca: **Isabel Edmonds**
> ""Maybe you only care about a certain part of the population, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[99]`
  - -> `[101]`
  - -> `[103]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Not my intention. But if there is demand, we must consider it.""]** — Mówca: **Player**
> ""Not my intention. But if there is demand, we must consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[69]`
Mówca: **Isabel Edmonds**
> ""But this will also result in the same, Mr. President. What happens if a party holds an absolute majority in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[37]`
  - -> `[35]`

### Węzeł `[70]`
Mówca: **Isabel Edmonds**
> ""I am sure this is what takes up everybody's mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[71]`
Mówca: **Isabel Edmonds**
> ""I guess it's a fitting description.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Isabel Edmonds**
> ""I don't find it believable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[73]`
Mówca: **Isabel Edmonds**
> ""Interesting. But I am not sure if this proposal would help with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""Is that what you call it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Is the elective dictatorship we have is better?""]** — Mówca: **Player**
> ""Is the elective dictatorship we have is better?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[79]`
Mówca: **Isabel Edmonds**
> ""Of course it's not your intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""I thought you would agree to that. I believed that respectable Justices like you are against the Old Guard.""]** — Mówca: **Player**
> ""I thought you would agree to that. I believed that respectable Justices like you are against the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""It depends on the circumstances.""]** — Mówca: **Player**
> ""It depends on the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""This will pave the way for a parliamentary democracy.""]** — Mówca: **Player**
> ""This will pave the way for a parliamentary democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[85]`
Mówca: **Isabel Edmonds**
> ""How? This is an attack against the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[87]`
Mówca: **Isabel Edmonds**
> ""Look. I am in opposition to them and definitely stand against their dominance. But this is not the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Yes. We must eventually decrease the threshold.""]** — Mówca: **Player**
> ""Yes. We must eventually decrease the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Yes. That is the future for Sordland.""]** — Mówca: **Player**
> ""Yes. That is the future for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[90]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[91]`
Mówca: **Isabel Edmonds**
> ""Is that one of your intentions then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[81]`
  - -> `[68]`

### Węzeł `[92]`
Mówca: **Isabel Edmonds**
> ""Why did you include that in the proposal, knowing that you need our vote?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[80]`
  - -> `[93]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I thought the Court could see reason.""]** — Mówca: **Player**
> ""I thought the Court could see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[94]`
Mówca: **Isabel Edmonds**
> ""What a convincing answer, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I think the presidential system is what damaged our republic.""]** — Mówca: **Player**
> ""I think the presidential system is what damaged our republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[96]`
Mówca: **Isabel Edmonds**
> ""The proposal doesn't contain any democratic reforms about the elections, decrees nor the minister procedures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I don't think this is the right time for such reform. It can create a political crisis.""]** — Mówca: **Player**
> ""I don't think this is the right time for such reform. It can create a political crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Isabel Edmonds**
> ""I actually agree with that. We can't let the Malenyevist nor separatist parties to enter the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""That can be addressed later.""]** — Mówca: **Player**
> ""That can be addressed later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[102]`
Mówca: **Isabel Edmonds**
> ""You can't just throw words like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Sometimes that's the sad reality. I need to care for myself and the party too.""]** — Mówca: **Player**
> ""Sometimes that's the sad reality. I need to care for myself and the party too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[104]`
Mówca: **Isabel Edmonds**
> ""Well, that's true to some extent. Don't get me wrong, I am not against the current threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""The Assembly has long been overshadowed. They need all the power to make laws.""]** — Mówca: **Player**
> ""The Assembly has long been overshadowed. They need all the power to make laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""That's not my intention but my hope for the future.""]** — Mówca: **Player**
> ""That's not my intention but my hope for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[107]`
Mówca: **Isabel Edmonds**
> ""I don't agree with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[13]`
  - -> `[84]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I've had to take my chances. We need it to clean up the Old Guard.""]** — Mówca: **Player**
> ""I've had to take my chances. We need it to clean up the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[112]`
Mówca: **Isabel Edmonds**
> ""Perhaps this proposal is only making you stronger. And a little too strong at that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true && (BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true) && (BaseGame.Reform_Law_Decrees_Default == true || BaseGame.Reform_Law_Decrees_Stronger == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true  and  (Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true)  and  (Variable["BaseGame.Reform_Law_Decrees_Default"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[117]`
Mówca: **Isabel Edmonds**
> ""Oh yes. People wanted to make you king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
