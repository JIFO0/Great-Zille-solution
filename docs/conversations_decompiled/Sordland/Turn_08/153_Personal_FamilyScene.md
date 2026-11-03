# Sordland/Turn08/Personal_FamilyScene

- **ID konwersacji:** `153`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/153_Personal_FamilyScene.md`
- **Liczba węzłów dialogowych:** 455
- **Liczba wyborów gracza:** 119

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.BFF_EliminationOperation_Botched`
- `BaseGame.BFF_Threatens_President`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bludish_Opinion`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Petr_isVP`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Petr_ShareBlameForLeak`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Unrest_WillHappen`
- `BaseGame.WomensRightCommission`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_Threatens_President`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Unrest_WillHappen`
- `BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY`
- `BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 15

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Unrest_WillHappen`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[16]` (Paskal Beniwoll): `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- Węzeł `[17]` (Paskal Beniwoll): `Variable["BaseGame.Unrest_BFF_WillHappen"] = false;`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["BaseGame.BFF_Threatens_President"] = true;`
- Węzeł `[34]` (Paskal Beniwoll): `--;`
- Węzeł `[35]` (Paskal Beniwoll): `--;`
- Węzeł `[39]` (Paskal Beniwoll): `Variable["BaseGame.Unrest_WillHappen"] = true;`
- Węzeł `[429]` (Paskal Beniwoll): `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- Węzeł `[433]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY"] = true;`
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
  - -> `[454]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12  or  (Variable["BaseGame.Bludish_Opinion"] <= -10  and  (Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12  or  (Variable["BaseGame.Bludish_Opinion"] <= -10  and  (Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I entered the grand study and let the warm glow of the room envelop me. Monica was sitting by the fireplace with a very old-looking book in her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[43]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Ersen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  (Variable["BaseGame.Arrest_FetihEjall"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == false)  or  (Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.Situation_Law_BludishReconciliation"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false)
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  (Variable["BaseGame.Arrest_FetihEjall"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == false)  or  (Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.Situation_Law_BludishReconciliation"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_WillHappen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.BFF_Threatens_President"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_WillHappen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[40]`
Mówca: **Narrator**
> "As I stepped through the front door of our stately residence, a sense of tranquillity washed over me. The house was quiet -- almost too quiet, without Franc blasting his music from upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you reading?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, you seem to have quite the fondness for these dusty tomes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Sit in the armchair next to hers."]** — Mówca: **Player_Italic**
> "I took a seat in the armchair next to hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[45]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[47]`
Mówca: **Monica**
> ""I took some books from the presidential library. This one in particular caught my eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Her voice was cold as she spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[71]`
  - -> `[72]`
  - -> `[73]`

### Węzeł `[49]`
Mówca: **Monica**
> ""The book's nothing. You wouldn't like it anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Monica**
> ""This isn't just any dusty tome, Anton. But you wouldn't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Monica**
> ""Is everything really going well at work?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[61]`
Mówca: **Monica**
> ""But yes, between these dusty covers lie worlds of knowledge waiting to be explored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[62]`
Mówca: **Narrator**
> "She showed me the book she was holding. I didn't recognize the author, but the name definitely sounded Valgish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Monica**
> ""It's about the women's struggle in post-revolution Valgsland and its breakaway states.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[64]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you becoming a Malenyevist, my dear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""From the presidential library, really? I'm surprised they keep any books about the Valgish revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Seems like Valgish propaganda to me. I'd take its contents with a grain of salt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually sounds like a great read.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But what is it? Can't you at least tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whatever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I decided to stay silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Monica**
> ""Really, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Narrator**
> "We both sat by the fireplace in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[77]`
Mówca: **Narrator**
> "I could see the anger in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Monica**
> ""I don't want to talk right now. Let me read in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[79]`
Mówca: **Narrator**
> "She let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Monica**
> ""It is. Especially the part about Galmland and the empire's former Rikan colonies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Monica**
> ""I had no idea the women there managed to organize so well and so early. It's very inspiring actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Monica**
> ""This isn't about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Monica**
> ""We shouldn't let our political opinions get in the way of learning about what the revolutionaries did right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Monica**
> ""To be honest, I was surprised too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Monica**
> ""I was told it was Tarquin Soll who collected most of them. Quite unexpected, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Monica**
> ""I mean... That may be true. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[87]`
Mówca: **Monica**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[88]`
Mówca: **Monica**
> ""Especially after everything that happened with Petr...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_isVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Petr_isVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Petr_isVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Petr_isVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Petr_isVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr who? My new vice president is doing a much better job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to talk about him. I hope you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. The palace does feel a lot more uncomfortable and intimidating without him around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish it had all gone differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[96]`
Mówca: **Monica**
> ""I do understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[97]`
Mówca: **Monica**
> ""Is that really how you feel, Anton? He was your closest friend since forever...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Monica**
> ""Thanks to you, I was just about the only woman at university he didn't go after. But I saw the way he was. And how he continued to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Monica**
> ""The truth is... That man has always been a bad influence on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Monica**
> ""...But honestly, you're probably right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Monica**
> ""And I don't think he should be forgiven after what he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[111]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[102]`
Mówca: **Monica**
> ""Evelyn said Petr's finally stopped drinking -- or most likely, stopped drinking so very much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Monica**
> ""Apparently, he's been coming home a lot more often, and spends most nights in his study, working on documents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't believe that until I see it with my own eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really? That's good to know. He did promise me he'd work harder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad he's actually doing his part for once. It's been a madhouse at the palace lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Monica**
> ""That was exactly my response to Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[108]`
Mówca: **Monica**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He wasn't forgiven. By me or anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't defend what he did, but he's still my friend. And he's facing the consequences of his actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Petr_ShareBlameForLeak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Petr_ShareBlameForLeak == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Petr_ShareBlameForLeak == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew Petr had his problems, Monica. But he was -- is -- my closest friend. I don't want to badmouth him behind his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. I should have listened to you back in the day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Monica**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Monica**
> ""I know. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Monica**
> ""Isn't that always the moral of these stories?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Monica**
> ""I don't know, Anton. Both of you seem to be under a massive amount of stress lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[122]`
Mówca: **Monica**
> ""I don't know, Anton. All of this seems to have put you under a massive amount of stress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[123]`
Mówca: **Monica**
> ""Maybe we can make some time for a little getaway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_Vineyard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Monica**
> ""We can have a weekend retreat at the vineyard in Erlory. What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Monica**
> ""We can have a weekend retreat out in the countryside. What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually sounds marvelous, Monica. Let's make the arrangements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a nice idea, but I'll have to check my schedule. I *am* very busy, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just the two of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Monica**
> ""Well... Franc's not around anymore, and I'm sure Deana would love a sleepover at one of her friends'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Monica**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[134]`
Mówca: **Monica**
> ""Great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Monica**
> ""So why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "She grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Just then, we heard the patter of small feet approaching the study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Deana appeared by the door with a piece of folded paper clutched in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_Threatens_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_WillHappen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_WillHappen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_WillHappen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[145]`
Mówca: **Deana**
> ""Mama, Papa, look what I found!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Deana appeared by the door with a piece of folded paper clutched in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Deana**
> ""Mama, Papa, my school report came in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Monica and I immediately turned our attention to her, our curiosity piqued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What have you got there, darling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Deana unfolded the paper and started to read it aloud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Deana**
> ""We hope this letter finds you in good spirits, surrounded by the warmth of your loved ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Deana**
> ""Oh, how we long for a world where justice prevails, where the corrupt are exposed, and the righteous triumph.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[155]`
Mówca: **Deana**
> ""We advise all of you to tread carefully, for it was Anton Rayne who grew the darkness over this land and suffocated our people. For what the President did, he and his family shall face re-- Retrbrution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[157]`
  - -> `[158]`
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Her voice started quivering as she continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's alright, my love. Just give it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana! Give me that paper right now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Let her continue."]** — Mówca: **Player_Italic**
> "I did not intervene and let her continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Deana**
> ""Papa. Why does it say that you suffocated people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[167]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[161]`
Mówca: **Narrator**
> "She reluctantly approached us with the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[162]`
Mówca: **Deana**
> ""The safety you have enjoyed so far is nothing but an illusion. Think twice before stepping into our ancestral lands. Danger lurks around every corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Deana**
> ""Don't forget. The powerful are vulnerable and the oppressed have nothing to los-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Narrator**
> "Monica quickly stood up and snatched the letter from her grasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Monica**
> ""It's okay, darling. This is all just a bad joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't know, sweetie. It's just a bunch of words that don't make sense. It must be a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are all lies, Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, darling. This is nothing for you to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Narrator**
> "I took the letter from her grasp and started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> ""...The safety you have enjoyed so far is nothing but an illusion. Think twice before you step into our ancestral lands. Danger lurks around every corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> ""Don't forget. The powerful are vulnerable and the oppressed have nothing to lose...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[173]`
Mówca: **Narrator**
> ""Consider our words, for they hold weight beyond your existence. Your decisions shape the destinies of millions, and their consequences will reverberate through the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> ""With sincerest concern, the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Monica**
> ""What are we going to do, Anton? This is serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[180]`
  - -> `[181]`
  - -> `[182]`

### Węzeł `[176]`
Mówca: **Narrator**
> "She gave me the letter and I immediately started reading the rest of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure it's nothing to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[178]`
Mówca: **Narrator**
> "Deana, sensing the tension, tiptoed closer to us, her eyes wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana, this letter is from some misguided individuals. We won't let them get their way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll check in with the presidential guard. This should never even have reached us in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't let fear dictate our actions, Monica. If there's truly a threat, we will face it head-on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. I'll inform the authorities and take every necessary precaution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Monica**
> ""Are you insane? This letter is directed at our entire family. And we know what its authors are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[184]`
Mówca: **Monica**
> ""We can't be too cautious. The letter is directed at our entire family. And we know what its authors are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[185]`
Mówca: **Monica**
> ""Deana, honey, where did you find this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "She hesitated for a moment before speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Deana**
> ""I found it in the living room window. It was stuck between the frames.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[188]`
  - -> `[190]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well done, Deana. You've shown incredible courage. Thank you for bringing this to our attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, sweetheart. But next time, please talk to me or your mother before touching things like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
