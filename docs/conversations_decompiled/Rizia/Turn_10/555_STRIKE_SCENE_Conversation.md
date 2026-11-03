# Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation

- **ID konwersacji:** `555`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/555_STRIKE_SCENE_Conversation.md`
- **Liczba węzłów dialogowych:** 196
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Success`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.DiscussedFestiburu`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Panel_RoyalDecrees`
- `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[350] Rizia/Turn 10/Birthday_Gathering** (../Turn_10/350_Birthday_Gathering.md), Węzeł `[169]`
- Węzeł `[4]` -> **[563] Rizia/Turn 10/STRIKE SCENE/PRE-STRIKE ABSOLUTIST KING SPEECH/PRE-STRIKE ABSOLUTIST KING SPEECH Conversation** (../Turn_10/563_PRE-STRIKE_ABSOLUTIST_KING_SPEECH_Conversation.md), Węzeł `[1]`
- Węzeł `[44]` -> **[558] Rizia/Turn 10/STRIKE SCENE/INTRO_ABDICATION/ABOLISHMENT/INTRO_ABDICATION/ABOLISHMENT Conversation** (../Turn_10/558_ABOLISHMENT_Conversation.md), Węzeł `[1]`
- Węzeł `[45]` -> **[557] Rizia/Turn 10/STRIKE SCENE/INTRO_REFORM/INTRO_REFORM Conversation** (../Turn_10/557_INTRO_REFORM_Conversation.md), Węzeł `[1]`
- Węzeł `[60]` -> **[566] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation** (../Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md), Węzeł `[1]`
- Węzeł `[65]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[1]`
- Węzeł `[134]` -> **[564] Rizia/Turn 10/STRIKE SCENE/RustyReformSuccess/RustyReformSuccess Conversation** (../Turn_10/564_RustyReformSuccess_Conversation.md), Węzeł `[1]`
- Węzeł `[152]` -> **[565] Rizia/Turn 10/STRIKE SCENE/REVOLUTIONARIES SUCCESS BRANCH/REVOLUTIONARIES SUCCESS BRANCH Conversation** (../Turn_10/565_REVOLUTIONARIES_SUCCESS_BRANCH_Conversation.md), Węzeł `[1]`
- Węzeł `[188]` -> **[556] Rizia/Turn 10/STRIKE SCENE/INTRO_NONREFORM/INTRO_NONREFORM Conversation** (../Turn_10/556_INTRO_NONREFORM_Conversation.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 15

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Panel_RoyalDecrees`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[19]` (Paskal Beniwoll): `--;`
- Węzeł `[77]` (Paskal Beniwoll): `-- REFORM/REVOLUTION;`
- Węzeł `[151]` (Paskal Beniwoll): `--;`
- Węzeł `[152]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike"] = true;`
- Węzeł `[153]` (Paskal Beniwoll): `RemoveConversant("Estela Toras"); ;`
- Węzeł `[157]` (Paskal Beniwoll): `RemoveConversant("Vina Toras"); ;`
- Węzeł `[188]` (Paskal Beniwoll): `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- Węzeł `[189]` (Paskal Beniwoll): `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
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
  - -> `[121]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `350` (*Rizia/Turn 10/Birthday_Gathering*), Węzeł `[169]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `563` (*Rizia/Turn 10/STRIKE SCENE/PRE-STRIKE ABSOLUTIST KING SPEECH/PRE-STRIKE ABSOLUTIST KING SPEECH Conversation*), Węzeł `[1]`

### Węzeł `[5]`
Mówca: **Narrator**
> "And that’s when we heard it -- a piercing scream from the library, followed by a series of loud bangs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Everyone turned toward the noise, their faces drained of color."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Betrayal has its consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprise!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Choices are the architecture of fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please remain seated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ITS_A_TRAP_hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The bell has been rung, and its sound cannot be unstruck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_WarnedAboutCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_WarnedAboutCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_WarnedAboutCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[10]`
  - -> `[72]`
  - -> `[16]`
  - -> `[73]`
  - -> `[9]`
  - -> `[15]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "Raise your glass. [Signal for attack]"]** — Mówca: **Player_Romus_Italic**
> "I grabbed my glass and held it up high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "It was subtle, but it was enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""To my mother, Queen Estela, and to the future of Rizia!" [Signal for attack]"]** — Mówca: **Player_Romus**
> ""To my mother, Queen Estela, and to the future of Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I raised my glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[24]`
Mówca: **Narrator**
> "As we lifted our glasses, the doors clicked shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RaiseAToast_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[20]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ITS_A_TRAP_hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[28]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men, who was disguised as a server, and gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[36]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men who was already inside the room, blending in with the security guards. I gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `558` (*Rizia/Turn 10/STRIKE SCENE/INTRO_ABDICATION/ABOLISHMENT/INTRO_ABDICATION/ABOLISHMENT Conversation*), Węzeł `[1]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `557` (*Rizia/Turn 10/STRIKE SCENE/INTRO_REFORM/INTRO_REFORM Conversation*), Węzeł `[1]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[47]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men, who was disguised as a server, and gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[48]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men who was already inside the room, blending in with the security guards. I gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ITS_A_TRAP_hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you might say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it was worth a try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How unfortunate. For you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `566` (*Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation*), Węzeł `[1]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
Mówca: **Narrator**
> "And that’s when it began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `559` (*Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation*), Węzeł `[1]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_AbdicationPath == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_AbdicationPath == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "Watch in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave you a peaceful way out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // REFORM/REVOLUTION)*
- **Efekt (`userScript`):** `-- REFORM/REVOLUTION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[85]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[78]`
Mówca: **Narrator**
> "There was a brief pause, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Narrator**
> "With a rustling of formalwear, the other Torases and the heads of House Sazon and House Azaro got up and followed me into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to spoil the fun, but it's time I had a talk with my fellow royal houses. Please come to the trophy room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's one renovation that hasn't been unveiled yet -- the new trophy room. Would the leaders of each house be so kind as to follow me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies and gentlemen, heads of each House, I ask that you join me in private for a brief discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the pleasantries. I need the leaders of each house to come with me. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
Mówca: **Vina Toras**
> ""Is something wrong, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[129]`
  - -> `[97]`
  - -> `[104]`
  - -> `[91]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, dear. I need you to stay here and entertain your grandmother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""It seems I'm not invited either, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[130]`

