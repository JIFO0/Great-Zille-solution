# Sordland/Epilogue_ElectionWin

- **ID konwersacji:** `259`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionWin)`
- **Lokalizacja pliku:** `Sordland/Epilogue/259_Epilogue_ElectionWin.md`
- **Liczba węzłów dialogowych:** 599
- **Liczba wyborów gracza:** 152

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Capitalist`
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth`
- `BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords`
- `BaseGame.Democratic`
- `BaseGame.Ending_RumburgWarWin`
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.JoinParty_CPS`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.JoinParty_WPB`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NFPLeader_Remus`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_PeoplesParty`
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Sollist`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Epilogue_Election_VP`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGameIsolated.Epilogue_Election_VP`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 33

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[314]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- Węzeł `[315]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- Węzeł `[316]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- Węzeł `[317]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;`
- Węzeł `[318]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- Węzeł `[319]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] = true;`
- Węzeł `[465]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`
- Węzeł `[573]` (Paskal Beniwoll): `PrologueImage("pe_sordishgoat");`
- *...oraz 25 innych węzłów ze skryptami.*

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
  - -> `[503]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "For the second time, your moment of truth had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Democrat Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was a historic achievement for the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_FormNewParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_DemocratParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_LiberalParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_PeoplesParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_PeoplesParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_PeoplesParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_PeoplesParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_PeoplesParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_MaroonParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[34]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of Sordish law enforcement. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Their magic had worn off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Liberal Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The people had finally spoken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You succeeded in breaking them down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Maroon Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the Sordish Prosperity Party came out as the winner, securing you your second term.

It was the first time the United Sordland Party had ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Freedom and Justice Party came out as the winner, securing Manoly Suheil as the first female president of Sordland.

It was also the first time the United Sordland Party ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the joint force of the WPB and CPS, the People's Front, came out as the winners. Leke was about to become the first Sordish president with a Bludish background.

It was also first time the United Sordland Party ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the People's Freedom and Justice Party came out as the winner, securing Frens Ricter's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the National Front Party came out as the winner, securing Remus Holstron's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the National Front Party came out as the winner, securing Kesaro Kibener's first term as president.

It was also the first time the United Sordland Party ever lost in an election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "As expected, the United Sordland Party came out as the winner again, securing Lileas Graf as the first female president of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[58]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The party owed its success to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The people had spoken again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Victory had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[61]`
Mówca: **Narrator**
> "The National Front was now the second biggest party in the Assembly, leaving the PFJP to be the third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party was again the second largest party in the Assembly, while the National Front came in third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[69]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party was again the second largest party in the Assembly, while the National Front failed to meet the new threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[73]`
Mówca: **Narrator**
> "In a historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fourth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

This time, however, you won as a coalition with the PFJP. You were about to form the government together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[58]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

This time, however, you won as a coalition with the NFP. You were about to form a government together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[58]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[86]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[102]`
Mówca: **Narrator**
> "In a historic success, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[103]`
Mówca: **Narrator**
> "In a historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[114]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Bludish votes divided between the Workers' Party of Bludia and the Bludish Freedom Party resulted in both of them finishing below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first -- more parties in the Grand National Assembly than ever before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[119]`
Mówca: **Narrator**
> "In a historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[129]`
Mówca: **Narrator**
> "In a historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its third biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[189]`
  - -> `[191]`

### Węzeł `[130]`
Mówca: **Narrator**
> "In another historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fourth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[131]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third, leaving the National Front to be the fourth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_8 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_8"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[138]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[142]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[143]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers' Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Never before had so many parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[144]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Bludish votes divided between the Workers' Party of Bludia and the Bludish Freedom Party resulted in both finishing below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[145]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[146]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[147]`
Mówca: **Narrator**
> "In a historic success, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 8% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[157]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third. 

The National Front Party fell below the new threshold and failed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Narrator**
> "In another historic success, the People's Front coalition got both the Workers' Party of Bludia and the Communist Party of Sordland into the Assembly as its fifth biggest political force."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[192]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[172]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the National Front Party third, leaving the PFJP to be the fourth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Policy_Law_Threshold_3 == false && BaseGame.Policy_Law_Threshold_8 == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Policy_Law_Threshold_3"] == false  and  Variable["BaseGame.Policy_Law_Threshold_8"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[179]`
Mówca: **Narrator**
> "The People's Freedom and Justice Party came in second and the National Front Party third. This time, however, the Communist Party of Sordland also managed to enter the Assembly as the fourth largest party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[183]`
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third, leaving the National Front as the fourth largest party of the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`
  - -> `[187]`

### Węzeł `[181]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the People's Freedom and Justice Party third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`
  - -> `[186]`

