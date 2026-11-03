# Sordland/Turn10/DINNER WITH ONLY FRANC

- **ID konwersacji:** `217`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/217_DINNER_WITH_ONLY_FRANC.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 94

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn09_StrongWomensRights_Vetoed`
- `BaseGame.Bill_Turn09_WeakWomensRights_Vetoed`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.JoinParty_CPS`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.JoinParty_WPB`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `GameCondition.Turn09_Personal_PetrFuneral`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[51]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 15

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[278]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[280]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[291]` (Paskal Beniwoll): `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- Węzeł `[296]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[313]` (Paskal Beniwoll): `Variable["BaseGame.Exile_LeaveNow"] = true;`
- Węzeł `[323]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[324]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Exile"] = true;`
- Węzeł `[337]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- *...oraz 7 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `213` (*Sordland/Turn10/Personal_FinalSupper*), Węzeł `[51]`

### Węzeł `[3]`
Mówca: **Narrator**
> "I'd had the chef prepare barbecued ribs for the occasion. I hoped they were still his favorite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Nearly half an hour after he said he'd be there, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""You're late.""]** — Mówca: **Player**
> ""You're late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Is everything all right?""]** — Mówca: **Player**
> ""Is everything all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Franc**
> ""Yeah, I know. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[8]`
Mówca: **Franc**
> ""Yeah, yeah. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[9]`
Mówca: **Franc**
> ""Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[13]`
Mówca: **Franc**
> ""I ran into a couple of my friends protesting outside your gates. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[25]`

### Węzeł `[19]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I know. I still can't believe nobody was hurt.""]** — Mówca: **Player**
> ""I know. I still can't believe nobody was hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Franc**
> ""Mom would kill me for telling you this, but she was really worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[46]`

### Węzeł `[31]`
Mówca: **Franc**
> ""I know. I can't believe he's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Franc**
> ""Mom was inconsolable about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[46]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""How is your mother, anyway?""]** — Mówca: **Player**
> ""How is your mother, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[34]`
Mówca: **Franc**
> ""I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""So when's the wedding?""]** — Mówca: **Player**
> ""So when's the wedding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa, sprawled out in a chair and sniffed the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Franc**
> ""Nice. Mom never makes ribs at her new place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Franc**
> ""That's what Mom always says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[46]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""How is Deana?""]** — Mówca: **Player**
> ""How is Deana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Franc shrugged uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Franc**
> ""She's fine, I guess. She's spending a lot of time volunteering with the Sordish League of Women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Franc**
> ""She won't tell me who she's voting for, except that it sure as hell isn't Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[53]`
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""That's a relief.""]** — Mówca: **Player**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Who are you voting for? Now that you're old enough.""]** — Mówca: **Player**
> ""Who are you voting for? Now that you're old enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[55]`
Mówca: **Franc**
> ""She won't tell me who she's voting for, but I think she's leaning PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[56]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""That's not surprising.""]** — Mówca: **Player**
> ""That's not surprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course it does. Every vote counts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[58]`
Mówca: **Franc**
> ""Jeez, Dad. Not everything is about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn09_Personal_PetrFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Franc**
> ""I mean, I think between the divorce, Serge and Petr, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(GameCondition.Turn09_Personal_PetrFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Franc**
> ""I mean, I think between the divorce and Petr, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Franc**
> ""I mean, I think between the divorce and Serge, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Franc**
> ""I mean, I think she's been taking the divorce pretty hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[75]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""And you haven't?""]** — Mówca: **Player**
> ""And you haven't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""And I haven't?""]** — Mówca: **Player**
> ""And I haven't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[74]`
Mówca: **Franc**
> ""It's different. I'm older.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[120]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""What about your mother?""]** — Mówca: **Player**
> ""What about your mother?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Old enough to vote, even.""]** — Mówca: **Player**
> ""Old enough to vote, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[80]`
Mówca: **Franc**
> ""Does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[84]`
Mówca: **Franc**
> ""Although it doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[85]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I suppose not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[89]`
Mówca: **Franc**
> ""Who will you vote for, Dad? Now that you're out of the running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Franc raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Franc**
> ""Huh. Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[96]`
Mówca: **Franc**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[97]`
Mówca: **Franc**
> ""Who would you vote for? I mean, if you weren't in the running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[102]`

