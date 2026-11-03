# Sordland/ANRICA ENDING

- **ID konwersacji:** `266`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ANRICA ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/266_ANRICA_ENDING.md`
- **Liczba węzłów dialogowych:** 103
- **Liczba wyborów gracza:** 43

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
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Resigned_GusManger`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Retirement_FamilyWithYou`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[54]` (Paskal Beniwoll): `Variable["BaseGame.Retirement_FamilyWithYou"] = false;`
- Węzeł `[95]` (Paskal Beniwoll): `PrologueImage("pe_city");`
- Węzeł `[96]` (Paskal Beniwoll): `PrologueImage("pe_celebrity");`
- Węzeł `[97]` (Paskal Beniwoll): `PrologueImage("pe_monicaspeech");`
- Węzeł `[98]` (Paskal Beniwoll): `PrologueImage("pe_loss");`
- Węzeł `[99]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
- Węzeł `[100]` (Paskal Beniwoll): `PrologueImage("");`
- Węzeł `[101]` (Paskal Beniwoll): `PrologueImage("");`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[95]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `264` (*Sordland/Epilogue_Retirement*), Węzeł `[2]`

### Węzeł `[3]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Anrica.

You and Gus Manger had stayed friendly after his resignation, and he gladly helped install you as manager of the team you co-owned. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[10]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Anrica.

You and Gus Manger had stayed friendly after your term ended, and he gladly helped install you as manager of the team you co-owned. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...threw yourself into the role, studying football strategy and using all the tactics that helped you run Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...used it as an excuse to cut loose and schmooze with celebrities."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your influence with Anrica conservatives to lobby for her cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Thanks to your popularity, your wife was able to pick up her political career where she had left off.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[14]`
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team won more matches than it had in years. The people of Anrica forgot about your shortcomings as a President and celebrated you as their football club's savior.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[14]`
  - -> `[30]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[37]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s among Sordland's jet-setting elite while propelling FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples as you propelled FC Anrica to victory after victory. 

Eventually, you decided to settle down. You relinquished control of the team and..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...reconnected with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[71]`
  - -> `[70]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How Failing As A President Helped Me Win As A Football Manager", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[72]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[59]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off. Eventually, she filed for divorce and moved with Deana to Holsord.

Once in the capitol, Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[59]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Your unpopularity in Anrica trounced Monica's hopes of picking up her political advocacy where it had left off. Eventually, she filed for divorce and moved with Deana to Holsord.

Once in the capitol, Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[59]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "1960|Anrica"]** — Mówca: **Narrator**
> "The team lost more matches in one year than it had in the previous decade. They and you became a laughing stock.

Meanwhile, you couldn't help but notice your ex-wife gaining political traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political connections to lobby for her cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Anrica"]** — Mówca: **Narrator**
> "You spent the swinging '60s attempting to ingratiate yourself among Sordland's jet-setting elite as FC Anrica suffered one humiliating defeat after another.

Your money started running out, and Gus persuaded you to sell him your shares in the team. With your ownership stake gone, you were easily forced out as manager.

You used your new spare time to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Your book, titled 'One For The Team: How I Failed At Both The Presidency And Football", was an instant best-seller, lauded for its unflinching honesty. 

With your reputation saved and your presidency a mere footnote in Sordish history, you lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...start writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...connect with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

The rest of your days were spent between Anrica and Bergia. You weren't rich, but you were happy to have the love of your family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never reconciled with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never repaired your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't take your football career seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[71]`
  - -> `[70]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[71]`
  - -> `[70]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

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
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_city");)*
- **Efekt (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_celebrity");)*
- **Efekt (`userScript`):** `PrologueImage("pe_celebrity");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
