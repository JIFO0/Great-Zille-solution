# Sordland/Turn10/DINNER ALONE

- **ID konwersacji:** `216`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/216_DINNER_ALONE.md`
- **Liczba węzłów dialogowych:** 109
- **Liczba wyborów gracza:** 15

---

## 1. Uczestnicy Sceny

- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Public_Opinion`
- `BaseGame.Rumburg_AttacksSordland`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[48]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[98]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- Węzeł `[107]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- Węzeł `[108]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[48]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Get a beer from the fridge."]** — Mówca: **Player_Italic**
> "I grabbed a beer from the fridge, went to the living room and turned on the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Go straight to the living room and turn on the TV."]** — Mówca: **Player_Italic**
> "I went to the living room and turned on the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I was right on time for the game to start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[22]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president. At least my own football team still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term. At least my own football team still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president. At least Anrica still liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[42]`
Mówca: **Narrator**
> "I couldn't even watch a football game without being reminded of everything I'd done wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "And everyone I'd lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Monica..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Franc and Deana..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Petr..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Poor Serge..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Where would it end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Narrator**
> "As the game began, I found I couldn't even pay attention to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I was too busy thinking about everything I had left to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Narrator**
> "My party had abandoned me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Narrator**
> "My military had turned against me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Narrator**
> "The Court wanted me removed from office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Narrator**
> "And I'd signed part of my country over to Rumburg..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AttacksSordland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AttacksSordland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_AttacksSordland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_AttacksSordland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_AttacksSordland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Narrator**
> "And Rumburg was on our doorstep..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Public_Opinion"] > 1  or  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Won == true || BaseGame.Public_Opinion > 1 || BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true  or  Variable["BaseGame.Public_Opinion"] > 1  or  Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Narrator**
> "At least I was on track to win another term. But was that what I even wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[78]`
Mówca: **Narrator**
> "My chances of re-election were slim, to say the least. And was that what I even wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Yes."]** — Mówca: **Player_Italic**
> "I smiled to myself. My entire life had built up to this presidency. I had to keep going."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "No."]** — Mówca: **Player_Italic**
> "No, it wasn't. Admitting that to myself felt like a heavy weight being lifted off my shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[86]`
Mówca: **Narrator**
> "The end of my term suddenly felt years away. If I stayed in Sordland, would I even make it to retirement?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[95]`
  - -> `[105]`

### Węzeł `[87]`
Mówca: **Narrator**
> "No matter what -- or who -- it would cost me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Stick with your plan to retire."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I would stick it out until the end of my term -- but no longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Narrator**
> "My entire life had built up to this presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "The end of my term suddenly felt ages away. And if I continued in politics, the years after that would just be more of the same..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`
  - -> `[105]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "Stop contemplating and go to bed."]** — Mówca: **Player_Italic**
> "I willed myself to stop overthinking everything. I was tired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