### Węzeł `[98]`
Mówca: **Franc**
> ""I'm voting for the candidate who...buys me a car?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""Nice try, but no.""]** — Mówca: **Player**
> ""Nice try, but no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""You want it, you got it.""]** — Mówca: **Player**
> ""You want it, you got it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps one of the small parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_NFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_NFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[101]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_PFJP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.JoinParty_CPS"] == true  or  Variable["BaseGame.JoinParty_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[93]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.JoinParty_CPS"] == true  or  Variable["BaseGame.JoinParty_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[111]`
Mówca: **Narrator**
> "The oven timer went off. I took out the ribs and brought them to the dining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "After we'd eaten, Franc kept toying with his fork. He looked preoccupied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""What is it?""]** — Mówca: **Player**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Was dinner all right?""]** — Mówca: **Player**
> ""Was dinner all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Franc**
> ""Yeah, it was great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Franc looked down at the tablecloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Yes, I can see that.""]** — Mówca: **Player**
> ""Yes, I can see that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == false  and  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Public_Opinion"] < 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == false  and  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Public_Opinion"] < 0)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[124]`
Mówca: **Franc**
> ""Dad, have you thought about quitting politics? I don't just mean dropping out of the race -- I mean retiring altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Franc**
> ""Dad, I think you should leave Sordland. It isn't safe here anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""What gave you that idea? The bullets just barely whistling past my skull?""]** — Mówca: **Player**
> ""What gave you that idea? The bullets just barely whistling past my skull?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""That's ridiculous. I can take care of myself.""]** — Mówca: **Player**
> ""That's ridiculous. I can take care of myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It's crossed my mind once or twice.""]** — Mówca: **Player**
> ""It's crossed my mind once or twice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Never.""]** — Mówca: **Player**
> ""Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Are you insane, son?""]** — Mówca: **Player**
> ""Are you insane, son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Franc**
> ""It's just that... Deana told me she's getting bullied in school because of you. I've lost friends in the past months just for having the last name Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[132]`
Mówca: **Franc**
> ""Everything was so much easier before this. I think you were happier, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[133]`
Mówca: **Franc**
> ""I'm not talking about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Franc**
> ""There's no guarantee that the same people who want you dead won't also come after Monica and Deana. Or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[136]`
  - -> `[138]`

### Węzeł `[135]`
Mówca: **Franc**
> ""That might have had something to do with it, yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""No. I'm the target.""]** — Mówca: **Player**
> ""No. I'm the target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""You're watching too many conspiracy thrillers.""]** — Mówca: **Player**
> ""You're watching too many conspiracy thrillers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Franc**
> ""They killed Serge, didn't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Franc**
> ""They almost killed Serge, didn't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Franc**
> ""Haven't you thought about just laying low for a while?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I already said I'd retire. Isn't that enough?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[146]`
Mówca: **Franc**
> ""And my politics professors said you don't have a chance of winning anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`
  - -> `[149]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""What? I'll show those eggheads!""]** — Mówca: **Player**
> ""What? I'll show those eggheads!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I can't give up now, Franc. You're too young to understand.""]** — Mówca: **Player**
> ""I can't give up now, Franc. You're too young to understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I didn't know how hard it was for you kids. I'm sorry.""]** — Mówca: **Player**
> ""I didn't know how hard it was for you kids. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Franc**
> ""Trust me, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Franc**
> ""Just think about it. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[157]`
  - -> `[153]`
  - -> `[241]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I'd rather leave the country than admit defeat.""]** — Mówca: **Player**
> ""I'd rather leave the country than admit defeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
Mówca: **Franc**
> ""That's a little extreme. But sure, it might not hurt to lay low for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'll do better going forward. I won't let you down.""]** — Mówca: **Player**
> ""I'll do better going forward. I won't let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""You've made your point. I will.""]** — Mówca: **Player**
> ""You've made your point. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't it enough that your mother and I are divorced?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""I could go to Kyrute. It's the only truly neutral country on the continent.""]** — Mówca: **Player**
> ""I could go to Kyrute. It's the only truly neutral country on the continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Franc**
> ""I don't know! Who knows what these people want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Franc**
> ""Yes! Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Franc**
> ""Just think about it. I'm serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""All right, Franc. I will.""]** — Mówca: **Player**
> ""All right, Franc. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""You should go home, Franc.""]** — Mówca: **Player**
> ""You should go home, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Franc**
> ""Thanks, Dad. And thanks for dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[314]`

