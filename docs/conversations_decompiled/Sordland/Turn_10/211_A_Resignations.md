# Sordland/Turn10/A_Resignations

- **ID konwersacji:** `211`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/211_A_Resignations.md`
- **Liczba węzłów dialogowych:** 843
- **Liczba wyborów gracza:** 77

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[35]** Gus Manger
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Democratic`
- `BaseGame.Fired_Symon`
- `BaseGame.LeakedScandal_GusManger_UnderhallCollusion`
- `BaseGame.LeakedScandal_SecretState_DetainFrensRicter`
- `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_DetainPetrVectern`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`
- `BaseGame.Pandemic_Severity`
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_Honorary_Presidents`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Policy_Law_Judges_Impeachment_President`
- `BaseGame.Policy_Law_TermLimits_Default`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Policy_Law_Veto_Loophole`
- `BaseGame.Policy_Welfare_HealthReform`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Resigned_CiaraWalda`
- `BaseGame.Resigned_GusManger`
- `BaseGame.Resigned_NiaMorgna`
- `BaseGame.Resigned_PaskalBeniwoll`
- `BaseGame.Resigned_SymonHoll`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Situation_Welfare_EpidemicPrevented`
- `BaseGame.Situation_Welfare_ModernEducationTechniques`
- `BaseGame.Situation_Welfare_QualityRuralHealthServices`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`
- `BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda`
- `BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna`
- `BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll`
- `BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_SymonHoll`
- `BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned`
- `BaseGameSupport.Journal_Turn10_Resignations_Ciara`
- `BaseGameSupport.Journal_Turn10_Resignations_Gus`
- `BaseGameSupport.Journal_Turn10_Resignations_Nia`
- `BaseGameSupport.Journal_Turn10_Resignations_Paskal`
- `BaseGameSupport.Journal_Turn10_Resignations_Symon`
- `BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne`
- `BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne`
- `BaseGameSupport.News_Turn10_LT_Resignations_One`
- `BaseGameSupport.News_Turn10_LT_Resignations_TooMany`
- `BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne`
- `GameCondition.Turn10_A_Resignations`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 33

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Ciara Walda): `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_...`
- Węzeł `[10]` (Ciara Walda): `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_...`
- Węzeł `[11]` (Ciara Walda): `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_...`
- Węzeł `[15]` (Ciara Walda): `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_...`
- Węzeł `[19]` (Ciara Walda): `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_...`
- Węzeł `[656]` (Ciara Walda): `Variable["GameCondition.Turn10_A_Resignations"] = true;`
- Węzeł `[679]` (Ciara Walda): `Variable["BaseGameSupport.Journal_Turn10_Resignations_Ciara"] = true; Variable["BaseGameSupport.C...`
- Węzeł `[680]` (Ciara Walda): `Variable["BaseGameSupport.Journal_Turn10_Resignations_Gus"] = true; Variable["BaseGameSupport.Cod...`
- *...oraz 25 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ciara Walda)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[5]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[8]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[10]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[12]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[14]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[18]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_PaskalBeniwoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[20]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[22]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[23]`
Mówca: **Narrator**
> "The door opened and Lucian entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""Mr. President. There is a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[25]`
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""What is it now?""]** — Mówca: **Player**
> ""What is it now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""What kind of a problem?""]** — Mówca: **Player**
> ""What kind of a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Some cabinet members said they wanted to speak to you urgently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""They are in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[34]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[36]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[39]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[42]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_PaskalBeniwoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Mrs. Walda wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Mr. Manger wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Mr. Beniwoll wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""Mr. Holl wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""She is in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""He is in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[53]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""What's so urgent?""]** — Mówca: **Player**
> ""What's so urgent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Do you know what it's about?""]** — Mówca: **Player**
> ""Do you know what it's about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I was just told to come get you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "I opened the doors and we entered the White Room. I looked around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true  and  Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true  and  Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Ciara and Nia were standing near the table with their arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[62]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Ciara was standing near the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Nia was standing near the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Symon and Gus were seated. They looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Symon was sitting, playing with the pen in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Gus was sitting, playing with the pen in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Paskal looked incredibly stressed. He wiped off his sweat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[88]`

