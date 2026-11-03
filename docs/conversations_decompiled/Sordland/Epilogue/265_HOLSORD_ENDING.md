# Sordland/HOLSORD ENDING

- **ID konwersacji:** `265`
- **StoryPack:** `Sordland`
- **Tura:** `Epilogue (HOLSORD ENDING)`
- **Lokalizacja pliku:** `Sordland/Epilogue/265_HOLSORD_ENDING.md`
- **Liczba węzłów dialogowych:** 125
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
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Epilogue_Retirement_Memoir`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[264] Sordland/Epilogue_Retirement** (../Epilogue/264_Epilogue_Retirement.md), Węzeł `[2]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 15
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[83]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- Węzeł `[114]` (Paskal Beniwoll): `PrologueImage("pe_holsord");`
- Węzeł `[115]` (Paskal Beniwoll): `PrologueImage("pe_monicaspeech");`
- Węzeł `[116]` (Paskal Beniwoll): `PrologueImage("pe_blue");`
- Węzeł `[117]` (Paskal Beniwoll): `PrologueImage("pe_relaxed");`
- Węzeł `[118]` (Paskal Beniwoll): `PrologueImage("pe_relaxed");`

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
  - -> `[114]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `264` (*Sordland/Epilogue_Retirement*), Węzeł `[2]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the board of Underhall Construction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[4]`
Mówca: **Narrator**
> "You and Monica began speaking to each other again, although she refused to consider getting back together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[30]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, your wife became ever more entrenched in her struggle for women's rights.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[30]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living with his wife and son on a farming commune in United Contana, publicly distanced himself from you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as a valuable ally to the new administration, representing Sordish women as gender equality policies were made and implemented. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[31]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...began writing a memoir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[10]`
Mówca: **Narrator**
> "With your presidency behind you, you began your new life in Holsord. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[23]`
  - -> `[9]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "1960|Holsord"]** — Mówca: **Narrator**
> "Meanwhile, you couldn't help but notice your ex-wife gaining traction in the capitol.

Monica emerged as one of the fiercest opponents of the new administration, rallying thousands of Sordish women to fight for change. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[31]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Epilogue_Retirement_Memoir == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[18]`
Mówca: **Narrator**
> "The ensuing scandal erased most of Monica's political clout. She and Deana moved to a small cottage in Benfi."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a farm in Bergia with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...became an adjunct professor of politics at Holsord State University."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Underhall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...vocally supported her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Your support buoyed Monica to new heights. People began referring to you as "Monica Rayne's husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never saw either of them ever again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stayed silent, but agreed to look after Deana as Monica spent more and more time in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...found some racy photos you'd once taken of her, and leaked them to the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == false && BaseGame.Relations_Monica_DivorceAfterElection == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == false  and  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Epilogue_NewPresident_Frens == true || BaseGame.Epilogue_NewPresident_Manoly == true || BaseGame.Epilogue_NewPresident_PeoplesFront == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Epilogue_NewPresident_Frens"] == true  or  Variable["BaseGame.Epilogue_NewPresident_Manoly"] == true  or  Variable["BaseGame.Epilogue_NewPresident_PeoplesFront"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Years went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...helped him with whatever he needed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...refused to give him anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a farm somewhere in Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living on a small farm in Bergia with his wife and son, frequently asked you for money. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion < -2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion < -2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in Bergia, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy to reconnect with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You didn't care."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You lost sleep over it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days among Holsord's wealthy elite, surrounded by sycophants and just a few true friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[122]`
  - -> `[70]`

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
> "...were never able to mend your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, helping Monica as necessary as she tirelessly pursued her cause.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[73]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "1975|Holsord"]** — Mówca: **Narrator**
> "You lived out the rest of your days in relative anonymity, alone except for a few close friends.

Your only regret was that you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[119]`
  - -> `[75]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...actually, you had no regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't fulfill the goals you'd set out as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were never able to mend your marriage with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...never got back into politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Retirement_FamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Retirement_FamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Retirement_FamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Retirement_FamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Epilogue_Retirement_Memoir = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Epilogue_Retirement_Memoir"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Author Rayne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Life went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

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
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "As you used your remaining political contacts to your advantage, Underhall became the wealthiest construction company in Sordland. 

Franc, by now living in the Arcasian suburbs with his wife and son, frequently asked you for money. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living in the Arcasian suburbs with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "After years of hard work, your memoir, titled "Suzerain", was finally published. 

It became an instant best-seller, skyrocketing you to notoriety throughout the country.

Upon reading it, Franc, by now living on a commune in United Contana with his wife and son, reached out to you for reconciliation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

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
  - -> `[105]`

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
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son somewhere in the Arcasian suburbs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

You barely heard from Franc. All you knew was that he was living with his wife and son on a commune somewhere in United Contana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son in the Arcasian suburbs, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "1965|Holsord"]** — Mówca: **Narrator**
> "You threw yourself into your teaching career as your presidency began to fade from Sordish memory.

Franc, by now living with his wife and son on a commune in United Contana, came to visit from time to time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_holsord");)*
- **Efekt (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monicaspeech");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monicaspeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_blue");)*
- **Efekt (`userScript`):** `PrologueImage("pe_blue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed");)*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_relaxed");)*
- **Efekt (`userScript`):** `PrologueImage("pe_relaxed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true ||BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
