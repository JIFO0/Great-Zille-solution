# Sordland/Turn07/IsabelPersuasion

- **ID konwersacji:** `112`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/112_IsabelPersuasion.md`
- **Liczba węzłów dialogowych:** 193
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Law_Veto_Limited`
- `BaseGame.Reform_Law_Veto_Removed`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[310]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 19

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[35]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[38]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[40]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[49]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[50]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[51]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[56]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[58]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- *...oraz 11 innych węzłów ze skryptami.*

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
  - -> `[66]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[310]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[6]`
Mówca: **Isabel Edmonds**
> ""Well... I actually have to say this too. I am really surprised that the proposal is abolishing the member of honor title. I support that part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[7]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[8]`
Mówca: **Isabel Edmonds**
> ""Sure, we just need to have *blind faith*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""If we were to come back to the point of unifying against the Old Guard...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Isabel Edmonds**
> ""I want the Old Guard gone as much as you, but I am torn about this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[135]`
  - -> `[140]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Why?""]** — Mówca: **Player**
> ""Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Nia suddenly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""The Court protects the Constitution. I would have done the same with my proposal today.""]** — Mówca: **Player**
> ""The Court protects the Constitution. I would have done the same with my proposal today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[20]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""Well... I actually have to say this. I am really surprised that you are bringing term limits. That's one good point of the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""I don't agree with that. I am no Malenyevist.""]** — Mówca: **Player**
> ""I don't agree with that. I am no Malenyevist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[26]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Purely an advisory body for legislation and the high criminal court.""]** — Mówca: **Player**
> ""Purely an advisory body for legislation and the high criminal court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""Well... At least you are bringing term limits. I guess that's one positive aspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""It must have the power of judicial review and to strike down laws that are against the Constitution.""]** — Mówca: **Player**
> ""It must have the power of judicial review and to strike down laws that are against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""Tell me... Are you planning to put Soll to trial?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[33]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> ""You are playing with fire, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""No. Even though I'm abolishing his position, he must be respected as the founder of our second republic.""]** — Mówca: **Player**
> ""No. Even though I'm abolishing his position, he must be respected as the founder of our second republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I have no such plans. The important thing here is now he will be a regular Sordish citizen.""]** — Mówca: **Player**
> ""I have no such plans. The important thing here is now he will be a regular Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Yes. He should be properly investigated and finally answer for his crimes.""]** — Mówca: **Player**
> ""Yes. He should be properly investigated and finally answer for his crimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""The threshold not only affects them but all of us. It can lead to a political crisis in the future.""]** — Mówca: **Player**
> ""The threshold not only affects them but all of us. It can lead to a political crisis in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""I am a democratic socialist, Mrs. Edmonds. There is a difference.""]** — Mówca: **Player**
> ""I am a democratic socialist, Mrs. Edmonds. There is a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I don't agree with their ideologies, but we must be fair.""]** — Mówca: **Player**
> ""I don't agree with their ideologies, but we must be fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
Mówca: **Isabel Edmonds**
> ""I don't want to hand a victory to a Malenyevist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[173]`
  - -> `[57]`

### Węzeł `[42]`
Mówca: **Isabel Edmonds**
> ""Anyway... At least the proposal introduces term limits. I can say that I support that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[43]`
Mówca: **Isabel Edmonds**
> ""These changes are one thing. But there is also your political view...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[47]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""We can't silence different political opinions anymore, Mrs. Edmonds.""]** — Mówca: **Player**
> ""We can't silence different political opinions anymore, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[52]`
Mówca: **Isabel Edmonds**
> ""I also like that the proposal introduces term limits. That's another good point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == true || BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""You must understand that it is the way forward.""]** — Mówca: **Player**
> ""You must understand that it is the way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""So what do you think about the judicial review?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[80]`
  - -> `[73]`

### Węzeł `[60]`
Mówca: **Isabel Edmonds**
> ""I didn't say that. But if we're not careful, we will become a puppet, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[61]`
Mówca: **Narrator**
> "She took a sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""I don't agree with that. We are not their puppet.""]** — Mówca: **Player**
> ""I don't agree with that. We are not their puppet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[63]`
Mówca: **Isabel Edmonds**
> ""I want to help you, Mrs. Morgna. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[64]`
Mówca: **Isabel Edmonds**
> ""Anyway, I don't have much else to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[65]`
Mówca: **Nia Morgna**
> ""So, Mrs. Edmonds... What are you thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true  and  Variable["BaseGame.Malenyevist"] >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromotePlanned == true && BaseGame.Malenyevist >= 17))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true  and  Variable["BaseGame.Malenyevist"] >= 17) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Isabel Edmonds**
> ""Anyway, I don't have much else to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  and  Variable["BaseGame.Capitalist"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromoteMarket == true && BaseGame.Capitalist >= 10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  and  Variable["BaseGame.Capitalist"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""It gives the Court an abrupt power over other branches.""]** — Mówca: **Player**
> ""It gives the Court an abrupt power over other branches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why are you asking me these questions?""]** — Mówca: **Player**
> ""Why are you asking me these questions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""These changes are one thing. But you also lead an alarming narrative...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[77]`
Mówca: **Isabel Edmonds**
> ""Right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[78]`
Mówca: **Isabel Edmonds**
> ""Yes... Sordland definitely gives presidents paranoia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""It plays an essential role in ensuring that each branch of government recognizes the limits of its own power.""]** — Mówca: **Player**
> ""It plays an essential role in ensuring that each branch of government recognizes the limits of its own power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[81]`
Mówca: **Isabel Edmonds**
> ""I am concerned about your heavy pursuit of capitalism. You are bringing Arcasia's influence to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[88]`
  - -> `[95]`