### Węzeł `[93]`
Mówca: **Narrator**
> "A flash of disappointment crossed Vina's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy your birthday, Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll update you later when the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’re not missing anything you'd want to see, believe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll fill you in later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[98]`
Mówca: **Estela Toras**
> ""If you say so, but that sounds rather ominous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Estela Toras**
> ""How convenient. Well, somebody's got to keep the lesser nobles entertained during your secret chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Estela Toras**
> ""I'd enjoy it a lot more if I knew what mischief my son was planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "I kissed Mother on the cheek before stepping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[153]`

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""What are you up to, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`
  - -> `[111]`
  - -> `[124]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing after Grandmother, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedFestiburu == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedFestiburu == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedFestiburu == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedFestiburu"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Narrator**
> "She tilted her head in annoyance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Estela Toras**
> ""I see. So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[130]`

### Węzeł `[109]`
Mówca: **Vina Toras**
> ""So I'm not invited. Got it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""I don't recall ordering a festiburu. What's really going on, darling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[130]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m simply handling something that requires my immediate attention, that's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Estela Toras**
> ""How conveniently cryptic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[130]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, Mother. We'll be back out before you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Up to? Nothing in the slightest. Just a little... royal housekeeping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedFestiburu == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DiscussedFestiburu == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DiscussedFestiburu == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DiscussedFestiburu"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[95]`
  - -> `[94]`
  - -> `[130]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Several catering staff were already present, moving briskly to rearrange chairs and set out refreshments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.Reform_Path"] == true)  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.Reform_Path"] == true)  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, mother. Change will happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the opposite. I'm about to convince the houses to finally listen to the people's demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Vina. I need to talk to them about something you'll surely approve of. Just trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll talk to you in a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [ITS_A_TRAP_hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `564` (*Rizia/Turn 10/STRIKE SCENE/RustyReformSuccess/RustyReformSuccess Conversation*), Węzeł `[1]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Angelica Sazon**
> ""Good God! Is that... gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Manus Sazon**
> "Who’s shooting?! Why is there gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[143]`
Mówca: **Leona Sazon**
> ""Oh my God! Is that gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[144]`
Mówca: **Narrator**
> "At that precise moment, the man concealed behind Titus' guards sprang into action, swiftly disarming one of them and hurling a smoke grenade with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "The sound of glass shattering rang through the room as armed men entered through broken windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[149]`
Mówca: **Narrator**
> "The catering staff, who had been moving quietly among the nobles in the trophy room, pulled out weapons from beneath platters, aprons, and serving trays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Others, concealed in the shadows and alcoves of the room, sprang into action, attacking the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `565` (*Rizia/Turn 10/STRIKE SCENE/REVOLUTIONARIES SUCCESS BRANCH/REVOLUTIONARIES SUCCESS BRANCH Conversation*), Węzeł `[1]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[158]`
Mówca: **Narrator**
> "My wife rose from her seat warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Romus, is there something you haven't been telling me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`
  - -> `[165]`
  - -> `[166]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All will be revealed. Just walk this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever happens next, I want you to know that I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep your father from doing anything stupid. That's all I ask of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a routine check-in with the houses. Why would I need to tell you about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[167]`
Mówca: **Narrator**
> "As I crossed the room, Pabel intercepted me. He kept a forced smile on his face as he spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Something you haven't been telling me, Rom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`
  - -> `[176]`
  - -> `[175]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All will be revealed. Just keep the wine flowing out here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever happens next, I want you to know that I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all part of what we talked about. Soon, we'll be able to be together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a routine check-in with the houses. Why would I need to tell you about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Pabel Adria**
> ""Sure. Whatever you say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""As an Azaro and your wife, I'd say I deserve to be filled in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""I don't like the sound of that at all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""I love you too, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Lucita Azaro**
> ""All right, Your Majesty. I trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[184]`
Mówca: **Narrator**
> "As she walked into the room, her hand instinctively wandered towards the holster where I knew she kept her dagger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[185]`
Mówca: **Pabel Adria**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[186]`
Mówca: **Pabel Adria**
> ""I love you too, But please don't do anything rash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[187]`
Mówca: **Pabel Adria**
> ""Just don't do anything rash. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `556` (*Rizia/Turn 10/STRIKE SCENE/INTRO_NONREFORM/INTRO_NONREFORM Conversation*), Węzeł `[1]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Traitor", "R_Traitor_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Traitor","R_Traitor_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BallGunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BallGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Explosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_Adarfo_Usurped = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("AbsolutistStrikeFallout");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("AbsolutistStrikeFallout");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Panel_RoyalDecrees = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Daria De Rava");)*
- **Efekt (`userScript`):** `RemoveConversant("Daria De Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