### Węzeł `[182]`
Mówca: **Narrator**
> "The United Sordland Party came in second and the National Front Party third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the elections."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the PFJP leadership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the NFP leadership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the WPB and CPS leadership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the elections."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You declared that "The Morning Has Come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated the new Assembly members."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You congratulated all parties that participated in the election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You declared that "Morning has come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[199]`
  - -> `[320]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[199]`
  - -> `[320]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[320]`
  - -> `[195]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[200]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[199]`
  - -> `[320]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Mansoun Leke and a group of his allies came together and announced that the integrity of the election was extremely questionable. They protested the results and demanded the state of emergency be revoked immediately.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Because the constitution was easier to amend now, most of the opposition came forth with demands to pursue further constitutional reforms ahead of your inauguration.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[538]`
  - -> `[221]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you to attempt constitutional reform once more.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[221]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you for the constitutional reforms you had promised, calling you a "puppet of the Old Guard" when you failed to respond.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[221]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...suppressed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...accepted their demands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...censored them from press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...promised to cooperate with them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you to attempt constitutional reform once more.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[229]`
  - -> `[236]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...cooperated with them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Because the constitution was easier to amend now, most of the opposition came forth with demands to pursue further constitutional reforms ahead of your inauguration.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[229]`
  - -> `[536]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "1958|January"]** — Mówca: **Narrator**
> "Ahead of your inauguration, members of the opposition already began pressing you for the constitutional reforms you had promised, calling you a "puppet of the Old Guard" when you failed to respond.

Many citizens were also starting to sympathize with them.

In response, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[229]`
  - -> `[236]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...censored them from the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not do anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[237]`
Mówca: **Narrator**
> "You accepted their demands and revoked the state of emergency ahead of your second inauguration.

People celebrated the decision everywhere in Sordland. You hoped that your second inauguration would go smoother than the first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[238]`
Mówca: **Narrator**
> "You censored them from the press and blocked every platform that could make their voices heard.

You made sure your second inauguration would go smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[239]`
Mówca: **Narrator**
> "You made sure their voices were not heard. Any challengers to the election were silenced and the results were officially accepted.

You made sure that your second inauguration would go smoother than the first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[240]`
Mówca: **Narrator**
> "You promised to cooperate as soon as your official inauguration was complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[241]`
Mówca: **Narrator**
> "You censored them from the media and blocked every platform that could make their voices heard.

You made sure your second inauguration would go smoothly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Narrator**
> "You promised to cooperate with them as soon as your official inauguration was complete."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Narrator**
> "You ignored their demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your new term was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your second term was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Manoly went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Remus started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[263]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Leke and Stahler went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

They promoted syndicalist socialism and brought Sordland closer with Valgsland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Kibener cut back investments from Bergia and directed them to kick-start the heavy military industry of Sordland.

He announced a massive redevelopment plan, the "Sord Plan", to contribute to social stability and economic growth by focusing on the rural Greater Holsord region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Ricter started implementing tax initiatives for small businesses and made policies that were aimed at bringing more foreign investment inside the country.

He also promoted a social market economy that emphasized the need for the state to ensure that the free market produced results close to its theoretical potential."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Lileas went after hundreds of private businesses and seized their assets. Many were tried under charges of corruption. 

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You kept supporting the party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against the policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Capitalist"] > 10  and  Variable["BaseGame.Malenyevist"] < 5  and  Variable["BaseGame.Sollist"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Capitalist > 10 && BaseGame.Malenyevist < 5 && BaseGame.Sollist < 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Capitalist"] > 10  and  Variable["BaseGame.Malenyevist"] < 5  and  Variable["BaseGame.Sollist"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 18  and  Variable["BaseGame.Sollist"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 18 && BaseGame.Sollist < 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 18  and  Variable["BaseGame.Sollist"] < 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA: "1958|January 18th"]** — Mówca: **Narrator**
> "You stood on the podium overlooking the famous Hill of Pride once again. It was a particularly cold day. 

When you looked at the thousands of people with hopeful eyes, your shoulders grew heavy and you shivered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[280]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist > 18)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist > 18)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Sollist"] > 18`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Sollist > 18))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Sollist"] > 18) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You held Monica's hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You swallowed the feeling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[284]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a wealthier Sordland.

The country saw massive economic development over your next term. The remnants of the Soll era were long gone, businesses became more profitable and the markets were freed of regulation.

As the market became freer, the people of Sordland also became free. As the economic boom continued, the most critical problems vanished one by one. Sordland was finally letting go of its past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`

### Węzeł `[285]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of equality.

The country saw massive social and economic reforms over your next term. The remnants of the Soll era were long gone, the unequal wealth distribution was curbed, and the means of production were being transferred to the workers.

Sordland was finally letting go of its past. As the people became more equal, they also became free. Your social experiment was bringing Sordland one step closer to the revolution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[290]`
  - -> `[289]`

### Węzeł `[286]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of security and stability.