**[WYBÓR GRACZA: "Console her."]** — Mówca: **Player_Italic**
> "I knelt down and gathered Deana into my arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Deana**
> ""Papa, what's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Deana**
> ""Are they threatening us for something you did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Narrator**
> "She spoke innocently, but I could sense a new guardedness in her voice. I took a deep breath and tried to find the right words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[211]`
  - -> `[215]`
  - -> `[216]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana, we've received a letter from some people called the BFF. They want to do bad things to us because they don't agree with what we stand for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Narrator**
> ""When you eliminated our people's right to represent themselves, you gave us no choice but to take matters into our own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Arrest_FetihEjall == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[205]`
Mówca: **Narrator**
> ""With the arrest of Mr. Ejall, we have finally come to terms with reality. The peaceful movement has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[206]`
Mówca: **Narrator**
> ""Everyone who has been complicit in this injustice will have to answer for it. We will also visit Governor Bron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[210]`
Mówca: **Narrator**
> ""Everyone who has been complicit in this injustice will have to answer for it. We will also visit Governor Krull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, darling. I haven't done anything wrong. The people who wrote this do not believe in the authority of our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[212]`
Mówca: **Deana**
> ""But daddy, we're good people. And I know you always try to do what's best for everyone. Why would they want to hurt us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[213]`
  - -> `[230]`
  - -> `[451]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, people fear what they don't understand. But we won't let that fear define us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Deana**