### Węzeł `[82]`
Mówca: **Narrator**
> "She coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Weren't you for Alphonso's free market reforms? Why are you suddenly against this?""]** — Mówca: **Player**
> ""Weren't you for Alphonso's free market reforms? Why are you suddenly against this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""I have to protect myself after my duty ends too. Sordland is dangerous for presidents.""]** — Mówca: **Player**
> ""I have to protect myself after my duty ends too. Sordland is dangerous for presidents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I disagree. Soll wasn't any trouble after he resigned. I think we deserve this title.""]** — Mówca: **Player**
> ""I disagree. Soll wasn't any trouble after he resigned. I think we deserve this title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Mrs. Edmonds. You are exaggerating it. It's only a symbolic title.""]** — Mówca: **Player**
> ""Mrs. Edmonds. You are exaggerating it. It's only a symbolic title.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""We need Arcasia's support as a country. They can be an important ally.""]** — Mówca: **Player**
> ""We need Arcasia's support as a country. They can be an important ally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[96]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about the Assembly. You are giving them too much power. How can we ensure that they will never go rogue in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Isabel Edmonds**
> ""The only one who wins here is you, Mr. President. What are you trying to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[106]`
  - -> `[146]`

### Węzeł `[98]`
Mówca: **Isabel Edmonds**
> ""Wasn't that even a concern for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[99]`
Mówca: **Isabel Edmonds**
> ""And what about the Assembly? You are giving them too much power. How can we ensure that they will never go rogue in the future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && (BaseGame.Reform_Law_Veto_Removed == true || BaseGame.Reform_Law_Veto_Limited == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Removed"] == true  or  Variable["BaseGame.Reform_Law_Veto_Limited"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[103]`
Mówca: **Isabel Edmonds**
> ""I find the growing Arcasian influence concerning. I supported the free market reforms earlier but you can't afford to be reckless like Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[104]`
Mówca: **Isabel Edmonds**
> ""What do you mean why? I asked you a question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[105]`
Mówca: **Isabel Edmonds**
> ""...If I give you the power to impeach us today... What's going to happen tomorrow? Can you even give me any guarantees that this will not result in the destruction of the Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[152]`
  - -> `[155]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""The President is elected by people and the title should not be taken away by anyone else.""]** — Mówca: **Player**
> ""The President is elected by people and the title should not be taken away by anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""There are still checks and balances. They can't go against the Constitution.""]** — Mówca: **Player**
> ""There are still checks and balances. They can't go against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Of course it was a concern. But this is a transition. The future lies in the parliamentary system.""]** — Mówca: **Player**
> ""Of course it was a concern. But this is a transition. The future lies in the parliamentary system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""No it's not. We have to believe in the MP's. The Assembly is our most democratic branch.""]** — Mówca: **Player**
> ""No it's not. We have to believe in the MP's. The Assembly is our most democratic branch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[116]`
Mówca: **Isabel Edmonds**
> ""This will also be a huge burden on the government to take care of every former President's lavish lifestyles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[92]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Don't be. We are together in this. This will open the way for further reforms too.""]** — Mówca: **Player**
> ""Don't be. We are together in this. This will open the way for further reforms too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[118]`
Mówca: **Isabel Edmonds**
> ""But what about giving yourself the Member of Honor title too? You are clearly playing a dangerous game here, Mr. President. We don't want another king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[92]`

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""This will also be a huge burden on the government to take care of every former President's lavish lifestyles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[92]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
Mówca: **Isabel Edmonds**
> ""I don't agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[125]`
Mówca: **Isabel Edmonds**
> ""Even a president who becomes another Tarquin Soll? Would you be okay if people elected a Malenyev here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Isabel Edmonds**
> ""I tried to stop it. But the Chief Justice was the puppet master. Alphonso didn't deserve that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""As I said before, it is only a safety mechanism for threats like the Old Guard.""]** — Mówca: **Player**
> ""As I said before, it is only a safety mechanism for threats like the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[129]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about making every president a member of honor. That title was created for Soll to protect himself. Not only dangerous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[131]`
Mówca: **Isabel Edmonds**
> ""Mr. President. I am also wondering... If you were in Soll's position, how would you have structured the Supreme Court? What do you even believe is its role?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[29]`
  - -> `[19]`
  - -> `[14]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about making every president a member of honor. That title was created for Soll to protect himself. Not only dangerous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Vote yes. There is not much to think.""]** — Mówca: **Player**
> ""Vote yes. There is not much to think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[136]`
Mówca: **Isabel Edmonds**
> ""And how about you? You are giving yourself total immunity... The only one who wins here is you, Mr. President. What are you trying to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[106]`
  - -> `[146]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Please, Mrs. Edmonds. We need your help.""]** — Mówca: **Player**
