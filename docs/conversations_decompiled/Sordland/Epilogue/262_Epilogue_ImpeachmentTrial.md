# Sordland/Epilogue_ImpeachmentTrial

- **ID konwersacji:** `262`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ImpeachmentTrial)`
- **Lokalizacja pliku:** `Sordland/Epilogue/262_Epilogue_ImpeachmentTrial.md`
- **Liczba węzłów dialogowych:** 120
- **Liczba wyborów gracza:** 59

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Franc_Died`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[113]` (Paskal Beniwoll): `PrologueImage("pe_gavel");`
- Węzeł `[114]` (Paskal Beniwoll): `PrologueImage("pe_jail");`
- Węzeł `[115]` (Paskal Beniwoll): `PrologueImage("pe_jail");`
- Węzeł `[116]` (Paskal Beniwoll): `PrologueImage("");`
- Węzeł `[117]` (Paskal Beniwoll): `PrologueImage("pe_red");`
- Węzeł `[118]` (Paskal Beniwoll): `PrologueImage("pe_execution");`
- Węzeł `[119]` (Paskal Beniwoll): `PrologueImage("");`

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
  - -> `[113]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Orso Hawker demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Orso opened it with a barely suppressed smile. 

Knowing what was coming next, you felt that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best for Sordland. No matter what."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The next words you heard were "It is hereby decided that Anton Rayne is impeached from office."

The crowd in the courtroom -- the very same people who celebrated your inauguration -- erupted in loud cheers.

You thought about how you would go down in history as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were angry at everyone who spoke against you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed only yourself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the first impeached President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[11]`
Mówca: **Narrator**
> "But the judge wasn't done speaking.

"For the magnitude of his crimes against Sordland, Anton Rayne is sentenced to life in prison."

The crowd cheered even louder this time. Security officers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[12]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading was the only thing you could do. After finishing the precious books sent by Monica, you kept yourself busy by writing your own memoir.

Meanwhile, your family visited you at least once a month."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "It had been months since Monica's last visit. In the middle of the night, the warden knocked roughly on your door and told you you had a visitor.

Deana was waiting for you with teary eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Seeing you, Deana quickly turned around, hiding her face. Franc couldn't hold his tears anymore and told you that his mother passed away. 

His mother, your wife, Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were overcome with grief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "You returned to your cell, numb and exhausted.

Every passing second was torture as you rotted away in this dark, isolated hellhole.

Lying down on your bed, you looked at your belt and the metal pipe in the ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "End it all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Don't do it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "You spent the rest of your life between four walls.

Eventually, old age caught up with you. You were discharged from prison to the hospital to spend your last moments with your family.

As you took your last breath, you grabbed Deana. You pulled her close and said..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "And so Anton Rayne was no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "Deana started crying and hugged you.

You could feel you were slipping away.

Your eyes filled with tears and started to close, never to be opened again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Before you could kick your chair away, the warden rushed in and pulled you down. You were stripped of any potentially dangerous belongings and placed under constant surveillance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Ovid Grecer demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Ovid opened it with a stern face. 

Knowing what was coming next, you felt that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[4]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "1958|Supreme Court of Sordland"]** — Mówca: **Narrator**
> "The gavel was tapped two times and Heron Garaci demanded silence in the loud room. After a long pause, he ordered everyone to rise.

One of his retainers handed him the letter with the verdict. Heron opened it with a barely suppressed smile. 

Knowing what was coming next, you felt that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[4]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[38]`
Mówca: **Narrator**
> "But the judge wasn't finished speaking.

"For the magnitude of the crimes he has committed against Sordland, Anton Rayne is sentenced to execution by firing squad."

The crowd cheered even louder this time. Security officers grabbed your arms and started walking you towards the door. 

As you were walking you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried about the future of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...declared that you would take revenge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted your fate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "1959|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. The only decorations you put on the damp, dark walls were photos of Franc and Deana.

