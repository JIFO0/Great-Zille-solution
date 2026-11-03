# Sordland/Turn07/WhatIsYourNextMove

- **ID konwersacji:** `111`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/111_WhatIsYourNextMove.md`
- **Liczba węzłów dialogowych:** 93
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[112] Sordland/Turn07/IsabelPersuasion** (../Turn_07/112_IsabelPersuasion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 11

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[18]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[32]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[41]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[42]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[48]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- Węzeł `[72]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel...`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `112` (*Sordland/Turn07/IsabelPersuasion*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Isabel Edmonds**
> ""That's relieving to hear. I thought you forgot about all the other issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[4]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Isabel Edmonds**
> ""Can you explain me one thing. How come you think that the Supreme Court's right to vote on constitutional amendments is a major problem with such priority?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""To further the reforms.""]** — Mówca: **Player**
> ""To further the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""To ensure the new processes are respected and executed in transparency.""]** — Mówca: **Player**
> ""To ensure the new processes are respected and executed in transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Focus on our internal and external threats.""]** — Mówca: **Player**
> ""Focus on our internal and external threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""We will eliminate the Old Guards from all branches of government.""]** — Mówca: **Player**
> ""We will eliminate the Old Guards from all branches of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[10]`
Mówca: **Isabel Edmonds**
> ""...What will be your next move?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[7]`
  - -> `[6]`
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[14]`
Mówca: **Nia Morgna**
> ""I thought we wer-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[16]`
Mówca: **Isabel Edmonds**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""That point was a red line for Mr. Ricter. We had to include it.""]** — Mówca: **Player**
> ""That point was a red line for Mr. Ricter. We had to include it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[20]`
Mówca: **Isabel Edmonds**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[21]`
Mówca: **Isabel Edmonds**
> ""I'm asking the President, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[71]`
  - -> `[56]`
  - -> `[17]`

### Węzeł `[22]`
Mówca: **Isabel Edmonds**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[23]`
Mówca: **Isabel Edmonds**
> ""You shouldn't make a move against the Court, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Isabel Edmonds**
> ""How can I be sure that you will not go after us too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[27]`
  - -> `[29]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Trust me. It is only the Old Guard we're after.""]** — Mówca: **Player**
> ""Trust me. It is only the Old Guard we're after.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[26]`
Mówca: **Narrator**
> "She sighed and looked outside the window for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Help me bring Orso Hawker down. He's the only one we need.""]** — Mówca: **Player**
> ""Help me bring Orso Hawker down. He's the only one we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[28]`
Mówca: **Isabel Edmonds**
> ""I'm sorry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[44]`
  - -> `[36]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We can't do anything without a proper cause anyway.""]** — Mówca: **Player**
> ""We can't do anything without a proper cause anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds... Mr. President had a rough day. This court vote is extremely important for us. Please do understand our position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[31]`
Mówca: **Nia Morgna**
> ""Mrs. Edmonds, we are not against you. We want you on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[33]`
Mówca: **Isabel Edmonds**
> ""I don't know what to say, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Nia looked really worried and tense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Isabel took another sip from her water and looked at me without saying anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""]** — Mówca: **Player**
> ""I did not intend any offence, Mrs. Edmonds. Please accept my apology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, please help us achieve this victory. We have to be together in this.""]** — Mówca: **Player**
> ""Mrs. Edmonds, please help us achieve this victory. We have to be together in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What do you want in return for the centrist vote?""]** — Mówca: **Player**
> ""What do you want in return for the centrist vote?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, how about we get to the point now?""]** — Mówca: **Player**
> ""Mrs. Edmonds, how about we get to the point now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[43]`
Mówca: **Isabel Edmonds**
> ""I don't want anything, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Let's just get to the point, Mrs. Edmonds. Do I have your vote or not?""]** — Mówca: **Player**
> ""Let's just get to the point, Mrs. Edmonds. Do I have your vote or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I told you. You are not our target.""]** — Mówca: **Player**
> ""I told you. You are not our target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[46]`
Mówca: **Isabel Edmonds**
> ""Just because your *corruption* police put some pressure on the Court, doesn't mean you own it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[47]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
Mówca: **Isabel Edmonds**
> ""Interesting. So you do not own it up, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[53]`
Mówca: **Isabel Edmonds**
> ""I just want assurance that you don't intend to destroy the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Why don't you ask the *reformists*? This proposal was made together.""]** — Mówca: **Player**
> ""Why don't you ask the *reformists*? This proposal was made together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[55]`
Mówca: **Isabel Edmonds**
> ""Isn't that where we are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""The judiciary should not have legislative powers, Mrs. Edmonds.""]** — Mówca: **Player**
> ""The judiciary should not have legislative powers, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[57]`
Mówca: **Isabel Edmonds**
> ""Perhaps that is the way we must take...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I did not intend any offense, Mrs. Edmonds. Please accept my apology.""]** — Mówca: **Player**
> ""I did not intend any offence, Mrs. Edmonds. Please accept my apology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[59]`
Mówca: **Isabel Edmonds**
> ""My vote is not for sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""You heard me.""]** — Mówca: **Player**
> ""You heard me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[61]`
Mówca: **Isabel Edmonds**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""How can we even do that? Please, Mrs. Edmonds. Don't overexaggerate.""]** — Mówca: **Player**
> ""How can we even do that? Please, Mrs. Edmonds. Don't overexaggerate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""You have my word.""]** — Mówca: **Player**
> ""You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I didn't want to disrespect you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""I didn't want to disrespect you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[65]`
Mówca: **Isabel Edmonds**
> ""Of course not...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""With all due respect, you are reaching the last straw.""]** — Mówca: **Player**
> ""With all due respect, you are reaching the last straw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""The Court has been stopping every constitutional change, Mrs. Edmonds...""]** — Mówca: **Player**
> ""The Court has been stopping every constitutional change, Mrs. Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
Mówca: **Isabel Edmonds**
> ""I didn't come here to be disrespected, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[64]`
  - -> `[58]`

### Węzeł `[75]`
Mówca: **Isabel Edmonds**
> ""That's not very relieving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[76]`
Mówca: **Isabel Edmonds**
> ""So that is your position... I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

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
  - -> `[71]`
  - -> `[56]`
  - -> `[88]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Why don't you ask the *reformists*? That clause was one of their main demands too.""]** — Mówca: **Player**
> ""Why don't you ask the *reformists*? That clause was one of their main demands too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""That point was a red line for the opposition. We had to include it.""]** — Mówca: **Player**
> ""That point was a red line for the opposition. We had to include it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
