# Sordland/Epilogue_ElectionLose

- **ID konwersacji:** `271`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (Epilogue_ElectionLose)`
- **Lokalizacja pliku:** `Sordland/Epilogue/271_Epilogue_ElectionLose.md`
- **Liczba węzłów dialogowych:** 573
- **Liczba wyborów gracza:** 188

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_PeoplesFront`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.NFPLeader_Remus`
- `BaseGame.NewParty_DemocratParty`
- `BaseGame.NewParty_LiberalParty`
- `BaseGame.NewParty_MaroonParty`
- `BaseGame.NewParty_PeoplesParty`
- `BaseGame.PFJPLeader_Manoly`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn09_A_LileasResigned`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Epilogue_NewPresident_Frens`
- `BaseGame.Epilogue_NewPresident_Kesaro`
- `BaseGame.Epilogue_NewPresident_Lileas`
- `BaseGame.Epilogue_NewPresident_Manoly`
- `BaseGame.Epilogue_NewPresident_Remus`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Retirement_Arcasia`
- `BaseGame.Retirement_UnitedContana`
- `BaseGameIsolated.Epilogue_Election_Forcedout`
- `BaseGameIsolated.Epilogue_Election_LateRetire`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Skoki między-konwersacyjne:
- Węzeł `[561]` -> **[273] Sordland/ARCASIA OR UC ELECTION ENDING** (../Epilogue/273_ARCASIA_OR_UC_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[562]` -> **[272] Sordland/ANRICA ELECTION ENDING** (../Epilogue/272_ANRICA_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[563]` -> **[274] Sordland/ERLORY ELECTION ENDING** (../Epilogue/274_ERLORY_ELECTION_ENDING.md), Węzeł `[1]`
- Węzeł `[564]` -> **[275] Sordland/BENFI ELECTION ENDING** (../Epilogue/275_BENFI_ELECTION_ENDING.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 23
- **Węzły modyfikujące stan gry:** 47

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Monica_Divorce`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[286]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- Węzeł `[305]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] = true;`
- Węzeł `[306]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- Węzeł `[307]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- Węzeł `[308]` (Paskal Beniwoll): `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- Węzeł `[312]` (Paskal Beniwoll): `Variable["BaseGame.Retirement_Arcasia"] = true;`
- Węzeł `[313]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- Węzeł `[338]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- *...oraz 39 innych węzłów ze skryptami.*

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
  - -> `[449]`

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
> "Once again, your moment of truth had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Democrat Party failed to even pass the threshold.

Your term was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`

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
  - -> `[51]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_FormNewParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_FormNewParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_DemocratParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_DemocratParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_DemocratParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_DemocratParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_LiberalParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_LiberalParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_LiberalParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_LiberalParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_PeoplesParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_PeoplesParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_PeoplesParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_PeoplesParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_PeoplesParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NewParty_MaroonParty == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NewParty_MaroonParty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NewParty_MaroonParty == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NewParty_MaroonParty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[33]`
Mówca: **Narrator**
> "On election day, millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Liberal Party failed to even pass the threshold.

Your term was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Party failed to even pass the threshold.

Your term was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Maybe this was for the better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It felt good to return to the Assembly, where it all started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Maroon Party failed to even pass the threshold.

Your term was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Sordish Prosperity Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling everyone to isolate and silence your movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[47]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The PFJP came in second and became the second biggest party in the Assembly, leaving the National Front to be the third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worked with lobbyists to increase your power base."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Freedom and Justice Party secured the second spot.

Despite her promise, Manoly pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Front failed to even pass the threshold.

Your political career was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "Your overtures did not result in any alliances. Most political leaders distanced themselves from you due to your ties with the establishment. 

You stood alone in the Assembly. You gradually realized that accomplishing your party's goals would be impossible under these circumstances.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[60]`
  - -> `[48]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Freedom and Justice Party secured the second spot.

Despite his promise, Frens pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept serving your duty as the opposition by pointing out mistakes and suggesting solutions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to boost your visibility through media stunts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the National Front Party secured the second spot, leaving the PFJP behind.

Despite his promise, Remus pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the National Front Party secured the second spot, leaving the PFJP behind.

Despite his promise, Kesaro pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party under the leadership of Lileas Graf did not secure victory. The People's Freedom and Justice Party had won, pushing the USP to second place for the first time in in history.

Despite her promise, Lileas pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The People's Freedom and Justice Party had won. The NFP secured the second spot, while the USP limped into third.

You were to be a member of the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The PFJP came in second and became the second biggest party in the Assembly, leaving the National Front to be the third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`
  - -> `[101]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire from politics after this failure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It felt good to return to the Assembly, where it all started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[72]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, while the NFP came in third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the Communist Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Democrat Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

President Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[38]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Liberal Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[38]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the People's Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling for everyone to isolate and silence you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[38]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Maroon Party barely scraped past the low threshold you had set during your term. You had won a seat in the Assembly.

Lileas Graf denounced you and your party, calling everyone to isolate and silence your movement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[38]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "The United Sordland Party came out as the winner, while the Sordish Prosperity Party failed to even pass the threshold.

Your term was completely over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the Workers' Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to cooperate with the pro-Bludish parties."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the betrayal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Maybe this was for the best."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ElectionLose_Retire)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ElectionLose_Retire])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ElectionLose_Retire])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[107]`
Mówca: **Narrator**
> "You accepted the situation and retired from politics completely.

It had been decades since you first entered the political arena. You did not know what else to do with your life.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[287]`
  - -> `[291]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[114]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[115]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[116]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Narrator**
> "In another historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Narrator**
> "In another historic moment, the Workers' Party of Bludia managed to enter the Assembly for the first time, surpassing the 8% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The die had been recast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[126]`
Mówca: **Narrator**
> "In another historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Policy_Law_Threshold_3 == true  && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Policy_Law_Threshold_3"] == true   and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Manoly began a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the government's legislative branch, expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

