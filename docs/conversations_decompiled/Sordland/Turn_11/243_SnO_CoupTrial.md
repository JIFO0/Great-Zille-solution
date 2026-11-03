# Sordland/Turn11/SnO_CoupTrial

- **ID konwersacji:** `243`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/243_SnO_CoupTrial.md`
- **Liczba węzłów dialogowych:** 276
- **Liczba wyborów gracza:** 29

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[42]** Valken Kruger
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Economy`
- `BaseGame.Enable_SollTrial`
- `BaseGame.Policy_Law_Impeachment_Assembly`
- `BaseGame.Policy_Law_Impeachment_Default`
- `BaseGame.Policy_Law_Impeachment_Harder`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn09_EnT_IncreasedLivingStandards`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Deal_Failed`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery`
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial`
- `GameCondition.Turn11_SnO_CoupTrial`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 12

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[196]` (Paskal Beniwoll): `-- Continue;`
- Węzeł `[199]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] = true;`
- Węzeł `[200]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] = true;`
- Węzeł `[206]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_SnO_CoupTrial"] = true;`
- Węzeł `[207]` (Paskal Beniwoll): `-- continue;`
- Węzeł `[220]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] = true;`
- Węzeł `[228]` (Paskal Beniwoll): `-- Continue;`
- Węzeł `[245]` (Paskal Beniwoll): `-- continue;`
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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was making my 14th scratch on the wall when the warden opened the cell door. It was my first time seeing a person since the military detained me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“You are no judge. You are just a usurper.”"]** — Mówca: **Player**
> "“You are no judge. You are just a usurper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He put handcuffs on my wrists and we started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“Normally, you are supposed to rise when a judge enters this room, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[18]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I barely had enough energy to ask where we were going. I just assumed the worst. He told me today was the day of my trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "While we were walking, I caught a glimpse of my reflection in a metal door. My beard had grown and my cheeks were sunken. The conditions I was held in were showing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Soldiers grabbed my arms and led me inside. They gestured towards the table in the court room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Take a seat."]** — Mówca: **Player_Italic**
> "I took my place at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Looking around, I saw the flags of the Sordish Armed Forces hanging down from the walls, covering the crests of the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The room was completely empty except for me and the soldiers on guard. I looked at the vacant seats on the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Narrator**
> "The door opened and General Iosef Lancea entered alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Narrator**
> "The door opened and General Valken Kruger entered alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Stand up."]** — Mówca: **Player_Italic**
> "I stood up in my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The soldiers saluted and he saluted back. I watched him take his seat comfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Valken Kruger**
> "“Normally, you are supposed to rise when a judge enters this room, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“Cranky, aren't we? I suppose that's what staying in a cell for weeks does to people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Valken Kruger**
> "“Cranky, aren't we? I suppose that's what staying in a cell for weeks does to people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Valken Kruger**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“There is no time to waste. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Valken Kruger**
> "“There is no time to waste. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“This military court will now handle the case of Anton Rayne, the former President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“You are accused of high treason against Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`
  - -> `[126]`

### Węzeł `[41]`
Mówca: **Valken Kruger**
> "“You are accused of high treason against Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`
  - -> `[126]`

