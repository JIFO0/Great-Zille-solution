# Sordland/ARCASIA OR UC ELECTION ENDING

- **ID konwersacji:** `273`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ARCASIA OR UC ELECTION ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/273_ARCASIA_OR_UC_ELECTION_ENDING.md`
- **Liczba węzłów dialogowych:** 152
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Investment_Arcasia_Successful`
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_Arcasia`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Retirement_UnitedContana`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[271] Sordland/Epilogue_ElectionLose** (../Epilogue/271_Epilogue_ElectionLose.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 13

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[103]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- Węzeł `[140]` (Paskal Beniwoll): `PrologueImage("pe_city");`
- Węzeł `[141]` (Paskal Beniwoll): `PrologueImage("pe_city");`
- Węzeł `[142]` (Paskal Beniwoll): `PrologueImage("pe_congress");`
- Węzeł `[143]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
- Węzeł `[144]` (Paskal Beniwoll): `PrologueImage("pe_relaxed");`
- Węzeł `[145]` (Paskal Beniwoll): `PrologueImage("pe_relaxed");`
- Węzeł `[146]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `271` (*Sordland/Epilogue_ElectionLose*), Węzeł `[2]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "At first, he would only speak with Deana and Monica. But gradually, the two of you began to reconcile.

Meanwhile, you yourself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[35]`
  - -> `[41]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Your ostentatious lifestyle drew international attention. Franc, by now living on a farming commune in United Contana, publicly disowned you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[87]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "1958|Arcasia"]** — Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Arcasia. 

After transferring your money to the local currency, you could afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[118]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "1958|United Contana"]** — Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in United Contana.

After transferring your money to the local currency, you could afford..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[124]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Investment_Arcasia_Successful == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Investment_Arcasia_Successful"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Investment_Arcasia_Successful == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Investment_Arcasia_Successful"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Narrator**
> "It was hard adjusting to the different culture and values, but you were happy to reconnect with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 4)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion > 4))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Armadine Enterprises and moved to Ventrie City, Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started a charitable foundation to stop global hunger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[31]`
Mówca: **Narrator**
> "You were happy not only to live in a country that aligned with your personal values, but to reconnect with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...lived like royalty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "When he heard you were in the country, he refused to speak to you. But gradually, your relationship began to thaw.

Meanwhile, you yourself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[35]`
  - -> `[41]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "The two of you frequently got together for dinner and ideological discussions.

Meanwhile, you yourself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[35]`
  - -> `[41]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Franc's United People's University."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Your new role on the board of Armadine Enterprises fit you like a glove.

Monica, meanwhile, was thrilled by the new possibilities and viewpoints the Arcasian women's movement had to offer.

In the face of escalating tensions with United Contana, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[127]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Though at first uncomfortable with the country's rampant capitalism, you gradually settled into your new role on the board of Armadine Enterprises.

Monica, meanwhile, was thrilled by the new possibilities and viewpoints the Arcasian women's movement had to offer.

In the face of escalating tensions with United Contana, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[127]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Some time passed. A series of breakthrough inventions made Armadine one of the wealthiest corporations in Arcasia. 

You suddenly had more money than you'd ever been able to enjoy in Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[30]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "1960|United Contana"]** — Mówca: **Narrator**
> "You, him, Deana and Monica had frequent dinners together. It felt like old times.

Meanwhile, you yourself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[35]`
  - -> `[41]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Some time passed. A series of breakthrough inventions made Armadine one of the wealthiest corporations in Arcasia. 

You and your family suddenly had more money than you'd ever been able to enjoy in Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[30]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Though at first uncomfortable with the country's rampant capitalism, you gradually settled into your new role on the board of Armadine Enterprises.

In the face of escalating tensions with United Contana, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[127]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "1960|Arcasia"]** — Mówca: **Narrator**
> "Your new role on the board of Armadine Enterprises fit you like a glove.

In the face of escalating tensions with United Contana, you...."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[127]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...had a bunker built, just in case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your book titled "Rayne The Red; Why I Chose Communism Over The Sordish Presidency", was an instant best-seller. You and Monica toured it everywhere except Arcasia.

When you were at home, you frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your book titled "Rayne The Red; Why I Chose Communism Over The Sordish Presidency", was an instant best-seller. You toured it everywhere except Arcasia.

On your stop in Sordland, you noticed Monica in the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your book, titled "Let Freedom Rayne: Why I Chose Arcasia Over The Sordish Presidency", was an instant best-seller. You and Monica toured it everywhere except United Contana.

When you were at home, you frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your book, titled "Let Freedom Rayne: Why I Chose Arcasia Over The Sordish Presidency", was an instant best-seller. You toured it everywhere except United Contana.

On your stop in Sordland, you noticed Monica in the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ignored her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You asked her to get coffee with you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging. While you rose through the academic ranks, Monica became involved in the United Contana women's movement.

You frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "1965|United Contana"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging.

Some years went by. One day, you noticed your ex-wife would be visiting campus to give a talk on Sordland's burgeoning women's movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging.

Some years went by. One day, you noticed your ex-wife would be visiting campus to give a talk on Sordland's burgeoning women's movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "1965|Arcasia"]** — Mówca: **Narrator**
> "Your new job was unglamorous but intellectually challenging. While you rose through the academic ranks, Monica became involved in the Arcasian women's movement.

You frequently visited Franc in the countryside, where he now lived with his wife and son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[86]`
Mówca: **Narrator**
> "Franc, by now living on a farm with his wife and son, began asking you for money."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You helped him with whatever he needed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Political commentators liked to say that the Rayne Foundation helped more people than you ever had as president. 

On your visits back to Sordland, you were welcomed as a hero.

Franc, by now living on a farming commune in United Contana, reached out to reconcile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Political commentators liked to say that the Rayne Foundation helped more people than you ever had as president. 

On your visits back to Sordland, you were welcomed as a hero.

Franc, by now living on a farm with his wife and son, began asking you for money."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[96]`
Mówca: **Narrator**
> "You lived out the rest of your days in comfort, insulated from the global tensions around you. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never fully got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never fulfilled your goals as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[100]`
Mówca: **Narrator**
> "The two of you met and had a long talk about everything that had happened during your presidency.

You left on slightly better terms, but you never got back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You became a doting grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You became a doting grandfather."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[104]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort, surrounded by admirers, family and a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Memoir == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "More time went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[109]`
Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity as your presidency became a footnote in Sordish history.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never moved back to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hillside mansion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a small cottage in the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a city apartment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest apartment in a prefab government housing bloc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...an opulent hillside villa recently vacated by a disgraced government official."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a country cottage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You sought him out on your first day there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You waited for him to get in touch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...funded President Walker's federalist New Democratic Concord party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[131]`
Mówca: **Narrator**
> "You lived out the rest of your days in comfort, insulated from the global tensions around you. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`
  - -> `[99]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[138]`
Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity as your presidency became a footnote in Sordish history.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`

### Węzeł `[139]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort, surrounded by admirers, family and a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_city");)*
- **Efekt (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_city");)*
- **Efekt (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed");)*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed");)*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
