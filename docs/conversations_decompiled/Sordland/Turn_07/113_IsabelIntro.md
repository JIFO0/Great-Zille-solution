# Sordland/Turn07/IsabelIntro

- **ID konwersacji:** `113`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/113_IsabelIntro.md`
- **Liczba węzłów dialogowych:** 151
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[149]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[35]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[58]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[61]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[93]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[126]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`

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
  - -> `[139]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[149]`

### Węzeł `[3]`
Mówca: **Isabel Edmonds**
> ""You must be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We both know that I will have a target on my back after this. I need that immunity.""]** — Mówca: **Player**
> ""We both know that I will have a target on my back after this. I need that immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Isabel Edmonds**
> ""Of course. This is all about you, Mr. President, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[9]`
Mówca: **Isabel Edmonds**
> ""With all due respect, Mr. President. I think you got ahead of yourself. Especially by trying to remove your impeachment procedure and giving yourself immunity. This is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[15]`
  - -> `[47]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[13]`
Mówca: **Isabel Edmonds**
> ""So that you can create your own *Old Guard* and kick everyone with opposing views? The Judiciary must be independent, Mr. President and the clause you removed was a prerequisite of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[14]`
Mówca: **Isabel Edmonds**
> ""The same assembly that your party controls, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[82]`
  - -> `[81]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""You're still not seeing the complete picture. This proposal is a step towards democratization.""]** — Mówca: **Player**
> ""You're still not seeing the complete picture. This proposal is a step towards democratization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""We both know that the Old Guard that dominates and obstructs the court needs to be dealt with.""]** — Mówca: **Player**
> ""We both know that the Old Guard that dominates and obstructs the court needs to be dealt with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""I'm not going to deny that. That is the situation.""]** — Mówca: **Player**
> ""I'm not going to deny that. That is the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Therefore, you will vote yes.""]** — Mówca: **Player**
> ""Therefore, you will vote yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Don't get ahead of yourself.""]** — Mówca: **Player**
> ""Don't get ahead of yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm sure we can make a deal.""]** — Mówca: **Player**
> ""I'm sure we can make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""Mr. President is aiming to destroy the Court and he needs us to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[22]`
Mówca: **Isabel Edmonds**
> ""That's a start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We don't want that.""]** — Mówca: **Player**
> ""We don't want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[25]`
Mówca: **Narrator**
> "She measured me with her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Isabel Edmonds**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""I'm not here to make a deal, Mr. President. I'm here to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Isabel Edmonds**
> ""...But it pains me to say that your proposal has a very low chance of getting through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[30]`
Mówca: **Isabel Edmonds**
> ""I hope you're not thinking about bribing a Supreme Court Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[31]`
Mówca: **Isabel Edmonds**
> ""First of all... Congratulations with the vote in the Grand National Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[32]`
Mówca: **Isabel Edmonds**
> ""It is you, Mr. President, who shouldn't get ahead of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[33]`
Mówca: **Narrator**
> "She stared at me for a few seconds. She seemed to be taken aback by my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[34]`
Mówca: **Isabel Edmonds**
> ""First of all, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[36]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds... Let's calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[40]`
Mówca: **Nia Morgna**
> ""Bribe? Who do you think we are, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[41]`
Mówca: **Isabel Edmonds**
> ""I admire your struggle. Especially because you were strong enough to include concessions from your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[46]`
Mówca: **Isabel Edmonds**
> ""Why should I vote for a proposal that will take away my immunity as a Justice? Was this the promised reform? Impeaching a Justice with the decision of the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""You oppose this because of that one simple clause?""]** — Mówca: **Player**
> ""You oppose this because of that one simple clause?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Isabel Edmonds**
> ""You made a very clever package, Mr. President. The real gain here is your immunity from impeachment. And...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""You take away our immunity and give it to yourself, and I'm opposing because of a little simple clause?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""But you like the proposal?""]** — Mówca: **Player**
> ""But you like the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[51]`
Mówca: **Isabel Edmonds**
> ""Democratization!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Isabel Edmonds**
> ""What about it? You are already trying to take our right to vote on constitutional legislature and also open a way to impeach us, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[53]`
Mówca: **Isabel Edmonds**
> ""You are really brave, Mr. President. Trying to go against Tarquin Soll's member of honor rights, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""And what do you think about the proposal itself?""]** — Mówca: **Player**
> ""And what do you think about the proposal itself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""You know it's true, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[60]`
Mówca: **Isabel Edmonds**
> ""Proper? You are already trying to take our right to vote on constitutional legislature and also open a way to impeach us, are you not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[62]`
Mówca: **Isabel Edmonds**
> ""This law will not only apply to them but all Justices, Mr. President. Who will protect our rights if you take away our immunity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[67]`
Mówca: **Isabel Edmonds**
> ""....Using Soll's membership laws for your own benefit? I have to say I don't really like this proposal, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[71]`
Mówca: **Isabel Edmonds**
> ""You need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[72]`
Mówca: **Isabel Edmonds**
> ""....No. I don't like the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Isabel Edmonds**
> ""To start with, I think it's disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Isabel Edmonds**
> ""I am perfectly aware that you need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""You are packaging it as a democratic reform, yet it smells like an attack against the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[76]`
Mówca: **Isabel Edmonds**
> ""You need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[77]`
Mówca: **Isabel Edmonds**
> ""So the current situation is clear...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[78]`
Mówca: **Isabel Edmonds**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
Mówca: **Isabel Edmonds**
> ""But now you face the Supreme Court. And it pains me to say that your proposal has a very low chance of getting through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[45]`
  - -> `[50]`
  - -> `[23]`