> ""So what are we going to do? We can't let the bad people win, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`
  - -> `[238]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, darling. Some people think I've done bad things and now they are trying to send me a message.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some matters are best left for the grown-ups.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
Mówca: **Deana**
> ""But that's not fair, Papa. Our country is supposed to protect all of us, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[220]`
  - -> `[226]`

### Węzeł `[218]`
Mówca: **Deana**
> ""But you wouldn't really do anything bad, would you? I know you always try to do what's best for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[225]`

### Węzeł `[219]`
Mówca: **Deana**
> ""But I want to understand, Papa. This seems important. I'm not a little kid anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, my girl. Our country is meant to protect its people, but sometimes there are those who challenge its ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Deana. I strive to be the best I can be, but sometimes people have different opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even your papa can make mistakes sometimes, Deana. What's important is to remember that we can learn and grow from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. You're growing into such a remarkable young woman. Tell me. What do you want to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are complex issues and disagreements in our country, and sometimes it's best for adults to handle them. But please know that I will always protect you and our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people have evil in their hearts, Deana. They don't care whether you're doing the right thing or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. Our country protects all of us, Deana. But some people have evil in their hearts and want to reject that protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Trust me, Deana. It's best if you stay out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes our country doesn't function the way it's supposed to, Deana. And when it doesn't, it leads to problems with different groups of people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Deana. I strive to be the best I can be, but sometimes people have different opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people have evil in their hearts, Deana. They don't care whether you're doing the right thing or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Deana's lower lip trembled. I saw a hint of disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[233]`
Mówca: **Deana**
> ""Have you really done something to hurt these people? I know you always try to do what's best for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[225]`