She promised you a position as her next Vice President if you supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Frens began a massive campaign to rewrite the constitution of Sordland. 

His proposal was aimed at strengthening the government's legislative branch, expanding the rights of women and minorities, and eliminating the unequal distribution of campaign funding.

He promised you a position as his next Vice President if you supported him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`
  - -> `[146]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Monica ignored you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer, but supported the proposal nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[148]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[153]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[154]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Manoly Suheil went after big corporations, raising their taxes two-fold. Many businessmen were also tried under charges of corruption, and their assets were seized.

She announced a massive redevelopment plan, "TAP", or "the Agnland Project", to contribute to social stability and economic growth by focusing on the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[161]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The fact that you had supported it angered your base in the USP, and you were stripped of your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Frens Ricter started implementing tax initiatives for small businesses and policies aimed at bringing more foreign investment inside the country.

He also promoted a social market economy, emphasizing the need for the state to ensure that the free market produced results close to its theoretical potential."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[161]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against the PFJP's policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the PFJP's policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[164]`
  - -> `[147]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[164]`
  - -> `[156]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested against her policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[168]`
  - -> `[167]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Lileas began a massive campaign to rewrite the constitution of Sordland. 

Her proposal was aimed at strengthening the government's executive and judiciary branches, while transforming the election system so that the next president would be chosen by specific electors rather than the popular vote.

She offered an alliance if your party supported the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[195]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, Lileas went after hundreds of Sordish private businesses and seized their assets. Many were tried under charges of corruption. 

She announced a massive economic redevelopment plan, "TAP", or "the Agnland Project", to contribute to the national targets of social stability and economic growth by focusing on the Agnland region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[169]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[183]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. The tensions gave way to frequent fights until one day, Monica filed for divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Monica ignored you and, in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[187]`
  - -> `[168]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the governing party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the undemocratic proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[197]`
Mówca: **Narrator**
> "You formed a grassroots coalition of MPs who agreed that the new proposal would spell the end of democracy in Sordland.

In a seismic shift in Sordish politics, your Sordish Democratic Coalition managed to drum up enough popular support to prevent Lileas from changing the Constitution.

The USP lost by 193 nays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You thought it was all for the best."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were devastated by the betrayal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "After you supported Lileas' proposal, your party called you a traitor and stripped you of your membership.

