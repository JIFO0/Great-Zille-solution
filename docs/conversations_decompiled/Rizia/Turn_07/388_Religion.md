# Rizia/Turn 7/Religion

- **ID konwersacji:** `388`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/388_Religion.md`
- **Liczba węzłów dialogowych:** 563
- **Liczba wyborów gracza:** 116

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia`
- `RiziaDLC.Decision_Turn07_InviteSalToHOD`
- `RiziaDLC.Diplomacy_Wehlen_AgreementRefused`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Policy_RD_Law_NurityStateReligion`
- `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[387] Rizia/Turn 7/Public Opinion** (../Turn_07/387_Public_Opinion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[562]` (Paskal Beniwoll): `RemoveConversant("Sal Ignacius"); -- Removes the conversant with the character name in database;`

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
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `387` (*Rizia/Turn 7/Public Opinion*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""Next on the agenda is a discussion regarding the current religious climate in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Daria de Rava**
> ""Next on the agenda was a discussion regarding the current religious climate in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "He looked uneasily at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""More specifically, King Romus' decision to remove our kingdom's state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""We are acutely aware of the important role that Wruhecism, and Nurity as a whole, plays in the lives of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""However, the RPP cautiously welcomes our kingdom's move towards a more secular state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""His Majesty's decree, however controversial, is a step towards ensuring all Rizians are equal before the law, regardless of what they believe in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Daria raised her hand to interject."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""The RNC has prepared a statement opposing this unprecedented and potentially destabilizing separation of Sanctuary and state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[24]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My decision was final. Any criticism of it will not be tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Destabilizing' is a little extreme, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Daria de Rava**
> ""Mr. Speaker, Your Majesty, the secularization of Rizia risks creating vast rifts in a society that can hardly afford more division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Daria de Rava**
> ""By erasing religious symbols and institutions from the public sphere, we are telling millions of citizens that the government no longer cares about their faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""If the goal is to create a more inclusive religious atmosphere in Rizia, we can do that without negating the principles that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""I will add that the opposition's arguments against the King's decree are not without merit. We must proceed with sensitivity or risk alienating a significant portion of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""The gentleman has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[38]`
Mówca: **Manus Sazon**
> ""And we know that this policy change has been met with resistance from all of Rizia's religious communities, be they Wruhecist, Golcondist or Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we are to progress as a nation, we must break the chains of religious dogma that shackle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not wish to discount the importance of religion to Rizians. I am merely trying to reduce its role in government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing man myself, I am sensitive to the needs of Rizia's religious communities. I will make sure nobody feels left out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""Absolutely, Your Majesty. Which is why we stand behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, we cannot force chains off of those who do not see themselves as shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty. My constituents will be comforted to know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. I have no doubt that your decree will open more doors for us than it will close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Manus Sazon**
> ""But I am sure we can transition away from state-enshrined Wruhecism while continuing to embrace faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[66]`
  - -> `[63]`

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""I am sure we can transition away from state-enshrined Wruhecism while embracing faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[71]`
  - -> `[66]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Law_NurityStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[55]`
Mówca: **Manus Sazon**
> ""More specifically, King Romus' decision to change our state religion to encompass all denominations of Nurity, not only Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Manus Sazon**
> ""We are acutely aware of the important role that Wruhecism plays in the lives of many of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""And we know that this policy change has been met with resistance from Wruhecist and Golcondist religious leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""However, the RPP welcomes our kingdom's move towards religious inclusivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Manus Sazon**
> ""His Majesty's decree is a step towards ensuring all Rizians are equal before the law, regardless of belief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Daria raised her hand to interject."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Daria de Rava**
> ""The RNC has prepared a statement opposing this unnecessary and potentially destabilizing dilution of our religious policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[75]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't put words in my mouth, Mr. Sazon. A truly egalitarian Rizian society has no room for archaic superstitions of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. As long as we don't place any one faith above the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those faiths do not espouse destructive values -- like Golcondism, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People may practice whatever they want in private. But they have no business forcing that practice on others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My decision was final. Any criticism of it will not be tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Destabilizing' is a little extreme, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""I am not being hyperbolic. The secularization of Rizia has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""Mr. Speaker, Your Majesty, the broadening of our state religion has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Daria de Rava**
> ""We are essentially telling the millions of Wruhecist believers in this country that their faith is no different from Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Daria de Rava**
> ""If the goal is to create a more inclusive religious atmosphere in Rizia, we can do that without negating the practices and traditions that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[95]`
  - -> `[89]`
  - -> `[91]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""I will add that the opposition's arguments against the King's decree are not without merit. We must proceed with caution or risk alienating a significant portion of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""He has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[95]`
  - -> `[89]`
  - -> `[91]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""Absolutely, Your Majesty. Which is why we stand behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the state religion to Nurity was only the first step in breaking the chains of religious dogma that shackle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is not a zero-sum game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. I have no doubt that your decree will open more doors for us than it will close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing Wruhecist myself, I understand these concerns. But spiritual openness is one of our core principles. Limiting our state religion to only one branch of Nurity is a betrayal of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[99]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, we cannot force chains off of those who do not see themselves as shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Manus Sazon**
> ""I am sure we can transition away from state-enshrined Wruhecism while continuing to embrace the Nurist faith in all of its forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[102]`
  - -> `[113]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now, yes. But a truly egalitarian Rizian society has no room for archaic superstitions of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""In light of our worsening tensions with Wehlen, it's important to send our Wehzek citizens the signal that they are still welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[116]`
  - -> `[111]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""In light of our new agreement with Wehlen, it's important to send our Wehzek citizens the signal that they are welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[116]`
  - -> `[111]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinion of Wehzeks is of no consequence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Our nation must unify beneath the umbrella of the great Nur.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those forms of Nurity do not espouse destructive values -- like Golcondism, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, this will go a long way towards reducing animosity between ethnic Rizians and those of Wehzek descent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Including Golcondism, as I'm sure I need not remind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""Superstitions?! Your Majesty--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[119]`
Mówca: **Narrator**
> "Hugo turned to me and spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Your Majesty, I urge you to take the opposition to your decree seriously. I too worry about its potential to alienate millions of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""Your Majesty, I urge you to take the opposition to your decree seriously. I too worry about its potential to alienate millions of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[95]`
  - -> `[89]`
  - -> `[91]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Hugo turned to me and spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""I am not speaking hyperbolically. The broadening of our state religion has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[127]`
Mówca: **Manus Sazon**
> ""More specifically, the encroachment of Wruhecism into previously secular areas of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[131]`
Mówca: **Manus Sazon**
> ""Our tax code, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""And our educational system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Manus Sazon**
> ""Our educational system, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Sal rose to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Sal Ignacius**
> ""The King has decided to reinforce the sacred laws of this land. It is blasphemous to question him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`
  - -> `[145]`
  - -> `[144]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[149]`
  - -> `[148]`
  - -> `[152]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and glorify the words of St. Wruhec?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit our House Speaker from expressing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its religious practices is essential for our spiritual health and unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit down, Grand Wiseman. I did not invite you here to speak for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[146]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are being inundated with non-Wruhecist newcomers. They must respect our state religion if they want to keep living here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you we are one of the few purely Wruhecist nations on this planet? We must do all we can to preserve our holy practices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[154]`
Mówca: **Manus Sazon**
> ""Migrants cannot be forced into accepting a religion that is not their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Manus Sazon**
> ""Where you see alignment, I see an attempt at forced indoctrination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Sal Ignacius**
> ""Pardon my interruption. It was the Lord who compelled me to defend our holy ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""Of course I acknowledge the long tradition of Wruhecism in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist-owned businesses that have had to close since the tax on non-Wruhecists was introduced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[163]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist Rizians who have had to pull their children out of school since our reforms were implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[167]`
Mówca: **Daria de Rava**
> ""More specifically, His Majesty's decision to remove our kingdom's state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[168]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't put words in my mouth, Mr. Sazon. I do not embrace any faith, and neither will this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. As long as we don't place any one faith above the others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those faiths do not espouse destructive values -- like Golcondism, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People may practice whatever they want in private. But they have no business forcing that practice on others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""A kingdom that publicly panders to the interests of migrants will never be seen as strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the state religion to Nurity was only the first step in breaking the chains of religious dogma that shackle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is not a zero-sum game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Daria de Rava**
> ""There is openness, and then there is the dilution of our values to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[185]`
Mówca: **Daria de Rava**
> ""We can acknowledge Dastnurists without enshrining their religion in national law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing Wruhecist myself, I understand the opposition. But spiritual openness is one of our core principles. Limiting our state religion to only one branch of Nurity is a betrayal of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[190]`
Mówca: **Daria de Rava**
> ""The RNC has made our position clear, Your Majesty. I will say no more about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and glorify the words of St. Wruhec?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit our House Speaker from expressing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its religious practices is essential for our spiritual health and unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit down, Grand Wiseman. I did not invite you here to speak for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[195]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are being inundated with non-Wruhecist newcomers. They must respect our state religion if they want to keep living here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you we are one of the few purely Wruhecist nations on this planet? We must do all we can to preserve our holy practices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Manus Sazon**
> ""Forcing migrants to embrace Wruhecism will only create resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Manus Sazon**
> ""Where you see alignment, I see an attempt at forced indoctrination, which will only create resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Sal Ignacius**
> ""Pardon my interruption. It was the Lord who compelled me to defend our holy ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Manus Sazon**
> ""Of course I acknowledge the long tradition of Wruhecism in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[208]`
Mówca: **Daria de Rava**
> ""By erasing religious symbols and institutions from the public sphere, we are telling millions of citizens that the government no longer cares about their faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Daria de Rava**
> ""We in the House of Delegates have no choice but to issue an official disproval of the King's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Narrator**
> "She banged her gavel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[243]`
  - -> `[242]`
  - -> `[248]`

### Węzeł `[211]`
Mówca: **Daria de Rava**
> ""And this recent policy change has been met with resistance from all of the country's religious communities, be they Wruhecist, Golcondist or Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""We all know that Rizia's Wruhecist roots can be traced back to the early years of the Rezenid Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""With this policy change, we are essentially telling millions of Wruhecist believers that their -- our -- faith is no different from Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""In the name of 'inclusivity', we risk erasing the unique practices and traditions that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[215]`
Mówca: **Narrator**
> "She raised her hand to bang the gavel. Manus quickly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Manus Sazon**
> ""And our educational system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[217]`
Mówca: **Manus Sazon**
> ""Madame Speaker, my party has prepared a defense of the change in state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Sal had risen to his feet. He gingerly sat back down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Law_NurityStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Law_NurityStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[222]`
Mówca: **Daria de Rava**
> ""More specifically, King Romus' decision to change our state religion to encompass all denominations of Nurity, not only Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[223]`
Mówca: **Manus Sazon**
> ""As Madame Speaker mentioned, my party and our constituents are worried about the government's religious overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[224]`
Mówca: **Manus Sazon**
> ""We see it in our tax code, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[225]`
Mówca: **Manus Sazon**
> ""We see it in our educational system, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[226]`
Mówca: **Daria de Rava**
> ""The House of Delegates has therefore decided to issue an official disproval of the King's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Sal rose to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""The King has decided to reinforce the sacred laws of this land. It is treasonous to question him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`
  - -> `[194]`
  - -> `[193]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[198]`
  - -> `[197]`
  - -> `[201]`

### Węzeł `[241]`
Mówca: **Daria de Rava**
> ""We all know that Rizia's Wruhecist roots can be traced back to the early years of the Rezenid Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing man myself, I am offended by your disproval. My intention was not to erase Wruhecism, but to allow all religions to flourish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your disproval has been noted. But Rizia will never return to the shackles of religious dogma.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon? No objections from your party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am offended by your disproval. My intention was not to erase Wruhecism, but to allow all religions to flourish in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[250]`
Mówca: **Daria de Rava**
> ""A kingdom without its spiritual center cannot survive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[254]`
Mówca: **Daria de Rava**
> ""Especially not in the middle of a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[255]`
Mówca: **Daria de Rava**
> ""Your Majesty... Wruhecism is an ancient denomination with millions of followers, none of whom would call themselves shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[256]`
  - -> `[261]`
  - -> `[259]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The shackles are invisible. That's what makes them so dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly egalitarian society has no room for archaic superstitions of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[258]`
Mówca: **Manus Sazon**
> ""Actually, Your Majesty, many of us in the RPP harbor reservations about your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[260]`
Mówca: **Daria de Rava**
> ""Religions cannot flourish in a kingdom that frowns on belief systems of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a meaningless distraction meant to keep the poor and downtrodden from questioning their lot in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Manus Sazon**
> ""Ultimately, religion should have no place in the economy of a modern nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`
  - -> `[269]`
  - -> `[270]`

### Węzeł `[266]`
Mówca: **Manus Sazon**
> ""Ultimately, a child's religious education should be decided on by their parents. Not mandated by the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`
  - -> `[280]`
  - -> `[273]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But look at the income the tax generates. It can be used to help the less fortunate, in line with Wruhecist principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand by my decision. Businesses cannot take advantage of our resources while ignoring our values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submit to Wruhecism or pay the price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Parents do not always know what is best for their children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are one of the few Wruhecist countries in this world. If we do not pass on our traditions, they will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. They should be instilled in children regardless of what their parents believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""I cannot disagree with that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[278]`
Mówca: **Narrator**
> "Manus choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""No. But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Providing each Rizian child with a Wruhecist education will foster a stronger sense of unity for future generations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""Isn't that what our religious institutions are for? Using public schools for this purpose will only foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[282]`
Mówca: **Manus Sazon**
> ""Or it will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[283]`
Mówca: **Manus Sazon**
> ""I worry that will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[284]`
Mówca: **Daria de Rava**
> ""I believe the King has made his position clear, Mr. Speaker. It is not up to us to debate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[286]`
Mówca: **Narrator**
> "Manus gave her a look of warning. She closed her mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[287]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Manus Sazon**
> ""While we are on that subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[289]`
Mówca: **Manus Sazon**
> ""While we are on the subject of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[290]`
Mówca: **Manus Sazon**
> ""Well, the RPP regards it as an important side effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[291]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[292]`
Mówca: **Manus Sazon**
> ""At the very least, we must not let religious differences divide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[293]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty. The House Speaker is overlooking the decree's obvious benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the new tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Manus looked down at his notes again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""By installing token Wruhecist CEOs, no doubt. But never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[299]`
Mówca: **Sal Ignacius**
> ""There will be no exclusion when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[300]`
Mówca: **Sal Ignacius**
> ""There will be no resentment when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[307]`
Mówca: **Narrator**
> "Frustration flashed across Manus' face. He kept it in check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Manus Sazon**
> ""Very well. But while we are on the subject of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[309]`
Mówca: **Narrator**
> "Manus hesitantly put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Manus Sazon**
> ""I must say that my party has reservations about this decree as well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Manus Sazon**
> ""We are in favor of ending religious discrimination in Rizia. But we must proceed with caution. We can't simply scrub religion from public life from one day to the next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""However... I am sure that under your leadership, we can transition away from state-enshrined Wruhecism while continuing to embrace faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[179]`
  - -> `[174]`
  - -> `[171]`

### Węzeł `[313]`
Mówca: **Daria de Rava**
> ""While we are on that subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[314]`
Mówca: **Daria de Rava**
> ""But while we are on the topic of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[315]`
Mówca: **Daria de Rava**
> ""The Delegates have given their ruling. Please drop the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`
  - -> `[318]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want to know the RPP's opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not attempt to silence your fellow delegates, Madame Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your support, Mr. Sazon, but your input is not needed. I stand by my decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Manus gave me a nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[186]`
  - -> `[180]`
  - -> `[182]`

### Węzeł `[320]`
Mówca: **Daria de Rava**
> ""Very well. You may proceed, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Manus Sazon**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Narrator**
> "He glanced at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Manus Sazon**
> ""The RPP welcomes this long-overdue move towards religious inclusivity in our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[324]`
Mówca: **Daria de Rava**
> ""Your Majesty... Wruhecism is an ancient denomination with millions of followers, none of whom would call themselves shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[325]`
  - -> `[327]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The shackles are invisible. That's what makes them so dangerous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly egalitarian society has no room for archaic superstitions of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a meaningless distraction meant to keep the poor and downtrodden from questioning their lot in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Daria de Rava**
> ""Superstitions?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[330]`
Mówca: **Daria de Rava**
> ""A meaningless distraction?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[331]`
Mówca: **Daria de Rava**
> ""But very well, Your Majesty. You have made yourself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[332]`
Mówca: **Daria de Rava**
> ""Very well, Your Majesty. You have made yourself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[333]`
Mówca: **Manus Sazon**
> ""It is long past time we acknowledge the growing numbers of Dastnurists in our society, and the contributions they make to this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Manus Sazon**
> ""And from what I can tell, the populace has welcomed the chance to celebrate twice as many public holidays as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "There was some polite laughter among the RPP delegates. Daria frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Daria de Rava**
> ""The King is diluting our thousand-year-old religious traditions, and you speak of holidays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[337]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[338]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[339]`
Mówca: **Manus Sazon**
> ""Of course that isn't the only benefit. We foresee great strides in Rizia's international relations in the wake of this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Manus Sazon**
> ""In light of our worsening tensions with Wehlen, it's important to send our Wehzek citizens the signal that they are still welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[348]`
  - -> `[346]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""In light of our new agreement with Wehlen, it's important to send our Wehzek citizens the signal that they are welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[348]`
  - -> `[346]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinion of Wehzeks is of no consequence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Our nation must unify beneath the umbrella of the great Nur.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""Well, the RPP regards it as an important side effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, this will go a long way towards reducing animosity between ethnic Rizians and those of Wehzek descent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Manus Sazon**
> ""At the very least, we must not let religious differences divide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Daria de Rava**
> ""Thank you, Mr. Sazon. You have made your position clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Daria de Rava**
> ""While we are on the topic of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Daria de Rava**
> ""I must mention the growing pressure from Golcondist communities to lift Rizia's blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[357]`
Mówca: **Daria de Rava**
> ""I must bring His Majesty's attention to to the aftermath of our lifting the Golcondist blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Manus Sazon**
> ""I must mention the growing pressure from Bludish and Derdian communities to lift our so-called blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[362]`
Mówca: **Manus Sazon**
> ""I must bring His Majesty's attention to the aftermath of our lifting the Golcondist blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[363]`
Mówca: **Daria de Rava**
> ""The opposition speaker had some comments regarding what he sees as an 'encroachment of Wruhecism' onto everyday life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Daria de Rava**
> ""I don't see the need to air these complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[367]`
  - -> `[366]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's always valuable to know the opposition's opinion. Go ahead, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor do I. We shall not change the religious direction of this country, not when so many of our citizens are finally starting to welcome God into their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would be curious to know what blasphemous thoughts Mr. Sazon has rolling about in his head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Narrator**
> "Manus cleared his throat. He glanced uneasily at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Narrator**
> "Manus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[373]`
Mówca: **Sal Ignacius**
> ""Halaita, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Daria de Rava**
> ""As the King proclaims, so it shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[378]`
Mówca: **Narrator**
> "She paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the recently imposed tax on non-Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will see the light, or they will pay the price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburgian corporations are wealthy. They can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there are all sorts of loopholes they can exploit if need be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. We still need Rumburg on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Daria de Rava**
> ""I have no doubt of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[389]`
Mówca: **Daria de Rava**
> ""The tax should not cost us the Queen's support. Not if we continue to help Rumburg in other ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist-owned businesses that have had to close since the tax on non-Wruhecists was introduced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist Rizians who have had to pull their children out of school since our reforms were implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Manus Sazon**
> ""Ultimately, religion should have no place in the economy of a modern nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`
  - -> `[399]`
  - -> `[400]`

### Węzeł `[396]`
Mówca: **Manus Sazon**
> ""Ultimately, a child's religious education should be decided on by their parents. Not mandated by the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`
  - -> `[410]`
  - -> `[403]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But look at the income the tax generates. It can be used to help the less fortunate, in line with Wruhecist principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand by my decision. Businesses cannot take advantage of our resources while ignoring our values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submit to Wruhecism or pay the price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Parents do not always know what is best for their children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are one of the few Wruhecist countries in this world. If we do not pass on our traditions, they will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. They should be instilled in children regardless of what their parents believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Manus Sazon**
> ""I cannot disagree with that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[408]`
Mówca: **Narrator**
> "Manus choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[409]`
Mówca: **Manus Sazon**
> ""No. But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Providing each Rizian child with a Wruhecist education will foster a stronger sense of unity for future generations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[411]`
Mówca: **Manus Sazon**
> ""Isn't that what our religious institutions are for? Using public schools for this purpose will only foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[412]`
Mówca: **Manus Sazon**
> ""I worry that will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[413]`
Mówca: **Manus Sazon**
> ""Or it will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[414]`
Mówca: **Daria de Rava**
> ""I believe the King has made his position clear, Mr. Sazon. It is not up to you to debate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[415]`
Mówca: **Manus Sazon**
> ""But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[422]`
Mówca: **Narrator**
> "Manus looked down. Daria smoothly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[423]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the new tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[424]`
Mówca: **Sal Ignacius**
> ""There will be no exclusion when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[425]`
Mówca: **Sal Ignacius**
> ""There will be no resentment when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[426]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty. The opposition is overlooking the decree's obvious benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[427]`
Mówca: **Daria de Rava**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[428]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[429]`
Mówca: **Narrator**
> "Frustration flashed across Manus' face. He kept it in check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[430]`
Mówca: **Manus Sazon**
> ""Naturally, the Derdian and Bludish natives residing in Rizia have rejoiced at the opportunity to worship alongside their fellow Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[431]`
Mówca: **Manus Sazon**
> ""However, the general public remains skeptical about what they see as a legitimization of an extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[432]`
Mówca: **Manus Sazon**
> ""It has helped soften the backlash against our border ban, which many say unfairly targets Golcondists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[436]`
Mówca: **Manus Sazon**
> ""Together with the border ban we implemented in agreement with Wehlen, they point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`
  - -> `[447]`
  - -> `[449]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""They point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`
  - -> `[449]`
  - -> `[442]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A ridiculous accusation. Did I not allow Golcondist pilgrims to occupy the Plavo Archsanctuary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not discriminatory to crack down on terrorism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and what is wrong with that? Golcondism is totally incompatible with modern Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lifting the blasphemy law has long been on my agenda. I will make it my priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[448]`
Mówca: **Manus Sazon**
> ""Yes, but it was expected that that action would be followed by a more general easing of restrictions on Golcondist worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. I simply believe real Wruhecists have the right to worship in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours or mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[451]`
Mówca: **Manus Sazon**
> ""We have no evidence that the Golcondists we are turning away are terrorists, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[452]`
Mówca: **Manus Sazon**
> ""Some of its followers may hold problematic views. We cannot use that to justify denying rights to the Golcondist community as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[453]`
Mówca: **Manus Sazon**
> ""Granting all citizens an equal right to worship would be a great step forward for freedom in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Manus Sazon**
> ""Golcondists do consider themselves 'real' Wruhecists, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Manus Sazon**
> ""On the other hand, I understand public concerns about legitimizing what some see as an extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave all Rizians an equal right to worship, regardless of religion. It's not like Golcondists are receiving special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The public has been scared away by decades of harmful stereotypes. They'll warm up to Golcondists in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[465]`
Mówca: **Sal Ignacius**
> ""Precisely, Mr. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
Mówca: **Narrator**
> "The delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Sal Ignacius**
> ""I have made myself clear on this subject time and time again. By allowing Golcondists to flood our holy sites, we would be opening the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""Especially if Rizia is to reopen relations with Derdia, there are concerns about giving too much credence to Golcondist beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[460]`
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The concerns are over nothing. I don't want to have anything to do with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[473]`
Mówca: **Manus Sazon**
> ""I agree, Your Majesty. I personally supported the lifting of the ban as a step forward for freedom in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[474]`
Mówca: **Manus Sazon**
> ""That is my party's hope as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[475]`
Mówca: **Manus Sazon**
> ""The RPP is not opposed to dealing with Golcondist nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Manus Sazon**
> ""Whatever the intention, I regard the lifting of the ban as a step forward for freedom in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Manus Sazon**
> ""But we must take care to ensure practitioners of other religions do not feel neglected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[478]`
Mówca: **Manus Sazon**
> ""I... wouldn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Manus Sazon**
> ""But there are those who are worried that if Rizia grants more rights to Golcondists, the kingdom will fall victim to the same ideologies as Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[487]`
  - -> `[483]`

### Węzeł `[480]`
Mówca: **Manus Sazon**
> ""There are those who are worried that if Rizia grants more rights to Golcondists, the kingdom will fall victim to the same ideologies as Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[487]`
  - -> `[483]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if the blasphemy law is revoked, Rizia will never turn into Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be so bad? We have much to learn from our Derdian neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may need Derdia's help in the war. But I will not make any ideological concessions to the Nurist republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These worries are unfounded. The blasphemy law is staying in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[488]`
Mówca: **Manus Sazon**
> ""I do not view the revocation of the blasphemy law as a concession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[489]`
Mówca: **Manus Sazon**
> ""Yes, I also believe these fears are unfounded. The benefits of revoking the law outweigh the drawbacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[490]`
Mówca: **Manus Sazon**
> ""Your Majesty, there is a reason the Nurist republic has been diplomatically isolated since its founding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[491]`
Mówca: **Manus Sazon**
> ""I still believe the benefits of revoking it outweigh the drawbacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[492]`
Mówca: **Daria de Rava**
> ""Naturally, the sudden acceptance of Derdian and Bludish worshippers in our sacred archsanctuaries has caused chaos within the Wruhecist community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[493]`
Mówca: **Daria de Rava**
> ""However, the general public remains worried about the growing legitimization of this extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[494]`
Mówca: **Daria de Rava**
> ""Admittedly, it has helped soften the backlash against our border ban on natives of those countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours or mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave all Rizians an equal right to worship, regardless of religion. It's not like Golcondists are receiving special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The public has been scared away by decades of harmful stereotypes. They'll warm up to Golcondists in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[505]`
Mówca: **Daria de Rava**
> ""Especially ahead of Rizia's upcoming diplomatic visit to Derdia, there are concerns about giving too much credence to Golcondist beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[503]`
  - -> `[506]`
  - -> `[510]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The concerns are over nothing. Rizia will never turn into Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[507]`
Mówca: **Daria de Rava**
> ""Our respected religious leaders would beg to disagree. Including the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[508]`
Mówca: **Sal Ignacius**
> ""I warned you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Narrator**
> "The Delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[513]`
Mówca: **Daria de Rava**
> ""Many religious leaders, our Grand Wiseman included, would call their presence a threat to mainstream Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[514]`
Mówca: **Daria de Rava**
> ""Their fears about Golcondists are based on more than mere stereotypes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[515]`
Mówca: **Daria de Rava**
> ""No. Not as long as the majority of our citizens still oppose Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Daria de Rava**
> ""I respect that. But we must be careful not to align with them too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[520]`
Mówca: **Sal Ignacius**
> ""By accepting Golcondist worshippers, we have opened the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[521]`
Mówca: **Daria de Rava**
> ""Thank you, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[522]`
Mówca: **Daria de Rava**
> ""Together with the border ban we implemented in agreement with Wehlen, they point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I find the accusations worrying. I do not want my citizens to feel discriminated against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Because I have no intention of lifting it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[528]`
Mówca: **Manus Sazon**
> ""I must object, your Majesty. We have no proof that the Golcondists we are turning away at the border are terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[529]`
Mówca: **Manus Sazon**
> ""I must object, Your Majesty. We cannot use the problematic views of a few followers to justify denying rights to the Golcondist community as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[530]`
Mówca: **Manus Sazon**
> ""My party agrees, Your Majesty. Granting all citizens an equal right to worship would be a great step forward for freedom in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""I must object, Your Majesty. Even if Golcondists make up a minority of society, they deserve the right to worship like anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[535]`
Mówca: **Daria de Rava**
> ""They point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's wrong with discrimination against Golcondists? Their faith is totally incompatible with modern Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not discriminatory to crack down on terrorism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[538]`
Mówca: **Daria de Rava**
> ""However, these complaints are only coming from a fraction of the populace. The majority want our law to stay in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[542]`
Mówca: **Sal Ignacius**
> ""Foolish words, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Narrator**
> "The delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Sal Ignacius**
> ""I have made myself clear on this subject time and time again. By allowing Golcondists to flood our holy sites, we would be opening the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn07_InviteSalToHOD == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn07_InviteSalToHOD == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Daria de Rava**
> ""Silence, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Daria de Rava**
> ""We have seen the influence of Golcondism on our neighbor Derdia. Our citizens do not want Rizia to fall victim to the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`
  - -> `[558]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if the blasphemy law is revoked, Rizia will never turn into Derdia. Our traditions are too strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be so bad? We have much to learn from Supreme Wiseman Azmal and his people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Daria de Rava**
> ""I should hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[553]`
Mówca: **Daria de Rava**
> ""Your Majesty, there is a reason the Nurist republic has been diplomatically isolated since its founding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[554]`
Mówca: **Narrator**
> "I saw Hugo raise his eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[555]`
Mówca: **Narrator**
> "My uncle looked relieved. He nodded emphatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[536]`
  - -> `[526]`
  - -> `[527]`

### Węzeł `[556]`
Mówca: **Narrator**
> "Out of the corner of my eye, I saw Hugo nod emphatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit we need Derdia's help in the war. But I will not make any ideological concessions to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`
  - -> `[560]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[561]`
Mówca: **Daria de Rava**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Sal Ignacius");

// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Sal Ignacius");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