### Węzeł `[234]`
Mówca: **Narrator**
> "Deana looked at me with a hint of disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Deana. We will not let them win. We will take every precaution to keep our family safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's nothing to win, Deana. Don't worry, nothing bad will happen as long as I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Never, my dear. We will not surrender to fear or threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're not bad people, just people with bad ideas. I will show them the right thing to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Monica tugged on my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Monica**
> ""Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Monica**
> ""We have to talk about this. You and me. Alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Monica and I immediately turned our attention to her, our curiosity piqued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`
  - -> `[249]`
  - -> `[246]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's my girl! I can't wait to hear about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very well. Bring it here and let's assess your progress together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Deana unfolded the paper and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Deana**
> ""I was so close to the top of the class...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh no, not the dreaded report!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Narrator**
> "Deana chuckled and gave the paper to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's incredible, Deana! You've worked hard and it shows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""*Almost* doesn't count, honey. Sounds like you've got to try harder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Congratulations, my girl! But you know I'd love you even if you got bad grades, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
Mówca: **Narrator**
> "I heard a mix of pride and disappointment in her voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`
  - -> `[253]`
  - -> `[267]`
  - -> `[255]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh my. We've got a genius in the house! Watch out, world, Holsord's number-two student is on the loose!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Narrator**
> "Deana chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Narrator**
> "Deana smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[258]`
Mówca: **Deana**
> ""I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Narrator**
> "Monica quickly stood up and snatched the paper from my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Monica**
> ""You did great, darling!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Monica**
> ""We're so proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[266]`
Mówca: **Monica**
> ""I'm so proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to hear! I wish your brother had your brains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Deana**
> ""Mama says Franc's smart in a different way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[269]`
Mówca: **Narrator**
> "She knelt down and gathered Deana into her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Deana**
> ""I know! But I still feel kinda bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[271]`
Mówca: **Deana**
> ""And then there's that stupid blonde boy Markus. He never even studies, but the teachers always give him higher grades than everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Monica**
> ""Don't call him stupid, baby. Who is this Markus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Deana**
> ""I told you about him, Mommy. Markus Clavin. The one who can't even do basic math, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait. Did you just say Clavin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your mother's right, Deana. Forget about it. You've already done great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, really? Maybe I should have a talk with your school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Deana**
> ""Yes. That's his last name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`
  - -> `[282]`
  - -> `[276]`

