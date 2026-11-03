# Sordland/Turn10/Election + closing statements

- **ID konwersacji:** `238`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/238_Election_+_closing_statements.md`
- **Liczba węzłów dialogowych:** 245
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Democratic`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Debate_SpacePromise`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_MansounLeke`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[229] Sordland/Turn10/A_Debate** (../Turn_10/229_A_Debate.md), Węzeł `[99]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[220]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- Węzeł `[225]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- Węzeł `[227]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false; Variable["BaseGameIsolated.Debate...`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `229` (*Sordland/Turn10/A_Debate*), Węzeł `[99]`

### Węzeł `[3]`
Mówca: **Moderator**
> ""Uh, it appears we have time for one last question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Moderator**
> ""President Rayne, given this country's rather turbulent political history...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Moderator**
> ""Will you accept the results of the election, whatever they are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[9]`
  - -> `[12]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""What kind of a question is that? Of course I'll accept the results.""]** — Mówca: **Player**
> ""What kind of a question is that? Of course I'll accept the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I will respect what the people of Sordland decide.""]** — Mówca: **Player**
> ""I will respect what the people of Sordland decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""I accepted the results when the USP voted me out, didn't I?""]** — Mówca: **Player**
> ""I accepted the results when the USP voted me out, didn't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Yes. But I pledge I will never stop fighting for my beliefs.""]** — Mówca: **Player**
> ""Yes. But I pledge I will never stop fighting for my beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Denis Stahler**
> ""Ha! Listen to this man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[17]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who promised change, only to warp the constitution to suit his own desires?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who promised change, only to attempt to warp the constitution to suit his own desires?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Denis Stahler**
> ""You're going to trust someone who fabricated an emergency as an excuse to seize power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Moderator**
> ""Mr. Stahler, my question was for the President alone. Please don't interrupt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_DenisChallenge == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_DenisChallenge"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_DenisStahler == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Denis looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Mansoun looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Manoly looked like she wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Frens looked like he wanted to say something, but thought better of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[46]`
Mówca: **Frens Ricter**
> ""The mere fact that you have to ask that question is proof that Sordland is far from the democracy it must become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Manoly Suheil**
> ""The mere fact that you have to ask that question is proof that Sordland is far from the democracy it must become.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Moderator**
> ""Right. I'd like to end the evening by allowing each candidate to make a short closing statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Denis looked at the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""This is such a disrespectful question to ask a sitting president. The leader of Sordland shall stay in power for however long its people and God will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I couldn't have said that better myself.""]** — Mówca: **Player**
> ""I couldn't have said that better myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""And that's the reason I left the USP.""]** — Mówca: **Player**
> ""And that's the reason I left the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Surely this is a disrespectful question to ask a sitting president. The leader of Sordland shall stay in power for however long its people and God will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Remus Holstron**
> ""How dare you ask that of a sitting president? The leader of Sordland shall stay in power for however long is the Sords and God wills it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""If there is a God, you will never become president.""]** — Mówca: **Player**
> ""If there is a God, you will never become president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""She was well within her right to ask that. The president must never be elevated above anyone else.""]** — Mówca: **Player**
> ""She was well within her right to ask that. The president must never be elevated above anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_DenisChallenge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_DenisChallenge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_DenisStahler == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Denis Stahler**
> ""No further comment. The events of this evening speak for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[79]`
Mówca: **Mansoun Leke**
> ""I agree. No further comment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""I have nothing to add. I trust the Sordish people will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[84]`
Mówca: **Manoly Suheil**
> ""I have nothing to add. I trust the Sordish people will make the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Mansoun Leke**
> "Mansoun looked at Denis' empty chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Mansoun Leke**
> ""I won't comment further. The events of this evening speak for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Frens looked at Denis and Mansoun's empty chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Manoly looked at Denis and Mansoun's empty chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Lileas Graf**
> ""Well, I will say something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""People of Sordland, I have watched this man lead our great country astray. Place your trust in me, and I will put us back on the path that the Lord chose for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Kesaro Kibener**
> ""Whatever differences of opinion President Rayne and I expressed during this debate, the NFP is prepared to stand with him and his party. For a Sordland that truly belongs to the Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""For a Sordland that truly belongs to its own people, there is only one way to vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Remus Holstron**
> ""I am a man of action, not of words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Remus Holstron**
> ""Vote NFP. For a Sordland that truly belongs to the Sords. We shall realise our destiny as a great people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Moderator**
> ""President Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[145]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[114]`
Mówca: **Denis Stahler**
> ""I am grateful to the President for finally paving the way for my party into Assembly. But I ask you: Why stop there? Sordish Socialism is upon our doorstep. All that is left to do is embrace it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Denis Stahler**
> ""My party spent years shut out of assembly while the voices of thousands of Sords were denied. It is time for a new way forward. The People's Front is the future Sordland deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[122]`
Mówca: **Denis Stahler**
> ""Join our coalition and we promise equality for every man and woman, every Blud and Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
Mówca: **Mansoun Leke**
> ""Now that smaller parties have been given a voice, it is time to rise up and make your own heard. Man or woman, Blud or Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Frens Ricter**
> ""I know Sordland is ready for democracy. Under the PFJP, you will enjoy a freedom you have never known before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[131]`
Mówca: **Manoly Suheil**
> ""My predecessor Frens Ricter believed that Sordland was finally ready for democracy. It's time for the people to prove him right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I've already said everything I need to say. Thank you for a pleasant evening.""]** — Mówca: **Player**
> ""I've already said everything I need to say. Thank you for a pleasant evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Why accept my opponents' mediocre promises when you could have... the moon?""]** — Mówca: **Player**
> ""Why accept my opponents' mediocre promises when you could have... the moon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""People of Sordland... we have only just begun.""]** — Mówca: **Player**
> ""People of Sordland... we have only just begun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""A new day began to dawn. We must not abandon what we started.""]** — Mówca: **Player**
> ""A new day began to dawn. We must not abandon what we started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Moderator**
> ""Very well. Thanks to all the candidates for your time tonight. The Sordish Broadcasting Corporation wishes all our viewers a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Narrator**
> "She motioned to the crew, and the cameras stopped rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[144]`
Mówca: **Frens Ricter**
> ""Whatever differences President Rayne and I expressed during this debate, our alliance still stands. No matter who wins, we will govern together to bring Sordland a freedom it has never known before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_SpacePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_SpacePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_SpacePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_SpacePromise"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I understand your concerns given my predecessors' attempts to cling to power. But I swear I will serve only as long as the people want me.""]** — Mówca: **Player**
> ""I understand your concerns given my predecessors' attempts to cling to power. But I swear I will serve only as long as the people want me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Of course, there's always the possibility of election fraud, in which case I will fight to make sure the will of the people is respected.""]** — Mówca: **Player**
> ""Of course, there's always the possibility of election fraud, in which case I will fight to make sure the will of the people is respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_DenisStahler == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[162]`
Mówca: **Moderator**
> ""Um...with those who remain at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[163]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[165]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[166]`
Mówca: **Narrator**
> "The moderator took a minute to regain her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[168]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[181]`
  - -> `[226]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[173]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[174]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[183]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[183]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[184]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[191]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[194]`
  - -> `[200]`
  - -> `[195]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[194]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[199]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[204]`
  - -> `[203]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[201]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[190]`

### Węzeł `[202]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[203]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[211]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[212]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[216]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic < -10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[224]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""The Red Youth were out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth were out of control. You should have done something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[228]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[229]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[231]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[232]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[233]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Calm == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Denis Stahler**
> ""You claimed to understand the plight of the common man back in Narbel. But it was all an act, wasn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[241]`
Mówca: **Denis Stahler**
> ""Ever since our confrontation in Narbel I've known exactly what kind of man you were, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