For a while, reading books was the only thing you could do. Eventually, you started scribbling notes about your life that you hoped you could turn into a memoir.

Monica and the children visited only once, to have you sign the divorce papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time flies in jail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he joined the ranks of the People's Freedom and Justice Party. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[61]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he joined the ranks of the Communist Party of Sordland. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[61]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "Franc visited you for the first time in years, bringing along his wife and son. They reminded you of your own family, in better times.

You held your grandson for the first time. He squirmed and started crying in your arms.

Franc told you that he was now a senior army official on a track to the higher ranks. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "1964|Antel Rock Prison"]** — Mówca: **Narrator**
> "The warden paid you a visit to deliver a letter from the Sordish Armed Forces. You opened the envelope.

Franc Rayne was killed in action in a battle against the BFF near Erzaren."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your whole world fell apart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...congratulated him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told him not to get too deep into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...said you were worried for his future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "In the middle of the night, the warden knocked roughly on your door and told you you had visitors.

Franc, his wife and Deana were waiting for you with teary eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "In the middle of the night, the warden knocked roughly on your door and told you you had a visitor.

Deana was waiting for you with teary eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "1968|Antel Rock Prison"]** — Mówca: **Narrator**
> "It had been months since Monica's last visit. In the middle of the night, the warden knocked roughly on your door and told you you had visitors.

Franc, his wife and Deana were waiting for you with teary eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Something was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Deana couldn't hold her tears anymore and told you that her mother passed away. 

Her mother, your wife, Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "You spent the rest of your life between four walls.

Eventually, old age caught up with you. You were discharged from prison to the hospital to spend your last moments with your family.

As you took your last breath, you grabbed Franc and Deana. You pulled them close and said..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Franc_Died == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Franc_Died"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "1976"]** — Mówca: **Narrator**
> "Franc and Deana started crying and hugged you.

You could feel you were slipping away.

Your eyes filled with tears and started to close, never to be opened again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

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
  - -> `[92]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. You had a week until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

You were happy that at least your family visited you every day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "1958|Antel Rock Prison"]** — Mówca: **Narrator**
> "Your cell was cold and lonely. A week remained until your execution.

To keep busy, you read books and occasionally scribbled down notes about your life that you hoped someone would compile into a memoir. It was better than just staring at the wall and waiting for your certain death.

Monica visited you only once, along with the kids."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The week was over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "1958|Day of the Execution|Antel Rock Prison"]** — Mówca: **Narrator**
> "The day of your execution had arrived.

The cell door opened and the warden entered. He asked you what would be your final meal.

You asked him for..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`
  - -> `[97]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the largest, bloodiest steak he could find."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hearty and healthy breakfast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a bottle of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[98]`
Mówca: **Narrator**
> "You were dragged outside after you finished your final meal. The guards brought you to a corner just outside the prison block and tied your hands behind your back.

You took a look at the wall behind you. It was covered in dried blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You heard the footsteps of soldiers approaching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[100]`
Mówca: **Narrator**
> "The squad of soldiers turned the corner and lined up across from you. At the head of the line was their commander, Iosef.

He checked his watch and declared that the time had come. 

He pulled out a cloth to cover your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[101]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Beg Iosef to free you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Accept your death."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "He asked you if you had any last words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I regret nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core! Vectern sis da!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[107]`
Mówca: **Narrator**
> "He covered your eyes and stepped back. 

After a moment, you heard the sounds of the guns being cocked.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[108]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...felt relaxed. It was finally over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...defiantly stood proud and strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cried like a child."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "The gunshots were the last thing you ever heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "A failure to the end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_gavel");)*
- **Efekt (`userScript`):** `PrologueImage("pe_gavel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail");)*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail");)*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_red");)*
- **Efekt (`userScript`):** `PrologueImage("pe_red");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_execution");)*
- **Efekt (`userScript`):** `PrologueImage("pe_execution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
