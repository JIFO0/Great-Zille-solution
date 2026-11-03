# Sordland/Epilogue_CoupTrial

- **ID konwersacji:** `263`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_CoupTrial)`
- **Lokalizacja pliku:** `Sordland/Epilogue/263_Epilogue_CoupTrial.md`
- **Liczba węzłów dialogowych:** 135
- **Liczba wyborów gracza:** 66

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Franc_Died`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Deal_Signed`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 11

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[124]` (Paskal Beniwoll): `PrologueImage("pe_coup_iosef");`
- Węzeł `[125]` (Paskal Beniwoll): `PrologueImage("pe_coup_valken");`
- Węzeł `[126]` (Paskal Beniwoll): `PrologueImage("pe_gavel");`
- Węzeł `[127]` (Paskal Beniwoll): `PrologueImage("pe_jail");`
- Węzeł `[128]` (Paskal Beniwoll): `PrologueImage("pe_jail");`
- Węzeł `[129]` (Paskal Beniwoll): `PrologueImage("pe_red");`
- Węzeł `[130]` (Paskal Beniwoll): `PrologueImage("pe_execution");`
- Węzeł `[131]` (Paskal Beniwoll): `PrologueImage("");`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[68]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "Valken Kruger tapped the gavel. The sound echoed in the empty courtroom.

He rose from his seat.

Knowing what was coming next, you felt that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best for Sordland. No matter what."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "Iosef Lancea tapped the gavel. The sound echoed in the empty courtroom.

He rose from his seat.

Knowing what was coming next, you felt that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The next words you heard were "I hereby decide that you are guilty."

You thought about how you would go down in history as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were angry at everyone who betrayed you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed only yourself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the victim of yet another one of Sordland's coups."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The gunshots were the last thing you ever heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[13]`
Mówca: **Narrator**
> "But he wasn't done speaking.

"For the magnitude of the crimes you have committed against Sordland, I am sentencing you to life in prison."

Soldiers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your whole world fell apart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...congratulated him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading was the only thing you could do. After finishing the precious books sent by Monica, you kept yourself busy by writing your own memoir.

You were happy that at least your family was allowed to visit once a month."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cried like a child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...defiantly stood proud and strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt relaxed. It was finally over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. A week remained until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

Monica visited you only once, along with the kids."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He covered your eyes and stepped back. 

After a moment, you heard the sounds of the guns being cocked.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[20]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Go to hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core! Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. You had a week until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

You were happy that at least your family was allowed to visit you every day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he had joined the ranks of the Communist Party of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[30]`
  - -> `[16]`

### Węzeł `[29]`
Mówca: **Narrator**
> "He asked you if you had any last words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[24]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told him not to get too deep into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Accept your death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Iosef to free you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he was now a senior army official on a track to the higher ranks. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[30]`
  - -> `[16]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Iosef.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[31]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were worried for his future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[39]`
Mówca: **Narrator**
> "But he wasn't finished speaking.

"For the magnitude of the crimes you have committed against Sordland, I am sentencing you to execution by firing squad."

Soldiers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You heard the footsteps of soldiers approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[50]`
Mówca: **Narrator**
> "You were dragged outside after you finished your final meal. Soldiers brought you to a corner just outside the prison block and tied your hands behind your back.

You took a look at the wall behind you. It was covered in dried blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he had joined the ranks of the People's Freedom and Justice Party. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[30]`
  - -> `[16]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading books was the only thing you could do. Eventually, you started scribbling notes about your life that you hoped you could turn into a memoir.

Monica and the children visited only once, to have you sign the divorce papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a bottle of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hearty and healthy breakfast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the largest, bloodiest steak he could find."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The week was over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "1958|Day of the Execution|Antel Rock Prison"]** — Mówca: **Narrator**
> "The day of your execution had arrived.

The cell door opened and the warden entered. He asked you what would be your final meal.

You asked him for..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[56]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Valken.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[75]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Valken to free you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "You learned in prison that after 2 years, the military junta finally gave the power back to people.

The political parties and the Grand National Assembly were re-established.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not care much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought that this could be your way out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hoped that someone would hang Iosef for his crimes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hoped that someone would hang Valken for his crimes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "1965"]** — Mówca: **Narrator**
> "After 7 years in jail, Sordland's new president finally granted amnesty to political prisoners from the military rule days.

You looked at yourself in the mirror as you were packing up your belongings to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had grown old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "1967"]** — Mówca: **Narrator**
> "Getting used to being a free man took years.

You finally felt confident enough to plan out what to do with the rest of your life.

You chose to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[87]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

No one was waiting for you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Franc and his family were waiting for you. 

Everything had changed so much that you felt out of place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Monica, Deana and Franc were waiting for you.

Unfortunately, the years hadn't been kind to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Narrator**
> "You took your first step outside. Freedom felt good.

Monica and Deana were waiting for you.

Unfortunately, the years hadn't been kind to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The years haven't been kind to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But they hadn't been kind to you either."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...have another shot at politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...retire to the countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...find an earnest job."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "You tried to get back into politics, but Sordland had changed too much.

The political spheres formed after the coup did not accept you.

You had to work menial, though at least honest, jobs to get by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "Life was good.

You took up various hobbies like gardening and woodworking. Out of boredom, you became a carpenter.

Your new past times earned you just enough money to get by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "At least you were free."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "1973"]** — Mówca: **Narrator**
> "Life was good.

You took up woodworking and became a carpenter.

It was a menial job, but at least it was honest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had all the time in the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had to get by somehow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "1974"]** — Mówca: **Narrator**
> "A week after your 66th birthday, a woman knocked on your door.

She was a young upstart journalist fascinated by your life story. No matter what you did, she kept coming back. Finally, you gave in. She said she was working on a book about you. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...just wanted to finally have peace of mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped her as best as you could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "After many hours of interviews, she said that she had enough information and disappeared from your life.

You looked up the name she had given you, but you couldn't find it anywhere. You suspected she'd used an alias."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You wondered why."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "You heard a knock on your door. It was the delivery man with a large, heavy package.

The package was filled with copies of books. There was a small note on top of it.

"Thank you. --Carol Circas""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You picked up the book."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "It was titled Suzerain: The Story of Anton Rayne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You faintly smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "The warden paid you a visit to deliver a letter from the Sordish Armed Forces. You opened the envelope.

Franc Rayne was killed in action in a battle against the BFF near Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_UnrestStopped"] == false  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_UnrestStopped == false || BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_UnrestStopped"] == false  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coup_iosef");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coup_iosef");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coup_valken");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coup_valken");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_gavel");)*
- **Efekt (`userScript`):** `PrologueImage("pe_gavel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail");)*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail");)*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_red");)*
- **Efekt (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_execution");)*
- **Efekt (`userScript`):** `PrologueImage("pe_execution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