### Węzeł `[174]`
Mówca: **Franc**
> ""All right. Stay in denial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Franc**
> ""That's all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""You should go home, Franc. It's late.""]** — Mówca: **Player**
> ""You should go home, Franc. It's late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Franc**
> ""And seriously, think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[181]`
Mówca: **Franc**
> ""Dad, I can't keep coming over here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[185]`
  - -> `[184]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""What? Why?""]** — Mówca: **Player**
> ""What? Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Is it because of... how you got into Holsord State?""]** — Mówca: **Player**
> ""Is it because of... how you got into Holsord State?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[184]`
**[WYBÓR GRACZA: ""What has your mother been telling you about me?""]** — Mówca: **Player**
> ""What has your mother been telling you about me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[191]`
Mówca: **Franc**
> ""Not to mention the way everyone's been treating me since they found out how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[192]`
Mówca: **Franc**
> ""Well, yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Franc**
> ""I've been the laughing stock of the school since the news came out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Franc**
> ""I worked so hard to prove I belonged there. I was actually getting good grades for the first time in my life! But now everyone thinks I'm just a daddy's boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`
  - -> `[197]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""Would you rather have gone into the military?""]** — Mówca: **Player**
> ""Would you rather have gone into the military?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Cry me a river. Your problems are nothing compared to mine.""]** — Mówca: **Player**
> ""Cry me a river. Your problems are nothing compared to mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA: ""I'm sorry. I had no idea that would get leaked.""]** — Mówca: **Player**
> ""I'm sorry. I had no idea that would get leaked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
Mówca: **Franc**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
Mówca: **Franc**
> ""That makes this easier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Franc**
> ""I guess we both should have prepared for something like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Franc**
> ""But I think I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[202]`
Mówca: **Franc**
> ""In any case, I think I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Franc**
> ""I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Franc**
> ""I need to show them I'm more than just Anton Rayne's son. And the more contact I have with you, the harder that will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""All right. I understand.""]** — Mówca: **Player**
> ""All right. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Part of being your own man is not caring what other people think.""]** — Mówca: **Player**
> ""Part of being your own man is not caring what other people think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Great. So my whole family won't see me now.""]** — Mówca: **Player**
> ""Great. So my whole family won't see me now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Franc shifted nervously in his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Slapped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[212]`
Mówca: **Franc**
> ""Well, Mom and Deana... you kind of brought that on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[213]`
Mówca: **Franc**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Franc**
> ""I've been talking to Mom. About why she left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Franc**
> ""I've been the laughing stock of Holsord State since the news came out about how I got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Franc winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Franc**
> ""Look, I don't know the full story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Franc**
> ""But if it's anything like what she said, it was bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[226]`
  - -> `[234]`
  - -> `[245]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Slapped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WYBÓR GRACZA: ""I didn't mean to hit her.""]** — Mówca: **Player**
> ""I didn't mean to hit her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
**[WYBÓR GRACZA: ""Curtan Leste made me do it.""]** — Mówca: **Player**
> ""Curtan Leste made me do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
**[WYBÓR GRACZA: ""The Assembly members would've eaten her alive if I'd let her work with Ciara.""]** — Mówca: **Player**
> ""The Assembly members would've eaten her alive if I'd let her work with Ciara.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I had to veto that bill. There were bigger forces at work.""]** — Mówca: **Player**
> ""I had to veto that bill. There were bigger forces at work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Franc**
> ""Come on, Dad. This was the one thing she wanted out of your presidency, and you took it away from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Franc**
> ""I've been learning a lot about women's rights at university. I mean, I'm not one of those crazy 'male feminists', but I can sympathize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Franc**
> ""It's wrong that you always treated me so well while putting her down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[241]`
**[WYBÓR GRACZA: ""Sordland is counting on me. I won't let the country down just because your classmates are calling you names.""]** — Mówca: **Player**
> ""Sordland is counting on me. I won't let the country down just because your classmates are calling you names.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Franc**
> ""This was never about Sordland! It was only ever about you! God, Dad, can't you see that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[243]`
Mówca: **Franc**
> ""It doesn't matter what you meant!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[244]`
Mówca: **Franc**
> ""Well, the thing with Mom... you kind of brought that on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Franc, I know. I've been regretting it every day.""]** — Mówca: **Player**
> ""Franc, I know. I've been regretting it every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Franc**
> ""I don't know if that's enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Great. So my whole family hates me now.""]** — Mówca: **Player**
> ""Great. So my whole family hates me now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""You're too young to understand.""]** — Mówca: **Player**
> ""You're too young to understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Please, Franc. I've lost everyone else. I can't lose you too.""]** — Mówca: **Player**
> ""Please, Franc. I've lost everyone else. I can't lose you too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[250]`
Mówca: **Franc**
> ""I don't hate you. I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[251]`
Mówca: **Franc**
> ""That's bullshit. Listen, I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[252]`
Mówca: **Franc**
> ""You're not losing me. I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
Mówca: **Franc**
> ""Thanks, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Franc**
> ""You've got that luxury. I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[258]`
Mówca: **Franc**
> ""Good luck with the campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[259]`
Mówca: **Franc**
> ""Good luck with retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""You should go home, Franc. It's late.""]** — Mówca: **Player**
> ""You should go home, Franc. It's late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[263]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[264]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[297]`
  - -> `[293]`