> ""Please, Mrs. Edmonds. We need your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[141]`
Mówca: **Isabel Edmonds**
> ""Let's just forget it and enjoy our meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[142]`
Mówca: **Narrator**
> "She looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true ||
BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or 
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""You know Sordish politics, Mrs. Edmonds. We have to protect the presidents. Remember Alphonso?""]** — Mówca: **Player**
> ""You know Sordish politics, Mrs. Edmonds. We have to protect the presidents. Remember Alphonso?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I had to protect myself from all the backlash from changing Soll's Constitution.""]** — Mówca: **Player**
> ""I had to protect myself from all the backlash from changing Soll's Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""You have nothing to worry about. The Justices cannot be impeached so easily.""]** — Mówca: **Player**
> ""You have nothing to worry about. The Justices cannot be impeached so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[153]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns. This proposal would pave the way for the WPB and the CPS to enter the Assembly... I don't want to be a supporter of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[39]`
  - -> `[36]`

### Węzeł `[154]`
Mówca: **Isabel Edmonds**
> ""You are an interesting man indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""I promise, Mrs. Edmonds. Centrists will have nothing to worry about. You have my word.""]** — Mówca: **Player**
> ""I promise, Mrs. Edmonds. Centrists will have nothing to worry about. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Isabel Edmonds**
> ""Let's just forget it and enjoy the remaining of our meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Isabel went on to finish the remaining of her salad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[164]`
Mówca: **Isabel Edmonds**
> ""I'm glad that we agree on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[165]`
Mówca: **Isabel Edmonds**
> ""...I still have great concerns about the removal of the President's impeachment procedure. The President is giving himself total immunity here...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Isabel Edmonds**
> ""So you'd rather have no Court, no balances or checks in our goverment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[171]`
Mówca: **Nia Morgna**
> ""I don't think that's what he meant, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[172]`
Mówca: **Isabel Edmonds**
> ""Fine. I am not asking any more questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Malenyev isn't the only communist theoretician, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Malenyev isn't the only communist theoretician, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Isabel Edmonds**
> ""So what? You're going to tell me you pursue Marco-Raynism or something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Isabel Edmonds**
> ""So what? You're going to tell me you pursue Valgslandian Socialism or something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Isabel Edmonds**
> ""So, you're no fan of Malenyev? Who cares if you're into Chancellor Hegel's Valgslandian Socialism, or Sordish socialism of Bernard Circas? It's all Karlos Marcia's socio-economics in the end...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[180]`
Mówca: **Isabel Edmonds**
> ""Who cares if you're into Chancellor Hegel's socialism, or Sordish socialism of Bernard Circas? It's all Karlos Marcia's socio-economics in the end...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[184]`
Mówca: **Narrator**
> "She let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Isabel Edmonds**
> ""Anyway... There's no point in discussing this with you at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