You decided that it was time to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ElectionLose_LateRetire)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[205]`
Mówca: **Narrator**
> "You accepted the situation and retired from politics completely.

It had been decades since you first entered the political arena. You did not know what else to do with your life.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[287]`
  - -> `[291]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[213]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...began writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[208]`
Mówca: **Narrator**
> "With your political career behind you, you began your new life in Holsord. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[211]`
  - -> `[207]`

### Węzeł `[209]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[213]`

### Węzeł `[210]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Holsord State University."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living with his wife and son on a farming commune in United Contana, publicly distanced himself from you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[216]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You lost sleep over it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...refused to give him anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't care."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Underhall Construction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[232]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[233]`
Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[212]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[212]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped him with whatever he needed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[260]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`
  - -> `[215]`

### Węzeł `[261]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[275]`
  - -> `[217]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Memoir == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a farm somewhere in Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[220]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in Bergia, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living on a small farm in Bergia with his wife and son, frequently asked you for money. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[218]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to the coast of Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Vineyard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to stay in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided to try your luck managing FC Anrica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...dedicated yourself to making wine in your vineyard in Erlory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Joined_ATO == true) && BaseGame.Archetype_ComradeRayne == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Joined_ATO"] == true)  and  Variable["BaseGame.Archetype_ComradeRayne"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true || BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true  or  Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...moved to United Contana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_LateRetire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_LateRetire == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_LateRetire == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_LateRetire == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_LateRetire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_Arcasia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Retirement_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ElectionLose_LateRetire])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your struggle for the country continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[316]`
**[WYBÓR GRACZA: "1964"]** — Mówca: **Narrator**
> "Throughout the term, your acts led to a new era of Sordish politics where coalitions were commonplace. The Assembly became a place for civil discussion and actual productive solutions. 

After this internal renewal, Sordland rose to become a great regional power that rivaled many nations around it in economy, education and health, and diplomacy.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[322]`
  - -> `[325]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...strengthened Sordland's democratic institutions and the separation of power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were stronger together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "In the next election, the PFJP won with your party coming in second. The USP had to settle for third place.

Your movement's victory had been a turning point. The PFJP formed a coalition with you. Though you had your disagreements, it proved to be a fruitful cooperation.

The time for change had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...decided that it was time to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried to shift the country towards democratic socialism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_DemocraticRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_DemocraticRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "Sordish democracy became a beacon in the world thanks to your efforts. The legislative branch became stronger while the presidency became a symbolic institution. The judiciary was fair and independent.

The public rallied to your cause. In subsequent elections, the most non-democratic parties all failed to enter Assembly and the remaining ones joined in a grand coalition.

You went down in the Sordish history books as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[332]`
  - -> `[331]`

### Węzeł `[329]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "You spent your retirement enjoying the simple things in life. 

The role of the Presidency diminished in time and became symbolic during your retirement. The people remembered the positive parliamentarian change you brought.

You went down in the Sordish history books as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[330]`
  - -> `[337]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a popular hero that came to the country in a time of need."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a beacon of hope and change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a saviour of Sordish democracy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a diligent civil servant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[334]`
**[WYBÓR GRACZA: "1970"]** — Mówca: **Narrator**
> "The sentiment towards socialism grew thanks to your parliamentary efforts.

Your actions pushed the governing coalition to adopt principles close to Valgslandian Socialism. Better social welfare programs and improved workers' rights resulted in a major reformation of society.

You went down in the Sordish history books as..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a hero of the working class."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...the saviour of the downtrodden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...another politician that tried to do their best."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were a broken man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt only relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ElectionLose_LateRetire])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[346]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "By fighting tooth-and-nail against the PFJP's changes, you managed to block their proposal in the Assembly.

However, the party had drummed up so much popular support for its reforms that the public turned against the USP for sabotaging them.

In the next election, your party suffered its worst loss ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You soldiered on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[349]`
Mówca: **Narrator**
> "You lived out the rest of your days as a somewhat ineffectual career politician, never again achieving the success you had as President, but doing your best to fight for the causes you believed in.

A small street in your hometown was named after you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It's a dead end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...life went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Fame doesn't hurt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[362]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`

