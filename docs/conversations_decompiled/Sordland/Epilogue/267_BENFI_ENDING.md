# Sordland/BENFI ENDING

- **ID konwersacji:** `267`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (BENFI ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/267_BENFI_ENDING.md`
- **Liczba węzłów dialogowych:** 132
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.PersonalWealth`
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`
- `BaseGameIsolated.Epilogue_Retirement_Partying`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[49]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] = true;`
- Węzeł `[57]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- Węzeł `[129]` (Paskal Beniwoll): `PrologueImage("pe_coast");`
- Węzeł `[130]` (Paskal Beniwoll): `PrologueImage("pe_monicaspeech");`
- Węzeł `[131]` (Paskal Beniwoll): `PrologueImage("pe_coast");`

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
  - -> `[129]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `264` (*Sordland/Epilogue_Retirement*), Węzeł `[2]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a luxurious beach house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a modest condominium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a cozy cottage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Benfi. You moved into..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[8]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Your new home had everything your heart desired. You loved waking up and falling asleep to the sound of the waves.

You couldn't stay idle for long, though. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Narrator**
> "It was a far cry from the luxury you'd enjoyed in Holsord, but you loved waking up to the sound of the waves.

You couldn't stay idle for long, though. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Benfi University."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started hosting fabulous gatherings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_Dead == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Petr_Dead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Petr_Dead == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Petr_Dead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...hit the clubs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...called up Petr and hit the clubs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your wife's rose.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[30]`
  - -> `[39]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[30]`
  - -> `[39]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[46]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "1960|Benfi"]** — Mówca: **Narrator**
> "As your star faded, your ex-wife's rose.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[46]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage in the Erlory countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[37]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political influence to lobby for her cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Eventually you managed to reconcile with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Partying = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Partying == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Partying == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Partying == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Partying"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your hard-partying lifestyle began to take its toll. Strung out and losing money fast, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...asked your son if you could move in with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...checked yourself into rehab and began working on your memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Memoir == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a farm in Bergia with his wife and son.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion > 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

You even managed to reconcile with Franc.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2  or Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2 ||BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2  or Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living on a farm in Bergia with his wife and son, occasionally came for visits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Anton Rayne was famous once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[83]`
Mówca: **Narrator**
> "You lived out the rest of your days in wealth and comfort by the seaside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had never felt so close to your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "1980|Benfi"]** — Mówca: **Narrator**
> "After receiving multiple lifetime achievement awards for her women's rights work, Monica decided to finally take a break. The two of you spent the rest of your days in leisure by the seaside.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Raynespotting: How I Quit Both The Presidency And Drugs", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days by the seaside, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never mended your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between in Bergia. You weren't rich, but you were happy to have the love of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[91]`
  - -> `[92]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "After years of publication delays, your memoir, titled "Suzerain", was finally out. 

Lauded for its unflinching honesty, it became an instant best-seller.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living in the Arcasian suburbs with his wife and son.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "Your teaching career, though unglamorous, offered you a welcome anonymity. 

You luxuriated in your new life as a civilian as your presidency became a footnote in Sordish history.

During the school holidays you would visit Franc, by now living on a commune in United Contana with his wife and son.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living in the Arcasian suburbs with his wife and son, occasionally came for visits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "1970|Benfi"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with the elite as you advanced her cause together.

Franc, by now living in a commune in United Contana with his wife and son, occasionally came for visits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coast");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coast");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
