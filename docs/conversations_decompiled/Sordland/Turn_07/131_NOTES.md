# Sordland/Turn07/NOTES

- **ID konwersacji:** `131`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/131_NOTES.md`
- **Liczba węzłów dialogowych:** 92
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Decision_Turn06_Lobbying_Bribe`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Faction_Oligarchs_Enemy`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`
- `BaseGame.Turn06_InT_Taurus`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Assembly_Vote`
- `BaseGame.Reform_NFP_Vote_MinorConvinced`
- `BaseGame.Reform_PFJP_Vote_FullConvinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Reform_USP_Vote_FirstUndecided_Convinced`
- `BaseGame.Reform_USP_Vote_PartyDisagreements`
- `BaseGame.Reform_USP_Vote_Reformers_MinorConvinced`
- `BaseGame.Reform_USP_Vote_SecondUndecided_Convinced`
- `BaseGame.Reform_USP_Vote_StrongBase_Backing`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 27

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] = false;`
- Węzeł `[13]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] - 1;`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 3;`
- Węzeł `[28]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- Węzeł `[29]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 2;`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 3;`
- Węzeł `[37]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- *...oraz 19 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_InT_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_InT_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_InT_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Enemy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Enemy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Lobbying_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Lobbying_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Lobbying_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Lobbying_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true || BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true || BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true || BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == false && BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == false && BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Family_Important"] == false  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Family_Important == false && BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Family_Important"] == false  and  Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Ally == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Ally"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Ally == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Ally"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true || BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true  or  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn04_WorkersRights_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn04_WorkersRights_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_USP_Vote_FirstUndecided_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_USP_Vote_FirstUndecided_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_USP_Vote_StrongBase_Backing = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_USP_Vote_StrongBase_Backing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_USP_Vote_Reformers_MinorConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_USP_Vote_Reformers_MinorConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_USP_Vote_PartyDisagreements = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_USP_Vote_PartyDisagreements"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PFJP_Vote_FullConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_PFJP_Vote_FullConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_NFP_Vote_MinorConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_NFP_Vote_MinorConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_OldGuard_Content == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] - 2;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_USP_Vote_SecondUndecided_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_USP_Vote_SecondUndecided_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Bill_Turn04_WorkersRights_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Bill_Turn04_WorkersRights_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Bill_Turn04_WorkersRights_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true && BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Assembly_Vote"] = Variable["BaseGame.Reform_Assembly_Vote"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
