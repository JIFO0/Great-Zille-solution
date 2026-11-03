# Sordland/ERLORY ELECTION ENDING

- **ID konwersacji:** `274`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (ERLORY ELECTION ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/274_ERLORY_ELECTION_ENDING.md`
- **Liczba węzłów dialogowych:** 139
- **Liczba wyborów gracza:** 38

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
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Party`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Party`
- `BaseGameIsolated.Epilogue_Retirement_Erlory_Wine`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[271] Sordland/Epilogue_ElectionLose** (../Epilogue/271_Epilogue_ElectionLose.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 11

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[58]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] = true;`
- Węzeł `[59]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- Węzeł `[60]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- Węzeł `[131]` (Paskal Beniwoll): `PrologueImage("pe_party");`
- Węzeł `[132]` (Paskal Beniwoll): `PrologueImage("pe_relaxed");`
- Węzeł `[133]` (Paskal Beniwoll): `PrologueImage("pe_monicaspeech");`
- Węzeł `[134]` (Paskal Beniwoll): `PrologueImage("pe_drinking");`
- Węzeł `[135]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
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
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `271` (*Sordland/Epilogue_ElectionLose*), Węzeł `[2]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "You didn't know much about winemaking, but the vineyard's staff did. Rayne Wines gained a reputation as some of Sordland's finest.

As you opened the villa up for tastings, Erlory became a gathering point for the Sordland elite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_DenyEverything == true || BaseGame.Turn08_SecondScandal_ShareBlame == true || BaseGame.Turn08_SecondScandal_LiviaInvestigated == false && BaseGame.Petr_Dead == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true  or  Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == false  and  Variable["BaseGame.Petr_Dead"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "Between your villa and Petr's across town, Erlory became a gathering point for the Sordland elite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "1960|Erlory"]** — Mówca: **Narrator**
> "Your villa became a gathering point for the Sordland elite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...resumed wine production."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...used the space to host fabulous parties."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[17]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

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
  - -> `[31]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but used your remaining political influence to lobby for her cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never heard from either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "Your wife, sensing an opportunity, parlayed these new connections into a second attempt at a political career. 

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[24]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "Your wife, sensing an opportunity, parlayed these new connections into a second attempt at a political career. 

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[24]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "At one of your gatherings, you heard a rumor that your ex-wife was getting back into politics. It turned out to be true.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[24]`
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "1962|Erlory"]** — Mówca: **Narrator**
> "At one of your gatherings, you heard a rumor that your ex-wife was getting back into politics. It turned out to be true.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[24]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos of her you'd once taken, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[38]`
Mówca: **Narrator**
> "The ensuing scandal cost Monica her political clout. She and Deana moved to a small cottage on the Benfi coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with celebrities as you promoted your wines and her causes.

Eventually, you decided to settle down. You handed over control of the wine business and..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Your book, titled 'Purple Rayne: How I Failed The Presidency But Won At Wine", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...reconnected with Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...started writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "Years of heavy partying took their toll on you.

By the end of the swinging '60s, you were strung out and losing money fast. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...asked your son if you could move in with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...checked yourself into rehab and began working on your memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, now living on a farm in Bergia with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Marooned: How I Quit Both The Presidency And Booze", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days at your leafy villa, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never accomplished your presidential goals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You happily sampled your own goods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed sober."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You indulged in the party lifestyle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed clean and networked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Wine = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Party = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Erlory_Party == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Party"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "Though you hadn't meant to get caught up in the party lifestyle, the swinging '60s took their toll on you.

By the end of the decade, you were strung out and losing money fast. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "1970|Erlory"]** — Mówca: **Narrator**
> "You and Monica spent the swinging '60s as one of Sordland's premier power couples, hobnobbing with celebrities as you promoted her causes.

Eventually, you decided to settle down. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Erlory_Wine == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Erlory_Wine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Your book, titled 'Suzerain: The Real Story Of The Anton Rayne Presidency", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_LateRetire == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_LateRetire == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_LateRetire == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[76]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Erlory.

Your villa in Erlory wasn't quite as grand as Petr's, but it was spacious and calm, the perfect refuge after the chaos of Holsord.

You and your family..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[13]`

### Węzeł `[77]`
Mówca: **Narrator**
> "With your presidency behind you, you set out to begin your new life in Erlory.

Your villa in Erlory wasn't quite as grand as Petr's, but it was spacious and calm, the perfect refuge after the chaos of Holsord.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[13]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "1975|Benfi"]** — Mówca: **Narrator**
> "Your book, titled "Marooned: How I Quit Both The Presidency And Booze", was an instant best-seller, lauded for its unflinching honesty.

Your fame catapulted you back into Sordland's elite circles, though you were careful not to overdo it with the parties this time around.

You spent the rest of your days at your leafy villa, surrounded by sycophants and a few true friends. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "1975|Bergia"]** — Mówca: **Narrator**
> "Franc, now living on a farm in Bergia with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Your book, titled 'Suzerain: The Real Story Of The Anton Rayne Presidency", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Your book, titled 'Purple Rayne: How I Failed The Presidency But Won At Wine", was an instant best-seller.

You lived out the rest of your days in wealth and comfort. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Franc, by now living on a farm in Bergia with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Franc, by now living in the Arcasian suburbs with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Franc, by now living on a commune in United Contana with his wife and son, was happy to put whatever differences you'd had aside.

You became a doting grandfather.

You lived out the rest of your days in wealth and comfort, never far from the love of your family. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, now living in the Arcasian suburbs with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, now living on a commune in United Contana with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "1975|Arcasia"]** — Mówca: **Narrator**
> "Franc, now living in the Arcasian suburbs with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "1975|United Contana"]** — Mówca: **Narrator**
> "Franc, now living on a commune in United Contana with his wife and son, put aside whatever ill feelings he might have had about you and welcomed you with open arms.

You became a doting grandfather.

You spent the rest of your days in peace in the countryside. Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[51]`
  - -> `[53]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_party");)*
- **Efekt (`userScript`):** `PrologueImage("pe_party");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed");)*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_drinking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_drinking");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