### Węzeł `[278]`
Mówca: **Deana**
> ""What do you mean by talk, Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Deana**
> ""Please don't come to the school and shout at the teachers like Markus' father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[296]`
  - -> `[297]`
  - -> `[298]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Actually, I may know his father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Anyway, it doesn't matter, Deana. You've already done great. Don't mind that kid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Deana**
> ""Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[284]`
Mówca: **Deana**
> ""Do you know him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[282]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[288]`
Mówca: **Deana**
> ""Ever since they started letting the girls take science classes, they've been distracting us during exams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Deana**
> ""...But those classes are so boring!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[290]`
Mówca: **Deana**
> ""And the teachers don't even care!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[291]`
Mówca: **Deana**
> ""I'm sure I would've been at the top if the boys at school weren't so annoying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[292]`
Mówca: **Deana**
> ""I'm sure I would've been at the top if I'd done better in handicrafts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[293]`
Mówca: **Deana**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He did what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[295]`
Mówca: **Deana**
> ""His father came to the school a couple of times and shouted at the teachers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[296]`
  - -> `[297]`
  - -> `[298]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you serious, sweetie?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He did, did he? Looks like I have a *lot* of talking to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people just have bad manners, darling. You shouldn't pay attention to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[299]`
Mówca: **Narrator**
> "She gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Monica**
> ""We'll be back in a bit, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Narrator**
> "We entered the kitchen and Monica closed the door behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Monica**
> ""Anton. I know the Aschraf Anniversary will take place in a few days. I don't want you to attend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Monica**
> ""You know it's the largest-ever commemoration of the Izzam Incident. And it will be swarming with Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[307]`
Mówca: **Monica**
> ""Anton. I have a bad feeling about this. Isn't the Aschraf Anniversary in a few days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Monica**
> ""I feel like something might happen on that day. It's the commemoration of the Izzam Incident after all. And it'll be swarming with Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Monica**
> ""With everything going on in Bergia, and the timing of the letter... This cannot be a coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[311]`
  - -> `[312]`
  - -> `[317]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. The anniversary won't even take place. All mass gatherings are banned for the remainder of the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Monica. I cannot allow fear to dictate my actions. I cannot let the Bludish people down. You have to trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's exactly what they want us to do, Monica. We cannot give in to their threats. Don't worry. I will take the necessary security precautions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. I will not attend the anniversary. I will not take any risks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If I don't show support for the victims of Izzam now, I fear things may turn out even uglier. We can't let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Monica**
> ""You cannot simply decide that by yourself. This is about all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`
  - -> `[322]`
  - -> `[323]`

### Węzeł `[319]`
Mówca: **Monica**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look. You have to trust me. If there is a threat, I will handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're underestimating our forces and the power of the state. Nobody will let a bunch of misguided militants threaten us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please, Monica. You have to understand me. This political mess can only be solved through diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Maybe you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[324]`
Mówca: **Monica**
> ""Please, Anton. Listen to me this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[325]`
Mówca: **Monica**
> ""I don't really believe that after all the chaos I've seen in this country, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[326]`
Mówca: **Monica**
> ""Do you think we can trust the presidential guard after this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`
  - -> `[334]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[330]`
Mówca: **Monica**
> ""Despite everything you've done, you are still the father of our children. And I don't want you to get hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[331]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. They were never to be completely trusted. We must be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Monica. I have great reservations about them after this letter. Don't worry, I will try to get to the root of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We shouldn't jump to conclusions immediately. They are tasked with protecting our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Monica**
> ""You have to do something about our security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`
  - -> `[340]`