### Węzeł `[363]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland managed to enter the Assembly for the first time, surpassing the 3% threshold.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[370]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The PFJP once again became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`
  - -> `[101]`

### Węzeł `[371]`
Mówca: **Narrator**
> "In a historic moment, the Communist Party of Sordland, the Workers Party of Bludia and the Bludish Freedom Party managed to enter the Assembly for the first time, all surpassing the 3% threshold.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third.

This was a first. Six parties entered the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[73]`
  - -> `[101]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[378]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The National Front Party became the second biggest party in the Assembly; hampered by its lack of leadership, the PFJP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`

### Węzeł `[379]`
Mówca: **Narrator**
> "In a historic moment, the Workers Party of Bludia managed to enter the Assembly for the first time, surpassing the 3% threshold.

The Communist Party of Sordland finished just below the threshold, failing to be represented yet again.

The PFJP became the second biggest party in the Assembly; hampered by its lack of leadership, the NFP limped into third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`

### Węzeł `[380]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The National Front party had won. The USP came in second; with its leadership hampered, the PFJP limped into third.

You were to be a member of the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[381]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party did not secure victory for the first time in its existence. 

The People's Freedom and Justice Party had won. The USP secured the second spot; with its leadership hampered, the NFP limped into third.

You were to be a member of the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[388]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Kesaro Kibener started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[389]`
**[WYBÓR GRACZA: "1958"]** — Mówca: **Narrator**
> "A year later, President Remus Holstron started seizing the assets of Bludish businesses. Many businessmen were arrested under charges of corruption.

He also promoted the idea of "Maroon Blood" and heavily invested in eugenic research and the military. He openly supported and funded the Young Sords."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You supported the NFP's policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You protested the NFP's policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PFJPLeader_Manoly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PFJPLeader_Manoly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PFJPLeader_Manoly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PFJPLeader_Manoly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Manoly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Manoly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NFPLeader_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NFPLeader_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NFPLeader_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NFPLeader_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[408]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a fierce critic of the new administration, rallying Sordish women to demonstrate against the NFP's gender-biased policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[418]`
  - -> `[413]`