### Węzeł `[80]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""And what about the powers of the Supreme Court?""]** — Mówca: **Player**
> ""And what about the powers of the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We need proper balance of power, Mrs. Edmonds. Try to see the bigger picture.""]** — Mówca: **Player**
> ""We need proper balance of power, Mrs. Edmonds. Try to see the bigger picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[86]`
Mówca: **Isabel Edmonds**
> ""You know it's true, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Isabel Edmonds**
> ""You are aiming to destroy the Court and you need us to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[91]`
Mówca: **Isabel Edmonds**
> ""Why should I vote for a proposal that will take away my immunity as a Justice? Was this the promised reform? Removing Justices however you see fit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Isabel Edmonds**
> ""You are expanding the powers of the president, which already is very powerful. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[82]`
  - -> `[81]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[103]`
Mówca: **Isabel Edmonds**
> ""First of all, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Isabel Edmonds**
> ""...But it pains me to say that your *updated* proposal has a very low chance of getting through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[107]`
  - -> `[106]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""And what do you think about the proposal itself?""]** — Mówca: **Player**
> ""And what do you think about the proposal itself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Not if you support us.""]** — Mówca: **Player**
> ""Not if you support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""That's why we have you here.""]** — Mówca: **Player**
> ""That's why we have you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Isabel Edmonds**
> ""You think that's enough?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Isabel Edmonds**
> ""What I think really doesn't matter with a proposal like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Isabel Edmonds**
> ""Changing Article 6 and 7? Removing 'Sord' from the Constitution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Isabel Edmonds**
> ""What were you even thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The discrimination and oppression that many Bludish people face in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Assembly proved many wrong by passing it, Ms. Edmonds. The atmosphere in this country is now changing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know those changes are about equality and rights, Justice Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you not approve of those?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Isabel Edmonds**
> ""You know you need the other justices to vote for it too, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
Mówca: **Isabel Edmonds**
> ""Try explaining that to the Sollists and the Sordists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""I thought you were a tactical man, Mr. President. But you decided to gamble with your reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Isabel Edmonds**
> ""What matters is the atmosphere of the Supreme Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Isabel Edmonds**
> ""But before we get bogged down in details, I must say I find your proposal disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Isabel Edmonds**
> ""And now you need our wing to vote for you. Otherwise all of your hard work will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[127]`
Mówca: **Isabel Edmonds**
> ""But before we get bogged down in details, I must say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Isabel Edmonds**
> ""You are really brave. Trying to go against Tarquin Soll's member of honor rights, huh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Isabel Edmonds**
> ""I admire your struggle. Especially because you were strong enough to include concessions from your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Isabel Edmonds**
> ""You don't have a strong position here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Isabel Edmonds: ""You need our wing to vote for you...."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[138]`
Mówca: **Isabel Edmonds**
> ""You know, Mr. President... Since you tried to intervene with the Court's decision on Mr. Ersen's case, there is quite a bit of hostility against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[145]`
Mówca: **Isabel Edmonds**
> ""But before that, I want to congratulate you on the successful vote in the Grand National Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[146]`
Mówca: **Isabel Edmonds**
> ""You know, Mr. President... Since you tried to intervene with the Court's decision on Mr. Ersen's case, you created some hostility against yourself among my wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[150]`
Mówca: **Isabel Edmonds**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