### Węzeł `[83]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_PaskalBeniwoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[88]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Good evening.""]** — Mówca: **Player**
> ""Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""What is going on here?""]** — Mówca: **Player**
> ""What is going on here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""So. Why did you call me here?""]** — Mówca: **Player**
> ""So. Why did you call me here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[91]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[92]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[94]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[97]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[98]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[101]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[103]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[104]`
Mówca: **Ciara Walda**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Ciara Walda**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[108]`
Mówca: **Symon Holl**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[109]`
Mówca: **Symon Holl**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
Mówca: **Gus Manger**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[111]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Your resignations? What is the meaning of this?""]** — Mówca: **Player**
> ""Your resignations? What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I see. You are trying to sabotage me before the elections.""]** — Mówca: **Player**
> ""I see. You are trying to sabotage me before the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Let's all calm down. We can work something out.""]** — Mówca: **Player**
> ""Let's all calm down. We can work something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[118]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[120]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[121]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[124]`
Mówca: **Symon Holl**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[125]`
Mówca: **Nia Morgna**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[126]`
Mówca: **Ciara Walda**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[127]`
Mówca: **Gus Manger**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[128]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[130]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[133]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[135]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[137]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[141]`
Mówca: **Symon Holl**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[142]`
Mówca: **Nia Morgna**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[143]`
Mówca: **Ciara Walda**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[144]`
Mówca: **Gus Manger**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[145]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[147]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[150]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[152]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[154]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[155]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[158]`
Mówca: **Symon Holl**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[159]`
Mówca: **Nia Morgna**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[160]`
Mówca: **Ciara Walda**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[161]`
Mówca: **Gus Manger**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[168]`
  - -> `[170]`

### Węzeł `[162]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[164]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[167]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""You're betraying me, then.""]** — Mówca: **Player**
> ""You're betraying me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""But why? What are your reasons?""]** — Mówca: **Player**
> ""But why? What are your reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Talk to me. What can I do? How can I help you better?""]** — Mówca: **Player**
> ""Talk to me. What can I do? How can I help you better?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[173]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[174]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[177]`
Mówca: **Symon Holl**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[178]`
Mówca: **Nia Morgna**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[179]`
Mówca: **Ciara Walda**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[180]`
Mówca: **Gus Manger**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[183]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[184]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[186]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[188]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[190]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[191]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[194]`
Mówca: **Symon Holl**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[195]`
Mówca: **Nia Morgna**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[196]`
Mówca: **Ciara Walda**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[197]`
Mówca: **Gus Manger**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[198]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[201]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[203]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[207]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Symon Holl**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[209]`
Mówca: **Nia Morgna**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[210]`
Mówca: **Ciara Walda**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[211]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[213]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[215]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[217]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[221]`
Mówca: **Gus Manger**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[224]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[225]`
Mówca: **Ciara Walda**
> ""I don't even know why I joined the cabinet at this point. You managed to bring education in this country 20 years back in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[226]`
Mówca: **Ciara Walda**
> ""How could you create the Secret State Police? How dare you attack the very values this country stands on? You will go down in history as a dictator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Nia Morgna**
> ""This is a direct breach of the democratic process. You are responsible for destroying the lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`
  - -> `[231]`

### Węzeł `[229]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at some point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[232]`
Mówca: **Nia Morgna**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[233]`
Mówca: **Nia Morgna**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Nia Morgna**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Ciara Walda**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[237]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[240]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[242]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[285]`
  - -> `[284]`

### Węzeł `[246]`
Mówca: **Ciara Walda**
> ""Thanks to you, gender inequality is at an all-time high in Sordland. We are falling way behind modern countries and I don't see that changing anytime soon with leadership like this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[285]`
  - -> `[284]`

### Węzeł `[247]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[249]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[252]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[253]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Nia Morgna**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[267]`
  - -> `[266]`