The country saw massive social and economic development over your term. Your centrist approach helped the country heal and unite through a middle-ground.

Sordland was finally making peace with its past and learning to look to the future with hope. You brought harmony and confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[297]`
  - -> `[298]`

### Węzeł `[287]`
Mówca: **Narrator**
> "You dreamed about the future. You saw a Sordland of self-reliant greatness.

The country saw massive social and economic reforms over your term. The state became stronger and provided the highest-quality services to its people with strides made towards autarky.

Sordland was finally embracing its true self. As the state became richer, the people earned comfort. You made Sordland even stronger than it was before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[295]`
  - -> `[294]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked to achieve the dream of Malenyev."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to eliminate inequality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish social democracy in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to reach the potential of the Sordish dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish neo-liberal Arcasian capitalism in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to expand freedoms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to help the Sordish people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to establish a stronger state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked to achieve the dream of Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to expand freedoms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did everything you could to diminish inequality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You worked hard to reach the potential of the Sordish dream."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic > 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic > 10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic > 10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Narrator**
> "With the sacrifices made by you and your allies, everything became possible. You were building a dream nation together.

You encouraged more civic responsibility and everyone contributed to the greater good in their own way. It was a democratic and just Sordland.

You saw the people smile and smiled back at them. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`
  - -> `[460]`

### Węzeł `[304]`
Mówca: **Narrator**
> "With a sense of duty to your nation, you worked hard, sacrificing all of your time, your sleep, even your soul.

Thanks to your efforts, Sordland became stronger and a better place to live for its citizens -- and you. You heard them cheer your name.

You smiled. You knew you deserved to be praised more than anyone for the success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`
  - -> `[418]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_PeoplesFront = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[321]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Time went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[324]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[328]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[329]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Narrator**
> "Monica did not listen to you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[336]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Lileas launched a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the executive and judiciary branches, while transforming the election system so that the next president would be chosen by specific electors rather than the popular vote.

She offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[337]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Manoly launched a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the legislative branch, and expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

She offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Ricter launched a massive campaign to rewrite the constitution of Sordland. 

His proposal was aimed at strengthening the legislative branch, and expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

He offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Kesaro launched a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[352]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Remus launched a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[356]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "A year later, Leke and Stahler launched a massive campaign to rewrite the constitution of Sordland. 

Their proposal aimed to strengthen the legislative branch, expand the rights of women and minorities, and ensure that the means of production would be owned by the workers.

He offered you the position of Interior Minister in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[359]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer but supported the proposal nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "After your protests against the proposal, the party leadership forced you out by taking away your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[361]`
Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The resources invested in the campaign made the party fall victim to internal strife.

Each faction put forth their own candidates against the president. A congress to elect the party leadership was on the horizon.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[362]`
  - -> `[384]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...watched from the sidelines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Frens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Manoly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Kesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Kesaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Remus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Mansoun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...ran as a candidate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the PFJP Congress.

Unfortunately, you lost the vote to Frens Ricter. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Kesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Kesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_WPB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_WPB == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_WPB == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[401]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the PFJP Congress.

Unfortunately, you lost the vote to Manoly Suheil. The following month, she stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[402]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the NFP Congress.

Unfortunately, you lost the vote to Kesaro Kibener. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[403]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the NFP Congress.

Unfortunately, you lost the vote to Remus Holstron. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[404]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the WPB Congress.

Unfortunately, you lost the vote to Mansoun Leke. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_CPS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_CPS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_CPS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_CPS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_CPS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in the CPS Congress.

Unfortunately, you lost the vote to Denis Stahler. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[409]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "You announced that you were running for leadership, becoming the eighth candidate in that year's USP Congress.

Unfortunately, you lost the leadership vote to Lileas Graf again. The following month, he stripped you of your membership and forced you out of the party.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the result."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You thought it was for the best."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[412]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "After your inaction during the divide, the party leadership decided to push your name back in the MP list, diminishing your chances to be elected to the Assembly.

You realized that the inner circle was forcing you out of the party. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did not resist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to retire from politics entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[415]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Lileas won in the next elections and despite her promise, she did not appoint you as the Vice President.

The leadership decided to push your name back in the MP list, diminishing your chances to be elected to the Assembly. You realized that the inner circle was forcing you out of the party. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You deserved the praise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You knew there was more you could be doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You needed more power to do even better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were pleased with your achievements."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...knew there was more you could be doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Narrator**
> "You also saw Monica. You were back together again. She must have forgiven you.

Deana became a strong and successful young woman. Franc was a family man already.

You were proud of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Narrator**
> "Monica was gaining traction in the capital as one of the fiercest women's rights activists, rallying thousands of Sordish women to fight for change.

Your support buoyed Monica to new heights. With her activism and your administration, Sordish women made strides towards true parity.