### Węzeł `[265]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Narrator**
> "My political career had taken so much away from me. My wife and daughter, and now my son..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[267]`
Mówca: **Narrator**
> "And poor Serge..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[268]`
Mówca: **Narrator**
> "Petr..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == false  and (Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == false  and (Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[275]`
Mówca: **Narrator**
> "Where would it end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[277]`
  - -> `[348]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my decision to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "Go to bed."]** — Mówca: **Player_Italic**
> "I went to bed, trying not to think about my personal relationships. I had far too many other things on my plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[279]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[281]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[282]`
Mówca: **Narrator**
> "My entire life had built up to my presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[285]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[289]`
**[WYBÓR GRACZA: "Write a letter to Monica."]** — Mówca: **Player_Italic**
> "I went up to my office and began writing a letter to my ex-wife. Maybe after my retirement, we'd finally be able to work things out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[290]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_FinalSupper_Retired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[292]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[297]`
**[WYBÓR GRACZA: "Decide to ignore Franc's advice."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[298]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[299]`
  - -> `[304]`
  - -> `[305]`

### Węzeł `[299]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[300]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[301]`
Mówca: **Narrator**
> "My entire life had built up to this presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[302]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[303]`
Mówca: **Narrator**
> "I went to bed, trying not to think about what the next weeks would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[304]`
**[WYBÓR GRACZA: "Stay in Sordland and retire from politics."]** — Mówca: **Player_Italic**
> "I sat down and began drafting a speech announcing my decision to retire from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[305]`
**[WYBÓR GRACZA: "Stay in Sordland and continue in politics."]** — Mówca: **Player_Italic**
> "I shook my head. What did Franc know? He was just a kid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[307]`
Mówca: **Narrator**
> "A little mountain house in the neutral country of Kyrute wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[312]`

### Węzeł `[308]`
**[WYBÓR GRACZA: "Take Franc's advice and leave the country."]** — Mówca: **Player_Italic**
> "My son was right. Leaving Sordland was the safest thing I could do for myself and my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[309]`
**[WYBÓR GRACZA: "Ignore Franc's advice and stick with your plan to retire."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Narrator**
> "I went to bed, trying not to think about what the next weeks would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[311]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[312]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Exile_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Retired == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Retired == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
**[WYBÓR GRACZA: "Stay in Sordland but end your political career."]** — Mówca: **Player_Italic**
> "Franc was right -- it was too dangerous to stay in politics. But I wasn't about to leave the country over it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
**[WYBÓR GRACZA: "Ignore Franc's advice and continue your political career."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[319]`
Mówca: **Narrator**
> "I went up to my office and began drafting a speech announcing my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Exile = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Damn. I would've thought she'd be happy to vote for a woman.""]** — Mówca: **Player**
> ""Damn. I would've thought she'd be happy to vote for a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[329]`
Mówca: **Franc**
> ""Who would you vote for? I mean, besides the folks you're backing now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[336]`
Mówca: **Franc**
> ""And my politics professors say your campaigning might actually hurt the candidate you're backing now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`
  - -> `[149]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