### Węzeł `[42]`
Mówca: **Valken Kruger**
> "“This military court will now handle the case of Anton Rayne, the former President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“You have allowed our military to degrade, causing direct danger to the integrity of our country and our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Iosef Lancea**
> "“You have aligned our country with the evil ideology of Malenyevism. Our fathers are now rolling in their graves because of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“You spat on the very foundations this country was built upon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_SollTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_SollTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Enable_SollTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Enable_SollTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Enable_SollTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“You even put Colonel Soll, the founder of our republic, on a trial!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“It is clear to me that you are actively trying to destroy our country from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“And any enemy of Sordland must pay the ultimate price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[58]`
Mówca: **Valken Kruger**
> "“You have allowed our military to degrade, causing direct danger to the integrity of our country and our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[59]`
Mówca: **Valken Kruger**
> "“You spat on the very foundations this country was built upon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_SollTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_SollTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Enable_SollTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Enable_SollTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Enable_SollTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Valken Kruger**
> "“You have aligned our country with the evil ideology of Malenyevism. Our fathers are now rolling in their graves because of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[64]`
Mówca: **Valken Kruger**
> "“And any enemy of Sordland must pay the ultimate price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[65]`
Mówca: **Valken Kruger**
> "“It is clear to me that you are actively trying to destroy our country from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[72]`
Mówca: **Valken Kruger**
> "“You even put Colonel Soll, the founder of our republic, on a trial!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“What do you have to say for yourself, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[74]`
Mówca: **Valken Kruger**
> "“What do you have to say for yourself, Mr. Rayne?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“You know what, screw you!”"]** — Mówca: **Player**
> "“You know what, screw you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I will make it out of this and one day, you will be sorry for your life.”"]** — Mówca: **Player**
> "“I will make it out of this and one day, you will be sorry for your life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“It doesn't matter what I say, does it?”"]** — Mówca: **Player**
> "“It doesn't matter what I say, does it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I see what this is. This is all a ploy to end Sordish democracy along with my presidency. I won't play along.""]** — Mówca: **Player**
> "“I see what this is. This is all a ploy to end Sordish democracy along with my presidency. I won't play along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Iosef Lancea**
> ""Your lies know no bound. Fortunately, we don't care if you 'play along' or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[83]`
Mówca: **Valken Kruger**
> ""Your lies know no bound. Fortunately, we don't care if you 'play along' or not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“No, not really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[88]`
Mówca: **Valken Kruger**
> "“No, not really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[89]`
Mówca: **Valken Kruger**
> "“You dare threaten the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[93]`
Mówca: **Iosef Lancea**
> "“You dare threaten the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[94]`
Mówca: **Valken Kruger**
> "“You dare say that to the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“You dare say that to the head of your own country's military? You are an incorrigible traitor, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Just get on with it then. Finish it.”"]** — Mówca: **Player**
> "“Just get on with it then. Finish it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“At least let me see my family again. They are innocent.”"]** — Mówca: **Player**
> "“At least let me see my family again. They are innocent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“One day, the people of Sordland will look back and curse your name for what you have done.”"]** — Mówca: **Player**
> "“One day, the people of Sordland will look back and curse your name for what you have done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“You are wrong, Mr. Rayne. They will thank me for getting rid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Valken Kruger**
> "“You are wrong, Mr. Rayne. They will thank me for getting rid of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[107]`
Mówca: **Valken Kruger**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“Gladly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[112]`
Mówca: **Valken Kruger**
> "“We do not negotiate with traitors, Mr. Rayne. Permission denied.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[116]`
Mówca: **Iosef Lancea**
> "“We do not negotiate with traitors, Mr. Rayne. Permission denied.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[117]`
Mówca: **Narrator**
> "Iosef walked toward me and leaned in as he murmured faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[121]`
Mówca: **Narrator**
> "He swiftly moved back and adjusted his uniform before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[122]`
Mówca: **Narrator**
> "I was the only one loaded into the prison truck. After a couple of hours had passed, we finally came to a stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "After I exited the vehicle, I held my head up and saw the insignia of the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“This is ridiculous! You have no proof!”"]** — Mówca: **Player**
> "“This is ridiculous! You have no proof!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“High treason? I would never betray my country. You know that more than anyone.”"]** — Mówca: **Player**
> "“High treason? I would never betray my country. You know that more than anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“If there is any betrayal here, it is yours against your democratically elected president and government.”"]** — Mówca: **Player**
> "“If there is any betrayal here, it is yours against your democratically elected president and government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“Shut your mouth. You will only speak when you are spoken to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
Mówca: **Valken Kruger**
> "“Shut your mouth. You will only speak when you are spoken to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[132]`
Mówca: **Valken Kruger**
> "“Don't worry too much, Mr. Rayne, we will make good use of the economy you left for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“Don't worry too much, Mr. Rayne, we will make good use of the economy you left for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[137]`
Mówca: **Iosef Lancea**
> "“First and foremost, you have sold your own country, your own people, to Rumburg. You have conceded Estord and Narbel to our sworn enemies. I have never seen such cowardice and betrayal. Even Alphonso didn't fall so low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Valken Kruger**
> "“First and foremost, you have sold your own country, your own people, to Rumburg. You have conceded Estord and Narbel to our sworn enemies. I have never seen such cowardice and betrayal. Even Alphonso didn't fall so low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Iosef Lancea**
> "“Instead of giving the order to destroy the BFF, you decided to side with known rebels that we have been fighting for years. You betrayed loyal Sords who sacrificed themselves for their country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“You have failed to govern your people and instead, as a result of your actions, they are revolting. If you can't put an end to this, then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[150]`
Mówca: **Valken Kruger**
> "“Instead of giving the order to destroy the BFF, you decided to side with known rebels that we have been fighting for years. You betrayed loyal Sords who sacrificed themselves for their country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.Unrest_BFF_Deal_Promised == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Valken Kruger**
> "“You have failed to govern your people and instead, as a result of your actions, they are revolting. If you can't put an end to this, then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_UnrestStopped == false && (BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  and  (Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[158]`
Mówca: **Iosef Lancea**
> "“Do you know why you are here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Valken Kruger**
> "“Do you know why you are here?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“No, I don't.”"]** — Mówca: **Player**
> "“No, I don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "“No, I don't.”"]** — Mówca: **Player**
> "“No, I don't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Yes, I do.”"]** — Mówca: **Player**
> "“Yes, I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Iosef Lancea**
> "“Hah. As expected. Acting innocent until the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[165]`
Mówca: **Valken Kruger**
> "“And we let this man be our President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“We all know our sins.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[167]`
Mówca: **Valken Kruger**
> "“At least he is aware.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[171]`
Mówca: **Valken Kruger**
> "“And had him brutally executed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“And had him brutally executed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_IncreasedLivingStandards == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_IncreasedLivingStandards"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
**[WYBÓR GRACZA: "“I've made Sordland a better place. Every Sord is living a pleasant life because of me.""]** — Mówca: **Player**
> "“I've made Sordland a better place. Every Sord is living a pleasant life because of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Valken Kruger**
> "“Mr. Rayne, you can't toss us a bone and expect us to live in bliss ignorance of your crime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[187]`
Mówca: **Iosef Lancea**
> "“Mr. Rayne, you can't toss us a bone and expect us to live in bliss ignorance of your crime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I dragged Sordland out of a recession and brought us to a golden age. Without me, this republic would have crumbled. The people see me as a hero.""]** — Mówca: **Player**
> "“I dragged Sordland out of a recession and brought us to a golden age. Without me, this republic would have crumbled. The people see me as a hero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Valken Kruger**
> "“But the people have yet to know the cost it took, Mr. Rayne. When they know of your crimes, no one will still stand by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Iosef Lancea**
> "“But the people have yet to know the cost it took, Mr. Rayne. When they know of your crimes, no one will still stand by you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Plead Unguilty Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[212]`
  - -> `[179]`
  - -> `[258]`
  - -> `[77]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Plead Unguilty Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[76]`
  - -> `[75]`

### Węzeł `[197]`
Mówca: **Narrator**
> "His mouth twitched upwards as a smirk started forming on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[198]`
Mówca: **Narrator**
> "His mouth twitched upwards as a smirk started forming on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_LivingStandards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_SordishRecovery"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[201]`
Mówca: **Iosef Lancea**
> "“No need to delay this further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[202]`
Mówca: **Valken Kruger**
> "“No need to delay this further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Valken Kruger**
> "“I will now announce the verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Iosef Lancea**
> "“I will now announce the verdict on this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_CoupTrial = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_SnO_CoupTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 7)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 7))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[211]`
Mówca: **Narrator**
> "Valken walked toward me and leaned in as he murmured faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true && BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true  and  Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[215]`
Mówca: **Valken Kruger**
> "“We are doing what we were assigned to do. Protect this country. At this very moment, we are protecting it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
Mówca: **Iosef Lancea**
> "“We are doing what we were assigned to do. Protect this country. At this very moment, we are protecting it from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_IncreasedMilitaryBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“I gave you support so you can protect this country. Instead, you've chosen to depose your own president!?""]** — Mówca: **Player**
> "“I gave you support so you can protect this country. Instead, you've chosen to depose your own president!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“This is criminal. You have neither the right nor the authority to judge me.""]** — Mówca: **Player**
> "“This is criminal. You have neither the right nor the authority to judge me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[238]`
  - -> `[229]`
  - -> `[246]`
  - -> `[235]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Iosef Lancea**
> ""You finished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[227]`
Mówca: **Valken Kruger**
> ""You finished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Harder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Harder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Impeachment_Harder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Harder"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
**[WYBÓR GRACZA: "“Where are the members of the assembly and the justices!?""]** — Mówca: **Player**
> "“Where are the members of the assembly and the justices!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Where are the justices!?""]** — Mówca: **Player**
> "“Where are the justices!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“By the law, I cannot be judged!”"]** — Mówca: **Player**
> "“By the law, I cannot be judged!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Where are the members of the assembly!?""]** — Mówca: **Player**
> "“Where are the members of the assembly!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
**[WYBÓR GRACZA: "“This is a power grab in the disguise of protecting the republic, I demand a proper trial.”"]** — Mówca: **Player**
> "“This is a power grab in the disguise of protecting the republic, I demand a proper trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> ""The *law* that you wrote and passed for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
Mówca: **Valken Kruger**
> ""The *law* that you wrote and passed for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> ""Shall we move on then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[254]`
Mówca: **Valken Kruger**
> ""Shall we move on then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[255]`
Mówca: **Iosef Lancea**
> ""What a joke!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[256]`
Mówca: **Valken Kruger**
> ""What a joke!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_CoupTrial_PleadNotGuilty_UnlawfulTrial"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "Spit on his face."]** — Mówca: **Player_Italic**
> "I spat on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[263]`
**[WYBÓR GRACZA: "Throw a punch at his jaw."]** — Mówca: **Player_Italic**
> "I punched his jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "Stare a spiteful gaze into his eyes."]** — Mówca: **Player_Italic**
> "I stared into his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[265]`
Mówca: **Narrator**
> "He swiped the saliva off his face and rubbed it on your suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Your punch connected but he barely flinched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Iosef Lancea**
> ""Weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Valken Kruger**
> ""Weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