Deana became a strong and successful young woman. Franc was a family man already.

You were proud of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years passed..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Narrator**
> "No more obstacles to the Sordish Dream were left. Now the morning had truly come.

The morning brought a united and happy Sordland. An independent and formidable Sordland.

You knew it was possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Victory was here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But the real morning was still on the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[430]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do solemnly swear...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[441]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[442]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[446]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[447]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[451]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[452]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "The People's Front won in the next elections and Mansoun appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[459]`
  - -> `[458]`

### Węzeł `[453]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Remus won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[459]`
  - -> `[458]`

### Węzeł `[454]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Kesaro won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[459]`
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Frens won in the next elections and appointed you as his Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[459]`
  - -> `[458]`

### Węzeł `[456]`
**[WYBÓR GRACZA: "1961|May"]** — Mówca: **Narrator**
> "Manoly won in the next elections and appointed you as her Vice President. It was time for four more years in the Maroon Palace.

Because of your experience and strong support, you earned the respect of the new cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[459]`
  - -> `[458]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You outmanoeuvred the other VP contenders to get the position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You schemed and backstabbed to become VP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to have allied yourself with the right people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...genuinely wanted to improve society."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...an unmemorable figure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a disappointing politician that failed his country in a time of need."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...someone who tried to do their best -- but who wasn't good enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[464]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "You spent your retirement enjoying the simple things in life. 

You went down in the Sordish history books as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`
  - -> `[463]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[469]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[473]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[477]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica was not here. You never got back together, and the years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[481]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Garaci stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[485]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Grecer stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_VP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_VP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_VP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_VP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[489]`
Mówca: **Narrator**
> "A fierce gust of wind shook you out of your daydream.

Monica squeezed your hand. Years had not passed. You were still on the podium, waiting to be sworn in.

Chief Justice Hawker stood next to you and said, "Please repeat after me. I do solemnly swear that I will respectfully execute the Office of the Vice President of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[490]`
**[WYBÓR GRACZA: "1962|January 18th"]** — Mówca: **Narrator**
> "For the inauguration, you stood on the podium next to the party leader overlooking the famous Hill of Pride. The new cabinet was ready to serve the country. It was a particularly cold day.

When you looked at the thousands of people with hopeful eyes, your shoulders grew heavy and you shivered. 

You were going to be their next Vice President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[280]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[497]`
Mówca: **Narrator**
> "With no clear leadership, the People's Freedom and Justice Party failed at entering the Assembly while the National Front Party became the second largest by a number of seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[498]`
Mówca: **Narrator**
> "With no clear leadership, the National Front Party failed at entering the Assembly while the People's Freedom and Justice Party became the second largest by number of seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[502]`
Mówca: **Narrator**
> "The National Front Party came in second; without any clear leadership, the PFJP limped into third. This time, however, the Communist Party of Sordland also managed to enter the Assembly as the fourth largest party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[183]`
  - -> `[184]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn11_Election_AssassinationHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[506]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[510]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Then, you woke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Narrator**
> "As your consciousness returned, you realized you were in a hospital. Several doctors were standing over you with looks of relief on their faces.

They told you that assassin's bullet had broken a couple of your ribs, but a metal object in your pocket had kept it from hitting any major organs.

They showed it to you. It was an antique pocket watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`
  - -> `[516]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[518]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[522]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[523]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You opened your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[528]`
Mówca: **Narrator**
> "Security guards rushed to your side. When you came to your senses, you realized.

It was Karl Greiser who jumped in front of the bullet to save your life.

He saluted you as he lay bleeding beside you. The end was near for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[535]`
Mówca: **Narrator**
> "You rejected their amendment demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...rejected further amendments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[537]`
Mówca: **Narrator**
> "You rejected their amendment demands and postponed the talks until after your official inauguration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...rejected further amendments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner again, securing your second term as president.

The international community criticized the election's integrity and the opposition asked for a transparent recount. 

The request was duly rejected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[58]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[554]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "Or Dax Querna! Qival Rumburgia!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`
  - -> `[557]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_RumburgWarWin == true && BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_RumburgWarWin"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[558]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "Or Dax Querna! Qival Rumburgia!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[562]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of the tens of thousands of Red Youth militias and other law enforcement units. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_FundPoliticalGroup_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[566]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of the tens of thousands of Young Sords militias and other law enforcement units. 

The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[569]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true  or  Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true || BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true  or  Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_victory");)*
- **Efekt (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_victory");)*
- **Efekt (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_victory");)*
- **Efekt (`userScript`):** `PrologueImage("pe_victory");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_politicians");)*
- **Efekt (`userScript`):** `PrologueImage("pe_politicians");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_innercircle");)*
- **Efekt (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_innercircle");)*
- **Efekt (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_congress");)*
- **Efekt (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