### Węzeł `[336]`
Mówca: **Monica**
> ""Well, I don't trust them, Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We'll weather this together. I will take the necessary measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just let me do my job for once, Monica. I know what to do. You shouldn't keep worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will, honey. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Narrator**
> "She did not respond. I knew what I said hadn't made her feel any better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[345]`
Mówca: **Deana**
> ""I already told you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[346]`
Mówca: **Deana**
> ""Why wouldn't I be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[347]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[348]`
Mówca: **Monica**
> ""Isn't that your new VP, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[349]`
Mówca: **Monica**
> ""I've also seen that more and more protests have been popping up around the country lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Monica**
> ""I'm worried that things may get out of hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`
  - -> `[353]`
  - -> `[354]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's no need for concern. People are just voicing their criticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm aware. It concerns me as well. But I'll take all the necessary steps, don't you worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, there's nothing I can do about that. Can I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're just a bunch of traitors who are being supported by foreign powers. The moment they truly pose a threat, they will be taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Monica**
> ""I guess you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Monica**
> ""Listen to yourself. I think you need a break, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Monica**
> ""But I think you need a break, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[361]`
Mówca: **Monica**
> ""Isn't that the one who challenged you for USP candidacy, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[365]`
Mówca: **Monica**
> ""How do you keep finding men like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[374]`
  - -> `[375]`
  - -> `[376]`

### Węzeł `[366]`
Mówca: **Monica**
> ""Why is your party still filled with men like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[378]`
  - -> `[379]`
  - -> `[380]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.BFF_Damaged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.BFF_Damaged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Damaged == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Damaged == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_Damaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_Damaged == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_Damaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[373]`
Mówca: **Deana**
> ""You may think that you destroyed us. But the will of the people will live on forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come on, Monica. How would I know about any of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just another male Sordish politician, Monica. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes... He is the new Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come on, Monica. You know I can't control everything our members do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just another male Sordish politician, Monica. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes... That's him, all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Monica**
> ""Oh, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[383]`
Mówca: **Monica**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[384]`
Mówca: **Monica**
> ""Uh. Forget I asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Monica**
> ""Maybe you should have some control. These type of men will only destroy the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Monica**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Monica**
> ""I think I'll continue my the book, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`
  - -> `[396]`

### Węzeł `[391]`
Mówca: **Monica**
> ""Are you hungry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Monica**
> ""I didn't cook today, but the chef prepared a wonderful Rizian meal for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Deana**
> ""Yes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`
  - -> `[405]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alright. See you at dinner, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is there something wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Monica**
> ""What do you mean, *now*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Monica**
> ""Yes. I just want to read my book.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[400]`
  - -> `[401]`

### Węzeł `[399]`
Mówca: **Monica**
> ""No! I just want to read, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can read it another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Narrator**
> "I grabbed Deana's hand and walked out the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great. I am starving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rizian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What? He couldn't come up with something Sordish?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Monica**
> ""Oh, come on, Anton. It won't kill you to try something new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Monica**
> ""Yes. It's similar to Lespian food, but better. There's a lobster dish called 'Toras Flambé!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Monica**
> ""Me too. Let's eat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Narrator**
> "She grabbed Deana's hand and we walked to the kitchen together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Monica**
> ""I hope so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[414]`
Mówca: **Narrator**
> "Before I could say anything else, she embraced me tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Monica**
> ""We'll get through this together. We have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[416]`
Mówca: **Narrator**
> "Before I could say anything else, she left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Monica**
> ""I'll go check on Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[418]`
Mówca: **Narrator**
> "How real was the threat to my family? Did I really have the power to guarantee their safety?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Narrator**
> "I felt a chill running down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[420]`
Mówca: **Monica**
> ""Seems like he's following through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[421]`
Mówca: **Monica**
> ""I understand. But honestly, maybe it was all for the best in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[422]`
Mówca: **Monica**
> ""I'm sure you can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's 'retribution', sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Deana**
> ""Yes. Retribution. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[425]`
Mówca: **Monica**
> ""I suppose you wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation_Botched == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation_Botched == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_EliminationOperation_Botched == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_WillHappen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Threatens_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_Threatens_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.YoungSords_Aids_Security == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Mountains");)*
- **Efekt (`userScript`):** `PlayMusic("Mountains");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[450]`
Mówca: **Monica**
> ""Anton, please. Can you leave me alone so I can read in peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even your papa can make mistakes sometimes, Deana. What's important is to remember that we can learn and grow from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Spending some personal time with their own family", "Residence of the President", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Spending some personal time with their own family","Residence of the President","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