### Węzeł `[255]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`
  - -> `[256]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[260]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[261]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[262]`
Mówca: **Ciara Walda**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Ciara Walda**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Ciara Walda**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[265]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[266]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Nia Morgna**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[269]`
Mówca: **Nia Morgna**
> ""Your puppeteers have you so brainwashed that you forgot you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[270]`
Mówca: **Nia Morgna**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[271]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[273]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_PaskalBeniwoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
> ""The government has not done enough and now we have polio cases popping up everywhere around Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
> ""Even in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
> ""Who knows? Soon it might be you or your own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
> ""If you are not going to take responsibility for it, then I will as the Minister of Health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[280]`
  - -> `[279]`

### Węzeł `[278]`
**[WYBÓR GRACZA: ""You are taking responsibility by resigning? That doesn't even make sense.""]** — Mówca: **Player**
> ""You are taking responsibility by resigning? That doesn't even make sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Please, Paskal. We need you in the government to solve this crisis once and for all.""]** — Mówca: **Player**
> ""Please, Paskal. We need you in the government to solve this crisis once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[280]`
**[WYBÓR GRACZA: ""This is because you have brought this to my attention so late.""]** — Mówca: **Player**
> ""This is because you have brought this to my attention so late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
> ""I am resigning because someone in the government has to admit that we have made mistakes. Our people are dying, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
> ""We are clearly not fit to lead. Otherwise we would've done something about this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[283]`
**[WYBÓR GRACZA: ""We can fix our mistakes if we work together.""]** — Mówca: **Player**
> ""We can fix our mistakes if we work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
**[WYBÓR GRACZA: ""And who is at fault there? Don't blame everything on me.""]** — Mówca: **Player**
> ""And who is at fault there? Don't blame everything on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""There were other high priority issues we had to handle.""]** — Mówca: **Player**
> ""There were other high priority issues we had to handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Ciara Walda**
> ""We are all to blame because we believed in you! Another disappointment in our country's history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[287]`
Mówca: **Ciara Walda**
> ""What is more important than education? Attending unnecessary speeches? Shaking hands with priests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[288]`
Mówca: **Ciara Walda**
> ""It's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
> ""Please don't blame me, Mr. President. Instead, blame yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
> ""I brought you the data as soon as I could but you chose not to act on it. You are at fault here, not me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
> ""I have already decided and nothing will turn me back from my decision. I have a duty to my people and I failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[293]`
Mówca: **Symon Holl**
> ""I have failed my mission as the Minister of Economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[294]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[297]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Fired_Symon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Fired_Symon == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_Symon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[299]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_Symon == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_Symon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[302]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[303]`
Mówca: **Symon Holl**
> ""During our term, instead of stopping the recession, we have made it even worse and entered the 'Sordish Depression'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Symon Holl**
> ""I blame myself for this. I couldn't offer you better solutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Symon Holl**
> ""I have proven that I am unfit to serve as the Minister of Economy in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Good. At least you have some dignity.""]** — Mówca: **Player**
> ""Good. At least you have some dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""Thank you. It's been a pleasure to work with you.""]** — Mówca: **Player**
> ""Thank you. It's been a pleasure to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[308]`
**[WYBÓR GRACZA: ""Please don't do this, Symon. I am to blame, not you.""]** — Mówca: **Player**
> ""Please don't do this, Symon. I am to blame, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
> ""I will hand you my resignation once our term is done, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[310]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`
  - -> `[306]`

### Węzeł `[311]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[312]`
Mówca: **Symon Holl**
> ""I'm afraid things are already in motion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[313]`
Mówca: **Symon Holl**
> ""Likewise, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[314]`
Mówca: **Symon Holl**
> ""I am afraid that I find myself too ideologically different to work as the Minister of Economy for this government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Symon Holl**
> ""The decisions we made have proven that to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Symon Holl**
> ""I know when to leave my seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[320]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[319]`
**[WYBÓR GRACZA: ""Good. At least you have some dignity.""]** — Mówca: **Player**
> ""Good. At least you have some dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[320]`
**[WYBÓR GRACZA: ""Please don't do this, Symon. We can overcome our differences.""]** — Mówca: **Player**
> ""Please don't do this, Symon. We can overcome our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Symon Holl**
> ""Likewise, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[322]`
Mówca: **Symon Holl**
> ""I'm afraid things are already in motion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Thank you. It's been a pleasure to work with you.""]** — Mówca: **Player**
> ""Thank you. It's been a pleasure to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Symon Holl**
> ""As you have requested, I have come to deliver my resignation letter, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Symon Holl**
> ""I am sorry for not being up to your standards as the Minister of Economy""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[327]`

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Good. Leave it on my desk on your way out.""]** — Mówca: **Player**
> ""Good. Leave it on my desk on your way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Thank you. That will be all then.""]** — Mówca: **Player**
> ""Thank you. That will be all then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Symon Holl**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[334]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[335]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[337]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[338]`
Mówca: **Gus Manger**
> ""I must say that I am very ashamed to be part of a scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Gus Manger**
> ""I will not beg for my innocence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Gus Manger**
> ""My involvement in the Underhall Construction affair cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Gus Manger**
> ""I will resign immediately to bring no further shame to the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`
  - -> `[342]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Very well. I understand.""]** — Mówca: **Player**