### Węzeł `[409]`
**[WYBÓR GRACZA: "1959"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a fierce critic of the new administration, rallying Sordish women to demonstrate against the NFP's gender-biased policies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[418]`
  - -> `[417]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Remus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Remus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Remus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Remus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised her to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[421]`
Mówca: **Narrator**
> "Monica ignored you and in time, raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[422]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[423]`
Mówca: **Narrator**
> "Monica raised herself to new heights. She was becoming the most famous woman in Sordish politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never talked to Monica again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[429]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[430]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[431]`
Mówca: **Narrator**
> "Your attitude created tensions between you and Monica. Tensions gave way to frequent fights until one day, Monica filed a divorce.

She and Deana moved out to a small apartment in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[433]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Remus began a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`
  - -> `[440]`

### Węzeł `[434]`
**[WYBÓR GRACZA: "1960"]** — Mówca: **Narrator**
> "A year later, Kesaro began a massive campaign to rewrite the constitution of Sordland. 

His proposal aimed to strengthen presidential powers, abolish the citizenship of Bludish people and implement racial laws to segregate the others from the "Maroon Bloods."

He offered you the position of Vice President in exchange for your support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`
  - -> `[440]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected the offer, but supported the proposal nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[437]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "Unfortunately, the proposal did not pass the Assembly. The fact that you had supported it angered your base in the USP, and you were stripped of your membership.

You decided that it was time for you to retire from politics. You continued your service as an independent MP until the end of your term and did not run for re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You soldiered on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You felt only relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You actively worked against the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You decided to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[442]`
**[WYBÓR GRACZA: "1961"]** — Mówca: **Narrator**
> "By fighting tooth-and-nail against the NFP's changes, you managed to block their proposal in the Assembly.

However, the party had drummed up so much popular support for its reforms that the public turned against the USP for sabotaging them.

In the next election, your party suffered its worst loss ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[438]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were a broken man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[444]`
**[WYBÓR GRACZA: "1957|November 3rd"]** — Mówca: **Narrator**
> "In a historic result, the United Sordland Party under the leadership of Lileas Graf did not secure victory. The National Front Party had won, pushing the USP to second place for the first time in in history.

Despite her promise, Lileas pushed your name to the bottom of the MP list, leaving you outside the Assembly.

You had been forced out of politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Kesaro = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Kesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn11_Election_AssassinationHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn11_Election_AssassinationHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_15 == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[455]`
Mówca: **Narrator**
> "No other party managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[456]`
Mówca: **Narrator**
> "Some new independents managed to enter the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[275]`
  - -> `[217]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[467]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`
  - -> `[215]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Election_Forcedout == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[228]`
  - -> `[227]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[201]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Election_Forcedout = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Election_Forcedout"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[439]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[485]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[220]`

### Węzeł `[486]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[220]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[493]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in the Arcasian suburbs, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[494]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son on a commune in United Contana, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[501]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son somewhere in the Arcasian suburbs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[502]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a commune somewhere in United Contana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`
  - -> `[505]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[506]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living in the Arcasian suburbs with his wife and son, frequently asked you for money. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[218]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Then, you woke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true && BaseGame.Fired_KarlGreiser == false && BaseGame.Turn09_A_LileasResigned == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true  and  Variable["BaseGame.Fired_KarlGreiser"] == false  and  Variable["BaseGame.Turn09_A_LileasResigned"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[511]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[515]`
Mówca: **Narrator**
> "Karl Greiser became a hero of the nation for his ultimate sacrifice.

In this tense atmosphere, the election day approached.

Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[516]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes, setting turnout records in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Unrest_BFF_Happened == true && BaseGame.Security_Unrest_Military == false && BaseGame.Unrest_BFF_Deal_Signed == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Security_Unrest_Military"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[520]`
Mówca: **Narrator**
> "You made a full recovery just in time for election day. Millions went out to cast their votes under the watchful eye of Sordish law enforcement. The turnout was low, but your expectations were high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[521]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[522]`
Mówca: **Narrator**
> "The last thing you remembered was a shout of "For Free Bludia! Yollak Bluderat!" -- and then, chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[523]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

You felt a heavy weight on top of you. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[524]`
Mówca: **Narrator**
> "The last thing you remembered was chaos. The people in the crowd screamed and scrambled for cover as security chased after the gunman. 

Your guards rushed to your side, but it was too late. You'd been hit. You collapsed to the ground, and everything faded to black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[527]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[528]`
Mówca: **Narrator**
> "As your consciousness returned, you realized you were in a hospital. Several doctors were standing over you with looks of relief on their faces.

They told you that assassin's bullet had broken a couple of your ribs, but a metal object in your pocket had kept it from hitting any major organs.

They showed it to you. It was an antique pocket watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[529]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You opened your eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[533]`
Mówca: **Narrator**
> "Security guards rushed to your side. When you came to your senses, you realized.

It was Karl Greiser who jumped in front of the bullet to save your life.

He saluted you in his last moments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Lileas = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Epilogue_NewPresident_Lileas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_UnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Retirement_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`
  - -> `[544]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Serge's good luck charm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_forcedout");)*
- **Efekt (`userScript`):** `PrologueImage("pe_forcedout");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sordishgoat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sordishgoat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_plane");)*
- **Efekt (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `273` (*Sordland/ARCASIA OR UC ELECTION ENDING*), Węzeł `[1]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_city");)*
- **Efekt (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `272` (*Sordland/ANRICA ELECTION ENDING*), Węzeł `[1]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_city");)*
- **Efekt (`userScript`):** `PrologueImage("pe_city");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `274` (*Sordland/ERLORY ELECTION ENDING*), Węzeł `[1]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coast");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coast");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `275` (*Sordland/BENFI ELECTION ENDING*), Węzeł `[1]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meeting");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meeting");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("");)*
- **Efekt (`userScript`):** `PrologueImage("");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_loss");)*
- **Efekt (`userScript`):** `PrologueImage("pe_loss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