> ""Very well. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""Thank you. Regardless, it was nice to have you here.""]** — Mówca: **Player**
> ""Thank you. Regardless, it was nice to have you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[344]`
**[WYBÓR GRACZA: ""I don't want to see you ever again.""]** — Mówca: **Player**
> ""I don't want to see you ever again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Gus Manger**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[346]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. It was nice to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[347]`
Mówca: **Gus Manger**
> ""Thank you for understanding, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[348]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Gus Manger**
> ""I must say I have been a minister for a very long time now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[350]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Gus Manger**
> ""I was very happy to be the part of the team you have created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""I will be handing you my resignation at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`
  - -> `[353]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""Family comes first. I understand.""]** — Mówca: **Player**
> ""Family comes first. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[354]`
**[WYBÓR GRACZA: ""Thank you, Gus. It was nice to have you here.""]** — Mówca: **Player**
> ""Thank you, Gus. It was nice to have you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[355]`
**[WYBÓR GRACZA: ""Let's keep in touch about more potential investments.""]** — Mówca: **Player**
> ""Let's keep in touch about more potential investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Gus Manger**
> ""Of course, Mr. President. I will be in touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[357]`
Mówca: **Gus Manger**
> ""Thank you for understanding, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. It was nice to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I have no choice but to accept your resignations.""]** — Mówca: **Player**
> ""I have no choice but to accept your resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""I accept your resignations. Now get out of my face.""]** — Mówca: **Player**
> ""I accept your resignations. Now get out of my face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Narrator**
> "The ministers left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[363]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[365]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Nia Morgna**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[370]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[372]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[373]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[375]`
Mówca: **Ciara Walda**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[376]`
Mówca: **Symon Holl**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[377]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[379]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[380]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[382]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[383]`
Mówca: **Symon Holl**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[384]`
Mówca: **Nia Morgna**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[385]`
Mówca: **Ciara Walda**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[386]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[388]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[390]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[392]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[396]`
Mówca: **Gus Manger**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[398]`
Mówca: **Symon Holl**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[399]`
Mówca: **Nia Morgna**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[400]`
Mówca: **Ciara Walda**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[401]`
Mówca: **Gus Manger**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[409]`

### Węzeł `[404]`
Mówca: **Symon Holl**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[405]`
Mówca: **Gus Manger**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[409]`

### Węzeł `[406]`
Mówca: **Symon Holl**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Nia Morgna**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Ciara Walda**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[409]`

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Let's just calm down. We can work something out.""]** — Mówca: **Player**
> ""Let's just calm down. We can work something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[410]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[412]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[413]`
Mówca: **Symon Holl**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[414]`
Mówca: **Nia Morgna**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[415]`
Mówca: **Ciara Walda**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[416]`
Mówca: **Gus Manger**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[418]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[420]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[421]`
Mówca: **Ciara Walda**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[422]`
Mówca: **Nia Morgna**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[423]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[425]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[426]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[428]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[429]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[431]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[432]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[434]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[436]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[439]`
Mówca: **Symon Holl**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[440]`
Mówca: **Nia Morgna**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[441]`
Mówca: **Ciara Walda**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[442]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`
  - -> `[444]`

### Węzeł `[443]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[444]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[447]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[451]`
Mówca: **Gus Manger**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[452]`
Mówca: **Symon Holl**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[453]`
Mówca: **Nia Morgna**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[454]`
Mówca: **Ciara Walda**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[455]`
Mówca: **Gus Manger**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[457]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[459]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[460]`
**[WYBÓR GRACZA: ""I see. You are trying to sabotage me before the elections.""]** — Mówca: **Player**
> ""I see. You are trying to sabotage me before the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[461]`
**[WYBÓR GRACZA: ""Your resignation? What is the meaning of this?""]** — Mówca: **Player**
> ""Your resignation? What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[462]`
Mówca: **Symon Holl**
> ""That is not why. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[463]`
Mówca: **Nia Morgna**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[464]`
Mówca: **Ciara Walda**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[465]`
Mówca: **Gus Manger**
> ""That is not why. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[467]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[469]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[470]`
Mówca: **Nia Morgna**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[471]`
Mówca: **Ciara Walda**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[472]`
Mówca: **Gus Manger**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[525]`
  - -> `[488]`

### Węzeł `[473]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[475]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[476]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[478]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[479]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[481]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[482]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[484]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[485]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[487]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[488]`
**[WYBÓR GRACZA: ""Talk to me. What can I do? How can I help you better?""]** — Mówca: **Player**
> ""Talk to me. What can I do? How can I help you better?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[489]`
Mówca: **Symon Holl**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[491]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[493]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[497]`
Mówca: **Gus Manger**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[498]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[500]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[501]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[503]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[504]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[506]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[507]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[509]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[510]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[512]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[513]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`
  - -> `[515]`

### Węzeł `[514]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[515]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[518]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[519]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[521]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[522]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[524]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[525]`
**[WYBÓR GRACZA: ""You're betraying me, then.""]** — Mówca: **Player**
> ""You're betraying me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[526]`
**[WYBÓR GRACZA: ""But why? What are your reasons?""]** — Mówca: **Player**
> ""But why? What are your reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[527]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[528]`
Mówca: **Ciara Walda**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[529]`
Mówca: **Ciara Walda**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`
  - -> `[532]`

### Węzeł `[530]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at one point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at one point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[531]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[532]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to better this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to better this country, then you don't deserve to be in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[533]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[535]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[536]`
Mówca: **Ciara Walda**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[537]`
Mówca: **Ciara Walda**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[538]`
Mówca: **Ciara Walda**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[539]`
Mówca: **Ciara Walda**
> ""How could you do create the Secret State Police? How dare you attack the very values this country stands on? You will go down the history as a dictator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[540]`
Mówca: **Ciara Walda**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[541]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`
  - -> `[543]`

### Węzeł `[542]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[543]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[544]`
Mówca: **Ciara Walda**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Ciara Walda**
> ""This is a direct breach of democratic process and you are responsible for destroying lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[546]`
Mówca: **Ciara Walda**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[547]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[548]`
Mówca: **Ciara Walda**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[549]`
Mówca: **Ciara Walda**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[547]`
  - -> `[556]`

### Węzeł `[550]`
Mówca: **Ciara Walda**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Ciara Walda**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[552]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: ((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: ((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[554]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)))*
- **Warunek (`conditionsString`):** `(((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[555]`
Mówca: **Ciara Walda**
> ""Your puppeteers have you so brainwashed that you forgot that you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[556]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[557]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[559]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[562]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[563]`
Mówca: **Nia Morgna**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`
  - -> `[567]`
  - -> `[568]`

### Węzeł `[564]`
Mówca: **Nia Morgna**
> ""How could you create the Secret State Police? How dare you attack the very values this country stands on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Nia Morgna**
> ""This is a direct breach of the democratic process. You are responsible for destroying lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[566]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at some point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[567]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[568]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[569]`
Mówca: **Nia Morgna**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[570]`
Mówca: **Nia Morgna**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Nia Morgna**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[572]`
Mówca: **Nia Morgna**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[573]`
Mówca: **Nia Morgna**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[578]`
  - -> `[579]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
> ""Your creation of the Secret State Police is a direct breach of the democratic process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
> ""Lives were destroyed using this completely illegal organisation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at one point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at one point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[578]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[579]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
> ""Unfortunately, that is not the problem, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
> ""This seems to serve the position of President more than the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
> ""You have changed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[584]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[587]`
Mówca: **Ciara Walda**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[588]`
Mówca: **Ciara Walda**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[591]`
  - -> `[593]`

### Węzeł `[589]`
Mówca: **Ciara Walda**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[590]`
Mówca: **Ciara Walda**
> ""Not until we said our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[591]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[592]`
Mówca: **Ciara Walda**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[593]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[594]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[595]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[596]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`
  - -> `[599]`
  - -> `[601]`

### Węzeł `[597]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[598]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[599]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[600]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[601]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[602]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[603]`
Mówca: **Nia Morgna**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[604]`
Mówca: **Nia Morgna**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[605]`
Mówca: **Nia Morgna**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[606]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[607]`
Mówca: **Nia Morgna**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[608]`
Mówca: **Nia Morgna**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[609]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[610]`
Mówca: **Nia Morgna**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`
  - -> `[609]`
  - -> `[612]`

### Węzeł `[611]`
Mówca: **Nia Morgna**
> ""Your puppeteers have you so brainwashed that you forgot that you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[612]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[613]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`
  - -> `[615]`

### Węzeł `[614]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[615]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[616]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[618]`

### Węzeł `[617]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[618]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[619]`
Mówca: **Narrator**
> "I looked at their determined faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[620]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[622]`

### Węzeł `[621]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[622]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`

### Węzeł `[624]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[625]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[626]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`
  - -> `[628]`

### Węzeł `[627]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[628]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[629]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`
  - -> `[631]`

### Węzeł `[630]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[631]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[632]`
Mówca: **Narrator**
> "I looked at Ciara's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[637]`

### Węzeł `[633]`
Mówca: **Narrator**
> "I looked at Nia's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[637]`

### Węzeł `[634]`
Mówca: **Narrator**
> "I looked at Symon's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[637]`

### Węzeł `[635]`
Mówca: **Narrator**
> "I looked at Gus's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Narrator**
> "I looked at Paskal's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[637]`

### Węzeł `[637]`
**[WYBÓR GRACZA: ""I accept your resignation. Now get out of my face.""]** — Mówca: **Player**
> ""I accept your resignation. Now get out of my face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[638]`
**[WYBÓR GRACZA: ""I have no choice but to accept your resignation.""]** — Mówca: **Player**
> ""I have no choice but to accept your resignation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Narrator**
> "Paskal and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[640]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[642]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[643]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`
  - -> `[645]`

### Węzeł `[644]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[645]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[646]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[648]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[649]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[651]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[652]`
Mówca: **Narrator**
> "Ciara and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[653]`
Mówca: **Narrator**
> "Gus and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[654]`
Mówca: **Narrator**
> "Nia and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Narrator**
> "Symon and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[656]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_A_Resignations = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_A_Resignations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[657]`
Mówca: **Narrator**
> "Ciara was too radical for this country anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[658]`
Mówca: **Narrator**
> "Symon had failed his job and could always be replaced by another expert. His departure wouldn't be felt and the damage he has done won't be forgotten."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[659]`
Mówca: **Narrator**
> "Paskal's heart was at the right place and it's sad that he is leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[660]`
Mówca: **Narrator**
> "Mr. Manger didn't leave much of a mark both positive and negative during his time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[661]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`
  - -> `[663]`

### Węzeł `[662]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_GusManger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[663]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_GusManger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[664]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`
  - -> `[666]`

### Węzeł `[665]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[666]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[667]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_SymonHoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[669]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_SymonHoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[670]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_CiaraWalda == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[672]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_CiaraWalda == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[673]`
Mówca: **Narrator**
> "People come and people go. Such is life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[674]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Fired_Symon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`
  - -> `[676]`

### Węzeł `[675]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Fired_Symon == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_Symon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[676]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_Symon == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_Symon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[677]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: Jump to: [SymonFired])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[678]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: SymonFired)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[679]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Resignations_Ciara = true;
BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Ciara"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[680]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Resignations_Gus = true;
BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_GusManger = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Gus"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[681]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Resignations_Nia = true;
BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Nia"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`

### Węzeł `[682]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Resignations_Paskal = true;
BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Paskal"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[683]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_Resignations_Symon = true;
BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_SymonHoll = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Symon"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_SymonHoll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[684]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`
  - -> `[686]`

### Węzeł `[685]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations >= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[686]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_Resignations_One = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_One"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[688]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[690]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[691]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_LT_Resignations_TooMany = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_TooMany"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[693]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`
  - -> `[695]`

### Węzeł `[694]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[695]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[696]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne = true;
BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[697]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`
  - -> `[699]`

### Węzeł `[698]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_PaskalBeniwoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[699]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_PaskalBeniwoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
> ""Even though you acted against the epidemic which saved millions of Sords, I cannot and will not stand with your abuse of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[701]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Pandemic_Severity >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Pandemic_Severity >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Pandemic_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[703]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Pandemic_Severity >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Pandemic_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
> ""The things you did behind closed doors shook me to my bones when the news came to my knowledge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
> ""Even worst is the things you did behind closed doors. It shook me to my bones when I heard of the dreadful news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
> ""You may have your reasons, Mr. President, that it is for the greater good. But the same line of reasoning will simply lead to more atrocious actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[707]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`
  - -> `[709]`

### Węzeł `[708]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[709]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[710]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`
  - -> `[712]`

### Węzeł `[711]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3  and  Variable["BaseGame.Situation_Law_MediaCensored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3  and  Variable["BaseGame.Situation_Law_MediaCensored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[713]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[714]`
Mówca: **Narrator**
> "Ciara was a great asset to the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[715]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_ModernEducationTechniques == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`
  - -> `[717]`

### Węzeł `[716]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_ModernEducationTechniques == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_ModernEducationTechniques == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[718]`
Mówca: **Narrator**
> "Ciara had accomplished the difficult education reforms. A task many would have failed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[719]`
Mówca: **Narrator**
> "Her ideas were beyond acceptable for the conservative base of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[720]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Democratic"] < -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[722]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Democratic"] < -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[723]`
Mówca: **Narrator**
> "We could have established much more with the Ministry of Justice. Her departure will be felt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[724]`
Mówca: **Narrator**
> "Nia was a true moralist. The world would never be perfect or just enough for her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[725]`
Mówca: **Narrator**
> "She just didn't have the guts to do what was necessary to make Sordland a better place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[726]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`
  - -> `[728]`

### Węzeł `[727]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[728]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[729]`
Mówca: **Narrator**
> "Mr. Holl achieved the great economic miracle but still decided to leave. It will be a saddening loss for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[730]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishRecovery == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[732]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishRecovery == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[733]`
Mówca: **Narrator**
> "He was a true bureaucrat with clear purpose. I respected that about Holl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[734]`
Mówca: **Narrator**
> "My skepticism about Symon had never ceased and this departure was expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[735]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`
  - -> `[737]`

### Węzeł `[736]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true  or  Variable["BaseGame.Turn05_P_Underhall"] == true  or  Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[737]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true  or  Variable["BaseGame.Turn05_P_Underhall"] == true  or  Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[738]`
Mówca: **Narrator**
> "We got the L-1 project completed with Gus and the mark of that investment was felt in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[739]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicPrevented == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`
  - -> `[741]`

### Węzeł `[740]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_EpidemicPrevented == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicPrevented"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[741]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_EpidemicPrevented == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicPrevented"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[742]`
Mówca: **Narrator**
> "Gus provided great investment opportunities but outside of that did little to contribute to the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[743]`
Mówca: **Narrator**
> "Gus was nothing but a leech that survived on connections alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[744]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_RailwayProject == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_RailwayProject == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_RailwayProject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[746]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_RailwayProject == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_RailwayProject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[747]`
Mówca: **Narrator**
> "Mr. Beniwoll helped prevent the Polio Crisis from becoming a regional epidemic or even a global pandemic. For this I will remember them well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[748]`
Mówca: **Narrator**
> "Paskal wasn't that useful to the administration anyway. The polio crisis wasn't fixed during the term and the damages of that were felt in the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[749]`
Mówca: **Narrator**
> "Paskal could have done much more but decided to leave the administration behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[750]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`
  - -> `[752]`

### Węzeł `[751]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[752]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`

### Węzeł `[753]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[755]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[756]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`
  - -> `[758]`

### Węzeł `[757]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[758]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[759]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[760]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[761]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`
  - -> `[763]`

### Węzeł `[762]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[763]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[764]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[765]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`
  - -> `[767]`

### Węzeł `[766]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[767]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[768]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`
  - -> `[773]`
  - -> `[772]`

### Węzeł `[769]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`
  - -> `[771]`

### Węzeł `[770]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[771]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[772]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[773]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[774]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[775]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[776]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`
  - -> `[778]`

### Węzeł `[777]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[778]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[779]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`
  - -> `[781]`

### Węzeł `[780]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[781]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[782]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Judiciary", "Position_NotableJustice_3", "Judiciary_NotableJustice_ArnoldDalton");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Judiciary","Position_NotableJustice_3","Judiciary_NotableJustice_ArnoldDalton");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[783]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_EducationMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_EducationMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[784]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_AgricultureMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_AgricultureMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[785]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_HealthMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_HealthMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[786]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_JusticeMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_JusticeMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[787]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: AssignConnection("Page_Cabinet", "Position_EconomyMinister", "");)*
- **Efekt (`userScript`):** `AssignConnection("Page_Cabinet","Position_EconomyMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[788]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Paskal Beniwoll","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[789]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Gus Manger", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Gus Manger","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[790]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Symon Holl", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Symon Holl","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[791]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Nia Morgna", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[792]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Ciara Walda", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Ciara Walda","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[793]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`

### Węzeł `[794]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[795]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[796]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`
  - -> `[798]`

### Węzeł `[797]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[798]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[799]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Ciara Walda", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Ciara Walda","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[800]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Nia Morgna", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[801]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Symon Holl", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Symon Holl","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[802]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`
  - -> `[804]`

### Węzeł `[803]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[804]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_EnT_SordishDepression == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[807]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_EnT_SordishDepression == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[808]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`
  - -> `[810]`

### Węzeł `[809]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[810]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[811]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Gus Manger", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Gus Manger","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[812]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`
  - -> `[814]`

### Węzeł `[813]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[814]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[815]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Paskal Beniwoll","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[816]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`
  - -> `[818]`

### Węzeł `[817]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true  or  Variable["BaseGame.Policy_Welfare_HealthReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[818]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true  or  Variable["BaseGame.Policy_Welfare_HealthReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[819]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`
  - -> `[821]`

### Węzeł `[820]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[821]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[822]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[823]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`
  - -> `[825]`

### Węzeł `[824]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[825]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[826]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`
  - -> `[828]`

### Węzeł `[827]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[828]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[829]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`
  - -> `[831]`

### Węzeł `[830]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[831]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[832]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family in Anraka. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[833]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family in Rizia. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[834]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`
  - -> `[836]`

### Węzeł `[835]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[836]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[837]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`
  - -> `[839]`

### Węzeł `[838]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[839]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[840]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`
  - -> `[842]`

### Węzeł `[841]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[842]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
